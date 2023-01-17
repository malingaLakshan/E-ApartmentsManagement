using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyStore.UI;
using System.Xml.Linq;
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;
using static System.Windows.Forms.AxHost;
using System.Runtime.InteropServices.ComTypes;

namespace E_ApartmentsManagement.UI
{
    public partial class Apartment : Form
    {
        BuildingDAL buildingDAL = new BuildingDAL();
        ParkingDAL parkingDAL = new ParkingDAL();
        ClassDAL classDAL = new ClassDAL();
       

        ApartmentDAL apartmentDAL = new ApartmentDAL();
        ApartmentBLL apartmentBLL = new ApartmentBLL();
        UserDAL userDAL = new UserDAL();
        public Apartment()
        {
            InitializeComponent();
            frmBuildings_Load();
            ParkingSpaces_Load();
            Class_Load();

            //Refresh Data Grid View
            DataTable dt = apartmentDAL.Select();
            dgvApartment.DataSource = dt;

            txtRefundableAmount.ReadOnly = true;
            txtMr.ReadOnly = true;
            txtMO.ReadOnly = true;
            txtRf.ReadOnly = true;
            txtName.ReadOnly= false;

            if (cmbState.Text.Equals("Available"))
            {
                lblRelease.Text = "This Apartment Is Available Now";
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get All the Values from Building Form
            apartmentBLL.name = txtName.Text;
            apartmentBLL.location = txtLocation.Text;
            apartmentBLL.floarArea = txtFa.Text;
            apartmentBLL.apartmentStates = cmbState.Text;
            apartmentBLL.buildingId =int.Parse(cmdBuilding.SelectedValue.ToString());
            apartmentBLL.parkingSpaceId = int.Parse(cmbParking.SelectedValue.ToString());
            apartmentBLL.classTypeId = int.Parse(cmbClassType.SelectedValue.ToString());
            apartmentBLL.description = txtDescription.Text;
            apartmentBLL.added_date = DateTime.Now;


            if (cmbState.Text.Equals("Available"))
            {
                apartmentBLL.active_state = true;
            }
            else
            {
                apartmentBLL.active_state = false;
            }


            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = userDAL.GetIDFromUsername(loggedUser);

            apartmentBLL.added_by = usr.userId;

            //Create Boolean variable to check if the apartment is added successfully or not
            bool success = apartmentDAL.Insert(apartmentBLL);


            //If the apartment is inserted successfully then the value of the success will be true else it will be false
            if (success == true)
            {

                //apartment Inserted Successfully
                MessageBox.Show("New Apartment Inserted Successfully.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = apartmentDAL.Select();
                dgvApartment.DataSource = dt;
                
                //update the parking space status
                updateParkingStatus(apartmentBLL.parkingSpaceId);
                ParkingSpaces_Load();
            }
            else
            {
                //FAiled to Insert apartment
                MessageBox.Show("Failed to Insert apartment Type.");
            }
        }

        public void Clear()
        {
            txtName.Text = "";
            txtLocation.Text = "";
            txtFa.Text = "";
            txtRf.Text = "";
            cmbState.Text = "";
            cmdBuilding.Text = "";
            cmbParking.Text = "";
            cmbClassType.Text = "";
            txtDescription.Text = "";
          

        }

        private void Apartment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBuildings_Load()
        {
            //Creating DAta Table to hold the buildings from Database
            DataTable buildings = buildingDAL.Select();
            //Specify DataSource for buildings ComboBox
            cmdBuilding.DataSource = buildings;
            //Specify Display Member and Value Member for Combobox
            cmdBuilding.DisplayMember = "name";
            cmdBuilding.ValueMember = "id";
        }

        private void ParkingSpaces_Load()
        {
            //Creating DAta Table to hold the buildings from Database
            DataTable parkings = parkingDAL.SearchByState(1); ;
            //Specify DataSource for buildings ComboBox
            cmbParking.DataSource = parkings;
            //Specify Display Member and Value Member for Combobox
            cmbParking.DisplayMember = "name";
            cmbParking.ValueMember = "id";
        }

        private void Class_Load()
        {
            //Creating DAta Table to hold the buildings from Database
            DataTable classes = classDAL.Select();
            //Specify DataSource for buildings ComboBox
            cmbClassType.DataSource = classes;
            //Specify Display Member and Value Member for Combobox
            cmbClassType.DisplayMember = "name";
            cmbClassType.ValueMember = "id";
        }

        private void cmbClassType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        public void getClassDetails()
        {
            // getClassDetails();
            //Get the Keywordss from Form
            string keywords = cmbClassType.Text;

            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT * FROM class_type where name = @name", conn);
            cmd.Parameters.AddWithValue("@name", keywords);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String refundableAmount = dr["refundable_amount"].ToString();
                String monthlyRent = dr["monthly_rent"].ToString();
                String maxOccupents = dr["max_occupent"].ToString();
                String reservationFee = dr["reservation_fee"].ToString();

                txtRefundableAmount.Text = refundableAmount;
                txtMr.Text = monthlyRent;
                txtMO.Text = maxOccupents;
                txtRf.Text = reservationFee;


            }
        }

        private void cmbClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string keywords = cmbClassType.Text;

            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT * FROM class_type where name = @name",conn);
            cmd.Parameters.AddWithValue("@name",keywords);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String refundableAmount = dr["refundable_amount"].ToString();
                String monthlyRent = dr["monthly_rent"].ToString();
                String maxOccupents = dr["max_occupent"].ToString();
                String reservationFee = dr["reservation_fee"].ToString();

                txtRefundableAmount.Text = refundableAmount;
                txtMr.Text = monthlyRent;
                txtMO.Text = maxOccupents;
                txtRf.Text = reservationFee;


            }

        }

        private void dgvApartment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer variable to know which Apartment was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txtID.Text = dgvApartment.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvApartment.Rows[rowIndex].Cells[1].Value.ToString();
            txtLocation.Text = dgvApartment.Rows[rowIndex].Cells[2].Value.ToString();
            txtFa.Text = dgvApartment.Rows[rowIndex].Cells[3].Value.ToString();
            cmbState.Text = dgvApartment.Rows[rowIndex].Cells[4].Value.ToString();

            //get building name from id to set the text fields
            int buildingID = int.Parse(dgvApartment.Rows[rowIndex].Cells[5].Value.ToString());
            String getBuildingName = buildingDAL.searchBuildingNameById(buildingID);
            cmdBuilding.Text = getBuildingName;


            //get parking name from id to set the text fields
            int parkingSpaceID = int.Parse(dgvApartment.Rows[rowIndex].Cells[6].Value.ToString());
            String getParkingSpaceName = parkingDAL.searchParkingById(parkingSpaceID);
            cmbParking.Text = getParkingSpaceName;


            //get class name from id to set the text fields
            int classTypeId = int.Parse(dgvApartment.Rows[rowIndex].Cells[7].Value.ToString());
            String getClassTypeName = classDAL.searchClassById(classTypeId);
            cmbClassType.Text = getClassTypeName;

            getClassDetails();

            txtDescription.Text = dgvApartment.Rows[rowIndex].Cells[8].Value.ToString();


        }

        public void updateParkingStatus(int parkingSpaceId)
        {
            bool success = parkingDAL.UpdateParkingAvailableState(parkingSpaceId);
            //If the Parking State is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Parking updated Successfully
                MessageBox.Show("Parking Status Updated."+ parkingSpaceId + "is not available now");
                Clear();
                //REfresh the Data Grid View
              /*  DataTable dt = d.Select();
                dgvParking.DataSource = dt;*/
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Parking State");
            }
        }
    }
}
