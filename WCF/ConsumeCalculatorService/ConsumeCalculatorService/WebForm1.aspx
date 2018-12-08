<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumeCalculatorService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Number1"></asp:Label>
            <asp:TextBox ID="TxtNumer1" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label>
                <asp:TextBox ID="TxtNumber2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Addition" />&nbsp;
                <asp:Button ID="BtnSub" runat="server" OnClick="BtnSub_Click" Text="Subraction" />
            </p>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
