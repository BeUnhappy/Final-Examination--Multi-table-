using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
 
namespace LiangBiao
{
    public partial class List : System.Web.UI.Page
    {
        //加载事件
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Rep.DataSource = T_EmployeeBLL.GetListTable();
                Rep.DataBind();
            }
        }
        //删除事件
        protected void Rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var cmd_name = e.CommandName;
            if (cmd_name == "sc")
            {
                int EmployeeId = Convert.ToInt32(e.CommandArgument.ToString());
                T_EmployeeBLL.Delete(EmployeeId);
            }
            Response.Redirect(Request.Url.ToString());
        }
    }
}