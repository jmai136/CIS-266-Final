namespace CarDealership
{
    partial class frmCarsForSale
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
            System.Windows.Forms.Label buyerIDLabel;
            System.Windows.Forms.Label buyerFNameLabel;
            System.Windows.Forms.Label buyerLNameLabel;
            System.Windows.Forms.Label sellerIDLabel;
            System.Windows.Forms.Label listingIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarsForSale));
            this.groupFinal266DataSet = new CarDealership.GroupFinal266DataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new CarDealership.GroupFinal266DataSetTableAdapters.TableAdapterManager();
            this.buyersTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.BuyersTableAdapter();
            this.listingTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.ListingTableAdapter();
            this.sellersTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.SellersTableAdapter();
            this.carsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.filterByToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.filterByToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.filterToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.carListingPropertyStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.carPropertyStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.viewAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyerIDTextBox = new System.Windows.Forms.TextBox();
            this.buyerFNameTextBox = new System.Windows.Forms.TextBox();
            this.buyerLNameTextBox = new System.Windows.Forms.TextBox();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerIDTextBox = new System.Windows.Forms.TextBox();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listingIDTextBox = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.CommentsTableAdapter();
            this.commentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buyerIDLabel = new System.Windows.Forms.Label();
            buyerFNameLabel = new System.Windows.Forms.Label();
            buyerLNameLabel = new System.Windows.Forms.Label();
            sellerIDLabel = new System.Windows.Forms.Label();
            listingIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).BeginInit();
            this.carsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buyerIDLabel
            // 
            buyerIDLabel.AutoSize = true;
            buyerIDLabel.Location = new System.Drawing.Point(51, 119);
            buyerIDLabel.Name = "buyerIDLabel";
            buyerIDLabel.Size = new System.Drawing.Size(51, 13);
            buyerIDLabel.TabIndex = 2;
            buyerIDLabel.Text = "Buyer ID:";
            // 
            // buyerFNameLabel
            // 
            buyerFNameLabel.AutoSize = true;
            buyerFNameLabel.Location = new System.Drawing.Point(8, 168);
            buyerFNameLabel.Name = "buyerFNameLabel";
            buyerFNameLabel.Size = new System.Drawing.Size(90, 13);
            buyerFNameLabel.TabIndex = 4;
            buyerFNameLabel.Text = "Buyer First Name:";
            // 
            // buyerLNameLabel
            // 
            buyerLNameLabel.AutoSize = true;
            buyerLNameLabel.Location = new System.Drawing.Point(11, 216);
            buyerLNameLabel.Name = "buyerLNameLabel";
            buyerLNameLabel.Size = new System.Drawing.Size(91, 13);
            buyerLNameLabel.TabIndex = 6;
            buyerLNameLabel.Text = "Buyer Last Name:";
            // 
            // sellerIDLabel
            // 
            sellerIDLabel.AutoSize = true;
            sellerIDLabel.Location = new System.Drawing.Point(48, 82);
            sellerIDLabel.Name = "sellerIDLabel";
            sellerIDLabel.Size = new System.Drawing.Size(50, 13);
            sellerIDLabel.TabIndex = 8;
            sellerIDLabel.Text = "Seller ID:";
            // 
            // listingIDLabel
            // 
            listingIDLabel.AutoSize = true;
            listingIDLabel.Location = new System.Drawing.Point(48, 49);
            listingIDLabel.Name = "listingIDLabel";
            listingIDLabel.Size = new System.Drawing.Size(54, 13);
            listingIDLabel.TabIndex = 10;
            listingIDLabel.Text = "Listing ID:";
            // 
            // groupFinal266DataSet
            // 
            this.groupFinal266DataSet.DataSetName = "GroupFinal266DataSet";
            this.groupFinal266DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyersTableAdapter = this.buyersTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.CommentsTableAdapter = null;
            this.tableAdapterManager.ListingTableAdapter = this.listingTableAdapter;
            this.tableAdapterManager.SellersTableAdapter = this.sellersTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarDealership.GroupFinal266DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // listingTableAdapter
            // 
            this.listingTableAdapter.ClearBeforeFill = true;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // carsBindingNavigator
            // 
            this.carsBindingNavigator.AddNewItem = null;
            this.carsBindingNavigator.BindingSource = this.carsBindingSource;
            this.carsBindingNavigator.CountItem = null;
            this.carsBindingNavigator.DeleteItem = null;
            this.carsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByToolStripLabel,
            this.filterByToolStripComboBox,
            this.filterToolStripSeparator,
            this.carListingPropertyStripLabel,
            this.carPropertyStripComboBox,
            this.viewAllToolStripButton});
            this.carsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carsBindingNavigator.MoveFirstItem = null;
            this.carsBindingNavigator.MoveLastItem = null;
            this.carsBindingNavigator.MoveNextItem = null;
            this.carsBindingNavigator.MovePreviousItem = null;
            this.carsBindingNavigator.Name = "carsBindingNavigator";
            this.carsBindingNavigator.PositionItem = null;
            this.carsBindingNavigator.Size = new System.Drawing.Size(810, 25);
            this.carsBindingNavigator.TabIndex = 0;
            this.carsBindingNavigator.Text = "bindingNavigator1";
            // 
            // filterByToolStripLabel
            // 
            this.filterByToolStripLabel.Name = "filterByToolStripLabel";
            this.filterByToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.filterByToolStripLabel.Text = "Filter By:";
            // 
            // filterByToolStripComboBox
            // 
            this.filterByToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByToolStripComboBox.Name = "filterByToolStripComboBox";
            this.filterByToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.filterByToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.filterByToolStripComboBox_SelectedIndexChanged);
            // 
            // filterToolStripSeparator
            // 
            this.filterToolStripSeparator.Name = "filterToolStripSeparator";
            this.filterToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // carListingPropertyStripLabel
            // 
            this.carListingPropertyStripLabel.Name = "carListingPropertyStripLabel";
            this.carListingPropertyStripLabel.Size = new System.Drawing.Size(146, 22);
            this.carListingPropertyStripLabel.Text = "Car Listing Property Filter: ";
            // 
            // carPropertyStripComboBox
            // 
            this.carPropertyStripComboBox.Name = "carPropertyStripComboBox";
            this.carPropertyStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // viewAllToolStripButton
            // 
            this.viewAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("viewAllToolStripButton.Image")));
            this.viewAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewAllToolStripButton.Name = "viewAllToolStripButton";
            this.viewAllToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.viewAllToolStripButton.Text = "View All";
            this.viewAllToolStripButton.Click += new System.EventHandler(this.viewAllToolStripButton_Click);
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.carsDataGridView.DataSource = this.carsBindingSource;
            this.carsDataGridView.Location = new System.Drawing.Point(14, 254);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.Size = new System.Drawing.Size(776, 158);
            this.carsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarVIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarVIN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarYear";
            this.dataGridViewTextBoxColumn2.HeaderText = "CarYear";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CarMake";
            this.dataGridViewTextBoxColumn3.HeaderText = "CarMake";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CarModel";
            this.dataGridViewTextBoxColumn4.HeaderText = "CarModel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CarColor";
            this.dataGridViewTextBoxColumn6.HeaderText = "CarColor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CarMiles";
            this.dataGridViewTextBoxColumn7.HeaderText = "CarMiles";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // buyerIDTextBox
            // 
            this.buyerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerID", true));
            this.buyerIDTextBox.Location = new System.Drawing.Point(108, 119);
            this.buyerIDTextBox.Name = "buyerIDTextBox";
            this.buyerIDTextBox.ReadOnly = true;
            this.buyerIDTextBox.Size = new System.Drawing.Size(190, 20);
            this.buyerIDTextBox.TabIndex = 3;
            // 
            // buyerFNameTextBox
            // 
            this.buyerFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerFName", true));
            this.buyerFNameTextBox.Location = new System.Drawing.Point(108, 161);
            this.buyerFNameTextBox.Name = "buyerFNameTextBox";
            this.buyerFNameTextBox.ReadOnly = true;
            this.buyerFNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.buyerFNameTextBox.TabIndex = 5;
            // 
            // buyerLNameTextBox
            // 
            this.buyerLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerLName", true));
            this.buyerLNameTextBox.Location = new System.Drawing.Point(110, 213);
            this.buyerLNameTextBox.Name = "buyerLNameTextBox";
            this.buyerLNameTextBox.ReadOnly = true;
            this.buyerLNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.buyerLNameTextBox.TabIndex = 7;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // sellerIDTextBox
            // 
            this.sellerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "SellerID", true));
            this.sellerIDTextBox.Location = new System.Drawing.Point(108, 75);
            this.sellerIDTextBox.Name = "sellerIDTextBox";
            this.sellerIDTextBox.ReadOnly = true;
            this.sellerIDTextBox.Size = new System.Drawing.Size(192, 20);
            this.sellerIDTextBox.TabIndex = 9;
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "FK_Listing_Sellers";
            this.listingBindingSource.DataSource = this.sellersBindingSource;
            // 
            // listingIDTextBox
            // 
            this.listingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "ListingID", true));
            this.listingIDTextBox.Location = new System.Drawing.Point(110, 42);
            this.listingIDTextBox.Name = "listingIDTextBox";
            this.listingIDTextBox.ReadOnly = true;
            this.listingIDTextBox.Size = new System.Drawing.Size(190, 20);
            this.listingIDTextBox.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(585, 430);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 30);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(715, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(715, 466);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(75, 35);
            this.btnComments.TabIndex = 14;
            this.btnComments.Text = "Comments";
            this.btnComments.UseVisualStyleBackColor = true;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // commentsDataGridView
            // 
            this.commentsDataGridView.AutoGenerateColumns = false;
            this.commentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8});
            this.commentsDataGridView.DataSource = this.commentsBindingSource;
            this.commentsDataGridView.Location = new System.Drawing.Point(11, 443);
            this.commentsDataGridView.Name = "commentsDataGridView";
            this.commentsDataGridView.Size = new System.Drawing.Size(417, 291);
            this.commentsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CommentText";
            this.dataGridViewTextBoxColumn8.HeaderText = "CommentText";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmCarsForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 716);
            this.Controls.Add(this.commentsDataGridView);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(listingIDLabel);
            this.Controls.Add(this.listingIDTextBox);
            this.Controls.Add(sellerIDLabel);
            this.Controls.Add(this.sellerIDTextBox);
            this.Controls.Add(buyerLNameLabel);
            this.Controls.Add(this.buyerLNameTextBox);
            this.Controls.Add(buyerFNameLabel);
            this.Controls.Add(this.buyerFNameTextBox);
            this.Controls.Add(buyerIDLabel);
            this.Controls.Add(this.buyerIDTextBox);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.carsBindingNavigator);
            this.Name = "frmCarsForSale";
            this.Text = "Cars For Sale";
            this.Load += new System.EventHandler(this.frmCarsForSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).EndInit();
            this.carsBindingNavigator.ResumeLayout(false);
            this.carsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupFinal266DataSet groupFinal266DataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private GroupFinal266DataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private GroupFinal266DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carsBindingNavigator;
        private GroupFinal266DataSetTableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private System.Windows.Forms.TextBox buyerIDTextBox;
        private System.Windows.Forms.TextBox buyerFNameTextBox;
        private System.Windows.Forms.TextBox buyerLNameTextBox;
        private GroupFinal266DataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private GroupFinal266DataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private System.Windows.Forms.TextBox sellerIDTextBox;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private System.Windows.Forms.TextBox listingIDTextBox;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.ToolStripLabel filterByToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox filterByToolStripComboBox;
        private System.Windows.Forms.ToolStripButton viewAllToolStripButton;
        private System.Windows.Forms.ToolStripLabel carListingPropertyStripLabel;
        private System.Windows.Forms.ToolStripComboBox carPropertyStripComboBox;
        private System.Windows.Forms.ToolStripSeparator filterToolStripSeparator;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private GroupFinal266DataSetTableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridView commentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

