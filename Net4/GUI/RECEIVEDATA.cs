using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net4
{
    public partial class RECEIVEDATA : Form
    {
        public RECEIVEDATA()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            listDT = new List<DataTable>();
            demand = new List<string>();
            demand.Add("User");
            demand.Add("Customer");
            demand.Add("UserRole");
            demand.Add("Product");
            demand.Add("Game");
            demand.Add("News");
            demand.Add("End");
            Connect();
            Send(demand[dem]);
        }
        IPEndPoint IP;
        Socket client;
        List<string> demand;
        List<DataTable> listDT;
        int dem = 0;
        public Boolean check = false;

        //kết nối đến server
        void Connect()
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse("192.168.1.134"), 5555);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, 16384);
            //bắt đầu kết nôi. Nếu ko kết nối được thì hiện thông báo
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        //đóng kết nối đến server
        public void Close()
        {
            client.Close();
        }

        //gửi dữ liệu
        public void Send(string fbMessage)
        {
            client.Send(Serialize(fbMessage));

        }

        //nhận dữ liệu
        void Receive()
        {
            try
            {
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    DataTable dt = (DataTable)Deseriliaze(data);
                    listDT.Add(dt);
                    dem++;
                    if (dem < 6)
                    {
                        Send(demand[dem]);
                    }
                    else if (dem == 6)
                    {
                        Send(demand[dem]);
                        check = true;
                    }

                }
            }
            catch
            {
                Close();
            }
        }

        //add mesage vào khung chat


        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        byte[] Serialize(object obj)
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy rồi cbi gửi đi
            return stream.ToArray();
        }

        //Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string để hiện thị lên màn hình
        object Deseriliaze(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data);
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);
        }

        private void SENDORDER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView0.DataSource = listDT[0];
            dataGridView1.DataSource = listDT[1];
            dataGridView2.DataSource = listDT[2];
            dataGridView3.DataSource = listDT[3];
            dataGridView4.DataSource = listDT[4];
            dataGridView5.DataSource = listDT[5];
        }

        public List<DataTable> getListDataTable()
        {
            return listDT;
        }
    }
}
