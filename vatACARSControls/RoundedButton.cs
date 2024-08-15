using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace vatACARSControls
{
    public class RoundedButton : Button
    {
        private int _cornerRadius = 8; 

        [Category("Appearance")]
        [Description("The radius of the button's corners.")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                if (_cornerRadius != value)
                {
                    _cornerRadius = value;
                    Invalidate(); 
                    UpdateRegion();
                }
            }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Padding = new Padding(0);
            this.TextAlign = ContentAlignment.MiddleCenter; 
            UpdateRegion(); 
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, _cornerRadius * 2, _cornerRadius * 2, 180, 90);
                path.AddArc(Width - _cornerRadius * 2, 0, _cornerRadius * 2, _cornerRadius * 2, 270, 90);
                path.AddArc(Width - _cornerRadius * 2, Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90);
                path.AddArc(0, Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                using (Pen pen = new Pen(ForeColor))
                {
                    pevent.Graphics.DrawPath(pen, path);
                }
            }

            base.OnPaint(pevent);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, _cornerRadius * 2, _cornerRadius * 2, 180, 90);
                path.AddArc(Width - _cornerRadius * 2, 0, _cornerRadius * 2, _cornerRadius * 2, 270, 90);
                path.AddArc(Width - _cornerRadius * 2, Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 0, 90);
                path.AddArc(0, Height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }
}
