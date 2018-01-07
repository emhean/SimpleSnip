using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSnip
{
    public partial class mainForm : Form
    {
        private int notifyFrames, snipMode = 0,
            maxSnips = 999;
        private Size? _mouseGrabOffset;
        private Size size;

        public mainForm()
        {
            InitializeComponent();
            // Start size as of now is 450 width, 400 height.
            verticalLinePbx.Location = new Point((Width / 2) - (verticalLinePbx.Width), 0);
            horizontalLinePbx.Location = new Point(0, (Height / 2) - (horizontalLinePbx.Height));
            // Make sizable but still remove upper border.
            this.ControlBox = false;
            this.Text = String.Empty;

            // Settings
            var settingsPath = "settings.txt";
            var comment = "#";
            if (File.Exists(settingsPath))
            {
                var lines = File.ReadAllLines("settings.txt");
                int c = 0;
                for(int i = 0; i < lines.Length; ++i)
                {
                    if(lines[i].StartsWith(comment))
                    {
                        continue;
                    }

                    if (lines[i].StartsWith("MODE="))
                    {
                        try
                        {
                            snipMode = Convert.ToInt16(lines[i].Remove(0, "MODE=".Length));
                        }
                        catch
                        {
                            snipMode = 0;
                        }
                    }

                    if (lines[i].StartsWith("INTERVAL="))
                    {
                        if(snipMode == 1)
                        {
                            try
                            {
                                autoSnip.Interval = // SECONDS
                                    Convert.ToInt16(lines[i].Remove(0, "INTERVAL=".Length)) * 10;
                                autoSnip.Start();
                            }
                            catch
                            {
                                autoSnip = null;
                            }
                            // break; // Hardcoded exit because no other implementation
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Take the 'snip' screenshot.
        /// </summary>
        private void snipAreaPbx_Click(object sender, EventArgs e)
        {
            saveSnip(null);
        }

        /// <summary>
        /// Capture a 'snip' and save it.
        /// </summary>
        private void saveSnip(string fileName = null, bool errorMessage = true)
        {
            size = new Size(snipAreaPbx.Width, snipAreaPbx.Height); // Set size
            try
            {
                // Create a new bitmap.
                var bmpScreenshot = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);

                // Create a graphics object from the bitmap.
                var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                // Take the screenshot.
                gfxScreenshot.CopyFromScreen(DesktopLocation.X, DesktopLocation.Y, 0, 0, size, CopyPixelOperation.SourceCopy);

                // Save the 'snip'.
                if (fileName != null) // Save by choice.
                {
                    saveSnip(bmpScreenshot, fileName); // Save
                }
                else
                {
                    // Save the screenshot by algorithm.
                    for (int i = 0; i < maxSnips; i++) // Supports up to 999 screenshots
                    {
                        fileName = $"snips/screenshot_{i}.png";
                        if (File.Exists(fileName))
                        {
                            continue;
                        }
                        else
                        {
                            saveSnip(bmpScreenshot, fileName); // Save
                            break;
                        }
                    }
                }
            }
            catch
            {
                if (errorMessage)
                {
                    MessageBox.Show("An unknown error occurred when trying to save the snip.");
                }
            }
        }

        /// <summary>
        /// Get the count of default-named 'snips' in target folder.
        /// </summary>
        private int snipCount(string folderPath)
        {
            for (int i = 0; i < maxSnips; i++)
            {
                if (File.Exists($"snips/screenshot_{i}.png"))
                {
                    continue;
                }
                else
                {
                    return i; // Return the EXACT count.
                }
            }
            return maxSnips; // Return the user-set max amount. No more space!
        }

        /// <summary>
        /// Save the snip and show notification.
        /// </summary>
        private void saveSnip(Bitmap bitmap, string fileName)
        {
            bitmap.Save(fileName, ImageFormat.Png);

            // Notify
            var sB = new StringBuilder("Saved to: ");
            sB.Append(fileName);
            notifyLabel.Text = sB.ToString();
            notifyLabel.Visible = true;
            notifyFrames = 90;
            notifyLabel.Tag = fileName;

            update.Start(); // Background worker for notification and maybe some other things.
        }

        /// <summary>
        /// Get a 'snip' filename by current time.
        /// </summary>
        private string getSnipFileName()
        {
            var sB = new StringBuilder();
            sB.Append(DateTime.UtcNow);
            sB.Append("_");
            sB.Append(DateTime.UtcNow.Date);
            return sB.ToString();
        }

        /// <summary>
        /// The button to 'snip' the screen.
        /// </summary>
        private void snipBtn_Click(object sender, EventArgs e)
        {
            snipAreaPbx_Click(null, EventArgs.Empty);
        }


        /// <summary>
        /// Change color on hovering
        /// </summary>
        private void snipBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.DarkGreen;
        }

        /// <summary>
        /// Change color back to normal
        /// </summary>
        private void snipBtn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.LimeGreen;
        }


        /// <summary>
        /// Close the program.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        /// <summary>
        /// Lets you choose directory to save to before the actual 'snip' is taken.
        /// </summary>
        private void saveAs_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog()
            {
                Title = "Save As...",
                DefaultExt = ".png",
                FileName = "snip.png",
                CheckFileExists = false,

            };
            fileDialog.ShowDialog();
            if (fileDialog.FileName != null)
            {
                saveSnip(fileDialog.FileName, errorMessage: false);
            }
        }

        /// <summary>
        /// Move window logic
        /// </summary>
        private void iconPbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseGrabOffset = new Size(e.Location);
            }
        }
        /// <summary>
        /// Move window logic
        /// </summary>
        private void iconPbx_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseGrabOffset.HasValue)
            {
                this.Location = Cursor.Position - _mouseGrabOffset.Value;
            }
        }
        /// <summary>
        /// Move window logic
        /// </summary>
        private void iconPbx_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseGrabOffset = null;
        }

        /// <summary>
        /// When MODE=1 in settings.txt.
        /// </summary>
        private void autoSnip_Tick(object sender, EventArgs e)
        {
            saveSnip(fileName: null, errorMessage: false);
        }

        /// <summary>
        /// Show the settings screen.
        /// </summary>
        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Background worker.
        /// </summary>
        private void update_Tick(object sender, EventArgs e)
        {
            if (notifyFrames != 0)
            {
                notifyFrames--;
                if (notifyFrames == 0)
                {
                    notifyLabel.Visible = false;
                    update.Stop();
                }
            }
        }
    }
}
