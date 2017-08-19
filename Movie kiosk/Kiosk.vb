Imports System.Reflection
Imports DotNetBrowser

Public Class Kiosk
    Private Sub Netflixbtn_Click(sender As Object, e As EventArgs) Handles Netflixbtn.Click

        Browser.URL = "https://www.netflix.com"
        Browser.Update()

    End Sub

    Private Sub Ziggobtn_Click(sender As Object, e As EventArgs) Handles Ziggobtn.Click
        Browser.URL = "https://www.ziggogo.tv/nl/tv-kijken.html"
        Browser.Update()
    End Sub

    Private Sub Youtubebtn_Click(sender As Object, e As EventArgs) Handles Youtubebtn.Click
        Browser.URL = "https://www.youtube.com"
        Browser.Update()
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Maximizebtn_Click(sender As Object, e As EventArgs) Handles Maximizebtn.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Minimizebtn_Click(sender As Object, e As EventArgs) Handles Minimizebtn.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Shutdownbtn_Click(sender As Object, e As EventArgs) Handles Shutdownbtn.Click
        Process.Start("cmd", "/c echo dit is een test")
        'Process.Start("cmd", "/c shutdown -s -t 10")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim t As Type = GetType(System.Reflection.Assembly)
        'Dim s As String = t.Assembly.FullName.ToString()

        'Dim classname As AssemblyName.GetAssemblyName(".\UtilityLibrary.dll")
        Dim ClassName As String = Me.GetType().Name
        Label1.Text = ClassName


    End Sub
End Class