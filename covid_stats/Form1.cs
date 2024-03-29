﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using covid_stats.graphs;
using covid_stats.Properties;
using help_about;

namespace covid_stats
{
    public partial class Form1 : Form
    {
        private string[] world_data;
        private long w_population = 7879482612;
        private long uk_population = 68258533; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_graphs_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int Population = 1;
            bool flag = false;

            try
            {
                string country = cmbobox_country.SelectedItem.ToString();
            //read world data into a file to use later
            world_data = File.ReadAllLines("World_Stats.csv");

            
                for (int i = 0; i < world_data.Length; i++)
                {
                    string[] fields = world_data[i].Split(',');

                    if (fields[0].Equals(country))
                    {
                       flag = true;
                       Population = Int32.Parse(fields[1]);
                       
                    }
                }
           }
           catch (Exception ex)
           {
               //comes in here is we cannot find the search term and then we do not draw graphs per 100k
               string ext = ex.ToString();
               flag = false;
           }



            var G1 = new Graphs();

            foreach (DataGridViewRow row in dgvValues.Rows)
            {
                G1.chrt_Daily.Series["Daily"].Points.Add(Convert.ToDouble(dgvValues["Daily Cases", counter].Value));
                G1.chrt_Daily.Series[0].Points[counter].AxisLabel = Convert.ToDateTime(dgvValues["Date", counter].Value).ToString("d");

                G1.chrt_deaths.Series["Deaths"].Points.Add(Convert.ToDouble(dgvValues["Daily Deaths", counter].Value));
                G1.chrt_deaths.Series[0].Points[counter].AxisLabel = Convert.ToDateTime(dgvValues["Date", counter].Value).ToString("d");


                if (flag) //Can only draw if we have population
                {
                    G1.chrt_cases_100k.Series["cases_100k"].Points
                        .Add((Convert.ToDouble(dgvValues["Tot Cases", counter].Value) / Population) * 100000);
                    G1.chrt_cases_100k.Series[0].Points[counter].AxisLabel = Convert.ToDateTime(dgvValues["Date", counter].Value).ToString("d");

                    G1.chrt_deaths_100k.Series["deaths_100k"].Points
                        .Add((Convert.ToDouble(dgvValues["Tot Deaths", counter].Value) / Population) * 100000);
                    G1.chrt_deaths_100k.Series[0].Points[counter].AxisLabel = Convert.ToDateTime(dgvValues["Date", counter].Value).ToString("d");

                }

                counter++;
            }


            G1.ShowDialog();
        }

        

