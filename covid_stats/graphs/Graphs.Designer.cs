namespace covid_stats.graphs
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tab_graphs = new System.Windows.Forms.TabControl();
            this.tabpage_testing = new System.Windows.Forms.TabPage();
            this.chrt_Daily = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabpage_deaths = new System.Windows.Forms.TabPage();
            this.chrt_deaths = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_casesper100k = new System.Windows.Forms.TabPage();
            this.chrt_cases_100k = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_deaths100k = new System.Windows.Forms.TabPage();
            this.chrt_deaths_100k = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.Tab_graphs.SuspendLayout();
            this.tabpage_testing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Daily)).BeginInit();
            this.tabpage_deaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths)).BeginInit();
            this.tabPage_casesper100k.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_cases_100k)).BeginInit();
            this.tabPage_deaths100k.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths_100k)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tab_graphs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 756);
            this.panel1.TabIndex = 1;
            // 
            // Tab_graphs
            // 
            this.Tab_graphs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_graphs.Controls.Add(this.tabpage_testing);
            this.Tab_graphs.Controls.Add(this.tabpage_deaths);
            this.Tab_graphs.Controls.Add(this.tabPage_casesper100k);
            this.Tab_graphs.Controls.Add(this.tabPage_deaths100k);
            this.Tab_graphs.Location = new System.Drawing.Point(4, 6);
            this.Tab_graphs.Name = "Tab_graphs";
            this.Tab_graphs.SelectedIndex = 0;
            this.Tab_graphs.Size = new System.Drawing.Size(986, 747);
            this.Tab_graphs.TabIndex = 6;
            // 
            // tabpage_testing
            // 
            this.tabpage_testing.Controls.Add(this.chrt_Daily);
            this.tabpage_testing.Location = new System.Drawing.Point(4, 25);
            this.tabpage_testing.Name = "tabpage_testing";
            this.tabpage_testing.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_testing.Size = new System.Drawing.Size(978, 718);
            this.tabpage_testing.TabIndex = 0;
            this.tabpage_testing.Text = "Daily Confirmed Cases by Testing";
            this.tabpage_testing.UseVisualStyleBackColor = true;
            // 
            // chrt_Daily
            // 
            this.chrt_Daily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrt_Daily.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_Daily.Legends.Add(legend1);
            this.chrt_Daily.Location = new System.Drawing.Point(6, 5);
            this.chrt_Daily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_Daily.Name = "chrt_Daily";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Daily";
            series1.YValuesPerPoint = 2;
            this.chrt_Daily.Series.Add(series1);
            this.chrt_Daily.Size = new System.Drawing.Size(965, 731);
            this.chrt_Daily.TabIndex = 1;
            this.chrt_Daily.Text = "chart1";
            this.chrt_Daily.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_Daily_MouseMove);
            // 
            // tabpage_deaths
            // 
            this.tabpage_deaths.Controls.Add(this.chrt_deaths);
            this.tabpage_deaths.Location = new System.Drawing.Point(4, 25);
            this.tabpage_deaths.Name = "tabpage_deaths";
            this.tabpage_deaths.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_deaths.Size = new System.Drawing.Size(978, 718);
            this.tabpage_deaths.TabIndex = 1;
            this.tabpage_deaths.Text = "Hospital Deaths";
            this.tabpage_deaths.UseVisualStyleBackColor = true;
            // 
            // chrt_deaths
            // 
            this.chrt_deaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chrt_deaths.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_deaths.Legends.Add(legend2);
            this.chrt_deaths.Location = new System.Drawing.Point(3, 5);
            this.chrt_deaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_deaths.Name = "chrt_deaths";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Deaths";
            this.chrt_deaths.Series.Add(series2);
            this.chrt_deaths.Size = new System.Drawing.Size(968, 708);
            this.chrt_deaths.TabIndex = 3;
            this.chrt_deaths.Text = "chart2";
            this.chrt_deaths.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_deaths_MouseMove);
            // 
            // tabPage_casesper100k
            // 
            this.tabPage_casesper100k.Controls.Add(this.chrt_cases_100k);
            this.tabPage_casesper100k.Location = new System.Drawing.Point(4, 25);
            this.tabPage_casesper100k.Name = "tabPage_casesper100k";
            this.tabPage_casesper100k.Size = new System.Drawing.Size(978, 718);
            this.tabPage_casesper100k.TabIndex = 2;
            this.tabPage_casesper100k.Text = "Cases per 100k";
            this.tabPage_casesper100k.UseVisualStyleBackColor = true;
            // 
            // chrt_cases_100k
            // 
            this.chrt_cases_100k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chrt_cases_100k.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrt_cases_100k.Legends.Add(legend3);
            this.chrt_cases_100k.Location = new System.Drawing.Point(7, -6);
            this.chrt_cases_100k.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_cases_100k.Name = "chrt_cases_100k";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "cases_100k";
            series3.YValuesPerPoint = 2;
            this.chrt_cases_100k.Series.Add(series3);
            this.chrt_cases_100k.Size = new System.Drawing.Size(965, 731);
            this.chrt_cases_100k.TabIndex = 2;
            this.chrt_cases_100k.Text = "chart1";
            this.chrt_cases_100k.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_cases_100k_MouseMove);
            // 
            // tabPage_deaths100k
            // 
            this.tabPage_deaths100k.Controls.Add(this.chrt_deaths_100k);
            this.tabPage_deaths100k.Location = new System.Drawing.Point(4, 25);
            this.tabPage_deaths100k.Name = "tabPage_deaths100k";
            this.tabPage_deaths100k.Size = new System.Drawing.Size(978, 718);
            this.tabPage_deaths100k.TabIndex = 3;
            this.tabPage_deaths100k.Text = "Deaths per 100k";
            this.tabPage_deaths100k.UseVisualStyleBackColor = true;
            // 
            // chrt_deaths_100k
            // 
            this.chrt_deaths_100k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chrt_deaths_100k.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrt_deaths_100k.Legends.Add(legend4);
            this.chrt_deaths_100k.Location = new System.Drawing.Point(7, -6);
            this.chrt_deaths_100k.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_deaths_100k.Name = "chrt_deaths_100k";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "deaths_100k";
            series4.YValuesPerPoint = 2;
            this.chrt_deaths_100k.Series.Add(series4);
            this.chrt_deaths_100k.Size = new System.Drawing.Size(965, 731);
            this.chrt_deaths_100k.TabIndex = 3;
            this.chrt_deaths_100k.Text = "chart1";
            this.chrt_deaths_100k.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_deaths_100k_MouseMove);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 756);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Graphs";
            this.Text = "Covid-19 Graphs";
            this.Load += new System.EventHandler(this.Graphs_Load);
            this.panel1.ResumeLayout(false);
            this.Tab_graphs.ResumeLayout(false);
            this.tabpage_testing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Daily)).EndInit();
            this.tabpage_deaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths)).EndInit();
            this.tabPage_casesper100k.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_cases_100k)).EndInit();
            this.tabPage_deaths100k.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths_100k)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_Daily;
        private System.Windows.Forms.TabControl Tab_graphs;
        private System.Windows.Forms.TabPage tabpage_testing;
        private System.Windows.Forms.TabPage tabpage_deaths;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_deaths;
        private System.Windows.Forms.TabPage tabPage_casesper100k;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_cases_100k;
        private System.Windows.Forms.TabPage tabPage_deaths100k;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_deaths_100k;
    }
}