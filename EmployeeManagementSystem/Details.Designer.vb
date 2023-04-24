<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpDOB = New System.Windows.Forms.Label()
        Me.EmpEducation = New System.Windows.Forms.Label()
        Me.EmpPosition = New System.Windows.Forms.Label()
        Me.EmpAddress = New System.Windows.Forms.Label()
        Me.EmpPhone = New System.Windows.Forms.Label()
        Me.EmpGender = New System.Windows.Forms.Label()
        Me.EmpName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EmpIDtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.EmpDOB)
        Me.Panel1.Controls.Add(Me.EmpEducation)
        Me.Panel1.Controls.Add(Me.EmpPosition)
        Me.Panel1.Controls.Add(Me.EmpAddress)
        Me.Panel1.Controls.Add(Me.EmpPhone)
        Me.Panel1.Controls.Add(Me.EmpGender)
        Me.Panel1.Controls.Add(Me.EmpName)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.EmpIDtxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(6, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 358)
        Me.Panel1.TabIndex = 1
        '
        'EmpDOB
        '
        Me.EmpDOB.AutoSize = True
        Me.EmpDOB.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDOB.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpDOB.Location = New System.Drawing.Point(433, 224)
        Me.EmpDOB.Name = "EmpDOB"
        Me.EmpDOB.Size = New System.Drawing.Size(125, 22)
        Me.EmpDOB.TabIndex = 34
        Me.EmpDOB.Text = "Date of Birth"
        Me.EmpDOB.Visible = False
        '
        'EmpEducation
        '
        Me.EmpEducation.AutoSize = True
        Me.EmpEducation.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEducation.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpEducation.Location = New System.Drawing.Point(610, 181)
        Me.EmpEducation.Name = "EmpEducation"
        Me.EmpEducation.Size = New System.Drawing.Size(104, 22)
        Me.EmpEducation.TabIndex = 33
        Me.EmpEducation.Text = "Education"
        Me.EmpEducation.Visible = False
        '
        'EmpPosition
        '
        Me.EmpPosition.AutoSize = True
        Me.EmpPosition.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPosition.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpPosition.Location = New System.Drawing.Point(610, 135)
        Me.EmpPosition.Name = "EmpPosition"
        Me.EmpPosition.Size = New System.Drawing.Size(86, 22)
        Me.EmpPosition.TabIndex = 32
        Me.EmpPosition.Text = "Position"
        Me.EmpPosition.Visible = False
        '
        'EmpAddress
        '
        Me.EmpAddress.AutoSize = True
        Me.EmpAddress.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddress.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpAddress.Location = New System.Drawing.Point(608, 92)
        Me.EmpAddress.Name = "EmpAddress"
        Me.EmpAddress.Size = New System.Drawing.Size(88, 22)
        Me.EmpAddress.TabIndex = 31
        Me.EmpAddress.Text = "Address"
        Me.EmpAddress.Visible = False
        '
        'EmpPhone
        '
        Me.EmpPhone.AutoSize = True
        Me.EmpPhone.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPhone.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpPhone.Location = New System.Drawing.Point(285, 181)
        Me.EmpPhone.Name = "EmpPhone"
        Me.EmpPhone.Size = New System.Drawing.Size(105, 22)
        Me.EmpPhone.TabIndex = 30
        Me.EmpPhone.Text = "Phone No."
        Me.EmpPhone.Visible = False
        '
        'EmpGender
        '
        Me.EmpGender.AutoSize = True
        Me.EmpGender.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGender.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpGender.Location = New System.Drawing.Point(281, 135)
        Me.EmpGender.Name = "EmpGender"
        Me.EmpGender.Size = New System.Drawing.Size(79, 22)
        Me.EmpGender.TabIndex = 29
        Me.EmpGender.Text = "Gender"
        Me.EmpGender.Visible = False
        '
        'EmpName
        '
        Me.EmpName.AutoSize = True
        Me.EmpName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpName.Location = New System.Drawing.Point(281, 92)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(62, 22)
        Me.EmpName.TabIndex = 28
        Me.EmpName.Text = "Name"
        Me.EmpName.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(567, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 38)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Fetch Data"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'EmpIDtxt
        '
        Me.EmpIDtxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIDtxt.Location = New System.Drawing.Point(374, 15)
        Me.EmpIDtxt.Name = "EmpIDtxt"
        Me.EmpIDtxt.Size = New System.Drawing.Size(169, 29)
        Me.EmpIDtxt.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(239, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 22)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Employee ID"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(544, 295)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 38)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(243, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 38)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(302, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 22)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Date of Birth"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(500, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 22)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Education"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(500, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 22)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(174, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 22)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(174, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Phone No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(498, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 22)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(174, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 22)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EmployeeManagementSystem.My.Resources.Resources.details
        Me.PictureBox1.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(848, 446)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 22)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Group 4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(910, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "X"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(945, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpDOB As Label
    Friend WithEvents EmpEducation As Label
    Friend WithEvents EmpPosition As Label
    Friend WithEvents EmpAddress As Label
    Friend WithEvents EmpPhone As Label
    Friend WithEvents EmpGender As Label
    Friend WithEvents EmpName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents EmpIDtxt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
