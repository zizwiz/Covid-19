namespace covid_stats.graphs
{
    partial class MultiGraphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
         private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiGraphs));
            this.Tab_multi_graphs = new System.Windows.Forms.TabControl();
            this.tabPage_casesper100k = new System.Windows.Forms.TabPage();
            this.chrt_multi_cases_100k = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_deaths100k = new System.Windows.Forms.TabPage();
            this.chrt_multi_deaths_100k = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tab_multi_graphs.SuspendLayout();
            this.tabPage_casesper100k.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_multi_cases_100k)).BeginInit();
            this.tabPage_deaths100k.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_multi_deaths_100k)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_multi_graphs
            // 
            this.Tab_multi_graphs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_multi_graphs.Controls.Add(this.tabPage_casesper100k);
            this.Tab_multi_graphs.Controls.Add(this.tabPage_deaths100k);
            this.Tab_multi_graphs.Location = new System.Drawing.Point(2, 5);
            this.Tab_multi_graphs.Name = "Tab_multi_graphs";
            this.Tab_multi_graphs.SelectedIndex = 0;
            this.Tab_multi_graphs.Size = new System.Drawing.Size(986, 747);
            this.Tab_multi_graphs.TabIndex = 7;
            // 
            // tabPage_casesper100k
            // 
            this.tabPage_casesper100k.Controls.Add(this.chrt_multi_cases_100k);
            this.tabPage_casesper100k.Location = new System.Drawing.Point(4, 25);
            this.tabPage_casesper100k.Name = "tabPage_casesper100k";
            this.tabPage_casesper100k.Size = new System.Drawing.Size(978, 718);
            this.tabPage_casesper100k.TabIndex = 2;
            this.tabPage_casesper100k.Text = "Cases per 100k";
            this.tabPage_casesper100k.UseVisualStyleBackColor = true;
            // 
            // chrt_multi_cases_100k
            // 
            this.chrt_multi_cases_100k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrt_multi_cases_100k.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_multi_cases_100k.Legends.Add(legend1);
            this.chrt_multi_cases_100k.Location = new System.Drawing.Point(7, -6);
            this.chrt_multi_cases_100k.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_multi_cases_100k.Name = "chrt_multi_cases_100k";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "country1_cases_100k";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "country2_cases_100k";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "country3_cases_100k";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "country4_cases_100k";
            this.chrt_multi_cases_100k.Series.Add(series1);
            this.chrt_multi_cases_100k.Series.Add(series2);
            this.chrt_multi_cases_100k.Series.Add(series3);
            this.chrt_multi_cases_100k.Series.Add(series4);
            this.chrt_multi_cases_100k.Size = new System.Drawing.Size(965, 731);
            this.chrt_multi_cases_100k.TabIndex = 2;
            this.chrt_multi_cases_100k.Text = "chart1";
            // 
            // tabPage_deaths100k
            // 
            this.tabPage_deaths100k.Controls.Add(this.chrt_multi_deaths_100k);
            this.tabPage_deaths100k.Location = new System.Drawing.Point(4, 25);
            this.tabPage_deaths100k.Name = "tabPage_deaths100k";
            this.tabPage_deaths100k.Size = new System.Drawing.Size(978, 718);
            this.tabPage_deaths100k.TabIndex = 3;
            this.tabPage_deaths100k.Text = "Deaths per 100k";
            this.tabPage_deaths100k.UseVisualStyleBackColor = true;
            // 
            // chrt_multi_deaths_100k
            // 
            this.chrt_multi_deaths_100k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chrt_multi_deaths_100k.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_multi_deaths_100k.Legends.Add(legend2);
            this.chrt_multi_deaths_100k.Location = new System.Drawing.Point(7, -6);
            this.chrt_multi_deaths_100k.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_multi_deaths_100k.Name = "chrt_multi_deaths_100k";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "country1_deaths_100k";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "country2_deaths_100k";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "country3_deaths_100k";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "country4_deaths_100k";
            this.chrt_multi_deaths_100k.Series.Add(series5);
            this.chrt_multi_deaths_100k.Series.Add(series6);
            this.chrt_multi_deaths_100k.Series.Add(series7);
            this.chrt_multi_deaths_100k.Series.Add(series8);
            this.chrt_multi_deaths_100k.Size = new System.Drawing.Size(965, 731);
            this.chrt_multi_deaths_100k.TabIndex = 3;
            this.chrt_multi_deaths_100k.Text = "chart1";
            // 
            // MultiGraphs
            // 
            this.ClientSize = new System.Drawing.Size(991, 756);
            this.Controls.Add(this.Tab_multi_graphs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiGraphs";
            this.Text = "Multi-Country Graphs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiGraphs_FormClosing);
            this.Load += new System.EventHandler(this.MultiGraphs_Load);
            this.Tab_multi_graphs.ResumeLayout(false);
            this.tabPage_casesper100k.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_multi_cases_100k)).EndInit();
            this.tabPage_deaths100k.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_multi_deaths_100k)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        		
		private System.Windows.Forms.TabControl Tab_multi_graphs;
        private System.Windows.Forms.TabPage tabPage_casesper100k;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_multi_cases_100k;
        private System.Windows.Forms.TabPage tabPage_deaths100k;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_multi_deaths_100k;
    }
}