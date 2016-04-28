<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="SilverGuacamoleWF.Customer.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Edit</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox id="NameInput" type="text" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Phone"></asp:Label>
        <br />
        <asp:TextBox ID="PhoneInput" type="text" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Update" />
        <asp:HyperLink ID="HyperLink1" href="Index" runat="server">Cancel</asp:HyperLink>
        
    </div>
    </form>
</body>
</html>
