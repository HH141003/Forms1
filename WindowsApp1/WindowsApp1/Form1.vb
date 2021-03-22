Public Class Form1
    'Start Button
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        lblOutput.Text = "Your full name is " & txtName.Text & " " & txtSurname.Text
        cmdStart.BackColor = Color.Red
        If rbtOver.Checked Then
            lblOutput2.Text = "You are over 24 years old"
        End If

        If rbtUnder.Checked Then
            lblOutput2.Text = "You are under 24 years old"
        End If
    End Sub

    Private Sub cmdStart_MouseEnter(sender As Object, e As EventArgs) Handles cmdStart.MouseEnter
        cmdStart.BackColor = Color.Green
    End Sub

    Private Sub cmdStart_MouseLeave(sender As Object, e As EventArgs) Handles cmdStart.MouseLeave
        cmdStart.BackColor = Color.White
    End Sub

    'Clear Button

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        lblOutput.Text = ""
        cmdStart.BackColor = Color.White
        txtName.Text = ""
        txtSurname.Text = ""
        lblOutput2.Text = ""

    End Sub

    Private Sub cmdClear_MouseEnter(sender As Object, e As EventArgs) Handles cmdClear.MouseEnter
        cmdClear.BackColor = Color.Red
    End Sub

    Private Sub cmdClear_MouseLeave(sender As Object, e As EventArgs) Handles cmdClear.MouseLeave
        cmdClear.BackColor = Color.White
    End Sub
    'Exit Button
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim frm As New Form1
        frm.Show()

        Me.Close()
    End Sub

    Private Sub cmdExit_MouseEnter(sender As Object, e As EventArgs) Handles cmdExit.MouseEnter
        cmdExit.BackColor = Color.Yellow
    End Sub

    Private Sub cmdExit_MouseLeave(sender As Object, e As EventArgs) Handles cmdExit.MouseLeave
        cmdExit.BackColor = Color.White
    End Sub


End Class
