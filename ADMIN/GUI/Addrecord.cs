using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADMIN.BLL;
namespace ADMIN.GUI
{
    public partial class Addrecord : Form
    {
        int ISD;
       
        public Addrecord(int iSD)
        {
            InitializeComponent();
            ISD= iSD;
        }
        public Addrecord(int iSD,record re)
        {
            InitializeComponent();
            
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
          if(ISD==0)
            {
                record re=new record();
                re.id = txt_id.Text;
                re.customer_id= txt_customer.Text;
                re.computer_id= txt_computer.Text;
                re.start_time = dateTime_start.Value;
                re.end_time= dateTime_end.Value;
                RECORD_BLL.Instance.add_BLL(re);
            }
        }
    }
}
