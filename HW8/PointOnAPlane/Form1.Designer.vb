﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ChartX = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartY = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea4.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart.Legends.Add(Legend4)
        Me.Chart.Location = New System.Drawing.Point(43, 96)
        Me.Chart.Name = "Chart"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart.Series.Add(Series4)
        Me.Chart.Size = New System.Drawing.Size(606, 525)
        Me.Chart.TabIndex = 1
        Me.Chart.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 78)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "DRAW CARTESIAN PLANE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(1048, 578)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(89, 43)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ChartX
        '
        ChartArea5.Name = "ChartArea1"
        Me.ChartX.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.ChartX.Legends.Add(Legend5)
        Me.ChartX.Location = New System.Drawing.Point(674, 42)
        Me.ChartX.Name = "ChartX"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.ChartX.Series.Add(Series5)
        Me.ChartX.Size = New System.Drawing.Size(368, 260)
        Me.ChartX.TabIndex = 4
        Me.ChartX.Text = "ChartX"
        '
        'ChartY
        '
        ChartArea6.Name = "ChartArea1"
        Me.ChartY.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.ChartY.Legends.Add(Legend6)
        Me.ChartY.Location = New System.Drawing.Point(674, 339)
        Me.ChartY.Name = "ChartY"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.ChartY.Series.Add(Series6)
        Me.ChartY.Size = New System.Drawing.Size(368, 282)
        Me.ChartY.TabIndex = 5
        Me.ChartY.Text = "Chart2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "EMPIRICAL DISTRIBUTION X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "EMPIRICAL DISTRIBUTION Y"
        '
        'TextBoxN
        '
        Me.TextBoxN.Location = New System.Drawing.Point(380, 40)
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxN.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(302, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "INSERT N"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 644)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChartY)
        Me.Controls.Add(Me.ChartX)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ChartX As DataVisualization.Charting.Chart
    Friend WithEvents ChartY As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxN As TextBox
    Friend WithEvents Label3 As Label
End Class
