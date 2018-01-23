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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pctWall = New System.Windows.Forms.PictureBox()
        Me.pctLocked = New System.Windows.Forms.PictureBox()
        Me.pctGoal = New System.Windows.Forms.PictureBox()
        Me.pctPresent = New System.Windows.Forms.PictureBox()
        Me.pctFloor = New System.Windows.Forms.PictureBox()
        Me.pctNotFloor = New System.Windows.Forms.PictureBox()
        Me.pctSanta = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTiles = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWIN = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCol = New System.Windows.Forms.TextBox()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblResets = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pctWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLocked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGoal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPresent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctNotFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSanta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 60)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "PROCEED TO NEXT LEVEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pctWall
        '
        Me.pctWall.Image = CType(resources.GetObject("pctWall.Image"), System.Drawing.Image)
        Me.pctWall.Location = New System.Drawing.Point(830, 151)
        Me.pctWall.Name = "pctWall"
        Me.pctWall.Size = New System.Drawing.Size(40, 40)
        Me.pctWall.TabIndex = 56
        Me.pctWall.TabStop = False
        Me.pctWall.Visible = False
        '
        'pctLocked
        '
        Me.pctLocked.Image = CType(resources.GetObject("pctLocked.Image"), System.Drawing.Image)
        Me.pctLocked.Location = New System.Drawing.Point(774, 105)
        Me.pctLocked.Name = "pctLocked"
        Me.pctLocked.Size = New System.Drawing.Size(40, 40)
        Me.pctLocked.TabIndex = 55
        Me.pctLocked.TabStop = False
        Me.pctLocked.Visible = False
        '
        'pctGoal
        '
        Me.pctGoal.BackColor = System.Drawing.Color.White
        Me.pctGoal.Image = CType(resources.GetObject("pctGoal.Image"), System.Drawing.Image)
        Me.pctGoal.Location = New System.Drawing.Point(774, 151)
        Me.pctGoal.Name = "pctGoal"
        Me.pctGoal.Size = New System.Drawing.Size(40, 40)
        Me.pctGoal.TabIndex = 54
        Me.pctGoal.TabStop = False
        Me.pctGoal.Visible = False
        '
        'pctPresent
        '
        Me.pctPresent.Image = CType(resources.GetObject("pctPresent.Image"), System.Drawing.Image)
        Me.pctPresent.Location = New System.Drawing.Point(774, 197)
        Me.pctPresent.Name = "pctPresent"
        Me.pctPresent.Size = New System.Drawing.Size(40, 40)
        Me.pctPresent.TabIndex = 53
        Me.pctPresent.TabStop = False
        Me.pctPresent.Visible = False
        '
        'pctFloor
        '
        Me.pctFloor.Image = CType(resources.GetObject("pctFloor.Image"), System.Drawing.Image)
        Me.pctFloor.Location = New System.Drawing.Point(718, 151)
        Me.pctFloor.Name = "pctFloor"
        Me.pctFloor.Size = New System.Drawing.Size(40, 40)
        Me.pctFloor.TabIndex = 52
        Me.pctFloor.TabStop = False
        Me.pctFloor.Visible = False
        '
        'pctNotFloor
        '
        Me.pctNotFloor.Image = CType(resources.GetObject("pctNotFloor.Image"), System.Drawing.Image)
        Me.pctNotFloor.Location = New System.Drawing.Point(718, 197)
        Me.pctNotFloor.Name = "pctNotFloor"
        Me.pctNotFloor.Size = New System.Drawing.Size(40, 40)
        Me.pctNotFloor.TabIndex = 51
        Me.pctNotFloor.TabStop = False
        Me.pctNotFloor.Visible = False
        '
        'pctSanta
        '
        Me.pctSanta.Image = CType(resources.GetObject("pctSanta.Image"), System.Drawing.Image)
        Me.pctSanta.Location = New System.Drawing.Point(718, 105)
        Me.pctSanta.Name = "pctSanta"
        Me.pctSanta.Size = New System.Drawing.Size(40, 40)
        Me.pctSanta.TabIndex = 50
        Me.pctSanta.TabStop = False
        Me.pctSanta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(643, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "GRASS TILES COLLECTED: "
        '
        'lblTiles
        '
        Me.lblTiles.AutoSize = True
        Me.lblTiles.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiles.ForeColor = System.Drawing.Color.Green
        Me.lblTiles.Location = New System.Drawing.Point(813, 78)
        Me.lblTiles.Name = "lblTiles"
        Me.lblTiles.Size = New System.Drawing.Size(18, 20)
        Me.lblTiles.TabIndex = 48
        Me.lblTiles.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(102, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(738, 39)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "YOU NEED BOTH MARKERS TO BE ABLE TO UNLOCK THE GOAL"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresent.ForeColor = System.Drawing.Color.Green
        Me.lblPresent.Location = New System.Drawing.Point(813, 54)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(18, 20)
        Me.lblPresent.TabIndex = 46
        Me.lblPresent.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(657, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "CHIPS COLLECTED: "
        '
        'lblWIN
        '
        Me.lblWIN.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWIN.ForeColor = System.Drawing.Color.Green
        Me.lblWIN.Location = New System.Drawing.Point(245, 114)
        Me.lblWIN.Name = "lblWIN"
        Me.lblWIN.Size = New System.Drawing.Size(396, 123)
        Me.lblWIN.TabIndex = 44
        Me.lblWIN.Text = "YOU WIN! PROCEED TO THE NEXT LEVEL!"
        Me.lblWIN.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(685, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 34)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "CLICK TO RESET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(688, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Columns"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(688, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Rows"
        Me.Label1.Visible = False
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(745, 290)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(100, 20)
        Me.txtCol.TabIndex = 40
        Me.txtCol.Text = "10"
        Me.txtCol.Visible = False
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(745, 245)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(100, 20)
        Me.txtRow.TabIndex = 39
        Me.txtRow.Text = "5"
        Me.txtRow.Visible = False
        Me.txtRow.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(669, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "YOU HAVE             RESETS REMAINING"
        '
        'lblResets
        '
        Me.lblResets.AutoSize = True
        Me.lblResets.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResets.ForeColor = System.Drawing.Color.Maroon
        Me.lblResets.Location = New System.Drawing.Point(740, 388)
        Me.lblResets.Name = "lblResets"
        Me.lblResets.Size = New System.Drawing.Size(15, 20)
        Me.lblResets.TabIndex = 59
        Me.lblResets.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(266, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(375, 34)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "CLICK TO RESTART WHOLE GAME"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 460)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblResets)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pctWall)
        Me.Controls.Add(Me.pctLocked)
        Me.Controls.Add(Me.pctGoal)
        Me.Controls.Add(Me.pctPresent)
        Me.Controls.Add(Me.pctFloor)
        Me.Controls.Add(Me.pctNotFloor)
        Me.Controls.Add(Me.pctSanta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTiles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWIN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCol)
        Me.Controls.Add(Me.txtRow)
        Me.Name = "Form1"
        Me.Text = "+"
        CType(Me.pctWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLocked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGoal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPresent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctNotFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSanta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents pctWall As PictureBox
    Friend WithEvents pctLocked As PictureBox
    Friend WithEvents pctGoal As PictureBox
    Friend WithEvents pctPresent As PictureBox
    Friend WithEvents pctFloor As PictureBox
    Friend WithEvents pctNotFloor As PictureBox
    Friend WithEvents pctSanta As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTiles As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPresent As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWIN As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCol As TextBox
    Friend WithEvents txtRow As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblResets As Label
    Friend WithEvents Label8 As Label
End Class
