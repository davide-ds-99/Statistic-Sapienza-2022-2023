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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ButtonBinomial = New System.Windows.Forms.Button()
        Me.RTBVariable = New System.Windows.Forms.RichTextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewFrequency = New System.Windows.Forms.DataGridView()
        Me.ButtonFrquency = New System.Windows.Forms.Button()
        Me.ButtonHisto = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBinomial
        '
        Me.ButtonBinomial.Location = New System.Drawing.Point(12, 12)
        Me.ButtonBinomial.Name = "ButtonBinomial"
        Me.ButtonBinomial.Size = New System.Drawing.Size(118, 54)
        Me.ButtonBinomial.TabIndex = 0
        Me.ButtonBinomial.Text = "BINOMIAL"
        Me.ButtonBinomial.UseVisualStyleBackColor = True
        '
        'RTBVariable
        '
        Me.RTBVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBVariable.Location = New System.Drawing.Point(158, 12)
        Me.RTBVariable.Name = "RTBVariable"
        Me.RTBVariable.Size = New System.Drawing.Size(249, 54)
        Me.RTBVariable.TabIndex = 2
        Me.RTBVariable.Text = ""
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(395, 170)
        Me.DataGridView.TabIndex = 3
        '
        'DataGridViewFrequency
        '
        Me.DataGridViewFrequency.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewFrequency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFrequency.Location = New System.Drawing.Point(413, 72)
        Me.DataGridViewFrequency.Name = "DataGridViewFrequency"
        Me.DataGridViewFrequency.RowHeadersWidth = 51
        Me.DataGridViewFrequency.RowTemplate.Height = 24
        Me.DataGridViewFrequency.Size = New System.Drawing.Size(669, 170)
        Me.DataGridViewFrequency.TabIndex = 4
        '
        'ButtonFrquency
        '
        Me.ButtonFrquency.Location = New System.Drawing.Point(413, 12)
        Me.ButtonFrquency.Name = "ButtonFrquency"
        Me.ButtonFrquency.Size = New System.Drawing.Size(118, 54)
        Me.ButtonFrquency.TabIndex = 5
        Me.ButtonFrquency.Text = "FREQUENCY"
        Me.ButtonFrquency.UseVisualStyleBackColor = True
        '
        'ButtonHisto
        '
        Me.ButtonHisto.Location = New System.Drawing.Point(12, 248)
        Me.ButtonHisto.Name = "ButtonHisto"
        Me.ButtonHisto.Size = New System.Drawing.Size(118, 54)
        Me.ButtonHisto.TabIndex = 6
        Me.ButtonHisto.Text = "HISTOGRAM"
        Me.ButtonHisto.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 308)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(519, 362)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(546, 308)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(519, 362)
        Me.Chart2.TabIndex = 9
        Me.Chart2.Text = "Chart2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 728)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ButtonHisto)
        Me.Controls.Add(Me.ButtonFrquency)
        Me.Controls.Add(Me.DataGridViewFrequency)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.RTBVariable)
        Me.Controls.Add(Me.ButtonBinomial)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonBinomial As Button
    Friend WithEvents RTBVariable As RichTextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents DataGridViewFrequency As DataGridView
    Friend WithEvents ButtonFrquency As Button
    Friend WithEvents ButtonHisto As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
End Class
