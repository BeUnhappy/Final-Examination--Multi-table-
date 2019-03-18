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
    public class T_EmployeeBLL
    {
        //读取全部
        public static List<T_Employee> GetList()
        {
            return T_EmployeeDAL.GetList();
        }
        //读取下拉列表
        public static DataTable GetListTable()
        {
            return T_EmployeeDAL.GetListTable();
        }
        //新增
        public static bool Add(T_Employee emp)
        {
            return T_EmployeeDAL.Add(emp);
        }
        //删除
        public static bool Delete(int EmployeeId)
        {
            return T_EmployeeDAL.Delete(EmployeeId);
        }
    }
}
