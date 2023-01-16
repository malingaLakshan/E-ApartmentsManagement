namespace E_ApartmentsManagement.UI
{
    partial class FormUsers
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
            this.btnSave = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.btnUpdates = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 54);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // role
            // 
            this.role.Location = new System.Drawing.Point(11, 121);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(100, 23);
            this.role.TabIndex = 1;
            this.role.Text = "Role";
            this.role.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFName
            // 
            this.lblFName.Location = new System.Drawing.Point(11, 15);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(100, 23);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "FirstName";
            this.lblFName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLName
            // 
            this.lblLName.Location = new System.Drawing.Point(11, 72);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(100, 16);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "LastName";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(100, 12);
            this.firstName.MinimumSize = new System.Drawing.Size(100, 30);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(239, 30);
            this.firstName.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(100, 69);
            this.lastName.MinimumSize = new System.Drawing.Size(100, 30);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(239, 30);
            this.lastName.TabIndex = 3;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "ADMIN",
            "CUSTOMER"});
            this.roleComboBox.Location = new System.Drawing.Point(100, 121);
            this.roleComboBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(239, 24);
            this.roleComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nic";
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(100, 170);
            this.nic.MinimumSize = new System.Drawing.Size(100, 30);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(239, 30);
            this.nic.TabIndex = 3;
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(365, 109);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(100, 16);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(454, 103);
            this.contact.MinimumSize = new System.Drawing.Size(100, 30);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(239, 30);
            this.contact.TabIndex = 3;
            // 
            // lbladdress
            // 
            this.lbladdress.Location = new System.Drawing.Point(365, 15);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(79, 16);
            this.lbladdress.TabIndex = 2;
            this.lbladdress.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(454, 15);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(239, 53);
            this.address.TabIndex = 5;
            this.address.Text = "";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(365, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(454, 180);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMale.TabIndex = 6;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(534, 180);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemale.TabIndex = 6;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnUpdates
            // 
            this.btnUpdates.Location = new System.Drawing.Point(404, 250);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(117, 54);
            this.btnUpdates.TabIndex = 0;
            this.btnUpdates.Text = "Update";
            this.btnUpdates.UseVisualStyleBackColor = true;
            this.btnUpdates.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(549, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 54);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 238);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(716, 18);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(716, 75);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(805, 15);
            this.txtEmail.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(716, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(805, 72);
            this.txtUsername.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 30);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(805, 173);
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // FormUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1335, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.address);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.nic);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.role);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdates);
            this.Controls.Add(this.btnSave);
            this.Name = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}