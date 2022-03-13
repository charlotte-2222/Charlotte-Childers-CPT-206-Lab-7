<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblNumSld = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtNumSold = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GrpBoxCarsSoldByType = New System.Windows.Forms.GroupBox()
        Me.TxtSoldByUsedCar = New System.Windows.Forms.TextBox()
        Me.LblUsedCar = New System.Windows.Forms.Label()
        Me.TxtSoldByNewCar = New System.Windows.Forms.TextBox()
        Me.LblNewCar = New System.Windows.Forms.Label()
        Me.TxtSoldByPartTime = New System.Windows.Forms.TextBox()
        Me.TxtSoldByFullTime = New System.Windows.Forms.TextBox()
        Me.LblPT = New System.Windows.Forms.Label()
        Me.LblFT = New System.Windows.Forms.Label()
        Me.DECOY = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpBoxCarsSoldByType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(12, 39)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(23, 16)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "&ID:"
        '
        'LblNumSld
        '
        Me.LblNumSld.AutoSize = True
        Me.LblNumSld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumSld.Location = New System.Drawing.Point(112, 39)
        Me.LblNumSld.Name = "LblNumSld"
        Me.LblNumSld.Size = New System.Drawing.Size(89, 16)
        Me.LblNumSld.TabIndex = 1
        Me.LblNumSld.Text = "&Number Sold:"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(15, 55)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(62, 20)
        Me.TxtID.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtID, "Enter your Employee ID (Ex: 123UF, 123NP)")
        '
        'TxtNumSold
        '
        Me.TxtNumSold.Location = New System.Drawing.Point(115, 55)
        Me.TxtNumSold.Name = "TxtNumSold"
        Me.TxtNumSold.Size = New System.Drawing.Size(63, 20)
        Me.TxtNumSold.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtNumSold, "Enter the number of vehicles you have sold")
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BtnCalc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCalc.FlatAppearance.BorderSize = 2
        Me.BtnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(15, 88)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(76, 32)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.BtnCalc, "Show the Amount of Car Sales")
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Salmon
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExit.FlatAppearance.BorderSize = 2
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(115, 88)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(76, 32)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit the Program")
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GrpBoxCarsSoldByType
        '
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.TxtSoldByUsedCar)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.LblUsedCar)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.TxtSoldByNewCar)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.LblNewCar)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.TxtSoldByPartTime)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.TxtSoldByFullTime)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.LblPT)
        Me.GrpBoxCarsSoldByType.Controls.Add(Me.LblFT)
        Me.GrpBoxCarsSoldByType.Location = New System.Drawing.Point(8, 133)
        Me.GrpBoxCarsSoldByType.Name = "GrpBoxCarsSoldByType"
        Me.GrpBoxCarsSoldByType.Size = New System.Drawing.Size(245, 149)
        Me.GrpBoxCarsSoldByType.TabIndex = 6
        Me.GrpBoxCarsSoldByType.TabStop = False
        Me.GrpBoxCarsSoldByType.Text = "Cars Sold By"
        Me.ToolTip1.SetToolTip(Me.GrpBoxCarsSoldByType, "Cars Sold By Employee Type")
        '
        'TxtSoldByUsedCar
        '
        Me.TxtSoldByUsedCar.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSoldByUsedCar.ForeColor = System.Drawing.Color.Black
        Me.TxtSoldByUsedCar.Location = New System.Drawing.Point(144, 105)
        Me.TxtSoldByUsedCar.Name = "TxtSoldByUsedCar"
        Me.TxtSoldByUsedCar.ReadOnly = True
        Me.TxtSoldByUsedCar.Size = New System.Drawing.Size(62, 20)
        Me.TxtSoldByUsedCar.TabIndex = 11
        Me.TxtSoldByUsedCar.TabStop = False
        '
        'LblUsedCar
        '
        Me.LblUsedCar.AutoSize = True
        Me.LblUsedCar.Location = New System.Drawing.Point(19, 108)
        Me.LblUsedCar.Name = "LblUsedCar"
        Me.LblUsedCar.Size = New System.Drawing.Size(108, 13)
        Me.LblUsedCar.TabIndex = 10
        Me.LblUsedCar.Text = "Used Car Employees:"
        '
        'TxtSoldByNewCar
        '
        Me.TxtSoldByNewCar.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSoldByNewCar.ForeColor = System.Drawing.Color.Black
        Me.TxtSoldByNewCar.Location = New System.Drawing.Point(144, 79)
        Me.TxtSoldByNewCar.Name = "TxtSoldByNewCar"
        Me.TxtSoldByNewCar.ReadOnly = True
        Me.TxtSoldByNewCar.Size = New System.Drawing.Size(62, 20)
        Me.TxtSoldByNewCar.TabIndex = 9
        Me.TxtSoldByNewCar.TabStop = False
        '
        'LblNewCar
        '
        Me.LblNewCar.AutoSize = True
        Me.LblNewCar.Location = New System.Drawing.Point(19, 82)
        Me.LblNewCar.Name = "LblNewCar"
        Me.LblNewCar.Size = New System.Drawing.Size(105, 13)
        Me.LblNewCar.TabIndex = 8
        Me.LblNewCar.Text = "New Car Employees:"
        '
        'TxtSoldByPartTime
        '
        Me.TxtSoldByPartTime.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSoldByPartTime.ForeColor = System.Drawing.Color.Black
        Me.TxtSoldByPartTime.Location = New System.Drawing.Point(144, 53)
        Me.TxtSoldByPartTime.Name = "TxtSoldByPartTime"
        Me.TxtSoldByPartTime.ReadOnly = True
        Me.TxtSoldByPartTime.Size = New System.Drawing.Size(62, 20)
        Me.TxtSoldByPartTime.TabIndex = 7
        Me.TxtSoldByPartTime.TabStop = False
        '
        'TxtSoldByFullTime
        '
        Me.TxtSoldByFullTime.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSoldByFullTime.ForeColor = System.Drawing.Color.Black
        Me.TxtSoldByFullTime.Location = New System.Drawing.Point(144, 27)
        Me.TxtSoldByFullTime.Name = "TxtSoldByFullTime"
        Me.TxtSoldByFullTime.ReadOnly = True
        Me.TxtSoldByFullTime.Size = New System.Drawing.Size(62, 20)
        Me.TxtSoldByFullTime.TabIndex = 6
        Me.TxtSoldByFullTime.TabStop = False
        '
        'LblPT
        '
        Me.LblPT.AutoSize = True
        Me.LblPT.Location = New System.Drawing.Point(19, 56)
        Me.LblPT.Name = "LblPT"
        Me.LblPT.Size = New System.Drawing.Size(109, 13)
        Me.LblPT.TabIndex = 5
        Me.LblPT.Text = "Part-Time Employees:"
        '
        'LblFT
        '
        Me.LblFT.AutoSize = True
        Me.LblFT.Location = New System.Drawing.Point(19, 30)
        Me.LblFT.Name = "LblFT"
        Me.LblFT.Size = New System.Drawing.Size(106, 13)
        Me.LblFT.TabIndex = 4
        Me.LblFT.Text = "Full-Time Employees:"
        '
        'DECOY
        '
        Me.DECOY.AutoSize = True
        Me.DECOY.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DECOY.Location = New System.Drawing.Point(5, 304)
        Me.DECOY.Name = "DECOY"
        Me.DECOY.Size = New System.Drawing.Size(58, 20)
        Me.DECOY.TabIndex = 7
        Me.DECOY.Text = "DECOY"
        Me.ToolTip1.SetToolTip(Me.DECOY, "Current Time")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rembrandt Auto Solutions"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(296, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 244)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Greetings Rembrandt Auto Employee!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please be sure to correctly enter your Empl" &
    "oyee ID and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the amount of vehicles you have sold today!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Ex. EmpID: 123UF, E" &
    "mpID: 123NP)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(370, 326)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DECOY)
        Me.Controls.Add(Me.GrpBoxCarsSoldByType)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.TxtNumSold)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LblNumSld)
        Me.Controls.Add(Me.LblID)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers | Rembrandt Auto"
        Me.GrpBoxCarsSoldByType.ResumeLayout(False)
        Me.GrpBoxCarsSoldByType.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents LblNumSld As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtNumSold As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents GrpBoxCarsSoldByType As GroupBox
    Friend WithEvents TxtSoldByUsedCar As TextBox
    Friend WithEvents LblUsedCar As Label
    Friend WithEvents TxtSoldByNewCar As TextBox
    Friend WithEvents LblNewCar As Label
    Friend WithEvents TxtSoldByPartTime As TextBox
    Friend WithEvents TxtSoldByFullTime As TextBox
    Friend WithEvents LblPT As Label
    Friend WithEvents LblFT As Label
    Friend WithEvents DECOY As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
