Public Class Bookmarks
    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
    End Sub

    Private Sub Bookmarks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            MessageBox.Show("Deleted!")
            Button1.PerformClick()
        Catch ex As Exception



        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim w As IO.StreamWriter

        Try
            Dim i As Integer
            w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\Bookmarks.gwbb")
            For i = 0 To ListBox1.Items.Count - 1
                w.WriteLine(ListBox1.Items.Item(i))
            Next
            w.Close()
        Catch ex As Exception

        End Try
        Try
            Dim i As Integer
            w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\Bookmarks2.gwbb")
            For i = 0 To ListBox2.Items.Count - 1
                w.WriteLine(ListBox2.Items.Item(i))
            Next
            w.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try

            Main.RadioButton2.Checked = True

            Main.ComboBox1.Text = ListBox2.SelectedItem.ToString
            Main.Button6.PerformClick()

        Catch ex As Exception

        End Try

    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Button1.PerformClick()
    End Sub
End Class