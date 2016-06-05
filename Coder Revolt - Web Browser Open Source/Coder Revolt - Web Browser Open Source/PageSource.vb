Public Class PageSource
    Private Sub PageSource_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.txtURL.Text = Main.ComboBox1.Text

        btnViewSource.PerformClick()

    End Sub

    Private Sub btnViewSource_Click(sender As System.Object, e As System.EventArgs) Handles btnViewSource.Click
        btnViewSource.Enabled = False


        Dim WebStream As System.Net.WebClient
        Dim SourceCodeStream As System.IO.Stream
        WebStream = New System.Net.WebClient
        Try
            SourceCodeStream = WebStream.OpenRead(txtURL.Text)
            Dim objReader As System.IO.StreamReader = New System.IO.StreamReader(SourceCodeStream)
            txtSource.Text = objReader.ReadToEnd
        Catch
            MsgBox("Invalid URL" & vbCrLf & "File looking for cannot be found.", MsgBoxStyle.Exclamation, "Invalid URL")
        End Try

        btnViewSource.Enabled = True
    End Sub
End Class