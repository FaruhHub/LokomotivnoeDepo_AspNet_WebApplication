<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RepairWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 564px;
        }
        .auto-style2 {
            width: 712px;
        }
        .auto-style3 {
            height: 321px;
        }
    </style>
</head>
<body style="height: 577px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" class="auto-style3">
                    <asp:GridView ID="RepairGridView" runat="server" Width="1153px" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="#FDF5E6" BorderColor="#FDF5E6" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnPageIndexChanging="PersonGridView_PageIndexChanging" OnSelectedIndexChanged="PersonGridView_SelectedIndexChanged" PageSize="8" Height="174px">
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

                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Вывести информацию о вагонах, прикрепленных к депо " OnCheckedChanged="CheckBox1_CheckedChanged" />
                </td>

            </tr>
            <tr>
                <td class="auto-style2" rowspan="4">
                    <asp:GridView ID="dataGridView1" runat="server" Width="774px" BackColor="#FDF5E6" BorderColor="#FDF5E6" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="30px" style="margin-top: 19px">
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
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Бригады, прикрепленные к депо" Width="251px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Ремонт" Width="250px" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Анализ" Width="249px" OnClick="Button3_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
