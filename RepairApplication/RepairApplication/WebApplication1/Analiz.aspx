<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Analiz.aspx.cs" Inherits="RepairWebApplication.Analiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ремонт</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Количество проведенных ремонтов за 2014 год:

        <asp:GridView ID="dataGridView2" runat="server" BackColor="#FDF5E6" BorderColor="#FDF5E6" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
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

    
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="На главную" Width="296px" />

    
    </div>
    </form>
</body>
</html>