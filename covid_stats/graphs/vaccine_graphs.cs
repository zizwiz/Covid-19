using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace covid_stats.graphs
{
    public partial class vaccine_graphs : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        public vaccine_graphs()
        {
            InitializeComponent();
        }


        private void vaccine_graphs_Load(object sender, EventArgs e)
        {
            
            
            chrt_england_vac.Legends.Clear(); // We do not need a legend
            chrt_england_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_england_vac.Titles.Add("England Vaccinations");
            chrt_england_vac.Series["England"].ChartType = SeriesChartType.FastLine; //set type
            chrt_england_vac.Series["England"].Color = Color.Black; //set colour
            chrt_england_vac.Series["England_fully"].Color = Color.DimGray; //set colour

            chrt_scotland_vac.Legends.Clear(); // We do not need a legend
            chrt_scotland_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_scotland_vac.Titles.Add("Scotland Vaccinations");
            chrt_scotland_vac.Series["Scotland"].ChartType = SeriesChartType.FastLine; //set type
            chrt_scotland_vac.Series["Scotland"].Color = Color.BlueViolet; //set colour
            chrt_scotland_vac.Series["Scotland_fully"].Color = Color.Violet; //set colour

            chrt_n_ireland_vac.Legends.Clear(); // We do not need a legend
            chrt_n_ireland_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_n_ireland_vac.Titles.Add("N. Ireland Vaccinations");
            chrt_n_ireland_vac.Series["N. Ireland"].ChartType = SeriesChartType.FastLine; //set type
            chrt_n_ireland_vac.Series["N. Ireland"].Color = Color.Green; //set colour
            chrt_n_ireland_vac.Series["N. Ireland_fully"].Color = Color.DarkSeaGreen; //set colour

            chrt_wales_vac.Legends.Clear(); // We do not need a legend
            chrt_wales_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_wales_vac.Titles.Add("Wales Vaccinations");
            chrt_wales_vac.Series["Wales"].ChartType = SeriesChartType.FastLine; //set type
            chrt_wales_vac.Series["Wales"].Color = Color.Red; //set colour
            chrt_wales_vac.Series["Wales_fully"].Color = Color.PaleVioletRed; //set colour


        }

        private void chrt_combined_uk_vac_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_england_vac.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_england_vac, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_scotland_vac_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_england_vac.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_scotland_vac, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_wales_vac_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_england_vac.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_wales_vac, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_n_ireland_vac_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_england_vac.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_n_ireland_vac, pos.X, pos.Y - 15);
                }
            }
        }
    }
}
