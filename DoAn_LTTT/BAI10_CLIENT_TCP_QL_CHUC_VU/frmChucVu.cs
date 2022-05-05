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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }          
       
        StreamReader sr;
        StreamWriter sw;   

        int chon = 0;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                chon = 0;

                //tạo luồng đọc và luồng ghi dữ liệu
                //sử dụng biến static ns của form Kết Nối
                sr = new StreamReader(frmKetNoi.ns);
                sw = new StreamWriter(frmKetNoi.ns);
                
                sw.WriteLine(chon);
                sw.Flush();

               
                //tạo mảng byte để nhận dữ liệu từ máy chủ
                byte[] data = new byte[1024 * 5000];

                //sử dụng biến static clientSockt của form Kết Nối
                frmKetNoi.clientSock.Receive(data);

                //chuyển dữ liệu vừa nhận dạng mảng byte sang kiểu object rồi ép kiểu sang datatable
                DataTable dt = (DataTable)DeserializeData(data);

                //đưa datatable vào dataGridView
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["macv"].HeaderText = "Mã chức vụ";
                dataGridView1.Columns["tencv"].HeaderText = "Tên chức vụ";
                dataGridView1.Columns["hsphucap"].HeaderText = "Hệ số phụ cấp";
                dataGridView1.Columns["macv"].Width = 110;
                dataGridView1.Columns["tencv"].Width = 200;
                dataGridView1.Columns["hsphucap"].Width = 100;




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

        private void btn_batdau_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            
            if(dataGridView1.SelectedRows.Count > 0)
            {
                r = dataGridView1.SelectedRows[0];
                txt_macv.Text = r.Cells["macv"].Value.ToString();
                txt_tencv.Text = r.Cells["tencv"].Value.ToString();
                txt_hesopc.Text = r.Cells["hsphucap"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Dòng được chọn = "+dataGridView1.SelectedRows.Count.ToString());
            }   
        }


        public bool timChucVuTheoMaCV(string macvtim)
        {
            chon = 5;  

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(macvtim);
            sw.Flush();

            int kq = int.Parse(sr.ReadLine());
           
            if (kq == 1)
                return true;
            else
                return false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txt_macv.Text == "" || txt_tencv.Text == "" || txt_hesopc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txt_macv.Text.Length > 5)
            {
                MessageBox.Show("Mã chức vụ tối đa 5 ký tự!");
                return;
            }
            if (timChucVuTheoMaCV(txt_macv.Text) == true)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại!");
                return;
            }
            
            chon = 1;
            string macv = txt_macv.Text;
            string tencv = txt_tencv.Text;
            float hspc = float.Parse(txt_hesopc.Text);

            //thêm chức vụ            
            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(macv);
            sw.WriteLine(tencv);
            sw.WriteLine(hspc);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dataGridView1.DataSource = dt;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txt_macv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã chức vụ!");
                return;
            }            
            chon = 2;
            string macv = txt_macv.Text;           
           
            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(macv);            
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dataGridView1.DataSource = dt;            
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txt_macv.Text == "" || txt_tencv.Text == "" || txt_hesopc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mhập đủ thông tin!");
                return;
            }
            if (timChucVuTheoMaCV(txt_macv.Text) == false)
            {
                MessageBox.Show("Mã chức vụ không tồn tại!");
                return;
            }
            chon = 3;
            string macv = txt_macv.Text;
            string tencv = txt_tencv.Text;
            float hspc = float.Parse(txt_hesopc.Text);

            //thêm chức vụ

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(macv);
            sw.WriteLine(tencv);
            sw.WriteLine(hspc);
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dataGridView1.DataSource = dt;

        }

        private void btn_timkien_Click(object sender, EventArgs e)
        {
            /*
            if (txt_tim.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mhập tên chức vụ!");
                return;
            }
            */
            chon = 4;
            string tencvtim = txt_tim.Text;

            sr = new StreamReader(frmKetNoi.ns);
            sw = new StreamWriter(frmKetNoi.ns);

            sw.WriteLine(chon);
            sw.WriteLine(tencvtim);
            
            sw.Flush();

            //tạo mảng byte để nhận dữ liệu từ máy chủ
            byte[] data = new byte[1024 * 5000];
            frmKetNoi.clientSock.Receive(data);

            //chuyển dữ liệu vừa nhận dạng mảng byte sang datatable
            DataTable dt = (DataTable)DeserializeData(data);

            //đưa datatable vào dataGridView
            dataGridView1.DataSource = dt;

            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            //clientSock.Close();
            //sr.Close();
           // sw.Close();
            this.Close();
        }
    }
}
