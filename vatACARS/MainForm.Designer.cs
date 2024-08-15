using vatACARSControls;

namespace vatACARS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnl_control = new Panel();
            btn_settings = new Button();
            lbl_title = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            btn_connect = new RoundedButton();
            pnl_control.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_control
            // 
            pnl_control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_control.BackColor = Color.FromArgb(9, 9, 9);
            pnl_control.Controls.Add(btn_settings);
            pnl_control.Controls.Add(lbl_title);
            pnl_control.Controls.Add(btnClose);
            pnl_control.Controls.Add(btnMinimize);
            pnl_control.Location = new Point(0, 0);
            pnl_control.Name = "pnl_control";
            pnl_control.Size = new Size(696, 35);
            pnl_control.TabIndex = 0;
            pnl_control.MouseDown += pnl_control_MouseDown;
            pnl_control.MouseMove += pnl_control_MouseMove;
            pnl_control.MouseUp += pnl_control_MouseUp;
            // 
            // btn_settings
            // 
            btn_settings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_settings.Cursor = Cursors.Hand;
            btn_settings.FlatAppearance.BorderColor = Color.FromArgb(9, 9, 9);
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_settings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.ForeColor = Color.White;
            btn_settings.Image = (Image)resources.GetObject("btn_settings.Image");
            btn_settings.Location = new Point(618, 5);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(27, 26);
            btn_settings.TabIndex = 3;
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // lbl_title
            // 
            lbl_title.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            lbl_title.ForeColor = SystemColors.ButtonHighlight;
            lbl_title.Location = new Point(3, 3);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(110, 26);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "vatACARS";
            lbl_title.TextAlign = ContentAlignment.MiddleLeft;
            lbl_title.MouseDown += pnl_control_MouseDown;
            lbl_title.MouseMove += pnl_control_MouseMove;
            lbl_title.MouseUp += pnl_control_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(9, 9, 9);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(666, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 26);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(9, 9, 9);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(642, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(27, 26);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btn_connect
            // 
            btn_connect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_connect.BackColor = Color.FromArgb(59, 130, 246);
            btn_connect.CornerRadius = 8;
            btn_connect.Cursor = Cursors.Hand;
            btn_connect.FlatAppearance.BorderColor = Color.FromArgb(9, 9, 9);
            btn_connect.FlatAppearance.BorderSize = 0;
            btn_connect.FlatAppearance.MouseDownBackColor = Color.FromArgb(106, 155, 253);
            btn_connect.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 155, 253);
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.ForeColor = Color.White;
            btn_connect.Location = new Point(583, 376);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(101, 34);
            btn_connect.TabIndex = 4;
            btn_connect.Text = "CONNECT";
            btn_connect.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(696, 422);
            Controls.Add(btn_connect);
            Controls.Add(pnl_control);
            Font = new Font("Montserrat SemiBold", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(191, 166);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pilot Client";
            Load += MainForm_Load;
            LocationChanged += MainForm_LocationChanged;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
            Resize += MainForm_Resize;
            pnl_control.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnl_control;
        private Button btnClose;
        private Button btnMinimize;

        #endregion // End of Windows Form Designer generated code

        private Label lbl_title;
        private Button btn_settings;
        private RoundedButton btn_connect;
    }
}
