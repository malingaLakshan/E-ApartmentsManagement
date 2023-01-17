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
    internal class ClassDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool Insert(ClassBLL classBLL)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to insert product into database
                String sql = "INSERT INTO class_type (name, monthly_rent, max_occupent,reservation_fee,refundable_amount,bedroom_count,common_bathroom_count,attached_bathroom_count,servant_room_count,servant_toilet_count,description,active_state,added_date, added_by) VALUES (@name, @monthly_rent, @max_occupent,@reservation_fee,@refundable_amount,@bedroom_count,@common_bathroom_count,@attached_bathroom_count,@servant_room_count,@servant_toilet_count,@description,@active_state,@added_date, @added_by)";

                //Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the values through parameters
                cmd.Parameters.AddWithValue("@name", classBLL.name);
                cmd.Parameters.AddWithValue("@monthly_rent", classBLL.monthly_rent);
                cmd.Parameters.AddWithValue("@max_occupent", classBLL.max_occupent);
                cmd.Parameters.AddWithValue("@reservation_fee", classBLL.reservation_fee);
                cmd.Parameters.AddWithValue("@refundable_amount", classBLL.refundable_amount);
                cmd.Parameters.AddWithValue("@bedroom_count", classBLL.bedroom_count);
                cmd.Parameters.AddWithValue("@common_bathroom_count", classBLL.common_bathroom_count);
                cmd.Parameters.AddWithValue("@attached_bathroom_count", classBLL.attached_bathroom_count);
                cmd.Parameters.AddWithValue("@servant_room_count", classBLL.servant_room_count);
                cmd.Parameters.AddWithValue("@servant_toilet_count", classBLL.servant_toilet_count);
                cmd.Parameters.AddWithValue("@description", classBLL.description);
                cmd.Parameters.AddWithValue("@active_state", classBLL.active_state);
                cmd.Parameters.AddWithValue("@added_date", classBLL.added_date);
                cmd.Parameters.AddWithValue("@added_by", classBLL.added_by);

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

        public string searchClassById(int classTypeId)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT name FROM class_type where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", classTypeId);
            conn.Open();

            dr = cmd.ExecuteReader();
            String name = "";

            while (dr.Read())
            {
                name = dr["name"].ToString();


            }
            return name;
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
                String sql = "SELECT * FROM class_type";

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
