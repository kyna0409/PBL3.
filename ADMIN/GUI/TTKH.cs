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
    public partial class TTKH : UserControl
    {
        
        public TTKH()
        {
            InitializeComponent();
           setDGV();
        }
        public void show()
        {
           /* VTH2Entities db= new VTH2Entities();
            dgv.DataSource = db.customers.Select(p => new { p.id, p.user_name, p.remaining_time }).ToList();
*/
        }
        public void setDGV()
        {
            dgv.DataSource = TTKH_BLL.Instance.showdgv().DataSource;

        }
        
       
        private void TTKH_Load(object sender, EventArgs e)
        {
            show();
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            /*VTH2Entities db= new VTH2Entities();
            if(textBox1.Text!="")
            {
                dgv.DataSource = db.customers.Where(p => p.user_name.Contains(textBox1.Text))
                    .Select(p => new { p.id,p.user_name, p.remaining_time}).ToList();
                textBox1.Text = null;
            }*/

            /*if(textBox1!=null)
            {
                dgv.DataSource = TTKH_BLL.Instance.search_BLL(textBox1.Text);
                //textBox1.Text = null;
            }  */
            if (textBox1.Text != " ")
            {
                dgv.DataSource = TTKH_BLL.Instance.search_BLL(textBox1.Text).DataSource;
            }
            else
            {
                setDGV();
            }

            

        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgv.SelectedRows)
                {
                   
                   int id = Convert.ToInt32(i.Cells[0].Value.ToString());
                   TTKH_BLL.Instance.delBLL(id);
                }
                MessageBox.Show("Đã xóa thành công  ra khỏi danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("Chưa chọn cột muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setDGV();
        }
        private void but_Add_Click(object sender, EventArgs e)
        {
          
          using(AddEdit addEdit=new AddEdit(0))
            {
                if(addEdit.ShowDialog()==DialogResult.OK)
                {
                    setDGV();
                }    
            }    
           
        }
        private void but_edit_Click(object sender, EventArgs e)
        {
            
            string id = dgv.CurrentRow.Cells["id"].Value.ToString();

            customer c = TTKH_BLL.Instance.GetCustomerByID(Convert.ToInt32(id));
            using (AddEdit addEdit = new AddEdit(1, c))
            {
                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    setDGV();
                }
            }

        }

      
    }
      
}

