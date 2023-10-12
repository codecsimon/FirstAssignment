<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        lblMessage = New Label()
        picIDK = New PictureBox()
        picLOL = New PictureBox()
        picSRY = New PictureBox()
        picXO = New PictureBox()
        picBFF = New PictureBox()
        picBRB = New PictureBox()
        btnExit = New Button()
        CType(picIDK, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLOL, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSRY, ComponentModel.ISupportInitialize).BeginInit()
        CType(picXO, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBFF, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBRB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.BorderStyle = BorderStyle.FixedSingle
        lblMessage.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblMessage.Location = New Point(67, 201)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(567, 200)
        lblMessage.TabIndex = 17
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picIDK
        ' 
        picIDK.BorderStyle = BorderStyle.FixedSingle
        picIDK.Image = My.Resources.Resources.IDK
        picIDK.Location = New Point(285, 49)
        picIDK.Name = "picIDK"
        picIDK.Size = New Size(100, 50)
        picIDK.SizeMode = PictureBoxSizeMode.CenterImage
        picIDK.TabIndex = 16
        picIDK.TabStop = False
        ' 
        ' picLOL
        ' 
        picLOL.BorderStyle = BorderStyle.FixedSingle
        picLOL.Image = My.Resources.Resources.LOL
        picLOL.Location = New Point(394, 49)
        picLOL.Name = "picLOL"
        picLOL.Size = New Size(100, 50)
        picLOL.SizeMode = PictureBoxSizeMode.CenterImage
        picLOL.TabIndex = 15
        picLOL.TabStop = False
        ' 
        ' picSRY
        ' 
        picSRY.BorderStyle = BorderStyle.FixedSingle
        picSRY.Image = My.Resources.Resources.SRY1
        picSRY.Location = New Point(503, 49)
        picSRY.Name = "picSRY"
        picSRY.Size = New Size(100, 50)
        picSRY.SizeMode = PictureBoxSizeMode.CenterImage
        picSRY.TabIndex = 14
        picSRY.TabStop = False
        ' 
        ' picXO
        ' 
        picXO.BorderStyle = BorderStyle.FixedSingle
        picXO.Image = My.Resources.Resources.XO
        picXO.Location = New Point(612, 49)
        picXO.Name = "picXO"
        picXO.Size = New Size(100, 50)
        picXO.SizeMode = PictureBoxSizeMode.CenterImage
        picXO.TabIndex = 13
        picXO.TabStop = False
        ' 
        ' picBFF
        ' 
        picBFF.BorderStyle = BorderStyle.FixedSingle
        picBFF.Image = My.Resources.Resources.BFF
        picBFF.Location = New Point(67, 49)
        picBFF.Name = "picBFF"
        picBFF.Size = New Size(100, 50)
        picBFF.SizeMode = PictureBoxSizeMode.CenterImage
        picBFF.TabIndex = 12
        picBFF.TabStop = False
        ' 
        ' picBRB
        ' 
        picBRB.BorderStyle = BorderStyle.FixedSingle
        picBRB.Image = My.Resources.Resources.BRB
        picBRB.Location = New Point(176, 49)
        picBRB.Name = "picBRB"
        picBRB.Size = New Size(100, 50)
        picBRB.SizeMode = PictureBoxSizeMode.CenterImage
        picBRB.TabIndex = 11
        picBRB.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(659, 348)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(88, 53)
        btnExit.TabIndex = 10
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblMessage)
        Controls.Add(picIDK)
        Controls.Add(picLOL)
        Controls.Add(picSRY)
        Controls.Add(picXO)
        Controls.Add(picBFF)
        Controls.Add(picBRB)
        Controls.Add(btnExit)
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Text Message Symbols"
        CType(picIDK, ComponentModel.ISupportInitialize).EndInit()
        CType(picLOL, ComponentModel.ISupportInitialize).EndInit()
        CType(picSRY, ComponentModel.ISupportInitialize).EndInit()
        CType(picXO, ComponentModel.ISupportInitialize).EndInit()
        CType(picBFF, ComponentModel.ISupportInitialize).EndInit()
        CType(picBRB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents picIDK As PictureBox
    Friend WithEvents picLOL As PictureBox
    Friend WithEvents picSRY As PictureBox
    Friend WithEvents picXO As PictureBox
    Friend WithEvents picBFF As PictureBox
    Friend WithEvents picBRB As PictureBox
    Friend WithEvents btnExit As Button
End Class
