using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;

namespace E_ApartmentsManagement.UI
{
    public partial class LeaseExtend : Form
    {
        UserDAL udal = new UserDAL();
        ApartmentLeaseRequestBLL b = new ApartmentLeaseRequestBLL();
        ApartmentLeaseRequestDAL d = new ApartmentLeaseRequestDAL();
     
            public LeaseExtend()
        {
            InitializeComponent();
            DataTable dt = d.SelectAllLease(true);
            tblLease.DataSource = dt;
        }

        private void LeaseExtend_Load(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lease Extended Successfully.");
        }
    }
}
