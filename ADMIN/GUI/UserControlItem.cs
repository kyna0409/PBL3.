using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADMIN.BLL;
using ADMIN.DTO;
using ADMIN.GUI;

namespace ADMIN
{
    public partial class UserControlItem : UserControl
    {
       
        public UserControlItem()
        {
            InitializeComponent();

        }



        public UserControlItem(string typee,string title,string content,DateTime time, byte[] image,int id)
        {
            InitializeComponent();
            lab_type.Text = typee;
            lab_title.Text = title;
            lab_Content.Text = content;
            lab_time.Text = time.ToShortDateString();
            if(image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            lbID.Text = id.ToString();

        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            /* VTH2Entities db = new VTH2Entities();

              news ns = db.news.Find(cs);
              int cs = Convert.ToInt32(lbID.Text);
              db.news.Remove(ns);
              db.SaveChanges();
              MessageBox.Show("bạn có muốn xóa không");
              this.Dispose();*/
            int cs = Convert.ToInt32(lbID.Text);
            news_BLL.Instance.del_BLL(cs);
            MessageBox.Show("bạn có muốn xóa không");
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cs=Convert.ToInt32(lbID.Text);
            news c = news_BLL.Instance.GetNewsByID(cs);
            using (Addnews addEdit = new Addnews(1, c))
            {
                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    news_BLL.Instance.edit_BLL(c);
                }
            }

        }
    }
}
