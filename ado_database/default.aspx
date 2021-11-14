<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ado_database._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            name -
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            <br />
            address -
            <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            postcode -
            <asp:TextBox ID="tbPostCode" runat="server"></asp:TextBox>
            <br />
            <br />
            notes -<asp:TextBox ID="tbNotes" runat="server"></asp:TextBox>
            <br />
            <br />
            city -
            <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="buttonEnterData" runat="server" OnClick="buttonEnterData_Click" Text="Enter" />
            <br />
            <br />
            <br />
        </div>
        <asp:GridView ID="gridviewCustomers" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
