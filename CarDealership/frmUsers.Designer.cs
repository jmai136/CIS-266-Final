namespace CarDealership
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblSellerEmailLogin;
            this.groupFinal266DataSet = new CarDealership.GroupFinal266DataSet();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.BuyersTableAdapter();
            this.tableAdapterManager = new CarDealership.GroupFinal266DataSetTableAdapters.TableAdapterManager();
            this.txtSellerEmailLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtRegisterLastName = new System.Windows.Forms.TextBox();
            this.txtRegisterFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.SellersTableAdapter();
            this.sellersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteUserAccount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAccountList = new System.Windows.Forms.Label();
            lblSellerEmailLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            this.loginGroupBox.SuspendLayout();
            this.registerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSellerEmailLogin
            // 
            lblSellerEmailLogin.AutoSize = true;
            lblSellerEmailLogin.Location = new System.Drawing.Point(54, 31);
            lblSellerEmailLogin.Name = "lblSellerEmailLogin";
            lblSellerEmailLogin.Size = new System.Drawing.Size(35, 13);
            lblSellerEmailLogin.TabIndex = 1;
            lblSellerEmailLogin.Text = "Email:";
            // 
            // groupFinal266DataSet
            // 
            this.groupFinal266DataSet.DataSetName = "GroupFinal266DataSet";
            this.groupFinal266DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyersTableAdapter = this.buyersTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.CommentsTableAdapter = null;
            this.tableAdapterManager.ListingTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarDealership.GroupFinal266DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtSellerEmailLogin
            // 
            this.txtSellerEmailLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerUserName", true));
            this.txtSellerEmailLogin.Location = new System.Drawing.Point(104, 28);
            this.txtSellerEmailLogin.Name = "txtSellerEmailLogin";
            this.txtSellerEmailLogin.Size = new System.Drawing.Size(100, 20);
            this.txtSellerEmailLogin.TabIndex = 2;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(30, 74);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(56, 13);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(104, 71);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtLoginPassword.TabIndex = 4;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(519, 28);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(100, 23);
            this.btnShowPassword.TabIndex = 5;
            this.btnShowPassword.Text = "Show password";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.Location = new System.Drawing.Point(519, 66);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(100, 23);
            this.btnHidePassword.TabIndex = 6;
            this.btnHidePassword.Text = "Hide password";
            this.btnHidePassword.UseVisualStyleBackColor = true;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(129, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(544, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.txtLoginPassword);
            this.loginGroupBox.Controls.Add(this.btnHidePassword);
            this.loginGroupBox.Controls.Add(this.btnLogin);
            this.loginGroupBox.Controls.Add(this.btnShowPassword);
            this.loginGroupBox.Controls.Add(this.btnCancel);
            this.loginGroupBox.Controls.Add(this.txtSellerEmailLogin);
            this.loginGroupBox.Controls.Add(lblSellerEmailLogin);
            this.loginGroupBox.Controls.Add(this.lblPasswordLogin);
            this.loginGroupBox.Location = new System.Drawing.Point(12, 198);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(646, 152);
            this.loginGroupBox.TabIndex = 9;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Controls.Add(this.lblLastName);
            this.registerGroupBox.Controls.Add(this.txtRegisterLastName);
            this.registerGroupBox.Controls.Add(this.txtRegisterFirstName);
            this.registerGroupBox.Controls.Add(this.lblFirstName);
            this.registerGroupBox.Controls.Add(this.btnRegister);
            this.registerGroupBox.Controls.Add(this.lblRegisterPassword);
            this.registerGroupBox.Controls.Add(this.txtRegisterPassword);
            this.registerGroupBox.Controls.Add(this.txtRegisterEmail);
            this.registerGroupBox.Controls.Add(this.lblRegisterEmail);
            this.registerGroupBox.Location = new System.Drawing.Point(12, 29);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Size = new System.Drawing.Size(646, 163);
            this.registerGroupBox.TabIndex = 10;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "Register";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(452, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtRegisterLastName
            // 
            this.txtRegisterLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerUserName", true));
            this.txtRegisterLastName.Location = new System.Drawing.Point(519, 64);
            this.txtRegisterLastName.Name = "txtRegisterLastName";
            this.txtRegisterLastName.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterLastName.TabIndex = 14;
            // 
            // txtRegisterFirstName
            // 
            this.txtRegisterFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerUserName", true));
            this.txtRegisterFirstName.Location = new System.Drawing.Point(519, 26);
            this.txtRegisterFirstName.Name = "txtRegisterFirstName";
            this.txtRegisterFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterFirstName.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(453, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(278, 118);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(30, 71);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(56, 13);
            this.lblRegisterPassword.TabIndex = 11;
            this.lblRegisterPassword.Text = "Password:";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerUserName", true));
            this.txtRegisterPassword.Location = new System.Drawing.Point(104, 68);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterPassword.TabIndex = 10;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerUserName", true));
            this.txtRegisterEmail.Location = new System.Drawing.Point(104, 30);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(100, 20);
            this.txtRegisterEmail.TabIndex = 9;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(51, 33);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(35, 13);
            this.lblRegisterEmail.TabIndex = 0;
            this.lblRegisterEmail.Text = "Email:";
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // sellersDataGridView
            // 
            this.sellersDataGridView.AllowUserToAddRows = false;
            this.sellersDataGridView.AutoGenerateColumns = false;
            this.sellersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.DeleteUserAccount});
            this.sellersDataGridView.DataSource = this.sellersBindingSource;
            this.sellersDataGridView.Location = new System.Drawing.Point(12, 398);
            this.sellersDataGridView.Name = "sellersDataGridView";
            this.sellersDataGridView.ReadOnly = true;
            this.sellersDataGridView.Size = new System.Drawing.Size(646, 266);
            this.sellersDataGridView.TabIndex = 10;
            this.sellersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SellerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SellerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DeleteUserAccount
            // 
            this.DeleteUserAccount.HeaderText = "";
            this.DeleteUserAccount.Name = "DeleteUserAccount";
            this.DeleteUserAccount.ReadOnly = true;
            this.DeleteUserAccount.Text = "Delete";
            this.DeleteUserAccount.UseColumnTextForButtonValue = true;
            // 
            // lblAccountList
            // 
            this.lblAccountList.AutoSize = true;
            this.lblAccountList.Location = new System.Drawing.Point(9, 373);
            this.lblAccountList.Name = "lblAccountList";
            this.lblAccountList.Size = new System.Drawing.Size(66, 13);
            this.lblAccountList.TabIndex = 11;
            this.lblAccountList.Text = "Account List";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 676);
            this.Controls.Add(this.lblAccountList);
            this.Controls.Add(this.sellersDataGridView);
            this.Controls.Add(this.registerGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupFinal266DataSet groupFinal266DataSet;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private GroupFinal266DataSetTableAdapters.BuyersTableAdapter buyersTableAdapter;
        private GroupFinal266DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtSellerEmailLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtRegisterLastName;
        private System.Windows.Forms.TextBox txtRegisterFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private GroupFinal266DataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.DataGridView sellersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteUserAccount;
        private System.Windows.Forms.Label lblAccountList;
    }
}