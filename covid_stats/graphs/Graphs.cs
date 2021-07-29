using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace covid_stats.graphs
{
    public partial class Graphs : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        public Graphs()
        {
            InitializeComponent();
        }

        private void btn_graph_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            chrt_Daily.Series["Daily"].ChartType = SeriesChartType.FastLine; //set type
            chrt_Daily.Series["Daily"].Color = Color.Blue; //set colour
            chrt_Daily.Legends.Clear(); // We do not need a legend
            chrt_Daily.ChartAreas[0].AxisX.IsMarginVisible = false;
            
            Series series_daily = chrt_Daily.Series.Add("");
            ChartArea ca_daily = chrt_Daily.ChartAreas[series_daily.ChartArea]; // get hold of chart
            
            // enable autoscroll
            ca_daily.AxisX.ScaleView.Zoomable = true;
            ca_daily.CursorX.AutoScroll = true;
            ca_daily.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_daily.AxisX.ScaleView.SmallScrollSize = 100;
            

            chrt_deaths.Series["Deaths"].ChartType = SeriesChartType.FastLine; //set type
            chrt_deaths.Series["Deaths"].Color = Color.Red; //set colour
            chrt_deaths.Legends.Clear(); // We do not need a legend
            chrt_deaths.ChartAreas[0].AxisX.IsMarginVisible = false;
            
            Series series_deaths = chrt_deaths.Series.Add("");
            ChartArea ca_deaths = chrt_deaths.ChartAreas[series_deaths.ChartArea]; // get hold of chart
            
            // enable autoscroll
            ca_deaths.AxisX.ScaleView.Zoomable = true;
            ca_deaths.CursorX.AutoScroll = true;
            ca_deaths.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_deaths.AxisX.ScaleView.SmallScrollSize = 100;

            
            

            chrt_cases_100k.Series["cases_100k"].ChartType = SeriesChartType.FastLine; //set type
            chrt_cases_100k.Series["cases_100k"].Color = Color.DarkOrange; //set colour
            chrt_cases_100k.Legends.Clear(); // We do not need a legend
            chrt_cases_100k.ChartAreas[0].AxisX.IsMarginVisible = false;

            chrt_deaths_100k.Series["deaths_100k"].ChartType = SeriesChartType.FastLine; //set type
            chrt_deaths_100k.Series["deaths_100k"].Color = Color.DarkGreen; //set colour
            chrt_deaths_100k.Legends.Clear(); // We do not need a legend
            chrt_deaths_100k.ChartAreas[0].AxisX.IsMarginVisible = false;

        }

        private void chrt_Daily_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_Daily.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_Daily, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_deaths_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_deaths.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_deaths, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_deaths_100k_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_deaths.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_deaths, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_cases_100k_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_deaths.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_deaths, pos.X, pos.Y - 15);
                }
            }
        }

        private void btn_exit_graphs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_graphs_as_image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files|*.png|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            saveFileDialog.Title = "Save Chart Image As file";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.FileName = "Sample.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {

                    var imgFormats = new Dictionary<string, ChartImageFormat>()
                    {
                        {".bmp", ChartImageFormat.Bmp},
                        {".gif", ChartImageFormat.Gif},
                        {".jpg", ChartImageFormat.Jpeg},
                        {".jpeg", ChartImageFormat.Jpeg},
                        {".png", ChartImageFormat.Png},
                        {".tiff", ChartImageFormat.Tiff},
                    };
                    var fileExt = System.IO.Path.GetExtension(saveFileDialog.FileName).ToString().ToLower();

                    if (imgFormats.ContainsKey(fileExt))
                    {
                        if (Tab_graphs.SelectedTab.Name == "tabpage_testing")
                        {
                            chrt_Daily.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if (Tab_graphs.SelectedTab.Name == "tabpage_deaths")
                        {
                            chrt_deaths.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if (Tab_graphs.SelectedTab.Name == "tabPage_casesper100k")
                        {
                            chrt_cases_100k.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if (Tab_graphs.SelectedTab.Name == "tabPage_deaths100k")
                        {
                            chrt_deaths_100k.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                    }
                    else
                    {
                        throw new Exception(String.Format("Only image formats '{0}' supported", string.Join(", ", imgFormats.Keys)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
