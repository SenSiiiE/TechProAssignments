<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="viewStateDemoByVB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

    </title>
    <link rel="stylesheet" href="Stylesheet.css" text="text/css"/>
</head>
<body>
   <div class="container">
        <form id="form1" runat="server">
            <h1 class="center">ViewState Demo</h1>
            <p class="center buttons">
                UserName: <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" AutoCompleteType="Disabled"></asp:TextBox>
                <br /><br />MobileNo: <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox"></asp:TextBox>
                <br /><br />
                Password: <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Restore" />
            </p>
        </form>
    </div>
</body>
</html>