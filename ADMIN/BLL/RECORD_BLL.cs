using ADMIN.BLL;
using ADMIN.DAL;
using ADMIN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public class RECORD_BLL
    {
        private static RECORD_BLL instance;
        public static RECORD_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RECORD_BLL();
                }
                return instance;
            }
            private set { }
        }
        public DataGridView showRECORD()
        {
            return RECORD_DAL.Instance.getRECORD();
        }
       public void add_BLL(record re)
        {
           RECORD_DAL.Instance.add_DAL(re);
        }
    
        
    }
}
