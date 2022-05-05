using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        StreamReader sr;
        StreamWriter sw;

        int chon = 0;      

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //tạo luồng đọc và luồng ghi dữ liệu
                //sử dụng biến static ns của form Kết Nối
                sr = new StreamReader(frmKetNoi.ns);
                sw = new StreamWriter(frmKetNoi.ns);

                chon = 6;

                sr = new StreamReader(frmKetNoi.ns);
                sw = new StreamWriter(frmKetNoi.ns);

                sw.WriteLine(chon);
                sw.Flush();
               
               

                //tạo mảng byte để nhận table chuc vu từ máy chủ
                byte[] data_chucvu = new byte[1024 * 5000];

                //tạo mảng byte để nhận table nhan vien từ máy chủ
                byte[] data_nhanvien = new byte[1024 * 5000];


                //sử dụng biến static clientSockt của form Kết Nối
                frmKetNoi.clientSock.Receive(data_chucvu);
                //chuyển dữ liệu vừa nhận dạng mảng byte sang kiểu object rồi ép kiểu sang datatable
                DataTable dt_chucvu = (DataTable)DeserializeData(data_chucvu);

                //sử dụng biến static clientSockt của form Kết Nối
                frmKetNoi.clientSock.Receive(data_nhanvien);
                //chuyển dữ liệu vừa nhận dạng mảng byte sang kiểu object rồi ép kiểu sang datatable
                DataTable dt_nhanvien = (DataTable)DeserializeData(data_nhanvien);


                
                cboChucVu.DataSource = dt_chucvu;
                cboChucVu.DisplayMember = "tencv";
                cboChucVu.ValueMember = "macv";


                //đưa datatable vào dataGridView
                dgDSNhanVien.DataSource = dt_nhanvien;   
                




                //clientSock.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        //chuyển dữ liệu từ dạng mảng byte sang kiểu object
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);

        }

        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSNhanVien.SelectedRows[0];
            txtMaNV.Text = r.Cells["manv"].Value.ToString();
            txtHoLot.Text = r.Cells["holot"].Value.ToString();
            txtTen.Text = r.Cells["tennv"].Value.ToString();
            if (r.Cells["phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = r.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = r.Cells["macv"].Value;
        }
    }
}
