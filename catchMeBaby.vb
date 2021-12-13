Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim picNum = 1
        Dim xObj = New Random()
        Dim yObj = New Random()
        Dim picObj = New Random().Next(1, 6)
        Dim x = xObj.Next(Me.Width - btnCatchMe.Width)
        Dim y = yObj.Next(Me.Height - btnCatchMe.Height)
        lblCord.Text = "I am at x = " & x & " and y = " & y
        pcbEmoji.Image = Image.FromFile(picObj & ".png")
        btnCatchMe.Location = New Point(x, y)
    End Sub
End Class
