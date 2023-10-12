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
        btnExit = New Button()
        btnSizeChart = New Button()
        picJacket = New PictureBox()
        picChart = New PictureBox()
        btnBlack = New Button()
        btnBlue = New Button()
        btnBrown = New Button()
        btnRed = New Button()
        CType(picJacket, ComponentModel.ISupportInitialize).BeginInit()
        CType(picChart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(587, 32)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(138, 41)
        btnExit.TabIndex = 0
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSizeChart
        ' 
        btnSizeChart.Location = New Point(412, 32)
        btnSizeChart.Name = "btnSizeChart"
        btnSizeChart.Size = New Size(138, 41)
        btnSizeChart.TabIndex = 1
        btnSizeChart.Text = "S&ize Chart"
        btnSizeChart.UseVisualStyleBackColor = True
        ' 
        ' picJacket
        ' 
        picJacket.BorderStyle = BorderStyle.FixedSingle
        picJacket.Image = My.Resources.Resources.BlackJacket
        picJacket.Location = New Point(31, 23)
        picJacket.Name = "picJacket"
        picJacket.Size = New Size(328, 342)
        picJacket.SizeMode = PictureBoxSizeMode.StretchImage
        picJacket.TabIndex = 2
        picJacket.TabStop = False
        ' 
        ' picChart
        ' 
        picChart.Image = My.Resources.Resources.SizeChart
        picChart.Location = New Point(382, 95)
        picChart.Name = "picChart"
        picChart.Size = New Size(393, 270)
        picChart.SizeMode = PictureBoxSizeMode.Zoom
        picChart.TabIndex = 3
        picChart.TabStop = False
        picChart.Visible = False
        ' 
        ' btnBlack
        ' 
        btnBlack.Location = New Point(38, 396)
        btnBlack.Name = "btnBlack"
        btnBlack.Size = New Size(166, 42)
        btnBlack.TabIndex = 4
        btnBlack.Text = "&Black"
        btnBlack.UseVisualStyleBackColor = True
        ' 
        ' btnBlue
        ' 
        btnBlue.Location = New Point(228, 396)
        btnBlue.Name = "btnBlue"
        btnBlue.Size = New Size(166, 42)
        btnBlue.TabIndex = 5
        btnBlue.Text = "Bl&ue"
        btnBlue.UseVisualStyleBackColor = True
        ' 
        ' btnBrown
        ' 
        btnBrown.Location = New Point(418, 396)
        btnBrown.Name = "btnBrown"
        btnBrown.Size = New Size(166, 42)
        btnBrown.TabIndex = 6
        btnBrown.Text = "Bro&wn"
        btnBrown.UseVisualStyleBackColor = True
        ' 
        ' btnRed
        ' 
        btnRed.Location = New Point(608, 396)
        btnRed.Name = "btnRed"
        btnRed.Size = New Size(166, 42)
        btnRed.TabIndex = 7
        btnRed.Text = "&Red"
        btnRed.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRed)
        Controls.Add(btnBrown)
        Controls.Add(btnBlue)
        Controls.Add(btnBlack)
        Controls.Add(picChart)
        Controls.Add(picJacket)
        Controls.Add(btnSizeChart)
        Controls.Add(btnExit)
        Name = "frmMain"
        Text = "Jackets And More"
        CType(picJacket, ComponentModel.ISupportInitialize).EndInit()
        CType(picChart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSizeChart As Button
    Friend WithEvents picJacket As PictureBox
    Friend WithEvents picChart As PictureBox
    Friend WithEvents btnBlack As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnBrown As Button
    Friend WithEvents btnRed As Button
End Class
