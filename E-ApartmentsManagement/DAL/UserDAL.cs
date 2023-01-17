using System;
using System.Configuration;
using E_ApartmentsManagement.BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace E_ApartmentsManagement.DAL
{
    internal class UserDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(UserBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
           

           try
            {
                String sql = "INSERT INTO users (firstname,lastname,role,nic,address,contact,gender,email,username,password,added_date) VALUES (@firstname, @lastname,@role,@nic,@address,@contact,@gender,@email,@username,@password,@added_date)";
                SqlCommand cmd = new SqlCommand(sql, conn);
           
         
                cmd.Parameters.AddWithValue("@firstname", u.firstName);
                cmd.Parameters.AddWithValue("@lastname", u.lastName);
                cmd.Parameters.AddWithValue("@role", u.role);
                cmd.Parameters.AddWithValue("@nic", u.nic);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);



                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                     //Query Sucessfull
                    isSuccess = true;
                }
                else
                {
                    //Query Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public UserBLL GetIDFromUsername(string username)
        {
            UserBLL u = new UserBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT user_id FROM users WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.userId = int.Parse(dt.Rows[0]["user_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }





    }
}
