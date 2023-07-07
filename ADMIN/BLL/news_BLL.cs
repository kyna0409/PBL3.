using ADMIN.DAL;
using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN.BLL
{
    public class news_BLL
    {
        private static news_BLL instance;
        public static news_BLL Instance
        {
            get
            {
                if(instance==null)
                {
                    instance=new news_BLL();
                }
                return instance;
            }
        }
        public news GetNewsByID(int id)
        {
            foreach (news i in news_DAL.Instance.GetNews())
            {
                if (i.id == id) return i;
            }
            return null;
        }
        public void add_BLL(news ne)
        {
             news_DAL.Instance.add_DAL(ne);
        }
        public List<news> showflp()
        {
          return news_DAL.Instance.load();
        }
        public void del_BLL(int id)
        {
            news_DAL.Instance.del_DAL(id);
        }
        public void edit_BLL(news id)
        {
            news_DAL.Instance.edit_DAL(id);
        }
    }
}
