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
using System.Xml.Linq;
using AnyStore.UI;
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Button = System.Windows.Forms.Button;

namespace E_ApartmentsManagement.UI
{
    public partial class FormUsers : Form
    {
        String roleCome;
        String username;
        UserDAL UserDAL = new UserDAL();
        UserDAL udal = new UserDAL();
        UserBLL b = new UserBLL();
   
        public FormUsers()
        {
            InitializeComponent();
            AdmindashBoard admindashBoard = new AdmindashBoard();
            roleCome=admindashBoard.role.Trim().ToString();
            Console.WriteLine(roleCome);
            username = admindashBoard.username.Trim().ToString();


            DataTable dt = udal.Select();
            userTbl.DataSource = dt;

            //if role is CUSTOMER limit the access levels
            if (roleCome.Equals("Customer"))
            {
                btnSave.Dispose();
                btnUpdate.Dispose();
                btnDelete.Dispose();
                userTbl.Dispose();
                lblSearch.Dispose();
                txtSearch.Dispose();

                UserBLL usr = UserDAL.GetIDFromUsername(username);
                txtId.Text = usr.userId.ToString();
                firstName.Text = usr.firstName;
                lastName.Text = usr.lastName;
                roleComboBox.Text = usr.role;
                nic.Text= usr.nic;
                address.Text = usr.address;
                txtEmail.Text = usr.email;
                txtUsername.Text = usr.username;

                if (usr.gender.Equals("Male"))
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = false;
                }
                
            }
         

            // LoadTheme();
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
           /* role.ForeColor = ThemeColor.SecondaryColor;
            lblFName.ForeColor = ThemeColor.SecondaryColor;
            lblLName.ForeColor = ThemeColor.SecondaryColor;*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
    

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
            txtId.Text = "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Search the products
                DataTable dt = UserDAL.Search(keywords);
                userTbl.DataSource = dt;
            }
            else
            {
                //Display All the products
                DataTable dt = UserDAL.Select();
                userTbl.DataSource = dt;
            }
        }
       

        private void userTbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer variable to know which product was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txtId.Text = userTbl.Rows[rowIndex].Cells[0].Value.ToString();
            firstName.Text = userTbl.Rows[rowIndex].Cells[1].Value.ToString();
            lastName.Text = userTbl.Rows[rowIndex].Cells[2].Value.ToString();
            roleComboBox.Text = userTbl.Rows[rowIndex].Cells[3].Value.ToString();
            nic.Text = userTbl.Rows[rowIndex].Cells[4].Value.ToString();
            address.Text = userTbl.Rows[rowIndex].Cells[5].Value.ToString();
            contact.Text = userTbl.Rows[rowIndex].Cells[6].Value.ToString();
            radioButtonMale.Checked = true;
            txtEmail.Text = userTbl.Rows[rowIndex].Cells[8].Value.ToString();
            txtUsername.Text = userTbl.Rows[rowIndex].Cells[9].Value.ToString();
            txtPassword.Text = userTbl.Rows[rowIndex].Cells[10].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //GEt the ID of the user to be deleted
            b.userId = int.Parse(txtId.Text);

            //Create Bool Variable to Check if the user is deleted or not
            bool success = UserDAL.Delete(b);

            //If user is deleted successfully then the value of success will true else it will be false
            if (success == true)
            {
                //Building Successfuly Deleted
                MessageBox.Show("User successfully deleted.");
                //  Clear();
                //Refresh Data Grid View
                DataTable dt = UserDAL.Select();
                userTbl.DataSource = dt;
            }
            else
            {
                //Failed to Delete user
                MessageBox.Show("Failed to Delete user.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.added_date = DateTime.Now;
            u.userId = int.Parse(txtId .Text);

            /*    //Getting username of logged in user
                string loggedUser = frmLogin.loggedIn;
                UserBLL usr = udal.GetIDFromUsername(loggedUser);*/


            //Create a boolean variable to check if the building is updated or not
            bool success = UserDAL.Update(u);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Product updated Successfully
                MessageBox.Show("Building Successfully Updated");
                clear();
                //REfresh the Data Grid View
                DataTable dt = UserDAL.Select();
                userTbl.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Building");
            }
        }
    }
}
