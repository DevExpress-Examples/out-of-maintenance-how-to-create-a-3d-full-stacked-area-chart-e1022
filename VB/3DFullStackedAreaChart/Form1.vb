Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace _DFullStackedAreaChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim fullStackedArea3DChart As New ChartControl()

			' Create two series of the FullStackedArea3D view type.
			Dim series1 As New Series("Series 1", ViewType.FullStackedArea3D)
			Dim series2 As New Series("Series 2", ViewType.FullStackedArea3D)

			' Populate both series with points.
			series1.Points.Add(New SeriesPoint("A", 80))
			series1.Points.Add(New SeriesPoint("B", 20))
			series1.Points.Add(New SeriesPoint("C", 50))
			series1.Points.Add(New SeriesPoint("D", 30))
			series2.Points.Add(New SeriesPoint("A", 40))
			series2.Points.Add(New SeriesPoint("B", 60))
			series2.Points.Add(New SeriesPoint("C", 20))
			series2.Points.Add(New SeriesPoint("D", 80))

			' Add the series to the chart.
			fullStackedArea3DChart.Series.AddRange(New Series() { series1, series2})

			' Adjust the series options.
			series1.Label.Visible = False
			series2.Label.Visible = False

			' Adjust the view-type-specific options of the series.
			CType(series1.View, FullStackedArea3DSeriesView).Transparency = 20
			CType(series2.View, FullStackedArea3DSeriesView).Transparency = 60

			' Access the diagram's options.
			CType(fullStackedArea3DChart.Diagram, XYDiagram3D).ZoomPercent = 110

			' Add a title to the chart and hide the legend.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "3D Full Stacked Area Chart"
			fullStackedArea3DChart.Titles.Add(chartTitle1)
			fullStackedArea3DChart.Legend.Visible = False

			' Add the chart to the form.
			fullStackedArea3DChart.Dock = DockStyle.Fill
			Me.Controls.Add(fullStackedArea3DChart)
		End Sub

	End Class
End Namespace

