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
            System.Windows.Forms.Label listingIDLabel;
            System.Windows.Forms.Label sellerIDLabel;
            System.Windows.Forms.Label carVINLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label creationDateTimeLabel;
            System.Windows.Forms.Label commentIDLabel;
            System.Windows.Forms.Label commentTextLabel;
            System.Windows.Forms.Label listingIDLabel1;
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
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.CommentsTableAdapter();
            this.commentsDataGridView = new System.Windows.Forms.DataGridView();
            this.CommentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.listingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editListingGroupBox = new System.Windows.Forms.GroupBox();
            this.listingIDTextBox = new System.Windows.Forms.TextBox();
            this.sellerIDTextBox = new System.Windows.Forms.TextBox();
            this.carVINTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.creationDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentIDTextBox = new System.Windows.Forms.TextBox();
            this.listingIDTextBox1 = new System.Windows.Forms.TextBox();
            this.tabCommentsInfo = new System.Windows.Forms.TabControl();
            this.commentsGeneralTab = new System.Windows.Forms.TabPage();
            this.commentsInfoTab = new System.Windows.Forms.TabPage();
            this.btnSubmitComment = new System.Windows.Forms.Button();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            listingIDLabel = new System.Windows.Forms.Label();
            sellerIDLabel = new System.Windows.Forms.Label();
            carVINLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            creationDateTimeLabel = new System.Windows.Forms.Label();
            commentIDLabel = new System.Windows.Forms.Label();
            commentTextLabel = new System.Windows.Forms.Label();
            listingIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).BeginInit();
            this.carsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            this.editListingGroupBox.SuspendLayout();
            this.tabCommentsInfo.SuspendLayout();
            this.commentsGeneralTab.SuspendLayout();
            this.commentsInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // listingIDLabel
            // 
            listingIDLabel.AutoSize = true;
            listingIDLabel.Location = new System.Drawing.Point(6, 22);
            listingIDLabel.Name = "listingIDLabel";
            listingIDLabel.Size = new System.Drawing.Size(54, 13);
            listingIDLabel.TabIndex = 14;
            listingIDLabel.Text = "Listing ID:";
            // 
            // sellerIDLabel
            // 
            sellerIDLabel.AutoSize = true;
            sellerIDLabel.Location = new System.Drawing.Point(6, 48);
            sellerIDLabel.Name = "sellerIDLabel";
            sellerIDLabel.Size = new System.Drawing.Size(50, 13);
            sellerIDLabel.TabIndex = 16;
            sellerIDLabel.Text = "Seller ID:";
            // 
            // carVINLabel
            // 
            carVINLabel.AutoSize = true;
            carVINLabel.Location = new System.Drawing.Point(6, 74);
            carVINLabel.Name = "carVINLabel";
            carVINLabel.Size = new System.Drawing.Size(47, 13);
            carVINLabel.TabIndex = 18;
            carVINLabel.Text = "Car VIN:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 100);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Description:";
            // 
            // creationDateTimeLabel
            // 
            creationDateTimeLabel.AutoSize = true;
            creationDateTimeLabel.Location = new System.Drawing.Point(6, 127);
            creationDateTimeLabel.Name = "creationDateTimeLabel";
            creationDateTimeLabel.Size = new System.Drawing.Size(101, 13);
            creationDateTimeLabel.TabIndex = 22;
            creationDateTimeLabel.Text = "Creation Date Time:";
            // 
            // commentIDLabel
            // 
            commentIDLabel.AutoSize = true;
            commentIDLabel.Location = new System.Drawing.Point(34, 90);
            commentIDLabel.Name = "commentIDLabel";
            commentIDLabel.Size = new System.Drawing.Size(68, 13);
            commentIDLabel.TabIndex = 0;
            commentIDLabel.Text = "Comment ID:";
            // 
            // commentTextLabel
            // 
            commentTextLabel.AutoSize = true;
            commentTextLabel.Location = new System.Drawing.Point(3, 13);
            commentTextLabel.Name = "commentTextLabel";
            commentTextLabel.Size = new System.Drawing.Size(78, 13);
            commentTextLabel.TabIndex = 2;
            commentTextLabel.Text = "Comment Text:";
            // 
            // listingIDLabel1
            // 
            listingIDLabel1.AutoSize = true;
            listingIDLabel1.Location = new System.Drawing.Point(48, 122);
            listingIDLabel1.Name = "listingIDLabel1";
            listingIDLabel1.Size = new System.Drawing.Size(54, 13);
            listingIDLabel1.TabIndex = 4;
            listingIDLabel1.Text = "Listing ID:";
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
            this.carsBindingNavigator.Size = new System.Drawing.Size(1259, 25);
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
            this.carsDataGridView.AllowUserToAddRows = false;
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
            this.carsDataGridView.Location = new System.Drawing.Point(446, 266);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.Size = new System.Drawing.Size(776, 165);
            this.carsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarVIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarVIN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarYear";
            this.dataGridViewTextBoxColumn2.HeaderText = "CarYear";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CarMake";
            this.dataGridViewTextBoxColumn3.HeaderText = "CarMake";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CarModel";
            this.dataGridViewTextBoxColumn4.HeaderText = "CarModel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CarColor";
            this.dataGridViewTextBoxColumn6.HeaderText = "CarColor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CarMiles";
            this.dataGridViewTextBoxColumn7.HeaderText = "CarMiles";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.groupFinal266DataSet;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(32, 152);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 30);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(131, 152);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(75, 30);
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
            this.commentsDataGridView.AllowUserToAddRows = false;
            this.commentsDataGridView.AutoGenerateColumns = false;
            this.commentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentID,
            this.dataGridViewTextBoxColumn8,
            this.ListingID});
            this.commentsDataGridView.DataSource = this.commentsBindingSource;
            this.commentsDataGridView.Location = new System.Drawing.Point(446, 447);
            this.commentsDataGridView.Name = "commentsDataGridView";
            this.commentsDataGridView.ReadOnly = true;
            this.commentsDataGridView.Size = new System.Drawing.Size(779, 202);
            this.commentsDataGridView.TabIndex = 15;
            // 
            // CommentID
            // 
            this.CommentID.DataPropertyName = "CommentID";
            this.CommentID.HeaderText = "CommentID";
            this.CommentID.Name = "CommentID";
            this.CommentID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CommentText";
            this.dataGridViewTextBoxColumn8.HeaderText = "CommentText";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ListingID
            // 
            this.ListingID.DataPropertyName = "ListingID";
            this.ListingID.HeaderText = "ListingID";
            this.ListingID.Name = "ListingID";
            this.ListingID.ReadOnly = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1147, 33);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // listingDataGridView
            // 
            this.listingDataGridView.AllowUserToAddRows = false;
            this.listingDataGridView.AutoGenerateColumns = false;
            this.listingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.CreationDateTime});
            this.listingDataGridView.DataSource = this.listingBindingSource;
            this.listingDataGridView.Location = new System.Drawing.Point(446, 62);
            this.listingDataGridView.Name = "listingDataGridView";
            this.listingDataGridView.ReadOnly = true;
            this.listingDataGridView.Size = new System.Drawing.Size(776, 188);
            this.listingDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ListingID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ListingID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SellerID";
            this.dataGridViewTextBoxColumn10.HeaderText = "SellerID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CarVIN";
            this.dataGridViewTextBoxColumn11.HeaderText = "CarVIN";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn12.HeaderText = "Description";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // CreationDateTime
            // 
            this.CreationDateTime.DataPropertyName = "CreationDateTime";
            this.CreationDateTime.HeaderText = "CreationDateTime";
            this.CreationDateTime.Name = "CreationDateTime";
            this.CreationDateTime.ReadOnly = true;
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "FK_Listing_Sellers";
            this.listingBindingSource.DataSource = this.sellersBindingSource;
            // 
            // editListingGroupBox
            // 
            this.editListingGroupBox.Controls.Add(listingIDLabel);
            this.editListingGroupBox.Controls.Add(this.listingIDTextBox);
            this.editListingGroupBox.Controls.Add(sellerIDLabel);
            this.editListingGroupBox.Controls.Add(this.sellerIDTextBox);
            this.editListingGroupBox.Controls.Add(carVINLabel);
            this.editListingGroupBox.Controls.Add(this.carVINTextBox);
            this.editListingGroupBox.Controls.Add(descriptionLabel);
            this.editListingGroupBox.Controls.Add(this.descriptionTextBox);
            this.editListingGroupBox.Controls.Add(creationDateTimeLabel);
            this.editListingGroupBox.Controls.Add(this.creationDateTimeDateTimePicker);
            this.editListingGroupBox.Controls.Add(this.btnComments);
            this.editListingGroupBox.Controls.Add(this.btnUpload);
            this.editListingGroupBox.Controls.Add(this.btnDelete);
            this.editListingGroupBox.Location = new System.Drawing.Point(12, 62);
            this.editListingGroupBox.Name = "editListingGroupBox";
            this.editListingGroupBox.Size = new System.Drawing.Size(338, 188);
            this.editListingGroupBox.TabIndex = 17;
            this.editListingGroupBox.TabStop = false;
            this.editListingGroupBox.Text = "Edit Listing";
            // 
            // listingIDTextBox
            // 
            this.listingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "ListingID", true));
            this.listingIDTextBox.Location = new System.Drawing.Point(113, 19);
            this.listingIDTextBox.Name = "listingIDTextBox";
            this.listingIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.listingIDTextBox.TabIndex = 15;
            // 
            // sellerIDTextBox
            // 
            this.sellerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "SellerID", true));
            this.sellerIDTextBox.Location = new System.Drawing.Point(113, 45);
            this.sellerIDTextBox.Name = "sellerIDTextBox";
            this.sellerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.sellerIDTextBox.TabIndex = 17;
            // 
            // carVINTextBox
            // 
            this.carVINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "CarVIN", true));
            this.carVINTextBox.Location = new System.Drawing.Point(113, 71);
            this.carVINTextBox.Name = "carVINTextBox";
            this.carVINTextBox.Size = new System.Drawing.Size(200, 20);
            this.carVINTextBox.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(113, 97);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // creationDateTimeDateTimePicker
            // 
            this.creationDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listingBindingSource, "CreationDateTime", true));
            this.creationDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creationDateTimeDateTimePicker.Location = new System.Drawing.Point(113, 123);
            this.creationDateTimeDateTimePicker.Name = "creationDateTimeDateTimePicker";
            this.creationDateTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationDateTimeDateTimePicker.TabIndex = 23;
            // 
            // commentIDTextBox
            // 
            this.commentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "CommentID", true));
            this.commentIDTextBox.Location = new System.Drawing.Point(118, 87);
            this.commentIDTextBox.Name = "commentIDTextBox";
            this.commentIDTextBox.ReadOnly = true;
            this.commentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.commentIDTextBox.TabIndex = 1;
            // 
            // listingIDTextBox1
            // 
            this.listingIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "ListingID", true));
            this.listingIDTextBox1.Location = new System.Drawing.Point(118, 119);
            this.listingIDTextBox1.Name = "listingIDTextBox1";
            this.listingIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.listingIDTextBox1.TabIndex = 5;
            // 
            // tabCommentsInfo
            // 
            this.tabCommentsInfo.Controls.Add(this.commentsGeneralTab);
            this.tabCommentsInfo.Controls.Add(this.commentsInfoTab);
            this.tabCommentsInfo.Location = new System.Drawing.Point(21, 424);
            this.tabCommentsInfo.Name = "tabCommentsInfo";
            this.tabCommentsInfo.SelectedIndex = 0;
            this.tabCommentsInfo.Size = new System.Drawing.Size(317, 233);
            this.tabCommentsInfo.TabIndex = 19;
            // 
            // commentsGeneralTab
            // 
            this.commentsGeneralTab.Controls.Add(commentIDLabel);
            this.commentsGeneralTab.Controls.Add(this.commentIDTextBox);
            this.commentsGeneralTab.Controls.Add(this.listingIDTextBox1);
            this.commentsGeneralTab.Controls.Add(listingIDLabel1);
            this.commentsGeneralTab.Location = new System.Drawing.Point(4, 22);
            this.commentsGeneralTab.Name = "commentsGeneralTab";
            this.commentsGeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.commentsGeneralTab.Size = new System.Drawing.Size(309, 207);
            this.commentsGeneralTab.TabIndex = 0;
            this.commentsGeneralTab.Text = "Comments General";
            this.commentsGeneralTab.UseVisualStyleBackColor = true;
            // 
            // commentsInfoTab
            // 
            this.commentsInfoTab.Controls.Add(this.btnSubmitComment);
            this.commentsInfoTab.Controls.Add(this.commentsRichTextBox);
            this.commentsInfoTab.Controls.Add(commentTextLabel);
            this.commentsInfoTab.Location = new System.Drawing.Point(4, 22);
            this.commentsInfoTab.Name = "commentsInfoTab";
            this.commentsInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.commentsInfoTab.Size = new System.Drawing.Size(309, 207);
            this.commentsInfoTab.TabIndex = 1;
            this.commentsInfoTab.Text = "Comments Info";
            this.commentsInfoTab.UseVisualStyleBackColor = true;
            // 
            // btnSubmitComment
            // 
            this.btnSubmitComment.Location = new System.Drawing.Point(225, 178);
            this.btnSubmitComment.Name = "btnSubmitComment";
            this.btnSubmitComment.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitComment.TabIndex = 5;
            this.btnSubmitComment.Text = "Submit";
            this.btnSubmitComment.UseVisualStyleBackColor = true;
            this.btnSubmitComment.Click += new System.EventHandler(this.btnSubmitComment_Click);
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "CommentText", true));
            this.commentsRichTextBox.Location = new System.Drawing.Point(6, 29);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(294, 145);
            this.commentsRichTextBox.TabIndex = 4;
            this.commentsRichTextBox.Text = "";
            // 
            // frmCarsForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 723);
            this.Controls.Add(this.tabCommentsInfo);
            this.Controls.Add(this.editListingGroupBox);
            this.Controls.Add(this.listingDataGridView);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.commentsDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            this.editListingGroupBox.ResumeLayout(false);
            this.editListingGroupBox.PerformLayout();
            this.tabCommentsInfo.ResumeLayout(false);
            this.commentsGeneralTab.ResumeLayout(false);
            this.commentsGeneralTab.PerformLayout();
            this.commentsInfoTab.ResumeLayout(false);
            this.commentsInfoTab.PerformLayout();
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
        private GroupFinal266DataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private GroupFinal266DataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private System.Windows.Forms.BindingSource listingBindingSource;
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
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView listingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateTime;
        private System.Windows.Forms.GroupBox editListingGroupBox;
        private System.Windows.Forms.TextBox listingIDTextBox;
        private System.Windows.Forms.TextBox sellerIDTextBox;
        private System.Windows.Forms.TextBox carVINTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker creationDateTimeDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListingID;
        private System.Windows.Forms.TextBox commentIDTextBox;
        private System.Windows.Forms.TextBox listingIDTextBox1;
        private System.Windows.Forms.TabControl tabCommentsInfo;
        private System.Windows.Forms.TabPage commentsGeneralTab;
        private System.Windows.Forms.TabPage commentsInfoTab;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private System.Windows.Forms.Button btnSubmitComment;
    }
}

