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
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;

namespace E_ApartmentsManagement.UI
{
    public partial class ReportNearExpireLease : Form
    {
        UserDAL udal = new UserDAL();
        ApartmentLeaseRequestBLL b = new ApartmentLeaseRequestBLL();
        ApartmentLeaseRequestDAL d = new ApartmentLeaseRequestDAL();
        public ReportNearExpireLease()
        {
            InitializeComponent();
            DataTable dt = d.SelectAllLease(true);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "My Report"; //give your report name
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "footer"; //this is the footer
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
