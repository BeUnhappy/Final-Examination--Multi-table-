using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    public class T_DeptDAL
    {
        public static DataTable Getlist()
        {
            string sql = "select * from T_Dept";
            return DBhelp.Read(sql);
        }
    }
}
