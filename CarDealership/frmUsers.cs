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
    public partial class frmUsers : Form,  IUser, IUtility
    {
        // Temporary user
        User user = new User() { userID = -1 };

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

            txtRegisterEmail.Text = "zzm4h94sr1a@icznn.com";
            txtRegisterPassword.Text = "u3AeOX ^ 686 & h";
            txtRegisterFirstName.Text = "Hoshi";
            txtRegisterLastName.Text = "Kash";
        }

        public void AssignBusinessObjectData()
        {
            user.email = txtRegisterEmail.Text;
            user.password = txtRegisterPassword.Text;
            user.firstName = txtRegisterFirstName.Text;
            user.lastName = txtRegisterLastName.Text;
        }

        public bool PutBusinessObjectData()
        {
            try
            {
                AssignBusinessObjectData();

                // Loop through all the properties to make sure none of them are empty.
                //https://www.w3schools.blog/loop-over-object-properties-c
                // If one is empty then throw an error and return false.
                foreach (PropertyInfo property in user.GetType().GetProperties())
                    if (property.GetValue(user) == null || string.IsNullOrEmpty(property.GetValue(user).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!PutBusinessObjectData())
                return;

            UserDB userDB = new UserDB();

            if (!userDB.Upload(user, Program.sqlConnection)) {
                MessageBox.Show(userDB.MsgText, userDB.MsgCaption);
                return;
            }

            foreach (TextBox textBox in registerGroupBox.Controls.OfType<TextBox>())
                textBox.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAuthentication();
        }

        public void UserAuthentication()
        {
            // Put in validation here to see if it exists in the SQL database
            try
            {
                if (string.IsNullOrEmpty(txtSellerEmailLogin.Text))
                    throw new ArgumentException("Please input a username", "Username not found");

                if (string.IsNullOrEmpty(txtLoginPassword.Text))
                    throw new ArgumentException("Please input a password", "Password not found");

                user.email = txtSellerEmailLogin.Text;
                user.password = txtLoginPassword.Text;

                /*string msgText = "", msgCaption = "";*/

                // Insert query here
                if (UserDB.VerifyLoginUser(user, Program.sqlConnection/*, out msgText, out msgCaption*/)) {
                    EnterFormCarsForSale();
                    EnableControls(false);
                }

                // MessageBox.Show(msgText, msgCaption);

                // Because hashes are deterministic, two same passwords will always share the same hash
                // So grab the password that you inputted, call HashPassword, pass that in, then check to see
                // If the hashed password stored in the query matches the hashed password you inputted
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public void EnableControls(bool enable = true)
        {
            foreach (GroupBox groupBox in Controls)
                foreach (Control c in groupBox.Controls)
                {
                    if (c is Button)
                        c.Enabled = enable;

                    if (c is TextBox)
                        c.Enabled = enable;
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
            carsForSale.Show();
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
