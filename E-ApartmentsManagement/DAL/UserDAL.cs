using System;
using System.Configuration;
using E_ApartmentsManagement.BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using System.Net;

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
                String sql = "INSERT INTO users (firstname,lastname,role,nic,address,contact,gender,email,username,password,added_date) " +
                    "VALUES (@firstname, @lastname,@role,@nic,@address,@contact,@gender,@email,@username,@password,@added_date)";
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
                string sql = "SELECT * FROM users WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.userId = int.Parse(dt.Rows[0]["user_id"].ToString());
                    u.firstName = dt.Rows[0]["firstname"].ToString();
                    u.lastName = dt.Rows[0]["lastname"].ToString();
                    u.role = dt.Rows[0]["role"].ToString();
                    u.nic = dt.Rows[0]["nic"].ToString();
                    u.address = dt.Rows[0]["address"].ToString();
                    u.contact = dt.Rows[0]["contact"].ToString();
                    u.email = dt.Rows[0]["email"].ToString();
                    u.username = dt.Rows[0]["username"].ToString();
                    u.gender = dt.Rows[0]["gender"].ToString();
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

        public DataTable Select()
        {
            //Creating Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();


            try
            {
                //Wrting SQL Query to get all the data from DAtabase
                string sql = "SELECT * FROM users";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DAtabase Connection
                conn.Open();
                //Adding the value from adapter to Data TAble dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable Search(string keywords)
        {
            //SQL Connection fro DB Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Creating DAtaTable to hold value from dAtabase
            DataTable dt = new DataTable();

            try
            {
                //SQL query to search product
                string sql = "SELECT * FROM users WHERE firstname LIKE '%" + keywords + "%' OR lastname LIKE '%" + keywords + "%' OR role LIKE '%" +
                    keywords + "%' OR nic LIKE '%" + keywords + "%'";
                //Sql Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool Delete(UserBLL b)
        {

            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write Query User from DAtabase
                String sql = "DELETE FROM users WHERE user_id=@id";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@id", b.userId);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed successfullly then the value of rows will be greated than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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

        public bool Update(UserBLL u)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in database
                String sql = "UPDATE users SET firstname=@firstname, lastname=@lastname, role=@role, nic=@nic," +
                " address=@address, contact=@contact, gender=@gender, email=@email, username=@username, password=@password,added_date=@added_date WHERE user_id=@user_id";



              //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
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
                cmd.Parameters.AddWithValue("@user_id", u.userId);


                //Open the Database connection
                conn.Open();

                //Create Int Variable to check if the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of rows will be greater than 0 else it will be less than zero
                if (rows > 0)
                {
                    //Query ExecutedSuccessfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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
    }
}
