﻿
Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar <> " - " And Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If


        Dim pos As Integer = TextBox1.SelectionStart

        If pos < 2 Then e.Handled = True

        If pos <= 1 Then

            TextBox1.Clear()

        End If


    End Sub





    Private Sub personajuridica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles personajuridica.CheckedChanged


        hombre.Checked = False
        mujer.Checked = False
        hombre.Enabled = False
        mujer.Enabled = False




        TextBox1.Text = "30"

        TextBox1.Focus()



    End Sub

    Private Sub personafisica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles personafisica.CheckedChanged
        hombre.Enabled = True
        mujer.Enabled = True





    End Sub

    Private Sub hombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hombre.CheckedChanged

        TextBox1.SelectionStart = TextBox1.Text.Length


        If hombre.Checked Then

        End If


        TextBox1.Text = "20"

        TextBox1.Focus()




    End Sub

    Private Sub mujer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mujer.CheckedChanged


        TextBox1.SelectionStart = TextBox1.Text.Length

        If mujer.Checked Then

        End If

        TextBox1.Text = "27"

        TextBox1.Focus()



    End Sub


End Class
