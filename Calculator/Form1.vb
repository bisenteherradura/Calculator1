Imports System.Reflection.Emit

Public Class Form1
    Dim firstnum As Decimal
    Dim secondnum As Decimal
    Dim operation As Integer
    Dim Operator_selector As Boolean = False
    Dim int As Integer = 0
    Dim doub As Double = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles equals.Click
        Label.Text = Label.Text + result.Text
        Label.Text = Label.Text + " ="

        If Operator_selector = True Then
            secondnum = result.Text

            If operation = 1 Then
                result.Text = firstnum + secondnum
            ElseIf operation = 2 Then
                result.Text = firstnum - secondnum
            ElseIf operation = 3 Then
                result.Text = firstnum * secondnum
            Else
                If secondnum = 0 Then
                    result.Text = "Error"
                Else
                    result.Text = firstnum / secondnum
                End If
            End If
            Operator_selector = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles point.Click
        If Not (result.Text.Contains(".")) Then
            result.Text += "."
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles zero.Click
        If result.Text <> "0" Then
            result.Text += "0"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles negative.Click
        If Not String.IsNullOrEmpty(result.Text) AndAlso result.Text <> "0" Then
            If result.Text.StartsWith("-") Then
                ' If the number is negative, remove the negative sign
                result.Text = result.Text.Substring(1)
            Else
                ' If the number is positive, add a negative sign
                result.Text = "-" & result.Text
            End If
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles one.Click
        If result.Text <> "0" Then
            result.Text += "1"
        Else
            result.Text = "1"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles two.Click
        If result.Text <> "0" Then
            result.Text += "2"
        Else
            result.Text = "2"

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles three.Click
        If result.Text <> "0" Then
            result.Text += "3"
        Else
            result.Text = "3"
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles add.Click
        Label.Text = Label.Text + result.Text
        Label.Text = Label.Text + " + "
        firstnum = result.Text
        result.Text = "0"
        Operator_selector = True
        operation = 1 ' = +

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles four.Click
        If result.Text <> "0" Then
            result.Text += "4"
        Else
            result.Text = "4"

        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles five.Click
        If result.Text <> "0" Then
            result.Text += "5"
        Else
            result.Text = "5"

        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles six.Click
        If result.Text <> "0" Then
            result.Text += "6"
        Else
            result.Text = "6"

        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles minus.Click
        Label.Text = Label.Text + result.Text
        Label.Text = Label.Text + " - "
        firstnum = result.Text
        result.Text = "0"
        Operator_selector = True
        operation = 2 ' = -

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles seven.Click
        If result.Text <> "0" Then
            result.Text += "7"
        Else
            result.Text = "7"

        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles eight.Click
        If result.Text <> "0" Then
            result.Text += "8"
        Else
            result.Text = "8"

        End If


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles nine.Click
        If result.Text <> "0" Then
            result.Text += "9"
        Else
            result.Text = "9"

        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles multiply.Click
        Label.Text = Label.Text + result.Text
        Label.Text = Label.Text + " x "
        firstnum = result.Text
        result.Text = "0"
        Operator_selector = True
        operation = 3 ' = x

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles backspace.Click
        Dim _input As String = result.Text
        If _input.Length > 1 Then
            result.Text = _input.Remove(_input.Length - 1, 1)
        Else
            result.Text = "0"

        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles ce.Click
        result.Text = "0"

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles c.Click
        result.Text = "0"
        Label.Text = ""
        int = 0
        doub = 0

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles divide.Click
        Label.Text = Label.Text + result.Text
        Label.Text = Label.Text + " ÷ "
        firstnum = result.Text
        result.Text = "0"
        Operator_selector = True
        operation = 4 ' = ÷

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles result.TextChanged

    End Sub
End Class
