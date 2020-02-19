namespace Realestate
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label houseTypeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label squareFootageLabel;
            System.Windows.Forms.Label lotSizeLabel;
            System.Windows.Forms.Label bedroomsLabel;
            System.Windows.Forms.Label bathroomsLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label applianceLabel;
            System.Windows.Forms.Label isBasementLabel;
            System.Windows.Forms.Label isParkingLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label boroughLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zipcodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label nameAgentLabel;
            System.Windows.Forms.Label commentAgentLabel;
            System.Windows.Forms.Label statusPropertiesLabel;
            System.Windows.Forms.Label nameOwnerLabel;
            System.Windows.Forms.Label addressOwnerLabel;
            System.Windows.Forms.Label requestOwnerLabel;
            System.Windows.Forms.Label inforOwnerLabel;
            System.Windows.Forms.Label offerLabel;
            System.Windows.Forms.Label offerMakerLabel;
            System.Windows.Forms.Label offerConditionLabel;
            System.Windows.Forms.Label actionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Minprice = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Minbed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.garage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Minlot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Maxprice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Maxbed = new System.Windows.Forms.ComboBox();
            this.bathroom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.zipcode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.descriptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.descriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesDataSet = new Realestate.propertiesDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.descriptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descriptionTableAdapter = new Realestate.propertiesDataSetTableAdapters.DescriptionTableAdapter();
            this.tableAdapterManager = new Realestate.propertiesDataSetTableAdapters.TableAdapterManager();
            this.propertiesDataSet1 = new Realestate.propertiesDataSet1();
            this.table01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table01TableAdapter = new Realestate.propertiesDataSet1TableAdapters.Table01TableAdapter();
            this.tableAdapterManager1 = new Realestate.propertiesDataSet1TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.houseTypeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.squareFootageTextBox = new System.Windows.Forms.TextBox();
            this.lotSizeTextBox = new System.Windows.Forms.TextBox();
            this.bedroomsTextBox = new System.Windows.Forms.TextBox();
            this.bathroomsTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.applianceTextBox = new System.Windows.Forms.TextBox();
            this.isBasementCheckBox = new System.Windows.Forms.CheckBox();
            this.isParkingCheckBox = new System.Windows.Forms.CheckBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.boroughTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.nameAgentTextBox = new System.Windows.Forms.TextBox();
            this.commentAgentTextBox = new System.Windows.Forms.TextBox();
            this.statusPropertiesTextBox = new System.Windows.Forms.TextBox();
            this.nameOwnerTextBox = new System.Windows.Forms.TextBox();
            this.addressOwnerTextBox = new System.Windows.Forms.TextBox();
            this.requestOwnerTextBox = new System.Windows.Forms.TextBox();
            this.inforOwnerTextBox = new System.Windows.Forms.TextBox();
            this.offerTextBox = new System.Windows.Forms.TextBox();
            this.offerMakerTextBox = new System.Windows.Forms.TextBox();
            this.offerConditionTextBox = new System.Windows.Forms.TextBox();
            this.actionTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Id_Detail = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Offer_Detail = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            houseTypeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            squareFootageLabel = new System.Windows.Forms.Label();
            lotSizeLabel = new System.Windows.Forms.Label();
            bedroomsLabel = new System.Windows.Forms.Label();
            bathroomsLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            applianceLabel = new System.Windows.Forms.Label();
            isBasementLabel = new System.Windows.Forms.Label();
            isParkingLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            boroughLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            nameAgentLabel = new System.Windows.Forms.Label();
            commentAgentLabel = new System.Windows.Forms.Label();
            statusPropertiesLabel = new System.Windows.Forms.Label();
            nameOwnerLabel = new System.Windows.Forms.Label();
            addressOwnerLabel = new System.Windows.Forms.Label();
            requestOwnerLabel = new System.Windows.Forms.Label();
            inforOwnerLabel = new System.Windows.Forms.Label();
            offerLabel = new System.Windows.Forms.Label();
            offerMakerLabel = new System.Windows.Forms.Label();
            offerConditionLabel = new System.Windows.Forms.Label();
            actionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingNavigator)).BeginInit();
            this.descriptionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(618, 39);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 12);
            idLabel.TabIndex = 26;
            idLabel.Text = "Id:";
            // 
            // houseTypeLabel
            // 
            houseTypeLabel.AutoSize = true;
            houseTypeLabel.Location = new System.Drawing.Point(618, 66);
            houseTypeLabel.Name = "houseTypeLabel";
            houseTypeLabel.Size = new System.Drawing.Size(71, 12);
            houseTypeLabel.TabIndex = 28;
            houseTypeLabel.Text = "House Type:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(618, 93);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 12);
            priceLabel.TabIndex = 30;
            priceLabel.Text = "Price:";
            // 
            // squareFootageLabel
            // 
            squareFootageLabel.AutoSize = true;
            squareFootageLabel.Location = new System.Drawing.Point(618, 120);
            squareFootageLabel.Name = "squareFootageLabel";
            squareFootageLabel.Size = new System.Drawing.Size(95, 12);
            squareFootageLabel.TabIndex = 32;
            squareFootageLabel.Text = "Square Footage:";
            // 
            // lotSizeLabel
            // 
            lotSizeLabel.AutoSize = true;
            lotSizeLabel.Location = new System.Drawing.Point(618, 147);
            lotSizeLabel.Name = "lotSizeLabel";
            lotSizeLabel.Size = new System.Drawing.Size(59, 12);
            lotSizeLabel.TabIndex = 34;
            lotSizeLabel.Text = "Lot Size:";
            // 
            // bedroomsLabel
            // 
            bedroomsLabel.AutoSize = true;
            bedroomsLabel.Location = new System.Drawing.Point(618, 174);
            bedroomsLabel.Name = "bedroomsLabel";
            bedroomsLabel.Size = new System.Drawing.Size(59, 12);
            bedroomsLabel.TabIndex = 36;
            bedroomsLabel.Text = "Bedrooms:";
            // 
            // bathroomsLabel
            // 
            bathroomsLabel.AutoSize = true;
            bathroomsLabel.Location = new System.Drawing.Point(618, 201);
            bathroomsLabel.Name = "bathroomsLabel";
            bathroomsLabel.Size = new System.Drawing.Size(65, 12);
            bathroomsLabel.TabIndex = 38;
            bathroomsLabel.Text = "Bathrooms:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(618, 228);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(77, 12);
            descriptionLabel.TabIndex = 40;
            descriptionLabel.Text = "Description:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(618, 255);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 12);
            ageLabel.TabIndex = 42;
            ageLabel.Text = "Age:";
            // 
            // applianceLabel
            // 
            applianceLabel.AutoSize = true;
            applianceLabel.Location = new System.Drawing.Point(618, 282);
            applianceLabel.Name = "applianceLabel";
            applianceLabel.Size = new System.Drawing.Size(65, 12);
            applianceLabel.TabIndex = 44;
            applianceLabel.Text = "Appliance:";
            // 
            // isBasementLabel
            // 
            isBasementLabel.AutoSize = true;
            isBasementLabel.Location = new System.Drawing.Point(618, 311);
            isBasementLabel.Name = "isBasementLabel";
            isBasementLabel.Size = new System.Drawing.Size(77, 12);
            isBasementLabel.TabIndex = 46;
            isBasementLabel.Text = "Is Basement:";
            // 
            // isParkingLabel
            // 
            isParkingLabel.AutoSize = true;
            isParkingLabel.Location = new System.Drawing.Point(618, 341);
            isParkingLabel.Name = "isParkingLabel";
            isParkingLabel.Size = new System.Drawing.Size(71, 12);
            isParkingLabel.TabIndex = 48;
            isParkingLabel.Text = "Is Parking:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(861, 39);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(47, 12);
            streetLabel.TabIndex = 50;
            streetLabel.Text = "Street:";
            // 
            // boroughLabel
            // 
            boroughLabel.AutoSize = true;
            boroughLabel.Location = new System.Drawing.Point(861, 66);
            boroughLabel.Name = "boroughLabel";
            boroughLabel.Size = new System.Drawing.Size(53, 12);
            boroughLabel.TabIndex = 52;
            boroughLabel.Text = "Borough:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(861, 93);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 12);
            cityLabel.TabIndex = 54;
            cityLabel.Text = "City:";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new System.Drawing.Point(861, 120);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(53, 12);
            zipcodeLabel.TabIndex = 56;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(861, 147);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(53, 12);
            countryLabel.TabIndex = 58;
            countryLabel.Text = "Country:";
            // 
            // nameAgentLabel
            // 
            nameAgentLabel.AutoSize = true;
            nameAgentLabel.Location = new System.Drawing.Point(861, 180);
            nameAgentLabel.Name = "nameAgentLabel";
            nameAgentLabel.Size = new System.Drawing.Size(71, 12);
            nameAgentLabel.TabIndex = 60;
            nameAgentLabel.Text = "name Agent:";
            // 
            // commentAgentLabel
            // 
            commentAgentLabel.AutoSize = true;
            commentAgentLabel.Location = new System.Drawing.Point(861, 207);
            commentAgentLabel.Name = "commentAgentLabel";
            commentAgentLabel.Size = new System.Drawing.Size(89, 12);
            commentAgentLabel.TabIndex = 62;
            commentAgentLabel.Text = "comment Agent:";
            // 
            // statusPropertiesLabel
            // 
            statusPropertiesLabel.AutoSize = true;
            statusPropertiesLabel.Location = new System.Drawing.Point(861, 234);
            statusPropertiesLabel.Name = "statusPropertiesLabel";
            statusPropertiesLabel.Size = new System.Drawing.Size(113, 12);
            statusPropertiesLabel.TabIndex = 64;
            statusPropertiesLabel.Text = "status Properties:";
            // 
            // nameOwnerLabel
            // 
            nameOwnerLabel.AutoSize = true;
            nameOwnerLabel.Location = new System.Drawing.Point(861, 261);
            nameOwnerLabel.Name = "nameOwnerLabel";
            nameOwnerLabel.Size = new System.Drawing.Size(71, 12);
            nameOwnerLabel.TabIndex = 66;
            nameOwnerLabel.Text = "name Owner:";
            // 
            // addressOwnerLabel
            // 
            addressOwnerLabel.AutoSize = true;
            addressOwnerLabel.Location = new System.Drawing.Point(861, 288);
            addressOwnerLabel.Name = "addressOwnerLabel";
            addressOwnerLabel.Size = new System.Drawing.Size(89, 12);
            addressOwnerLabel.TabIndex = 68;
            addressOwnerLabel.Text = "address Owner:";
            // 
            // requestOwnerLabel
            // 
            requestOwnerLabel.AutoSize = true;
            requestOwnerLabel.Location = new System.Drawing.Point(861, 315);
            requestOwnerLabel.Name = "requestOwnerLabel";
            requestOwnerLabel.Size = new System.Drawing.Size(89, 12);
            requestOwnerLabel.TabIndex = 70;
            requestOwnerLabel.Text = "Request Owner:";
            // 
            // inforOwnerLabel
            // 
            inforOwnerLabel.AutoSize = true;
            inforOwnerLabel.Location = new System.Drawing.Point(861, 342);
            inforOwnerLabel.Name = "inforOwnerLabel";
            inforOwnerLabel.Size = new System.Drawing.Size(77, 12);
            inforOwnerLabel.TabIndex = 72;
            inforOwnerLabel.Text = "infor Owner:";
            // 
            // offerLabel
            // 
            offerLabel.AutoSize = true;
            offerLabel.Location = new System.Drawing.Point(618, 374);
            offerLabel.Name = "offerLabel";
            offerLabel.Size = new System.Drawing.Size(41, 12);
            offerLabel.TabIndex = 74;
            offerLabel.Text = "offer:";
            // 
            // offerMakerLabel
            // 
            offerMakerLabel.AutoSize = true;
            offerMakerLabel.Location = new System.Drawing.Point(618, 403);
            offerMakerLabel.Name = "offerMakerLabel";
            offerMakerLabel.Size = new System.Drawing.Size(77, 12);
            offerMakerLabel.TabIndex = 76;
            offerMakerLabel.Text = "offer Maker:";
            // 
            // offerConditionLabel
            // 
            offerConditionLabel.AutoSize = true;
            offerConditionLabel.Location = new System.Drawing.Point(618, 430);
            offerConditionLabel.Name = "offerConditionLabel";
            offerConditionLabel.Size = new System.Drawing.Size(101, 12);
            offerConditionLabel.TabIndex = 78;
            offerConditionLabel.Text = "offer Condition:";
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.Location = new System.Drawing.Point(618, 12);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new System.Drawing.Size(47, 12);
            actionLabel.TabIndex = 80;
            actionLabel.Text = "Action:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Buy);
            // 
            // Minprice
            // 
            this.Minprice.FormattingEnabled = true;
            this.Minprice.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Minprice.Items.AddRange(new object[] {
            "0",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "50000",
            "100000",
            "150000",
            "200000",
            "250000",
            "300000",
            "350000",
            "400000",
            "450000",
            "500000"});
            this.Minprice.Location = new System.Drawing.Point(38, 96);
            this.Minprice.Name = "Minprice";
            this.Minprice.Size = new System.Drawing.Size(126, 20);
            this.Minprice.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Rent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Rent);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Condo",
            "Townhome",
            "House",
            "Multi-Family"});
            this.type.Location = new System.Drawing.Point(38, 47);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(284, 20);
            this.type.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Property Type";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min Price";
            // 
            // Minbed
            // 
            this.Minbed.FormattingEnabled = true;
            this.Minbed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Minbed.Location = new System.Drawing.Point(38, 149);
            this.Minbed.Name = "Minbed";
            this.Minbed.Size = new System.Drawing.Size(126, 20);
            this.Minbed.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Min Bedroom";
            // 
            // garage
            // 
            this.garage.FormattingEnabled = true;
            this.garage.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.garage.Location = new System.Drawing.Point(38, 196);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(126, 20);
            this.garage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Garage/Parking";
            // 
            // Minlot
            // 
            this.Minlot.FormattingEnabled = true;
            this.Minlot.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "2000",
            "3000"});
            this.Minlot.Location = new System.Drawing.Point(38, 240);
            this.Minlot.Name = "Minlot";
            this.Minlot.Size = new System.Drawing.Size(121, 20);
            this.Minlot.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "Min Lots";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min Bathroom";
            // 
            // Maxprice
            // 
            this.Maxprice.FormattingEnabled = true;
            this.Maxprice.Items.AddRange(new object[] {
            "0",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "50000",
            "100000",
            "150000",
            "200000",
            "250000",
            "300000",
            "350000",
            "400000",
            "450000",
            "500000"});
            this.Maxprice.Location = new System.Drawing.Point(191, 96);
            this.Maxprice.Name = "Maxprice";
            this.Maxprice.Size = new System.Drawing.Size(124, 20);
            this.Maxprice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(189, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max Bedroom";
            // 
            // Maxbed
            // 
            this.Maxbed.FormattingEnabled = true;
            this.Maxbed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Maxbed.Location = new System.Drawing.Point(191, 149);
            this.Maxbed.Name = "Maxbed";
            this.Maxbed.Size = new System.Drawing.Size(124, 20);
            this.Maxbed.TabIndex = 10;
            // 
            // bathroom
            // 
            this.bathroom.FormattingEnabled = true;
            this.bathroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.bathroom.Location = new System.Drawing.Point(191, 196);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(124, 20);
            this.bathroom.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(189, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "ZipCode";
            // 
            // zipcode
            // 
            this.zipcode.Location = new System.Drawing.Point(189, 240);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(126, 21);
            this.zipcode.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(244, 305);
            this.dataGridView1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "List of Properties";
            // 
            // descriptionBindingNavigator
            // 
            this.descriptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.descriptionBindingNavigator.BindingSource = this.descriptionBindingSource;
            this.descriptionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.descriptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.descriptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.descriptionBindingNavigatorSaveItem});
            this.descriptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.descriptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.descriptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.descriptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.descriptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.descriptionBindingNavigator.Name = "descriptionBindingNavigator";
            this.descriptionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.descriptionBindingNavigator.Size = new System.Drawing.Size(1104, 25);
            this.descriptionBindingNavigator.TabIndex = 26;
            this.descriptionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // descriptionBindingSource
            // 
            this.descriptionBindingSource.DataMember = "Description";
            this.descriptionBindingSource.DataSource = this.propertiesDataSet;
            // 
            // propertiesDataSet
            // 
            this.propertiesDataSet.DataSetName = "propertiesDataSet";
            this.propertiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // descriptionBindingNavigatorSaveItem
            // 
            this.descriptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.descriptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("descriptionBindingNavigatorSaveItem.Image")));
            this.descriptionBindingNavigatorSaveItem.Name = "descriptionBindingNavigatorSaveItem";
            this.descriptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.descriptionBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // descriptionTableAdapter
            // 
            this.descriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DescriptionTableAdapter = this.descriptionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Realestate.propertiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // propertiesDataSet1
            // 
            this.propertiesDataSet1.DataSetName = "propertiesDataSet1";
            this.propertiesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table01BindingSource
            // 
            this.table01BindingSource.DataMember = "Table01";
            this.table01BindingSource.DataSource = this.propertiesDataSet1;
            // 
            // table01TableAdapter
            // 
            this.table01TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Table01TableAdapter = this.table01TableAdapter;
            this.tableAdapterManager1.UpdateOrder = Realestate.propertiesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(737, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 21);
            this.idTextBox.TabIndex = 27;
            // 
            // houseTypeTextBox
            // 
            this.houseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "HouseType", true));
            this.houseTypeTextBox.Location = new System.Drawing.Point(737, 63);
            this.houseTypeTextBox.Name = "houseTypeTextBox";
            this.houseTypeTextBox.Size = new System.Drawing.Size(104, 21);
            this.houseTypeTextBox.TabIndex = 29;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(737, 90);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(104, 21);
            this.priceTextBox.TabIndex = 31;
            // 
            // squareFootageTextBox
            // 
            this.squareFootageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "SquareFootage", true));
            this.squareFootageTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.squareFootageTextBox.Location = new System.Drawing.Point(737, 117);
            this.squareFootageTextBox.Name = "squareFootageTextBox";
            this.squareFootageTextBox.Size = new System.Drawing.Size(104, 21);
            this.squareFootageTextBox.TabIndex = 33;
            // 
            // lotSizeTextBox
            // 
            this.lotSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "LotSize", true));
            this.lotSizeTextBox.Location = new System.Drawing.Point(737, 144);
            this.lotSizeTextBox.Name = "lotSizeTextBox";
            this.lotSizeTextBox.Size = new System.Drawing.Size(104, 21);
            this.lotSizeTextBox.TabIndex = 35;
            // 
            // bedroomsTextBox
            // 
            this.bedroomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Bedrooms", true));
            this.bedroomsTextBox.Location = new System.Drawing.Point(737, 171);
            this.bedroomsTextBox.Name = "bedroomsTextBox";
            this.bedroomsTextBox.Size = new System.Drawing.Size(104, 21);
            this.bedroomsTextBox.TabIndex = 37;
            // 
            // bathroomsTextBox
            // 
            this.bathroomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Bathrooms", true));
            this.bathroomsTextBox.Location = new System.Drawing.Point(737, 198);
            this.bathroomsTextBox.Name = "bathroomsTextBox";
            this.bathroomsTextBox.Size = new System.Drawing.Size(104, 21);
            this.bathroomsTextBox.TabIndex = 39;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(737, 225);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(104, 21);
            this.descriptionTextBox.TabIndex = 41;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(737, 252);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(104, 21);
            this.ageTextBox.TabIndex = 43;
            // 
            // applianceTextBox
            // 
            this.applianceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Appliance", true));
            this.applianceTextBox.Location = new System.Drawing.Point(737, 279);
            this.applianceTextBox.Name = "applianceTextBox";
            this.applianceTextBox.Size = new System.Drawing.Size(104, 21);
            this.applianceTextBox.TabIndex = 45;
            // 
            // isBasementCheckBox
            // 
            this.isBasementCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.table01BindingSource, "IsBasement", true));
            this.isBasementCheckBox.Location = new System.Drawing.Point(737, 306);
            this.isBasementCheckBox.Name = "isBasementCheckBox";
            this.isBasementCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isBasementCheckBox.TabIndex = 47;
            this.isBasementCheckBox.Text = "Yes";
            this.isBasementCheckBox.UseVisualStyleBackColor = true;
            // 
            // isParkingCheckBox
            // 
            this.isParkingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.table01BindingSource, "IsParking", true));
            this.isParkingCheckBox.Location = new System.Drawing.Point(737, 336);
            this.isParkingCheckBox.Name = "isParkingCheckBox";
            this.isParkingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isParkingCheckBox.TabIndex = 49;
            this.isParkingCheckBox.Text = "Yes";
            this.isParkingCheckBox.UseVisualStyleBackColor = true;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(980, 36);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(104, 21);
            this.streetTextBox.TabIndex = 51;
            // 
            // boroughTextBox
            // 
            this.boroughTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Borough", true));
            this.boroughTextBox.Location = new System.Drawing.Point(980, 63);
            this.boroughTextBox.Name = "boroughTextBox";
            this.boroughTextBox.Size = new System.Drawing.Size(104, 21);
            this.boroughTextBox.TabIndex = 53;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(980, 90);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(104, 21);
            this.cityTextBox.TabIndex = 55;
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(980, 117);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(104, 21);
            this.zipcodeTextBox.TabIndex = 57;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(980, 144);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(104, 21);
            this.countryTextBox.TabIndex = 59;
            // 
            // nameAgentTextBox
            // 
            this.nameAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "nameAgent", true));
            this.nameAgentTextBox.Location = new System.Drawing.Point(980, 177);
            this.nameAgentTextBox.Name = "nameAgentTextBox";
            this.nameAgentTextBox.Size = new System.Drawing.Size(104, 21);
            this.nameAgentTextBox.TabIndex = 61;
            // 
            // commentAgentTextBox
            // 
            this.commentAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "commentAgent", true));
            this.commentAgentTextBox.Location = new System.Drawing.Point(980, 204);
            this.commentAgentTextBox.Name = "commentAgentTextBox";
            this.commentAgentTextBox.Size = new System.Drawing.Size(104, 21);
            this.commentAgentTextBox.TabIndex = 63;
            // 
            // statusPropertiesTextBox
            // 
            this.statusPropertiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "statusProperties", true));
            this.statusPropertiesTextBox.Location = new System.Drawing.Point(980, 231);
            this.statusPropertiesTextBox.Name = "statusPropertiesTextBox";
            this.statusPropertiesTextBox.Size = new System.Drawing.Size(104, 21);
            this.statusPropertiesTextBox.TabIndex = 65;
            // 
            // nameOwnerTextBox
            // 
            this.nameOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "nameOwner", true));
            this.nameOwnerTextBox.Location = new System.Drawing.Point(980, 258);
            this.nameOwnerTextBox.Name = "nameOwnerTextBox";
            this.nameOwnerTextBox.Size = new System.Drawing.Size(104, 21);
            this.nameOwnerTextBox.TabIndex = 67;
            // 
            // addressOwnerTextBox
            // 
            this.addressOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "addressOwner", true));
            this.addressOwnerTextBox.Location = new System.Drawing.Point(980, 285);
            this.addressOwnerTextBox.Name = "addressOwnerTextBox";
            this.addressOwnerTextBox.Size = new System.Drawing.Size(104, 21);
            this.addressOwnerTextBox.TabIndex = 69;
            // 
            // requestOwnerTextBox
            // 
            this.requestOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "requestOwner", true));
            this.requestOwnerTextBox.Location = new System.Drawing.Point(980, 312);
            this.requestOwnerTextBox.Name = "requestOwnerTextBox";
            this.requestOwnerTextBox.Size = new System.Drawing.Size(104, 21);
            this.requestOwnerTextBox.TabIndex = 71;
            // 
            // inforOwnerTextBox
            // 
            this.inforOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "inforOwner", true));
            this.inforOwnerTextBox.Location = new System.Drawing.Point(980, 339);
            this.inforOwnerTextBox.Name = "inforOwnerTextBox";
            this.inforOwnerTextBox.Size = new System.Drawing.Size(104, 21);
            this.inforOwnerTextBox.TabIndex = 73;
            // 
            // offerTextBox
            // 
            this.offerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "offer", true));
            this.offerTextBox.Location = new System.Drawing.Point(737, 371);
            this.offerTextBox.Name = "offerTextBox";
            this.offerTextBox.Size = new System.Drawing.Size(104, 21);
            this.offerTextBox.TabIndex = 75;
            // 
            // offerMakerTextBox
            // 
            this.offerMakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "offerMaker", true));
            this.offerMakerTextBox.Location = new System.Drawing.Point(737, 400);
            this.offerMakerTextBox.Name = "offerMakerTextBox";
            this.offerMakerTextBox.Size = new System.Drawing.Size(104, 21);
            this.offerMakerTextBox.TabIndex = 77;
            // 
            // offerConditionTextBox
            // 
            this.offerConditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "offerCondition", true));
            this.offerConditionTextBox.Location = new System.Drawing.Point(737, 426);
            this.offerConditionTextBox.Name = "offerConditionTextBox";
            this.offerConditionTextBox.Size = new System.Drawing.Size(104, 21);
            this.offerConditionTextBox.TabIndex = 79;
            // 
            // actionTextBox
            // 
            this.actionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table01BindingSource, "Action", true));
            this.actionTextBox.Location = new System.Drawing.Point(737, 9);
            this.actionTextBox.Name = "actionTextBox";
            this.actionTextBox.Size = new System.Drawing.Size(104, 21);
            this.actionTextBox.TabIndex = 81;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(408, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 82;
            this.button3.Text = "Detail";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Detail_button);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "Enter Id for Detail";
            // 
            // Id_Detail
            // 
            this.Id_Detail.Location = new System.Drawing.Point(462, 371);
            this.Id_Detail.Name = "Id_Detail";
            this.Id_Detail.Size = new System.Drawing.Size(121, 21);
            this.Id_Detail.TabIndex = 84;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(462, 432);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 21);
            this.Password.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 12);
            this.label12.TabIndex = 86;
            this.label12.Text = "Enter Password for ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 87;
            this.label13.Text = "Offer Detail";
            // 
            // Offer_Detail
            // 
            this.Offer_Detail.Location = new System.Drawing.Point(408, 462);
            this.Offer_Detail.Name = "Offer_Detail";
            this.Offer_Detail.Size = new System.Drawing.Size(75, 23);
            this.Offer_Detail.TabIndex = 88;
            this.Offer_Detail.Text = "Offer";
            this.Offer_Detail.UseVisualStyleBackColor = true;
            this.Offer_Detail.Click += new System.EventHandler(this.Offer_Detail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 497);
            this.Controls.Add(this.Offer_Detail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Id_Detail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(houseTypeLabel);
            this.Controls.Add(this.houseTypeTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(squareFootageLabel);
            this.Controls.Add(this.squareFootageTextBox);
            this.Controls.Add(lotSizeLabel);
            this.Controls.Add(this.lotSizeTextBox);
            this.Controls.Add(bedroomsLabel);
            this.Controls.Add(this.bedroomsTextBox);
            this.Controls.Add(bathroomsLabel);
            this.Controls.Add(this.bathroomsTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(applianceLabel);
            this.Controls.Add(this.applianceTextBox);
            this.Controls.Add(isBasementLabel);
            this.Controls.Add(this.isBasementCheckBox);
            this.Controls.Add(isParkingLabel);
            this.Controls.Add(this.isParkingCheckBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(boroughLabel);
            this.Controls.Add(this.boroughTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(nameAgentLabel);
            this.Controls.Add(this.nameAgentTextBox);
            this.Controls.Add(commentAgentLabel);
            this.Controls.Add(this.commentAgentTextBox);
            this.Controls.Add(statusPropertiesLabel);
            this.Controls.Add(this.statusPropertiesTextBox);
            this.Controls.Add(nameOwnerLabel);
            this.Controls.Add(this.nameOwnerTextBox);
            this.Controls.Add(addressOwnerLabel);
            this.Controls.Add(this.addressOwnerTextBox);
            this.Controls.Add(requestOwnerLabel);
            this.Controls.Add(this.requestOwnerTextBox);
            this.Controls.Add(inforOwnerLabel);
            this.Controls.Add(this.inforOwnerTextBox);
            this.Controls.Add(offerLabel);
            this.Controls.Add(this.offerTextBox);
            this.Controls.Add(offerMakerLabel);
            this.Controls.Add(this.offerMakerTextBox);
            this.Controls.Add(offerConditionLabel);
            this.Controls.Add(this.offerConditionTextBox);
            this.Controls.Add(actionLabel);
            this.Controls.Add(this.actionTextBox);
            this.Controls.Add(this.descriptionBindingNavigator);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zipcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Minlot);
            this.Controls.Add(this.bathroom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.garage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Maxbed);
            this.Controls.Add(this.Minbed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Minprice);
            this.Controls.Add(this.Maxprice);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingNavigator)).EndInit();
            this.descriptionBindingNavigator.ResumeLayout(false);
            this.descriptionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table01BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Minprice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Minbed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox garage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Minlot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Maxprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Maxbed;
        private System.Windows.Forms.ComboBox bathroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox zipcode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private propertiesDataSet propertiesDataSet;
        private System.Windows.Forms.BindingSource descriptionBindingSource;
        private propertiesDataSetTableAdapters.DescriptionTableAdapter descriptionTableAdapter;
        private propertiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator descriptionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton descriptionBindingNavigatorSaveItem;
        private propertiesDataSet1 propertiesDataSet1;
        private System.Windows.Forms.BindingSource table01BindingSource;
        private propertiesDataSet1TableAdapters.Table01TableAdapter table01TableAdapter;
        private propertiesDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox houseTypeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox squareFootageTextBox;
        private System.Windows.Forms.TextBox lotSizeTextBox;
        private System.Windows.Forms.TextBox bedroomsTextBox;
        private System.Windows.Forms.TextBox bathroomsTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox applianceTextBox;
        private System.Windows.Forms.CheckBox isBasementCheckBox;
        private System.Windows.Forms.CheckBox isParkingCheckBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox boroughTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox nameAgentTextBox;
        private System.Windows.Forms.TextBox commentAgentTextBox;
        private System.Windows.Forms.TextBox statusPropertiesTextBox;
        private System.Windows.Forms.TextBox nameOwnerTextBox;
        private System.Windows.Forms.TextBox addressOwnerTextBox;
        private System.Windows.Forms.TextBox requestOwnerTextBox;
        private System.Windows.Forms.TextBox inforOwnerTextBox;
        private System.Windows.Forms.TextBox offerTextBox;
        private System.Windows.Forms.TextBox offerMakerTextBox;
        private System.Windows.Forms.TextBox offerConditionTextBox;
        private System.Windows.Forms.TextBox actionTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Id_Detail;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Offer_Detail;
    }
}

