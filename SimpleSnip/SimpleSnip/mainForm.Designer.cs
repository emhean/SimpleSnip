namespace SimpleSnip
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.windowBorder = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.snipRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.settingsBtn = new System.Windows.Forms.Button();
            this.iconPbx = new System.Windows.Forms.PictureBox();
            this.horizontalLinePbx = new System.Windows.Forms.PictureBox();
            this.verticalLinePbx = new System.Windows.Forms.PictureBox();
            this.snipBtn = new System.Windows.Forms.Button();
            this.snipAreaPbx = new System.Windows.Forms.PictureBox();
            this.autoSnip = new System.Windows.Forms.Timer(this.components);
            this.windowBorder.SuspendLayout();
            this.snipRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalLinePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalLinePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snipAreaPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // windowBorder
            // 
            this.windowBorder.BackColor = System.Drawing.Color.Green;
            this.windowBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowBorder.Controls.Add(this.closeButton);
            this.windowBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBorder.Location = new System.Drawing.Point(0, 0);
            this.windowBorder.Name = "windowBorder";
            this.windowBorder.Size = new System.Drawing.Size(442, 25);
            this.windowBorder.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(409, -4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // snipRightClick
            // 
            this.snipRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAs});
            this.snipRightClick.Name = "snipRightClick";
            this.snipRightClick.Size = new System.Drawing.Size(126, 26);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(125, 22);
            this.saveAs.Text = "Save As...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.BackColor = System.Drawing.Color.White;
            this.notifyLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.notifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyLabel.Location = new System.Drawing.Point(8, 344);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(234, 20);
            this.notifyLabel.TabIndex = 7;
            this.notifyLabel.Text = "_________________________";
            this.notifyLabel.Visible = false;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 16;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.BackColor = System.Drawing.Color.Green;
            this.settingsBtn.BackgroundImage = global::SimpleSnip.Properties.Resources.settings;
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsBtn.ContextMenuStrip = this.snipRightClick;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Location = new System.Drawing.Point(398, 332);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(32, 32);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Visible = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // iconPbx
            // 
            this.iconPbx.BackColor = System.Drawing.Color.Green;
            this.iconPbx.BackgroundImage = global::SimpleSnip.Properties.Resources.SimpleSnip;
            this.iconPbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPbx.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.iconPbx.Image = global::SimpleSnip.Properties.Resources.move;
            this.iconPbx.Location = new System.Drawing.Point(1, 1);
            this.iconPbx.Name = "iconPbx";
            this.iconPbx.Size = new System.Drawing.Size(24, 24);
            this.iconPbx.TabIndex = 5;
            this.iconPbx.TabStop = false;
            this.iconPbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPbx_MouseDown);
            this.iconPbx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconPbx_MouseMove);
            this.iconPbx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconPbx_MouseUp);
            // 
            // horizontalLinePbx
            // 
            this.horizontalLinePbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalLinePbx.BackColor = System.Drawing.Color.Green;
            this.horizontalLinePbx.BackgroundImage = global::SimpleSnip.Properties.Resources.horizontalLine1;
            this.horizontalLinePbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horizontalLinePbx.Location = new System.Drawing.Point(-24, 185);
            this.horizontalLinePbx.Name = "horizontalLinePbx";
            this.horizontalLinePbx.Size = new System.Drawing.Size(535, 1);
            this.horizontalLinePbx.TabIndex = 3;
            this.horizontalLinePbx.TabStop = false;
            // 
            // verticalLinePbx
            // 
            this.verticalLinePbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.verticalLinePbx.BackColor = System.Drawing.Color.Green;
            this.verticalLinePbx.BackgroundImage = global::SimpleSnip.Properties.Resources.verticalLine1;
            this.verticalLinePbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verticalLinePbx.Location = new System.Drawing.Point(220, -77);
            this.verticalLinePbx.Name = "verticalLinePbx";
            this.verticalLinePbx.Size = new System.Drawing.Size(1, 489);
            this.verticalLinePbx.TabIndex = 2;
            this.verticalLinePbx.TabStop = false;
            // 
            // snipBtn
            // 
            this.snipBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.snipBtn.BackgroundImage = global::SimpleSnip.Properties.Resources.tback1;
            this.snipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snipBtn.ContextMenuStrip = this.snipRightClick;
            this.snipBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snipBtn.FlatAppearance.BorderSize = 0;
            this.snipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snipBtn.Location = new System.Drawing.Point(12, 38);
            this.snipBtn.Name = "snipBtn";
            this.snipBtn.Size = new System.Drawing.Size(64, 32);
            this.snipBtn.TabIndex = 1;
            this.snipBtn.UseVisualStyleBackColor = false;
            this.snipBtn.Click += new System.EventHandler(this.snipBtn_Click);
            this.snipBtn.MouseEnter += new System.EventHandler(this.snipBtn_MouseEnter);
            this.snipBtn.MouseLeave += new System.EventHandler(this.snipBtn_MouseLeave);
            // 
            // snipAreaPbx
            // 
            this.snipAreaPbx.BackColor = System.Drawing.Color.Green;
            this.snipAreaPbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snipAreaPbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snipAreaPbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snipAreaPbx.Location = new System.Drawing.Point(0, 0);
            this.snipAreaPbx.Name = "snipAreaPbx";
            this.snipAreaPbx.Size = new System.Drawing.Size(442, 373);
            this.snipAreaPbx.TabIndex = 0;
            this.snipAreaPbx.TabStop = false;
            this.snipAreaPbx.Click += new System.EventHandler(this.snipAreaPbx_Click);
            // 
            // autoSnip
            // 
            this.autoSnip.Interval = 9999;
            this.autoSnip.Tick += new System.EventHandler(this.autoSnip_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 373);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.iconPbx);
            this.Controls.Add(this.windowBorder);
            this.Controls.Add(this.horizontalLinePbx);
            this.Controls.Add(this.verticalLinePbx);
            this.Controls.Add(this.snipBtn);
            this.Controls.Add(this.snipAreaPbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleSnip";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.windowBorder.ResumeLayout(false);
            this.snipRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalLinePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalLinePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snipAreaPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snipAreaPbx;
        private System.Windows.Forms.Button snipBtn;
        private System.Windows.Forms.PictureBox verticalLinePbx;
        private System.Windows.Forms.PictureBox horizontalLinePbx;
        private System.Windows.Forms.Panel windowBorder;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox iconPbx;
        private System.Windows.Forms.ContextMenuStrip snipRightClick;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Timer autoSnip;
    }
}

