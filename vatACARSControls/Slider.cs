using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace vatACARSControls
{
    public class Slider : UserControl
    {
        private int _currentValue;
        private int _maxValue;
        private int _minValue;
        private TrackBar trackBar;
        private Label valueLabel;

        public Slider()
        {
            _minValue = 0;
            _maxValue = 100;
            _currentValue = 0;
            InitializeComponent();
            InitializeSlider();
        }

        public Slider(IContainer container) : this()
        {
            container.Add(this);
        }

        // Define the ValueChanged event
        public event EventHandler ValueChanged;

        // Define the ValueLabelClick event
        public event EventHandler ValueLabelClick;

        [Category("Custom Properties")]
        public int CurrentValue
        {
            get => _currentValue;
            set
            {
                if (_currentValue != value)
                {
                    _currentValue = Math.Max(MinValue, Math.Min(MaxValue, value));
                    trackBar.Value = _currentValue;
                    valueLabel.Text = _currentValue.ToString();
                    OnValueChanged(EventArgs.Empty);
                }
            }
        }

        [Category("Custom Properties")]
        public int MaxValue
        {
            get => _maxValue;
            set
            {
                if (_maxValue != value)
                {
                    _maxValue = value;
                    trackBar.Maximum = value;
                    if (_currentValue > _maxValue)
                    {
                        UpdateCurrentValue(_maxValue);
                    }
                }
            }
        }

        [Category("Custom Properties")]
        public int MinValue
        {
            get => _minValue;
            set
            {
                if (_minValue != value)
                {
                    _minValue = value;
                    trackBar.Minimum = value;
                    if (_currentValue < _minValue)
                    {
                        UpdateCurrentValue(_minValue);
                    }
                }
            }
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        protected virtual void OnValueLabelClick(EventArgs e)
        {
            ValueLabelClick?.Invoke(this, e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "Slider";
            this.Size = new Size(200, 50);
            this.ResumeLayout(false);
        }

        private void InitializeSlider()
        {
            trackBar = new TrackBar
            {
                Minimum = _minValue,
                Maximum = _maxValue,
                Value = _currentValue,
                Dock = DockStyle.Fill,
                TickStyle = TickStyle.None,
                LargeChange = 10,
                SmallChange = 1
            };

            valueLabel = new Label
            {
                Text = _currentValue.ToString(),
                Dock = DockStyle.Right,
                Width = 50,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Default // Default cursor
            };

            trackBar.Scroll += TrackBar_Scroll;
            valueLabel.Click += ValueLabel_Click;
            valueLabel.MouseEnter += ValueLabel_MouseEnter;
            valueLabel.MouseLeave += ValueLabel_MouseLeave;

            this.Controls.Add(trackBar);
            this.Controls.Add(valueLabel);
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateCurrentValue(trackBar.Value);
        }

        private void UpdateCurrentValue(int value)
        {
            if (_currentValue != value)
            {
                _currentValue = value;
                valueLabel.Text = _currentValue.ToString();
                OnValueChanged(EventArgs.Empty);
            }
        }

        private void ValueLabel_Click(object sender, EventArgs e)
        {
            OnValueLabelClick(EventArgs.Empty);
        }

        private void ValueLabel_MouseEnter(object sender, EventArgs e)
        {
            valueLabel.Cursor = Cursors.Hand; // Change cursor to hand when mouse is over label
        }

        private void ValueLabel_MouseLeave(object sender, EventArgs e)
        {
            valueLabel.Cursor = Cursors.Default; // Change cursor back to default when mouse leaves label
        }
    }
}