using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Net4.DTO;
using Net4.DAL;
using Net4.BLL;

namespace Net4
{
    public partial class MainMenu : Form
    {
        public string user_name;
        public string role_name;
        public string[] arr;
        int Hour, Minute, Second;
        public LockScreen ls;
        public Boolean activate = false;
        RECEIVEDATA rd = new RECEIVEDATA();
        SENDRMTIME srmt = new SENDRMTIME();
        List<DataTable> list = new List<DataTable>();
        DataTable dtUser;
        DataTable dtCustomer;
        DataTable dtUserRole;
        DataTable dtProduct;
        DataTable dtGame;
        public MainMenu()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = true;
            timer2.Start();
            
        }
        
        private void updateRemainingTime(String username,String remainingTime)
        {
            foreach (DataRow dr in list[1].Rows)
            {
                if (dr["user_name"].ToString() == username)
                {
                    dr["remaining_time"] = remainingTime.ToString();
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(LoadHome);
            Thread thread= new Thread(ts);
            thread.Start();
            button2.Enabled = false;
        }

        void LoadHome()
        {
            MenuDV home = new MenuDV(user_name, role_name, list);
            home.ShowDialog();
            
        }

        private void Load()
        {
            LockScreen lockScreen = new LockScreen(list);
            lockScreen.FireEventLoginSuccess += LockScreen_FireEventLoginSuccess;
            lockScreen.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (srmt.change)
            {
                if (Minute + srmt.Minute >= 60)
                {
                    Hour += srmt.Hour + 1;
                    Minute = (srmt.Minute + Minute) - 60;
                }
                else
                {
                    Hour += srmt.Hour;
                    Minute += srmt.Minute;
                }
                textBox2.Text = Hour.ToString() + ":" + Minute.ToString();
                textBox5.Text = Hour.ToString() + ":" + Minute.ToString();
                textBox3.Text = ((Hour * 60 + Minute) * 100).ToString();
                textBox4.Text = textBox3.Text;
                srmt.change = false;
            }
            
            if (Hour == 0 && Minute == 0 && Second == 0)
            {
                timer1.Stop();
                if (activate) { ls.lg.Dispose(); ls.Dispose(); activate = false; }
                button3_Click(sender, e);
                
            }
            else
            {
                if (Minute == 0 && Second == 0)
                {
                    Hour--;
                    Minute = 59;
                    Second = 59;
                    textBox4.Text = (Convert.ToInt32(textBox4.Text) - 100).ToString();
                }
                else if (Minute != 0 && Second == 0)
                {
                    Minute--;
                    Second = 59;
                    textBox4.Text = (Convert.ToInt32(textBox4.Text) - 100).ToString();
                }
                else if (Second != 0)
                {
                    Second--;
                }
                textBox5.Text = Hour.ToString() + ":" + Minute.ToString() + ":" + Second.ToString();
                srmt.Send(this.user_name + " " + textBox5.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ls = new LockScreen(1,list);
            activate = true;
            ls.user_name= this.user_name;
            ls.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();

            srmt.Send(this.user_name + " " + textBox5.Text);
            Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RESETPASS rp = new RESETPASS(this.user_name,list);
            rp.nemdl += ResetPass_nemdl;
            rp.Show();
        }

        private void ResetPass_nemdl(string username, string password)
        {
            srmt.Send(username  + " resetpass " + password );
            foreach(DataRow dr in list[0].Rows)
            {
                if (dr["user_name"].ToString() == username)
                {
                    dr["user_password"] = password.ToString();
                    break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rd.check)
            {
                list = rd.getListDataTable();
                dtUser = new DataTable();
                dtUser = list[0];
                dtCustomer = new DataTable();
                dtCustomer = list[1];
                dtUserRole = new DataTable();
                dtUserRole = list[2];
                dtProduct = new DataTable();
                dtProduct = list[3];
                dtGame = new DataTable();
                dtGame = list[4];
                rd.check = false;
                Load();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                timer2.Stop();
            }
        }

        private void LockScreen_FireEventLoginSuccess(string user_name, string role_name, string remaining_time)
        {
            this.user_name= user_name;
            this.role_name= role_name;
            textBox1.Text = user_name;
            arr = remaining_time.Split(':');
            
            Hour = Convert.ToInt32(arr[0]);
            Minute = Convert.ToInt32(arr[1]);
            Second = Convert.ToInt32(arr[2]);
            textBox2.Text = Hour.ToString() + ":" + Minute.ToString();
            textBox5.Text = Hour.ToString() + ":" + Minute.ToString();
            textBox3.Text = ((Hour * 60 + Minute) * 100).ToString();
            textBox4.Text = textBox3.Text;
            srmt.Send(this.user_name + " " + "Start");
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                timer1.Stop();


                updateRemainingTime(this.user_name, Hour.ToString() + ":" + Minute.ToString() + ":" + Second.ToString());
                srmt.Send(this.user_name + " " + Hour.ToString() + ":" + Minute.ToString() + ":" + Second.ToString());
                srmt.Send(this.user_name + " " + "End");
                Load();
        }
    }
}
