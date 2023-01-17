
using E_ApartmentsManagement.BLL;
using E_ApartmentsManagement.DAL;
using E_ApartmentsManagement.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string loggedIn;



        private void pboxClose_Click(object sender, EventArgs e)
        {
            //Code to close this form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.role = cmbRole.Text.Trim();

            //Checking the login credentials
            bool sucess = dal.loginCheck(l);
            if(sucess==true)
            {
                //Login Successfull
                MessageBox.Show("Login Successful.");
                loggedIn = l.username;
                //Need to open Respective Forms based on User Type
                switch (l.role)
                {
                    case "Admin":
                        {
                            //Display Admin Dashboard
                            AdmindashBoard admin = new AdmindashBoard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "Customer":
                        {
                            //Display User Dashboard
                            UserDashboard user = new UserDashboard();
                            user.role = "Customer";
                    
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //Display an error message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
            }
            else
            {
                //login Failed
                MessageBox.Show("Login Failed. Try Again");
            }
        }
    }
}
