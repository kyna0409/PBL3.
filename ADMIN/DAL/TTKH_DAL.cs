using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADMIN.DAL
{
    public class TTKH_DAL
    {
        private static TTKH_DAL instance;
        public static TTKH_DAL Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new TTKH_DAL();
                }    
                return instance;
            }
           private set
            {

            }
        }
        public List<customer> GetCustomers()
        {
            List<customer> ret = new List<customer>();
            using (VTH2Entities db = new VTH2Entities())
            {
                ret = db.customers.ToList();
            }
            return ret;
        }
        public DataGridView getTTKH()
        {
            DataGridView ttkh = new DataGridView();
            using (VTH2Entities db=new VTH2Entities())
            {
                ttkh.DataSource = db.customers.Select(p => new {
                    p.id,
                    p.user_name,
                    p.remaining_time
                   }).ToList();
            }
            return ttkh;
        }
        public void add_DAL(string user_name,string remaining_time)
        {   using(VTH2Entities db=new VTH2Entities())
            {
                customer cus = new customer();
                cus.user_name = user_name;
                cus.remaining_time = remaining_time;
                db.customers.Add(cus);
                db.SaveChanges();

            }    
            
        }
        public void edit_DAL(customer cus)
        {
           // customer cus = new customer();
           using(VTH2Entities db=new VTH2Entities())
            {

                customer cuss = db.customers.Find(cus.id);
                cus.id= cuss.id;
                cuss.user_name=cus.user_name;
                cuss.remaining_time=cus.remaining_time;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công ", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            }    
           
        }
        public void delDAL(int id)
        {
            using(VTH2Entities db=new VTH2Entities())
            {
                customer cus = db.customers.Find(id);
                db.customers.Remove(cus);
                db.SaveChanges();
            }
        }
        public DataGridView search_DAL(string search)
        {
            DataGridView dgv = new DataGridView();
            using (VTH2Entities db = new VTH2Entities())
            {
                dgv.DataSource = db.customers.Where
                    (
                        p => p.user_name.ToUpper().Contains(search.ToUpper()) 
                    )
                    .Select(p => new { p.id, p.user_name, p.remaining_time }).ToList();
            }
            return dgv;
        }
    }
}
