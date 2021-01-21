using System;
using System.IO;
using System.Windows.Forms;

namespace covid_stats
{
    public partial class Form1
    {
        private void make_country_list()
        {
            string line = "";
            int counter = 0;
            int num_rows = 0;

            string data_file = "countries.txt";
            string in_file = "orig_deaths.csv";

            string country;
            

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
                        country = parts[1];
                        if (parts[0] != "") // if country has subsections add them
                        {
                            country = country + " - " + parts[0];
                        }
                        outfile.WriteLine(country);
                    }

                    counter++;
                }
            }
            
            outfile.Close();
            populate_list();
        }


        private void populate_list()
        {
            string data_file = "countries.txt";

            cmbobox_country.Items.Clear();

            if (File.Exists(data_file))
            {
                string[] lineOfContents = File.ReadAllLines(data_file);
                 
                foreach (var line in lineOfContents)
                {
                    string[] tokens = line.Split(',');
                    
                    cmbobox_country.Items.Add(tokens[0]);
                }

                
            }
            else
            {
                MessageBox.Show("Please click on get data");
            }

            //cmbobox_country.SelectedIndex = 257;


        }




    }
}
