using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace vatACARS
{
    public partial class SettingsMenu : Form
    {
        private const int _resizeBorder = 10;
        private const int BorderWidth = 4;
        private const int CornerRadius = 8;
        private bool _isResizing = false;
        private Point _mouseDownLocation;
        private ResizeDirection _resizeDirection = ResizeDirection.None;
        private Point _resizeStartPoint;
        private Font? _semiBoldFont;
        private Color BorderColor = Color.FromArgb(9, 9, 9);

        private int clickCount = 0;

        private int currentSoundIndex = 0;

        private List<string> soundQueue = new List<string>
        {
            "downlink",
            "uplink",
            "piloterror"
        };

        public SettingsMenu()
        {
            InitializeComponent();
            LoadFont();
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Redraw on resize
        }

        private enum ResizeDirection
        {
            None,
            Top,
            Bottom,
            Right,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var path = new GraphicsPath())
            {
                var rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);

                // Create rounded corners path
                path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90); // Top-left corner
                path.AddArc(rect.Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90); // Top-right corner
                path.AddArc(rect.Width - CornerRadius * 2, rect.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90); // Bottom-right corner
                path.AddArc(0, rect.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90); // Bottom-left corner
                path.CloseAllFigures();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Cursor GetCursorForResizeDirection(ResizeDirection direction)
        {
            return direction switch
            {
                ResizeDirection.TopLeft or ResizeDirection.BottomRight => Cursors.SizeNWSE,
                ResizeDirection.TopRight or ResizeDirection.BottomLeft => Cursors.SizeNESW,
                ResizeDirection.Top or ResizeDirection.Bottom => Cursors.SizeNS,
                ResizeDirection.Right => Cursors.SizeWE,
                _ => Cursors.Default
            };
        }

        private ResizeDirection GetResizeDirection(Point location)
        {
            if (location.X >= this.ClientSize.Width - _resizeBorder && location.Y <= _resizeBorder)
                return ResizeDirection.TopRight;
            if (location.X >= this.ClientSize.Width - _resizeBorder && location.Y >= this.ClientSize.Height - _resizeBorder)
                return ResizeDirection.BottomRight;
            if (location.Y <= _resizeBorder)
                return ResizeDirection.Top;
            if (location.Y >= this.ClientSize.Height - _resizeBorder)
                return ResizeDirection.Bottom;
            if (location.X >= this.ClientSize.Width - _resizeBorder)
                return ResizeDirection.Right;

            return ResizeDirection.None;
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

        private async Task PlayAllSounds()
        {
            // Play all sounds at once
            foreach (var sound in soundQueue)
            {
                AudioInterface.playSound(sound);
            }

            await Task.Delay(10);
        }

        private async Task PlayCurrentSound()
        {
            string soundToPlay = soundQueue[currentSoundIndex];
            AudioInterface.playSound(soundToPlay);
            await Task.Delay(10);
        }

        private void pnl_control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void pnl_control_MouseMove(object sender, MouseEventArgs e)
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

        private void pnl_control_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
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

                this.Region = new Region(path);
            }
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            SetFormRegion();
        }

        private void SettingsMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _resizeDirection != ResizeDirection.None)
            {
                _isResizing = true;
                _resizeStartPoint = e.Location;
                this.Cursor = GetCursorForResizeDirection(_resizeDirection);
            }
        }

        private void SettingsMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isResizing)
            {
                int deltaX = e.X - _resizeStartPoint.X;
                int deltaY = e.Y - _resizeStartPoint.Y;

                switch (_resizeDirection)
                {
                    case ResizeDirection.Top:
                        this.Top += deltaY;
                        this.Height -= deltaY;
                        break;

                    case ResizeDirection.Bottom:
                        this.Height += deltaY;
                        break;

                    case ResizeDirection.Right:
                        this.Width += deltaX;
                        break;

                    case ResizeDirection.TopRight:
                        this.Top += deltaY;
                        this.Width += deltaX;
                        this.Height -= deltaY;
                        break;

                    case ResizeDirection.BottomRight:
                        this.Width += deltaX;
                        this.Height += deltaY;
                        break;
                }

                _resizeStartPoint = e.Location;
                SetFormRegion();
                Invalidate();
            }
            else
            {
                _resizeDirection = GetResizeDirection(e.Location);
                this.Cursor = GetCursorForResizeDirection(_resizeDirection);
            }
        }

        private void SettingsMenu_MouseUp(object sender, MouseEventArgs e)
        {
            _isResizing = false;
            _resizeDirection = ResizeDirection.None;
            this.Cursor = Cursors.Default;
        }

        private void SettingsMenu_Shown(object sender, EventArgs e)
        {
            tbx_token.Text = Properties.Settings.Default.Token;
            slr_volume.CurrentValue = Properties.Settings.Default.Volume;
        }

        private void slr_volume_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Volume = slr_volume.CurrentValue;
            Properties.Settings.Default.Save();
        }

        private async void slr_volume_ValueLabelClick(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount == 10) // for funny :)
            {
                AudioInterface.playSound("help");
                clickCount = 0;
            }
            else if (soundQueue.Count > 0)
            {
                await PlayCurrentSound();
                currentSoundIndex = (currentSoundIndex + 1) % soundQueue.Count;
            }
        }

        private void tbx_token_TextChanged(object sender, EventArgs e)
        {
            if (tbx_token.Text.StartsWith("vAcV1-") && tbx_token.Text.Length == 32)
            {
                Properties.Settings.Default.Token = tbx_token.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}