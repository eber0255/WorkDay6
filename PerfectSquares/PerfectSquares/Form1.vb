﻿Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim x As Integer = 1

        Do While (x <= 10)
            lstResult.Items.Add("Perfect Square of " & x & " is " & x ^ 2)
            x = x + 1

        Loop



    End Sub
End Class
