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
            System.Windows.Forms.Label carVINLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label creationDateTimeLabel;
            System.Windows.Forms.Label commentTextLabel;
            System.Windows.Forms.Label carVINLabel1;
            System.Windows.Forms.Label carYearLabel;
            System.Windows.Forms.Label carModelLabel;
            System.Windows.Forms.Label carPriceLabel;
            System.Windows.Forms.Label carColorLabel;
            System.Windows.Forms.Label carMilesLabel;
            System.Windows.Forms.Label carMakeLabel;
            System.Windows.Forms.Label listingIDLabel2;
            System.Windows.Forms.Label sellerIDLabel;
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
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new CarDealership.GroupFinal266DataSetTableAdapters.CommentsTableAdapter();
            this.commentsDataGridView = new System.Windows.Forms.DataGridView();
            this.CommentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteComment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.listingDataGridView = new System.Windows.Forms.DataGridView();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listingIDTextBox = new System.Windows.Forms.TextBox();
            this.carVINTextBoxListingInfo = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.creationDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listingIDComboBox = new System.Windows.Forms.ComboBox();
            this.btnSubmitComment = new System.Windows.Forms.Button();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.listingTab = new System.Windows.Forms.TabControl();
            this.listingInfoTab = new System.Windows.Forms.TabPage();
            this.sellerIDTextBox = new System.Windows.Forms.TextBox();
            this.carInfoTab = new System.Windows.Forms.TabPage();
            this.carMakeComboBox = new System.Windows.Forms.ComboBox();
            this.carVINTextBoxCarInfo = new System.Windows.Forms.TextBox();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carPriceTextBox = new System.Windows.Forms.TextBox();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.carMilesTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxComments = new System.Windows.Forms.GroupBox();
            this.groupFinal266DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carVINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteListing = new System.Windows.Forms.DataGridViewButtonColumn();
            listingIDLabel = new System.Windows.Forms.Label();
            carVINLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            creationDateTimeLabel = new System.Windows.Forms.Label();
            commentTextLabel = new System.Windows.Forms.Label();
            carVINLabel1 = new System.Windows.Forms.Label();
            carYearLabel = new System.Windows.Forms.Label();
            carModelLabel = new System.Windows.Forms.Label();
            carPriceLabel = new System.Windows.Forms.Label();
            carColorLabel = new System.Windows.Forms.Label();
            carMilesLabel = new System.Windows.Forms.Label();
            carMakeLabel = new System.Windows.Forms.Label();
            listingIDLabel2 = new System.Windows.Forms.Label();
            sellerIDLabel = new System.Windows.Forms.Label();
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
            this.listingTab.SuspendLayout();
            this.listingInfoTab.SuspendLayout();
            this.carInfoTab.SuspendLayout();
            this.groupBoxComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listingIDLabel
            // 
            listingIDLabel.AutoSize = true;
            listingIDLabel.Location = new System.Drawing.Point(7, 19);
            listingIDLabel.Name = "listingIDLabel";
            listingIDLabel.Size = new System.Drawing.Size(54, 13);
            listingIDLabel.TabIndex = 14;
            listingIDLabel.Text = "Listing ID:";
            // 
            // carVINLabel
            // 
            carVINLabel.AutoSize = true;
            carVINLabel.Location = new System.Drawing.Point(7, 71);
            carVINLabel.Name = "carVINLabel";
            carVINLabel.Size = new System.Drawing.Size(47, 13);
            carVINLabel.TabIndex = 18;
            carVINLabel.Text = "Car VIN:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(7, 97);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Description:";
            // 
            // creationDateTimeLabel
            // 
            creationDateTimeLabel.AutoSize = true;
            creationDateTimeLabel.Location = new System.Drawing.Point(7, 126);
            creationDateTimeLabel.Name = "creationDateTimeLabel";
            creationDateTimeLabel.Size = new System.Drawing.Size(101, 13);
            creationDateTimeLabel.TabIndex = 22;
            creationDateTimeLabel.Text = "Creation Date Time:";
            // 
            // commentTextLabel
            // 
            commentTextLabel.AutoSize = true;
            commentTextLabel.Location = new System.Drawing.Point(7, 54);
            commentTextLabel.Name = "commentTextLabel";
            commentTextLabel.Size = new System.Drawing.Size(78, 13);
            commentTextLabel.TabIndex = 2;
            commentTextLabel.Text = "Comment Text:";
            // 
            // carVINLabel1
            // 
            carVINLabel1.AutoSize = true;
            carVINLabel1.Location = new System.Drawing.Point(13, 18);
            carVINLabel1.Name = "carVINLabel1";
            carVINLabel1.Size = new System.Drawing.Size(47, 13);
            carVINLabel1.TabIndex = 0;
            carVINLabel1.Text = "Car VIN:";
            // 
            // carYearLabel
            // 
            carYearLabel.AutoSize = true;
            carYearLabel.Location = new System.Drawing.Point(13, 44);
            carYearLabel.Name = "carYearLabel";
            carYearLabel.Size = new System.Drawing.Size(51, 13);
            carYearLabel.TabIndex = 2;
            carYearLabel.Text = "Car Year:";
            // 
            // carModelLabel
            // 
            carModelLabel.AutoSize = true;
            carModelLabel.Location = new System.Drawing.Point(13, 96);
            carModelLabel.Name = "carModelLabel";
            carModelLabel.Size = new System.Drawing.Size(58, 13);
            carModelLabel.TabIndex = 6;
            carModelLabel.Text = "Car Model:";
            // 
            // carPriceLabel
            // 
            carPriceLabel.AutoSize = true;
            carPriceLabel.Location = new System.Drawing.Point(13, 122);
            carPriceLabel.Name = "carPriceLabel";
            carPriceLabel.Size = new System.Drawing.Size(53, 13);
            carPriceLabel.TabIndex = 8;
            carPriceLabel.Text = "Car Price:";
            // 
            // carColorLabel
            // 
            carColorLabel.AutoSize = true;
            carColorLabel.Location = new System.Drawing.Point(13, 148);
            carColorLabel.Name = "carColorLabel";
            carColorLabel.Size = new System.Drawing.Size(53, 13);
            carColorLabel.TabIndex = 10;
            carColorLabel.Text = "Car Color:";
            // 
            // carMilesLabel
            // 
            carMilesLabel.AutoSize = true;
            carMilesLabel.Location = new System.Drawing.Point(13, 174);
            carMilesLabel.Name = "carMilesLabel";
            carMilesLabel.Size = new System.Drawing.Size(53, 13);
            carMilesLabel.TabIndex = 12;
            carMilesLabel.Text = "Car Miles:";
            // 
            // carMakeLabel
            // 
            carMakeLabel.AutoSize = true;
            carMakeLabel.Location = new System.Drawing.Point(13, 69);
            carMakeLabel.Name = "carMakeLabel";
            carMakeLabel.Size = new System.Drawing.Size(56, 13);
            carMakeLabel.TabIndex = 13;
            carMakeLabel.Text = "Car Make:";
            // 
            // listingIDLabel2
            // 
            listingIDLabel2.AutoSize = true;
            listingIDLabel2.Location = new System.Drawing.Point(7, 22);
            listingIDLabel2.Name = "listingIDLabel2";
            listingIDLabel2.Size = new System.Drawing.Size(54, 13);
            listingIDLabel2.TabIndex = 5;
            listingIDLabel2.Text = "Listing ID:";
            // 
            // sellerIDLabel
            // 
            sellerIDLabel.AutoSize = true;
            sellerIDLabel.Location = new System.Drawing.Point(7, 45);
            sellerIDLabel.Name = "sellerIDLabel";
            sellerIDLabel.Size = new System.Drawing.Size(50, 13);
            sellerIDLabel.TabIndex = 16;
            sellerIDLabel.Text = "Seller ID:";
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
            this.viewAllToolStripButton.Size = new System.Drawing.Size(32, 22);
            this.viewAllToolStripButton.Text = "Sort";
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
            this.btnUpload.Location = new System.Drawing.Point(239, 165);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 30);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
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
            this.ListingID,
            this.DeleteComment});
            this.commentsDataGridView.DataSource = this.commentsBindingSource;
            this.commentsDataGridView.Location = new System.Drawing.Point(446, 447);
            this.commentsDataGridView.Name = "commentsDataGridView";
            this.commentsDataGridView.ReadOnly = true;
            this.commentsDataGridView.Size = new System.Drawing.Size(779, 202);
            this.commentsDataGridView.TabIndex = 15;
            this.commentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentsDataGridView_CellContentClick);
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
            // DeleteComment
            // 
            this.DeleteComment.HeaderText = "";
            this.DeleteComment.Name = "DeleteComment";
            this.DeleteComment.ReadOnly = true;
            this.DeleteComment.Text = "Delete";
            this.DeleteComment.UseColumnTextForButtonValue = true;
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
            this.listingIDDataGridViewTextBoxColumn,
            this.sellerIDDataGridViewTextBoxColumn,
            this.carVINDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.creationDateTimeDataGridViewTextBoxColumn,
            this.DeleteListing});
            this.listingDataGridView.DataSource = this.listingBindingSource;
            this.listingDataGridView.Location = new System.Drawing.Point(446, 62);
            this.listingDataGridView.Name = "listingDataGridView";
            this.listingDataGridView.ReadOnly = true;
            this.listingDataGridView.Size = new System.Drawing.Size(776, 188);
            this.listingDataGridView.TabIndex = 16;
            this.listingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listingDataGridView_CellContentClick);
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "Listing";
            this.listingBindingSource.DataSource = this.groupFinal266DataSetBindingSource;
            // 
            // listingIDTextBox
            // 
            this.listingIDTextBox.Location = new System.Drawing.Point(114, 16);
            this.listingIDTextBox.Name = "listingIDTextBox";
            this.listingIDTextBox.ReadOnly = true;
            this.listingIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.listingIDTextBox.TabIndex = 15;
            // 
            // carVINTextBoxListingInfo
            // 
            this.carVINTextBoxListingInfo.Location = new System.Drawing.Point(114, 68);
            this.carVINTextBoxListingInfo.Name = "carVINTextBoxListingInfo";
            this.carVINTextBoxListingInfo.Size = new System.Drawing.Size(200, 20);
            this.carVINTextBoxListingInfo.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 94);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // creationDateTimeDateTimePicker
            // 
            this.creationDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listingBindingSource, "CreationDateTime", true));
            this.creationDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creationDateTimeDateTimePicker.Location = new System.Drawing.Point(114, 126);
            this.creationDateTimeDateTimePicker.Name = "creationDateTimeDateTimePicker";
            this.creationDateTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationDateTimeDateTimePicker.TabIndex = 23;
            // 
            // listingIDComboBox
            // 
            this.listingIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "ListingID", true));
            this.listingIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "ListingID", true));
            this.listingIDComboBox.DataSource = this.listingBindingSource;
            this.listingIDComboBox.DisplayMember = "ListingID";
            this.listingIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listingIDComboBox.FormattingEnabled = true;
            this.listingIDComboBox.Location = new System.Drawing.Point(86, 19);
            this.listingIDComboBox.Name = "listingIDComboBox";
            this.listingIDComboBox.Size = new System.Drawing.Size(100, 21);
            this.listingIDComboBox.TabIndex = 6;
            this.listingIDComboBox.ValueMember = "ListingID";
            // 
            // btnSubmitComment
            // 
            this.btnSubmitComment.Location = new System.Drawing.Point(229, 221);
            this.btnSubmitComment.Name = "btnSubmitComment";
            this.btnSubmitComment.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitComment.TabIndex = 5;
            this.btnSubmitComment.Text = "Submit";
            this.btnSubmitComment.UseVisualStyleBackColor = true;
            this.btnSubmitComment.Click += new System.EventHandler(this.btnSubmitComment_Click);
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(10, 70);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(294, 145);
            this.commentsRichTextBox.TabIndex = 4;
            this.commentsRichTextBox.Text = "";
            // 
            // listingTab
            // 
            this.listingTab.Controls.Add(this.listingInfoTab);
            this.listingTab.Controls.Add(this.carInfoTab);
            this.listingTab.Location = new System.Drawing.Point(21, 33);
            this.listingTab.Name = "listingTab";
            this.listingTab.SelectedIndex = 0;
            this.listingTab.Size = new System.Drawing.Size(356, 233);
            this.listingTab.TabIndex = 24;
            // 
            // listingInfoTab
            // 
            this.listingInfoTab.AutoScroll = true;
            this.listingInfoTab.Controls.Add(this.sellerIDTextBox);
            this.listingInfoTab.Controls.Add(this.listingIDTextBox);
            this.listingInfoTab.Controls.Add(listingIDLabel);
            this.listingInfoTab.Controls.Add(sellerIDLabel);
            this.listingInfoTab.Controls.Add(this.descriptionTextBox);
            this.listingInfoTab.Controls.Add(descriptionLabel);
            this.listingInfoTab.Controls.Add(carVINLabel);
            this.listingInfoTab.Controls.Add(this.btnUpload);
            this.listingInfoTab.Controls.Add(creationDateTimeLabel);
            this.listingInfoTab.Controls.Add(this.creationDateTimeDateTimePicker);
            this.listingInfoTab.Controls.Add(this.carVINTextBoxListingInfo);
            this.listingInfoTab.Location = new System.Drawing.Point(4, 22);
            this.listingInfoTab.Name = "listingInfoTab";
            this.listingInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.listingInfoTab.Size = new System.Drawing.Size(348, 207);
            this.listingInfoTab.TabIndex = 0;
            this.listingInfoTab.Text = "Listing Information";
            this.listingInfoTab.UseVisualStyleBackColor = true;
            // 
            // sellerIDTextBox
            // 
            this.sellerIDTextBox.Location = new System.Drawing.Point(114, 42);
            this.sellerIDTextBox.Name = "sellerIDTextBox";
            this.sellerIDTextBox.ReadOnly = true;
            this.sellerIDTextBox.Size = new System.Drawing.Size(199, 20);
            this.sellerIDTextBox.TabIndex = 25;
            // 
            // carInfoTab
            // 
            this.carInfoTab.AutoScroll = true;
            this.carInfoTab.Controls.Add(carMakeLabel);
            this.carInfoTab.Controls.Add(this.carMakeComboBox);
            this.carInfoTab.Controls.Add(carVINLabel1);
            this.carInfoTab.Controls.Add(this.carVINTextBoxCarInfo);
            this.carInfoTab.Controls.Add(carYearLabel);
            this.carInfoTab.Controls.Add(this.carYearTextBox);
            this.carInfoTab.Controls.Add(carModelLabel);
            this.carInfoTab.Controls.Add(this.carModelTextBox);
            this.carInfoTab.Controls.Add(carPriceLabel);
            this.carInfoTab.Controls.Add(this.carPriceTextBox);
            this.carInfoTab.Controls.Add(carColorLabel);
            this.carInfoTab.Controls.Add(this.carColorTextBox);
            this.carInfoTab.Controls.Add(carMilesLabel);
            this.carInfoTab.Controls.Add(this.carMilesTextBox);
            this.carInfoTab.Location = new System.Drawing.Point(4, 22);
            this.carInfoTab.Name = "carInfoTab";
            this.carInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.carInfoTab.Size = new System.Drawing.Size(348, 207);
            this.carInfoTab.TabIndex = 1;
            this.carInfoTab.Text = "Car Information";
            this.carInfoTab.UseVisualStyleBackColor = true;
            // 
            // carMakeComboBox
            // 
            this.carMakeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarMake", true));
            this.carMakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carMakeComboBox.FormattingEnabled = true;
            this.carMakeComboBox.Location = new System.Drawing.Point(77, 66);
            this.carMakeComboBox.Name = "carMakeComboBox";
            this.carMakeComboBox.Size = new System.Drawing.Size(252, 21);
            this.carMakeComboBox.TabIndex = 14;
            // 
            // carVINTextBoxCarInfo
            // 
            this.carVINTextBoxCarInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarVIN", true));
            this.carVINTextBoxCarInfo.Location = new System.Drawing.Point(77, 15);
            this.carVINTextBoxCarInfo.Name = "carVINTextBoxCarInfo";
            this.carVINTextBoxCarInfo.Size = new System.Drawing.Size(252, 20);
            this.carVINTextBoxCarInfo.TabIndex = 1;
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarYear", true));
            this.carYearTextBox.Location = new System.Drawing.Point(77, 41);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(252, 20);
            this.carYearTextBox.TabIndex = 3;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarModel", true));
            this.carModelTextBox.Location = new System.Drawing.Point(77, 93);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(252, 20);
            this.carModelTextBox.TabIndex = 7;
            // 
            // carPriceTextBox
            // 
            this.carPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarPrice", true));
            this.carPriceTextBox.Location = new System.Drawing.Point(77, 119);
            this.carPriceTextBox.Name = "carPriceTextBox";
            this.carPriceTextBox.Size = new System.Drawing.Size(252, 20);
            this.carPriceTextBox.TabIndex = 9;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarColor", true));
            this.carColorTextBox.Location = new System.Drawing.Point(77, 145);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.Size = new System.Drawing.Size(252, 20);
            this.carColorTextBox.TabIndex = 11;
            // 
            // carMilesTextBox
            // 
            this.carMilesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarMiles", true));
            this.carMilesTextBox.Location = new System.Drawing.Point(77, 171);
            this.carMilesTextBox.Name = "carMilesTextBox";
            this.carMilesTextBox.Size = new System.Drawing.Size(252, 20);
            this.carMilesTextBox.TabIndex = 13;
            // 
            // groupBoxComments
            // 
            this.groupBoxComments.Controls.Add(this.listingIDComboBox);
            this.groupBoxComments.Controls.Add(this.btnSubmitComment);
            this.groupBoxComments.Controls.Add(listingIDLabel2);
            this.groupBoxComments.Controls.Add(this.commentsRichTextBox);
            this.groupBoxComments.Controls.Add(commentTextLabel);
            this.groupBoxComments.Location = new System.Drawing.Point(12, 403);
            this.groupBoxComments.Name = "groupBoxComments";
            this.groupBoxComments.Size = new System.Drawing.Size(365, 246);
            this.groupBoxComments.TabIndex = 25;
            this.groupBoxComments.TabStop = false;
            this.groupBoxComments.Text = "Comments";
            // 
            // groupFinal266DataSetBindingSource
            // 
            this.groupFinal266DataSetBindingSource.DataSource = this.groupFinal266DataSet;
            this.groupFinal266DataSetBindingSource.Position = 0;
            // 
            // listingIDDataGridViewTextBoxColumn
            // 
            this.listingIDDataGridViewTextBoxColumn.DataPropertyName = "ListingID";
            this.listingIDDataGridViewTextBoxColumn.HeaderText = "ListingID";
            this.listingIDDataGridViewTextBoxColumn.Name = "listingIDDataGridViewTextBoxColumn";
            this.listingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            this.sellerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carVINDataGridViewTextBoxColumn
            // 
            this.carVINDataGridViewTextBoxColumn.DataPropertyName = "CarVIN";
            this.carVINDataGridViewTextBoxColumn.HeaderText = "CarVIN";
            this.carVINDataGridViewTextBoxColumn.Name = "carVINDataGridViewTextBoxColumn";
            this.carVINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateTimeDataGridViewTextBoxColumn
            // 
            this.creationDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationDateTime";
            this.creationDateTimeDataGridViewTextBoxColumn.HeaderText = "CreationDateTime";
            this.creationDateTimeDataGridViewTextBoxColumn.Name = "creationDateTimeDataGridViewTextBoxColumn";
            this.creationDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeleteListing
            // 
            this.DeleteListing.HeaderText = "";
            this.DeleteListing.Name = "DeleteListing";
            this.DeleteListing.ReadOnly = true;
            this.DeleteListing.Text = "Delete";
            this.DeleteListing.UseColumnTextForButtonValue = true;
            // 
            // frmCarsForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 723);
            this.Controls.Add(this.groupBoxComments);
            this.Controls.Add(this.listingTab);
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
            this.listingTab.ResumeLayout(false);
            this.listingInfoTab.ResumeLayout(false);
            this.listingInfoTab.PerformLayout();
            this.carInfoTab.ResumeLayout(false);
            this.carInfoTab.PerformLayout();
            this.groupBoxComments.ResumeLayout(false);
            this.groupBoxComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupFinal266DataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox listingIDTextBox;
        private System.Windows.Forms.TextBox carVINTextBoxListingInfo;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker creationDateTimeDateTimePicker;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private System.Windows.Forms.Button btnSubmitComment;
        private System.Windows.Forms.TabControl listingTab;
        private System.Windows.Forms.TabPage listingInfoTab;
        private System.Windows.Forms.TabPage carInfoTab;
        private System.Windows.Forms.TextBox carVINTextBoxCarInfo;
        private System.Windows.Forms.TextBox carYearTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox carPriceTextBox;
        private System.Windows.Forms.TextBox carColorTextBox;
        private System.Windows.Forms.TextBox carMilesTextBox;
        private System.Windows.Forms.ComboBox carMakeComboBox;
        private System.Windows.Forms.ComboBox listingIDComboBox;
        private System.Windows.Forms.TextBox sellerIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListingID;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteComment;
        private System.Windows.Forms.GroupBox groupBoxComments;
        private System.Windows.Forms.BindingSource groupFinal266DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn listingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carVINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteListing;
    }
}

