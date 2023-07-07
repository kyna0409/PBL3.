using ADMIN.BLL;
using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ADMIN.GUI
{
    public partial class AddEdit : Form
    {
       public delegate void NemDL(customer cus);
        int IDS;
        
        public AddEdit(int iDS)
        {
            InitializeComponent();
            IDS = iDS;
        }
        public event NemDL nemdl = null;
        public AddEdit(int iDS, customer obj)
        {
            InitializeComponent();
            txt_id.Text = obj.id.ToString();
            txt_username.Text = obj.user_name;
            txt_remainingtime.Text = obj.remaining_time;
            IDS = iDS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IDS == 0)
            {
                
                TTKH_BLL.Instance.add_BLL(txt_username.Text, txt_remainingtime.Text);
            }
            else
            {
                customer cus = new customer();
                cus.id =Convert.ToInt32( txt_id.Text);
                cus.user_name = txt_username.Text;
                cus.remaining_time = txt_remainingtime.Text;
               
                TTKH_BLL.Instance.edit_BLL(cus);
               
            //   if (nemdl != null) nemdl(cus);
            }
        }

        private void AddEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
