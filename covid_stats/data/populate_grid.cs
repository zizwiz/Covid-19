using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace covid_stats
{
    public partial class Form1
    {
        private void Populate_Grid()
        {

            // data_file = "DailyCases.csv";
            // Deaths.csv
            //  lbl_status.Text = "Getting Files from GOV.UK";

            string data_file = "Deaths.csv";
            bool flag = true;
            int num_rows = 0;
            int num_cols = 0;
            //string short_date = "";

            for (int j = 0; j < 2; j++)
            {
                // Get the data.
                string[,] values = LoadCsv(data_file);

                if (flag) //only set first time through
                {
                    num_rows = values.GetUpperBound(0) + 1;
                    num_cols = (values.Length) / 2;

                    // Display the data to show we have it.

                    // Make column headers.
                    // For this example, we assume the first row
                    // contains the column names.
                    dgvValues.Columns.Clear();
                    //for (int c = 0; c < num_cols - 1; c++)
                    dgvValues.Columns.Add("Date", "Date"); 
                    dgvValues.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvValues.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvValues.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvValues.Columns.Add("Tot Deaths", "Tot Deaths");
                    dgvValues.Columns["Tot Deaths"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvValues.Columns["Tot Deaths"].DefaultCellStyle.Format = "### ### ### ##0";
                    dgvValues.Columns["Tot Deaths"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                    dgvValues.Columns.Add("Daily Deaths", "Daily Deaths");
                    dgvValues.Columns["Daily Deaths"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvValues.Columns["Daily Deaths"].DefaultCellStyle.Format = "### ### ### ##0";
                    dgvValues.Columns["Daily Deaths"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                    dgvValues.Columns.Add("Tot Cases", "Tot Cases");
                    dgvValues.Columns["Tot Cases"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvValues.Columns["Tot Cases"].DefaultCellStyle.Format = "### ### ### ##0";
                    dgvValues.Columns["Tot Cases"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                    dgvValues.Columns.Add("Daily Cases", "Daily Cases");
                    dgvValues.Columns["Daily Cases"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgvValues.Columns["Daily Cases"].DefaultCellStyle.Format = "### ### ### ##0";
                    dgvValues.Columns["Daily Cases"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



                    // Add the data.
                    for (int r = 0; r < num_cols; r++)
                    {
                        dgvValues.Rows.Add();

                        //We need to mangle the date we want it from MM/dd/yy to dd/MM/yyyy
                        string[] date_parts = values[0, r].Split('/');
                        //Now cast the date to a datetime object
                        dgvValues.Rows[r].Cells[0].Value = Convert.ToDateTime(date_parts[1] + "/" + date_parts[0] + "/" + "20" + date_parts[2]); //Date
                        dgvValues.Rows[r].Cells[1].Value = Convert.ToInt32(values[1, r]); //Total

                        if (r > 0) //work out daily totals
                        {
                            dgvValues.Rows[r].Cells[2].Value = (Convert.ToInt32(values[1, r]) - Convert.ToInt32(values[1, r - 1]));
                        }
                    }
                }
                else
                {

                    // Add the data for cases.
                    for (int r = 0; r < num_cols; r++)
                    {
                        //Cases
                        dgvValues.Rows[r].Cells[3].Value = Convert.ToInt32(values[1, r]);

                        if (r > 0)
                        {
                            dgvValues.Rows[r].Cells[4].Value = (Convert.ToInt32(values[1, r]) - Convert.ToInt32(values[1, r - 1]));
                        }
                    }
                }

                //change variables for next time through
                data_file = "Cases.csv";
                flag = false;
            }

            //Make the columns fill the space

            dgvValues.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvValues.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvValues.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvValues.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvValues.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvValues.FirstDisplayedScrollingRowIndex = dgvValues.RowCount - 1;
            dgvValues.RowHeadersVisible = false;
            

        }

        // Load a CSV file into an array of rows and columns.
        // Assume there may be blank lines but every line has
        // the same number of fields.
        private string[,] LoadCsv(string filename)
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
            string[,] values = new string[num_rows, num_cols - 65];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < num_cols; c++)
                {
                    if (c > 64)
                    {

                        values[r, c - 65] = line_r[c];
                    }
                }
            }

            // Return the values.
            return values;
        }


    }
}
