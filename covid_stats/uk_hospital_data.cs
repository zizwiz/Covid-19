using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using covid_stats.graphs;


namespace covid_stats
{
    public partial class Form1
    {
        private void btn_update_uk_hosp_data_Click(object sender, EventArgs e)
        {
            get_uk_hospital_data();
        }


        private void get_uk_hospital_data()
        {
            if (File.Exists("uk_hospitals.csv")) File.Delete("uk_hospitals.csv");
            
            try
            {
                
                const string url =
                    "https://api.coronavirus.data.gov.uk/v2/data?areaType=overview&metric=newAdmissions&metric=hospitalCases&format=csv";

                DownloadFile(url, "uk_hospitals.csv");

                Populate_UK_Hospital_Grid();
            }
            catch
            {
                MessageBox.Show("Cannot get results from Internet, please check connection");
            }
        }


        private void Populate_UK_Hospital_Grid()
        {
            int num_rows = 0;
            //int num_cols = 0;
            //string short_date = "";

            int hosp_cases;
            int new_cases;
            int dat; //date

            string[] headings;
            string[] uk_hosp_data;

            // Get the data.
            string[,] values = Load_vac_Csv("uk_hospitals.csv");

            uk_hosp_data = File.ReadAllLines("uk_hospitals.csv");
            headings = Regex.Split(uk_hosp_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

            dat = Array.IndexOf(headings, "date");
            hosp_cases = Array.IndexOf(headings, "hospitalCases");
            new_cases = Array.IndexOf(headings, "newAdmissions");


            num_rows = values.GetUpperBound(0) + 1;
           
            //int value2 = 0;
            int value = 0;
            int hosp_today = 0;
            int hosp_yesterday = 0;
            
            // Make column headers.
            // For this example, we assume the first row
            // contains the column names.
            dgv_uk_hospital.Columns.Clear();

            dgv_uk_hospital.Columns.Add("Date", "Date");
            dgv_uk_hospital.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_uk_hospital.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_uk_hospital.Columns.Add("hospitalCases", "Hospitalised Cases");
            dgv_uk_hospital.Columns["hospitalCases"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_uk_hospital.Columns["hospitalCases"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_uk_hospital.Columns["hospitalCases"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_uk_hospital.Columns.Add("newAdmissions", "New Admissions");
            dgv_uk_hospital.Columns["newAdmissions"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_uk_hospital.Columns["newAdmissions"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_uk_hospital.Columns["newAdmissions"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            
            dgv_uk_hospital.Columns.Add("netGain", "Net Gain");
            dgv_uk_hospital.Columns["netGain"].DefaultCellStyle.Format = "### ### ### ##0";
            dgv_uk_hospital.Columns["netGain"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_uk_hospital.Columns["netGain"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            
            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_uk_hospital.Rows.Add();
                dgv_uk_hospital.Rows[r - 1].Cells[0].Value = Convert.ToDateTime(values[r, dat]); //Date

                value = 0;
                if (values[r, hosp_cases] != "") value = Convert.ToInt32(values[r, hosp_cases]);
                dgv_uk_hospital.Rows[r - 1].Cells[1].Value = value; //Total hospitalised cases

                value = 0;
                if (values[r, new_cases] != "") value = Convert.ToInt32(values[r, new_cases]);
                dgv_uk_hospital.Rows[r - 1].Cells[2].Value = value; //Total new cases

                
            }
            
            hosp_yesterday = 0;
            for (int r = 1; r < num_rows; r++)
            {
                value = 0;
                
                
                if (values[r, hosp_cases] != "")
                {
                    hosp_today = Convert.ToInt32(values[r, hosp_cases]);
                    if (r == num_rows - 1)
                    {
                       hosp_yesterday = 0;
                    }
                   
                        dgv_uk_hospital.Rows[r - 1].Cells[3].Value = hosp_yesterday - hosp_today; //net gain
                        hosp_yesterday = hosp_today;
                }
                else
                {
                    dgv_uk_hospital.Rows[r-1].Cells[3].Value = 0;
                }
            }

            dgv_uk_hospital.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_uk_hospital.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_uk_hospital.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_uk_hospital.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dgv_uk_hospital.Sort(dgv_uk_hospital.Columns["Date"], ListSortDirection.Ascending); //We need to get the newest data at the bottom.

            dgv_uk_hospital.FirstDisplayedScrollingRowIndex = dgv_uk_hospital.RowCount - 1;
            dgv_uk_hospital.RowHeadersVisible = false;
        }


        private void btn_draw_uk_hos_graph_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int num_rows = dgv_uk_hospital.RowCount;
            

            var G3 = new uk_hosp_graphs();

           foreach (DataGridViewRow row in dgv_uk_hospital.Rows)
            {
                G3.chrt_num_in_hosp.Series["NumInHosp"].Points.Add(Convert.ToDouble(dgv_uk_hospital["hospitalCases", counter].Value));
                G3.chrt_num_in_hosp.Series["NumInHosp"].Points[counter].AxisLabel = Convert.ToDateTime(dgv_uk_hospital["Date", counter].Value).ToString("d");

                if (Convert.ToDouble(dgv_uk_hospital["newAdmissions", counter].Value) > 0)
                {
                    G3.chrt_new_admissions.Series["NewAdmissions"].Points
                        .Add(Convert.ToDouble(dgv_uk_hospital["newAdmissions", counter].Value));
                    G3.chrt_new_admissions.Series["NewAdmissions"].Points[counter].AxisLabel =
                        Convert.ToDateTime(dgv_uk_hospital["Date", counter].Value).ToString("d");
                }

                if (counter < (num_rows-1))
                {
                    G3.chrt_net_gain.Series["NetGain"].Points
                        .Add(Convert.ToDouble(dgv_uk_hospital["netGain", counter].Value));
                    G3.chrt_net_gain.Series["NetGain"].Points[counter].AxisLabel =
                        Convert.ToDateTime(dgv_uk_hospital["Date", counter].Value).ToString("d");
                }

                counter++;
            }

            G3.Show();
        }
    }
}
