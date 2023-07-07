using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Net4.DTO;

namespace Net4
{
    public partial class LockScreen : Form
    {
        public event FireEventLoginSuccess FireEventLoginSuccess = null;
        public Boolean Lockout = false;
        public Login lg;
        public Boolean Locked = false;
        public string user_name = "";
        List<DataTable> Listtables = new List<DataTable>();
        public LockScreen(int n, List<DataTable> listtables)
        {
            InitializeComponent();
            this.Locked = true;
            Listtables = listtables;
        }

        public LockScreen(List<DataTable> listtables)
        {
            InitializeComponent();
            Listtables = listtables;
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            this.Show();
            lg = new Login(Listtables);
            if (Locked)
            {
                lg.Locked= true;
                lg.user_name = user_name;
                this.Locked= false;
            }
            lg.FireEventLoginSuccess += Lg_FireEventLoginSuccess1;
            lg.ShowDialog();
        }

        private void Lg_FireEventLoginSuccess1(string user_name, string role_name,string remaining_time)
        {
            if (FireEventLoginSuccess != null) FireEventLoginSuccess(user_name,role_name,remaining_time);
            this.Dispose();
        }

        private void LockScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
