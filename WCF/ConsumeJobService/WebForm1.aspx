<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumeJobService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Enter a  Role:
        <asp:TextBox ID="TxtRole" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="BtnHttp" runat="server" Text="Invoke Http" OnClick="BtnHttp_Click" /> &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnTcp" runat="server" Text="Invoke TCP" OnClick="BtnTcp_Click" />
        </p>        
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
