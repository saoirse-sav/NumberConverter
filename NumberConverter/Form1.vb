Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try
            Dim input As String = txtNumber.Text
            Dim number As Integer

            If Integer.TryParse(input, number) Then
                lblResult.Text = "You entered the number: " & number
            Else
                lblResult.Text = "Invalid input. Please enter a valid number."
            End If

        Catch ex As Exception
            lblResult.Text = "An error occurred: " & ex.Message
        Finally
            MessageBox.Show("Number conversion finished.")
        End Try
    End Sub
End Class
