using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net4.DTO;

namespace Net4.DAL
{
    public class NEWSS_DAL
    {
        private static NEWSS_DAL instance;
        public static NEWSS_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEWSS_DAL();
                }
                return instance;
            }
            private set { }
        }

        public DataTable getNews()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("type", typeof(String));
            dataTable.Columns.Add("title", typeof(String));
            dataTable.Columns.Add("content", typeof(String));
            dataTable.Columns.Add("create_date", typeof(DateTime));
            dataTable.Columns.Add("image_url", typeof(byte[]));
            return dataTable;
        }

        public DataTable getAllNews()
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                var queryResult = db.news.Select(p => new { p.id, p.typee, p.title, p.content, p.create_date, p.image_url });
                DataTable dataTable = getNews();

                foreach (var result in queryResult)
                {
                    dataTable.Rows.Add(result.id, result.typee, result.title, result.content, result.create_date, result.image_url);
                }
                return dataTable;
            }
        }
    }
}
