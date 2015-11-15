<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Brigadi.aspx.cs" Inherits="RepairWebApplication.Brigadi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Бригады</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="brigadadataGridView" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="332px">
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
    
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="На главную" Width="296px" />
    
    </div>
    </form>
</body>
</html>