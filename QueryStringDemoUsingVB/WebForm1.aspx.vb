Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("WebForm2.aspx?firstname=" & TextBox1.Text & "&lastname=" & TextBox2.Text)
    End Sub

End Class