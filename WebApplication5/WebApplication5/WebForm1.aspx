<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Test Login Page</h1>
        <p class="lead">Login using data from Database.</p>
        <asp:TextBox ID="Login" runat="server" OnTextChanged="Login_TextChanged"></asp:TextBox>
    </div>
        <p>
        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        <p>
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
