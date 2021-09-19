using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace covid_stats.graphs
{
    public partial class vaccine_graphs : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        Bitmap MemoryImage;

        public vaccine_graphs()
        {
            InitializeComponent();
        }


        private void vaccine_graphs_Load(object sender, EventArgs e)
        {
            
            
            chrt_world_vac_info.Legends.Clear(); // We do not need a legend
            chrt_world_vac_info.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_world_vac_info.Titles.Add("World Vaccinations");
            chrt_world_vac_info.Series["World"].ChartType = SeriesChartType.FastLine; //set type
            chrt_world_vac_info.Series["World"].Color = Color.Indigo; //set colour
            chrt_world_vac_info.Series["World_fully"].Color = Color.Orange; //set colour
            chrt_world_vac_info.Series["World_Boost"].Color = Color.Orchid; //set colour
            
            chrt_england_vac.Legends.Clear(); // We do not need a legend
            chrt_england_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_england_vac.Titles.Add("England Vaccinations");
            chrt_england_vac.Series["England"].ChartType = SeriesChartType.FastLine; //set type
            chrt_england_vac.Series["England"].Color = Color.Black; //set colour
            chrt_england_vac.Series["England_fully"].Color = Color.DimGray; //set colour
            chrt_england_vac.Series["England_Boost"].Color = Color.LightGray; //set colour

            chrt_scotland_vac.Legends.Clear(); // We do not need a legend
            chrt_scotland_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_scotland_vac.Titles.Add("Scotland Vaccinations");
            chrt_scotland_vac.Series["Scotland"].ChartType = SeriesChartType.FastLine; //set type
            chrt_scotland_vac.Series["Scotland"].Color = Color.BlueViolet; //set colour
            chrt_scotland_vac.Series["Scotland_fully"].Color = Color.Violet; //set colour
            chrt_scotland_vac.Series["Scotland_Boost"].Color = Color.PaleVioletRed; //set colour

            chrt_n_ireland_vac.Legends.Clear(); // We do not need a legend
            chrt_n_ireland_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_n_ireland_vac.Titles.Add("N. Ireland Vaccinations");
            chrt_n_ireland_vac.Series["N. Ireland"].ChartType = SeriesChartType.FastLine; //set type
            chrt_n_ireland_vac.Series["N. Ireland"].Color = Color.Green; //set colour
            chrt_n_ireland_vac.Series["N. Ireland_fully"].Color = Color.DarkSeaGreen; //set colour
            chrt_n_ireland_vac.Series["N.Ireland_Boost"].Color = Color.ForestGreen; //set colour

            chrt_wales_vac.Legends.Clear(); // We do not need a legend
            chrt_wales_vac.ChartAreas[0].AxisX.IsMarginVisible = false;
            chrt_wales_vac.Titles.Add("Wales Vaccinations");
            chrt_wales_vac.Series["Wales"].ChartType = SeriesChartType.FastLine; //set type
            chrt_wales_vac.Series["Wales"].Color = Color.Red; //set colour
            chrt_wales_vac.Series["Wales_fully"].Color = Color.PaleVioletRed; //set colour
            chrt_wales_vac.Series["Wales_Boost"].Color = Color.MediumVioletRed; //set colour

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

        private void btn_vaccinegraphs_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_vaccinegraph_as_image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "Image Files|*.png|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            saveFileDialog.Title = "Save Chart Image As file";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.FileName = "Sample.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {

                    var imgFormats = new Dictionary<string, ImageFormat>()
                    {
                        {".bmp", ImageFormat.Bmp},
                        {".gif", ImageFormat.Gif},
                        {".jpg", ImageFormat.Jpeg},
                        {".jpeg", ImageFormat.Jpeg},
                        {".png", ImageFormat.Png},
                        {".tiff", ImageFormat.Tiff},
                    };
                    var fileExt = System.IO.Path.GetExtension(saveFileDialog.FileName).ToString().ToLower();
                    if (imgFormats.ContainsKey(fileExt))
                    {
                        int width = pnl_vac_graph.Size.Width;
                        int height = pnl_vac_graph.Size.Height;

                        Bitmap bm = new Bitmap(width, height);
                        pnl_vac_graph.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

                        bm.Save(saveFileDialog.FileName, imgFormats[fileExt]);


                    }
                    else
                    {
                        throw new Exception(String.Format("Only image formats '{0}' supported",
                            string.Join(", ", imgFormats.Keys)));
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
