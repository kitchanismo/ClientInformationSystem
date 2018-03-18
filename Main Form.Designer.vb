<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblclient = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txtrole = New System.Windows.Forms.Label()
        Me.timerdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnreports = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.lbllogout = New System.Windows.Forms.Label()
        Me.lvClient = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnbtns = New System.Windows.Forms.Panel()
        Me.btnarchive = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnbtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(210, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Computerized Client's Information System"
        '
        'btnadd
        '
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnadd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(7, 267)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(103, 49)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.Teal
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.White
        Me.txtsearch.Location = New System.Drawing.Point(598, 91)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(472, 31)
        Me.txtsearch.TabIndex = 48
        Me.txtsearch.Text = " "
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(7, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 31)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblclient
        '
        Me.lblclient.AutoSize = True
        Me.lblclient.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclient.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblclient.Location = New System.Drawing.Point(8, 102)
        Me.lblclient.Name = "lblclient"
        Me.lblclient.Size = New System.Drawing.Size(83, 21)
        Me.lblclient.TabIndex = 50
        Me.lblclient.Text = "Client List"
        '
        'btnrefresh
        '
        Me.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnrefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Location = New System.Drawing.Point(7, 47)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(103, 31)
        Me.btnrefresh.TabIndex = 51
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'txtrole
        '
        Me.txtrole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtrole.AutoSize = True
        Me.txtrole.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrole.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.txtrole.Location = New System.Drawing.Point(8, 643)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.Size = New System.Drawing.Size(152, 20)
        Me.txtrole.TabIndex = 53
        Me.txtrole.Text = "User Role Date Time"
        '
        'timerdate
        '
        Me.timerdate.Enabled = True
        Me.timerdate.Interval = 1000
        '
        'btnreports
        '
        Me.btnreports.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnreports.BackColor = System.Drawing.Color.White
        Me.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreports.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnreports.Location = New System.Drawing.Point(7, 87)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(103, 31)
        Me.btnreports.TabIndex = 54
        Me.btnreports.Text = "REPORT"
        Me.btnreports.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnedit.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(7, 325)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(103, 49)
        Me.btnedit.TabIndex = 55
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btndelete.BackColor = System.Drawing.Color.IndianRed
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(7, 383)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(103, 49)
        Me.btndelete.TabIndex = 56
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'lbllogout
        '
        Me.lbllogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbllogout.AutoSize = True
        Me.lbllogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbllogout.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogout.ForeColor = System.Drawing.Color.White
        Me.lbllogout.Location = New System.Drawing.Point(973, 644)
        Me.lbllogout.Name = "lbllogout"
        Me.lbllogout.Size = New System.Drawing.Size(75, 20)
        Me.lbllogout.TabIndex = 57
        Me.lbllogout.Text = "LOG OUT"
        '
        'lvClient
        '
        Me.lvClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvClient.BackColor = System.Drawing.Color.Teal
        Me.lvClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvClient.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvClient.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvClient.ForeColor = System.Drawing.Color.White
        Me.lvClient.FullRowSelect = True
        Me.lvClient.GridLines = True
        Me.lvClient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvClient.Location = New System.Drawing.Point(12, 133)
        Me.lvClient.MultiSelect = False
        Me.lvClient.Name = "lvClient"
        Me.lvClient.Size = New System.Drawing.Size(936, 500)
        Me.lvClient.TabIndex = 58
        Me.lvClient.UseCompatibleStateImageBehavior = False
        Me.lvClient.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 52
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "POLICY No"
        Me.ColumnHeader6.Width = 106
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "FULLNAME"
        Me.ColumnHeader7.Width = 207
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CONTACT"
        Me.ColumnHeader8.Width = 136
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "BIRTHDATE"
        Me.ColumnHeader9.Width = 118
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "GENDER"
        Me.ColumnHeader10.Width = 106
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ADDRESS"
        Me.ColumnHeader11.Width = 158
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "STATUS"
        Me.ColumnHeader12.Width = 108
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Promo Officer"
        Me.ColumnHeader1.Width = 133
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sales Officer"
        Me.ColumnHeader2.Width = 129
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Insured"
        Me.ColumnHeader3.Width = 118
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Appointed"
        Me.ColumnHeader4.Width = 113
        '
        'pnbtns
        '
        Me.pnbtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnbtns.BackColor = System.Drawing.Color.Teal
        Me.pnbtns.Controls.Add(Me.btnarchive)
        Me.pnbtns.Controls.Add(Me.btnview)
        Me.pnbtns.Controls.Add(Me.btnrefresh)
        Me.pnbtns.Controls.Add(Me.btnadd)
        Me.pnbtns.Controls.Add(Me.Button2)
        Me.pnbtns.Controls.Add(Me.btndelete)
        Me.pnbtns.Controls.Add(Me.btnreports)
        Me.pnbtns.Controls.Add(Me.btnedit)
        Me.pnbtns.Location = New System.Drawing.Point(954, 133)
        Me.pnbtns.Name = "pnbtns"
        Me.pnbtns.Size = New System.Drawing.Size(116, 500)
        Me.pnbtns.TabIndex = 59
        '
        'btnarchive
        '
        Me.btnarchive.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnarchive.BackColor = System.Drawing.Color.White
        Me.btnarchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarchive.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarchive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnarchive.Location = New System.Drawing.Point(8, 126)
        Me.btnarchive.Name = "btnarchive"
        Me.btnarchive.Size = New System.Drawing.Size(103, 31)
        Me.btnarchive.TabIndex = 58
        Me.btnarchive.Text = "ARCHIVE"
        Me.btnarchive.UseVisualStyleBackColor = False
        '
        'btnview
        '
        Me.btnview.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnview.BackColor = System.Drawing.Color.SteelBlue
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.White
        Me.btnview.Location = New System.Drawing.Point(7, 441)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(103, 49)
        Me.btnview.TabIndex = 57
        Me.btnview.Text = "VIEW"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipTitle = "creator"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1077, 674)
        Me.Controls.Add(Me.pnbtns)
        Me.Controls.Add(Me.lvClient)
        Me.Controls.Add(Me.lbllogout)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.lblclient)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Form"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnbtns.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblclient As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txtrole As System.Windows.Forms.Label
    Friend WithEvents timerdate As System.Windows.Forms.Timer
    Friend WithEvents btnreports As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents lbllogout As System.Windows.Forms.Label
    Friend WithEvents lvClient As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnbtns As System.Windows.Forms.Panel
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnarchive As System.Windows.Forms.Button
End Class
