<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="LiangBiao.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #right {
            float: left;
            width: 420px;
            height: 500px;
            border: 1px dashed #ffd800
        }
         #ziti2 {
            color: #0e9af9;
            margin-left: 150px;
            font-weight: 900;
        }
    </style>
    <script type="text/javascript">
        function sc() {
            var jg = confirm("确认删除吗？");
            return jg;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="right">
            <label id="ziti2">多表数据显示</label>
            <asp:Repeater ID="Rep" runat="server"  OnItemCommand="Rep_ItemCommand">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <td>员工编号</td>
                            <td>员工名称</td>
                            <td>员工头像</td>
                            <td>部门编号</td>
                            <td>性别</td>
                            <td>年龄</td>
                            <td>操作</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("EmployeeId") %></td>
                        <td><%#Eval("EmployeeName") %></td>
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ImageUrl") %>'  Width="65" Height="30"/></td>
                        <%-- 多表联查直接使用部门表名称 --%>
                        <td><%#Eval("DeptName") %></td>
                        <td><%#Eval("Sex") %></td>
                        <td><%#Eval("Age") %></td>
                        <td>
                            <asp:LinkButton ID="link_sc" runat="server" OnClientClick="return sc()" CommandName="sc" CommandArgument='<%#Eval("EmployeeId") %>'>删除</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
