<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonMean = New System.Windows.Forms.Button()
        Me.ButtonVariance = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.RichTextBoxMean = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxVariance = New System.Windows.Forms.RichTextBox()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxMean = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVariance = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxMean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVariance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMean
        '
        Me.ButtonMean.Location = New System.Drawing.Point(12, 12)
        Me.ButtonMean.Name = "ButtonMean"
        Me.ButtonMean.Size = New System.Drawing.Size(152, 63)
        Me.ButtonMean.TabIndex = 0
        Me.ButtonMean.Text = "MEAN"
        Me.ButtonMean.UseVisualStyleBackColor = True
        '
        'ButtonVariance
        '
        Me.ButtonVariance.Location = New System.Drawing.Point(695, 12)
        Me.ButtonVariance.Name = "ButtonVariance"
        Me.ButtonVariance.Size = New System.Drawing.Size(152, 63)
        Me.ButtonVariance.TabIndex = 1
        Me.ButtonVariance.Text = "VARIANCE"
        Me.ButtonVariance.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(695, 408)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(152, 63)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'RichTextBoxMean
        '
        Me.RichTextBoxMean.Location = New System.Drawing.Point(170, 12)
        Me.RichTextBoxMean.Name = "RichTextBoxMean"
        Me.RichTextBoxMean.Size = New System.Drawing.Size(181, 63)
        Me.RichTextBoxMean.TabIndex = 3
        Me.RichTextBoxMean.Text = ""
        '
        'RichTextBoxVariance
        '
        Me.RichTextBoxVariance.Location = New System.Drawing.Point(508, 12)
        Me.RichTextBoxVariance.Name = "RichTextBoxVariance"
        Me.RichTextBoxVariance.Size = New System.Drawing.Size(181, 63)
        Me.RichTextBoxVariance.TabIndex = 4
        Me.RichTextBoxVariance.Text = ""
        '
        'TextBoxN
        '
        Me.TextBoxN.Location = New System.Drawing.Point(379, 53)
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.Size = New System.Drawing.Size(94, 22)
        Me.TextBoxN.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Insert N"
        '
        'PictureBoxMean
        '
        Me.PictureBoxMean.Location = New System.Drawing.Point(12, 81)
        Me.PictureBoxMean.Name = "PictureBoxMean"
        Me.PictureBoxMean.Size = New System.Drawing.Size(339, 306)
        Me.PictureBoxMean.TabIndex = 7
        Me.PictureBoxMean.TabStop = False
        '
        'PictureBoxVariance
        '
        Me.PictureBoxVariance.Location = New System.Drawing.Point(508, 81)
        Me.PictureBoxVariance.Name = "PictureBoxVariance"
        Me.PictureBoxVariance.Size = New System.Drawing.Size(339, 306)
        Me.PictureBoxVariance.TabIndex = 8
        Me.PictureBoxVariance.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 487)
        Me.Controls.Add(Me.PictureBoxVariance)
        Me.Controls.Add(Me.PictureBoxMean)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxN)
        Me.Controls.Add(Me.RichTextBoxVariance)
        Me.Controls.Add(Me.RichTextBoxMean)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonVariance)
        Me.Controls.Add(Me.ButtonMean)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBoxMean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVariance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonMean As Button
    Friend WithEvents ButtonVariance As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents RichTextBoxMean As RichTextBox
    Friend WithEvents RichTextBoxVariance As RichTextBox
    Friend WithEvents TextBoxN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxMean As PictureBox
    Friend WithEvents PictureBoxVariance As PictureBox
End Class
