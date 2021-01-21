using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace covid_stats.graphs
{
    public partial class MultiGraphs : Form
    {
        

        public MultiGraphs()
        {
            InitializeComponent();
        }

        

        private void MultiGraphs_Load(object sender, EventArgs e)
        {
            chrt_multi_cases_100k.Series["cases_100k"].ChartType = SeriesChartType.FastLine; //set type
            chrt_multi_cases_100k.Series["country1_cases_100k"].Color = Color.Red; //set colour
            chrt_multi_cases_100k.Series["country2_cases_100k"].Color = Color.Blue; //set colour
            chrt_multi_cases_100k.Series["country3_cases_100k"].Color = Color.DarkOrange; //set colour
            chrt_multi_cases_100k.Series["country4_cases_100k"].Color = Color.GreenYellow; //set colour
            chrt_multi_cases_100k.Legends.Clear(); // We do not need a legend
            chrt_multi_cases_100k.ChartAreas[0].AxisX.IsMarginVisible = false;

            chrt_multi_deaths_100k.Series["deaths_100k"].ChartType = SeriesChartType.FastLine; //set type
            chrt_multi_deaths_100k.Series["country1_deaths_100k"].Color = Color.Red; //set colour
            chrt_multi_deaths_100k.Series["country2_deaths_100k"].Color = Color.Blue; //set colour
            chrt_multi_deaths_100k.Series["country3_deaths_100k"].Color = Color.DarkOrange; //set colour
            chrt_multi_deaths_100k.Series["country4_deaths_100k"].Color = Color.GreenYellow; //set colour
            chrt_multi_deaths_100k.Legends.Clear(); // We do not need a legend
            chrt_multi_deaths_100k.ChartAreas[0].AxisX.IsMarginVisible = false;

        }

        private void MultiGraphs_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
