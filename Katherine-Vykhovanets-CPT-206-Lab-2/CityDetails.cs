using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katherine_Vykhovanets_CPT_206_Lab_2
{
    public partial class CityDetails : Form
    {
        public CityDetails()
        {
            InitializeComponent();
        }

        private void cityTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDataSet);

        }

        private void CityDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDataSet.CityTable' table. You can move, or remove it, as needed.
            this.cityTableTableAdapter.Fill(this.cityDataSet.CityTable);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
