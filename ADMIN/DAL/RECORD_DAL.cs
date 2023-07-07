using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public  class RECORD_DAL
    {
        private static RECORD_DAL instance;
        public static RECORD_DAL Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new RECORD_DAL();
                }   
                return instance;
            }private set { }
        }
        public List<record> GetRecord()
        {
            List<record> ret = new List<record>();
            using (VTH2Entities db = new VTH2Entities())
            {
                ret = db.records.ToList();
            }
            return ret;
        }
        public DataGridView getRECORD()
        {
            DataGridView record = new DataGridView();
            using (VTH2Entities db = new VTH2Entities())
            {
                record.DataSource = db.records.Select(p => new {

                    p.id,
                    p.customer_id,
                    p.computer_id,
                    p.start_time, 
                    p.end_time,
                }).ToList();
            }
            return record;
        }
     public void add_DAL(record re)
        {
            using(VTH2Entities db=new VTH2Entities())
            {
                db.records.Add(re);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
