using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Net4.BLL;
using Net4.DTO;

namespace Net4
{
    public delegate void NemDL(string user_name, string password);
    public partial class RESETPASS : Form
    {
        public string user_name = "";
        public DataTable dataTable;
        public DataRow dr;
        Boolean down = false, enter = false;
        int X, Y, MX, MY;
        public event NemDL nemdl = null;
        List<DataTable> ListDT;

        public RESETPASS(string user_name, List<DataTable> dt)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.ListDT = dt;
        }

        private Boolean checkPassword(string username,string password)
        {
            foreach(DataRow dr in ListDT[0].Rows)
            {
                if (dr["user_name"].ToString() == username)
                {
                    if (dr["user_password"].ToString() == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public DataTable getDataTable()
        {
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("user_name", typeof(String));
            dataTable.Columns.Add("user_password", typeof(String));

            return dataTable;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                    if (!checkPassword(this.user_name,textBox1.Text))
                    {
                        MessageBox.Show("Bạn đã nhập sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("Bạn đã nhập lại mật khẩu mới không chính xác, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                    //ACCOUNT_BLL.Instance.resetPASS(textBox2.Text,this.user_name);
                    if (nemdl != null) nemdl(this.user_name, textBox2.Text);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
            }
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
