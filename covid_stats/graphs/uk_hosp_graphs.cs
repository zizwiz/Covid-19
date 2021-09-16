using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace covid_stats.graphs
{
    public partial class uk_hosp_graphs : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();


        public uk_hosp_graphs()
        {
            InitializeComponent();
        }

        private void uk_hosp_graphs_Load(object sender, System.EventArgs e)
        {
            chrt_num_in_hosp.Series["NumInHosp"].ChartType = SeriesChartType.FastLine; //set type
            chrt_num_in_hosp.Series["NumInHosp"].Color = Color.Blue; //set colour
            chrt_num_in_hosp.Legends.Clear(); // We do not need a legend
            chrt_num_in_hosp.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_NumInHosp = chrt_num_in_hosp.Series.Add("");
            ChartArea ca_NumInHosp = chrt_num_in_hosp.ChartAreas[series_NumInHosp.ChartArea]; // get hold of chart

            // enable autoscroll
            ca_NumInHosp.AxisX.ScaleView.Zoomable = true;
            ca_NumInHosp.CursorX.AutoScroll = true;
            ca_NumInHosp.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_NumInHosp.AxisX.ScaleView.SmallScrollSize = 100;



            chrt_new_admissions.Series["NewAdmissions"].ChartType = SeriesChartType.FastLine; //set type
            chrt_new_admissions.Series["NewAdmissions"].Color = Color.Blue; //set colour
            chrt_new_admissions.Legends.Clear(); // We do not need a legend
            chrt_new_admissions.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_NewAdmissions = chrt_new_admissions.Series.Add("");
            ChartArea ca_NewAdmissions = chrt_new_admissions.ChartAreas[series_NewAdmissions.ChartArea]; // get hold of chart

            // enable autoscroll
            ca_NewAdmissions.AxisX.ScaleView.Zoomable = true;
            ca_NewAdmissions.CursorX.AutoScroll = true;
            ca_NewAdmissions.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_NewAdmissions.AxisX.ScaleView.SmallScrollSize = 100;

            chrt_net_gain.Series["NetGain"].ChartType = SeriesChartType.FastLine; //set type
            chrt_net_gain.Series["NetGain"].Color = Color.Green; //set colour
            chrt_net_gain.Legends.Clear(); // We do not need a legend
            chrt_net_gain.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_NetGain = chrt_net_gain.Series.Add("");
            ChartArea ca_NetGain = chrt_net_gain.ChartAreas[series_NetGain.ChartArea]; // get hold of chart

            // enable autoscroll
            ca_NetGain.AxisX.ScaleView.Zoomable = true;
            ca_NetGain.CursorX.AutoScroll = true;
            ca_NetGain.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_NetGain.AxisX.ScaleView.SmallScrollSize = 100;


        }

        private void chrt_new_admissions_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_new_admissions.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_new_admissions, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_num_in_hosp_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_num_in_hosp.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_num_in_hosp, pos.X, pos.Y - 15);
                }
            }
        }

        private void chrt_net_gain_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chrt_net_gain.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); 
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chrt_net_gain, pos.X, pos.Y - 15);
                }
            }
        }
        
        private void btn_exit_hosp_graph_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn_save_hospt_graph_as_image_Click(object sender, System.EventArgs e)
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
                        if (tabcntr_uk_hosp.SelectedTab.Name == "tab_num_in_hospital")
                        {
                            chrt_num_in_hosp.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if (tabcntr_uk_hosp.SelectedTab.Name == "tab_new_admissions")
                        {
                            chrt_new_admissions.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
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
