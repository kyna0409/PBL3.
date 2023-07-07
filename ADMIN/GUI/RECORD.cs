using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADMIN.BLL;
using ADMIN.DTO;
using ADMIN.GUI;

namespace ADMIN
{
    public partial class RECORD : Form
    {
        public RECORD()
        {
            InitializeComponent();
            setDGV();
        }
        public void setDGV()
        {
            dataGridView1.DataSource = RECORD_BLL.Instance.showRECORD().DataSource;

        }
        private void but_add_Click(object sender, EventArgs e)
        {
            using (Addrecord addEdit = new Addrecord(0))
            {
                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    setDGV();
                }
            }

        }

        private void but_edit_Click(object sender, EventArgs e)
        {

        }

        private void but_delete_Click(object sender, EventArgs e)
        {

        }

        private void but_search_Click(object sender, EventArgs e)
        {

        }

        private void RECORD_Load(object sender, EventArgs e)
        {
            /*this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;*/
        }
    }
}
