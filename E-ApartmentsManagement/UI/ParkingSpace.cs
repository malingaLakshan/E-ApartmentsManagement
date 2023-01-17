using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyStore.UI;
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;

namespace E_ApartmentsManagement.UI
{
    public partial class ParkingSpace : Form
    {
        UserDAL udal = new UserDAL();
        ParkingBLL parking = new ParkingBLL();
        ParkingDAL d = new ParkingDAL();
        public ParkingSpace()
        {
            InitializeComponent();
            DataTable dt = d.Select();
            dgvParking.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Get All the Values from Building Form
            parking.name = txtName.Text;
            parking.description = txtDescription.Text;
            if (cmbState.Text.Equals("Available"))
            {
                parking.active_state = true;
            }
            else
            {
                parking.active_state = false;
            }
            
            parking.added_date = DateTime.Now;

            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            parking.added_by = usr.userId;

            //Create Boolean variable to check if the Parking is added successfully or not
            bool success = d.Insert(parking);


            //If the Parking is inserted successfully then the value of the success will be true else it will be false
            if (success == true)
            {
                //Parking Inserted Successfully
                MessageBox.Show("New Parking Inserted Successfully.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = d.Select();
                dgvParking.DataSource = dt;
            }
            else
            {
                //FAiled to Insert New Parking
                MessageBox.Show("Failed to Insert New Building.");
            }
        }

        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            
        }

        private void ParkingSpace_Load(object sender, EventArgs e)
        {

        }

        private void dgvParking_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer variable to know which Parking was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txtID.Text = dgvParking.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvParking.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvParking.Rows[rowIndex].Cells[2].Value.ToString();
            cmbState.Text = dgvParking.Rows[rowIndex].Cells[3].Value.ToString();
            if (dgvParking.Rows[rowIndex].Cells[3].Value.ToString().Equals("1"))
            {
                cmbState.Text = "Available";
            }
            else
            {
                cmbState.Text = "Reserved";
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Search the Parking
                DataTable dt = d.Search(keywords);
                dgvParking.DataSource = dt;
            }
            else
            {
                //Display All the Parking
                DataTable dt = d.Select();
                dgvParking.DataSource = dt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string keywords = comStateSearch.Text;
            int state = 0;
            if (keywords.Equals("Available"))
            {
                state= 1;
            }else if (keywords.Equals("Reserved"))
            {
                state = 0;
            }
            else if(keywords.Equals("All"))
            {
                keywords = null;
            }


            if (keywords != null)
            {
                //Search the Parking
                DataTable dt = d.SearchByState(state);
                dgvParking.DataSource = dt;
            }
            else
            {
                //Display All the Parking
                DataTable dt = d.Select();
                dgvParking.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            parking.id = int.Parse(txtID.Text);
            parking.name = txtName.Text;
            parking.description = txtDescription.Text;

            if (cmbState.Text.Equals("Available"))
            {
                parking.active_state = true;
            }
            else
            {
                parking.active_state = false;
            }

            parking.added_date = DateTime.Now;

            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            parking.added_by = usr.userId;


            //Create a boolean variable to check if the building is updated or not
            bool success = d.Update(parking);
            //If the Parking is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Parking updated Successfully
                MessageBox.Show("Parking Successfully Updated");
                Clear();
                //REfresh the Data Grid View
                DataTable dt = d.Select();
                dgvParking.DataSource = dt;
            }
            else
            {
                //Failed to Update Parking
                MessageBox.Show("Failed to Update Parking");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //GEt the ID of the Building to be deleted
            parking.id = int.Parse(txtID.Text);

            //Create Bool Variable to Check if the Building is deleted or not
            bool success = d.Delete(parking);

            //If Parking is deleted successfully then the value of success will true else it will be false
            if (success == true)
            {
                //Parking Successfuly Deleted
                MessageBox.Show("Parking successfully deleted.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = d.Select();
                dgvParking.DataSource = dt;
            }
            else
            {
                //Failed to Delete Parking
                MessageBox.Show("Failed to Delete Parking.");
            }
        }
    }
 }
    

