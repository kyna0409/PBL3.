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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net4
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        Boolean down = false, enter = false;
        int X, Y, MX, MY;
        String Text = "SERVER";

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(Text + ": " + txbMessage.Text);
        }

        IPEndPoint IP;
        Socket client;

        //kết nối đến server
        void Connect()
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse("192.168.1.134"), 1111);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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
        void Close()
        {
            client.Close();
        }

        //gửi dữ liệu
        void Send()
        {
            //nếu textboc khác rỗng thì mới gửi tin
            if (txbMessage.Text != string.Empty)
            {
                client.Send(Serialize(Text + ": " + txbMessage.Text));
            }
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
                    string message = (string)Deseriliaze(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        //add mesage vào khung chat
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txbMessage.Clear();
        }

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            down = true;
            MX = e.X;
            MY = e.Y;
            X = this.Location.X;
            Y = this.Location.Y;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            enter = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (enter && down)
            {
                this.Location = new Point(X + (e.X - MX), Y + (e.Y - MY));
                this.BringToFront();
            }
        }
    }
}
