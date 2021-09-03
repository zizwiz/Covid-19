using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace covid_stats
{
    public partial class Form1
    {
        private void btn_update_unverified_world_vac_Click(object sender, EventArgs e)
        {
            Directory.Delete("Country_Files", true);
            MakeCountryLists();
        }

        private void MakeCountryLists()
        {
            extract_world_vac_countries(); //make file with list of countries
            populate_world_vac_file("world_vac_countries.txt");
            Get_world_vac_files("world_vac_countries.txt");
        }

        private void Get_world_vac_files(string data_file)
        {


            Directory.CreateDirectory("Country_Files");

            if (File.Exists(data_file))
            {
                string[] lineOfContents = File.ReadAllLines(data_file);

                foreach (var who_line in lineOfContents)
                {
                    try
                    {
                        if ((who_line == "") || (who_line == "World"))
                        {
                            //do nothing as these do not exist.
                        }
                        else //get each country
                        {

                            string url =
                                "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/country_data/" +
                                who_line + ".csv";

                            DownloadFile(url, "Country_Files\\" + who_line + ".csv");
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Country" + who_line + "not found");
                    }

                }
            }
            else
            {
                MessageBox.Show("File \"world_vac_countries.txt\" Missing");
            }
        }

        private void populate_world_vac_file(string data_file)
        {
            //Now add to the combobox.
            cmbobx_world_vac.Items.Clear();

            if (File.Exists(data_file))
            {
                string[] lineOfContents = File.ReadAllLines(data_file);

                foreach (var who_line in lineOfContents)
                {
                    string[] tokens = who_line.Split(',');

                    cmbobx_world_vac.Items.Add(tokens[0]);
                }
            }
            else
            {
                MessageBox.Show("File \"world_vac_countries.txt\" Missing");
            }

            cmbobx_world_vac.SelectedIndex = 0;
        }



        private void extract_world_vac_countries()
        {
            string line = "";
            int counter = 0;
            int num_rows = 0;

            string data_file = "world_vac_countries.txt";
            string in_file = "world_vac_countries.csv";

            string country = "";
            string last_read_country = " ";

           // if (File.Exists(in_file)) File.Delete(in_file);

            if (!File.Exists(in_file))
            {
                const string url =
                    "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/locations.csv";
                DownloadFile(url, in_file);
            }

            // save file name
            StreamWriter outfile = new StreamWriter(data_file);

            //We read the countries and add them to a list
            using (StreamReader sr = new StreamReader(in_file))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (counter < 1)
                    {

                    }
                    else
                    {
                        string[] parts = line.Split(',');
                        country = parts[0];

                        if (last_read_country != country)
                        {
                            outfile.WriteLine(country); //only put in file is unique
                        }
                    }

                    last_read_country = country;
                    counter++;
                }
                outfile.WriteLine("World"); //we add world to the bottom case sensitive
            }
            outfile.Close();
        }

        private void btn_show_world_vac_data_Click(object sender, EventArgs e)
        {


            int num_rows = 0;
            int num_cols = 0;
            string short_date = "";

            if (cmbobx_world_vac.SelectedItem.ToString() != "World")
            {
                ////////////////////////////////////////////////////////////////
                // Load for countries
                ///////////////////////////////////////////////////////////////

                // we need these int in case no 1st vacs have taken place
                int big = 0;
                int small = 0;

                // Get the data.
                string[,] values = Load_vac_Csv("Country_Files\\" + cmbobx_world_vac.SelectedItem + ".csv");

                num_rows = values.GetUpperBound(0) + 1;

                dgv_vac_world_unverified.Columns.Clear();
                dgv_vac_world_unverified.Columns.Add("Date", "Date");
                dgv_vac_world_unverified.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv_vac_world_unverified.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                dgv_vac_world_unverified.Columns.Add("Vaccine", "Vaccine");
                dgv_vac_world_unverified.Columns["Vaccine"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                dgv_vac_world_unverified.Columns.Add("Last Period", "New 1st Vac");
                dgv_vac_world_unverified.Columns["Last Period"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["Last Period"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["Last Period"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("Total", "1st Vac Total");
                dgv_vac_world_unverified.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("Last Period 2", "New 2nd Vac");
                dgv_vac_world_unverified.Columns["Last Period 2"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["Last Period 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["Last Period 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("Total 2", "Fully Vac Total");
                dgv_vac_world_unverified.Columns["Total 2"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["Total 2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["Total 2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("last_boost1", "New 1st Boost");
                dgv_vac_world_unverified.Columns["last_boost1"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["last_boost1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["last_boost1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("boost1", "Tot 1st Boost");
                dgv_vac_world_unverified.Columns["boost1"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["boost1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["boost1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
               
                
                DataGridViewLinkColumn url_col = new DataGridViewLinkColumn(); //make URL clickable
                url_col.DataPropertyName = "Source";
                url_col.Name = "Data Source";
                dgv_vac_world_unverified.Columns.Add(url_col);

                dgv_vac_world_unverified.CellContentClick += new DataGridViewCellEventHandler(dgv_vac_world_unverified_CellContentClick);
                dgv_vac_world_unverified.Columns["Data Source"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;



                string[] country_data = File.ReadAllLines("Country_Files\\" + cmbobx_world_vac.SelectedItem + ".csv");
                //get the item number in the array.
                string[] headings = Regex.Split(country_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                //  location,ISO Code,date,vaccine,total_vaccinations,source_url

                int vac = Array.IndexOf(headings, "vaccine");
                int dat = Array.IndexOf(headings, "date");
                int tot = Array.IndexOf(headings, "people_vaccinated");
                int tot2 = Array.IndexOf(headings, "people_fully_vaccinated");
                int boost = Array.IndexOf(headings, "total_boosters");
                int url = Array.IndexOf(headings, "source_url");

                // Add the data.
                for (int r = 1; r < num_rows; r++)
                {
                    string[] fields = Regex.Split(country_data[r], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    dgv_vac_world_unverified.Rows.Add();
                    dgv_vac_world_unverified.Rows[r - 1].Cells[0].Value = Convert.ToDateTime(values[r, dat]); //Date
                    dgv_vac_world_unverified.Rows[r - 1].Cells[1].Value = values[r, vac]; //Vaccine



                    if (fields[tot] == "") //1st
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[3].Value = 0;
                    }
                    else
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[3].Value = Convert.ToInt32(values[r, tot]);//Total
                    }

                    if (fields[tot2] == "") //2nd
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[5].Value = 0;
                    }
                    else
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[5].Value = Convert.ToInt32(values[r, tot2]);
                    }

                    if (fields[boost] == "") //1st booster
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[7].Value = 0;
                    }
                    else
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[7].Value = Convert.ToInt32(values[r, boost]);
                    }

                    
                    dgv_vac_world_unverified.Rows[r - 1].Cells[8].Value = values[r, url]; //Data Source

                    if (r > 1) //work out daily 1st vac totals
                    {
                        if (values[r, tot] != "") big = Convert.ToInt32(values[r, tot]);
                        if (values[r - 1, tot] != "") small = Convert.ToInt32(values[r - 1, tot]);

                        dgv_vac_world_unverified.Rows[r - 1].Cells[2].Value = big - small;
                    }
                    else if (r == 1)
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[2].Value =
                            Convert.ToInt32(dgv_vac_world_unverified.Rows[r - 1].Cells[3].Value).ToString();
                    }

                    big = small = 0; //reset

                    if (values[r, tot2] == values[r, tot])
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[4].Value = 0;
                    }
                    else
                    {
                        if (r > 1) //work out 2nd vac daily totals
                        {
                            if (values[r, tot2] != "") big = Convert.ToInt32(values[r, tot2]);
                            if (values[r - 1, tot2] != "") small = Convert.ToInt32(values[r - 1, tot2]);

                            dgv_vac_world_unverified.Rows[r - 1].Cells[4].Value = big - small;

                        }
                        else if (r == 1)
                        {
                            dgv_vac_world_unverified.Rows[r - 1].Cells[4].Value =
                                Convert.ToInt32(dgv_vac_world_unverified.Rows[r - 1].Cells[5].Value).ToString();
                        }

                       // big = small = 0; //reset
                    }
                    
                    big = small = 0; //reset

                    if (r > 1) //work out daily 1st boost totals
                    {
                        if (values[r, boost] != "") big = Convert.ToInt32(values[r, boost]);
                        if (values[r - 1, boost] != "") small = Convert.ToInt32(values[r - 1, boost]);

                        dgv_vac_world_unverified.Rows[r - 1].Cells[6].Value = big - small;
                    }
                    else if (r == 1)
                    {
                        dgv_vac_world_unverified.Rows[r - 1].Cells[6].Value =
                            Convert.ToInt32(dgv_vac_world_unverified.Rows[r - 1].Cells[7].Value).ToString();
                    }
                    
                    
                    big = small = 0; //reset
                }

                dgv_vac_world_unverified.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                dgv_vac_world_unverified.FirstDisplayedScrollingRowIndex = dgv_vac_world_unverified.RowCount - 1;
                dgv_vac_world_unverified.RowHeadersVisible = false;
            }
            else
            {
                ////////////////////////////////////////////////////////////////
                // Load for world
                ///////////////////////////////////////////////////////////////

                // Get the data.
                string[,] values = Load_vac_Csv("world_vac.csv");
                string SelectedCountry = "";
                int count = 0;

                num_rows = values.GetUpperBound(0) + 1;

                dgv_vac_world_unverified.Columns.Clear();
                //location,date,total_vaccinations,daily_vaccinations,total_vaccinations_per_hundred,daily_vaccinations_per_million
                dgv_vac_world_unverified.Columns.Add("Country", "Country");
                dgv_vac_world_unverified.Columns["Country"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                dgv_vac_world_unverified.Columns.Add("Date", "Date");
                dgv_vac_world_unverified.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv_vac_world_unverified.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("Total", "Had min 1 Vac");
                dgv_vac_world_unverified.Columns["Total"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("Coverage", "% Min 1 Vac Coverage");
                dgv_vac_world_unverified.Columns["Coverage"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgv_vac_world_unverified.Columns["Coverage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgv_vac_world_unverified.Columns.Add("Total2", "Fully Vac Total");
                dgv_vac_world_unverified.Columns["Total2"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["Total2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["Total2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("Coverage2", "% Fully Vac Coverage");
                dgv_vac_world_unverified.Columns["Coverage2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dgv_vac_world_unverified.Columns["Coverage2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                
                dgv_vac_world_unverified.Columns.Add("last_boost1", "New 1st Boost");
                dgv_vac_world_unverified.Columns["last_boost1"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["last_boost1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["last_boost1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv_vac_world_unverified.Columns.Add("boost1", "% 1st Boost");
                dgv_vac_world_unverified.Columns["boost1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["boost1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
               

                dgv_vac_world_unverified.Columns.Add("GTotal", "Tot Doses Given");
                dgv_vac_world_unverified.Columns["GTotal"].DefaultCellStyle.Format = "### ### ### ##0";
                dgv_vac_world_unverified.Columns["GTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_vac_world_unverified.Columns["GTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;


                world_data = File.ReadAllLines("world_vac.csv");

                //get the item number in the array.
                string[] headings = Regex.Split(world_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                //location,iso_code,date,total_vaccinations,people_vaccinated,people_fully_vaccinated,total_boosters,daily_vaccinations_raw,
                //daily_vaccinations,total_vaccinations_per_hundred,people_vaccinated_per_hundred,people_fully_vaccinated_per_hundred,
                //total_boosters_per_hundred,daily_vaccinations_per_million

                int loc = Array.IndexOf(headings, "location");
                int dat = Array.IndexOf(headings, "date");
                long gtot = Array.IndexOf(headings, "total_vaccinations"); //Number doses administered
                long tot = Array.IndexOf(headings, "people_vaccinated"); //At least one
                long pop = Array.IndexOf(headings, "people_vaccinated_per_hundred");
                long tot2 = Array.IndexOf(headings, "people_fully_vaccinated"); //Fully
                long pop2 = Array.IndexOf(headings, "people_fully_vaccinated_per_hundred");
                long boost = Array.IndexOf(headings, "total_boosters");
                long boost2 = Array.IndexOf(headings, "total_boosters_per_hundred");




                // Add the data.
                for (int r = 1; r < num_rows; r++)
                {
                    if (SelectedCountry != values[r, loc])
                    {
                        dgv_vac_world_unverified.Rows.Add();
                        SelectedCountry = values[r, 0];
                        dgv_vac_world_unverified.Rows[count].Cells[0].Value = SelectedCountry; //Country
                        dgv_vac_world_unverified.Rows[count].Cells[1].Value = Convert.ToDateTime(values[r, dat]); //Date

                        if (values[r, tot] != "") //Total
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[2].Value = Convert.ToInt64(values[r, tot]); //Total
                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[2].Value = Convert.ToInt64(0);
                        }

                        if (values[r, tot2] != "") //Fully
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[4].Value = Convert.ToInt64(values[r, tot2]);
                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[4].Value = Convert.ToInt64(0);
                        }
                        
                        if (values[r, boost] != "") //boost
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[6].Value = Convert.ToInt64(values[r, boost]);
                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[6].Value = Convert.ToInt64(0);
                        }

                        if (values[r, pop] != "") //Total
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[3].Value = float.Parse(values[r, pop]); //% Population Covered

                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[3].Value = (float)0;
                        }

                        if (values[r, pop2] != "") //Fully
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[5].Value = float.Parse(values[r, pop2]); //% Population Covered

                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[5].Value = (float)0;
                        }

                        if (values[r, boost2] != "") //Fully
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[7].Value = float.Parse(values[r, boost2]); //% Population Covered

                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[7].Value = (float)0;
                        }
                        
                        
                        
                        
                        
                        
                        if (values[r, gtot] != "") //Total vac administered
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[8].Value = Convert.ToInt32(values[r, gtot]);
                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count].Cells[8].Value = Convert.ToInt32(0);
                        }

                        count++;
                    }
                    else
                    {
                        dgv_vac_world_unverified.Rows[count - 1].Cells[0].Value = SelectedCountry; //Country
                        dgv_vac_world_unverified.Rows[count - 1].Cells[1].Value = Convert.ToDateTime(values[r, dat]); //Date
                        if (values[r, tot] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[2].Value = Convert.ToInt64(values[r, tot]); //Total
                        }

                        if (values[r, tot2] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[4].Value = Convert.ToInt64(values[r, tot2]); //Total
                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[4].Value = Convert.ToInt32(0);
                        }

                        if (values[r, pop] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[3].Value = float.Parse(values[r, pop]); //% Population Covered

                        }

                        if (values[r, pop2] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[5].Value = float.Parse(values[r, pop2]); //% Population Covered

                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[5].Value = (float)0;
                        }
                        
                        
                        if (values[r, boost] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[6].Value = float.Parse(values[r, boost]); //% Population Covered

                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[6].Value = (float)0;
                        }
                        
                        if (values[r, boost2] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[7].Value = float.Parse(values[r, boost2]); //% Population Covered

                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[7].Value = (float)0;
                        }
                        
                        
                        

                        if (values[r, gtot] != "")
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[8].Value = Convert.ToInt64(values[r, gtot]); //Total
                        }
                        else
                        {
                            dgv_vac_world_unverified.Rows[count - 1].Cells[8].Value = Convert.ToInt64(0);
                        }
                    }
                }

                dgv_vac_world_unverified.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_vac_world_unverified.Sort(dgv_vac_world_unverified.Columns["Coverage"], ListSortDirection.Descending);
                dgv_vac_world_unverified.FirstDisplayedScrollingRowIndex = 0;
                dgv_vac_world_unverified.RowHeadersVisible = false;
            }
        }

        private void dgv_vac_world_unverified_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //start default browser and go to site but only if we are in url column
            try
            {
                if ((e.ColumnIndex == 6) && (tabcontrol_covid19.SelectedTab.Name == "tab_world_vac"))
                    Process.Start(dgv_vac_world_unverified.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            catch (Exception exception)
            {
                //Clicked on header on URL column
                // Ignore the issue and carry on. 
            }

        }
    }
}
