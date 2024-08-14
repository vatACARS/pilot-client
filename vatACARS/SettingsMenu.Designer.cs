using vatACARSControls;

namespace vatACARS
{
    partial class SettingsMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            pnl_control = new Panel();
            lbl_title = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            tbx_token = new TextBox();
            lbl_token = new Label();
            lbl_volume = new Label();
            slr_volume = new Slider(components);
            pnl_control.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_control
            // 
            pnl_control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_control.BackColor = Color.FromArgb(9, 9, 9);
            pnl_control.Controls.Add(lbl_title);
            pnl_control.Controls.Add(btnClose);
            pnl_control.Controls.Add(btnMinimize);
            pnl_control.Location = new Point(0, 0);
            pnl_control.Name = "pnl_control";
            pnl_control.Size = new Size(305, 35);
            pnl_control.TabIndex = 0;
            pnl_control.MouseDown += pnl_control_MouseDown;
            pnl_control.MouseMove += pnl_control_MouseMove;
            pnl_control.MouseUp += pnl_control_MouseUp;
            // 
            // lbl_title
            // 
            lbl_title.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            lbl_title.ForeColor = SystemColors.ButtonHighlight;
            lbl_title.Location = new Point(3, 3);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(110, 26);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "Settings";
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
            btnClose.Location = new Point(275, 5);
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
            btnMinimize.Location = new Point(251, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(27, 26);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // tbx_token
            // 
            tbx_token.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_token.BackColor = Color.White;
            tbx_token.BorderStyle = BorderStyle.FixedSingle;
            tbx_token.Font = new Font("Montserrat SemiBold", 12F);
            tbx_token.Location = new Point(90, 41);
            tbx_token.Name = "tbx_token";
            tbx_token.PasswordChar = '*';
            tbx_token.Size = new Size(203, 27);
            tbx_token.TabIndex = 1;
            tbx_token.TextChanged += tbx_token_TextChanged;
            // 
            // lbl_token
            // 
            lbl_token.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            lbl_token.ForeColor = SystemColors.ButtonHighlight;
            lbl_token.Location = new Point(3, 38);
            lbl_token.Name = "lbl_token";
            lbl_token.Size = new Size(81, 26);
            lbl_token.TabIndex = 3;
            lbl_token.Text = "Token:";
            lbl_token.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_volume
            // 
            lbl_volume.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            lbl_volume.ForeColor = SystemColors.ButtonHighlight;
            lbl_volume.Location = new Point(3, 74);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(81, 26);
            lbl_volume.TabIndex = 4;
            lbl_volume.Text = "Volume:";
            lbl_volume.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // slr_volume
            // 
            slr_volume.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            slr_volume.BackColor = Color.FromArgb(38, 38, 38);
            slr_volume.CurrentValue = 100;
            slr_volume.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            slr_volume.ForeColor = Color.White;
            slr_volume.Location = new Point(90, 74);
            slr_volume.MaxValue = 100;
            slr_volume.MinValue = 0;
            slr_volume.Name = "slr_volume";
            slr_volume.Size = new Size(203, 26);
            slr_volume.TabIndex = 5;
            slr_volume.ValueChanged += slr_volume_ValueChanged;
            slr_volume.ValueLabelClick += slr_volume_ValueLabelClick;
            // 
            // SettingsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(305, 401);
            Controls.Add(slr_volume);
            Controls.Add(lbl_volume);
            Controls.Add(lbl_token);
            Controls.Add(tbx_token);
            Controls.Add(pnl_control);
            Font = new Font("Montserrat SemiBold", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(191, 166);
            Name = "SettingsMenu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += SettingsMenu_Load;
            Shown += SettingsMenu_Shown;
            MouseDown += SettingsMenu_MouseDown;
            MouseMove += SettingsMenu_MouseMove;
            MouseUp += SettingsMenu_MouseUp;
            pnl_control.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnl_control;
        private Button btnClose;
        private Button btnMinimize;

        #endregion // End of Windows Form Designer generated code

        private Label lbl_title;
        private TextBox tbx_token;
        private Label lbl_token;
        private Label lbl_volume;
        private Slider slr_volume;
    }
}
