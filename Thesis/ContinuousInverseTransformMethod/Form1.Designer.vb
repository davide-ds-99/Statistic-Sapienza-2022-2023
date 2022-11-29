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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button100 = New System.Windows.Forms.Button()
        Me.Button500 = New System.Windows.Forms.Button()
        Me.Button1000 = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(726, 464)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(119, 59)
        Me.ButtonClear.TabIndex = 2
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(851, 464)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(119, 59)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(228, 77)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(742, 381)
        Me.Chart1.TabIndex = 6
        '
        'Button100
        '
        Me.Button100.Location = New System.Drawing.Point(225, 34)
        Me.Button100.Name = "Button100"
        Me.Button100.Size = New System.Drawing.Size(75, 37)
        Me.Button100.TabIndex = 8
        Me.Button100.Text = "n=100"
        Me.Button100.UseVisualStyleBackColor = True
        '
        'Button500
        '
        Me.Button500.Location = New System.Drawing.Point(307, 34)
        Me.Button500.Name = "Button500"
        Me.Button500.Size = New System.Drawing.Size(75, 37)
        Me.Button500.TabIndex = 9
        Me.Button500.Text = "n=500"
        Me.Button500.UseVisualStyleBackColor = True
        '
        'Button1000
        '
        Me.Button1000.Location = New System.Drawing.Point(388, 34)
        Me.Button1000.Name = "Button1000"
        Me.Button1000.Size = New System.Drawing.Size(75, 37)
        Me.Button1000.TabIndex = 10
        Me.Button1000.Text = "n=1000"
        Me.Button1000.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 597)
        Me.Controls.Add(Me.Button1000)
        Me.Controls.Add(Me.Button500)
        Me.Controls.Add(Me.Button100)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonClear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button100 As Button
    Friend WithEvents Button500 As Button
    Friend WithEvents Button1000 As Button
End Class
