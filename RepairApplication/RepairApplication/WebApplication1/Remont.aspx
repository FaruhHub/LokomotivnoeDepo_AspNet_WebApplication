<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Remont.aspx.cs" Inherits="RepairWebApplication.Remont" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 712px;
        }
        .auto-style3 {
            height: 50px;
        }
        .auto-style4 {
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" class="auto-style3">
                    <asp:GridView ID="RemontGridView" runat="server" Width="1153px" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="#FDF5E6" BorderColor="#FDF5E6" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"  PageSize="8" Height="174px">
                        <FooterStyle BackColor="#E6E6FA" ForeColor="#FFF0F5" />
                        <HeaderStyle BackColor="#B0C4DE" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#E0FFFF" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#A0522D" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </td>
            </tr>
             <tr>
                <td class="auto-style2" rowspan="4">
                    <asp:Label ID="Label1" runat="server" Text="Поиск вагонов по типу ремонта:"></asp:Label>
                    
                    &nbsp;
                    
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Поиск" Width="133px"  />
                    
                    <asp:GridView ID="SearchGridView" runat="server" Width="774px" BackColor="#FDF5E6" BorderColor="#FDF5E6" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="margin-top: 13px">
                        <FooterStyle BackColor="#E6E6FA" ForeColor="#FFF0F5" />
                        <HeaderStyle BackColor="#B0C4DE" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#E0FFFF" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#A0522D" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Добавить новый ремонт локомотива" Width="295px" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Удалить локомотив" Width="296px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="На главную" Width="296px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
