using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL;

namespace LiangBiao
{
    public partial class Add : System.Web.UI.Page
    {
        //下拉列表显示
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddl_bh.DataSource = BLL.T_DeptBLL.Getlist();
                this.ddl_bh.DataTextField = "DeptName";
                this.ddl_bh.DataValueField = "DeptId";
                this.ddl_bh.DataBind();
            }
        }
        //上传图片
        protected void btn_sc_Click(object sender, EventArgs e)
        {
            if (fupload.HasFile)
            {
                string path = Server.MapPath("~/img/");
                fupload.SaveAs(path + fupload.FileName);
                this.scimg.ImageUrl = "/img/" + fupload.FileName;
            }
        }
        //提交按钮
        protected void btn_tj_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text;
            string img = this.scimg.ImageUrl;
            int department = Convert.ToInt32(this.ddl_bh.SelectedValue);
            string sex = this.txt_sex.Text;
            int age = Convert.ToInt32(this.txt_age.Text);

            T_Employee emp = new T_Employee
            {
                EmployeeName=name,
                ImageUrl=img,
                DeptId= department,
                Sex=sex,
                Age=age
            };
            if (BLL.T_EmployeeBLL.Add(emp))
            {
                Response.Write("<script>alert('提交成功...')</script>");
            }
            else
            {
                Response.Write("<script>alert('提交失败...')</script>");
            }
        }
    }
}