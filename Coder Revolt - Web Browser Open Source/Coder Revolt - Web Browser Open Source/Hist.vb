Public Class Hist
    Dim w As IO.StreamWriter
    Private Sub save()
        Dim i As Integer
        w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\History1.gwbb")
        For i = 0 To ListBox1.Items.Count - 1
            w.WriteLine(ListBox1.Items.Item(i))
        Next
        w.Close()
        '
        Dim ii As Integer
        w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\History2.gwbb")
        For ii = 0 To ListBox1.Items.Count - 1
            w.WriteLine(ListBox1.Items.Item(ii))
        Next
        w.Close()
    End Sub
    Private Sub FindHistory(ByVal searchString As String)
        If searchString <> String.Empty Then
            Dim index As Integer = ListBox1.FindString(searchString)
            If index <> -1 Then
                ListBox1.SetSelected(index, True)
            Else
                MessageBox.Show("could not match any history for " + TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        FindHistory(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        save()

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

        Catch ex As Exception

        End Try


    End Sub

    Private Sub History_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load





        Me.TopMost = True

        Timer1.Start()

    End Sub
    Private Sub History_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing



    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Deleted!")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Main.RadioButton2.Checked = True

            Main.ComboBox1.Text = ListBox2.SelectedItem.ToString
            Main.Button6.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub
End Class