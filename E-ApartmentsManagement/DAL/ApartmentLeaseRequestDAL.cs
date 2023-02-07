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
    internal class ApartmentLeaseRequestDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(ApartmentLeaseRequestBLL apartmentLeaseRequestBLL)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to insert Apartments into database
                String sql = "INSERT INTO apartment_lease_requests (location,apartment_id,building_id,parking_space_id,class_type_id,leasing_pieriod," +
                    "leasing_status,approval_status, approve_state,added_date,added_by,required_date,added_user_id,added_username,approved_user_id," +
                    "approved_username)" +
                    "VALUES (@location, @apartment_id, @building_id,@parking_space_id,@class_type_id,@leasing_pieriod,@leasing_status,@approval_status," +
                    "@approve_state,@added_date, @added_by,@required_date,@added_user_id,@added_username,@approved_user_id,@approved_username)";

                //Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the values through parameters
                cmd.Parameters.AddWithValue("@location", apartmentLeaseRequestBLL.location);
                cmd.Parameters.AddWithValue("@apartment_id", apartmentLeaseRequestBLL.apartmentId);
                cmd.Parameters.AddWithValue("@building_id", apartmentLeaseRequestBLL.buildingId);
                cmd.Parameters.AddWithValue("@parking_space_id", apartmentLeaseRequestBLL.parkingSpaceId);
                cmd.Parameters.AddWithValue("@class_type_id", apartmentLeaseRequestBLL.classTypeId);
                cmd.Parameters.AddWithValue("@leasing_pieriod", apartmentLeaseRequestBLL.leasingPieriod);
                cmd.Parameters.AddWithValue("@leasing_status", apartmentLeaseRequestBLL.leasingStatus);
                cmd.Parameters.AddWithValue("@approval_status", apartmentLeaseRequestBLL.approvalStatus);
                cmd.Parameters.AddWithValue("@approve_state", apartmentLeaseRequestBLL.approveState);
                cmd.Parameters.AddWithValue("@added_date", apartmentLeaseRequestBLL.added_date);
                cmd.Parameters.AddWithValue("@added_by", apartmentLeaseRequestBLL.added_by);
                cmd.Parameters.AddWithValue("@required_date", apartmentLeaseRequestBLL.required_date);
                cmd.Parameters.AddWithValue("@added_user_id", apartmentLeaseRequestBLL.addedUserId);
                cmd.Parameters.AddWithValue("@added_username", apartmentLeaseRequestBLL.addedUserName);
                cmd.Parameters.AddWithValue("@approved_user_id", apartmentLeaseRequestBLL.approvedUserId);
                cmd.Parameters.AddWithValue("@approved_username", apartmentLeaseRequestBLL.approvedUserName);


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
            //Create Sql Connection to connect Databaes
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();



            try
            {
                //Writing the Query to Select all the Class Types from database
                String sql = "SELECT * FROM apartment_lease_requests";

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

        public bool Update(ApartmentLeaseRequestBLL apartmentLeaseRequest)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in database
                String sql = "UPDATE apartment_lease_requests SET approval_status=@approval_status WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@id", apartmentLeaseRequest.id);
                cmd.Parameters.AddWithValue("@approval_status", apartmentLeaseRequest.approvalStatus);


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

        public bool UpdateApprovalStateByAdmin(ApartmentLeaseRequestBLL apartmentLeaseRequest,int id)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in database
                String sql = "UPDATE apartment_lease_requests SET approval_status=@approval_status WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@approval_status", apartmentLeaseRequest.approvalStatus);
                cmd.Parameters.AddWithValue("@id", id);


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

        public bool UpdateGenerateLeaseByAdmin(ApartmentLeaseRequestBLL apartmentLeaseRequest,int id)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in database
                String sql = "UPDATE apartment_lease_requests SET approve_state=@approve_state WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@approve_state", apartmentLeaseRequest.approveState);
                cmd.Parameters.AddWithValue("@id", id);


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

        public DataTable SelectAllLease(Boolean approve_state)
        {
            //Create Sql Connection to connect Databaes
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();



            try
            {
                //Writing the Query to Select all the Class Types from database
                String sql = "SELECT * FROM apartment_lease_requests where approve_state=@approve_state";

                //Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@approve_state", approve_state);

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
