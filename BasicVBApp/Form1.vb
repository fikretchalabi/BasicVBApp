Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_1.Click

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        lbl_1.Visible = True


    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        lbl_1.ForeColor = Color.Orange




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        MessageBox.Show("Hello I am Window in VB")


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        btn_3.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        btn_3.Visible = True

    End Sub
End Class
