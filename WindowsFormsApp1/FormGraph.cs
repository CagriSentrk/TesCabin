using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class FormGraph : Form
    {
        private Chart[] charts = new Chart[4];
        private List<(DateTime createdAt, int fin1MotorHallState, int fin2MotorHallState)> data;
        private Timer timer;
        private int currentIndex = 0; // Index for progressing through data

        public FormGraph(List<(DateTime createdAt, int fin1MotorHallState, int fin2MotorHallState)> data)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(34, 34, 34); // Modern dark background
            this.data = data;
            InitializeCharts();
            CenterCharts();
            InitializeTimer(); // Start timer
        }

        private void InitializeCharts()
        {
            string[] titles = { "AÇI (DERECE)", "HIZ (RPM)", "AKIM", "HALL - STATE" };
            for (int i = 0; i < 4; i++)
            {
                charts[i] = new Chart
                {
                    Size = new Size(500, 300),
                    BackColor = Color.FromArgb(34, 34, 34), // Dark background for chart
                    Padding = new Padding(10)
                };

                charts[i].BorderlineDashStyle = ChartDashStyle.Solid;
                charts[i].BorderlineColor = Color.Gray;
                charts[i].BorderlineWidth = 2;

                ChartArea chartArea = new ChartArea
                {
                    BackColor = Color.FromArgb(50, 50, 50), // Darker background for chart area
                    ShadowColor = Color.FromArgb(80, 80, 80),
                    ShadowOffset = 3,
                    BorderColor = Color.Gray,
                    BorderDashStyle = ChartDashStyle.Solid,
                    CursorX = { IsUserEnabled = true, IsUserSelectionEnabled = true },
                    CursorY = { IsUserEnabled = true, IsUserSelectionEnabled = true }
                };

                // Enhanced axis settings for better visibility
                chartArea.AxisX.Title = "SİSTEM ZAMANI";
                chartArea.AxisY.Title = titles[i];
                chartArea.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartArea.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new Font("Arial", 9, FontStyle.Regular);
                chartArea.AxisY.LabelStyle.Font = new Font("Arial", 9, FontStyle.Regular);
                chartArea.AxisX.LineColor = Color.LightGray;
                chartArea.AxisY.LineColor = Color.LightGray;
                chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
                chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
                chartArea.AxisX.LabelStyle.ForeColor = Color.WhiteSmoke;
                chartArea.AxisY.LabelStyle.ForeColor = Color.WhiteSmoke;
                chartArea.AxisX.TitleForeColor = Color.WhiteSmoke;
                chartArea.AxisY.TitleForeColor = Color.WhiteSmoke;

                charts[i].ChartAreas.Add(chartArea);

                var measuredSeries = new Series
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Cyan, // Bright color for visibility
                    BorderWidth = 3,
                    Name = "Ölçülen"
                };

                charts[i].Series.Add(measuredSeries);

                charts[i].Legends.Add(new Legend
                {
                    Docking = Docking.Top,
                    LegendStyle = LegendStyle.Row,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    ForeColor = Color.WhiteSmoke // Legend text color
                });

                this.Controls.Add(charts[i]);
            }
        }

        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 1000 // Update every second
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < data.Count)
            {
                // Display new data point on the chart
                PlotDataOnGraph(data[currentIndex]);
                currentIndex++;
            }
            else
            {
                timer.Stop(); // Stop timer after displaying all data
            }
        }

        private void PlotDataOnGraph((DateTime createdAt, int fin1MotorHallState, int fin2MotorHallState) item)
        {
            var series = charts[3].Series["Ölçülen"];

            string xValue = item.createdAt.ToString("dd.MM.yy HH:mm:ss");
            double yValue = item.fin1MotorHallState;

            // Add data point to the chart
            series.Points.AddXY(xValue, yValue);

            // Settings for x-axis
            charts[3].Series["Ölçülen"].XValueType = ChartValueType.String;
            charts[3].ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yy\nHH:mm:ss";
            charts[3].ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            charts[3].ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            charts[3].ChartAreas[0].AxisX.Interval = 1;
            charts[3].ChartAreas[0].AxisX.IsMarginVisible = false;
            charts[3].ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            charts[3].ChartAreas[0].AxisX.IsLabelAutoFit = false;
            charts[3].ChartAreas[0].AxisX.Title = "SİSTEM ZAMANI";
            charts[3].ChartAreas[0].AxisX.TitleForeColor = Color.WhiteSmoke;
        }

        private void CenterCharts()
        {
            if (charts[0] == null) return;

            int xPadding = 20;
            int yPadding = 30;
            int columns = 2;
            int rows = 2;

            int totalWidth = columns * charts[0].Width + (columns - 1) * xPadding;
            int totalHeight = rows * charts[0].Height + (rows - 1) * yPadding;

            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            for (int i = 0; i < charts.Length; i++)
            {
                int row = i / columns;
                int col = i % columns;
                charts[i].Location = new Point(startX + col * (charts[i].Width + xPadding), startY + row * (charts[i].Height + yPadding));
            }
        }
    }
}
