<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ksmwater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ksmwater))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbunmetered = New System.Windows.Forms.RadioButton()
        Me.rdbmetered = New System.Windows.Forms.RadioButton()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KISUMU WATER COMPANY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer User Interface"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(485, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Welcome To The Kisumu Water Company: Choose Your Specs Below"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbunmetered)
        Me.GroupBox1.Controls.Add(Me.rdbmetered)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Of Client"
        '
        'rdbunmetered
        '
        Me.rdbunmetered.AutoSize = True
        Me.rdbunmetered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbunmetered.Location = New System.Drawing.Point(253, 38)
        Me.rdbunmetered.Name = "rdbunmetered"
        Me.rdbunmetered.Size = New System.Drawing.Size(102, 20)
        Me.rdbunmetered.TabIndex = 1
        Me.rdbunmetered.Text = "UnMetered"
        Me.rdbunmetered.UseVisualStyleBackColor = True
        '
        'rdbmetered
        '
        Me.rdbmetered.AutoSize = True
        Me.rdbmetered.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbmetered.Location = New System.Drawing.Point(7, 36)
        Me.rdbmetered.Name = "rdbmetered"
        Me.rdbmetered.Size = New System.Drawing.Size(83, 20)
        Me.rdbmetered.TabIndex = 0
        Me.rdbmetered.Text = "Metered"
        Me.rdbmetered.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(387, 301)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'ksmwater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(642, 345)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ksmwater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kisumu Water"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbunmetered As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmetered As System.Windows.Forms.RadioButton
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
