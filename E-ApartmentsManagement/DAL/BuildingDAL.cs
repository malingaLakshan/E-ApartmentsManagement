using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using E_ApartmentsManagement.BLL;

namespace E_ApartmentsManagement.DAL
{
    internal class BuildingDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Insert(BuildingBLL b)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to insert building into database
                String sql = "INSERT INTO buildings (name, city, address, contact, perches, added_by, added_date) VALUES (@name, @city, @address, @contact, @perches, @added_by, @added_date)";

                //Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the values through parameters
                cmd.Parameters.AddWithValue("@name", b.name);
                cmd.Parameters.AddWithValue("@city", b.city);
                cmd.Parameters.AddWithValue("@address", b.address);
                cmd.Parameters.AddWithValue("@contact", b.contact);
                cmd.Parameters.AddWithValue("@perches", 5);
                cmd.Parameters.AddWithValue("@added_by", b.added_by);
                cmd.Parameters.AddWithValue("@added_date", b.added_date);

                //Opening the Database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Query
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

        public DataTable Select()
        {
            //Creating Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();


            try
            {
                //Wrting SQL Query to get all the data from DAtabase
                string sql = "SELECT * FROM buildings";

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
                string sql = "SELECT * FROM buildings WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR city LIKE '%" + keywords + "%'";
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

        public bool Update(BuildingBLL b)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in database
                String sql = "UPDATE buildings SET name=@name, city=@city, address=@address, contact=@contact, perches=@perches, added_by=@added_by, added_date=@added_date WHERE id=@id";
             
                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@name", b.name);
                cmd.Parameters.AddWithValue("@city", b.city);
                cmd.Parameters.AddWithValue("@address", b.address);
                cmd.Parameters.AddWithValue("@contact", b.contact);
                cmd.Parameters.AddWithValue("@perches", 5);
                cmd.Parameters.AddWithValue("@added_by", b.added_by);
                cmd.Parameters.AddWithValue("@added_date", b.added_date);
                cmd.Parameters.AddWithValue("@id", b.id);

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

        public bool Delete(BuildingBLL b)
        {
            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write Query Building from DAtabase
                String sql = "DELETE FROM buildings WHERE id=@id";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@id", b.id);

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

        internal string searchBuildingNameById(int buildingID)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT name FROM buildings where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", buildingID);
            conn.Open();

            dr = cmd.ExecuteReader();
            String name = "";

            while (dr.Read())
            {
                name = dr["name"].ToString();
             

            }
            return name;
        }
    }
}
