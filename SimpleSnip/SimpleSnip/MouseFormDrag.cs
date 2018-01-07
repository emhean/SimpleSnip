using System;
using System.Drawing;
using System.Windows.Forms;

class MouseFormDragEventArgs : EventArgs
{
    public MouseFormDragEventArgs()
    {
    }

    public MouseButtons Button { get; set; }
    public Point Location { get; set; }
}

class MouseFormDrag
{
    private Size? _mouseGrabOffset;

    public MouseFormDrag()
    {
    }

    public Point? Location { get; set; }

    private void MouseDown(object sender, MouseFormDragEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            _mouseGrabOffset = new Size(e.Location);
        }
    }

    private void MouseMove(object sender, MouseFormDragEventArgs e)
    {
        if (_mouseGrabOffset.HasValue)
        {
            this.Location = Cursor.Position - _mouseGrabOffset.Value;
        }
    }

    private void MouseUp(object sender, MouseFormDragEventArgs e)
    {
        _mouseGrabOffset = null;
    }
}
