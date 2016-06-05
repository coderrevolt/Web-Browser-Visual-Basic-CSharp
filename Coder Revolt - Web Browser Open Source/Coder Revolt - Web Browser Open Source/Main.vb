Public Class Main
    'Credits: Steve Aura <> http://www.coderrevolt.com
    'Copyrights: MIT MIT License

    Dim int As Integer = 0
    Dim i As Integer = 1
    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        Try
            ToolStripProgressBar1.Maximum = e.MaximumProgress
            ToolStripProgressBar1.Value = e.CurrentProgress


        Catch ex As Exception

        End Try


    End Sub
    Private Sub historyin()



        Dim w As IO.StreamWriter
        Hist.ListBox1.Items.Add(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
        Hist.ListBox2.Items.Add(ComboBox1.Text)



        'Saving History
        Dim i As Integer
        w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\History1.gwbb")
        For i = 0 To Hist.ListBox1.Items.Count - 1
            w.WriteLine(Hist.ListBox1.Items.Item(i))
        Next
        w.Close()
        '
        Dim ii As Integer
        w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\History2.gwbb")
        For ii = 0 To Hist.ListBox2.Items.Count - 1
            w.WriteLine(Hist.ListBox2.Items.Item(ii))
        Next
        w.Close()
    End Sub
    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        ComboBox1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        'History
        If ToolStripProgressBar1.Value = "0" Then
            historyin()

        Else

        End If


    End Sub



    Private mousex As Integer
    Private mousey As Integer
    Private dragged As Boolean = False


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left = True Then
            dragged = True
            mousex = e.X
            mousey = e.Y
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If dragged = True Then
            Dim oo As Point = New Point
            oo.X = Me.Location.X + (e.X - mousex)
            oo.Y = Me.Location.Y + (e.Y - mousey)
            Me.Location = oo
            oo = Nothing
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left = True Then
            dragged = False
        End If
    End Sub
    Dim w As IO.StreamWriter
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim i As Integer
        w = New IO.StreamWriter("C:\CoderRevolt\WebBrowser\V1\Bookmarks.gwbb")
        For i = 0 To Bookmarks.ListBox1.Items.Count - 1
            w.WriteLine(Bookmarks.ListBox1.Items.Item(i))
        Next
        w.Close()

        Me.Enabled = False
        exit_page.Show()

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        exit_page.Show()

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.google.com")
        background.Start()

    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub
    Dim datestring = Date.Now
    Private Sub background_Tick(sender As System.Object, e As System.EventArgs) Handles background.Tick
        ToolStripStatusLabel1.Text = Format(Now, "hh:mm:ss tt") + " \- -/ " + Format(datestring, "Long Date")
        Try
            ToolStripStatusLabel4.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).StatusText
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If RadioButton1.Checked = True Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.co.uk/search?hl=en&q=" + ComboBox1.Text)

        End If
        If RadioButton3.Checked = True Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/search?q=" + ComboBox1.Text)

        End If
        If RadioButton2.Checked = True Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ComboBox1.Text)
            ComboBox1.Items.Add(ComboBox1.Text)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs)
        Process.Start("http://vysilhq.com/")
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            If Not TabControl1.TabPages.Count = 1 Then
                TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
                TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
                int = int - 1
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ComboBox1.Text)
    End Sub

    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

        If GetKeyPress(Keys.Enter) Then
            Button6.PerformClick()
        End If

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Me.WindowState = FormWindowState.Normal
            Me.BackgroundImageLayout = ImageLayout.None
        End If
    End Sub
    Private Sub OrigToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If Find_Highlight_Tool.Visible = True Then
            Find_Highlight_Tool.Hide()
        Else
            Find_Highlight_Tool.Show()
        End If
    End Sub
    Private PanelMOVE As Boolean = False
    Private PanelPOINT As New Point
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub


    Private Sub ToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem6.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub


    Private Sub OpenSourceProjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenSourceProjectToolStripMenuItem.Click
        Process.Start("http://www.steveaura.com/")
    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel4.Click

    End Sub

    Private Sub ToolStripStatusLabel6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Try
            Shell("rundll32.exe shell32.dll,Control_RunDLL inetcpl.cpl,,0", 5)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ViewPageSourceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewPageSourceToolStripMenuItem.Click
        PageSource.Show()

    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Button7.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click





    End Sub

    Private Sub AddToBookmarksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddToBookmarksToolStripMenuItem.Click
        If ComboBox1.Text.Contains("http") = True Then
            AddBookmark.Show()
            AddBookmark.TopMost = True

        Else

        End If

    End Sub

    Private Sub ViewBookmarksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewBookmarksToolStripMenuItem.Click
        If Bookmarks.Visible = True Then
            Bookmarks.Visible = False
        Else
            Bookmarks.Visible = True

        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If Hist.Visible = True Then
            Hist.Hide()

        Else
            Hist.Show()
        End If

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        My.Computer.Clipboard.SetText(CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.InnerText)

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        On Error Resume Next
        ComboBox1.Text = Clipboard.GetText()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Button2.PerformClick()

    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Process.Start("http://www.steveaura.com/")
    End Sub
End Class