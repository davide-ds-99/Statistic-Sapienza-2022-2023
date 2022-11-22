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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ButtonGauss = New System.Windows.Forms.Button()
        Me.ButtonChiSquare = New System.Windows.Forms.Button()
        Me.ButtonStudent = New System.Windows.Forms.Button()
        Me.ButtonFisher = New System.Windows.Forms.Button()
        Me.ButtonCauchy = New System.Windows.Forms.Button()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGauss
        '
        Me.ButtonGauss.Location = New System.Drawing.Point(25, 23)
        Me.ButtonGauss.Name = "ButtonGauss"
        Me.ButtonGauss.Size = New System.Drawing.Size(96, 62)
        Me.ButtonGauss.TabIndex = 0
        Me.ButtonGauss.Text = "GAUSS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(X)"
        Me.ButtonGauss.UseVisualStyleBackColor = True
        '
        'ButtonChiSquare
        '
        Me.ButtonChiSquare.Location = New System.Drawing.Point(136, 23)
        Me.ButtonChiSquare.Name = "ButtonChiSquare"
        Me.ButtonChiSquare.Size = New System.Drawing.Size(101, 62)
        Me.ButtonChiSquare.TabIndex = 1
        Me.ButtonChiSquare.Text = "CHI SQUARE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(X^2)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonChiSquare.UseVisualStyleBackColor = True
        '
        'ButtonStudent
        '
        Me.ButtonStudent.Location = New System.Drawing.Point(253, 23)
        Me.ButtonStudent.Name = "ButtonStudent"
        Me.ButtonStudent.Size = New System.Drawing.Size(108, 62)
        Me.ButtonStudent.TabIndex = 2
        Me.ButtonStudent.Text = "CHI STUDENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(X/Y^2)"
        Me.ButtonStudent.UseVisualStyleBackColor = True
        '
        'ButtonFisher
        '
        Me.ButtonFisher.Location = New System.Drawing.Point(377, 23)
        Me.ButtonFisher.Name = "ButtonFisher"
        Me.ButtonFisher.Size = New System.Drawing.Size(109, 62)
        Me.ButtonFisher.TabIndex = 3
        Me.ButtonFisher.Text = "FISHER F" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(X^2/Y^2)"
        Me.ButtonFisher.UseVisualStyleBackColor = True
        '
        'ButtonCauchy
        '
        Me.ButtonCauchy.Location = New System.Drawing.Point(504, 23)
        Me.ButtonCauchy.Name = "ButtonCauchy"
        Me.ButtonCauchy.Size = New System.Drawing.Size(105, 62)
        Me.ButtonCauchy.TabIndex = 4
        Me.ButtonCauchy.Text = "CAUCHY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(X/Y)"
        Me.ButtonCauchy.UseVisualStyleBackColor = True
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(25, 91)
        Me.Chart.Name = "Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart.Series.Add(Series1)
        Me.Chart.Size = New System.Drawing.Size(584, 523)
        Me.Chart.TabIndex = 5
        Me.Chart.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 626)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.ButtonCauchy)
        Me.Controls.Add(Me.ButtonFisher)
        Me.Controls.Add(Me.ButtonStudent)
        Me.Controls.Add(Me.ButtonChiSquare)
        Me.Controls.Add(Me.ButtonGauss)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonGauss As Button
    Friend WithEvents ButtonChiSquare As Button
    Friend WithEvents ButtonStudent As Button
    Friend WithEvents ButtonFisher As Button
    Friend WithEvents ButtonCauchy As Button
    Friend WithEvents Chart As DataVisualization.Charting.Chart
End Class
