namespace vatACARS
{
    partial class UpdatePopupForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePopupForm));
            lbl_changes = new Label();
            lbl_version = new Label();
            pnl_control = new Panel();
            lbl_title = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            pnl_control.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_changes
            // 
            lbl_changes.Font = new Font("Montserrat SemiBold", 10F);
            lbl_changes.ForeColor = Color.White;
            lbl_changes.Location = new Point(13, 66);
            lbl_changes.Margin = new Padding(4, 0, 4, 0);
            lbl_changes.Name = "lbl_changes";
            lbl_changes.Size = new Size(247, 193);
            lbl_changes.TabIndex = 0;
            lbl_changes.Text = "Message";
            lbl_changes.MouseDown += UpdatePopupForm_MouseDown;
            lbl_changes.MouseMove += UpdatePopupForm_MouseMove;
            lbl_changes.MouseUp += UpdatePopupForm_MouseUp;
            // 
            // lbl_version
            // 
            lbl_version.Font = new Font("Montserrat SemiBold", 12F);
            lbl_version.ForeColor = Color.White;
            lbl_version.Location = new Point(13, 38);
            lbl_version.Margin = new Padding(4, 0, 4, 0);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new Size(247, 28);
            lbl_version.TabIndex = 1;
            lbl_version.Text = "Version";
            lbl_version.TextAlign = ContentAlignment.TopCenter;
            lbl_version.MouseDown += UpdatePopupForm_MouseDown;
            lbl_version.MouseMove += UpdatePopupForm_MouseMove;
            lbl_version.MouseUp += UpdatePopupForm_MouseUp;
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
            pnl_control.Size = new Size(273, 35);
            pnl_control.TabIndex = 3;
            pnl_control.MouseDown += UpdatePopupForm_MouseDown;
            pnl_control.MouseMove += UpdatePopupForm_MouseMove;
            pnl_control.MouseUp += UpdatePopupForm_MouseUp;
            // 
            // lbl_title
            // 
            lbl_title.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            lbl_title.ForeColor = SystemColors.ButtonHighlight;
            lbl_title.Location = new Point(3, 3);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(179, 26);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "UPDATE AVAILABLE";
            lbl_title.TextAlign = ContentAlignment.MiddleLeft;
            lbl_title.MouseDown += UpdatePopupForm_MouseDown;
            lbl_title.MouseMove += UpdatePopupForm_MouseMove;
            lbl_title.MouseUp += UpdatePopupForm_MouseUp;
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
            btnClose.Location = new Point(243, 3);
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
            btnMinimize.Location = new Point(219, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(27, 26);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // UpdatePopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(273, 268);
            Controls.Add(pnl_control);
            Controls.Add(lbl_version);
            Controls.Add(lbl_changes);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdatePopupForm";
            Text = "UPDATE AVAILABLE";
            Load += UpdatePopupForm_Load;
            MouseDown += UpdatePopupForm_MouseDown;
            MouseMove += UpdatePopupForm_MouseMove;
            MouseUp += UpdatePopupForm_MouseUp;
            pnl_control.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_changes;
        private Label lbl_version;
        private Panel pnl_control;
        private Label lbl_title;
        private Button btnClose;
        private Button btnMinimize;
    }
}
