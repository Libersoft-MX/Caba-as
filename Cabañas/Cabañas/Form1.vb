Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim z As Integer
        z = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.Exclamation + vbYesNo, "Cabañas")
        If z = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Fecha.Text = Date.Now.ToShortDateString
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tc1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tc1.SelectedIndex = 1
        Tc1_1.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tc1.SelectedIndex = 2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Tc1.SelectedIndex = 4
        Reportes.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim z As Integer
        z = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.Exclamation + vbYesNo, "Cabañas")
        If z = vbYes Then
            End
        End If
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Tc1.SelectedIndex = 3
    End Sub

    Private Sub FlowLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel5.Paint

    End Sub
End Class
