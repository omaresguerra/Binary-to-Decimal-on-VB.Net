Public Class frmMidterms

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you want to exit?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub btnEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluate.Click
        Dim array() As Integer = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 80192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824}
        Dim bin As String = ""
        Dim newBin As String = ""
        Dim x As Integer = 0
        bin = Trim(txtNum.Text)

        For i As Integer = 1 To Len(bin)
            If Mid(bin, i, 1) <> "0" And Mid(bin, i, 1) <> "1" Then
                MessageBox.Show("Invalid binary input. Try again.", "Out of Bound", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNum.SelectAll()
                txtNum.Focus()
                Exit Sub
            End If
        Next

        For i As Integer = Len(bin) To 1 Step -1
            newBin = newBin & Mid(bin, i, 1)
        Next

        For i As Integer = 0 To Len(newBin) - 1
            If Mid(newBin, i + 1, 1) = "1" Then
                x = x + array(i)
            End If
        Next

        lblDecimal.Text = x.ToString



        'Dim pwrOf2 As Integer = 0
        'Dim ans As Long = 0L
        'If Long.TryParse(txtNum.Text, Nothing) Then
        '    For Each n As Char In txtNum.Text.Reverse
        '        Select Case n
        '            Case Is = "0"c
        '            Case Is = "1"c
        '                ans += 1L << pwrOf2
        '            Case Else
        '                Stop
        '        End Select
        '        pwrOf2 += 1

        '    Next
        '    lblDecimal.Text = ans.ToString
        'Else
        'End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNum.Clear()
        txtNum.Focus()
        lblDecimal.Text = ""
    End Sub

    Private Sub frmMidterms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class