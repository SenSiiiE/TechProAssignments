Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewState("name") = TextBox1.Text
        ViewState("password") = TextBox2.Text
        ViewState("phone") = TextBox3.Text


        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ViewState("name") IsNot Nothing Then
            TextBox1.Text = ViewState("name").ToString()
        End If

        If ViewState("password") IsNot Nothing Then
            TextBox2.Text = ViewState("password").ToString()
        End If

        If ViewState("phone") IsNot Nothing Then
            TextBox3.Text = ViewState("phone").ToString()
        End If
    End Sub

End Class