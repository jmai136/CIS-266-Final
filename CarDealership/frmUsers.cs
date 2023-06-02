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
    public partial class frmUsers : Form
    {
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

        private void PutUserRegisterData(User user)
        {
            // Grab all of the filled in textboxes for registering the user like first name, last name, email address, password
            // Assign it to the properties of user
            // Then pass this in to UserDB and have UserDB handle the data.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Put in validation here to see if it exists in the SQL database
            try
            {
                if (buyerUserNameTextBox.Text == "")
                {
                    MessageBox.Show("Please input a username", "Username not found");
                    return;
                }

                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please input a password", "Password not found");
                    return;
                }

                // Insert query here

                // Because hashes are deterministic, two same passwords will always share the same hash
                // So grab the password that you inputted, call HashPassword, pass that in, then check to see
                // If the hashed password stored in the query matches the hashed password you inputted
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
