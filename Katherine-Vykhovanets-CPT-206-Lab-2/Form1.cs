using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Katherine Vykhovanets
//CPT 206
//Lab 2

namespace Katherine_Vykhovanets_CPT_206_Lab_2
{
    public partial class Form1 : Form
    {
        CityDetails cityDetails = new CityDetails();
        public Form1()
        {
            InitializeComponent();
        }

        private void cityTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDataSet.CityTable' table. You can move, or remove it, as needed.
            this.cityTableTableAdapter.Fill(this.cityDataSet.CityTable);
        }
        //I dont think show details was required but I wanted to include it
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            cityDetails.ShowDialog();
            this.cityTableTableAdapter.Fill(this.cityDataSet.CityTable); 
        }
        //close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sort data by ascending population (fill table with query)
        private void btnPopAsc_Click(object sender, EventArgs e)
        {
            this.cityTableTableAdapter.FillByPopAsc(this.cityDataSet.CityTable);
        }
        //Sort data by descending population (fill table with query)

        private void btnPopDesc_Click(object sender, EventArgs e)
        {
            this.cityTableTableAdapter.FillByPopDesc(this.cityDataSet.CityTable);
        }
        //Sort data by city name (fill table with query)
        //button name was changed but it did not update here but still seems to work?
        private void button1_Click(object sender, EventArgs e)
        {
            this.cityTableTableAdapter.FillByName(this.cityDataSet.CityTable);
        }
        //find highest population
        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = 0;
            max = (int)this.cityTableTableAdapter.GetMax();
            MessageBox.Show("The highest population is: " + max);
        }
        //find lowest population
        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = 0;
            min = (int)this.cityTableTableAdapter.GetMin();
            MessageBox.Show("The highest population is: " + min);
        }
        //find average population
        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            decimal avg = 0.0m;
            object result = this.cityTableTableAdapter.GetAvg();
            //Had to add result object and if statement because it wasn't working
            if (result != null)
            {
                avg = Convert.ToDecimal(result);
                MessageBox.Show("The average population is: " + avg.ToString());
            }
            else//cant calculate an average if there is no data
            {
                MessageBox.Show("Please add data to calculate an average population.");
            }
        }
        //calculate total population
        private void btnTotalPop_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = (int)this.cityTableTableAdapter.GetSum();
            MessageBox.Show("The total population is: " + sum);
        }
    }
}
