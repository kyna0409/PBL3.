using ADMIN.BLL;
using ADMIN.DAL;
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

namespace ADMIN.GUI
{
    public partial class NEWSS : UserControl
    {
        
        public NEWSS()
        {
            InitializeComponent();
            load();
        }

        private void NEWSS_Load(object sender, EventArgs e)
        {
            load();
              
        }

     
        private void but_add_Click(object sender, EventArgs e)
        {
            Addnews addnews= new Addnews(0);
          
            if(addnews.ShowDialog()==DialogResult.OK)
            {           
                flowLayoutPanel1.Controls.Clear();
                load();
            }
        }
        public void load()
        {
            List<news> news = news_BLL.Instance.showflp();
            foreach(news item in news)
            {
                UserControlItem item2 = new UserControlItem(item.typee, item.title, item.content, (DateTime)item.create_date, (byte[])item.image_url, (int)item.id);
             flowLayoutPanel1.Controls.Add(item2);

            }

        }
       
        /* public void k_nemdl(news item)
         {
             UserControlItem item2 = new UserControlItem(item.typee, item.title, item.content, (DateTime)item.create_date, (byte[])item.image_url, (int)item.id);
             flowLayoutPanel1.Controls.Add(item2);
         }*/

    }
}
