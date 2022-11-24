<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BSCUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BSCUP))
        Me.TXTSE = New System.Windows.Forms.ComboBox()
        Me.TXTSESN = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.TXTADM = New System.Windows.Forms.TextBox()
        Me.TXTAD = New System.Windows.Forms.TextBox()
        Me.TXTCN = New System.Windows.Forms.TextBox()
        Me.TXTDOB = New System.Windows.Forms.TextBox()
        Me.TXTGENDER = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TXTNAME = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTSE
        '
        Me.TXTSE.FormattingEnabled = True
        Me.TXTSE.Items.AddRange(New Object() {"I SEMESTER", "II SEMESTER", "III SEMESTER", "IV SEMESTER", "V SEMESTER", "VI SEMESTER", "VII SEMESTER", "VIII SEMESTER"})
        Me.TXTSE.Location = New System.Drawing.Point(602, 576)
        Me.TXTSE.Name = "TXTSE"
        Me.TXTSE.Size = New System.Drawing.Size(150, 24)
        Me.TXTSE.TabIndex = 58
        '
        'TXTSESN
        '
        Me.TXTSESN.FormattingEnabled = True
        Me.TXTSESN.Items.AddRange(New Object() {"2020-21", "2021-22", "2022-23", "2023-24", "2024-25", "2025-26", "2026-27", "2027-28", "2028-29", "2029-30", "2030-31", "2031-32", "2032-33", "2033-34", "2034-35", "2035-36", "2036-37", "2037-38", "2038-39", "2039-40"})
        Me.TXTSESN.Location = New System.Drawing.Point(602, 468)
        Me.TXTSESN.Name = "TXTSESN"
        Me.TXTSESN.Size = New System.Drawing.Size(150, 24)
        Me.TXTSESN.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(599, 684)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "PATH"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 17)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "ADMISSION NO :-"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1521, 760)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 53)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1314, 760)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 53)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "CLEAR ALL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(565, 760)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 53)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1268, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 53)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(602, 630)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(284, 22)
        Me.TXTID.TabIndex = 49
        '
        'TXTADM
        '
        Me.TXTADM.Location = New System.Drawing.Point(602, 522)
        Me.TXTADM.Name = "TXTADM"
        Me.TXTADM.Size = New System.Drawing.Size(284, 22)
        Me.TXTADM.TabIndex = 48
        '
        'TXTAD
        '
        Me.TXTAD.Location = New System.Drawing.Point(602, 390)
        Me.TXTAD.Multiline = True
        Me.TXTAD.Name = "TXTAD"
        Me.TXTAD.Size = New System.Drawing.Size(284, 46)
        Me.TXTAD.TabIndex = 47
        '
        'TXTCN
        '
        Me.TXTCN.Location = New System.Drawing.Point(602, 336)
        Me.TXTCN.Name = "TXTCN"
        Me.TXTCN.Size = New System.Drawing.Size(150, 22)
        Me.TXTCN.TabIndex = 46
        '
        'TXTDOB
        '
        Me.TXTDOB.Location = New System.Drawing.Point(602, 282)
        Me.TXTDOB.Name = "TXTDOB"
        Me.TXTDOB.Size = New System.Drawing.Size(150, 22)
        Me.TXTDOB.TabIndex = 45
        '
        'TXTGENDER
        '
        Me.TXTGENDER.Location = New System.Drawing.Point(602, 228)
        Me.TXTGENDER.Name = "TXTGENDER"
        Me.TXTGENDER.Size = New System.Drawing.Size(150, 22)
        Me.TXTGENDER.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(401, 684)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "IMAGE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 630)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "E-MAIL ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 576)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "SEMESTER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 522)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ADMISSION DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(402, 468)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "SESSION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(402, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(402, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "CONTACT NO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "DATE OF BIRTH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "GENDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(779, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 36)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "UPDATE FORM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1255, 162)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1255, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(50)
        Me.Label12.Size = New System.Drawing.Size(215, 134)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "PICTURE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOT AVAILABLE"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(892, 162)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 34)
        Me.Button5.TabIndex = 61
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(157, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 17)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "NO "
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(79, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 34)
        Me.Button6.TabIndex = 65
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(33, 64)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 34)
        Me.Button7.TabIndex = 66
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(728, 282)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(24, 22)
        Me.DateTimePicker1.TabIndex = 67
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(768, 228)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 21)
        Me.RadioButton1.TabIndex = 68
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "MALE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(840, 229)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(83, 21)
        Me.RadioButton2.TabIndex = 69
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FEMALE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TXTNAME
        '
        Me.TXTNAME.DisplayMember = "NAME"
        Me.TXTNAME.FormattingEnabled = True
        Me.TXTNAME.Location = New System.Drawing.Point(602, 170)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(284, 24)
        Me.TXTNAME.TabIndex = 70
        Me.TXTNAME.ValueMember = "NAME"
        '
        'BSCUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1933, 1102)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXTNAME)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TXTSE)
        Me.Controls.Add(Me.TXTSESN)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.TXTADM)
        Me.Controls.Add(Me.TXTAD)
        Me.Controls.Add(Me.TXTCN)
        Me.Controls.Add(Me.TXTDOB)
        Me.Controls.Add(Me.TXTGENDER)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BSCUP"
        Me.Text = "UPADTE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTSE As ComboBox
    Friend WithEvents TXTSESN As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label14 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TXTID As TextBox
    Friend WithEvents TXTADM As TextBox
    Friend WithEvents TXTAD As TextBox
    Friend WithEvents TXTCN As TextBox
    Friend WithEvents TXTDOB As TextBox
    Friend WithEvents TXTGENDER As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TXTNAME As ComboBox
End Class
