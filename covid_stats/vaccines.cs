using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using convert_all;
using covid_stats.graphs;


namespace covid_stats
{
    public partial class Form1
    {


        private void btn_get_vac_data_Click(object sender, EventArgs e)
        {
            get_vac_data_Click();
            
        }


        private async void get_vac_data_Click()
        {
          //  Directory.Delete("Country_Files", true);
            if (File.Exists("world_vac.csv")) File.Delete("world_vac.csv");
            if (File.Exists("england_vac.csv")) File.Delete("england_vac.csv");
            if (File.Exists("scotland_vac.csv")) File.Delete("scotland_vac.csv");
            if (File.Exists("n_ireland_vac.csv")) File.Delete("n_ireland_vac.csv");
            if (File.Exists("wales_vac.csv")) File.Delete("wales_vac.csv");
            try
            {
                //World data
                // const string url = "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/COVID-19%20-%20Vaccinations.csv";

                const string url =
                    "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/vaccinations.csv";
                DownloadFile(url, "world_vac.csv");

                //England data.
                const string url2 =
                    "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/country_data/England.csv";
                DownloadFile(url2, "england_vac.csv");

                //Scotland data.
                const string url3 =
                    "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/country_data/Scotland.csv";
                DownloadFile(url3, "scotland_vac.csv");

                //N. Ireland data.
                const string url4 =
                    "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/country_data/Northern%20Ireland.csv";
                DownloadFile(url4, "n_ireland_vac.csv");

                //Wales data.
                const string url5 =
                    "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/country_data/Wales.csv";
                DownloadFile(url5, "wales_vac.csv");

                //UK Gov UK data.
                //   const string url6 =
                //     "https://coronavirus.data.gov.uk/api/v1/data?filters=areaName=United%20Kingdom;areaType=overview&structure={\"Name\":\"areaName\",\"date\":\"date\",\"FirstDose\":\"newPeopleReceivingFirstDose\",\"SecondDose\":\"newPeopleReceivingSecondDose\"}&format=csv";
                //  DownloadFile(url6, "uk_gov_uk_vac.csv");

                //UK Gov country data.
                //  const string url7 =
                 //   "https://coronavirus.data.gov.uk/api/v1/data?filters=areaType=nation&structure={\"Name\":\"areaName\",\"date\":\"date\",\"FirstDose\":\"cumPeopleVaccinatedFirstDoseByPublishDate\",\"SecondDose\":\"cumPeopleVaccinatedSecondDoseByPublishDate\"}&format=csv";
                //DownloadFile(url7, "uk_gov_country_vac.csv");

                //SyncFiles();


                Populate_Vaccine_Grid();
                make_country_list(); // do the rest of the world
            }
            catch
            {
                MessageBox.Show("Cannot get results from Internet, please check connection");
            }


        }

        // Load a CSV file into an array of rows and columns.
        // Assume there may be blank lines but every line has
        // the same number of fields.
        private string[,] Load_vac_Csv(string filename)
        {
            // Get the file's text.
            string whole_file = File.ReadAllText(filename);

            // Split into lines.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

           // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = (lines[0].Split(',').Length);

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
               // string[] line_r = lines[r].Split(',');

                string[] line_r = Regex.Split(lines[r], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c];

                }
            }

