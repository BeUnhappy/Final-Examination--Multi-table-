using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;

namespace BLL
{
    public class T_DeptBLL
    {
        public static DataTable Getlist()
        {
            return T_DeptDAL.Getlist();
        }
    }
}
