<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumeWCF.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Enter a  Name:
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="BtnHttp" runat="server" Text="Invoke Http" OnClick="BtnHttp_Click" /> &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnTcp" runat="server" Text="Invoke TCP" OnClick="BtnTcp_Click" />
        </p>
        <asp:Label ID="lblOutput1" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblOutput2" runat="server"></asp:Label>
    </form>
</body>
</html>
