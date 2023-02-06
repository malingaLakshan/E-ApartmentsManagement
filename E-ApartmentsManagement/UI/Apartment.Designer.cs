namespace E_ApartmentsManagement.UI
{
    partial class Apartment
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvApartment = new System.Windows.Forms.DataGridView();
            this.cmbParking = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClassType = new System.Windows.Forms.ComboBox();
            this.lblBuildingID = new System.Windows.Forms.Label();
            this.cmdBuilding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRf = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRefundableAmount = new System.Windows.Forms.TextBox();
            this.txtFa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbCityS = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbClassTypeS = new System.Windows.Forms.ComboBox();
            this.cmbStatusS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dateS = new System.Windows.Forms.DateTimePicker();
            this.lblLP = new System.Windows.Forms.Label();
            this.cmbLeas = new System.Windows.Forms.ComboBox();
            this.cmbLS = new System.Windows.Forms.ComboBox();
            this.lblLS = new System.Windows.Forms.Label();
            this.lblDateBuy = new System.Windows.Forms.Label();
            this.dateTimePickerBuy = new System.Windows.Forms.DateTimePicker();
            this.btnRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1115, 664);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 62);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(943, 664);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 62);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(771, 664);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 62);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvApartment
            // 
            this.dgvApartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartment.Location = new System.Drawing.Point(573, 61);
            this.dgvApartment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApartment.Name = "dgvApartment";
            this.dgvApartment.RowHeadersWidth = 51;
            this.dgvApartment.Size = new System.Drawing.Size(917, 451);
            this.dgvApartment.TabIndex = 29;
            this.dgvApartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartment_CellContentClick);
            this.dgvApartment.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApartment_RowHeaderMouseClick);
            // 
            // cmbParking
            // 
            this.cmbParking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParking.FormattingEnabled = true;
            this.cmbParking.Location = new System.Drawing.Point(204, 186);
            this.cmbParking.Margin = new System.Windows.Forms.Padding(4);
            this.cmbParking.Name = "cmbParking";
            this.cmbParking.Size = new System.Drawing.Size(297, 29);
            this.cmbParking.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(204, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(297, 29);
            this.txtID.TabIndex = 24;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(61, 186);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(116, 23);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Parking Space";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(58, 439);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Floar Area";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(61, 18);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(114, 23);
            this.lblProductID.TabIndex = 19;
            this.lblProductID.Text = "Apartment ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Class Type";
            // 
            // cmbClassType
            // 
            this.cmbClassType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassType.FormattingEnabled = true;
            this.cmbClassType.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Suite"});
            this.cmbClassType.Location = new System.Drawing.Point(204, 232);
            this.cmbClassType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClassType.Name = "cmbClassType";
            this.cmbClassType.Size = new System.Drawing.Size(297, 29);
            this.cmbClassType.TabIndex = 26;
            this.cmbClassType.SelectedIndexChanged += new System.EventHandler(this.cmbClassType_SelectedIndexChanged);
            this.cmbClassType.SelectedValueChanged += new System.EventHandler(this.cmbClassType_SelectedValueChanged);
            // 
            // lblBuildingID
            // 
            this.lblBuildingID.AutoSize = true;
            this.lblBuildingID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingID.Location = new System.Drawing.Point(61, 147);
            this.lblBuildingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildingID.Name = "lblBuildingID";
            this.lblBuildingID.Size = new System.Drawing.Size(94, 23);
            this.lblBuildingID.TabIndex = 41;
            this.lblBuildingID.Text = "Building ID";
            // 
            // cmdBuilding
            // 
            this.cmdBuilding.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuilding.FormattingEnabled = true;
            this.cmdBuilding.Location = new System.Drawing.Point(204, 144);
            this.cmdBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBuilding.Name = "cmdBuilding";
            this.cmdBuilding.Size = new System.Drawing.Size(297, 29);
            this.cmdBuilding.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Monthly Rent";
            // 
            // txtMr
            // 
            this.txtMr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMr.Location = new System.Drawing.Point(367, 317);
            this.txtMr.Margin = new System.Windows.Forms.Padding(4);
            this.txtMr.Name = "txtMr";
            this.txtMr.Size = new System.Drawing.Size(134, 29);
            this.txtMr.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "max Occupents";
            // 
            // txtMO
            // 
            this.txtMO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMO.Location = new System.Drawing.Point(367, 354);
            this.txtMO.Margin = new System.Windows.Forms.Padding(4);
            this.txtMO.Name = "txtMO";
            this.txtMO.Size = new System.Drawing.Size(134, 29);
            this.txtMO.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 391);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reservation Fee";
            // 
            // txtRf
            // 
            this.txtRf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRf.Location = new System.Drawing.Point(367, 391);
            this.txtRf.Margin = new System.Windows.Forms.Padding(4);
            this.txtRf.Name = "txtRf";
            this.txtRf.Size = new System.Drawing.Size(134, 29);
            this.txtRf.TabIndex = 25;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.FormattingEnabled = true;
            this.txtLocation.Items.AddRange(new object[] {
            "Moratuwa",
            "Kollupitya",
            "Bambalapitiya",
            "Colombo Fort",
            "Maradana",
            "Nugegoda",
            "Dehiwala",
            "Rathmalana",
            "Angulana",
            "Lunawa",
            "Baththaramulla"});
            this.txtLocation.Location = new System.Drawing.Point(204, 101);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(297, 29);
            this.txtLocation.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Location City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Refundable Amount";
            // 
            // txtRefundableAmount
            // 
            this.txtRefundableAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundableAmount.Location = new System.Drawing.Point(367, 280);
            this.txtRefundableAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefundableAmount.Name = "txtRefundableAmount";
            this.txtRefundableAmount.Size = new System.Drawing.Size(134, 29);
            this.txtRefundableAmount.TabIndex = 25;
            // 
            // txtFa
            // 
            this.txtFa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFa.Location = new System.Drawing.Point(204, 439);
            this.txtFa.Margin = new System.Windows.Forms.Padding(4);
            this.txtFa.Name = "txtFa";
            this.txtFa.Size = new System.Drawing.Size(297, 29);
            this.txtFa.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Apartment Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(204, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(297, 29);
            this.txtName.TabIndex = 24;
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Unavailable",
            "Reserved"});
            this.cmbState.Location = new System.Drawing.Point(204, 486);
            this.cmbState.Margin = new System.Windows.Forms.Padding(4);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(297, 29);
            this.cmbState.TabIndex = 26;
            this.cmbState.Text = "Available";
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 489);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Apartment Status";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelease.Location = new System.Drawing.Point(151, 718);
            this.lblRelease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(26, 23);
            this.lblRelease.TabIndex = 20;
            this.lblRelease.Text = "W";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(204, 527);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(297, 75);
            this.txtDescription.TabIndex = 45;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(61, 527);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 23);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Description ";
            // 
            // cmbCityS
            // 
            this.cmbCityS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCityS.FormattingEnabled = true;
            this.cmbCityS.Items.AddRange(new object[] {
            "Moratuwa",
            "Kollupitya",
            "Bambalapitiya",
            "Colombo Fort",
            "Maradana",
            "Nugegoda",
            "Dehiwala",
            "Rathmalana",
            "Angulana",
            "Lunawa",
            "Baththaramulla"});
            this.cmbCityS.Location = new System.Drawing.Point(621, 17);
            this.cmbCityS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCityS.Name = "cmbCityS";
            this.cmbCityS.Size = new System.Drawing.Size(105, 29);
            this.cmbCityS.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(574, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "City";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(734, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Class Type";
            // 
            // cmbClassTypeS
            // 
            this.cmbClassTypeS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassTypeS.FormattingEnabled = true;
            this.cmbClassTypeS.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Suite"});
            this.cmbClassTypeS.Location = new System.Drawing.Point(830, 17);
            this.cmbClassTypeS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClassTypeS.Name = "cmbClassTypeS";
            this.cmbClassTypeS.Size = new System.Drawing.Size(121, 29);
            this.cmbClassTypeS.TabIndex = 26;
            this.cmbClassTypeS.SelectedIndexChanged += new System.EventHandler(this.cmbClassType_SelectedIndexChanged);
            this.cmbClassTypeS.SelectedValueChanged += new System.EventHandler(this.cmbClassType_SelectedValueChanged);
            // 
            // cmbStatusS
            // 
            this.cmbStatusS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusS.FormattingEnabled = true;
            this.cmbStatusS.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Unavailable",
            "Reserved"});
            this.cmbStatusS.Location = new System.Drawing.Point(1101, 18);
            this.cmbStatusS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatusS.Name = "cmbStatusS";
            this.cmbStatusS.Size = new System.Drawing.Size(173, 29);
            this.cmbStatusS.TabIndex = 26;
            this.cmbStatusS.Text = "Available";
            this.cmbStatusS.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(957, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "Apartment Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(573, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(917, 62);
            this.button1.TabIndex = 46;
            this.button1.Text = "ADVANCED SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1282, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Date";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateS
            // 
            this.dateS.Location = new System.Drawing.Point(1336, 23);
            this.dateS.Name = "dateS";
            this.dateS.Size = new System.Drawing.Size(154, 22);
            this.dateS.TabIndex = 47;
            // 
            // lblLP
            // 
            this.lblLP.AutoSize = true;
            this.lblLP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLP.Location = new System.Drawing.Point(61, 610);
            this.lblLP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLP.Name = "lblLP";
            this.lblLP.Size = new System.Drawing.Size(125, 23);
            this.lblLP.TabIndex = 21;
            this.lblLP.Text = "Leasing Pieriod";
            // 
            // cmbLeas
            // 
            this.cmbLeas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLeas.FormattingEnabled = true;
            this.cmbLeas.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 ",
            "4 ",
            "5 "});
            this.cmbLeas.Location = new System.Drawing.Point(204, 610);
            this.cmbLeas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLeas.Name = "cmbLeas";
            this.cmbLeas.Size = new System.Drawing.Size(297, 29);
            this.cmbLeas.TabIndex = 26;
            this.cmbLeas.SelectedIndexChanged += new System.EventHandler(this.cmbClassType_SelectedIndexChanged);
            this.cmbLeas.SelectedValueChanged += new System.EventHandler(this.cmbClassType_SelectedValueChanged);
            // 
            // cmbLS
            // 
            this.cmbLS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLS.FormattingEnabled = true;
            this.cmbLS.Items.AddRange(new object[] {
            "Reserve",
            "Buy"});
            this.cmbLS.Location = new System.Drawing.Point(204, 643);
            this.cmbLS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLS.Name = "cmbLS";
            this.cmbLS.Size = new System.Drawing.Size(297, 29);
            this.cmbLS.TabIndex = 26;
            this.cmbLS.Text = "Buy";
            this.cmbLS.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lblLS
            // 
            this.lblLS.AutoSize = true;
            this.lblLS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLS.Location = new System.Drawing.Point(59, 646);
            this.lblLS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLS.Name = "lblLS";
            this.lblLS.Size = new System.Drawing.Size(118, 23);
            this.lblLS.TabIndex = 41;
            this.lblLS.Text = "Leasing Status";
            // 
            // lblDateBuy
            // 
            this.lblDateBuy.AutoSize = true;
            this.lblDateBuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBuy.Location = new System.Drawing.Point(61, 684);
            this.lblDateBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateBuy.Name = "lblDateBuy";
            this.lblDateBuy.Size = new System.Drawing.Size(46, 23);
            this.lblDateBuy.TabIndex = 41;
            this.lblDateBuy.Text = "Date";
            this.lblDateBuy.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimePickerBuy
            // 
            this.dateTimePickerBuy.Location = new System.Drawing.Point(202, 684);
            this.dateTimePickerBuy.Name = "dateTimePickerBuy";
            this.dateTimePickerBuy.Size = new System.Drawing.Size(299, 22);
            this.dateTimePickerBuy.TabIndex = 47;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRequest.Location = new System.Drawing.Point(573, 609);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(917, 71);
            this.btnRequest.TabIndex = 48;
            this.btnRequest.Text = "SEND LEASE REQUEST";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // Apartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 756);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.dateTimePickerBuy);
            this.Controls.Add(this.dateS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateBuy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBuildingID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvApartment);
            this.Controls.Add(this.cmbClassTypeS);
            this.Controls.Add(this.cmbLeas);
            this.Controls.Add(this.cmbClassType);
            this.Controls.Add(this.cmbCityS);
            this.Controls.Add(this.cmbStatusS);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbLS);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmdBuilding);
            this.Controls.Add(this.cmbParking);
            this.Controls.Add(this.txtRefundableAmount);
            this.Controls.Add(this.txtMr);
            this.Controls.Add(this.txtFa);
            this.Controls.Add(this.txtRf);
            this.Controls.Add(this.txtMO);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblLP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProductID);
            this.Name = "Apartment";
            this.Text = "Apartment";
            this.Load += new System.EventHandler(this.Apartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvApartment;
        private System.Windows.Forms.ComboBox cmbParking;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClassType;
        private System.Windows.Forms.Label lblBuildingID;
        private System.Windows.Forms.ComboBox cmdBuilding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRf;
        private System.Windows.Forms.ComboBox txtLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRefundableAmount;
        private System.Windows.Forms.TextBox txtFa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbCityS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbClassTypeS;
        private System.Windows.Forms.ComboBox cmbStatusS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateS;
        private System.Windows.Forms.Label lblLP;
        private System.Windows.Forms.ComboBox cmbLeas;
        private System.Windows.Forms.ComboBox cmbLS;
        private System.Windows.Forms.Label lblLS;
        private System.Windows.Forms.Label lblDateBuy;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuy;
        private System.Windows.Forms.Button btnRequest;
    }
}