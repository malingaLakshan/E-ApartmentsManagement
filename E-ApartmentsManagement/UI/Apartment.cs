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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        ApartmentLeaseRequestBLL apartmentLeaseRequestBLL = new ApartmentLeaseRequestBLL();
        ApartmentLeaseRequestDAL apartmentLeaseRequestDAL = new ApartmentLeaseRequestDAL();

        String roleCome;
        String username;
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

            /*    if (cmbState.Text.Equals("Available"))
                {
                    lblRelease.Text = "This Apartment Is Available Now";
                }*/

            //limit Customer Access
            AdmindashBoard admindashBoard = new AdmindashBoard();
            roleCome = admindashBoard.role.Trim().ToString();
            Console.WriteLine(roleCome);
            username = admindashBoard.username.Trim().ToString();
            if (roleCome.Equals("Customer"))
            {
                btnAdd.Dispose();
                btnUpdate.Dispose();
                btnDelete.Dispose();
            }


            //Lease button hide from Admin
            if (!roleCome.Equals("Customer"))
            {
                btnRequest.Dispose();
                lblLP.Dispose();
                cmbLeas.Dispose();
                lblLS.Dispose();
                cmbLS.Dispose();
                lblDateBuy.Dispose();
                dateTimePickerBuy.Dispose();
            }
            

            btnRequest.Enabled = false;
            btnRequest.BackColor = Color.Red;

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

            String dt = dgvApartment.Rows[rowIndex].Cells[12].Value.ToString();

            /*           DateTime myDate = DateTime.ParseExact(dt, "yyyy-MM-dd HH:mm:ss,fff",
                                                  System.Globalization.CultureInfo.InvariantCulture);*/

            DateTime enteredDate = DateTime.Parse(dt);

            DateTime dateTime = dateS.Value.Date;

            if (dateTime> enteredDate)
            {
                lblRelease.Text = "This Apartment is Available To Lease";
                btnRequest.Enabled = true;
                btnRequest.BackColor = Color.ForestGreen;
                

            }
            else
            {
                lblRelease.Text = "This Apartment is Not Available Now .Its Available On "+ enteredDate;
                btnRequest.Enabled = false;
                btnRequest.BackColor = Color.Red;
            }


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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String city = cmbCityS.Text;
            String classId = cmbClassTypeS.Text;
            int classIdValue = 1;
            if (classId.Equals("Class 1"))
            {
                classIdValue = 1;
            }else if (classId.Equals("Class 2"))
            {
                classIdValue = 2;
            }
            else if (classId.Equals("Class 3"))
            {
                classIdValue = 3;
            }
            else if (classId.Equals("Suite"))
            {
                classIdValue = 4;
            }

            String apartmentStatus = cmbStatusS.Text;
            DateTime dateTime = dateS.Value.Date;



            if (city != null && classId != null)
            {
                //filtering Apartment
                DataTable dt = apartmentDAL.SearchByFilterigs(city, classIdValue, apartmentStatus, dateTime);
                dgvApartment.DataSource = dt;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //Get All the Values from leaseRequest Form
            apartmentLeaseRequestBLL.location = txtName.Text;
            apartmentLeaseRequestBLL.apartmentId = int.Parse(txtID.Text);
            apartmentLeaseRequestBLL.buildingId = int.Parse(cmdBuilding.SelectedValue.ToString());
          //  apartmentLeaseRequestBLL.parkingSpaceId = int.Parse(cmbParking.SelectedValue.ToString());
           // apartmentLeaseRequestBLL.classTypeId = int.Parse(cmbClassType.SelectedValue.ToString());
            apartmentLeaseRequestBLL.leasingPieriod = cmbLeas.Text;
            apartmentLeaseRequestBLL.leasingStatus = cmbLS.Text;
            apartmentLeaseRequestBLL.approvalStatus = "PENDING";
            apartmentLeaseRequestBLL.approveState = false;
            apartmentLeaseRequestBLL.required_date = dateTimePickerBuy.Value.Date;
            apartmentLeaseRequestBLL.added_date = DateTime.Now;


            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = userDAL.GetIDFromUsername(loggedUser);

            apartmentLeaseRequestBLL.added_by = usr.userId;
            apartmentLeaseRequestBLL.addedUserId = usr.userId;
            apartmentLeaseRequestBLL.addedUserName = usr.username;
            apartmentLeaseRequestBLL.approvedUserId = 0;
            apartmentLeaseRequestBLL.approvedUserName = "";



            //Create Boolean variable to check if the leaseRequest is added successfully or not
            bool success = apartmentLeaseRequestDAL.Insert(apartmentLeaseRequestBLL);


            //If the leaseRequest is inserted successfully then the value of the success will be true else it will be false
            if (success == true)
            {

                //leaseRequest Inserted Successfully
                MessageBox.Show("New Apartment Inserted Successfully.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = apartmentLeaseRequestDAL.Select();
                dgvApartment.DataSource = dt;

          
            }
            else
            {
                //FAiled to Insert leaseRequest
                MessageBox.Show("Failed to Insert apartment Type.");
            }
        }
    }
}
