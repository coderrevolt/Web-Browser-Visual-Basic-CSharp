Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the timer to start
        Prog_In_Timer.Start()
    End Sub

    Private Sub Prog_In_Timer_Tick(sender As Object, e As EventArgs) Handles Prog_In_Timer.Tick
        'Inrement by +1 in progressbar #1 (get it started) 
        ProgressBar1.Increment(+1)


        'Add percent towards the central label
        Label2.Text = "Loading... " + ProgressBar1.Value.ToString + "%"
        Dim r As IO.StreamReader


        'Self-setup and checkup
        If ProgressBar1.Value = "1" Then

            If My.Computer.FileSystem.DirectoryExists("C:\CoderRevolt\WebBrowser\V1") Then
                'Check if returning user
            Else
                'If user is new, then create core directory folder
                My.Computer.FileSystem.CreateDirectory("C:\CoderRevolt\WebBrowser\V1")
            End If

        End If

        'Make sure History and Bookmarks panels are loaded up for next ProgressCheck @ Value '10'
        If ProgressBar1.Value = "5" Then
            Hist.Show()
            Hist.Hide()

            Bookmarks.Show()
            Bookmarks.Hide()

        End If

        'Bookmark Self-Check and Setup
        If ProgressBar1.Value = "10" Then
            If My.Computer.FileSystem.FileExists("C:\CoderRevolt\WebBrowser\V1\Bookmarks.gwbb") Then
                r = New IO.StreamReader("C:\CoderRevolt\WebBrowser\V1\Bookmarks.gwbb")
                While (r.Peek() > -1)
                    Bookmarks.ListBox1.Items.Add(r.ReadLine)
                End While
                r.Close()
            Else

            End If
            If My.Computer.FileSystem.FileExists("C:\CoderRevolt\WebBrowser\V1\Bookmarks2.gwbb") Then
                r = New IO.StreamReader("C:\CoderRevolt\WebBrowser\V1\Bookmarks2.gwbb")
                While (r.Peek() > -1)
                    Bookmarks.ListBox2.Items.Add(r.ReadLine)
                End While
                r.Close()
            Else

            End If
        End If

        'History Self-Check and Setup 
        If ProgressBar1.Value = "20" Then
            If My.Computer.FileSystem.FileExists("C:\CoderRevolt\WebBrowser\V1\History1.gwbb") Then
                r = New IO.StreamReader("C:\CoderRevolt\WebBrowser\V1\History1.gwbb")
                While (r.Peek() > -1)
                    Hist.ListBox1.Items.Add(r.ReadLine)
                End While
                r.Close()
            Else

            End If
            If My.Computer.FileSystem.FileExists("C:\CoderRevolt\WebBrowser\V1\History2.gwbb") Then
                r = New IO.StreamReader("C:\CoderRevolt\WebBrowser\V1\History2.gwbb")
                While (r.Peek() > -1)
                    Hist.ListBox2.Items.Add(r.ReadLine)
                End While
                r.Close()
            Else

            End If
        End If
        If ProgressBar1.Value = "100" Then
            Prog_In_Timer.Stop()
            Me.Hide()

            Main.Show()

        End If


    End Sub
End Class
