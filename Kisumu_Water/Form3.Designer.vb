<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class metered
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(metered))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.manualm = New System.Windows.Forms.RadioButton()
        Me.visam = New System.Windows.Forms.RadioButton()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.paye = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btbAdd = New System.Windows.Forms.Button()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "METERED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount Of Units"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Amount"
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(43, 189)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(100, 20)
        Me.txtunit.TabIndex = 3
        Me.txtunit.Text = "1"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(43, 277)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(100, 20)
        Me.txtamount.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.manualm)
        Me.GroupBox1.Controls.Add(Me.visam)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(304, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode Of Payment"
        '
        'manualm
        '
        Me.manualm.AutoSize = True
        Me.manualm.Location = New System.Drawing.Point(24, 77)
        Me.manualm.Name = "manualm"
        Me.manualm.Size = New System.Drawing.Size(76, 20)
        Me.manualm.TabIndex = 1
        Me.manualm.TabStop = True
        Me.manualm.Text = "Manual"
        Me.manualm.UseVisualStyleBackColor = True
        '
        'visam
        '
        Me.visam.AutoSize = True
        Me.visam.Location = New System.Drawing.Point(24, 39)
        Me.visam.Name = "visam"
        Me.visam.Size = New System.Drawing.Size(57, 20)
        Me.visam.TabIndex = 0
        Me.visam.TabStop = True
        Me.visam.Text = "Visa"
        Me.visam.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(43, 344)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(142, 344)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 7
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'paye
        '
        Me.paye.Location = New System.Drawing.Point(304, 232)
        Me.paye.Name = "paye"
        Me.paye.Size = New System.Drawing.Size(200, 20)
        Me.paye.TabIndex = 8
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(328, 277)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(165, 43)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.Text = "load database"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btbAdd
        '
        Me.btbAdd.Location = New System.Drawing.Point(329, 344)
        Me.btbAdd.Name = "btbAdd"
        Me.btbAdd.Size = New System.Drawing.Size(83, 36)
        Me.btbAdd.TabIndex = 10
        Me.btbAdd.Text = "Add"
        Me.btbAdd.UseVisualStyleBackColor = True
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(43, 114)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(100, 20)
        Me.txtNo.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Meter No."
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(429, 351)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 15
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'metered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(632, 404)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.btbAdd)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.paye)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "metered"
        Me.Text = "metered"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents manualm As System.Windows.Forms.RadioButton
    Friend WithEvents visam As System.Windows.Forms.RadioButton
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents paye As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btbAdd As System.Windows.Forms.Button
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
