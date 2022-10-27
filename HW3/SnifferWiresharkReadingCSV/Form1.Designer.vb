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
        Me.ButtonStream = New System.Windows.Forms.Button()
        Me.RichTextBoxCSV = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxPath = New System.Windows.Forms.RichTextBox()
        Me.ButtonDefaultFile = New System.Windows.Forms.Button()
        Me.ButtonCustomFile = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonBivariate = New System.Windows.Forms.Button()
        Me.RTBDistribution = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ButtonStream
        '
        Me.ButtonStream.Location = New System.Drawing.Point(558, 23)
        Me.ButtonStream.Name = "ButtonStream"
        Me.ButtonStream.Size = New System.Drawing.Size(105, 53)
        Me.ButtonStream.TabIndex = 0
        Me.ButtonStream.Text = "STREAM READER"
        Me.ButtonStream.UseVisualStyleBackColor = True
        '
        'RichTextBoxCSV
        '
        Me.RichTextBoxCSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxCSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxCSV.Location = New System.Drawing.Point(25, 121)
        Me.RichTextBoxCSV.Name = "RichTextBoxCSV"
        Me.RichTextBoxCSV.Size = New System.Drawing.Size(586, 317)
        Me.RichTextBoxCSV.TabIndex = 1
        Me.RichTextBoxCSV.Text = ""
        '
        'RichTextBoxPath
        '
        Me.RichTextBoxPath.Location = New System.Drawing.Point(269, 82)
        Me.RichTextBoxPath.Name = "RichTextBoxPath"
        Me.RichTextBoxPath.Size = New System.Drawing.Size(586, 33)
        Me.RichTextBoxPath.TabIndex = 2
        Me.RichTextBoxPath.Text = ""
        '
        'ButtonDefaultFile
        '
        Me.ButtonDefaultFile.Location = New System.Drawing.Point(25, 62)
        Me.ButtonDefaultFile.Name = "ButtonDefaultFile"
        Me.ButtonDefaultFile.Size = New System.Drawing.Size(91, 53)
        Me.ButtonDefaultFile.TabIndex = 3
        Me.ButtonDefaultFile.Text = "DEFAULT FILE"
        Me.ButtonDefaultFile.UseVisualStyleBackColor = True
        '
        'ButtonCustomFile
        '
        Me.ButtonCustomFile.Location = New System.Drawing.Point(133, 62)
        Me.ButtonCustomFile.Name = "ButtonCustomFile"
        Me.ButtonCustomFile.Size = New System.Drawing.Size(93, 53)
        Me.ButtonCustomFile.TabIndex = 4
        Me.ButtonCustomFile.Text = "CUSTOM FILE"
        Me.ButtonCustomFile.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(1055, 506)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(133, 36)
        Me.ButtonClose.TabIndex = 5
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonBivariate
        '
        Me.ButtonBivariate.Location = New System.Drawing.Point(861, 62)
        Me.ButtonBivariate.Name = "ButtonBivariate"
        Me.ButtonBivariate.Size = New System.Drawing.Size(107, 53)
        Me.ButtonBivariate.TabIndex = 6
        Me.ButtonBivariate.Text = "BIVARIATE DISTRIBUTION"
        Me.ButtonBivariate.UseVisualStyleBackColor = True
        '
        'RTBDistribution
        '
        Me.RTBDistribution.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTBDistribution.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBDistribution.Location = New System.Drawing.Point(617, 121)
        Me.RTBDistribution.Name = "RTBDistribution"
        Me.RTBDistribution.Size = New System.Drawing.Size(571, 317)
        Me.RTBDistribution.TabIndex = 10
        Me.RTBDistribution.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 554)
        Me.Controls.Add(Me.RTBDistribution)
        Me.Controls.Add(Me.ButtonBivariate)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonCustomFile)
        Me.Controls.Add(Me.ButtonDefaultFile)
        Me.Controls.Add(Me.RichTextBoxPath)
        Me.Controls.Add(Me.RichTextBoxCSV)
        Me.Controls.Add(Me.ButtonStream)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonStream As Button
    Friend WithEvents RichTextBoxCSV As RichTextBox
    Friend WithEvents RichTextBoxPath As RichTextBox
    Friend WithEvents ButtonDefaultFile As Button
    Friend WithEvents ButtonCustomFile As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonBivariate As Button
    Friend WithEvents RTBDistribution As RichTextBox
End Class
