
namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiepvuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bangluong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_quatrinhluong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stt_hoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.stt_thoigian = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.nghiepvuToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(842, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dangnhap,
            this.i_dangxuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // i_dangnhap
            // 
            this.i_dangnhap.Name = "i_dangnhap";
            this.i_dangnhap.Size = new System.Drawing.Size(180, 22);
            this.i_dangnhap.Text = "Đăng nhập";
            this.i_dangnhap.Click += new System.EventHandler(this.i_dangnhap_Click);
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmChucVu,
            this.i_dmNhanVien});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // i_dmChucVu
            // 
            this.i_dmChucVu.Name = "i_dmChucVu";
            this.i_dmChucVu.Size = new System.Drawing.Size(128, 22);
            this.i_dmChucVu.Text = "Chức vụ";
            this.i_dmChucVu.Click += new System.EventHandler(this.i_dmChucVu_Click);
            // 
            // i_dmNhanVien
            // 
            this.i_dmNhanVien.Name = "i_dmNhanVien";
            this.i_dmNhanVien.Size = new System.Drawing.Size(128, 22);
            this.i_dmNhanVien.Text = "Nhân viên";
            this.i_dmNhanVien.Click += new System.EventHandler(this.i_dmNhanVien_Click);
            // 
            // nghiepvuToolStripMenuItem
            // 
            this.nghiepvuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_bangluong,
            this.i_quatrinhluong});
            this.nghiepvuToolStripMenuItem.Name = "nghiepvuToolStripMenuItem";
            this.nghiepvuToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiepvuToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // i_bangluong
            // 
            this.i_bangluong.Name = "i_bangluong";
            this.i_bangluong.Size = new System.Drawing.Size(188, 22);
            this.i_bangluong.Text = "Bảng lương";
            // 
            // i_quatrinhluong
            // 
            this.i_quatrinhluong.Name = "i_quatrinhluong";
            this.i_quatrinhluong.Size = new System.Drawing.Size(188, 22);
            this.i_quatrinhluong.Text = "Quá trình nâng lương";
            // 
            // i_dangxuat
            // 
            this.i_dangxuat.Enabled = false;
            this.i_dangxuat.Name = "i_dangxuat";
            this.i_dangxuat.Size = new System.Drawing.Size(180, 22);
            this.i_dangxuat.Text = "Đăng xuất";
            this.i_dangxuat.Click += new System.EventHandler(this.i_dangxuat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stt_hoten,
            this.stt_thoigian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stt_hoten
            // 
            this.stt_hoten.Name = "stt_hoten";
            this.stt_hoten.Size = new System.Drawing.Size(43, 17);
            this.stt_hoten.Text = "Họ tên";
            // 
            // stt_thoigian
            // 
            this.stt_thoigian.Name = "stt_thoigian";
            this.stt_thoigian.Size = new System.Drawing.Size(116, 17);
            this.stt_thoigian.Text = "Thời gian đăng nhập";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý nhân viên";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_dmChucVu;
        private System.Windows.Forms.ToolStripMenuItem i_dmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem nghiepvuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_bangluong;
        private System.Windows.Forms.ToolStripMenuItem i_quatrinhluong;
        private System.Windows.Forms.ToolStripMenuItem i_dangnhap;
        private System.Windows.Forms.ToolStripMenuItem i_dangxuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stt_hoten;
        private System.Windows.Forms.ToolStripStatusLabel stt_thoigian;
    }
}