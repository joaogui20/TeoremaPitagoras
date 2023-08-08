<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPitagoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPitagoras))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblArea2 = New System.Windows.Forms.Label()
        Me.lblArea3 = New System.Windows.Forms.Label()
        Me.lblArea4 = New System.Windows.Forms.Label()
        Me.lblArea5 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(362, 252)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(403, 67)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(96, 24)
        Me.lblArea.TabIndex = 1
        Me.lblArea.Text = "Valor de a"
        '
        'lblArea2
        '
        Me.lblArea2.AutoSize = True
        Me.lblArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea2.Location = New System.Drawing.Point(403, 125)
        Me.lblArea2.Name = "lblArea2"
        Me.lblArea2.Size = New System.Drawing.Size(97, 24)
        Me.lblArea2.TabIndex = 2
        Me.lblArea2.Text = "Valor de b"
        '
        'lblArea3
        '
        Me.lblArea3.AutoSize = True
        Me.lblArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea3.Location = New System.Drawing.Point(403, 183)
        Me.lblArea3.Name = "lblArea3"
        Me.lblArea3.Size = New System.Drawing.Size(97, 24)
        Me.lblArea3.TabIndex = 3
        Me.lblArea3.Text = "Valor de h"
        '
        'lblArea4
        '
        Me.lblArea4.AutoSize = True
        Me.lblArea4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea4.Location = New System.Drawing.Point(12, 295)
        Me.lblArea4.Name = "lblArea4"
        Me.lblArea4.Size = New System.Drawing.Size(141, 24)
        Me.lblArea4.TabIndex = 4
        Me.lblArea4.Text = "a^2 = b^2 + h^2"
        '
        'lblArea5
        '
        Me.lblArea5.AutoSize = True
        Me.lblArea5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea5.Location = New System.Drawing.Point(187, 295)
        Me.lblArea5.Name = "lblArea5"
        Me.lblArea5.Size = New System.Drawing.Size(71, 24)
        Me.lblArea5.TabIndex = 5
        Me.lblArea5.Text = "Área = "
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(506, 64)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(120, 29)
        Me.txtA.TabIndex = 6
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(506, 125)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(120, 29)
        Me.txtB.TabIndex = 7
        '
        'txtH
        '
        Me.txtH.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtH.Location = New System.Drawing.Point(506, 183)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(120, 29)
        Me.txtH.TabIndex = 8
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(407, 241)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(219, 60)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'frmPitagoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 360)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblArea5)
        Me.Controls.Add(Me.lblArea4)
        Me.Controls.Add(Me.lblArea3)
        Me.Controls.Add(Me.lblArea2)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPitagoras"
        Me.Text = "Teorema de Pitágoras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblArea2 As System.Windows.Forms.Label
    Friend WithEvents lblArea3 As System.Windows.Forms.Label
    Friend WithEvents lblArea4 As System.Windows.Forms.Label
    Friend WithEvents lblArea5 As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtH As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button

End Class
