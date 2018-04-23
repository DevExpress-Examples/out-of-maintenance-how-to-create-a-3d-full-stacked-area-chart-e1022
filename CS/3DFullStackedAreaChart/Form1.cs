using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace _DFullStackedAreaChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl fullStackedArea3DChart = new ChartControl();

            // Create two series of the FullStackedArea3D view type.
            Series series1 = new Series("Series 1", ViewType.FullStackedArea3D);
            Series series2 = new Series("Series 2", ViewType.FullStackedArea3D);

            // Populate both series with points.
            series1.Points.Add(new SeriesPoint("A", 80));
            series1.Points.Add(new SeriesPoint("B", 20));
            series1.Points.Add(new SeriesPoint("C", 50));
            series1.Points.Add(new SeriesPoint("D", 30));
            series2.Points.Add(new SeriesPoint("A", 40));
            series2.Points.Add(new SeriesPoint("B", 60));
            series2.Points.Add(new SeriesPoint("C", 20));
            series2.Points.Add(new SeriesPoint("D", 80));

            // Add the series to the chart.
            fullStackedArea3DChart.Series.AddRange(new Series[] {
                series1,
                series2});

            // Adjust the series options.
            series1.Label.Visible = false;
            series2.Label.Visible = false;

            // Adjust the view-type-specific options of the series.
            ((FullStackedArea3DSeriesView)series1.View).Transparency = 20;
            ((FullStackedArea3DSeriesView)series2.View).Transparency = 60;

            // Access the diagram's options.
            ((XYDiagram3D)fullStackedArea3DChart.Diagram).ZoomPercent = 110;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Full Stacked Area Chart";
            fullStackedArea3DChart.Titles.Add(chartTitle1);
            fullStackedArea3DChart.Legend.Visible = false;

            // Add the chart to the form.
            fullStackedArea3DChart.Dock = DockStyle.Fill;
            this.Controls.Add(fullStackedArea3DChart);
        }

    }
}

