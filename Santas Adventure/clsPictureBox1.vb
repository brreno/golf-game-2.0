Public Class clsPictureBox1
    Inherits PictureBox
    Public PictureBox1 As New PictureBox

    Sub New()
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(180, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.BackColor = Color.Gray
        Me.PictureBox1.BorderStyle = BorderStyle.None
    End Sub


End Class
