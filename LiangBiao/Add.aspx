<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="LiangBiao.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #left {
            float: left;
            width: 280px;
            height: 530px;
            border: 1px solid #ffd800
        }

        .style {
            margin-top: 20px;
            margin-left: 20px;
        }

        #ziti {
            color: #0e9af9;
            margin-left: 110px;
            font-weight: 900;
        }

        #btn {
            margin-top: 30px;
            margin-left: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="left">
            <label id="ziti">多表新增</label>
            <div class="style">
                员工名称：<asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            </div>
            <div class="style">
                员工头像：
                <div style="margin-top: 10px;">
                    <asp:FileUpload ID="fupload" runat="server" />
                </div>
                <div style="margin-top: 5px;">
                    <asp:Image ID="scimg" runat="server" Width="240" Height="140" />
                </div>
                <div>
                    <asp:Button ID="btn_sc" runat="server" Text="点击上传" OnClick="btn_sc_Click" />
                </div>
            </div>
            <div class="style">
                部门编号：<asp:DropDownList ID="ddl_bh" runat="server" Width="70" Height="25"></asp:DropDownList>
            </div>
            <div class="style">
                员工性别：<asp:TextBox ID="txt_sex" runat="server"></asp:TextBox>
            </div>
            <div class="style">
                员工年龄：<asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
            </div>
            <div id="btn">
                <asp:Button ID="btn_tj" runat="server" Text="点击提交" OnClick="btn_tj_Click" />
            </div>
            <div style="margin-left:100px;">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/List.aspx" Font-Size="Small">单表数据显示</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
