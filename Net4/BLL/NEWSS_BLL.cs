using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net4.DTO;
using Net4.DAL;

namespace Net4.BLL
{
    public class NEWSS_BLL
    {
        private static NEWSS_BLL instance;
        public static NEWSS_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEWSS_BLL();
                }
                return instance;
            }
            private set { }
        }

        public DataTable GetAllNEWS()
        {
            return NEWSS_DAL.Instance.getAllNews();
        }
    }
}
