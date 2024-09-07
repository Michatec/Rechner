Public Class Form1

    Public Property Zahl As String = ""
    Public Property Calc As String = ""
    Public Property WR = 0

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        TB1.Text += "1"
    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        TB1.Text += "0"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        TB1.Text += "3"
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        TB1.Text += "6"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        TB1.Text += "5"
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        TB1.Text += "4"
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        TB1.Text += "7"
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        TB1.Text += "8"
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        TB1.Text += "9"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        TB1.Text += "2"
    End Sub

    Private Sub BDel_Click(sender As Object, e As EventArgs) Handles BDel.Click
        If (TB1.Text.Length > 0) Then
            TB1.Text = TB1.Text.Substring(0, TB1.Text.Length - 1)
        End If
    End Sub

    Private Sub BAC_Click(sender As Object, e As EventArgs) Handles BAC.Click
        Calc = ""
        Zahl = ""
        TB1.Text = ""
        L1.Text = ""
        L2.Text = ""
    End Sub

    Private Sub BG_Click(sender As Object, e As EventArgs) Handles BG.Click
        If (Calc = "+") Then
            TB1.Text = Val(Zahl) + Val(TB1.Text)
        End If
        If (Calc = "-") Then
            TB1.Text = Val(Zahl) - Val(TB1.Text)
        End If
        If (Calc = "/") Then
            TB1.Text = Val(Zahl) / Val(TB1.Text)
        End If
        If (Calc = "*") Then
            TB1.Text = Val(Zahl) * Val(TB1.Text)
        End If

        L1.Text = ""
        L2.Text = ""

    End Sub

    Private Sub BMal_Click(sender As Object, e As EventArgs) Handles BMal.Click
        Zahl = TB1.Text
        L2.Text = Zahl
        TB1.Text = ""

        Calc = "*"
        L1.Text = Calc
    End Sub

    Private Sub BGE_Click(sender As Object, e As EventArgs) Handles BGE.Click
        Zahl = TB1.Text
        L2.Text = Zahl
        TB1.Text = ""

        Calc = "/"
        L1.Text = Calc
    End Sub

    Private Sub BMin_Click(sender As Object, e As EventArgs) Handles BMin.Click
        Zahl = TB1.Text
        L2.Text = Zahl
        TB1.Text = ""

        Calc = "-"
        L1.Text = Calc
    End Sub

    Private Sub BPlus_Click(sender As Object, e As EventArgs) Handles BPlus.Click
        Zahl = TB1.Text
        L2.Text = Zahl
        TB1.Text = ""

        Calc = "+"
        L1.Text = Calc
    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        TB1.Text += "."
    End Sub

    Private Sub BR_Click(sender As Object, e As EventArgs) Handles BR.Click
        TB1.Text = Math.Round(Val(TB1.Text))
    End Sub

    Private Sub BO_Click(sender As Object, e As EventArgs) Handles BO.Click
        TB1.Text = 1.0 / Val(TB1.Text)
    End Sub

    Private Sub BPi_Click(sender As Object, e As EventArgs) Handles BPi.Click
        TB1.Text = Math.PI
    End Sub

    Private Sub BE_Click(sender As Object, e As EventArgs) Handles BE.Click
        TB1.Text = Math.E
    End Sub

    Private Sub BINFO_Click(sender As Object, e As EventArgs) Handles BINFO.Click
        Info.ShowDialog()
    End Sub

    Private Sub BSET_Click(sender As Object, e As EventArgs) Handles BSET.Click
        Settings.Show()
    End Sub
End Class
