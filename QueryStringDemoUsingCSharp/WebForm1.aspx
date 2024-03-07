<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QueryStringDemoCSharp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" herf ="style.css"/>

</head>
<body>
    <form id="form2" runat="server">
        <div class="container">
            <center>
                <h1>Query String Demo</h1>
                    Firstname: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
                    Lastname : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
                    Age : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
                   <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </center>
        </div>
    </form>
</body>
</html>
