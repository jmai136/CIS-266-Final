using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class frmUsers : Form
    {
        // Temporary user
        User user = new User();

        public frmUsers()
        {
            InitializeComponent();
        }

        private void buyersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buyersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupFinal266DataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupFinal266DataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.groupFinal266DataSet.Buyers);
        }

        private void AssignUserRegistrationData(User user)
        {
            user.email = txtRegisterEmail.Text;
            user.password = txtRegisterPassword.Text;
            user.firstName = txtRegisterFirstName.Text;
            user.lastName = txtRegisterLastName.Text;
        }

        private bool PutUserRegisterData(User user)
        {
            try
            {
                // Temporary values for userID and CarVIN, because they'd need to be updated later
                user.userID = 0;
                user.carVIN = "VIN";

                AssignUserRegistrationData(user);

                // Loop through all the properties to make sure none of them are empty.
                //https://www.w3schools.blog/loop-over-object-properties-c
                // If one is empty then throw an error and return false.
                foreach (PropertyInfo property in user.GetType().GetProperties())
                    if (property.GetValue(user) != null && string.IsNullOrEmpty(property.GetValue(user).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            return false;

            // Then pass User in to UserDB and have UserDB handle the data if registered data is true.
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!PutUserRegisterData(user))
                return;

            if (!UserDB.RegisterUser(user, Program.sqlConnection)) {
                MessageBox.Show("User already exists.", "Invalid registration");
                return;
            }

            foreach (TextBox textBox in registerGroupBox.Controls.OfType<TextBox>())
                textBox.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Put in validation here to see if it exists in the SQL database
            try
            {
                if (string.IsNullOrEmpty(txtSellerEmailLogin.Text))
                    throw new ArgumentException("Please input a username", "Username not found");

                if (string.IsNullOrEmpty(txtLoginPassword.Text))
                    throw new ArgumentException("Please input a password", "Password not found");

                // Insert query here
                UserDB.VerifyLoginUser(user, Program.sqlConnection);

                // Because hashes are deterministic, two same passwords will always share the same hash
                // So grab the password that you inputted, call HashPassword, pass that in, then check to see
                // If the hashed password stored in the query matches the hashed password you inputted

                EnterFormCarsForSale();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void EnterFormCarsForSale()
        {
            // Check if int is null or empty
            if (string.IsNullOrEmpty(user.userID.ToString()) || user.userID == -1)
                return;

            int sellerID = user.userID;

            // Probably go to the new form then using the user?
            // Maybe we do need an argument constructor
            frmCarsForSale carsForSale = new frmCarsForSale();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtRegisterPassword.UseSystemPasswordChar || txtLoginPassword.UseSystemPasswordChar)
            {
                txtRegisterPassword.UseSystemPasswordChar = false;
                txtLoginPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            if (!txtRegisterPassword.UseSystemPasswordChar || !txtLoginPassword.UseSystemPasswordChar)
            {
                txtRegisterPassword.UseSystemPasswordChar = true;
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
