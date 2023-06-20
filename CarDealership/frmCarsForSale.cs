using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace CarDealership
{
    public partial class frmCarsForSale : Form, IUser, IUtility
    {
        int SellerID { get; set; } = -1;

        frmUsers m_frmUsers;

        private Listing listing = new Listing();
        private ListingDB listingDB = new ListingDB();

        private Mercedes<string> mercedes = new Mercedes<string>();
        private BMW<string> bmw = new BMW<string>();
        private Honda<int> honda = new Honda<int>();
        private Toyota<int> toyota = new Toyota<int>();

        private string carType;

        private CarDB carDB = new CarDB();

        private Comments comments = new Comments();
        private CommentsDB commentsDB = new CommentsDB();

        [Flags]
        public enum ModifyingCarComponents
        {
            NONE = 0,
            IS_MODIFYING_CAR = 1,
            IS_MODIFYING_LISTING = 2,
            IS_MODIFYING_COMMENTS = 3
        }

        ModifyingCarComponents modifyingCarComponents = new ModifyingCarComponents();

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

        public frmCarsForSale(int sellerID, frmUsers frmUsers)
        {
            SellerID = sellerID;
            m_frmUsers = frmUsers;

            InitializeComponent();
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
            SetUpCarMakeComboBox();

            sellerIDTextBox.Text = SellerID.ToString();

            LoadSampleCarComponents();
        }

        private void LoadSampleCarComponents()
        {
            carVINComboBox.SelectedValue = "WID28374910YU1293";
            descriptionTextBox.Text = "Seller: Hoshi Kask; Car: 2004 Toyota GT86";

            carVINTextBoxCarInfo.Text = "X";
            carYearTextBox.Text = "2001";
            carModelTextBox.Text = "";
            carColorTextBox.Text = "blue";
            carPriceTextBox.Text = "0";
            carMilesTextBox.Text = "5000";
            carFeaturesTextBox.Text = "0";

            commentsRichTextBox.Text = "Seller: Hoshi Kask; Car: 2004 Toyota GT86WID28374910YU1293";
        }

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

        private void SetUpCarMakeComboBox()
        {
            List<string> carMakes = ListingDB.GetCarPropertyFilteredByDistinctValues("CarMake", Program.sqlConnection);
            foreach (string carMake in carMakes)
                carMakeComboBox.Items.Add(carMake);
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

            this.groupFinal266DataSet.Listing.Rows.Clear();

            if (cars.Count < 1)
                return;

            List<Listing> listings = ListingDB.GetAllListings(Program.sqlConnection);

            string carVINs = String.Join("|", cars.Select(x => x.carVIN).ToArray());
            carVINs = carVINs.Trim(new Char[] { '|' });

            listings.RemoveAll(l => l.carVIN.Any(c => !Regex.IsMatch(l.carVIN, carVINs)));

            foreach (Listing listing in listings)
                this.groupFinal266DataSet.Listing.Rows.Add(listing.listingID, listing.sellerID, listing.carVIN, listing.description, listing.creationDateTime);
        }

        // This should be for uploading
        public void AssignBusinessObjectDataToUpload()
        {
            // Listing
            if ((modifyingCarComponents & ModifyingCarComponents.IS_MODIFYING_LISTING) != 0)
            {
                // Assigning auto incrementing values are just for validation checks to not throw error
                listing.listingID = 0;
                listing.sellerID = Convert.ToInt32(sellerIDTextBox.Text);
                listing.carVIN = Convert.ToString(carVINComboBox.SelectedValue);
                listing.description = descriptionTextBox.Text;
                listing.creationDateTime = Convert.ToDateTime(creationDateTimeDateTimePicker.Text);
            }

            // Car? Are we supposed to add cars? Tutor thinks so so we're gonna do that in case.
            if ((modifyingCarComponents & ModifyingCarComponents.IS_MODIFYING_CAR) != 0)
            {
                var car = ListingDB.carsCreationDictionary[carMakeComboBox.Text].Invoke();

                if (car is Mercedes<string>)
                {
                    mercedes.carVIN = carVINTextBoxCarInfo.Text;
                    mercedes.age = Convert.ToInt32(carYearTextBox.Text);
                    mercedes.make = carMakeComboBox.Text;
                    mercedes.model = carModelTextBox.Text;
                    mercedes.color = carColorTextBox.Text;
                    mercedes.price = Convert.ToDecimal(carPriceTextBox.Text);
                    mercedes.miles = Convert.ToInt32(carMilesTextBox.Text);
                    mercedes.engine = carFeaturesTextBox.Text;

                    carType = "Mercedes";
                }

                if (car is BMW<string>)
                {
                    bmw.carVIN = carVINTextBoxCarInfo.Text;
                    bmw.age = Convert.ToInt32(carYearTextBox.Text);
                    bmw.make = carMakeComboBox.Text;
                    bmw.model = carModelTextBox.Text;
                    bmw.color = carColorTextBox.Text;
                    bmw.price = Convert.ToDecimal(carPriceTextBox.Text);
                    bmw.miles = Convert.ToInt32(carMilesTextBox.Text);
                    bmw.engine = carFeaturesTextBox.Text;

                    carType = "BMW";
                }

                if (car is Honda<int>)
                {
                    honda.carVIN = carVINTextBoxCarInfo.Text;
                    honda.age = Convert.ToInt32(carYearTextBox.Text);
                    honda.make = carMakeComboBox.Text;
                    honda.model = carModelTextBox.Text;
                    honda.color = carColorTextBox.Text;
                    honda.price = Convert.ToDecimal(carPriceTextBox.Text);
                    honda.miles = Convert.ToInt32(carMilesTextBox.Text);
                    honda.mileage = Convert.ToInt32(carFeaturesTextBox.Text);

                    carType = "Honda";
                }

                if (car is Toyota<int>)
                {
                    toyota.carVIN = carVINTextBoxCarInfo.Text;
                    toyota.age = Convert.ToInt32(carYearTextBox.Text);
                    toyota.make = carMakeComboBox.Text;
                    toyota.model = carModelTextBox.Text;
                    toyota.color = carColorTextBox.Text;
                    toyota.price = Convert.ToDecimal(carPriceTextBox.Text);
                    toyota.miles = Convert.ToInt32(carMilesTextBox.Text);
                    toyota.mileage = Convert.ToInt32(carFeaturesTextBox.Text);

                    carType = "Toyota";
                }
            }

            // Comments
            // Probably should only be able to add comments for the seller that you're adding to
            if ((modifyingCarComponents & ModifyingCarComponents.IS_MODIFYING_COMMENTS) != 0)
            {
                comments.CommentsID = 0;
                comments.ListingID = Convert.ToInt32(listingIDComboBox.SelectedValue);
                comments.CommentText = commentsRichTextBox.Text;
            }

            modifyingCarComponents = ModifyingCarComponents.NONE;
        }

        public bool ValidateBusinessObjectData()
        {
            try
            {
                if ((modifyingCarComponents & ModifyingCarComponents.IS_MODIFYING_LISTING) != 0)
                {
                    foreach (PropertyInfo property in listing.GetType().GetProperties())
                        if (property.GetValue(listing) == null || string.IsNullOrEmpty(property.GetValue(listing).ToString()))
                            throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                }

                if ((modifyingCarComponents & ModifyingCarComponents.IS_MODIFYING_CAR) != 0)
                {
                    switch (carType)
                    {
                        case "Mercedes":
                            foreach (PropertyInfo property in mercedes.GetType().GetProperties())
                                if (property.GetValue(mercedes) == null || string.IsNullOrEmpty(property.GetValue(mercedes).ToString()))
                                    throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                            break;
                        case "BMW":
                            foreach (PropertyInfo property in bmw.GetType().GetProperties())
                                if (property.GetValue(bmw) == null || string.IsNullOrEmpty(property.GetValue(bmw).ToString()))
                                    throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                            break;
                        case "Toyota":
                            foreach (PropertyInfo property in toyota.GetType().GetProperties())
                                if (property.GetValue(toyota) == null || string.IsNullOrEmpty(property.GetValue(toyota).ToString()))
                                    throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                            break;
                        case "Honda":
                            foreach (PropertyInfo property in honda.GetType().GetProperties())
                                if (property.GetValue(honda) == null || string.IsNullOrEmpty(property.GetValue(honda).ToString()))
                                    throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                            break;
                    }
                }

                if ((modifyingCarComponents & ModifyingCarComponents.IS_MODIFYING_COMMENTS) != 0)
                {
                    foreach (PropertyInfo property in comments.GetType().GetProperties())
                        if (property.GetValue(comments) == null || string.IsNullOrEmpty(property.GetValue(comments).ToString()))
                            throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            return false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            modifyingCarComponents = ModifyingCarComponents.IS_MODIFYING_LISTING;

            AssignBusinessObjectDataToUpload();

            if (!ValidateBusinessObjectData())
                return;

            if (!listingDB.Upload(listing, Program.sqlConnection)) { 
                MessageBox.Show(listingDB.MsgText, listingDB.MsgCaption);
                return;
            }

            listingBindingSource.ResetBindings(true);

            // Why don't these work?
            listingDataGridView.Update();
            listingDataGridView.Refresh();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            modifyingCarComponents = ModifyingCarComponents.IS_MODIFYING_CAR;

            AssignBusinessObjectDataToUpload();

            if (!ValidateBusinessObjectData())
                return;

            switch (carType)
            {
                case "Mercedes":
                    if (!carDB.Upload(mercedes, Program.sqlConnection))
                        MessageBox.Show(carDB.MsgText, carDB.MsgCaption);
                    break;
                case "BMW":
                    if (!carDB.Upload(bmw, Program.sqlConnection))
                        MessageBox.Show(carDB.MsgText, carDB.MsgCaption);
                    break;
                case "Toyota":
                    if (!carDB.Upload(toyota, Program.sqlConnection))
                        MessageBox.Show(carDB.MsgText, carDB.MsgCaption);
                    break;
                case "Honda":
                    if (!carDB.Upload(honda, Program.sqlConnection))
                        MessageBox.Show(carDB.MsgText, carDB.MsgCaption);
                    break;
            }
        }

        public void AssignBusinessObjectDataToDelete(int rowIndex)
        {
            if (modifyingCarComponents == ModifyingCarComponents.IS_MODIFYING_LISTING)
            {
                listing.listingID = Convert.ToInt32(listingDataGridView.Rows[rowIndex].Cells[0].Value);
                listing.sellerID = Convert.ToInt32(listingDataGridView.Rows[rowIndex].Cells[1].Value);
                listing.carVIN = Convert.ToString(listingDataGridView.Rows[rowIndex].Cells[2].Value);
                listing.description = Convert.ToString(listingDataGridView.Rows[rowIndex].Cells[3].Value);
                listing.creationDateTime = Convert.ToDateTime(listingDataGridView.Rows[rowIndex].Cells[4].Value);
            }

            /*
            if (modifyingCarComponents == ModifyingCarComponents.IS_MODIFYING_CAR)
            {
                car = ListingDB.carsCreationDictionary[carMakeComboBox.Text].Invoke();
                car.carVIN = carVINTextBoxCarInfo.Text;
                car.age = Convert.ToInt32(carYearTextBox.Text);
                car.make = carMakeComboBox.Text;
                car.model = carModelTextBox.Text;
                car.color = carColorTextBox.Text;
                car.price = Convert.ToDecimal(carPriceTextBox.Text);
                car.miles = Convert.ToInt32(carMilesTextBox.Text);

                if (car is Mercedes<string>)
                    car.engine = carFeaturesTextBox.Text;

                if (car is BMW<string>)
                    car.engine = carFeaturesTextBox.Text;

                if (car is Honda<int>)
                    car.mileage = Convert.ToInt32(carFeaturesTextBox.Text);

                if (car is Toyota<int>)
                    car.mileage = Convert.ToInt32(carFeaturesTextBox.Text);
            }*/

            if (modifyingCarComponents == ModifyingCarComponents.IS_MODIFYING_COMMENTS)
            {
                comments.CommentsID = Convert.ToInt32(commentsDataGridView.Rows[rowIndex].Cells[0].Value);
                comments.CommentText = Convert.ToString(commentsDataGridView.Rows[rowIndex].Cells[1].Value);
                comments.ListingID = Convert.ToInt32(commentsDataGridView.Rows[rowIndex].Cells[2].Value);
            }

            modifyingCarComponents = ModifyingCarComponents.NONE;
        }

        private void carsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {

            }
        }

        private void listingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                modifyingCarComponents = ModifyingCarComponents.IS_MODIFYING_LISTING;

                AssignBusinessObjectDataToDelete(e.RowIndex);

                if (!ValidateBusinessObjectData())
                    return;

                if (!listingDB.Delete(listing, Program.sqlConnection)) {
                    MessageBox.Show(listingDB.MsgText, listingDB.MsgCaption);
                    return;
                }

                listingDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(listingIDComboBox.Text))
                    throw new ArgumentException("Please input a comment id", "Listing id not found");

                if (string.IsNullOrEmpty(commentsRichTextBox.Text))
                    throw new ArgumentException("Please input a comment", "Comment not found");

                modifyingCarComponents = ModifyingCarComponents.IS_MODIFYING_COMMENTS;

                AssignBusinessObjectDataToUpload();

                if (!commentsDB.Upload(comments, Program.sqlConnection))
                {
                    MessageBox.Show(commentsDB.MsgText, commentsDB.MsgCaption);
                    return;
                }

                commentsBindingSource.ResetBindings(true);

                // Why don't these work?
                commentsDataGridView.Update();
                commentsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void commentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                modifyingCarComponents = ModifyingCarComponents.IS_MODIFYING_COMMENTS;

                AssignBusinessObjectDataToDelete(e.RowIndex);

                if (!ValidateBusinessObjectData())
                    return;

                if (!commentsDB.Delete(comments, Program.sqlConnection)) {
                    MessageBox.Show(commentsDB.MsgText, commentsDB.MsgCaption);
                    return;
                }

                commentsDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void LogoutVerification()
        {
            if (MessageBox.Show("Y' sure?", "Log out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                m_frmUsers.EnableControls();
                Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogoutVerification();
        }

        private void btnUploadAll_Click(object sender, EventArgs e)
        {
            modifyingCarComponents = ModifyingCarComponents.IS_MODIFYING_CAR | ModifyingCarComponents.IS_MODIFYING_LISTING | ModifyingCarComponents.IS_MODIFYING_COMMENTS;

            AssignBusinessObjectDataToUpload();

            if (!listingDB.Upload(listing, Program.sqlConnection)) {
                MessageBox.Show(listingDB.MsgText, listingDB.MsgCaption);
                return;
            }

            if (!commentsDB.Upload(comments, Program.sqlConnection)) {
                MessageBox.Show(commentsDB.MsgText, commentsDB.MsgCaption);
                return;
            }
        }
    }
}