            // Return the values.
            return values;
        }

       
        private void Populate_Vaccine_Grid()
        {
            int num_rows = 0;
            int num_cols = 0;
            string short_date = "";

            long vac;
            long dat;
            long tot;
            long tot2;
            long loc;
            string[] headings;
            string[] country_data;

            ////////////////////////////////////////////////////////////////
            // Load for England
            ///////////////////////////////////////////////////////////////

            // Get the data.
            string[,] values = Load_vac_Csv("england_vac.csv");

            num_rows = values.GetUpperBound(0) + 1;
            num_cols = ((values.Length) / 2) - 1;

            long value2 = 0;
            long value = 0;
            // Display the data to show we have it.

            // Make column headers.
            // For this example, we assume the first row
            // contains the column names.
            dgv_vac_england.Columns.Clear();
            //for (int c = 0; c < num_cols - 1; c++)
            dgv_vac_england.Columns.Add("Date", "Date");
            dgv_vac_england.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_vac_england.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_england.Columns.Add("Vaccine", "Vaccine");
            dgv_vac_england.Columns["Vaccine"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_england.Columns.Add("Last Period", "New 1st Vac");
            dgv_vac_england.Columns["Last Period"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_england.Columns["Last Period"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_england.Columns["Last Period"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_england.Columns.Add("Total", "Tot 1st Vac");
            dgv_vac_england.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_england.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_england.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_england.Columns.Add("Last Period 2", "New 2nd Vac");
            dgv_vac_england.Columns["Last Period 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_england.Columns["Last Period 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_england.Columns["Last Period 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_england.Columns.Add("Total 2", "Tot 2nd Vac");
            dgv_vac_england.Columns["Total 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_england.Columns["Total 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_england.Columns["Total 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            country_data = File.ReadAllLines("england_vac.csv");
            //get the item number in the array.
            headings = Regex.Split(country_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //  location,ISO Code,date,vaccine,total_vaccinations,source_url

            vac = Array.IndexOf(headings, "vaccine");
            dat = Array.IndexOf(headings, "date");
           // tot = Array.IndexOf(headings, "total_vaccinations");
            tot = Array.IndexOf(headings, "people_vaccinated");
            tot2 = Array.IndexOf(headings, "people_fully_vaccinated");

            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_vac_england.Rows.Add();
                dgv_vac_england.Rows[r - 1].Cells[0].Value = Convert.ToDateTime(values[r, dat]); //Date
                dgv_vac_england.Rows[r - 1].Cells[1].Value = values[r, vac]; //Vaccine

                // dgv_vac_england.Rows[r - 1].Cells[3].Value = Convert.ToInt64(values[r, tot]) - Convert.ToInt64(values[r, tot2]); //Total 1st
                
                value = 0;
                if (values[r, tot] != "") value = Convert.ToInt64(values[r, tot]);
                dgv_vac_england.Rows[r - 1].Cells[3].Value = value; //Total 1st
                

                if (r > 1) //work out daily totals
                {
                    dgv_vac_england.Rows[r - 1].Cells[2].Value =
                        (Convert.ToInt64(values[r, tot]) - Convert.ToInt64(values[r - 1, tot]));
                }
                else if (r == 1)
                {
                    dgv_vac_england.Rows[r - 1].Cells[2].Value =
                        Convert.ToInt64(dgv_vac_england.Rows[r - 1].Cells[3].Value);
                }

                value = 0;
                if (values[r, tot2] != "") value = Convert.ToInt64(values[r, tot2]);
                dgv_vac_england.Rows[r - 1].Cells[5].Value = value; //Total 2nd

                if (r > 1) //work out daily totals
                {
                    value2 = 0;
                    if (values[r-1, tot2] != "") value2 = Convert.ToInt64(values[r-1, tot2]);
                    dgv_vac_england.Rows[r - 1].Cells[4].Value = value - value2;
                }
                else if (r == 1)
                {
                    dgv_vac_england.Rows[r - 1].Cells[4].Value =
                        Convert.ToInt64(dgv_vac_england.Rows[r - 1].Cells[5].Value);
                }


            }

            dgv_vac_england.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_england.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_england.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_england.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_england.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_england.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_vac_england.FirstDisplayedScrollingRowIndex = dgv_vac_england.RowCount - 1;
            dgv_vac_england.RowHeadersVisible = false;

            ////////////////////////////////////////////////////////////////
            // Load for Scotland
            ///////////////////////////////////////////////////////////////

            // Get the data.
            values = Load_vac_Csv("scotland_vac.csv");

            num_rows = values.GetUpperBound(0) + 1;
            num_cols = ((values.Length) / 2) - 1;

            // Make column headers.
            dgv_vac_scotland.Columns.Clear();
            dgv_vac_scotland.Columns.Add("Date", "Date");
            dgv_vac_scotland.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_vac_scotland.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_scotland.Columns.Add("Vaccine", "Vaccine");
            dgv_vac_scotland.Columns["Vaccine"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_scotland.Columns.Add("Last Period", "New 1st Vac");
            dgv_vac_scotland.Columns["Last Period"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_scotland.Columns["Last Period"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_scotland.Columns["Last Period"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_scotland.Columns.Add("Total", "Tot 1st Vac");
            dgv_vac_scotland.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_scotland.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_scotland.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_scotland.Columns.Add("Last Period 2", "New 2nd Vac");
            dgv_vac_scotland.Columns["Last Period 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_scotland.Columns["Last Period 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_scotland.Columns["Last Period 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_scotland.Columns.Add("Total 2", "Tot 2nd Vac");
            dgv_vac_scotland.Columns["Total 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_scotland.Columns["Total 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_scotland.Columns["Total 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            country_data = File.ReadAllLines("scotland_vac.csv");
            //get the item number in the array.
            headings = Regex.Split(country_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //  location,ISO Code,date,vaccine,total_vaccinations,source_url

            vac = Array.IndexOf(headings, "vaccine");
            dat = Array.IndexOf(headings, "date");
            // tot = Array.IndexOf(headings, "total_vaccinations");
            tot = Array.IndexOf(headings, "people_vaccinated");
            tot2 = Array.IndexOf(headings, "people_fully_vaccinated");

            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_vac_scotland.Rows.Add();

                dgv_vac_scotland.Rows[r - 1].Cells[0].Value = Convert.ToDateTime(values[r, dat]); //Date
                dgv_vac_scotland.Rows[r - 1].Cells[1].Value = values[r, vac]; //Vaccine

                value = 0;
                if (values[r, tot] != "") value = Convert.ToInt64(values[r, tot]);
                dgv_vac_scotland.Rows[r - 1].Cells[3].Value = value; //Total

                if (r > 1) //work out daily totals
                {
                    dgv_vac_scotland.Rows[r - 1].Cells[2].Value = (Convert.ToInt64(values[r, tot]) - Convert.ToInt64(values[r - 1, tot]));
                }
                else if (r == 1)
                {
                    dgv_vac_scotland.Rows[r - 1].Cells[2].Value = Convert.ToInt64(dgv_vac_scotland.Rows[r - 1].Cells[3].Value);
                }

                value = 0;
                if (values[r, tot2] != "") value = Convert.ToInt64(values[r, tot2]);
                dgv_vac_scotland.Rows[r - 1].Cells[5].Value = value; //Total 2nd

                if (r > 1) //work out daily totals
                {
                    value2 = 0;
                    if (values[r - 1, tot2] != "") value2 = Convert.ToInt64(values[r - 1, tot2]);
                    dgv_vac_scotland.Rows[r - 1].Cells[4].Value = value - value2;
                }
                else if (r == 1)
                {
                    dgv_vac_scotland.Rows[r - 1].Cells[4].Value =
                        Convert.ToInt64(dgv_vac_scotland.Rows[r - 1].Cells[5].Value);
                }
            }
            dgv_vac_scotland.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_scotland.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_scotland.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_scotland.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_scotland.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_scotland.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_vac_scotland.FirstDisplayedScrollingRowIndex = dgv_vac_scotland.RowCount - 1;
            dgv_vac_scotland.RowHeadersVisible = false;

            ////////////////////////////////////////////////////////////////
            // Load for Wales
            ///////////////////////////////////////////////////////////////

            // Get the data.
            values = Load_vac_Csv("wales_vac.csv");

            num_rows = values.GetUpperBound(0) + 1;
            num_cols = ((values.Length) / 2) - 1;

            // Make column headers.
            dgv_vac_wales.Columns.Clear();
            dgv_vac_wales.Columns.Add("Date", "Date");
            dgv_vac_wales.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_vac_wales.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_wales.Columns.Add("Vaccine", "Vaccine");
            dgv_vac_wales.Columns["Vaccine"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_wales.Columns.Add("Last Period", "New 1st Vac");
            dgv_vac_wales.Columns["Last Period"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_wales.Columns["Last Period"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_wales.Columns["Last Period"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_wales.Columns.Add("Total", "Tot 1st Vac");
            dgv_vac_wales.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_wales.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_wales.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_wales.Columns.Add("Last Period 2", "New 2nd Vac");
            dgv_vac_wales.Columns["Last Period 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_wales.Columns["Last Period 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_wales.Columns["Last Period 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_wales.Columns.Add("Total 2", "Tot 2nd Vac");
            dgv_vac_wales.Columns["Total 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_wales.Columns["Total 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_wales.Columns["Total 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            country_data = File.ReadAllLines("wales_vac.csv");
            //get the item number in the array.
            headings = Regex.Split(country_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //  location,ISO Code,date,vaccine,total_vaccinations,source_url

            vac = Array.IndexOf(headings, "vaccine");
            dat = Array.IndexOf(headings, "date");
            // tot = Array.IndexOf(headings, "total_vaccinations");
            tot = Array.IndexOf(headings, "people_vaccinated");
            tot2 = Array.IndexOf(headings, "people_fully_vaccinated");

            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_vac_wales.Rows.Add();

                dgv_vac_wales.Rows[r - 1].Cells[0].Value = Convert.ToDateTime(values[r, dat]); //Date
                dgv_vac_wales.Rows[r - 1].Cells[1].Value = values[r, vac]; //Vaccine

                value = 0;
                if (values[r, tot] != "") value = Convert.ToInt64(values[r, tot]);
                dgv_vac_wales.Rows[r - 1].Cells[3].Value = value; //Total

                if (r > 1) //work out daily totals
                {
                    dgv_vac_wales.Rows[r - 1].Cells[2].Value = (Convert.ToInt64(values[r, tot]) - Convert.ToInt64(values[r - 1, tot]));
                }
                else if (r == 1)
                {
                    dgv_vac_wales.Rows[r - 1].Cells[2].Value = Convert.ToInt64(dgv_vac_wales.Rows[r - 1].Cells[3].Value);
                }

                value = 0;
                if (values[r, tot2] != "") value = Convert.ToInt64(values[r, tot2]);
                dgv_vac_wales.Rows[r - 1].Cells[5].Value = value; //Total 2nd

                if (r > 1) //work out daily totals
                {
                    value2 = 0;
                    if (values[r - 1, tot2] != "") value2 = Convert.ToInt64(values[r - 1, tot2]);
                    dgv_vac_wales.Rows[r - 1].Cells[4].Value = value - value2;
                }
                else if (r == 1)
                {
                    dgv_vac_wales.Rows[r - 1].Cells[4].Value =
                        Convert.ToInt64(dgv_vac_wales.Rows[r - 1].Cells[5].Value);
                }
            }
            dgv_vac_wales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_wales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_wales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_wales.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_wales.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_wales.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_vac_wales.FirstDisplayedScrollingRowIndex = dgv_vac_wales.RowCount - 1;
            dgv_vac_wales.RowHeadersVisible = false;

            ////////////////////////////////////////////////////////////////
            // Load for Northern Ireland
            ///////////////////////////////////////////////////////////////

            // Get the data.
            values = Load_vac_Csv("n_ireland_vac.csv");

            num_rows = values.GetUpperBound(0) + 1;
            num_cols = ((values.Length) / 2) - 1;

            // Make column headers.
            dgv_vac_n_ireland.Columns.Clear();
            dgv_vac_n_ireland.Columns.Add("Date", "Date");
            dgv_vac_n_ireland.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_vac_n_ireland.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_n_ireland.Columns.Add("Vaccine", "Vaccine");
            dgv_vac_n_ireland.Columns["Vaccine"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_n_ireland.Columns.Add("Last Period", "New 1st Vac");
            dgv_vac_n_ireland.Columns["Last Period"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_n_ireland.Columns["Last Period"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_n_ireland.Columns["Last Period"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_n_ireland.Columns.Add("Total", "Tot 1st Vac");
            dgv_vac_n_ireland.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_n_ireland.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_n_ireland.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_n_ireland.Columns.Add("Last Period 2", "New 2nd Vac");
            dgv_vac_n_ireland.Columns["Last Period 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_n_ireland.Columns["Last Period 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_n_ireland.Columns["Last Period 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_n_ireland.Columns.Add("Total 2", "Tot 2nd Vac");
            dgv_vac_n_ireland.Columns["Total 2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_n_ireland.Columns["Total 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_n_ireland.Columns["Total 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            country_data = File.ReadAllLines("n_ireland_vac.csv");
            //get the item number in the array.
            headings = Regex.Split(country_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //  location,ISO Code,date,vaccine,total_vaccinations,source_url

            vac = Array.IndexOf(headings, "vaccine");
            dat = Array.IndexOf(headings, "date");
            // tot = Array.IndexOf(headings, "total_vaccinations");
            tot = Array.IndexOf(headings, "people_vaccinated");
            tot2 = Array.IndexOf(headings, "people_fully_vaccinated");

            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_vac_n_ireland.Rows.Add();

                dgv_vac_n_ireland.Rows[r - 1].Cells[0].Value = Convert.ToDateTime(values[r, dat]); //Date
                dgv_vac_n_ireland.Rows[r - 1].Cells[1].Value = values[r, vac]; //Vaccine

                value = 0;
                if (values[r, tot] != "") value = Convert.ToInt64(values[r, tot]);
                dgv_vac_n_ireland.Rows[r - 1].Cells[3].Value = value; //Total

                if (r > 1) //work out daily totals
                {
                    dgv_vac_n_ireland.Rows[r - 1].Cells[2].Value = (Convert.ToInt64(values[r, tot]) - Convert.ToInt64(values[r - 1, tot]));
                }
                else if (r == 1)
                {
                    dgv_vac_n_ireland.Rows[r - 1].Cells[2].Value = Convert.ToInt64(dgv_vac_n_ireland.Rows[r - 1].Cells[3].Value);
                }

                value = 0;
                if (values[r, tot2] != "") value = Convert.ToInt64(values[r, tot2]);
                dgv_vac_n_ireland.Rows[r - 1].Cells[5].Value = value; //Total 2nd

                if (r > 1) //work out daily totals
                {
                    value2 = 0;
                    if (values[r - 1, tot2] != "") value2 = Convert.ToInt64(values[r - 1, tot2]);
                    dgv_vac_n_ireland.Rows[r - 1].Cells[4].Value = value - value2;

                }
                else if (r == 1)
                {
                    dgv_vac_n_ireland.Rows[r - 1].Cells[4].Value =
                        Convert.ToInt64(dgv_vac_n_ireland.Rows[r - 1].Cells[5].Value);
                }
            }
            dgv_vac_n_ireland.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_n_ireland.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_n_ireland.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_n_ireland.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_n_ireland.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_n_ireland.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgv_vac_n_ireland.FirstDisplayedScrollingRowIndex = dgv_vac_n_ireland.RowCount - 1;

            dgv_vac_n_ireland.RowHeadersVisible = false;

            ////////////////////////////////////////////////////////////////
            // UK Data
            ///////////////////////////////////////////////////////////////


            // Make column headers.
            dgv_vac_uk.Columns.Clear();
            dgv_vac_uk.Columns.Add("Date", "Date");
            dgv_vac_uk.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_vac_uk.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_vac_uk.Columns.Add("Last Day", "New 1st Vac");
            dgv_vac_uk.Columns["Last Day"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_uk.Columns["Last Day"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_uk.Columns["Last Day"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_uk.Columns.Add("Total", "Total 1st Vac");
            dgv_vac_uk.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_uk.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_uk.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_uk.Columns.Add("Percentage Cover", "1st % Coverage");
            dgv_vac_uk.Columns["Percentage Cover"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_uk.Columns["Percentage Cover"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_uk.Columns.Add("Last Day2", "New 2nd Vac");
            dgv_vac_uk.Columns["Last Day2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_uk.Columns["Last Day2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_uk.Columns["Last Day2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_uk.Columns.Add("Total2", "Total 2nd Vac");
            dgv_vac_uk.Columns["Total2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_uk.Columns["Total2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_uk.Columns["Total2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_uk.Columns.Add("Percentage Cover2", "2nd % Coverage");
            dgv_vac_uk.Columns["Percentage Cover2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_uk.Columns["Percentage Cover2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            world_data = File.ReadAllLines("world_vac.csv");
            //get the item number in the array.
            headings = Regex.Split(world_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //location,iso_code,date,total_vaccinations,daily_vaccinations,total_vaccinations_per_hundred,daily_vaccinations_per_million

            loc = Array.IndexOf(headings, "location");
            dat = Array.IndexOf(headings, "date");
            // tot = Array.IndexOf(headings, "total_vaccinations");
            tot = Array.IndexOf(headings, "people_vaccinated");
            tot2 = Array.IndexOf(headings, "people_fully_vaccinated");

            int count = 0;
            //location,iso_code,date,total_vaccinations,people_vaccinated,people_fully_vaccinated,daily_vaccinations_raw,daily_vaccinations,total_vaccinations_per_hundred,people_vaccinated_per_hundred,people_fully_vaccinated_per_hundred,daily_vaccinations_per_million
            try
            {
                for (int i = 0; i < world_data.Length; i++)
                {
                    string[] fields = Regex.Split(world_data[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"); ;

                    if (fields[loc].Equals("United Kingdom"))
                    {
                        dgv_vac_uk.Rows.Add();
                        dgv_vac_uk.Rows[count].Cells[0].Value = Convert.ToDateTime(fields[dat]);
                       
                        if (fields[tot] == "")
                        {
                            dgv_vac_uk.Rows[count].Cells[2].Value = 0;
                        }
                        else
                        {
                            dgv_vac_uk.Rows[count].Cells[2].Value = Convert.ToInt64(fields[tot]);
                        }


                        if (fields[tot2] == "")
                        {
                            dgv_vac_uk.Rows[count].Cells[5].Value = 0;
                        }
                        else
                        {
                            dgv_vac_uk.Rows[count].Cells[5].Value = Convert.ToInt64(fields[tot2]);
                        }


                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                //comes in here is we cannot find the search term and then we do not draw graphs per 100k

            }


            for (int t = 0; t < dgv_vac_uk.RowCount; t++)
            {

                if (t > 0) //work out daily totals
                {
                    dgv_vac_uk.Rows[t].Cells[1].Value =
                        (Convert.ToInt64(dgv_vac_uk.Rows[t].Cells[2].Value) -
                         Convert.ToInt64(dgv_vac_uk.Rows[t - 1].Cells[2].Value));

                    dgv_vac_uk.Rows[t].Cells[4].Value =
                        (Convert.ToInt64(dgv_vac_uk.Rows[t].Cells[5].Value) -
                         Convert.ToInt64(dgv_vac_uk.Rows[t - 1].Cells[5].Value));
                }
                else if (t == 0)
                {
                    dgv_vac_uk.Rows[t].Cells[1].Value = Convert.ToInt64(dgv_vac_uk.Rows[t].Cells[2].Value);

                    dgv_vac_uk.Rows[t].Cells[4].Value = Convert.ToInt64(dgv_vac_uk.Rows[t].Cells[5].Value);
                }

                //work out percentages
                dgv_vac_uk.Rows[t].Cells[3].Value =
                    (((float)(Convert.ToInt64(dgv_vac_uk.Rows[t].Cells[2].Value)) * 100) / uk_population)
                    .ToString("0.0000") + "%";

                dgv_vac_uk.Rows[t].Cells[6].Value =
                    (((float)(Convert.ToInt64(dgv_vac_uk.Rows[t].Cells[5].Value)) * 100) / uk_population)
                    .ToString("0.0000") + "%";

            }

            dgv_vac_uk.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_uk.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_uk.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_uk.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_uk.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_uk.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_uk.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_vac_uk.FirstDisplayedScrollingRowIndex = dgv_vac_uk.RowCount - 1;

            dgv_vac_uk.RowHeadersVisible = false;



            ////////////////////////////////////////////////////////////////
            // Add World data as best we can
            ///////////////////////////////////////////////////////////////


            //country,year,total_vaccinations,total_vaccinations_per_hundred

            // Make column headers.
            dgv_vac_world.Columns.Clear();
            dgv_vac_world.Columns.Add("Date", "Date"); 
            dgv_vac_world.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_vac_world.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            
            dgv_vac_world.Columns.Add("Last Day", "New 1st Vac");
            dgv_vac_world.Columns["Last Day"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_world.Columns["Last Day"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_world.Columns["Last Day"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_world.Columns.Add("Total", "Total 1st Vac");
            dgv_vac_world.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_world.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_world.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_world.Columns.Add("Percentage Cover", "1st % Coverage");
            dgv_vac_world.Columns["Percentage Cover"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_world.Columns["Percentage Cover"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_world.Columns.Add("Last Day2", "New 2nd Vac");
            dgv_vac_world.Columns["Last Day2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_world.Columns["Last Day2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_world.Columns["Last Day2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_world.Columns.Add("Total2", "Total 2nd Vac");
            dgv_vac_world.Columns["Total2"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_vac_world.Columns["Total2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_world.Columns["Total2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_vac_world.Columns.Add("Percentage Cover2", "2nd % Coverage");
            dgv_vac_world.Columns["Percentage Cover2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_vac_world.Columns["Percentage Cover2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            world_data = File.ReadAllLines("world_vac.csv");
            //get the item number in the array.
            headings = Regex.Split(world_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //location,iso_code,date,total_vaccinations,daily_vaccinations,total_vaccinations_per_hundred,daily_vaccinations_per_million

            loc = Array.IndexOf(headings, "location");
            dat = Array.IndexOf(headings, "date");
            // tot = Array.IndexOf(headings, "total_vaccinations");
            tot = Array.IndexOf(headings, "people_vaccinated");
            tot2 = Array.IndexOf(headings, "people_fully_vaccinated");

            count = 0;

            try
            {
                for (int i = 0; i < world_data.Length; i++)
                {
                    string[] fields = Regex.Split(world_data[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"); ;

                    if (fields[loc].Equals("World"))
                    {
                        dgv_vac_world.Rows.Add();
                        dgv_vac_world.Rows[count].Cells[0].Value = Convert.ToDateTime(fields[dat]);
                       // dgv_vac_world.Rows[count].Cells[2].Value = Convert.ToInt64(fields[tot]);

                        if (fields[tot] == "")
                        {
                            dgv_vac_world.Rows[count].Cells[2].Value = 0;
                        }
                        else
                        {
                            dgv_vac_world.Rows[count].Cells[2].Value = Convert.ToInt64(fields[tot]);
                        }

                        if (fields[tot2] == "")
                        {
                            dgv_vac_world.Rows[count].Cells[5].Value = 0;
                        }
                        else
                        {
                            dgv_vac_world.Rows[count].Cells[5].Value = Convert.ToInt64(fields[tot2]);
                        }


                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                //comes in here is we cannot find the search term and then we do not draw graphs per 100k

            }

            
            for (int t = 0; t < dgv_vac_world.RowCount; t++)
            {

                if (t > 0) //work out daily totals
                {
                    dgv_vac_world.Rows[t].Cells[1].Value =
                        (Convert.ToInt64(dgv_vac_world.Rows[t].Cells[2].Value) -
                         Convert.ToInt64(dgv_vac_world.Rows[t - 1].Cells[2].Value));

                    dgv_vac_world.Rows[t].Cells[4].Value =
                        (Convert.ToInt64(dgv_vac_world.Rows[t].Cells[5].Value) -
                         Convert.ToInt64(dgv_vac_world.Rows[t - 1].Cells[5].Value));
                }
                else if (t == 0)
                {
                    dgv_vac_world.Rows[t].Cells[1].Value = Convert.ToInt64(dgv_vac_world.Rows[t].Cells[2].Value);

                    dgv_vac_world.Rows[t].Cells[4].Value = Convert.ToInt64(dgv_vac_world.Rows[t].Cells[5].Value);
                }

                //work out percentages
                dgv_vac_world.Rows[t].Cells[3].Value =
                    (((float)(Convert.ToInt64(dgv_vac_world.Rows[t].Cells[2].Value)) * 100) / w_population)
                    .ToString("0.0000") + "%";

                dgv_vac_world.Rows[t].Cells[6].Value =
                    (((float)(Convert.ToInt64(dgv_vac_world.Rows[t].Cells[5].Value)) * 100) / w_population)
                    .ToString("0.0000") + "%";

            }

            dgv_vac_world.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_world.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_world.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_world.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_world.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_world.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_vac_world.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_vac_world.FirstDisplayedScrollingRowIndex = dgv_vac_world.RowCount - 1;

            dgv_vac_world.RowHeadersVisible = false;


        }


        private void btn_vac_graphs_Click(object sender, EventArgs e)
        {
            int counter = 0;

            var G2 = new vaccine_graphs();

            foreach (DataGridViewRow row in dgv_vac_scotland.Rows)
            {
                G2.chrt_scotland_vac.Series["Scotland"].Points.Add(Convert.ToDouble(dgv_vac_scotland["Total", counter].Value));
                G2.chrt_scotland_vac.Series["Scotland_fully"].Points.Add(Convert.ToDouble(dgv_vac_scotland["Total 2", counter].Value));
                G2.chrt_scotland_vac.Series["Scotland"].Points[counter].AxisLabel = Convert.ToDateTime(dgv_vac_scotland["Date", counter].Value).ToString("d");
                
                counter++;
            }

            counter = 0;
            foreach (DataGridViewRow row in dgv_vac_england.Rows)
            {
                G2.chrt_england_vac.Series["England"].Points.Add(Convert.ToDouble(dgv_vac_england["Total", counter].Value));
                G2.chrt_england_vac.Series["England_fully"].Points.Add(Convert.ToDouble(dgv_vac_england["Total 2", counter].Value));
                G2.chrt_england_vac.Series["England"].Points[counter].AxisLabel = Convert.ToDateTime(dgv_vac_england["Date", counter].Value).ToString("d");

                counter++;
            }

            counter = 0;
            foreach (DataGridViewRow row in dgv_vac_n_ireland.Rows)
            {
                G2.chrt_n_ireland_vac.Series["N. Ireland"].Points.Add(Convert.ToDouble(dgv_vac_n_ireland["Total", counter].Value));
                G2.chrt_n_ireland_vac.Series["N. Ireland_fully"].Points.Add(Convert.ToDouble(dgv_vac_n_ireland["Total 2", counter].Value));
                G2.chrt_n_ireland_vac.Series["N. Ireland"].Points[counter].AxisLabel = Convert.ToDateTime(dgv_vac_n_ireland["Date", counter].Value).ToString("d");
                
                counter++;
            }

            counter = 0;
            foreach (DataGridViewRow row in dgv_vac_wales.Rows)
            {
                G2.chrt_wales_vac.Series["Wales"].Points.Add(Convert.ToDouble(dgv_vac_wales["Total", counter].Value));
                G2.chrt_wales_vac.Series["Wales_fully"].Points.Add(Convert.ToDouble(dgv_vac_wales["Total 2", counter].Value));
                G2.chrt_wales_vac.Series["Wales"].Points[counter].AxisLabel = Convert.ToDateTime(dgv_vac_wales["Date", counter].Value).ToString("d");

               counter++;
            }

            ///////////////////////////////////////
            /// Doughnut Chart for UK % covered
            /// ///////////////////////////////////
            int numrows = (dgv_vac_uk.RowCount) - 1;
            G2.chrt_uk_vac.Legends.Clear();
            G2.chrt_uk_vac.Series["UK_1st"].Label = " ";
            //G2.chrt_uk_vac.Titles.Add("UK % 1st (outer ring) = " + dgv_vac_uk[3, numrows].Value + "\rUK % 2nd (inner ring) = " + dgv_vac_uk[3, numrows].Value);


            string firsts = Regex.Replace(dgv_vac_uk[3, numrows].Value.ToString(), @" ", "");
            firsts = firsts.Substring(0, firsts.Length - 3) + "%";

            string fully = Regex.Replace(dgv_vac_uk[6, numrows].Value.ToString(), @" ", "");
            fully = fully.Substring(0, fully.Length - 3) + "%";

            G2.chrt_uk_vac.Titles.Add("UK: 1st = " + firsts + ", Full = " + fully);


            G2.chrt_uk_vac.Series.Clear();
            Series S1 = G2.chrt_uk_vac.Series.Add("UK_1st");
            Series S2 = G2.chrt_uk_vac.Series.Add("UK_2nd");

            G2.chrt_uk_vac.Series["UK_2nd"].Label = " ";
            G2.chrt_uk_vac.ChartAreas.Clear();
            G2.chrt_uk_vac.Legends.Clear();
            G2.chrt_uk_vac.Series["UK_1st"].Label = " ";

            ChartArea CA1 = G2.chrt_uk_vac.ChartAreas.Add("Outer");
            ChartArea CA2 = G2.chrt_uk_vac.ChartAreas.Add("Inner");

            CA1.Position = new ElementPosition(0, 0, 100, 100);
            CA2.Position = new ElementPosition(0, 0, 100, 100);

            float innerSize = 60;
            float outerSize = 100;
            float baseDoughnutWidth = 25;

            CA1.InnerPlotPosition = new ElementPosition((100 - outerSize) / 2,
                (100 - outerSize) / 2 + 10, outerSize, outerSize - 10);

            CA2.InnerPlotPosition = new ElementPosition((100 - innerSize) / 2,
                (100 - innerSize) / 2 + 10, innerSize, innerSize - 10);

            S1["DoughnutRadius"] =
                Math.Min(baseDoughnutWidth * (100 / outerSize), 99).ToString().Replace(",", ".");
            S2["DoughnutRadius"] =
                Math.Min(baseDoughnutWidth * (100 / innerSize), 99).ToString().Replace(",", ".");


            S1.ChartArea = CA1.Name;
            S2.ChartArea = CA2.Name;

            S1.ChartType = SeriesChartType.Doughnut;
            S2.ChartType = SeriesChartType.Doughnut;

            CA2.BackColor = Color.Transparent;
            S1["DoughnutRadius"] = "41"; // leave just a little space!
            S2["DoughnutRadius"] = "99"; // 99 is the limit. a tiny spot remains open

            long o_remaining_number = 68085031 - (long)dgv_vac_uk[2, numrows].Value;
            S1.Points.AddXY("1", o_remaining_number);
            S1.Points.AddXY("2", dgv_vac_uk[2, numrows].Value.ToString());

            long i_remaining_number = 68085031 - (long)dgv_vac_uk[5, numrows].Value;
            S2.Points.AddXY("1", i_remaining_number);
            S2.Points.AddXY("2", "0");
            S2.Points.AddXY("3", dgv_vac_uk[5, numrows].Value.ToString());


            ///////////////////////////////////////
            /// PieChart for World % covered
            /// ///////////////////////////////////
            /*
            long w_remaining_number = 7861686173 - (int)dgv_vac_world[2, numrows].Value;
                        
            numrows = (dgv_vac_world.RowCount) - 1;
            G2.chrt_world_vac.Legends.Clear();
            G2.chrt_world_vac.Series["World"].Label = " ";
            G2.chrt_world_vac.Titles.Add("World % Covered = " + dgv_vac_world[3, numrows].Value);
            G2.chrt_world_vac.Series["World"].Points.AddXY("1", w_remaining_number); //World Population
            G2.chrt_world_vac.Series["World"].Points.AddXY("2", dgv_vac_world[2, numrows].Value.ToString()); // vaccinated
            */

            numrows = (dgv_vac_world.RowCount) - 1;
            G2.chrt_world_vac.Legends.Clear();
            G2.chrt_world_vac.Series["World_1st"].Label = " ";

            string wfirsts = Regex.Replace(dgv_vac_world[3, numrows].Value.ToString(), @" ", "");
            wfirsts = wfirsts.Substring(0, wfirsts.Length - 3) + "%";

            string wfully = Regex.Replace(dgv_vac_world[6, numrows].Value.ToString(), @" ", "");
            wfully = wfully.Substring(0, wfully.Length - 3) + "%";

            G2.chrt_world_vac.Titles.Add("World: 1st = " + wfirsts + ", Full = " + wfully);


            G2.chrt_world_vac.Series.Clear();
            Series wS1 = G2.chrt_world_vac.Series.Add("World_1st");
            Series wS2 = G2.chrt_world_vac.Series.Add("World_2nd");

            G2.chrt_world_vac.Series["World_2nd"].Label = " ";
            G2.chrt_world_vac.ChartAreas.Clear();
            G2.chrt_world_vac.Legends.Clear();
            G2.chrt_world_vac.Series["World_1st"].Label = " ";

            ChartArea wCA1 = G2.chrt_world_vac.ChartAreas.Add("wOuter");
            ChartArea wCA2 = G2.chrt_world_vac.ChartAreas.Add("wInner");

            wCA1.Position = new ElementPosition(0, 0, 100, 100);
            wCA2.Position = new ElementPosition(0, 0, 100, 100);

            float winnerSize = 60;
            float wouterSize = 100;
            float wbaseDoughnutWidth = 25;

            wCA1.InnerPlotPosition = new ElementPosition((100 - wouterSize) / 2,
                (100 - wouterSize) / 2 + 10, wouterSize, wouterSize - 10);

            wCA2.InnerPlotPosition = new ElementPosition((100 - winnerSize) / 2,
                (100 - winnerSize) / 2 + 10, winnerSize, winnerSize - 10);

            wS1["DoughnutRadius"] =
                Math.Min(wbaseDoughnutWidth * (100 / wouterSize), 99).ToString().Replace(",", ".");
            wS2["DoughnutRadius"] =
                Math.Min(wbaseDoughnutWidth * (100 / winnerSize), 99).ToString().Replace(",", ".");


            wS1.ChartArea = wCA1.Name;
            wS2.ChartArea = wCA2.Name;

            wS1.ChartType = SeriesChartType.Doughnut;
            wS2.ChartType = SeriesChartType.Doughnut;

            wCA2.BackColor = Color.Transparent;
            wS1["DoughnutRadius"] = "41"; // leave just a little space!
            wS2["DoughnutRadius"] = "99"; // 99 is the limit. a tiny spot remains open

            long wo_remaining_number = 7861686173 - (long)dgv_vac_world[2, numrows].Value;
            wS1.Points.AddXY("1", wo_remaining_number);
            wS1.Points.AddXY("2", dgv_vac_world[2, numrows].Value.ToString());

            long wi_remaining_number = 7861686173 - (long)dgv_vac_world[5, numrows].Value;
            wS2.Points.AddXY("1", wi_remaining_number);
            wS2.Points.AddXY("2", "0");
            wS2.Points.AddXY("3", dgv_vac_world[5, numrows].Value.ToString());





            ///////////////////////////////////////
            /// PieChart for UK Target coverage
            /// ///////////////////////////////////
            long remaining_number = 52800000 - (long)dgv_vac_uk[2, ((dgv_vac_uk.RowCount) - 1)].Value;

            numrows = (dgv_vac_uk.RowCount) - 1;
            G2.chrt_uk_target.Legends.Clear();
            G2.chrt_uk_target.Series["uk_target"].Label = " ";
            G2.chrt_uk_target.Titles.Add("UK Targeted Coverage = 52.8 million 1st doses by 19 July 2021");
            G2.chrt_uk_target.Series["uk_target"].Points.AddXY("1", remaining_number); //target
            G2.chrt_uk_target.Series["uk_target"].Points.AddXY("2", dgv_vac_uk[2, numrows].Value.ToString()); // vaccinated

            

            DateTime d2 = new DateTime(2021, 7, 19);
            DateTime d1 = DateTime.Now;

            if (d1 < d2)
            {
                G2.label1.Visible = true;
                G2.label3.Visible = true;
                G2.label2.Visible = true;
                G2.label4.Visible = true;
                int DaysToGo = convert.DaysBetweenDates(d2, d1);
                if (DaysToGo == 0) DaysToGo = 1;

                G2.lbl_HowManyToGo.Text = remaining_number.ToString("### ### ##0");
                G2.lbl_HowManyEachDay.Text = (remaining_number / DaysToGo).ToString("### ### ##0");
                G2.lbl_present_rate.Text =
                    ((int) dgv_vac_uk[1, ((dgv_vac_uk.RowCount) - 1)].Value).ToString("### ### ##0");

                if (((int) dgv_vac_uk[1, ((dgv_vac_uk.RowCount) - 1)].Value) < (remaining_number / DaysToGo))
                {
                    G2.panel_uk_target.BackColor = Color.Red;
                }
                else
                {
                    G2.panel_uk_target.BackColor = Color.LimeGreen;
                }
            }
            else
            {
                G2.lbl_HowManyToGo.Text = "";
                G2.lbl_HowManyEachDay.Text = "";
                G2.lbl_present_rate.Text = "";
                G2.label1.Visible = false;
                G2.label3.Visible = false;
                G2.label2.Visible = false;
                G2.label4.Visible = false;
            }

            G2.ShowDialog();
        }



    }
}
