Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim curYear As Integer
        Dim curPop As Double

        curYear = 2013
        curPop = 7000000000

        Do While (curPop > 6000000)
            curYear = curYear - 50
            curPop = curPop / 2

        Loop





        MessageBox.Show("The year is " & curYear, "Error")

    End Sub
End Class
