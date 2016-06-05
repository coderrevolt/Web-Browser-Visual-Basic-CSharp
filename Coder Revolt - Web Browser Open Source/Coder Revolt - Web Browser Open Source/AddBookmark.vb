Public Class AddBookmark
    Dim w As IO.StreamWriter
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Bookmarks.ListBox2.Items.Add(TextBox2.Text)
        Bookmarks.ListBox1.Items.Add(TextBox1.Text)
        'Saving
        Try
            Dim i As Integer
            w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\Bookmarks.gwbb")
            For i = 0 To Bookmarks.ListBox1.Items.Count - 1
                w.WriteLine(Bookmarks.ListBox1.Items.Item(i))
            Next
            w.Close()
        Catch ex As Exception

        End Try
        Try
            Dim i As Integer
            w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\Bookmarks2.gwbb")
            For i = 0 To Bookmarks.ListBox2.Items.Count - 1
                w.WriteLine(Bookmarks.ListBox2.Items.Item(i))
            Next
            w.Close()
        Catch ex As Exception

        End Try
        MessageBox.Show("Bookmark " + TextBox1.Text + " has been created!")
        Me.Hide()

    End Sub

    Private Sub AddBookmark_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Main.ComboBox1.Text
        TextBox1.Text = (CType(Main.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
    End Sub
End Class