using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmCarsForSale : Form
    {
        DataTable carsDataTable;
        Dictionary<string, Func<IEnumerable<string>>> filterByDictionary;

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
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Listing' table. You can move, or remove it, as needed.
            this.listingTableAdapter.Fill(this.groupFinal266DataSet.Listing);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Sellers' table. You can move, or remove it, as needed.
            this.sellersTableAdapter.Fill(this.groupFinal266DataSet.Sellers);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.groupFinal266DataSet.Buyers);
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.groupFinal266DataSet.Cars);

            SetUpFilterByComboBox();
            SetUpFilterByDictionary();
        }

        private void SetUpFilterByDictionary()
        {
            carsDataTable = groupFinal266DataSet.Cars;
            filterByDictionary = new Dictionary<string, Func<IEnumerable<string>>>
            {
                { "Make", () => carsDataTable.AsEnumerable().Select(row => row.Field<string>("CarMake")).Distinct() },
                { "Model", () => carsDataTable.AsEnumerable().Select(row => row.Field<string>("CarModel")).Distinct() },
                { "Age", () => carsDataTable.AsEnumerable().Select(row => row.Field<int>("CarYear").ToString()).Distinct() },
                { "Price", () =>carsDataTable.AsEnumerable().Select(row => row.Field<decimal>("CarPrice").ToString()).Distinct() }
            };
        }

        private void SetUpFilterByComboBox()
        {
            filterByToolStripComboBox.ComboBox.Items.Add("Make");
            filterByToolStripComboBox.ComboBox.Items.Add("Color");
            filterByToolStripComboBox.ComboBox.Items.Add("Age");
            filterByToolStripComboBox.ComboBox.Items.Add("Price");

            filterByToolStripComboBox.ComboBox.SelectedIndex = 0;
            filterByToolStripComboBox.ComboBox.SelectedValue = 0;
        }

        private void filterByToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func<IEnumerable<string>> options = filterByDictionary[filterByToolStripComboBox.ComboBox.SelectedValue.ToString()];

            // Error
            /*
            foreach (var option in options)
                carPropertyStripComboBox.ComboBox.Items.Add(option.ToString());*/
        }
    }
}
