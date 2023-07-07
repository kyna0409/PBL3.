using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN.DAL
{
    public class news_DAL
    {
        private static news_DAL instance;
        public static news_DAL Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new news_DAL();
                }    
                return instance;
            }private set { }
        }
        public List<news>GetNews()
        {
            List<news> ret = new List<news>();
            using (VTH2Entities db = new VTH2Entities())
            {
                ret = db.news.ToList();
            }
            return ret;
        }
        public void add_DAL (news ne)
        {
            using (VTH2Entities db = new VTH2Entities())
            {
                db.news.Add(ne);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        public List<news> load()
        {
           VTH2Entities db = new VTH2Entities();
           List<news> ns = db.news.ToList();
            return ns;
        }
        public void del_DAL(int id)
        {
            using (VTH2Entities db = new VTH2Entities())
            { news cus = db.news.Find(id);
                db.news.Remove(cus);
                db.SaveChanges();
            }
        }
        public void edit_DAL(news ne)
        {
           
            using (VTH2Entities db = new VTH2Entities())
            {

                news ness = db.news.Find(ne.id);
                ne.id = ness.id;
                ness.typee = ne.typee;
                ness.title= ne.title;
                ness.content = ne.content;
                ness.create_date = ne.create_date;
                ness.image_url= ne.image_url;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công ", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
