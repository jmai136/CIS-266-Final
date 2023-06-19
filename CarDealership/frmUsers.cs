using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealership.GroupFinal266DataSetTableAdapters;
using CarLibrary;
using PagedList;

namespace CarDealership
{
    public partial class frmUsers : Form, IUser, IUtility
    {
        User user = new User() { userID = -1 };
        UserDB userDB = new UserDB();

        int startRecord = 0;

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
            PaginationSetUp(Program.sqlConnection);

            // TODO: This line of code loads data into the 'groupFinal266DataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.groupFinal266DataSet.Buyers);

            LoadSampleUsers();
        }

        private void LoadSampleUsers()
        {
            txtRegisterEmail.Text = "zzm4h94sr1a@icznn.com";
            txtRegisterPassword.Text = "u3AeOX ^ 686 & h";
            txtRegisterFirstName.Text = "Nanna";
            txtRegisterLastName.Text = "Maric";

            txtSellerEmailLogin.Text = "zzm4h94sr1a@icznn.com";
            txtLoginPassword.Text = "u3AeOX ^ 686 & h";
        }

        private bool PaginationSetUp(SqlConnection sqlConnection)
        {
            try
            {
                sellersTableAdapter.Adapter.SelectCommand = new SqlCommand("SELECT * FROM Sellers", sqlConnection);
                sqlConnection.Open();

                sellersTableAdapter.Adapter.Fill(this.groupFinal266DataSet, startRecord, 5, "PaginatedSellersDataTable");

                sellersDataGridView.DataSource = this.groupFinal266DataSet;
                sellersDataGridView.DataMember = "PaginatedSellersDataTable";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            startRecord -= 5;

            if (startRecord <= 0)
                startRecord = 0;

            this.groupFinal266DataSet.Clear();
            sellersTableAdapter.Adapter.Fill(this.groupFinal266DataSet, startRecord, 5, "PaginatedSellersDataTable");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlConnection sqlConnection = Program.sqlConnection;

            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM [GroupFinal266].[dbo].[Sellers]", sqlConnection);
            sqlConnection.Open();
            count = Convert.ToInt32(cmdCount.ExecuteScalar());

            sqlConnection.Close();

            startRecord += 5;
            
            if (startRecord > count) {
                startRecord -= 5;
            }

            this.groupFinal266DataSet.Clear();
            sellersTableAdapter.Adapter.Fill(this.groupFinal266DataSet, startRecord, 5, "PaginatedSellersDataTable");
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

            if (!userDB.Upload(user, Program.sqlConnection)) {
                MessageBox.Show(userDB.MsgText, userDB.MsgCaption);
                return;
            }

            MessageBox.Show(userDB.MsgText, userDB.MsgCaption);

            foreach (TextBox textBox in registerGroupBox.Controls.OfType<TextBox>())
                textBox.Clear();

            sellersDataGridView.Update();
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

                // Because hashes are deterministic, two same passwords will always share the same hash
                if (!userDB.VerifyLoginUser(user, Program.sqlConnection))
                    MessageBox.Show(userDB.MsgText, userDB.MsgCaption);

                EnterFormCarsForSale();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        public void EnableControls(bool enable = true)
        {
            btnPreviousPage.Enabled = enable;
            btnNextPage.Enabled = enable;

            // Why is it attempting to convert here?
            foreach (GroupBox groupBox in Controls.OfType<GroupBox>())
                foreach (Control c in groupBox.Controls)
                {
                    if (c is Button)
                        c.Enabled = enable;

                    if (c is TextBox)
                        c.Enabled = enable;
                }

            this.sellersDataGridView.Columns["DeleteUserAccount"].Visible = enable;
        }

        private void EnterFormCarsForSale()
        {
            // Check if int is null or empty
            if (string.IsNullOrEmpty(user.userID.ToString()) || user.userID <= 0)
                return;

            // Probably go to the new form then using the user?
            // Maybe we do need an argument constructor
            frmCarsForSale carsForSale = new frmCarsForSale(user.userID, this);
            carsForSale.Show();

            // Make a delegate to enable controls in Program.cs, Program.cs will be our singleton
            EnableControls(false);
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

        private void sellersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                user.userID = Convert.ToInt32(sellersDataGridView.Rows[e.RowIndex].Cells[0].Value);
                user.firstName = Convert.ToString(sellersDataGridView.Rows[e.RowIndex].Cells[1].Value);
                user.lastName = Convert.ToString(sellersDataGridView.Rows[e.RowIndex].Cells[2].Value);
                user.email = Convert.ToString(sellersDataGridView.Rows[e.RowIndex].Cells[3].Value);
                user.password = Convert.ToString(sellersDataGridView.Rows[e.RowIndex].Cells[4].Value);

                userDB.Delete(user, Program.sqlConnection);

                sellersDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
