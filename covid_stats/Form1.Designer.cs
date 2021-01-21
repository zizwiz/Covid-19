namespace covid_stats
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabcontrol_covid19 = new System.Windows.Forms.TabControl();
            this.tab_world_stats = new System.Windows.Forms.TabPage();
            this.lbl_global_deaths_percentage = new System.Windows.Forms.Label();
            this.lbl_global_cases_percentage = new System.Windows.Forms.Label();
            this.lbl_global_deaths_total = new System.Windows.Forms.Label();
            this.lbl_global_cases_total = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_world_stats_deaths = new System.Windows.Forms.DataGridView();
            this.dgv_world_stats_cases = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_update_who_stats = new System.Windows.Forms.Button();
            this.tab_country_stats = new System.Windows.Forms.TabPage();
            this.btn_get_data = new System.Windows.Forms.Button();
            this.btn_graphs = new System.Windows.Forms.Button();
            this.dgvValues = new System.Windows.Forms.DataGridView();
            this.tab_vaccinations = new System.Windows.Forms.TabPage();
            this.btn_get_vac_data = new System.Windows.Forms.Button();
            this.btn_vac_graphs = new System.Windows.Forms.Button();
            this.tabcntrol_vaccination = new System.Windows.Forms.TabControl();
            this.tab_world = new System.Windows.Forms.TabPage();
            this.dgv_vac_world = new System.Windows.Forms.DataGridView();
            this.tab_uk = new System.Windows.Forms.TabPage();
            this.dgv_vac_uk = new System.Windows.Forms.DataGridView();
            this.tab_england = new System.Windows.Forms.TabPage();
            this.dgv_vac_england = new System.Windows.Forms.DataGridView();
            this.tab_scotland = new System.Windows.Forms.TabPage();
            this.dgv_vac_scotland = new System.Windows.Forms.DataGridView();
            this.tab_n_ireland = new System.Windows.Forms.TabPage();
            this.dgv_vac_n_ireland = new System.Windows.Forms.DataGridView();
            this.tab_wales = new System.Windows.Forms.TabPage();
            this.dgv_vac_wales = new System.Windows.Forms.DataGridView();
            this.tab_world_vac = new System.Windows.Forms.TabPage();
            this.btn_unverified_help = new System.Windows.Forms.Button();
            this.btn_update_unverified_world_vac = new System.Windows.Forms.Button();
            this.dgv_vac_world_unverified = new System.Windows.Forms.DataGridView();
            this.tab_citations = new System.Windows.Forms.TabPage();
            this.lbl_vacinations_citation = new System.Windows.Forms.Label();
            this.lbl_country_stats_citation = new System.Windows.Forms.Label();
            this.lbl_who_citation = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.cmbobox_country = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_who_countries = new System.Windows.Forms.Label();
            this.cmbobox_who_country = new System.Windows.Forms.ComboBox();
            this.btn_who_find = new System.Windows.Forms.Button();
            this.btn_who_reset = new System.Windows.Forms.Button();
            this.cmbobx_world_vac = new System.Windows.Forms.ComboBox();
            this.btn_show_world_vac_data = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.tabcontrol_covid19.SuspendLayout();
            this.tab_world_stats.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_world_stats_deaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_world_stats_cases)).BeginInit();
            this.tab_country_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).BeginInit();
            this.tab_vaccinations.SuspendLayout();
            this.tabcntrol_vaccination.SuspendLayout();
            this.tab_world.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_world)).BeginInit();
            this.tab_uk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_uk)).BeginInit();
            this.tab_england.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_england)).BeginInit();
            this.tab_scotland.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_scotland)).BeginInit();
            this.tab_n_ireland.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_n_ireland)).BeginInit();
            this.tab_wales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_wales)).BeginInit();
            this.tab_world_vac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_world_unverified)).BeginInit();
            this.tab_citations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol_covid19
            // 
            this.tabcontrol_covid19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrol_covid19.Controls.Add(this.tab_world_stats);
            this.tabcontrol_covid19.Controls.Add(this.tab_country_stats);
            this.tabcontrol_covid19.Controls.Add(this.tab_vaccinations);
            this.tabcontrol_covid19.Controls.Add(this.tab_world_vac);
            this.tabcontrol_covid19.Controls.Add(this.tab_citations);
            this.tabcontrol_covid19.Location = new System.Drawing.Point(15, 7);
            this.tabcontrol_covid19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcontrol_covid19.Name = "tabcontrol_covid19";
            this.tabcontrol_covid19.SelectedIndex = 0;
            this.tabcontrol_covid19.Size = new System.Drawing.Size(684, 390);
            this.tabcontrol_covid19.TabIndex = 1;
            this.tabcontrol_covid19.SelectedIndexChanged += new System.EventHandler(this.tabcontrol_covid19_SelectedIndexChanged);
            // 
            // tab_world_stats
            // 
            this.tab_world_stats.Controls.Add(this.lbl_global_deaths_percentage);
            this.tab_world_stats.Controls.Add(this.lbl_global_cases_percentage);
            this.tab_world_stats.Controls.Add(this.lbl_global_deaths_total);
            this.tab_world_stats.Controls.Add(this.lbl_global_cases_total);
            this.tab_world_stats.Controls.Add(this.tableLayoutPanel1);
            this.tab_world_stats.Controls.Add(this.btn_update_who_stats);
            this.tab_world_stats.Location = new System.Drawing.Point(4, 25);
            this.tab_world_stats.Name = "tab_world_stats";
            this.tab_world_stats.Size = new System.Drawing.Size(676, 361);
            this.tab_world_stats.TabIndex = 2;
            this.tab_world_stats.Text = "WHO World Stats";
            this.tab_world_stats.UseVisualStyleBackColor = true;
            // 
            // lbl_global_deaths_percentage
            // 
            this.lbl_global_deaths_percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_global_deaths_percentage.AutoSize = true;
            this.lbl_global_deaths_percentage.Location = new System.Drawing.Point(275, 341);
            this.lbl_global_deaths_percentage.Name = "lbl_global_deaths_percentage";
            this.lbl_global_deaths_percentage.Size = new System.Drawing.Size(20, 17);
            this.lbl_global_deaths_percentage.TabIndex = 16;
            this.lbl_global_deaths_percentage.Text = "...";
            // 
            // lbl_global_cases_percentage
            // 
            this.lbl_global_cases_percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_global_cases_percentage.AutoSize = true;
            this.lbl_global_cases_percentage.Location = new System.Drawing.Point(275, 318);
            this.lbl_global_cases_percentage.Name = "lbl_global_cases_percentage";
            this.lbl_global_cases_percentage.Size = new System.Drawing.Size(20, 17);
            this.lbl_global_cases_percentage.TabIndex = 14;
            this.lbl_global_cases_percentage.Text = "...";
            // 
            // lbl_global_deaths_total
            // 
            this.lbl_global_deaths_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_global_deaths_total.AutoSize = true;
            this.lbl_global_deaths_total.Location = new System.Drawing.Point(3, 341);
            this.lbl_global_deaths_total.Name = "lbl_global_deaths_total";
            this.lbl_global_deaths_total.Size = new System.Drawing.Size(20, 17);
            this.lbl_global_deaths_total.TabIndex = 13;
            this.lbl_global_deaths_total.Text = "...";
            // 
            // lbl_global_cases_total
            // 
            this.lbl_global_cases_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_global_cases_total.AutoSize = true;
            this.lbl_global_cases_total.Location = new System.Drawing.Point(3, 318);
            this.lbl_global_cases_total.Name = "lbl_global_cases_total";
            this.lbl_global_cases_total.Size = new System.Drawing.Size(20, 17);
            this.lbl_global_cases_total.TabIndex = 12;
            this.lbl_global_cases_total.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_world_stats_deaths, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_world_stats_cases, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 311);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Deaths inc % population";
            // 
            // dgv_world_stats_deaths
            // 
            this.dgv_world_stats_deaths.AllowUserToAddRows = false;
            this.dgv_world_stats_deaths.AllowUserToDeleteRows = false;
            this.dgv_world_stats_deaths.AllowUserToResizeColumns = false;
            this.dgv_world_stats_deaths.AllowUserToResizeRows = false;
            this.dgv_world_stats_deaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_world_stats_deaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_world_stats_deaths.Location = new System.Drawing.Point(345, 25);
            this.dgv_world_stats_deaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_world_stats_deaths.Name = "dgv_world_stats_deaths";
            this.dgv_world_stats_deaths.ReadOnly = true;
            this.dgv_world_stats_deaths.RowTemplate.Height = 28;
            this.dgv_world_stats_deaths.Size = new System.Drawing.Size(334, 282);
            this.dgv_world_stats_deaths.TabIndex = 14;
            // 
            // dgv_world_stats_cases
            // 
            this.dgv_world_stats_cases.AllowUserToAddRows = false;
            this.dgv_world_stats_cases.AllowUserToDeleteRows = false;
            this.dgv_world_stats_cases.AllowUserToResizeColumns = false;
            this.dgv_world_stats_cases.AllowUserToResizeRows = false;
            this.dgv_world_stats_cases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_world_stats_cases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_world_stats_cases.Location = new System.Drawing.Point(5, 25);
            this.dgv_world_stats_cases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_world_stats_cases.Name = "dgv_world_stats_cases";
            this.dgv_world_stats_cases.ReadOnly = true;
            this.dgv_world_stats_cases.RowTemplate.Height = 28;
            this.dgv_world_stats_cases.Size = new System.Drawing.Size(334, 282);
            this.dgv_world_stats_cases.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Cases incl % population";
            // 
            // btn_update_who_stats
            // 
            this.btn_update_who_stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_who_stats.Location = new System.Drawing.Point(554, 318);
            this.btn_update_who_stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_who_stats.Name = "btn_update_who_stats";
            this.btn_update_who_stats.Size = new System.Drawing.Size(110, 34);
            this.btn_update_who_stats.TabIndex = 9;
            this.btn_update_who_stats.Text = "Update Data";
            this.btn_update_who_stats.UseVisualStyleBackColor = true;
            this.btn_update_who_stats.Click += new System.EventHandler(this.btn_update_who_stats_Click);
            // 
            // tab_country_stats
            // 
            this.tab_country_stats.Controls.Add(this.btn_get_data);
            this.tab_country_stats.Controls.Add(this.btn_graphs);
            this.tab_country_stats.Controls.Add(this.dgvValues);
            this.tab_country_stats.Location = new System.Drawing.Point(4, 25);
            this.tab_country_stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_country_stats.Name = "tab_country_stats";
            this.tab_country_stats.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_country_stats.Size = new System.Drawing.Size(676, 361);
            this.tab_country_stats.TabIndex = 0;
            this.tab_country_stats.Text = "Country Cases and Deaths";
            this.tab_country_stats.UseVisualStyleBackColor = true;
            // 
            // btn_get_data
            // 
            this.btn_get_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get_data.Location = new System.Drawing.Point(553, 321);
            this.btn_get_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_get_data.Name = "btn_get_data";
            this.btn_get_data.Size = new System.Drawing.Size(110, 34);
            this.btn_get_data.TabIndex = 5;
            this.btn_get_data.Text = "Update Data";
            this.btn_get_data.UseVisualStyleBackColor = true;
            this.btn_get_data.Click += new System.EventHandler(this.btn_get_data_Click);
            // 
            // btn_graphs
            // 
            this.btn_graphs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_graphs.Location = new System.Drawing.Point(11, 322);
            this.btn_graphs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_graphs.Name = "btn_graphs";
            this.btn_graphs.Size = new System.Drawing.Size(105, 34);
            this.btn_graphs.TabIndex = 2;
            this.btn_graphs.Text = "Draw Graphs";
            this.btn_graphs.UseVisualStyleBackColor = true;
            this.btn_graphs.Click += new System.EventHandler(this.btn_graphs_Click);
            // 
            // dgvValues
            // 
            this.dgvValues.AllowUserToAddRows = false;
            this.dgvValues.AllowUserToDeleteRows = false;
            this.dgvValues.AllowUserToResizeColumns = false;
            this.dgvValues.AllowUserToResizeRows = false;
            this.dgvValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValues.Location = new System.Drawing.Point(11, 10);
            this.dgvValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvValues.Name = "dgvValues";
            this.dgvValues.ReadOnly = true;
            this.dgvValues.RowTemplate.Height = 28;
            this.dgvValues.Size = new System.Drawing.Size(652, 297);
            this.dgvValues.TabIndex = 1;
            // 
            // tab_vaccinations
            // 
            this.tab_vaccinations.Controls.Add(this.btn_get_vac_data);
            this.tab_vaccinations.Controls.Add(this.btn_vac_graphs);
            this.tab_vaccinations.Controls.Add(this.tabcntrol_vaccination);
            this.tab_vaccinations.Location = new System.Drawing.Point(4, 25);
            this.tab_vaccinations.Name = "tab_vaccinations";
            this.tab_vaccinations.Size = new System.Drawing.Size(676, 361);
            this.tab_vaccinations.TabIndex = 1;
            this.tab_vaccinations.Text = "UK Vaccinations";
            this.tab_vaccinations.UseVisualStyleBackColor = true;
            // 
            // btn_get_vac_data
            // 
            this.btn_get_vac_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get_vac_data.Location = new System.Drawing.Point(553, 322);
            this.btn_get_vac_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_get_vac_data.Name = "btn_get_vac_data";
            this.btn_get_vac_data.Size = new System.Drawing.Size(110, 34);
            this.btn_get_vac_data.TabIndex = 8;
            this.btn_get_vac_data.Text = "Update Data";
            this.btn_get_vac_data.UseVisualStyleBackColor = true;
            this.btn_get_vac_data.Click += new System.EventHandler(this.btn_get_vac_data_Click);
            // 
            // btn_vac_graphs
            // 
            this.btn_vac_graphs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_vac_graphs.Location = new System.Drawing.Point(11, 323);
            this.btn_vac_graphs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_vac_graphs.Name = "btn_vac_graphs";
            this.btn_vac_graphs.Size = new System.Drawing.Size(105, 34);
            this.btn_vac_graphs.TabIndex = 7;
            this.btn_vac_graphs.Text = "Draw Graphs";
            this.btn_vac_graphs.UseVisualStyleBackColor = true;
            this.btn_vac_graphs.Click += new System.EventHandler(this.btn_vac_graphs_Click);
            // 
            // tabcntrol_vaccination
            // 
            this.tabcntrol_vaccination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcntrol_vaccination.Controls.Add(this.tab_world);
            this.tabcntrol_vaccination.Controls.Add(this.tab_uk);
            this.tabcntrol_vaccination.Controls.Add(this.tab_england);
            this.tabcntrol_vaccination.Controls.Add(this.tab_scotland);
            this.tabcntrol_vaccination.Controls.Add(this.tab_n_ireland);
            this.tabcntrol_vaccination.Controls.Add(this.tab_wales);
            this.tabcntrol_vaccination.Location = new System.Drawing.Point(-4, 3);
            this.tabcntrol_vaccination.Name = "tabcntrol_vaccination";
            this.tabcntrol_vaccination.SelectedIndex = 0;
            this.tabcntrol_vaccination.Size = new System.Drawing.Size(679, 315);
            this.tabcntrol_vaccination.TabIndex = 0;
            // 
            // tab_world
            // 
            this.tab_world.Controls.Add(this.dgv_vac_world);
            this.tab_world.Location = new System.Drawing.Point(4, 25);
            this.tab_world.Name = "tab_world";
            this.tab_world.Padding = new System.Windows.Forms.Padding(3);
            this.tab_world.Size = new System.Drawing.Size(671, 286);
            this.tab_world.TabIndex = 0;
            this.tab_world.Text = "World";
            this.tab_world.UseVisualStyleBackColor = true;
            // 
            // dgv_vac_world
            // 
            this.dgv_vac_world.AllowUserToAddRows = false;
            this.dgv_vac_world.AllowUserToDeleteRows = false;
            this.dgv_vac_world.AllowUserToResizeColumns = false;
            this.dgv_vac_world.AllowUserToResizeRows = false;
            this.dgv_vac_world.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vac_world.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_world.Location = new System.Drawing.Point(3, 3);
            this.dgv_vac_world.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_world.Name = "dgv_vac_world";
            this.dgv_vac_world.ReadOnly = true;
            this.dgv_vac_world.RowTemplate.Height = 28;
            this.dgv_vac_world.Size = new System.Drawing.Size(665, 280);
            this.dgv_vac_world.TabIndex = 2;
            // 
            // tab_uk
            // 
            this.tab_uk.Controls.Add(this.dgv_vac_uk);
            this.tab_uk.Location = new System.Drawing.Point(4, 25);
            this.tab_uk.Name = "tab_uk";
            this.tab_uk.Padding = new System.Windows.Forms.Padding(3);
            this.tab_uk.Size = new System.Drawing.Size(671, 286);
            this.tab_uk.TabIndex = 1;
            this.tab_uk.Text = "UK";
            this.tab_uk.UseVisualStyleBackColor = true;
            // 
            // dgv_vac_uk
            // 
            this.dgv_vac_uk.AllowUserToAddRows = false;
            this.dgv_vac_uk.AllowUserToDeleteRows = false;
            this.dgv_vac_uk.AllowUserToResizeColumns = false;
            this.dgv_vac_uk.AllowUserToResizeRows = false;
            this.dgv_vac_uk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vac_uk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_uk.Location = new System.Drawing.Point(3, 3);
            this.dgv_vac_uk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_uk.Name = "dgv_vac_uk";
            this.dgv_vac_uk.ReadOnly = true;
            this.dgv_vac_uk.RowTemplate.Height = 28;
            this.dgv_vac_uk.Size = new System.Drawing.Size(665, 280);
            this.dgv_vac_uk.TabIndex = 3;
            // 
            // tab_england
            // 
            this.tab_england.Controls.Add(this.dgv_vac_england);
            this.tab_england.Location = new System.Drawing.Point(4, 25);
            this.tab_england.Name = "tab_england";
            this.tab_england.Size = new System.Drawing.Size(671, 286);
            this.tab_england.TabIndex = 2;
            this.tab_england.Text = "England";
            this.tab_england.UseVisualStyleBackColor = true;
            // 
            // dgv_vac_england
            // 
            this.dgv_vac_england.AllowUserToAddRows = false;
            this.dgv_vac_england.AllowUserToDeleteRows = false;
            this.dgv_vac_england.AllowUserToResizeColumns = false;
            this.dgv_vac_england.AllowUserToResizeRows = false;
            this.dgv_vac_england.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vac_england.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_england.Location = new System.Drawing.Point(0, 0);
            this.dgv_vac_england.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_england.Name = "dgv_vac_england";
            this.dgv_vac_england.ReadOnly = true;
            this.dgv_vac_england.RowTemplate.Height = 28;
            this.dgv_vac_england.Size = new System.Drawing.Size(671, 286);
            this.dgv_vac_england.TabIndex = 3;
            // 
            // tab_scotland
            // 
            this.tab_scotland.Controls.Add(this.dgv_vac_scotland);
            this.tab_scotland.Location = new System.Drawing.Point(4, 25);
            this.tab_scotland.Name = "tab_scotland";
            this.tab_scotland.Size = new System.Drawing.Size(671, 286);
            this.tab_scotland.TabIndex = 3;
            this.tab_scotland.Text = "Scotland";
            this.tab_scotland.UseVisualStyleBackColor = true;
            // 
            // dgv_vac_scotland
            // 
            this.dgv_vac_scotland.AllowUserToAddRows = false;
            this.dgv_vac_scotland.AllowUserToDeleteRows = false;
            this.dgv_vac_scotland.AllowUserToResizeColumns = false;
            this.dgv_vac_scotland.AllowUserToResizeRows = false;
            this.dgv_vac_scotland.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_scotland.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vac_scotland.Location = new System.Drawing.Point(0, 0);
            this.dgv_vac_scotland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_scotland.Name = "dgv_vac_scotland";
            this.dgv_vac_scotland.ReadOnly = true;
            this.dgv_vac_scotland.RowTemplate.Height = 28;
            this.dgv_vac_scotland.Size = new System.Drawing.Size(671, 286);
            this.dgv_vac_scotland.TabIndex = 3;
            // 
            // tab_n_ireland
            // 
            this.tab_n_ireland.Controls.Add(this.dgv_vac_n_ireland);
            this.tab_n_ireland.Location = new System.Drawing.Point(4, 25);
            this.tab_n_ireland.Name = "tab_n_ireland";
            this.tab_n_ireland.Size = new System.Drawing.Size(671, 286);
            this.tab_n_ireland.TabIndex = 4;
            this.tab_n_ireland.Text = "N. Ireland";
            this.tab_n_ireland.UseVisualStyleBackColor = true;
            // 
            // dgv_vac_n_ireland
            // 
            this.dgv_vac_n_ireland.AllowUserToAddRows = false;
            this.dgv_vac_n_ireland.AllowUserToDeleteRows = false;
            this.dgv_vac_n_ireland.AllowUserToResizeColumns = false;
            this.dgv_vac_n_ireland.AllowUserToResizeRows = false;
            this.dgv_vac_n_ireland.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vac_n_ireland.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_n_ireland.Location = new System.Drawing.Point(0, 0);
            this.dgv_vac_n_ireland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_n_ireland.Name = "dgv_vac_n_ireland";
            this.dgv_vac_n_ireland.ReadOnly = true;
            this.dgv_vac_n_ireland.RowTemplate.Height = 28;
            this.dgv_vac_n_ireland.Size = new System.Drawing.Size(671, 286);
            this.dgv_vac_n_ireland.TabIndex = 3;
            // 
            // tab_wales
            // 
            this.tab_wales.Controls.Add(this.dgv_vac_wales);
            this.tab_wales.Location = new System.Drawing.Point(4, 25);
            this.tab_wales.Name = "tab_wales";
            this.tab_wales.Size = new System.Drawing.Size(671, 286);
            this.tab_wales.TabIndex = 5;
            this.tab_wales.Text = "Wales";
            this.tab_wales.UseVisualStyleBackColor = true;
            // 
            // dgv_vac_wales
            // 
            this.dgv_vac_wales.AllowUserToAddRows = false;
            this.dgv_vac_wales.AllowUserToDeleteRows = false;
            this.dgv_vac_wales.AllowUserToResizeColumns = false;
            this.dgv_vac_wales.AllowUserToResizeRows = false;
            this.dgv_vac_wales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vac_wales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_wales.Location = new System.Drawing.Point(0, 0);
            this.dgv_vac_wales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_wales.Name = "dgv_vac_wales";
            this.dgv_vac_wales.ReadOnly = true;
            this.dgv_vac_wales.RowTemplate.Height = 28;
            this.dgv_vac_wales.Size = new System.Drawing.Size(671, 286);
            this.dgv_vac_wales.TabIndex = 3;
            // 
            // tab_world_vac
            // 
            this.tab_world_vac.Controls.Add(this.btn_unverified_help);
            this.tab_world_vac.Controls.Add(this.btn_update_unverified_world_vac);
            this.tab_world_vac.Controls.Add(this.dgv_vac_world_unverified);
            this.tab_world_vac.Location = new System.Drawing.Point(4, 25);
            this.tab_world_vac.Name = "tab_world_vac";
            this.tab_world_vac.Size = new System.Drawing.Size(676, 361);
            this.tab_world_vac.TabIndex = 4;
            this.tab_world_vac.Text = "World Vac Unverified";
            this.tab_world_vac.UseVisualStyleBackColor = true;
            // 
            // btn_unverified_help
            // 
            this.btn_unverified_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_unverified_help.Location = new System.Drawing.Point(12, 318);
            this.btn_unverified_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_unverified_help.Name = "btn_unverified_help";
            this.btn_unverified_help.Size = new System.Drawing.Size(141, 34);
            this.btn_unverified_help.TabIndex = 9;
            this.btn_unverified_help.Text = "Why Unverified?";
            this.btn_unverified_help.UseVisualStyleBackColor = true;
            this.btn_unverified_help.Click += new System.EventHandler(this.btn_unverified_help_Click);
            // 
            // btn_update_unverified_world_vac
            // 
            this.btn_update_unverified_world_vac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_unverified_world_vac.Location = new System.Drawing.Point(554, 318);
            this.btn_update_unverified_world_vac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_unverified_world_vac.Name = "btn_update_unverified_world_vac";
            this.btn_update_unverified_world_vac.Size = new System.Drawing.Size(110, 34);
            this.btn_update_unverified_world_vac.TabIndex = 8;
            this.btn_update_unverified_world_vac.Text = "Update Data";
            this.btn_update_unverified_world_vac.UseVisualStyleBackColor = true;
            this.btn_update_unverified_world_vac.Click += new System.EventHandler(this.btn_update_unverified_world_vac_Click);
            // 
            // dgv_vac_world_unverified
            // 
            this.dgv_vac_world_unverified.AllowUserToAddRows = false;
            this.dgv_vac_world_unverified.AllowUserToDeleteRows = false;
            this.dgv_vac_world_unverified.AllowUserToResizeColumns = false;
            this.dgv_vac_world_unverified.AllowUserToResizeRows = false;
            this.dgv_vac_world_unverified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vac_world_unverified.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vac_world_unverified.Location = new System.Drawing.Point(12, 7);
            this.dgv_vac_world_unverified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vac_world_unverified.Name = "dgv_vac_world_unverified";
            this.dgv_vac_world_unverified.ReadOnly = true;
            this.dgv_vac_world_unverified.RowTemplate.Height = 28;
            this.dgv_vac_world_unverified.Size = new System.Drawing.Size(652, 297);
            this.dgv_vac_world_unverified.TabIndex = 6;
            // 
            // tab_citations
            // 
            this.tab_citations.Controls.Add(this.lbl_vacinations_citation);
            this.tab_citations.Controls.Add(this.lbl_country_stats_citation);
            this.tab_citations.Controls.Add(this.lbl_who_citation);
            this.tab_citations.Location = new System.Drawing.Point(4, 25);
            this.tab_citations.Name = "tab_citations";
            this.tab_citations.Size = new System.Drawing.Size(676, 361);
            this.tab_citations.TabIndex = 3;
            this.tab_citations.Text = "Citations";
            this.tab_citations.UseVisualStyleBackColor = true;
            // 
            // lbl_vacinations_citation
            // 
            this.lbl_vacinations_citation.AutoSize = true;
            this.lbl_vacinations_citation.Location = new System.Drawing.Point(5, 191);
            this.lbl_vacinations_citation.Name = "lbl_vacinations_citation";
            this.lbl_vacinations_citation.Size = new System.Drawing.Size(28, 17);
            this.lbl_vacinations_citation.TabIndex = 2;
            this.lbl_vacinations_citation.Text = ".....";
            // 
            // lbl_country_stats_citation
            // 
            this.lbl_country_stats_citation.AutoSize = true;
            this.lbl_country_stats_citation.Location = new System.Drawing.Point(5, 100);
            this.lbl_country_stats_citation.Name = "lbl_country_stats_citation";
            this.lbl_country_stats_citation.Size = new System.Drawing.Size(28, 17);
            this.lbl_country_stats_citation.TabIndex = 1;
            this.lbl_country_stats_citation.Text = ".....";
            // 
            // lbl_who_citation
            // 
            this.lbl_who_citation.AutoSize = true;
            this.lbl_who_citation.Location = new System.Drawing.Point(5, 25);
            this.lbl_who_citation.Name = "lbl_who_citation";
            this.lbl_who_citation.Size = new System.Drawing.Size(28, 17);
            this.lbl_who_citation.TabIndex = 0;
            this.lbl_who_citation.Text = ".....";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(631, 401);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(68, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // cmbobox_country
            // 
            this.cmbobox_country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbobox_country.FormattingEnabled = true;
            this.cmbobox_country.Location = new System.Drawing.Point(269, 407);
            this.cmbobox_country.Name = "cmbobox_country";
            this.cmbobox_country.Size = new System.Drawing.Size(256, 24);
            this.cmbobox_country.TabIndex = 5;
            this.cmbobox_country.SelectedIndexChanged += new System.EventHandler(this.cmbobox_country_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Country";
            // 
            // lbl_who_countries
            // 
            this.lbl_who_countries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_who_countries.AutoSize = true;
            this.lbl_who_countries.Location = new System.Drawing.Point(16, 410);
            this.lbl_who_countries.Name = "lbl_who_countries";
            this.lbl_who_countries.Size = new System.Drawing.Size(109, 17);
            this.lbl_who_countries.TabIndex = 8;
            this.lbl_who_countries.Text = "Choose Country";
            // 
            // cmbobox_who_country
            // 
            this.cmbobox_who_country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbobox_who_country.FormattingEnabled = true;
            this.cmbobox_who_country.Location = new System.Drawing.Point(134, 407);
            this.cmbobox_who_country.Name = "cmbobox_who_country";
            this.cmbobox_who_country.Size = new System.Drawing.Size(280, 24);
            this.cmbobox_who_country.Sorted = true;
            this.cmbobox_who_country.TabIndex = 7;
            // 
            // btn_who_find
            // 
            this.btn_who_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_who_find.Location = new System.Drawing.Point(420, 401);
            this.btn_who_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_who_find.Name = "btn_who_find";
            this.btn_who_find.Size = new System.Drawing.Size(73, 34);
            this.btn_who_find.TabIndex = 9;
            this.btn_who_find.Text = "Find";
            this.btn_who_find.UseVisualStyleBackColor = true;
            this.btn_who_find.Click += new System.EventHandler(this.btn_who_find_Click);
            // 
            // btn_who_reset
            // 
            this.btn_who_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_who_reset.Location = new System.Drawing.Point(499, 401);
            this.btn_who_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_who_reset.Name = "btn_who_reset";
            this.btn_who_reset.Size = new System.Drawing.Size(73, 34);
            this.btn_who_reset.TabIndex = 10;
            this.btn_who_reset.Text = "Reset";
            this.btn_who_reset.UseVisualStyleBackColor = true;
            this.btn_who_reset.Click += new System.EventHandler(this.btn_who_reset_Click);
            // 
            // cmbobx_world_vac
            // 
            this.cmbobx_world_vac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbobx_world_vac.FormattingEnabled = true;
            this.cmbobx_world_vac.Location = new System.Drawing.Point(134, 407);
            this.cmbobx_world_vac.Name = "cmbobx_world_vac";
            this.cmbobx_world_vac.Size = new System.Drawing.Size(259, 24);
            this.cmbobx_world_vac.Sorted = true;
            this.cmbobx_world_vac.TabIndex = 11;
            // 
            // btn_show_world_vac_data
            // 
            this.btn_show_world_vac_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_world_vac_data.Location = new System.Drawing.Point(420, 401);
            this.btn_show_world_vac_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show_world_vac_data.Name = "btn_show_world_vac_data";
            this.btn_show_world_vac_data.Size = new System.Drawing.Size(91, 34);
            this.btn_show_world_vac_data.TabIndex = 12;
            this.btn_show_world_vac_data.Text = "Show Data";
            this.btn_show_world_vac_data.UseVisualStyleBackColor = true;
            this.btn_show_world_vac_data.Click += new System.EventHandler(this.btn_show_world_vac_data_Click);
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.Location = new System.Drawing.Point(590, 401);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(35, 34);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 446);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_show_world_vac_data);
            this.Controls.Add(this.cmbobx_world_vac);
            this.Controls.Add(this.btn_who_reset);
            this.Controls.Add(this.btn_who_find);
            this.Controls.Add(this.lbl_who_countries);
            this.Controls.Add(this.cmbobox_who_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbobox_country);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabcontrol_covid19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Covid-19 Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol_covid19.ResumeLayout(false);
            this.tab_world_stats.ResumeLayout(false);
            this.tab_world_stats.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_world_stats_deaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_world_stats_cases)).EndInit();
            this.tab_country_stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).EndInit();
            this.tab_vaccinations.ResumeLayout(false);
            this.tabcntrol_vaccination.ResumeLayout(false);
            this.tab_world.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_world)).EndInit();
            this.tab_uk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_uk)).EndInit();
            this.tab_england.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_england)).EndInit();
            this.tab_scotland.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_scotland)).EndInit();
            this.tab_n_ireland.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_n_ireland)).EndInit();
            this.tab_wales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_wales)).EndInit();
            this.tab_world_vac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vac_world_unverified)).EndInit();
            this.tab_citations.ResumeLayout(false);
            this.tab_citations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabcontrol_covid19;
        private System.Windows.Forms.TabPage tab_country_stats;
        private System.Windows.Forms.DataGridView dgvValues;
        private System.Windows.Forms.Button btn_graphs;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_get_data;
        private System.Windows.Forms.ComboBox cmbobox_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_vaccinations;
        private System.Windows.Forms.Button btn_get_vac_data;
        private System.Windows.Forms.Button btn_vac_graphs;
        private System.Windows.Forms.TabControl tabcntrol_vaccination;
        private System.Windows.Forms.TabPage tab_world;
        private System.Windows.Forms.TabPage tab_uk;
        private System.Windows.Forms.TabPage tab_england;
        private System.Windows.Forms.TabPage tab_scotland;
        private System.Windows.Forms.TabPage tab_n_ireland;
        private System.Windows.Forms.TabPage tab_wales;
        private System.Windows.Forms.DataGridView dgv_vac_world;
        private System.Windows.Forms.DataGridView dgv_vac_uk;
        private System.Windows.Forms.DataGridView dgv_vac_england;
        private System.Windows.Forms.DataGridView dgv_vac_scotland;
        private System.Windows.Forms.DataGridView dgv_vac_n_ireland;
        private System.Windows.Forms.DataGridView dgv_vac_wales;
        private System.Windows.Forms.TabPage tab_world_stats;
        private System.Windows.Forms.Button btn_update_who_stats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_world_stats_deaths;
        private System.Windows.Forms.DataGridView dgv_world_stats_cases;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_global_deaths_percentage;
        private System.Windows.Forms.Label lbl_global_cases_percentage;
        private System.Windows.Forms.Label lbl_global_deaths_total;
        private System.Windows.Forms.Label lbl_global_cases_total;
        private System.Windows.Forms.TabPage tab_citations;
        private System.Windows.Forms.Label lbl_who_citation;
        private System.Windows.Forms.Label lbl_country_stats_citation;
        private System.Windows.Forms.Label lbl_vacinations_citation;
        private System.Windows.Forms.Label lbl_who_countries;
        private System.Windows.Forms.ComboBox cmbobox_who_country;
        private System.Windows.Forms.Button btn_who_find;
        private System.Windows.Forms.Button btn_who_reset;
        private System.Windows.Forms.TabPage tab_world_vac;
        private System.Windows.Forms.Button btn_unverified_help;
        private System.Windows.Forms.Button btn_update_unverified_world_vac;
        private System.Windows.Forms.DataGridView dgv_vac_world_unverified;
        private System.Windows.Forms.ComboBox cmbobx_world_vac;
        private System.Windows.Forms.Button btn_show_world_vac_data;
        private System.Windows.Forms.Button btn_help;
    }
}

