using System;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace vatACARS
{
    public partial class UpdatePopupForm : Form
    {
        private const int BorderWidth = 4;
        private const int CornerRadius = 8;
        private bool _isResizing = false;
        private Point _mouseDownLocation;
        private Font? _semiBoldFont;
        private Color BorderColor = Color.FromArgb(9, 9, 9);
        public UpdatePopupForm()
        {
            InitializeComponent();
            LoadFont();
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Redraw on resize

            lbl_version.Text = string.Format("Version {0}", VersionChecker.updateInfo.version.ToString());
            lbl_changes.Text = string.Join("\n", VersionChecker.updateInfo.Changes.ToArray());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw rounded corners with better quality
            using (var path = new GraphicsPath())
            {
                var rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);

                // Create rounded corners path
                path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90); // Top-left corner
                path.AddArc(rect.Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90); // Top-right corner
                path.AddArc(rect.Width - CornerRadius * 2, rect.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90); // Bottom-right corner
                path.AddArc(0, rect.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90); // Bottom-left corner
                path.CloseAllFigures();

                // Smooth drawing with high-quality settings
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);

                // Draw border
                using (var borderPen = new Pen(BorderColor, BorderWidth))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void LoadFont()
        {
            try
            {
                PrivateFontCollection privateFonts = new PrivateFontCollection();
                string fontPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Montserrat-SemiBold.ttf");
                privateFonts.AddFontFile(fontPath);
                _semiBoldFont = new Font(privateFonts.Families[0], 12f, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the font: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePopupForm_Load(object sender, EventArgs e)
        {
            SetFormRegion();
        }

        private void SetFormRegion()
        {
            using (var path = new GraphicsPath())
            {
                var rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);

                // Create rounded corners path
                path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90); // Top-left corner
                path.AddArc(rect.Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90); // Top-right corner
                path.AddArc(rect.Width - CornerRadius * 2, rect.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90); // Bottom-right corner
                path.AddArc(0, rect.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90); // Bottom-left corner
                path.CloseAllFigures();

                // Set form region to the rounded path
                this.Region = new Region(path);
            }
        }

        private void UpdatePopupForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdatePopupForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(
                    this.Location.X + (e.X - _mouseDownLocation.X),
                    this.Location.Y + (e.Y - _mouseDownLocation.Y)
                );
                this.Location = newLocation;
            }
        }

        private void UpdatePopupForm_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

    }
}
