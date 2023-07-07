using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADMIN.DTO;
namespace ADMIN
{
    public class DKTK_DAL
    {
        private static DKTK_DAL instance;
        public static DKTK_DAL Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new DKTK_DAL();
                } 
                return instance;
            }private set { }
        }
        List<user>GetUsers()
        {
            List<user> ret = new List<user>();
            using (VTH2Entities db = new VTH2Entities())
            {
                ret = db.users.ToList();
            }
            return ret;
        }
        public void add(user user)
        {

        }

    }
}
