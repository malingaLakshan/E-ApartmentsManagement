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

namespace E_ApartmentsManagement.UI
{
    public partial class LeasingRequestManage : Form
    {
        ApartmentDAL apartmentDAL = new ApartmentDAL();
        ApartmentLeaseRequestDAL apartmentLeaseRequestDAL = new ApartmentLeaseRequestDAL();
        BuildingDAL buildingDAL = new BuildingDAL();
        ParkingDAL parkingDAL = new ParkingDAL();
        ClassDAL classDAL = new ClassDAL();
        ApartmentLeaseRequestBLL apartmentLeaseRequest = new ApartmentLeaseRequestBLL();
        UserDAL udal = new UserDAL();
        int requestId = 0;

        String roleCome;
        String username;
        public LeasingRequestManage()
        {

            InitializeComponent();
            loadAllRequest();
            btnLease.Enabled = false;
            btnLease.BackColor = Color.Red;
           

            AdmindashBoard admindashBoard = new AdmindashBoard();
            roleCome = admindashBoard.role.Trim().ToString();
            Console.WriteLine(roleCome);
            username = admindashBoard.username.Trim().ToString();
            if (roleCome.Equals("Customer"))
            {
                btnRequest.Dispose();
                btnLease.Dispose();

            }
        }

        private void LeasingRequestManage_Load(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            apartmentLeaseRequest.id = int.Parse(dgvRequests.Rows[rowIndex].Cells[0].Value.ToString());
            apartmentLeaseRequest.approvalStatus = cmbState.Text;

        

            //Create a boolean variable to check if the building is updated or not
            bool success = apartmentLeaseRequestDAL.Update(apartmentLeaseRequest);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Product updated Successfully
                MessageBox.Show("Update State Successfully Updated");
                //REfresh the Data Grid View
                DataTable dt = apartmentLeaseRequestDAL.Select();
                dgvRequests.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update State");
            }
        }

        private void loadAllRequest()
        {
            DataTable dt = apartmentLeaseRequestDAL.Select();
            dgvRequests.DataSource = dt;
        }

        private void dgvRequests_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            //Create integer variable to know which Apartment was clicked
            int rowIndex = e.RowIndex;

             requestId = int.Parse(dgvRequests.Rows[rowIndex].Cells[0].Value.ToString());
            //Display the Value on Respective TextBoxes
            txtID.Text = dgvRequests.Rows[rowIndex].Cells[2].Value.ToString();
            txtLocation.Text = dgvRequests.Rows[rowIndex].Cells[1].Value.ToString();
   
            txtFa.Text = dgvRequests.Rows[rowIndex].Cells[3].Value.ToString();
            cmbState.Text = dgvRequests.Rows[rowIndex].Cells[8].Value.ToString();

            if (cmbState.Text.Equals("APPROVED"))
            {
                btnLease.Enabled = true;
                btnLease.BackColor = Color.ForestGreen;

            }
            else
            {
                btnLease.Enabled = false;
                btnLease.BackColor = Color.Red;
            }

            //get building name from id to set the text fields
            int buildingID = int.Parse(dgvRequests.Rows[rowIndex].Cells[3].Value.ToString());
            String getBuildingName = buildingDAL.searchBuildingNameById(buildingID);
            cmdBuilding.Text = getBuildingName;


            //get parking name from id to set the text fields
            int parkingSpaceID = int.Parse(dgvRequests.Rows[rowIndex].Cells[4].Value.ToString());
            String getParkingSpaceName = parkingDAL.searchParkingById(parkingSpaceID);
            cmbParking.Text = getParkingSpaceName;


            //get class name from id to set the text fields
            int classTypeId = int.Parse(dgvRequests.Rows[rowIndex].Cells[5].Value.ToString());
            String getClassTypeName = classDAL.searchClassById(classTypeId);
            cmbClassType.Text = getClassTypeName;

            getClassDetails();

            dtReq.Text = dgvRequests.Rows[rowIndex].Cells[12].Value.ToString();

            int leasingPerios = int.Parse(dgvRequests.Rows[rowIndex].Cells[6].Value.ToString());
            DateTime enteredDate = DateTime.Parse(dgvRequests.Rows[rowIndex].Cells[12].Value.ToString());
            DateTime m = enteredDate.AddYears(leasingPerios);
            dateTimePicker1.Text = m.ToString();

            requestId = int.Parse(dgvRequests.Rows[rowIndex].Cells[0].Value.ToString());






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

        private void btnRequest_Click(object sender, EventArgs e)
        {
            apartmentLeaseRequest.approvalStatus = cmbState.Text;
         

            //Create a boolean variable to check if the building is updated or not
            bool success = apartmentLeaseRequestDAL.UpdateApprovalStateByAdmin(apartmentLeaseRequest, requestId);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Product updated Successfully
                MessageBox.Show("Approve Status Successfully Updated");
         
                //REfresh the Data Grid View
                DataTable dt = apartmentLeaseRequestDAL.Select();
                dgvRequests.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Approve Status");
            }
        }

        private void btnLease_Click(object sender, EventArgs e)
        {
            apartmentLeaseRequest.approveState = true;


            //Create a boolean variable to check if the building is updated or not
            bool success = apartmentLeaseRequestDAL.UpdateGenerateLeaseByAdmin(apartmentLeaseRequest, requestId);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Product updated Successfully
                MessageBox.Show("Lease Generated Successfully");

                //REfresh the Data Grid View
                DataTable dt = apartmentLeaseRequestDAL.Select();
                dgvRequests.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Generate Lease");
            }
        }
    }
}
