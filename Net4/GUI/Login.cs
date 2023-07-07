using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Net4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Net4.DTO;
using Net4.BLL;

namespace Net4
{
    public partial class Login : Form
    {
        public event FireEventLoginSuccess FireEventLoginSuccess = null;
        public Boolean Locked = false;
        public string user_name = "";
        public Login(List<DataTable> listDT)
        {
            InitializeComponent();
            this.listDT = listDT;
        }
        DataTable dataTable = new DataTable();
        DataRow dr;
        List<DataTable> listDT = new List<DataTable>();

        public DataTable createAccountTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("user_name", typeof(String));
            dataTable.Columns.Add("role_name", typeof(String));
            dataTable.Columns.Add("remaining_time", typeof(String));
            return dataTable;
        }

        public DataTable getAccountTable() 
        {
            DataTable dataTable = new DataTable();
            dataTable = createAccountTable();
            String username = "";
            String remainingtime = "";
            String userrole = "";
            foreach (DataRow dr in listDT[0].Rows)
            {
                if (dr["user_name"].ToString() == textBox1.Text && dr["user_password"].ToString() == textBox2.Text)
                {
                    username = dr["user_name"].ToString();
                    break;
                }
            }
            if (username == "")
            {
                
                return dataTable;
            } 
                
                
            foreach (DataRow dr in listDT[1].Rows)
            {
                if (dr["user_name"].ToString() == username)
                {
                    remainingtime = dr["remaining_time"].ToString();
                    break;
                }
            }
            foreach (DataRow dr in listDT[2].Rows)
            {
                if (dr["user_name"].ToString() == username)
                {
                    userrole = dr["role_name"].ToString();
                    break;
                }
            }
            dataTable.Rows.Add(username,userrole,remainingtime);
            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataTable = getAccountTable();


            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dr = dataTable.Rows[0];
                if (!Locked)
                {
                    if (FireEventLoginSuccess != null) FireEventLoginSuccess(dr["user_name"].ToString(), dr["role_name"].ToString(), dr["remaining_time"].ToString());
                    this.Dispose();
                }
                else
                {
                    if (this.user_name == dr["user_name"].ToString())
                    {
                        Locked = false;
                        if (FireEventLoginSuccess != null) FireEventLoginSuccess(dr["user_name"].ToString(), dr["role_name"].ToString(), dr["remaining_time"].ToString());
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Máy này đã bị khóa bởi tài khoản " + this.user_name + ", vui lòng sử dụng máy khác!");
                        return;
                    }
                }

            }
        }
    }
}
