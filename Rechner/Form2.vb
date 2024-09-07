Public Class Settings
    Public Property WR = 0
    Private Sub BAuS_Click(sender As Object, e As EventArgs) Handles BAuS.Click
        If (WR = 0) Then
            WR = 1
            BAuS.Text = "An"
        Else
            BAuS.Text = "Aus"
            WR = 0
        End If
    End Sub

    Private Sub BSPE_Click(sender As Object, e As EventArgs) Handles BSPE.Click
        If (WR = 1) Then
            Form1.WR = 1
        Else
            Form1.WR = 0
        End If
        If (WR = 0) Then
            Form1.BO.Visible = False
            Form1.BPi.Visible = False
            Form1.BE.Visible = False
            Form1.BR.Visible = False
        End If
        If (WR = 1) Then
            Form1.BO.Visible = True
            Form1.BPi.Visible = True
            Form1.BE.Visible = True
            Form1.BR.Visible = True
        End If
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Form1.WR = 0) Then
            WR = 0
            BAuS.Text = "Aus"
        End If
    End Sub

    Private Sub BABR_Click(sender As Object, e As EventArgs) Handles BABR.Click
        Me.Close()
    End Sub

    Private Sub BINFO_Click(sender As Object, e As EventArgs) Handles BINFO.Click
        Info.Show()
    End Sub
End Class