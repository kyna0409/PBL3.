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
using static ADMIN.GUI.AddEdit;

namespace ADMIN.GUI
{
    public partial class Addnews : Form
    {
        public  delegate void NemDL(news ne);
        int IDS;
        public Addnews(int iDS)
        {
            InitializeComponent();
            IDS= iDS;
        }
        public Addnews(int iDS,news ne)
        {

            InitializeComponent();
            txt_lab.Text = ne.id.ToString();
            txt_type.Text = ne.typee;
            txt_title.Text = ne.title;
            txt_content.Text = ne.content;
            txt_title.Text = ne.title;
            dateTimePicker1.Value = ne.create_date;
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageData = ms.ToArray();
                ne.image_url = imageData;
            }
            news_BLL.Instance.edit_BLL(ne);
            IDS= iDS;
            
        }
        public event NemDL nemdl1 = null;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)|*.jpg;*.jpeg;*.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    
                }

            }
        }
       

        private void but_save_Click(object sender, EventArgs e)
        {
          if(IDS==0)
            {
                news ne = new news();
                ne.typee = txt_type.Text;
                ne.title = txt_title.Text;
                ne.content = txt_content.Text;
                ne.create_date = dateTimePicker1.Value;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] NVpic = ms.GetBuffer();
                ms.Close();
                ne.image_url = NVpic;
                news_BLL.Instance.add_BLL(ne);
                MessageBox.Show("đã lưu thành công !!!");
                // this.Dispose();

            }
            else
            {
                news ne = new news();
                ne.id = Convert.ToInt32(txt_lab.Text);
                ne.typee= txt_type.Text;
                ne.title= txt_title.Text;
                ne.content = txt_content.Text;
                ne.create_date = dateTimePicker1.Value;
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageData = ms.ToArray();
                    ne.image_url = imageData;
                }
                news_BLL.Instance.edit_BLL(ne);
                
            }

        }

        private void Addnews_Load(object sender, EventArgs e)
        {

        }
    }
}
