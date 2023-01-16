using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Button = System.Windows.Forms.Button;

namespace E_ApartmentsManagement.UI
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            LoadTheme();
        }

        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            role.ForeColor = ThemeColor.SecondaryColor;
            lblFName.ForeColor = ThemeColor.SecondaryColor;
            lblLName.ForeColor = ThemeColor.SecondaryColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Gettting Data FRom UI

            u.firstName = firstName.Text;
            u.lastName = lastName.Text;

            object b = roleComboBox.SelectedItem;
            u.role = Convert.ToString(b);

            u.nic = nic.Text;
            u.address = address.Text;
            u.contact = contact.Text;

            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                u.gender = "Male";
            }
            else
            {
                u.gender = "Female";
            }
            u.email = txtEmail.Text;
            u.username= txtUsername.Text;
            u.password= txtPassword.Text;
            u.added_date = DateTime.Now;

            //Inserting Data into DAtabase
            bool success = dal.Insert(u);
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("User successfully created.");
                clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new user");
            }

        }

        private void clear()
        {
            firstName.Text = "";
            lastName.Text = "";
            role.Text = "";
            nic.Text = "";
            address.Text = "";
            contact.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text= "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
