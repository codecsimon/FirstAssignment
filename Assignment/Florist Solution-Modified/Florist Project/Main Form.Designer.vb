<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        btnExit = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        picHours = New PictureBox()
        btnShow = New Button()
        btnHide = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picHours, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(680, 371)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(86, 38)
        btnExit.TabIndex = 0
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.Florist
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(323, 409)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = My.Resources.Resources.Message
        PictureBox2.Location = New Point(373, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(404, 115)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' picHours
        ' 
        picHours.BorderStyle = BorderStyle.FixedSingle
        picHours.Image = My.Resources.Resources.Hours
        picHours.Location = New Point(341, 133)
        picHours.Name = "picHours"
        picHours.Size = New Size(463, 159)
        picHours.SizeMode = PictureBoxSizeMode.CenterImage
        picHours.TabIndex = 3
        picHours.TabStop = False
        picHours.Visible = False
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(385, 371)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(96, 30)
        btnShow.TabIndex = 4
        btnShow.Text = "Show Hours"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnHide
        ' 
        btnHide.Location = New Point(504, 373)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(127, 30)
        btnHide.TabIndex = 5
        btnHide.Text = "Hide Hours"
        btnHide.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 457)
        Controls.Add(btnHide)
        Controls.Add(btnShow)
        Controls.Add(picHours)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnExit)
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Florist Haven"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(picHours, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picHours As PictureBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
End Class
