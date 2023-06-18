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

        Listing listing = new Listing();
        ListingDB listingDB = new ListingDB();

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
                "$5,000-",
                "$5,000 - $9,999",
                "$10,000+"
            };

            static public Dictionary<string, List<string>> filterByDictionary = new Dictionary<string, List<string>>
            {
                { "Make", carMakes },
                { "Color", carColors },
                { "Age", carAgeRanges },
                {"Price", carPriceRanges }
            };
        }

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
            SetUpCarMakeOptions();
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

        private void SetUpCarMakeOptions()
        {
            carMakeComboBox.Items.Add("Mercedes");
            carMakeComboBox.Items.Add("BMW");
            carMakeComboBox.Items.Add("Honda");
            carMakeComboBox.Items.Add("Toyota");
        }

        private void filterByToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carPropertyStripComboBox.ComboBox.Text = "";
            carPropertyStripComboBox.ComboBox.SelectedItem = "";
            carPropertyStripComboBox.ComboBox.Items.Clear();

            string filterProperty = filterByToolStripComboBox.ComboBox.SelectedItem.ToString();
            carListingPropertyStripLabel.Text = filterProperty + ": ";

            foreach (string option in filterByStruct.filterByDictionary[filterProperty])
                carPropertyStripComboBox.ComboBox.Items.Add(option);
        }

        private void viewAllToolStripButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Program.sqlConnection;
            // Get every car in database then remove it from there
            // List<Car> cars = listingDB.GetAllCars(SellerID, sqlConnection);

            List<Car> cars = new List<Car>();

            switch (filterByToolStripComboBox.ComboBox.SelectedItem)
            {
                case "Make":
                    ListingDB.FilterByMake filterByMake = new ListingDB.FilterByMake();
                    cars = filterByMake.FilterBy(cars, carPropertyStripComboBox.ComboBox.Text.ToString(),sqlConnection);
                    break;
                case "Color":
                    ListingDB.FilterByColor filterByColor = new ListingDB.FilterByColor();
                    cars = filterByColor.FilterBy(cars, carPropertyStripComboBox.ComboBox.Text.ToString(),sqlConnection);
                    break;
                case "Age":
                    ListingDB.FilterByAge filterByAge = new ListingDB.FilterByAge();
                    cars = filterByAge.FilterBy(cars, carPropertyStripComboBox.ComboBox.Text.ToString(),sqlConnection);
                    break;
                case "Price":
                    ListingDB.FilterByPrice filterByPrice = new ListingDB.FilterByPrice();
                    cars = filterByPrice.FilterBy(cars, carPropertyStripComboBox.ComboBox.Text,sqlConnection);
                    break;
                default:
                    break;
            }

            this.groupFinal266DataSet.Cars.Clear();


            foreach (Car car in cars)
                this.groupFinal266DataSet.Cars.Rows.Add(car.carVIN, car.age, car.make, car.model, car.price, car.color, car.miles);

            // this.carsTableAdapter.Fill(this.groupFinal266DataSet.Cars);
            // Each of those CarVIN, look up those listings, select listings with those carVINs, put them in listing grid
            // Make a query, pass that in, use ANY in SQL, that should accept arrays
            // https://stackoverflow.com/questions/58217068/pass-unknown-number-of-parameters-to-in-clause-using-jdbc-and-postgres

            // Or not
            // this.groupFinal266DataSet.Listing.Rows.Clear();

            // Grab all listings based on carVIN?
            // this.groupFinal266DataSet.Listing.Rows.Add(cars.Select(x => x.carVIN));

            string carVINs = String.Join(",", cars.Select(x => x.carVIN).ToArray());

            // IN ('', '') - I guess it's time to make a stored procedure for IN, then convert the array to a joined string then pass that in as the parameter
            // Like SELECT * FROM dbo.Listings WHERE CarVIN = IN(@carVINS)
        }

        // This should be for uploading
        public void AssignBusinessObjectData()
        {
            listing.listingID = Convert.ToInt32(listingIDTextBox.Text);
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
            /*try
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
            }*/


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
