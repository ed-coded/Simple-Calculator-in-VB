Public Class Form1
    Dim firstnum As Decimal
    Dim secondnum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "5"
        Else
            txtDisplay.Text = "5"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "6"
        Else
            txtDisplay.Text = "6"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "7"
        Else
            txtDisplay.Text = "7"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click, Button14.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "8"
        Else
            txtDisplay.Text = "8"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "9"
        Else
            txtDisplay.Text = "9"
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "0"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text += "."
        End If
    End Sub

    'this is used to calculate the addition
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = "0"
        operator_selector = True
        operations = 1 '= + operator
    End Sub

    'this is used to calculate the subtraction
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        secondnum = txtDisplay.Text
        txtDisplay.Text = "0"
        operator_selector = True
        operations = 2 '= - operator
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If operator_selector = True Then
            secondnum = txtDisplay.Text
            If operations = 1 Then
                txtDisplay.Text = firstnum + secondnum
            ElseIf operations = 2 Then
                txtDisplay.Text = firstnum - secondnum
            End If
        End If
    End Sub

    'THIS IS the cleat button
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtDisplay.Text = "0"
    End Sub
End Class
