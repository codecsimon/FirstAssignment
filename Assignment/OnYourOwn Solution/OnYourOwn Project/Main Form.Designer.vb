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
        picMonkey = New PictureBox()
        picFlorist = New PictureBox()
        lblShow = New Label()
        btnExit = New Button()
        CType(picMonkey, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFlorist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picMonkey
        ' 
        picMonkey.BorderStyle = BorderStyle.FixedSingle
        picMonkey.Image = My.Resources.Resources.Love
        picMonkey.Location = New Point(81, 32)
        picMonkey.Name = "picMonkey"
        picMonkey.Size = New Size(263, 248)
        picMonkey.SizeMode = PictureBoxSizeMode.CenterImage
        picMonkey.TabIndex = 0
        picMonkey.TabStop = False
        ' 
        ' picFlorist
        ' 
        picFlorist.BorderStyle = BorderStyle.FixedSingle
        picFlorist.Image = My.Resources.Resources.Florist
        picFlorist.Location = New Point(385, 32)
        picFlorist.Name = "picFlorist"
        picFlorist.Size = New Size(263, 248)
        picFlorist.SizeMode = PictureBoxSizeMode.Zoom
        picFlorist.TabIndex = 1
        picFlorist.TabStop = False
        ' 
        ' lblShow
        ' 
        lblShow.BorderStyle = BorderStyle.FixedSingle
        lblShow.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblShow.Location = New Point(81, 340)
        lblShow.Name = "lblShow"
        lblShow.Size = New Size(567, 166)
        lblShow.TabIndex = 2
        lblShow.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(668, 436)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(98, 61)
        btnExit.TabIndex = 3
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 509)
        Controls.Add(btnExit)
        Controls.Add(lblShow)
        Controls.Add(picFlorist)
        Controls.Add(picMonkey)
        MaximizeBox = False
        Name = "frmMain"
        Text = "Picture Description"
        CType(picMonkey, ComponentModel.ISupportInitialize).EndInit()
        CType(picFlorist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picMonkey As PictureBox
    Friend WithEvents picFlorist As PictureBox
    Friend WithEvents lblShow As Label
    Friend WithEvents btnExit As Button
End Class
