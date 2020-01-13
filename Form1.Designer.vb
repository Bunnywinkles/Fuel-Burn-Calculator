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
        Me.FlightHours = New System.Windows.Forms.NumericUpDown()
        Me.FlightMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AircraftFuelBurn = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FSeats = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.JSeats = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.YSeats = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AircraftCapacity = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblFuelCosts = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblCrewCosts = New System.Windows.Forms.Label()
        Me.cbACSize = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbOriginSize = New System.Windows.Forms.ComboBox()
        Me.cbDestSize = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblAPFees = New System.Windows.Forms.Label()
        CType(Me.FlightHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AircraftFuelBurn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FSeats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JSeats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YSeats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AircraftCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlightHours
        '
        Me.FlightHours.Location = New System.Drawing.Point(9, 32)
        Me.FlightHours.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.FlightHours.Name = "FlightHours"
        Me.FlightHours.Size = New System.Drawing.Size(120, 20)
        Me.FlightHours.TabIndex = 0
        '
        'FlightMinutes
        '
        Me.FlightMinutes.Location = New System.Drawing.Point(146, 32)
        Me.FlightMinutes.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.FlightMinutes.Name = "FlightMinutes"
        Me.FlightMinutes.Size = New System.Drawing.Size(120, 20)
        Me.FlightMinutes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minutes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.FlightMinutes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.FlightHours)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 65)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight Information"
        '
        'AircraftFuelBurn
        '
        Me.AircraftFuelBurn.Location = New System.Drawing.Point(9, 32)
        Me.AircraftFuelBurn.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.AircraftFuelBurn.Name = "AircraftFuelBurn"
        Me.AircraftFuelBurn.Size = New System.Drawing.Size(120, 20)
        Me.AircraftFuelBurn.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.AircraftCapacity)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AircraftFuelBurn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 107)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aircraft Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.FSeats)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.JSeats)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.YSeats)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(204, 43)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seats"
        '
        'FSeats
        '
        Me.FSeats.Location = New System.Drawing.Point(152, 16)
        Me.FSeats.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.FSeats.Name = "FSeats"
        Me.FSeats.Size = New System.Drawing.Size(38, 20)
        Me.FSeats.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "F"
        '
        'JSeats
        '
        Me.JSeats.Location = New System.Drawing.Point(89, 16)
        Me.JSeats.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.JSeats.Name = "JSeats"
        Me.JSeats.Size = New System.Drawing.Size(38, 20)
        Me.JSeats.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "J"
        '
        'YSeats
        '
        Me.YSeats.Location = New System.Drawing.Point(26, 16)
        Me.YSeats.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.YSeats.Name = "YSeats"
        Me.YSeats.Size = New System.Drawing.Size(38, 20)
        Me.YSeats.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Y"
        '
        'AircraftCapacity
        '
        Me.AircraftCapacity.Location = New System.Drawing.Point(145, 32)
        Me.AircraftCapacity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.AircraftCapacity.Name = "AircraftCapacity"
        Me.AircraftCapacity.Size = New System.Drawing.Size(120, 20)
        Me.AircraftCapacity.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Capacity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fuel Burn"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(322, 167)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblFuelCosts)
        Me.GroupBox3.Location = New System.Drawing.Point(302, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 143)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fuel Costs"
        '
        'lblFuelCosts
        '
        Me.lblFuelCosts.AutoSize = True
        Me.lblFuelCosts.Location = New System.Drawing.Point(6, 16)
        Me.lblFuelCosts.Name = "lblFuelCosts"
        Me.lblFuelCosts.Size = New System.Drawing.Size(0, 13)
        Me.lblFuelCosts.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblCrewCosts)
        Me.GroupBox5.Location = New System.Drawing.Point(438, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(130, 178)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Crew Costs"
        '
        'lblCrewCosts
        '
        Me.lblCrewCosts.AutoSize = True
        Me.lblCrewCosts.Location = New System.Drawing.Point(6, 17)
        Me.lblCrewCosts.Name = "lblCrewCosts"
        Me.lblCrewCosts.Size = New System.Drawing.Size(0, 13)
        Me.lblCrewCosts.TabIndex = 0
        '
        'cbACSize
        '
        Me.cbACSize.FormattingEnabled = True
        Me.cbACSize.Items.AddRange(New Object() {"Light", "Regional", "Small", "Medium", "Large", "X-Large", "Jumbo"})
        Me.cbACSize.Location = New System.Drawing.Point(231, 156)
        Me.cbACSize.Name = "cbACSize"
        Me.cbACSize.Size = New System.Drawing.Size(53, 21)
        Me.cbACSize.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Size"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.cbDestSize)
        Me.GroupBox6.Controls.Add(Me.cbOriginSize)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(161, 59)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Airport Information"
        '
        'cbOriginSize
        '
        Me.cbOriginSize.FormattingEnabled = True
        Me.cbOriginSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbOriginSize.Location = New System.Drawing.Point(9, 31)
        Me.cbOriginSize.Name = "cbOriginSize"
        Me.cbOriginSize.Size = New System.Drawing.Size(35, 21)
        Me.cbOriginSize.TabIndex = 0
        '
        'cbDestSize
        '
        Me.cbDestSize.FormattingEnabled = True
        Me.cbDestSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbDestSize.Location = New System.Drawing.Point(72, 31)
        Me.cbDestSize.Name = "cbDestSize"
        Me.cbDestSize.Size = New System.Drawing.Size(37, 21)
        Me.cbDestSize.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Origin Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Destination Size"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblAPFees)
        Me.GroupBox7.Location = New System.Drawing.Point(179, 196)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(389, 59)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Airport Fees"
        '
        'lblAPFees
        '
        Me.lblAPFees.AutoSize = True
        Me.lblAPFees.Location = New System.Drawing.Point(7, 15)
        Me.lblAPFees.Name = "lblAPFees"
        Me.lblAPFees.Size = New System.Drawing.Size(45, 13)
        Me.lblAPFees.TabIndex = 0
        Me.lblAPFees.Text = "Label11"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 262)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cbACSize)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Fuel Cost Calculator"
        CType(Me.FlightHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AircraftFuelBurn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FSeats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JSeats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YSeats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AircraftCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlightHours As NumericUpDown
    Friend WithEvents FlightMinutes As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AircraftFuelBurn As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AircraftCapacity As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblFuelCosts As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents JSeats As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents YSeats As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents FSeats As NumericUpDown
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblCrewCosts As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbACSize As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDestSize As ComboBox
    Friend WithEvents cbOriginSize As ComboBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblAPFees As Label
End Class
