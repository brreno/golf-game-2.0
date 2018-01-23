<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pctFloor = New System.Windows.Forms.PictureBox()
        Me.pctPresent = New System.Windows.Forms.PictureBox()
        Me.pctGoal = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.pctFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPresent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGoal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(409, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Use The Arrow Keys To Move Santa."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(134, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1103, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You Must Step On Every Brick And Collect All Of The Presents To Unlock The Goal."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(505, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(323, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "START YOUR ADVENTURE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pctFloor
        '
        Me.pctFloor.Image = CType(resources.GetObject("pctFloor.Image"), System.Drawing.Image)
        Me.pctFloor.Location = New System.Drawing.Point(479, 207)
        Me.pctFloor.Name = "pctFloor"
        Me.pctFloor.Size = New System.Drawing.Size(40, 40)
        Me.pctFloor.TabIndex = 34
        Me.pctFloor.TabStop = False
        '
        'pctPresent
        '
        Me.pctPresent.Image = CType(resources.GetObject("pctPresent.Image"), System.Drawing.Image)
        Me.pctPresent.Location = New System.Drawing.Point(863, 207)
        Me.pctPresent.Name = "pctPresent"
        Me.pctPresent.Size = New System.Drawing.Size(40, 40)
        Me.pctPresent.TabIndex = 35
        Me.pctPresent.TabStop = False
        '
        'pctGoal
        '
        Me.pctGoal.BackColor = System.Drawing.Color.White
        Me.pctGoal.Image = CType(resources.GetObject("pctGoal.Image"), System.Drawing.Image)
        Me.pctGoal.Location = New System.Drawing.Point(1168, 207)
        Me.pctGoal.Name = "pctGoal"
        Me.pctGoal.Size = New System.Drawing.Size(40, 40)
        Me.pctGoal.TabIndex = 36
        Me.pctGoal.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 60)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "RETURN TO MAIN MENU"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1338, 393)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pctGoal)
        Me.Controls.Add(Me.pctPresent)
        Me.Controls.Add(Me.pctFloor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        CType(Me.pctFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPresent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGoal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pctFloor As PictureBox
    Friend WithEvents pctPresent As PictureBox
    Friend WithEvents pctGoal As PictureBox
    Friend WithEvents Button2 As Button
End Class
