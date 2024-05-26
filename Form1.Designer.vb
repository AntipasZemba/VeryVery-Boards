<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRentalCharges = New System.Windows.Forms.Label()
        Me.lblBoardBootsCharges = New System.Windows.Forms.Label()
        Me.lblBoardCharges = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBoards = New System.Windows.Forms.TextBox()
        Me.txtBoardBoots = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDailyTotal = New System.Windows.Forms.Label()
        Me.lblDailyBoards = New System.Windows.Forms.Label()
        Me.lblDailyBoots = New System.Windows.Forms.Label()
        Me.lblAvgCust = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Boards:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Boards w/boot:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Boards Charges:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Boards w/boot Charges:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rental Charges:"
        '
        'lblRentalCharges
        '
        Me.lblRentalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRentalCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRentalCharges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRentalCharges.Location = New System.Drawing.Point(175, 221)
        Me.lblRentalCharges.Name = "lblRentalCharges"
        Me.lblRentalCharges.Size = New System.Drawing.Size(98, 19)
        Me.lblRentalCharges.TabIndex = 15
        '
        'lblBoardBootsCharges
        '
        Me.lblBoardBootsCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoardBootsCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBoardBootsCharges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBoardBootsCharges.Location = New System.Drawing.Point(175, 186)
        Me.lblBoardBootsCharges.Name = "lblBoardBootsCharges"
        Me.lblBoardBootsCharges.Size = New System.Drawing.Size(98, 19)
        Me.lblBoardBootsCharges.TabIndex = 16
        '
        'lblBoardCharges
        '
        Me.lblBoardCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoardCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBoardCharges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBoardCharges.Location = New System.Drawing.Point(175, 151)
        Me.lblBoardCharges.Name = "lblBoardCharges"
        Me.lblBoardCharges.Size = New System.Drawing.Size(98, 19)
        Me.lblBoardCharges.TabIndex = 17
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(175, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(98, 20)
        Me.txtName.TabIndex = 18
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(175, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(98, 20)
        Me.txtID.TabIndex = 19
        '
        'txtBoards
        '
        Me.txtBoards.Location = New System.Drawing.Point(175, 81)
        Me.txtBoards.Name = "txtBoards"
        Me.txtBoards.Size = New System.Drawing.Size(53, 20)
        Me.txtBoards.TabIndex = 20
        '
        'txtBoardBoots
        '
        Me.txtBoardBoots.Location = New System.Drawing.Point(175, 116)
        Me.txtBoardBoots.Name = "txtBoardBoots"
        Me.txtBoardBoots.Size = New System.Drawing.Size(53, 20)
        Me.txtBoardBoots.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(16, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Daily Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(16, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SnowBoards:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(16, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "SnowBoards w/boot:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(16, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Avg Rental p/Cust:"
        '
        'lblDailyTotal
        '
        Me.lblDailyTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDailyTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDailyTotal.Location = New System.Drawing.Point(175, 23)
        Me.lblDailyTotal.Name = "lblDailyTotal"
        Me.lblDailyTotal.Size = New System.Drawing.Size(98, 19)
        Me.lblDailyTotal.TabIndex = 11
        '
        'lblDailyBoards
        '
        Me.lblDailyBoards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyBoards.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDailyBoards.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDailyBoards.Location = New System.Drawing.Point(175, 53)
        Me.lblDailyBoards.Name = "lblDailyBoards"
        Me.lblDailyBoards.Size = New System.Drawing.Size(98, 19)
        Me.lblDailyBoards.TabIndex = 12
        '
        'lblDailyBoots
        '
        Me.lblDailyBoots.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyBoots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDailyBoots.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDailyBoots.Location = New System.Drawing.Point(175, 81)
        Me.lblDailyBoots.Name = "lblDailyBoots"
        Me.lblDailyBoots.Size = New System.Drawing.Size(98, 19)
        Me.lblDailyBoots.TabIndex = 13
        '
        'lblAvgCust
        '
        Me.lblAvgCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAvgCust.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAvgCust.Location = New System.Drawing.Point(175, 110)
        Me.lblAvgCust.Name = "lblAvgCust"
        Me.lblAvgCust.Size = New System.Drawing.Size(98, 19)
        Me.lblAvgCust.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAvgCust)
        Me.GroupBox1.Controls.Add(Me.lblDailyBoots)
        Me.GroupBox1.Controls.Add(Me.lblDailyBoards)
        Me.GroupBox1.Controls.Add(Me.lblDailyTotal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 157)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daily Summary"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBoardBoots)
        Me.GroupBox2.Controls.Add(Me.txtBoards)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.lblBoardCharges)
        Me.GroupBox2.Controls.Add(Me.lblBoardBootsCharges)
        Me.GroupBox2.Controls.Add(Me.lblRentalCharges)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 274)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Rental"
        '
        'btnCalculate
        '
        Me.btnCalculate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalculate.Location = New System.Drawing.Point(363, 316)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(106, 35)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(363, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 35)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearAll.Location = New System.Drawing.Point(363, 397)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(106, 35)
        Me.btnClearAll.TabIndex = 26
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(363, 438)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 35)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(363, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(347, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 509)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Very Very Boards"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRentalCharges As Label
    Friend WithEvents lblBoardBootsCharges As Label
    Friend WithEvents lblBoardCharges As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBoards As TextBox
    Friend WithEvents txtBoardBoots As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDailyTotal As Label
    Friend WithEvents lblDailyBoards As Label
    Friend WithEvents lblDailyBoots As Label
    Friend WithEvents lblAvgCust As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
