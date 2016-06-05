<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageSource
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageSource))
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnViewSource = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSource
        '
        Me.txtSource.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSource.Location = New System.Drawing.Point(3, 31)
        Me.txtSource.Multiline = True
        Me.txtSource.Name = "txtSource"
        Me.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSource.Size = New System.Drawing.Size(1032, 358)
        Me.txtSource.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtSource, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1038, 390)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnViewSource)
        Me.Panel1.Controls.Add(Me.txtURL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 22)
        Me.Panel1.TabIndex = 6
        '
        'btnViewSource
        '
        Me.btnViewSource.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnViewSource.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewSource.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSource.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnViewSource.Location = New System.Drawing.Point(946, 0)
        Me.btnViewSource.Name = "btnViewSource"
        Me.btnViewSource.Size = New System.Drawing.Size(86, 22)
        Me.btnViewSource.TabIndex = 3
        Me.btnViewSource.Text = "View Source"
        Me.btnViewSource.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtURL.Location = New System.Drawing.Point(0, 0)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(946, 20)
        Me.txtURL.TabIndex = 0
        '
        'PageSource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 390)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PageSource"
        Me.Text = "Page Source Code"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSource As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnViewSource As Button
    Friend WithEvents txtURL As TextBox
End Class
