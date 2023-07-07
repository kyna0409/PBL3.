using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Net4.DTO;
using Net4.DAL;
using Net4.BLL;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Net4
{
    public partial class GameMenu : Form
    {
        public GameMenu(DataTable dt)
        {
            InitializeComponent();
            dtGame = new DataTable();
            dtGame = dt;
            dtGame1 = getGameByID(1);
            dtGame2 = getGameByID(2);
            dtGame3 = getGameByID(3);
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        string s = "All";
        DataTable dataTable;
        MemoryStream ms;
        Boolean down = false, enter = false;
        int X, Y, MX, MY;
        IPEndPoint IP;
        Socket client;
        DataTable dtGame;
        DataTable dtGame1;
        DataTable dtGame2;
        DataTable dtGame3;

        //kết nối đến server
        void Connect()
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse("192.168.1.134"), 1801);
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
                    string message = (string)Deseriliaze(data);
                    if (message == "YES") MessageBox.Show("SERVER ĐÃ NHẬN ĐƯỢC PHẢN HỒI");
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
        ///
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public DataTable createDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("game_category_id", typeof(int));
            dataTable.Columns.Add("game_name", typeof(String));
            dataTable.Columns.Add("played_times", typeof(int));
            dataTable.Columns.Add("path", typeof(String));
            return dataTable;
        }
        private DataTable getGameByID(int id)
        {
            DataTable dt = new DataTable();
            dt = createDataTable();
            foreach(DataRow row in dtGame.Rows)
            {
                if (row["game_category_id"].ToString() == id.ToString())
                {
                    dt.Rows.Add(Convert.ToInt32(row["id"]), Convert.ToInt32(row["game_category_id"]), row["game_name"].ToString(), Convert.ToInt32(row["played_times"]), row["path"].ToString());
                }
            }
            return dt;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor= Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor= Color.Gainsboro;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gainsboro;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gainsboro;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Gainsboro;
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
                //dataTable = GAME_BLL.Instance.getAllGAME();

                foreach (DataRow row in dtGame.Rows)
                {
                    GAMES game = new GAMES();
                    game.button1.Text = row["game_name"].ToString();
                    game.label1.Text = row["path"].ToString();
                    if (row["game_category_id"].ToString() == "1")
                    {
                        game.pictureBox1.Image = game.offlinegame.Image;
                    }
                    else if (row["game_category_id"].ToString() == "2")
                    {
                        game.pictureBox1.Image = game.onlinegame.Image;
                    }
                    else if (row["game_category_id"].ToString() == "3")
                    {
                        game.pictureBox1.Image = game.tools.Image;
                    }
                    game.button1.Click += Button1_Click;
                    flowLayoutPanel1.Controls.Add(game);
                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GAMES game = new GAMES();
            game = (GAMES)btn.Parent;
            if (game.label1.Text != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(game.label1.Text);
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            Send(game.button1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
                //dataTable = GAME_BLL.Instance.getAllGAME();
                s = "All";
                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow row in dtGame.Rows)
                {
                    GAMES game = new GAMES();
                    game.button1.Text = row["game_name"].ToString();
                    game.label1.Text = row["path"].ToString();
                    if (row["game_category_id"].ToString() == "1")
                    {
                        game.pictureBox1.Image = game.offlinegame.Image;
                    }
                    else if (row["game_category_id"].ToString() == "2")
                    {
                        game.pictureBox1.Image = game.onlinegame.Image;
                    }
                    else if (row["game_category_id"].ToString() == "3")
                    {
                        game.pictureBox1.Image = game.tools.Image;
                    }
                    game.button1.Click += Button1_Click;
                    flowLayoutPanel1.Controls.Add(game);
                }
        }

        private void label3_Click(object sender, EventArgs e)
        {
                //dataTable = GAME_BLL.Instance.getGameByID(1);
                s = "Offline";
                flowLayoutPanel1.Controls.Clear();
                
                foreach (DataRow row in dtGame1.Rows)
                {
                    GAMES game = new GAMES();
                    game.button1.Text = row["game_name"].ToString();
                    game.label1.Text = row["path"].ToString();
                    game.pictureBox1.Image = game.offlinegame.Image;
                    game.button1.Click += Button1_Click;
                    flowLayoutPanel1.Controls.Add(game);
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {
                //dataTable = GAME_BLL.Instance.getGameByID(2);
                s = "Online";
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow row in dtGame2.Rows)
                {
                    GAMES game = new GAMES();
                    game.button1.Text = row["game_name"].ToString();
                    game.label1.Text = row["path"].ToString();
                    game.pictureBox1.Image = game.onlinegame.Image;
                    game.button1.Click += Button1_Click;
                    flowLayoutPanel1.Controls.Add(game);
                }
        }

        private void label5_Click(object sender, EventArgs e)
        {
                //dataTable = GAME_BLL.Instance.getGameByID(3);
                s = "Tools";
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow row in dtGame3.Rows)
                {
                    GAMES game = new GAMES();
                    //bTDRINK.Size = new System.Drawing.Size(183, 217);
                    game.button1.Text = row["game_name"].ToString();
                    game.label1.Text = row["path"].ToString();
                    game.pictureBox1.Image = game.tools.Image;
                    game.button1.Click += Button1_Click;
                    flowLayoutPanel1.Controls.Add(game);
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                flowLayoutPanel1.Controls.Clear();

                if (s == "All")
                    dataTable = dtGame;
                else if (s == "Online")
                    dataTable = dtGame2;
                else if (s == "Offline")
                    dataTable = dtGame1;
                else if (s == "Tools")
                    dataTable = dtGame3;
                
                foreach (DataRow row in dataTable.Rows)
                {
                    GAMES game = new GAMES();
                    game.button1.Text = row["game_name"].ToString();
                    game.label1.Text = row["path"].ToString();
                    if (row["game_category_id"].ToString() == "1")
                    {
                        game.pictureBox1.Image = game.offlinegame.Image;
                    }
                    else if (row["game_category_id"].ToString() == "2")
                    {
                        game.pictureBox1.Image = game.onlinegame.Image;
                    }
                    else if (row["game_category_id"].ToString() == "3")
                    {
                        game.pictureBox1.Image = game.tools.Image;
                    }
                    game.button1.Click += Button1_Click;
                    flowLayoutPanel1.Controls.Add(game);
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
