<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnNewMonkey = New System.Windows.Forms.Button()
        Me.btnNewLion = New System.Windows.Forms.Button()
        Me.btnNewElephant = New System.Windows.Forms.Button()
        Me.lbx = New System.Windows.Forms.ListBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnFeedAll = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewMonkey
        '
        Me.btnNewMonkey.Location = New System.Drawing.Point(13, 25)
        Me.btnNewMonkey.Name = "btnNewMonkey"
        Me.btnNewMonkey.Size = New System.Drawing.Size(111, 23)
        Me.btnNewMonkey.TabIndex = 0
        Me.btnNewMonkey.Text = "Nieuwe Aap"
        Me.btnNewMonkey.UseVisualStyleBackColor = True
        '
        'btnNewLion
        '
        Me.btnNewLion.Location = New System.Drawing.Point(13, 66)
        Me.btnNewLion.Name = "btnNewLion"
        Me.btnNewLion.Size = New System.Drawing.Size(111, 23)
        Me.btnNewLion.TabIndex = 1
        Me.btnNewLion.Text = "Nieuwe Leeuw"
        Me.btnNewLion.UseVisualStyleBackColor = True
        '
        'btnNewElephant
        '
        Me.btnNewElephant.Location = New System.Drawing.Point(13, 102)
        Me.btnNewElephant.Name = "btnNewElephant"
        Me.btnNewElephant.Size = New System.Drawing.Size(111, 23)
        Me.btnNewElephant.TabIndex = 2
        Me.btnNewElephant.Text = "Nieuwe olifant"
        Me.btnNewElephant.UseVisualStyleBackColor = True
        '
        'lbx
        '
        Me.lbx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbx.FormattingEnabled = True
        Me.lbx.Location = New System.Drawing.Point(186, 25)
        Me.lbx.Name = "lbx"
        Me.lbx.Size = New System.Drawing.Size(139, 407)
        Me.lbx.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(361, 25)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(427, 407)
        Me.dgv.TabIndex = 4
        '
        'btnFeedAll
        '
        Me.btnFeedAll.Location = New System.Drawing.Point(13, 148)
        Me.btnFeedAll.Name = "btnFeedAll"
        Me.btnFeedAll.Size = New System.Drawing.Size(111, 23)
        Me.btnFeedAll.TabIndex = 5
        Me.btnFeedAll.Text = "Voederen"
        Me.btnFeedAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Apen voederen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Leeuwen voederen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Olifanten voederen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 301)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Olifanten 2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFeedAll)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lbx)
        Me.Controls.Add(Me.btnNewElephant)
        Me.Controls.Add(Me.btnNewLion)
        Me.Controls.Add(Me.btnNewMonkey)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewMonkey As Button
    Friend WithEvents btnNewLion As Button
    Friend WithEvents btnNewElephant As Button
    Friend WithEvents lbx As ListBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnFeedAll As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
End Class
