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
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }
        string ip_client = "";
        string ip_server = "";
        public IPEndPoint ipEnd;
        public static Socket clientSock;
        public static NetworkStream ns;

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            IPHostEntry ip = new IPHostEntry();
            string hostname = Dns.GetHostName();
            ip = Dns.GetHostByName(hostname);

            foreach (IPAddress listip in ip.AddressList)
            {
                txt_IP_Client.Text = listip.ToString();
                ip_client = listip.ToString();
            }
            ip_server = "127.0.0.1";
            txt_IP.Text = ip_server;
        }

       

        private void btn_batdau_Click(object sender, EventArgs e)
        {
            try
            {
                // Client tìm là địa chỉ ip, port của server trên mạng
                // mỗi endpoint chứa ip của host và port của tiến trình
                ipEnd = new IPEndPoint(IPAddress.Parse(ip_server), 2021);

                // khởi tạo 1 socket để sử dụng dịch vụ Tcp
                //clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // tạo kết nối tới Server có ipEnd với ip và port như khai báo ở trên
                clientSock.Connect(ipEnd);

                //khai báo luồng kết nối mạng 
                ns = new NetworkStream(clientSock);


                frmMain.kiemtraketnoi = true;
               
                //clientSock.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Kết nối Server thành công!");
            this.Close();
           
        }
    }
}
