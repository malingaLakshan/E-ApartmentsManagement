using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_ApartmentsManagement.BLL;

namespace E_ApartmentsManagement.DAL
{
    internal class ApartmentDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Insert(ApartmentBLL apartmentBLL)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to insert Apartments into database
                String sql = "INSERT INTO apartments (name, location, " +
                    "floar_area,apartment_states,building_id,parking_space_id,class_type_id,description,active_state,added_date, added_by) " +
                    "VALUES (@name, @location, @floar_area,@apartment_states,@building_id,@parking_space_id,@class_type_id,@description,@active_state,@added_date, @added_by)";

                //Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the values through parameters
                cmd.Parameters.AddWithValue("@name", apartmentBLL.name);
                cmd.Parameters.AddWithValue("@location", apartmentBLL.location);
                cmd.Parameters.AddWithValue("@floar_area", apartmentBLL.floarArea);
                cmd.Parameters.AddWithValue("@apartment_states", apartmentBLL.apartmentStates);
                cmd.Parameters.AddWithValue("@building_id", apartmentBLL.buildingId);
                cmd.Parameters.AddWithValue("@parking_space_id", apartmentBLL.parkingSpaceId);
                cmd.Parameters.AddWithValue("@class_type_id", apartmentBLL.classTypeId);
                cmd.Parameters.AddWithValue("@description", apartmentBLL.description);
                cmd.Parameters.AddWithValue("@active_state", apartmentBLL.active_state);
                cmd.Parameters.AddWithValue("@added_date", apartmentBLL.added_date);
                cmd.Parameters.AddWithValue("@added_by", apartmentBLL.added_by);
           

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

        internal DataTable Select()
        {
            //Create Sql Connection to connect Databaes
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();



            try
            {
                //Writing the Query to Select all the Class Types from database
                String sql = "SELECT * FROM apartments";

                //Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DAtabase Connection
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
    }
}
