using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace covid_stats
{
    public partial class Form1
    {

        private void btn_update_who_stats_Click(object sender, EventArgs e)
        {
            get_world_stats();
        }


        private void get_world_stats()
        {

            if (File.Exists("who_world_stats.csv")) File.Delete("who_world_stats.csv");

            const string url =
                "https://covid19.who.int/WHO-COVID-19-global-table-data.csv";
            DownloadFile(url, "who_world_stats.csv");


            //fixed known issues in downloaded file
            string text = File.ReadAllText("who_world_stats.csv");
            text = text.Replace("\"occupied Palestinian territory, including east Jerusalem\"", "Palestine inc E. Jerusalem"); //remove comma from name
            text = text.Replace(",,", ",0,"); //Country called other has not population
            File.WriteAllText("who_world_stats.csv", text);

            //create the country list as it will not be the same words as in other lists we use.

            extract_countries();
            
            Populate_World_Stats_Grid();
        }

        // Load a CSV file into an array of rows and columns.
        // Assume there may be blank lines but every line has
        // the same number of fields.
        private string[,] Load_world_stats_Csv(string filename)
        {
            // Get the file's text.
            string whole_file = File.ReadAllText(filename);

            // Split into lines.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = (lines[0].Split(',').Length);

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c];

                }
            }

            // Return the values.
            return values;
        }

        private void Populate_World_Stats_Grid()
        {
            int num_rows = 0;
            int num_cols = 0;


            ////////////////////////////////////////////////////////////////
            // Load for Global cases
            ///////////////////////////////////////////////////////////////

            // Get the data.
            string[,] values = Load_world_stats_Csv("who_world_stats.csv");

            num_rows = values.GetUpperBound(0) + 1;
            num_cols = ((values.Length) / 2) - 1;

            //Display Cases Data
            dgv_world_stats_cases.Columns.Clear();

            dgv_world_stats_cases.Columns.Add("Rank", "Rank");
            dgv_world_stats_cases.Columns["Rank"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_world_stats_cases.Columns["Rank"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_world_stats_cases.Columns.Add("Country", "Country");
            dgv_world_stats_cases.Columns["Country"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_world_stats_cases.Columns.Add("Total", "Total");
            dgv_world_stats_cases.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_world_stats_cases.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_world_stats_cases.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgv_world_stats_cases.Columns.Add("% Population", "% Population");
            dgv_world_stats_cases.Columns["% Population"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_world_stats_cases.Columns["% Population"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;



            //Name,WHO Region,Cases - cumulative total,Cases - cumulative total per 1 million population,Cases - newly reported in last 7 days,Cases - newly reported in last 24 hours,Deaths - cumulative total,Deaths - cumulative total per 1 million population,Deaths - newly reported in last 7 days,Deaths - newly reported in last 24 hours,Transmission Classification


            string[] country_data = File.ReadAllLines("who_world_stats.csv");
            //get the item number in the array.
            string[] headings = Regex.Split(country_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            //  location,ISO Code,date,vaccine,total_vaccinations,source_url

            int nam = Array.IndexOf(headings, "Name");
            int tot_cas = Array.IndexOf(headings, "Cases - cumulative total");
            int case_per = Array.IndexOf(headings, "Cases - cumulative total per 100000 population");
            int tot_dea = Array.IndexOf(headings, "Deaths - cumulative total");
            int dea_per = Array.IndexOf(headings, "Deaths - cumulative total per 100000 population");






            // Add the data.
            for (int r = 2; r < num_rows; r++)
            {
                dgv_world_stats_cases.Rows.Add();
                dgv_world_stats_cases.Rows[r - 2].Cells[0].Value = r-1; //Country
                dgv_world_stats_cases.Rows[r - 2].Cells[1].Value = values[r, nam]; //Country
                dgv_world_stats_cases.Rows[r - 2].Cells[2].Value = Convert.ToInt32(values[r, tot_cas]); //Total
                dgv_world_stats_cases.Rows[r - 2].Cells[3].Value = (float.Parse(values[r, case_per]) / 1000).ToString("0.0000"); //%population
            }

            dgv_world_stats_cases.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_world_stats_cases.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_world_stats_cases.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_world_stats_cases.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgv_world_stats_cases.FirstDisplayedScrollingRowIndex = dgv_world_stats_cases.RowCount - 1;
            dgv_world_stats_cases.Sort(dgv_world_stats_cases.Columns["Total"], ListSortDirection.Descending);
            dgv_world_stats_cases.FirstDisplayedScrollingRowIndex = 0; //start on top row
            dgv_world_stats_cases.RowHeadersVisible = false;



            //Display Deaths Data
            dgv_world_stats_deaths.Columns.Clear();

            dgv_world_stats_deaths.Columns.Add("Rank", "Rank");
            dgv_world_stats_deaths.Columns["Rank"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_world_stats_deaths.Columns["Rank"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_world_stats_deaths.Columns.Add("Country", "Country");
            dgv_world_stats_deaths.Columns["Country"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_world_stats_deaths.Columns.Add("Total", "Total");
            dgv_world_stats_deaths.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_world_stats_deaths.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_world_stats_deaths.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_world_stats_deaths.Columns.Add("% Population", "% Population");
            dgv_world_stats_deaths.Columns["% Population"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_world_stats_deaths.Columns["% Population"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


            //Name,WHO Region,Cases - cumulative total,Cases - cumulative total per 1 million population,Cases - newly reported in last 7 days,Cases - newly reported in last 24 hours,Deaths - cumulative total,Deaths - cumulative total per 1 million population,Deaths - newly reported in last 7 days,Deaths - newly reported in last 24 hours,Transmission Classification

            // Add the data.
            for (int r = 2; r < num_rows; r++)
            {
                dgv_world_stats_deaths.Rows.Add();
                dgv_world_stats_deaths.Rows[r - 2].Cells[1].Value = values[r, nam]; //Country
                dgv_world_stats_deaths.Rows[r - 2].Cells[2].Value = Convert.ToInt32(values[r, tot_dea]); //Total
                dgv_world_stats_deaths.Rows[r - 2].Cells[3].Value = (float.Parse(values[r, dea_per]) / 1000).ToString("0.0000"); //Deaths - cumulative total per 100000 population
            }
        
            
            dgv_world_stats_deaths.FirstDisplayedScrollingRowIndex = dgv_world_stats_deaths.RowCount - 1;
            dgv_world_stats_deaths.Sort(dgv_world_stats_deaths.Columns["Total"], ListSortDirection.Descending);
            dgv_world_stats_deaths.FirstDisplayedScrollingRowIndex = 0; //start on top row
            dgv_world_stats_deaths.RowHeadersVisible = false;

            //Add Ranking
            for (int r = 1; r < num_rows-1; r++)
            {
                dgv_world_stats_deaths.Rows[r - 1].Cells[0].Value = r;
            }

            dgv_world_stats_deaths.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_world_stats_deaths.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_world_stats_deaths.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_world_stats_deaths.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //////////////////////////////////////////////////////////
            /// Global Figures
            ////////////////////////////////////////////////////////

            lbl_global_cases_total.Text = "Cases Global Total = " + (int.Parse(values[1, tot_cas])).ToString("### ### ### ##0");
            lbl_global_cases_percentage.Text = "Cases Global Pop % = " + (float.Parse(values[1, case_per]) / 1000).ToString("0.0000");
            lbl_global_deaths_total.Text = "Deaths Global Total = " + (int.Parse(values[1, tot_dea])).ToString("### ### ### ##0");
            lbl_global_deaths_percentage.Text = "Deaths Global Pop % = " + (float.Parse(values[1, dea_per]) / 1000).ToString("0.0000");

            dgv_world_stats_cases.ClearSelection();
            dgv_world_stats_deaths.ClearSelection();
        }


        private void extract_countries()
        {
            string line = "";
            int counter = 0;
            int num_rows = 0;

            string data_file = "who_countries.txt";
            string in_file = "who_world_stats.csv";

            string country;


            // save file name
            StreamWriter outfile = new StreamWriter(data_file);

            //We read the countries and add them to a list
            using (StreamReader sr = new StreamReader(in_file))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (counter < 2)
                    {

                    }
                    else
                    {
                        string[] parts = line.Split(',');
                        country = parts[0];
                        outfile.WriteLine(country);
                    }

                    counter++;
                }
            }

            outfile.Close();
            populate_who_file(data_file);
        }

        private void populate_who_file(string data_file)
        {
        //Now add to the combobox.
            cmbobox_who_country.Items.Clear();

            if (File.Exists(data_file))
            {
                string[] lineOfContents = File.ReadAllLines(data_file);

                foreach (var who_line in lineOfContents)
                {
                    string[] tokens = who_line.Split(',');

                    cmbobox_who_country.Items.Add(tokens[0]);
                }
            }

            cmbobox_who_country.SelectedIndex = 0;
        }

        private void btn_who_find_Click(object sender, EventArgs e)
        {
            string searchValue = "";

            try
            {
                searchValue = cmbobox_who_country.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("The chosen name does not exist");
                cmbobox_who_country.SelectedIndex = 0;
                return;
            }

            int count = 0;

            dgv_world_stats_cases.ClearSelection();
            dgv_world_stats_deaths.ClearSelection();

            dgv_world_stats_cases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgv_world_stats_cases.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        dgv_world_stats_cases.FirstDisplayedScrollingRowIndex = count;
                        break;
                    }

                    count++;
                }

                count = 0;
                foreach (DataGridViewRow row in dgv_world_stats_deaths.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        dgv_world_stats_deaths.FirstDisplayedScrollingRowIndex = count;
                        break;
                    }

                    count++;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btn_who_reset_Click(object sender, EventArgs e)
        {
            dgv_world_stats_cases.Sort(dgv_world_stats_cases.Columns["Rank"], ListSortDirection.Ascending);
            dgv_world_stats_deaths.Sort(dgv_world_stats_deaths.Columns["Rank"], ListSortDirection.Ascending);

            dgv_world_stats_cases.FirstDisplayedScrollingRowIndex = 0;
            dgv_world_stats_deaths.FirstDisplayedScrollingRowIndex = 0;
            cmbobox_who_country.SelectedIndex = 0;

            dgv_world_stats_cases.ClearSelection();
            dgv_world_stats_deaths.ClearSelection();

            
        }
    }
}
