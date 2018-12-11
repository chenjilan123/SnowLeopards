using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDAL;

namespace SnowLeopard
{
    public class DalProxy
    {
        private const string ConnectionString = 
            "Data Source=192.168.3.87;Initial Catalog=TopDB;Integrated Security=SSPI;UID=sa;PWD=top@db123";

        private static DBHelper _sql = null;
        public static DBHelper Sql
        {
            get
            {
                return _sql;
            }
        }
        static DalProxy()
        {
            _sql = new DBHelper(ConnectionString);
        }
    }
}
