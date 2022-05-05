using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string ip_client = "";
        string ip_server = "";
        public IPEndPoint ipEnd;
        public static Socket clientSock;
        public static NetworkStream ns;
        string ipClient = "";
        string ipServer = "";
        StreamReader sr;
        StreamWriter sw;

        int chon = 0;




        frmChucVu fCV;
        frmNhanVien fNV;
        frmKetNoi fKN;
        frmDangNhap fDN;

        string tennguoidung = "";
        bool kiemtradangnhap = false;
        public static bool kiemtraketnoi = false;


        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (fKN == null || fKN.IsDisposed)
            {
                fKN = new frmKetNoi();
                fKN.MdiParent = this;
                fKN.Show();                
            }
           
            HienThiMenu();
        }        

        private void HienThiMenu()
        {
            if (kiemtradangnhap == true)
            {
                // Hiển thị trạng thái đăng nhập
                stt_hoten.Text = "Người dùng: "+tennguoidung;
                stt_thoigian.Text = "Thời điểm đăng nhập: " + DateTime.Now;

                i_dangnhap.Enabled = false;
                i_dangxuat.Enabled = true;


                i_dmChucVu.Enabled = true;
                i_dmNhanVien.Enabled = true;
                i_bangluong.Enabled = true;
                i_quatrinhluong.Enabled = true;
                
            }
            else
            {
                stt_hoten.Text = "Chưa đăng nhập";
                stt_thoigian.Text = " ";
               
                 i_dangnhap.Enabled = true;               
                i_dangxuat.Enabled = false;

                i_dmChucVu.Enabled = false;
                i_dmNhanVien.Enabled = false;
                i_bangluong.Enabled = false;
                i_quatrinhluong.Enabled = false;
            }

        }

        private void i_dmChucVu_Click(object sender, EventArgs e)
        { 
            if (fCV == null || fCV.IsDisposed)
            {
                fCV = new frmChucVu();
                fCV.MdiParent = this;
                fCV.Show();
            }
        }

        private void kếtNốiServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fKN == null || fKN.IsDisposed)
            {
                fKN = new frmKetNoi();
                fKN.MdiParent = this;
                fKN.Show();
            }
        }

        private void i_dmNhanVien_Click(object sender, EventArgs e)
        {
            if (fNV == null || fNV.IsDisposed)
            {
                fNV = new frmNhanVien();
                fNV.MdiParent = this;
                fNV.Show();
            }
        }

        private void i_dangnhap_Click(object sender, EventArgs e)
        {
            if(kiemtraketnoi == true)
            {
                fDN = new frmDangNhap();
               

                if (fDN.ShowDialog() == DialogResult.OK)
                {
                  
                    string sTen = fDN.txtTen.Text;
                    MD5 md5Hash = MD5.Create();
                    string sMatKhau = GetMd5Hash(md5Hash, fDN.txtMatKhau.Text);

                    sr = new StreamReader(frmKetNoi.ns);
                    sw = new StreamWriter(frmKetNoi.ns);

                    chon = 7;
                    sw.WriteLine(chon);
                    sw.WriteLine(sTen);
                    sw.WriteLine(sMatKhau);
                    sw.Flush();
                    //lưu ý phải thêm w.Flush để đẩy dữ liệu đi

                    int kq = int.Parse(sr.ReadLine());
                    tennguoidung = sr.ReadLine();
                    //MessageBox.Show("KQ" + kq + " ten ND: "+ tennguoidung);
                    if (kq == 1)
                    {
                        kiemtradangnhap = true;
                    }
                    else
                    {
                        kiemtradangnhap = false;
                    }
                }
                else
                {
                    kiemtradangnhap = false;
                }
                HienThiMenu();
            } 
            else
            {
                MessageBox.Show("Chưa kết nối server!");
            }    
            
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void i_dangxuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất & thiết lập lại menu
            kiemtradangnhap = false;
            HienThiMenu();
        }
    }
}
