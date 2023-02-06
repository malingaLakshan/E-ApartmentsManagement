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
    public partial class frmBuildings : Form
    {
        UserDAL udal = new UserDAL();
        BuildingBLL b = new BuildingBLL();
        BuildingDAL d = new BuildingDAL();
        public frmBuildings()
        {
            InitializeComponent();
            txtID.ReadOnly = true;
           
            DataTable dt = d.Select();
            dgvBuilding.DataSource = dt;

            UserDashboard u = new UserDashboard();
            if (u.role.Equals("Customer"))
            {
                btnAdd.Dispose();
                btnUpdate.Dispose();
                btnDelete.Dispose();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get All the Values from Building Form
            b.name = txtName.Text;
            b.city = cmbCity.Text;
            b.address = txtAddress.Text;
            b.contact = txtContact.Text;
            b.added_date = DateTime.Now;

            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            b.added_by = usr.userId;

            //Create Boolean variable to check if the building is added successfully or not
            bool success = d.Insert(b);


            //If the Building is inserted successfully then the value of the success will be true else it will be false
            if (success == true)
            {
                //Building Inserted Successfully
                MessageBox.Show("New Building Inserted Successfully.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = d.Select();
                dgvBuilding.DataSource = dt;
            }
            else
            {
                //FAiled to Insert New Building
                MessageBox.Show("Failed to Insert New Building.");
            }
        }
        public void Clear()
        {
            txtName.Text = "";
            cmbCity.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
        }

        private void frmBuildings_Load(object sender, EventArgs e)
        {

        }

        private void dgvBuilding_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer variable to know which product was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txtID.Text = dgvBuilding.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvBuilding.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCity.Text = dgvBuilding.Rows[rowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dgvBuilding.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvBuilding.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Search the products
                DataTable dt = d.Search(keywords);
                dgvBuilding.DataSource = dt;
            }
            else
            {
                //Display All the products
                DataTable dt = d.Select();
                dgvBuilding.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            b.id = int.Parse(txtID.Text);
            b.name= txtName.Text;
            b.city = cmbCity.Text;
            b.address = txtAddress.Text;
            b.contact = txtContact.Text;
            b.added_date = DateTime.Now;

            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            b.added_by = usr.userId;

            //Create a boolean variable to check if the building is updated or not
            bool success = d.Update(b);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Product updated Successfully
                MessageBox.Show("Building Successfully Updated");
                Clear();
                //REfresh the Data Grid View
                DataTable dt = d.Select();
                dgvBuilding.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Building");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //GEt the ID of the Building to be deleted
            b.id = int.Parse(txtID.Text);

            //Create Bool Variable to Check if the Building is deleted or not
            bool success = d.Delete(b);

            //If Building is deleted successfully then the value of success will true else it will be false
            if (success == true)
            {
                //Building Successfuly Deleted
                MessageBox.Show("Building successfully deleted.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = d.Select();
                dgvBuilding.DataSource = dt;
            }
            else
            {
                //Failed to Delete Building
                MessageBox.Show("Failed to Delete Building.");
            }
        }

        private void dgvBuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
