Imports System.Reflection.Emit

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim firstname As String = Request.QueryString("firstname")
        Dim lastname As String = Request.QueryString("lastname")
        Label1.Text = "Hi, Welcome " & firstname & " " & lastname
    End Sub

End Class