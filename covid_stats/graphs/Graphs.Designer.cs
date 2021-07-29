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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tab_graphs = new System.Windows.Forms.TabControl();
            this.tabpage_testing = new System.Windows.Forms.TabPage();
            this.chrt_Daily = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabpage_deaths = new System.Windows.Forms.TabPage();
            this.chrt_deaths = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_casesper100k = new System.Windows.Forms.TabPage();
            this.chrt_cases_100k = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_deaths100k = new System.Windows.Forms.TabPage();
            this.chrt_deaths_100k = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_save_graphs_as_image = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_exit_graphs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Tab_graphs.SuspendLayout();
            this.tabpage_testing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Daily)).BeginInit();
            this.tabpage_deaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths)).BeginInit();
            this.tabPage_casesper100k.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_cases_100k)).BeginInit();
            this.tabPage_deaths100k.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths_100k)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 756);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 756);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tab_graphs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 695);
            this.panel2.TabIndex = 0;
            // 
            // Tab_graphs
            // 
            this.Tab_graphs.Controls.Add(this.tabpage_testing);
            this.Tab_graphs.Controls.Add(this.tabpage_deaths);
            this.Tab_graphs.Controls.Add(this.tabPage_casesper100k);
            this.Tab_graphs.Controls.Add(this.tabPage_deaths100k);
            this.Tab_graphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_graphs.Location = new System.Drawing.Point(0, 0);
            this.Tab_graphs.Name = "Tab_graphs";
            this.Tab_graphs.SelectedIndex = 0;
            this.Tab_graphs.Size = new System.Drawing.Size(985, 695);
            this.Tab_graphs.TabIndex = 6;
            // 
            // tabpage_testing
            // 
            this.tabpage_testing.Controls.Add(this.chrt_Daily);
            this.tabpage_testing.Location = new System.Drawing.Point(4, 25);
            this.tabpage_testing.Name = "tabpage_testing";
            this.tabpage_testing.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_testing.Size = new System.Drawing.Size(977, 666);
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
            this.chrt_Daily.Size = new System.Drawing.Size(964, 679);
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
            this.tabpage_deaths.Size = new System.Drawing.Size(977, 666);
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
            this.chrt_deaths.Size = new System.Drawing.Size(967, 656);
            this.chrt_deaths.TabIndex = 3;
            this.chrt_deaths.Text = "chart2";
            this.chrt_deaths.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_deaths_MouseMove);
            // 
            // tabPage_casesper100k
            // 
            this.tabPage_casesper100k.Controls.Add(this.chrt_cases_100k);
            this.tabPage_casesper100k.Location = new System.Drawing.Point(4, 25);
            this.tabPage_casesper100k.Name = "tabPage_casesper100k";
            this.tabPage_casesper100k.Size = new System.Drawing.Size(977, 666);
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
            this.chrt_cases_100k.Size = new System.Drawing.Size(964, 679);
            this.chrt_cases_100k.TabIndex = 2;
            this.chrt_cases_100k.Text = "chart1";
            this.chrt_cases_100k.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_cases_100k_MouseMove);
            // 
            // tabPage_deaths100k
            // 
            this.tabPage_deaths100k.Controls.Add(this.chrt_deaths_100k);
            this.tabPage_deaths100k.Location = new System.Drawing.Point(4, 25);
            this.tabPage_deaths100k.Name = "tabPage_deaths100k";
            this.tabPage_deaths100k.Size = new System.Drawing.Size(977, 666);
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
            this.chrt_deaths_100k.Size = new System.Drawing.Size(964, 679);
            this.chrt_deaths_100k.TabIndex = 3;
            this.chrt_deaths_100k.Text = "chart1";
            this.chrt_deaths_100k.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_deaths_100k_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 704);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 49);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(985, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_save_graphs_as_image);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 43);
            this.panel4.TabIndex = 0;
            // 
            // btn_save_graphs_as_image
            // 
            this.btn_save_graphs_as_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_graphs_as_image.Location = new System.Drawing.Point(162, 1);
            this.btn_save_graphs_as_image.Name = "btn_save_graphs_as_image";
            this.btn_save_graphs_as_image.Size = new System.Drawing.Size(163, 40);
            this.btn_save_graphs_as_image.TabIndex = 1;
            this.btn_save_graphs_as_image.Text = "Save as Image";
            this.btn_save_graphs_as_image.UseVisualStyleBackColor = true;
            this.btn_save_graphs_as_image.Click += new System.EventHandler(this.btn_save_graphs_as_image_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_exit_graphs);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(495, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(487, 43);
            this.panel5.TabIndex = 1;
            // 
            // btn_exit_graphs
            // 
            this.btn_exit_graphs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit_graphs.Location = new System.Drawing.Point(192, 1);
            this.btn_exit_graphs.Name = "btn_exit_graphs";
            this.btn_exit_graphs.Size = new System.Drawing.Size(102, 40);
            this.btn_exit_graphs.TabIndex = 0;
            this.btn_exit_graphs.Text = "Exit";
            this.btn_exit_graphs.UseVisualStyleBackColor = true;
            this.btn_exit_graphs.Click += new System.EventHandler(this.btn_exit_graphs_Click);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Tab_graphs.ResumeLayout(false);
            this.tabpage_testing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Daily)).EndInit();
            this.tabpage_deaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths)).EndInit();
            this.tabPage_casesper100k.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_cases_100k)).EndInit();
            this.tabPage_deaths100k.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_deaths_100k)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_save_graphs_as_image;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_exit_graphs;
    }
}