Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker7_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker7.ValueChanged
        If DateTimePicker7.Checked = True Then DateTimePicker8.Enabled = True

    End Sub
End Class
