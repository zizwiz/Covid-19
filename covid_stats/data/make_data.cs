using System.Data;
using System.IO;


namespace covid_stats
{
    public partial class Form1
    { 
        


        private void Make_Data(int row)
        {
            //string a = "";
            //int row_no = 0;
            int counter = 0;
            string line = "";

            //data for the first file
            
            int count1 = 0;
            int count2 = row; //257; //224; //row in spreadsheet
            string data_file = "Deaths.csv";
            string in_file = "orig_deaths.csv";

            for (int j = 0; j < 2; j++)
            {
                ////////////////////////////////////////////////////////////
                /// Make file without the text before the column headers
                /// ////////////////////////////////////////////////////////

                // Read the file and display it line by line.  
                StreamReader infile = new System.IO.StreamReader(in_file);

                // save it without headers
                StreamWriter outfile = new System.IO.StreamWriter(data_file);

                //only write out the part we want to work with
                while ((line = infile.ReadLine()) != null)
                {
                    if (counter == count1) //header
                    {
                        outfile.WriteLine(line);
                    }

                    if (counter == count2) //Data
                    {
                        outfile.WriteLine(line);
                    }

                    counter++;
                }

                infile.Close();
                outfile.Close();

                //reset the variables
                //a = "";
                //row_no = 0;
                counter = 0;
                line = "";

                //data for second file
                count1 = 0;
                count2 = row; //257; //224; //row in spreadsheet
                data_file = "Cases.csv";
                in_file = "orig_cases.csv";
            }

            Populate_Grid();
        }

    }
}
