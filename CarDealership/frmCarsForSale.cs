using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace CarDealership
{
    public partial class frmCarsForSale : Form, IUser, IUtility
    {
        int SellerID { get; set; } = -1;

        struct filterByStruct
        {
            // Grab the other structs then use commands to filter

            static private List<string> carMakes = ListingDB.GetCarPropertyFilteredByDistinctValues("CarMake", Program.sqlConnection);
            static private List<string> carColors = ListingDB.GetCarPropertyFilteredByDistinctValues("CarColor", Program.sqlConnection);

            static private List<string> carAgeRanges = new List<string>
            {
                "1969-",
                "1969-1994",
                "1994-2001",
                "2001-2012",
                "2012-2022",
                "2022+"
            };

            static private List<string> carPriceRanges = new List<string>
            {
                "$5000-",
                "$5000 - 9,999",
                "$10,000"
            };

            static public Dictionary<string, List<string>> filterByDictionary = new Dictionary<string, List<string>>
            {
                { "Make", carMakes },
                { "Color", carColors },
                { "Age", carAgeRanges },
                {"Price", carPriceRanges }
            };
        }

        Listing listing = new Listing();

        public frmCarsForSale()
        {
            InitializeComponent();
        }

        public frmCarsForSale(int sellerID)
        {
            SellerID = sellerID;
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

            UserAuthentication();

            SetUpFilterByComboBox();
        }

        // Authenticate first, if the authentication fails, then closes the form.
        public void UserAuthentication()
        {
            UserDB userDB = new UserDB();
            if (!userDB.VerifyLoginUser(SellerID, Program.sqlConnection)) {
                MessageBox.Show(userDB.MsgText, userDB.MsgCaption);
                Close();
            }
        }

        // Might be unnecessary
        public void EnableControls(bool enable = true)
        {
            foreach (Control c in Controls)
            {
                if (c is ComboBox || c is Button)
                    c.Enabled = enable;
            }
        }

        private void SetUpFilterByComboBox()
        {
            filterByToolStripComboBox.ComboBox.Items.Add("Make");
            filterByToolStripComboBox.ComboBox.Items.Add("Color");
            filterByToolStripComboBox.ComboBox.Items.Add("Age");
            filterByToolStripComboBox.ComboBox.Items.Add("Price");
        }

        private void filterByToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carPropertyStripComboBox.ComboBox.SelectedItem = "";
            carPropertyStripComboBox.ComboBox.Items.Clear();

            string filterProperty = filterByToolStripComboBox.ComboBox.SelectedItem.ToString();
            carListingPropertyStripLabel.Text = filterProperty + ": ";

            foreach (string option in filterByStruct.filterByDictionary[filterProperty])
                carPropertyStripComboBox.ComboBox.Items.Add(option);
        }

        private void viewAllToolStripButton_Click(object sender, EventArgs e)
        {

        }

        // This should be for uploading
        public void AssignBusinessObjectData()
        {
            throw new NotImplementedException();
        }

        public bool PutBusinessObjectData()
        {
            throw new NotImplementedException();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            /*
            AssignBusinessObjectData();

            PutBusinessObjectData();*/

            // Works fine
            /*
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.sqlConnection;

                cmd.CommandText =
                    "IF NOT EXISTS " +
                        "(SELECT TOP 1 CarVIN FROM Cars " +
                            "WHERE CarVIN = @CarVIN) " +
                        "BEGIN " +
                            "INSERT INTO Cars (CarVIN, CarYear, CarMake, CarModel, CarPrice, CarColor, CarMiles)  " +
                            "VALUES (@CarVIN, @CarYear, @CarMake, @CarModel, @CarPrice, @CarColor, @CarMiles)" +
                        "END ";

                cmd.Parameters.AddWithValue("@CarVIN", "1HGCG1650Y1081994");
                cmd.Parameters.AddWithValue("@CarYear", 2000);
                cmd.Parameters.AddWithValue("@CarMake", "Honda");
                cmd.Parameters.AddWithValue("@CarModel", "2000 Honda Accord");
                cmd.Parameters.AddWithValue("@CarPrice", 169.40);
                cmd.Parameters.AddWithValue("@CarColor", "Black");
                cmd.Parameters.AddWithValue("@CarMiles", 6843.50);

                Program.sqlConnection.Open();

                MessageBox.Show(cmd.ExecuteScalar().ToString(), "Execute scalar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Program.sqlConnection.Close();
            }*/

            // Does not work due to Seller constraint
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.sqlConnection;

                cmd.CommandText =
                    "IF NOT EXISTS " +
                        "(SELECT TOP 1 ListingID FROM Listing " +
                            "WHERE CarVIN = @CarVIN) " +
                        "BEGIN " +
                            "INSERT INTO Listing (SellerID, CarVIN)  " +
                            "VALUES (@SellerID, @CarVIN)" +
                        "END ";

                cmd.Parameters.AddWithValue("@SellerID", 1);
                cmd.Parameters.AddWithValue("@CarVIN", "4JGBB5GB6BA625034");

                Program.sqlConnection.Open();
                MessageBox.Show(cmd.ExecuteScalar().ToString(), "Execute scalar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Program.sqlConnection.Close();
            }
        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(commentIDTextBox.Text))
                    throw new ArgumentException("Please input a comment id", "Comment id not found");

                if (string.IsNullOrEmpty(commentIDTextBox.Text))
                    throw new ArgumentException("Please input a listing id", "Listing id not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            EnableControls(false);

            if (MessageBox.Show("Y' sure?", "Log out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
            else
            {
                EnableControls();
            }
        }
    }
}
