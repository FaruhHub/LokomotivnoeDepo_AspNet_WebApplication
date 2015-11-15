<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New_rem.aspx.cs" Inherits="RepairWebApplication.New_rem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 129px;
        }
        .auto-style3 {
            width: 160px;
        }
        .auto-style4 {
            width: 171px;
        }
        .auto-style5 {
            width: 146px;
        }
        .auto-style6 {
            background-color:#cce6cf;
        }
        .auto-style7 {
            width: 160px;
            height: 23px;
        }
        .auto-style8 {
            width: 129px;
            height: 23px;
        }
        .auto-style9 {
            width: 171px;
            height: 23px;
        }
        .auto-style10 {
            width: 146px;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
        }
    </style>
</head>
<body class="auto-style6">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Тип ремонта"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TB1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="Конец ремонта"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB6" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Стоимость ремонта"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TB2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Text="Причина поступления"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB7" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Качество ремонта"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TB3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Text="№ бригады"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB8" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Премия"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TB4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Text="Номер локомотива"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TB9" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Начало ремонта"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TB5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить " />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
