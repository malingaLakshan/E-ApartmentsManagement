using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace E_ApartmentsManagement.UI
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            reportView r = new reportView();
            r.Show();





        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReportNearExpireLease r = new ReportNearExpireLease();
            r.Show();

        }
    }
}
