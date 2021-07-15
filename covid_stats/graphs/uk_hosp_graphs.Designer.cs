namespace covid_stats.graphs
{
    partial class uk_hosp_graphs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uk_hosp_graphs));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabcntr_uk_hosp = new System.Windows.Forms.TabControl();
            this.tab_num_in_hospital = new System.Windows.Forms.TabPage();
            this.chrt_num_in_hosp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_new_admissions = new System.Windows.Forms.TabPage();
            this.chrt_new_admissions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabcntr_uk_hosp.SuspendLayout();
            this.tab_num_in_hospital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_num_in_hosp)).BeginInit();
            this.tab_new_admissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_new_admissions)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 756);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabcntr_uk_hosp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 750);
            this.panel1.TabIndex = 0;
            // 
            // tabcntr_uk_hosp
            // 
            this.tabcntr_uk_hosp.Controls.Add(this.tab_num_in_hospital);
            this.tabcntr_uk_hosp.Controls.Add(this.tab_new_admissions);
            this.tabcntr_uk_hosp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcntr_uk_hosp.Location = new System.Drawing.Point(0, 0);
            this.tabcntr_uk_hosp.Name = "tabcntr_uk_hosp";
            this.tabcntr_uk_hosp.SelectedIndex = 0;
            this.tabcntr_uk_hosp.Size = new System.Drawing.Size(985, 750);
            this.tabcntr_uk_hosp.TabIndex = 0;
            // 
            // tab_num_in_hospital
            // 
            this.tab_num_in_hospital.Controls.Add(this.chrt_num_in_hosp);
            this.tab_num_in_hospital.Location = new System.Drawing.Point(4, 25);
            this.tab_num_in_hospital.Name = "tab_num_in_hospital";
            this.tab_num_in_hospital.Padding = new System.Windows.Forms.Padding(3);
            this.tab_num_in_hospital.Size = new System.Drawing.Size(977, 721);
            this.tab_num_in_hospital.TabIndex = 0;
            this.tab_num_in_hospital.Text = "Number in Hospital";
            this.tab_num_in_hospital.UseVisualStyleBackColor = true;
            // 
            // chrt_num_in_hosp
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_num_in_hosp.ChartAreas.Add(chartArea1);
            this.chrt_num_in_hosp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrt_num_in_hosp.Legends.Add(legend1);
            this.chrt_num_in_hosp.Location = new System.Drawing.Point(3, 3);
            this.chrt_num_in_hosp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_num_in_hosp.Name = "chrt_num_in_hosp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "NumInHosp";
            series1.YValuesPerPoint = 2;
            this.chrt_num_in_hosp.Series.Add(series1);
            this.chrt_num_in_hosp.Size = new System.Drawing.Size(971, 715);
            this.chrt_num_in_hosp.TabIndex = 2;
            this.chrt_num_in_hosp.Text = "chart1";
            this.chrt_num_in_hosp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_num_in_hosp_MouseMove);
            // 
            // tab_new_admissions
            // 
            this.tab_new_admissions.Controls.Add(this.chrt_new_admissions);
            this.tab_new_admissions.Location = new System.Drawing.Point(4, 25);
            this.tab_new_admissions.Name = "tab_new_admissions";
            this.tab_new_admissions.Padding = new System.Windows.Forms.Padding(3);
            this.tab_new_admissions.Size = new System.Drawing.Size(977, 721);
            this.tab_new_admissions.TabIndex = 1;
            this.tab_new_admissions.Text = "New Admissions";
            this.tab_new_admissions.UseVisualStyleBackColor = true;
            // 
            // chrt_new_admissions
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_new_admissions.ChartAreas.Add(chartArea2);
            this.chrt_new_admissions.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chrt_new_admissions.Legends.Add(legend2);
            this.chrt_new_admissions.Location = new System.Drawing.Point(3, 3);
            this.chrt_new_admissions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt_new_admissions.Name = "chrt_new_admissions";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "NewAdmissions";
            series2.YValuesPerPoint = 2;
            this.chrt_new_admissions.Series.Add(series2);
            this.chrt_new_admissions.Size = new System.Drawing.Size(971, 715);
            this.chrt_new_admissions.TabIndex = 3;
            this.chrt_new_admissions.Text = "chart1";
            this.chrt_new_admissions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_new_admissions_MouseMove);
            // 
            // uk_hosp_graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 756);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uk_hosp_graphs";
            this.Text = "UK Hospital Graphs";
            this.Load += new System.EventHandler(this.uk_hosp_graphs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabcntr_uk_hosp.ResumeLayout(false);
            this.tab_num_in_hospital.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_num_in_hosp)).EndInit();
            this.tab_new_admissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_new_admissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabcntr_uk_hosp;
        private System.Windows.Forms.TabPage tab_num_in_hospital;
        private System.Windows.Forms.TabPage tab_new_admissions;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_num_in_hosp;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrt_new_admissions;
    }
}