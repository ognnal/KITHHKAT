Public Class Loading

    Private Sub Loading_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Timer1.Stop()
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
        End If
    End Sub
End Class