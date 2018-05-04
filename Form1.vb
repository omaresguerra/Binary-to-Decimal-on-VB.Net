Public Class frmMidterm

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you really want to exit?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtText.Clear()
        txtText.Focus()
        lstConso.Items.Clear()
        lstVowel.Items.Clear()
        lstChar.Items.Clear()
    End Sub

    Private Sub btnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluate.Click
        Dim conso() As String = {"B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"}
        Dim vowel() As String = {"A", "E", "I", "O", "U"}
        Dim text As String = ""
        text = Trim(txtText.Text)

        For i As Integer = 0 To Len(text)
            If Mid(text, i, 1) <> conso(i) Then
                lstConso.Items.Add(conso(i))
            End If
        Next
    End Sub

    Private Sub frmMidterm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
