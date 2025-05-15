namespace CoCaro_26_minh
{
    partial class formGame_26_minh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGame_26_minh));
            msMain_26_minh = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            chơiLạiToolStripMenuItem = new ToolStripMenuItem();
            quayLạiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            pnBanCo_26_minh = new Panel();
            pnAnh_26_minh = new Panel();
            lblRule_26_minh = new Label();
            pnNguoiChoi_26_minh = new Panel();
            lblTenNguoichoi_26_minh = new Label();
            pbAvt_26_minh = new PictureBox();
            tmCoolDown_26_minh = new System.Windows.Forms.Timer(components);
            prcbCooldown_26_minh = new ProgressBar();
            msMain_26_minh.SuspendLayout();
            pnAnh_26_minh.SuspendLayout();
            pnNguoiChoi_26_minh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvt_26_minh).BeginInit();
            SuspendLayout();
            // 
            // msMain_26_minh
            // 
            msMain_26_minh.ImageScalingSize = new Size(32, 32);
            msMain_26_minh.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            msMain_26_minh.Location = new Point(0, 0);
            msMain_26_minh.Name = "msMain_26_minh";
            msMain_26_minh.Size = new Size(1974, 40);
            msMain_26_minh.TabIndex = 0;
            msMain_26_minh.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chơiLạiToolStripMenuItem, quayLạiToolStripMenuItem, thoátToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(96, 36);
            menuToolStripMenuItem.Text = "Game";
            // 
            // chơiLạiToolStripMenuItem
            // 
            chơiLạiToolStripMenuItem.Name = "chơiLạiToolStripMenuItem";
            chơiLạiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            chơiLạiToolStripMenuItem.Size = new Size(359, 44);
            chơiLạiToolStripMenuItem.Text = "Game mới";
            chơiLạiToolStripMenuItem.Click += chơiLạiToolStripMenuItem_Click;
            // 
            // quayLạiToolStripMenuItem
            // 
            quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            quayLạiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            quayLạiToolStripMenuItem.Size = new Size(359, 44);
            quayLạiToolStripMenuItem.Text = "Quay lại";
            quayLạiToolStripMenuItem.Click += quayLạiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            thoátToolStripMenuItem.Size = new Size(359, 44);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // pnBanCo_26_minh
            // 
            pnBanCo_26_minh.Location = new Point(30, 72);
            pnBanCo_26_minh.Name = "pnBanCo_26_minh";
            pnBanCo_26_minh.Size = new Size(1300, 1100);
            pnBanCo_26_minh.TabIndex = 1;
            // 
            // pnAnh_26_minh
            // 
            pnAnh_26_minh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnAnh_26_minh.BackgroundImage = Properties.Resources.CaroAvt_26_minh;
            pnAnh_26_minh.BackgroundImageLayout = ImageLayout.Stretch;
            pnAnh_26_minh.Controls.Add(lblRule_26_minh);
            pnAnh_26_minh.Location = new Point(1422, 60);
            pnAnh_26_minh.Name = "pnAnh_26_minh";
            pnAnh_26_minh.Size = new Size(525, 525);
            pnAnh_26_minh.TabIndex = 2;
            // 
            // lblRule_26_minh
            // 
            lblRule_26_minh.BackColor = Color.FromArgb(255, 192, 128);
            lblRule_26_minh.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblRule_26_minh.ForeColor = Color.Red;
            lblRule_26_minh.Location = new Point(-1, 0);
            lblRule_26_minh.Name = "lblRule_26_minh";
            lblRule_26_minh.Size = new Size(526, 57);
            lblRule_26_minh.TabIndex = 0;
            lblRule_26_minh.Text = "5 QUÂN LIỀN KỀ ĐỂ THẮNG";
            lblRule_26_minh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnNguoiChoi_26_minh
            // 
            pnNguoiChoi_26_minh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnNguoiChoi_26_minh.BackColor = Color.FromArgb(255, 224, 192);
            pnNguoiChoi_26_minh.Controls.Add(lblTenNguoichoi_26_minh);
            pnNguoiChoi_26_minh.Controls.Add(pbAvt_26_minh);
            pnNguoiChoi_26_minh.Location = new Point(1422, 635);
            pnNguoiChoi_26_minh.Name = "pnNguoiChoi_26_minh";
            pnNguoiChoi_26_minh.Size = new Size(525, 525);
            pnNguoiChoi_26_minh.TabIndex = 3;
            // 
            // lblTenNguoichoi_26_minh
            // 
            lblTenNguoichoi_26_minh.BackColor = Color.FromArgb(255, 192, 128);
            lblTenNguoichoi_26_minh.Dock = DockStyle.Bottom;
            lblTenNguoichoi_26_minh.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTenNguoichoi_26_minh.ForeColor = Color.Blue;
            lblTenNguoichoi_26_minh.Location = new Point(0, 330);
            lblTenNguoichoi_26_minh.Name = "lblTenNguoichoi_26_minh";
            lblTenNguoichoi_26_minh.Size = new Size(525, 195);
            lblTenNguoichoi_26_minh.TabIndex = 2;
            lblTenNguoichoi_26_minh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbAvt_26_minh
            // 
            pbAvt_26_minh.ErrorImage = null;
            pbAvt_26_minh.Location = new Point(100, 0);
            pbAvt_26_minh.Name = "pbAvt_26_minh";
            pbAvt_26_minh.Size = new Size(325, 332);
            pbAvt_26_minh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvt_26_minh.TabIndex = 1;
            pbAvt_26_minh.TabStop = false;
            // 
            // tmCoolDown_26_minh
            // 
            tmCoolDown_26_minh.Tick += tmCoolDown_26_minh_Tick;
            // 
            // prcbCooldown_26_minh
            // 
            prcbCooldown_26_minh.Location = new Point(1421, 579);
            prcbCooldown_26_minh.Name = "prcbCooldown_26_minh";
            prcbCooldown_26_minh.Size = new Size(526, 64);
            prcbCooldown_26_minh.TabIndex = 4;
            // 
            // formGame_26_minh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background2_26_minh;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1974, 1229);
            Controls.Add(prcbCooldown_26_minh);
            Controls.Add(pnNguoiChoi_26_minh);
            Controls.Add(pnAnh_26_minh);
            Controls.Add(pnBanCo_26_minh);
            Controls.Add(msMain_26_minh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMain_26_minh;
            MaximizeBox = false;
            MaximumSize = new Size(2000, 1300);
            MinimumSize = new Size(1900, 1200);
            Name = "formGame_26_minh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cờ Caro";
            FormClosing += frmGame_26_minh_FormClosing;
            msMain_26_minh.ResumeLayout(false);
            msMain_26_minh.PerformLayout();
            pnAnh_26_minh.ResumeLayout(false);
            pnNguoiChoi_26_minh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvt_26_minh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain_26_minh;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Panel pnBanCo_26_minh;
        private Panel pnAnh_26_minh;
        private Panel pnNguoiChoi_26_minh;
        private PictureBox pbAvt_26_minh;
        private Label lblTenNguoichoi_26_minh;
        private System.Windows.Forms.Timer tmCoolDown_26_minh;
        private ProgressBar prcbCooldown_26_minh;
        private ToolStripMenuItem chơiLạiToolStripMenuItem;
        private ToolStripMenuItem quayLạiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label lblRule_26_minh;
    }
}
