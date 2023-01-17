using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyStore.UI;
using E_ApartmentsManagement.BLL;
using System.Xml.Linq;
using E_ApartmentsManagement.DAL;

namespace E_ApartmentsManagement.UI
{
    public partial class Class : Form
    {
        ClassBLL classBLL = new ClassBLL();
        ClassDAL classDAL = new ClassDAL();
        UserDAL userDAL = new UserDAL();    
        public Class()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get All the Values from Building Form
            classBLL.name = txtName.Text;
            classBLL.monthly_rent = double.Parse(txtMonthlyRent.Text);
            classBLL.max_occupent = double.Parse(txtMaxOccupent.Text);
            classBLL.reservation_fee = double.Parse(txtRf.Text);
            classBLL.refundable_amount= double.Parse(txtRefundableAmount.Text);
            classBLL.bedroom_count = double.Parse(txtBedroomCount.Text);
            classBLL.common_bathroom_count = double.Parse(txtCommonBathroomCount.Text);
            classBLL.attached_bathroom_count = double.Parse(txtAttachedBathroomCount.Text);
            classBLL.servant_room_count = double.Parse(txtServantRoomCount.Text);
            classBLL.servant_toilet_count = double.Parse(txtServantToiletCount.Text);
            classBLL.description = txtDescription.Text;
           
           if (cmbStatus.Text.Equals("Available"))
            {
                classBLL.active_state = true;
            }
            else
            {
                classBLL.active_state = false;
            }

            classBLL.added_date = DateTime.Now;

            //Getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = userDAL.GetIDFromUsername(loggedUser);

            classBLL.added_by = usr.userId;

            //Create Boolean variable to check if the Class Type is added successfully or not
            bool success = classDAL.Insert(classBLL);


            //If the Class Type is inserted successfully then the value of the success will be true else it will be false
            if (success == true)
            {
                //Class Type Inserted Successfully
                MessageBox.Show("New Class Type Inserted Successfully.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = classDAL.Select();
                dgvClassType.DataSource = dt;
            }
            else
            {
                //FAiled to Insert Class Type
                MessageBox.Show("Failed to Insert New Class Type.");
            }
        }
        public void Clear()
        {
            txtName.Text = "";
            txtMonthlyRent.Text = "";
            txtMaxOccupent.Text = "";
            txtRf.Text = "";
            txtRefundableAmount.Text = "";
            txtBedroomCount.Text = "";
            txtCommonBathroomCount.Text = "";
            txtAttachedBathroomCount.Text = "";
            txtServantRoomCount.Text = "";
            txtServantToiletCount.Text = "";
            txtDescription.Text = "";

        }

        private void Class_Load(object sender, EventArgs e)
        {

        }
    }
}
