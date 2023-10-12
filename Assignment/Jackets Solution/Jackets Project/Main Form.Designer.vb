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
        PictureBox1 = New PictureBox()
        picChart = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.BlackJacket
        PictureBox1.Location = New Point(31, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(328, 415)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' picChart
        ' 
        picChart.Image = My.Resources.Resources.SizeChart
        picChart.Location = New Point(382, 95)
        picChart.Name = "picChart"
        picChart.Size = New Size(393, 328)
        picChart.SizeMode = PictureBoxSizeMode.Zoom
        picChart.TabIndex = 3
        picChart.TabStop = False
        picChart.Visible = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(picChart)
        Controls.Add(PictureBox1)
        Controls.Add(btnSizeChart)
        Controls.Add(btnExit)
        Name = "frmMain"
        Text = "JacketsAndMore"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picChart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSizeChart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picChart As PictureBox
End Class
