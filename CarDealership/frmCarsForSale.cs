using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace CarDealership
{
    public partial class frmCarsForSale : Form
    {
        Dictionary<string, string> filterByDictionary = new Dictionary<string, string>
        {
            { "Make", "CarMake" },
            { "Color", "CarColor" },
            { "Age", "CarYear" },
            { "Price", "CarPrice" }
        };

        public frmCarsForSale()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupFinal266DataSet);
        }

        private void frmCarsForSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.groupFinal266DataSet.Comments);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Listing' table. You can move, or remove it, as needed.
            this.listingTableAdapter.Fill(this.groupFinal266DataSet.Listing);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Sellers' table. You can move, or remove it, as needed.
            this.sellersTableAdapter.Fill(this.groupFinal266DataSet.Sellers);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.groupFinal266DataSet.Buyers);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.groupFinal266DataSet.Cars);

            SetUpFilterByComboBox();
        }

        private void SetUpFilterByComboBox()
        {
            filterByToolStripComboBox.ComboBox.Items.Add("Make");
            filterByToolStripComboBox.ComboBox.Items.Add("Color");
            filterByToolStripComboBox.ComboBox.Items.Add("Age");
            filterByToolStripComboBox.ComboBox.Items.Add("Price");

            filterByToolStripComboBox.ComboBox.SelectedIndex = 0;
        }

        private void filterByToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carPropertyStripComboBox.ComboBox.Items.Clear();

            string filterProperty = filterByToolStripComboBox.ComboBox.SelectedItem.ToString();
            carListingPropertyStripLabel.Text = filterProperty + ": ";

            List<string> options;

            ListingDB.GetCarPropertyFilteredByComboBoxValues(filterByDictionary[filterProperty], Program.sqlConnection, out options);

            foreach (var option in options)
                carPropertyStripComboBox.ComboBox.Items.Add(option.ToString());

            carPropertyStripComboBox.ComboBox.SelectedIndex = 0;
        }

        private void viewAllToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