        private void btn_get_data_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists("orig_cases.csv")) File.Delete("orig_cases.csv");
                if (File.Exists("orig_deaths.csv")) File.Delete("orig_deaths.csv");
                if (File.Exists("countries.txt")) File.Delete("countries.txt");


                //deaths data
                const string url = "https://data.humdata.org/hxlproxy/api/data-preview.csv?url=https%3A%2F%2Fraw.githubusercontent.com%2FCSSEGISandData%2FCOVID-19%2Fmaster%2Fcsse_covid_19_data%2Fcsse_covid_19_time_series%2Ftime_series_covid19_deaths_global.csv&filename=time_series_covid19_deaths_global.csv";
                DownloadFile(url, "orig_deaths.csv");

                //case data.
                const string url2 = "https://data.humdata.org/hxlproxy/api/data-preview.csv?url=https%3A%2F%2Fraw.githubusercontent.com%2FCSSEGISandData%2FCOVID-19%2Fmaster%2Fcsse_covid_19_data%2Fcsse_covid_19_time_series%2Ftime_series_covid19_confirmed_global.csv&filename=time_series_covid19_confirmed_global.csv";
                DownloadFile(url2, "orig_cases.csv");

                make_country_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            int linenum = Getline("United Kingdom", ""); //Find the UK entry

            Make_Data(linenum); //take data out of large files
            cmbobox_country.SelectedIndex = linenum - 1; //subtract 1 for header row
        }


        int Getline(string country, string state)
        {
            //find the line number for requested country.
            int count = 0;
            var strLines = File.ReadLines("orig_deaths.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[1].Equals(country) && (line.Split(',')[0].Equals(state)))
                    return count;
                count++;
            }

            return 1;
        }







        private void DownloadFile(string url, string filename)
        {
            // See if we have today's file.
            if (!File.Exists(filename))
            {
                // Download the file.
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                try
                {
                    // Make a WebClient.
                    WebClient web_client = new WebClient();

                    // Download the file.
                    web_client.DownloadFile(url, filename);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Download Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("orig_deaths.csv"))
            {
                //deaths data
                const string url = "https://data.humdata.org/hxlproxy/api/data-preview.csv?url=https%3A%2F%2Fraw.githubusercontent.com%2FCSSEGISandData%2FCOVID-19%2Fmaster%2Fcsse_covid_19_data%2Fcsse_covid_19_time_series%2Ftime_series_covid19_deaths_global.csv&filename=time_series_covid19_deaths_global.csv";
                DownloadFile(url, "orig_deaths.csv");

                //case data.
                const string url2 = "https://data.humdata.org/hxlproxy/api/data-preview.csv?url=https%3A%2F%2Fraw.githubusercontent.com%2FCSSEGISandData%2FCOVID-19%2Fmaster%2Fcsse_covid_19_data%2Fcsse_covid_19_time_series%2Ftime_series_covid19_confirmed_global.csv&filename=time_series_covid19_confirmed_global.csv";
                DownloadFile(url2, "orig_cases.csv");
            }

            int linenum = Getline("United Kingdom", ""); //Find the UK entry

            Make_Data(linenum); //take data out of large files
            make_country_list();
            cmbobox_country.SelectedIndex = linenum - 1; //subtract 1 for header row
            

            // get file of country info from resources. If it exists delete it otherwise make it
            if (File.Exists("World_Stats.csv")) File.Delete("World_Stats.csv");
            File.WriteAllText("World_Stats.csv", Resources.World_Stats);
            
            cmbobox_country.Visible = false;
            label3.Visible = false;

            //read world data into a file to use later
            world_data = File.ReadAllLines("World_Stats.csv");


            //england_vac.csv   n_ireland_vac.csv   scotland_vac.csv    wales_vac.csv  world_vac.csv
            if (File.Exists("england_vac.csv")&& File.Exists("n_ireland_vac.csv") && File.Exists("scotland_vac.csv") && File.Exists("wales_vac.csv") && File.Exists("world_vac.csv"))
            {
                Populate_Vaccine_Grid();
            }
            else
            {
                get_vac_data_Click();
            }

            //UK hospital Data
            if (File.Exists("uk_hospitals.csv"))
            {
                Populate_UK_Hospital_Grid();
            }
            else
            {
                get_uk_hospital_data();
            }


            //england_vac.csv   n_ireland_vac.csv   scotland_vac.csv    wales_vac.csv  world_vac.csv
            if (File.Exists("who_world_stats.csv")&& File.Exists("who_countries.txt"))
            {
                Populate_World_Stats_Grid();
                populate_who_file("who_countries.txt");
            }
            else
            {
                get_world_stats();
            }

            SetVisibility();
            AddCitations();
            try
            {
                if (!File.Exists("world_vac_countries.csv"))
                {
                    const string url =
                        "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/locations.csv";
                    DownloadFile(url, "world_vac_countries.csv");
                }
            }
            catch (Exception exception)
            {
                //not connected to internet so do nothing
                string ex = exception.ToString();
            }
            
            MakeCountryLists();
        }

        private void cmbobox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Make_Data(cmbobox_country.SelectedIndex + 1); //add 1 for header row
        }


        private void tabcontrol_covid19_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetVisibility();
        }

        private void SetVisibility()
        {
        if ((tabcontrol_covid19.SelectedTab == tab_vaccinations)|| (tabcontrol_covid19.SelectedTab == tab_citations) || (tabcontrol_covid19.SelectedTab == tab_uk_hospital_data))
            {
                cmbobox_country.Visible = false;
                label3.Visible = false;
                cmbobox_who_country.Visible = false;
                lbl_who_countries.Visible = false;
                btn_who_find.Visible = false;
                btn_who_reset.Visible = false;
                cmbobx_world_vac.Visible = false;
                btn_show_world_vac_data.Visible = false;
            }
            else if (tabcontrol_covid19.SelectedTab == tab_country_stats)
            {
                cmbobox_country.Visible = true;
                label3.Visible = true;
                cmbobox_who_country.Visible = false;
                lbl_who_countries.Visible = false;
                btn_who_find.Visible = false;
                btn_who_reset.Visible = false;
                cmbobx_world_vac.Visible = false;
                btn_show_world_vac_data.Visible = false;
            }
            else if (tabcontrol_covid19.SelectedTab == tab_world_stats)
            {
                cmbobox_country.Visible = false;
                label3.Visible = false;
                cmbobox_who_country.Visible = true;
                lbl_who_countries.Visible = true;
                btn_who_find.Visible = true;
                btn_who_reset.Visible = true;
                cmbobx_world_vac.Visible = false;
                btn_show_world_vac_data.Visible = false;
            }
            else if (tabcontrol_covid19.SelectedTab == tab_world_vac)
            {
                cmbobox_country.Visible = false;
                label3.Visible = false;
                cmbobox_who_country.Visible = false;
                lbl_who_countries.Visible = true;
                btn_who_find.Visible = false;
                btn_who_reset.Visible = false;
                cmbobx_world_vac.Visible = true;
                btn_show_world_vac_data.Visible = true;
            }


        }

        private void AddCitations()
        {
            lbl_who_citation.Text = "WHO coronavirus disease (COVID-19) dashboard. Geneva: World Health Organization, 2020.";
            lbl_country_stats_citation.Text = "United Nations Office for the Coordination of Humanitarian Affairs, Humanitarian Data Exchange";
            lbl_vacinations_citation.Text = "Hasell, J., Mathieu, E., Beltekian, D. et al. A cross-country database of COVID-19 testing. Sci Data 7, 345 (2020). https://doi.org/10.1038/s41597-020-00688-8";
            lbl_Licence.Text = "GNU General Public License v3.0";
        }

        private void btn_unverified_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some help with understanding the data. \r\n"+
            "\r\nAlthough we are getting better data from around the world some is a bit sketchy. You will often see a result of 0 all this means I do not have solid data for this so rather than put down something that has a high probability of being incorrect I just put down 0.\r\n" +
            "\r\nThis is how the data is worked out before I get it and how I lay it out.\r\n" +
            "\r\nTot Doses Given: total number of doses administered.This is counted as a single dose, and may not equal the total number of people vaccinated, depending on the specific dose regime(e.g.people receive multiple doses).If a person receives one dose of the vaccine, this metric goes up by 1.If they receive a second dose, it goes up by 1 again.\r\n" +
            "\r\nHad Min 1 Vac: total number of people who received at least one vaccine dose.If a person receives the first dose of a 2 - dose vaccine, this metric goes up by 1.If they receive the second dose, the metric stays the same.\r\n" +
            "\r\nFully Vac Total: total number of people who received all doses prescribed by the vaccination protocol.If a person receives the first dose of a 2 - dose vaccine, this metric stays the same.If they receive the second dose, the metric goes up by 1.Some vaccines are only single dose\r\n");
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jetbrains.com");
        }

       
    }
}
