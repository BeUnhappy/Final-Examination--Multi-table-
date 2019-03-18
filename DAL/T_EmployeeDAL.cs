using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    public class T_EmployeeDAL
    {
        //显示数据
        public static List<T_Employee> GetList()
        {
            string sql = "select * from T_Employee";
            DataTable table = DBhelp.Read(sql);
            List<T_Employee> lst = new List<T_Employee>();
            foreach (DataRow row in table.Rows)
            {
                T_Employee emp = new T_Employee
                {
                    EmployeeId = Convert.ToInt32(row["EmployeeId"]),
                    EmployeeName = row["EmployeeName"].ToString(),
                    ImageUrl = row["ImageUrl"].ToString(),
                    DeptId = Convert.ToInt32(row["DeptId"]),
                    Sex = row["Sex"].ToString(),
                    Age = Convert.ToInt32(row["Age"])
                };
                lst.Add(emp);
            }
            return lst;
        }
        //查询下拉列表中的列表
        public static DataTable GetListTable()
        {
            string sql = "select * from T_Employee join T_Dept on T_Employee.DeptId=T_Dept.DeptId";
            return DBhelp.Read(sql);
        }
        //添加员工--直接向T_Employee中加入
        public static bool Add(T_Employee emp)
        {
            string sql = string.Format("insert into T_Employee values('{0}','{1}','{2}','{3}','{4}')", emp.EmployeeName, emp.ImageUrl, emp.DeptId, emp.Sex, emp.Age);
            return DBhelp.Write(sql);
        }
        //删除
        public static bool Delete(int EmployeeId)
        {
            string sql = string.Format("delete from T_Employee where EmployeeId='{0}'", EmployeeId);
            return DBhelp.Write(sql);
        }
    }
}
