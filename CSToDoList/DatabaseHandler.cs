using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace CSToDoList
{
    class DatabaseHandler
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prince Anand\Documents\Visual Studio 2013\Projects\CSToDoList\CSToDoList\TaskStorage.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
   


        public void openConnection()
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();             
            }
            catch (SqlException sqlEx)
            {
                
            }
           
            finally
            {
                conn.Close();
            }
        }

        public void closeConnection()
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();

                //    string query = "SELECT * FROM CategoryTotal";

                //     da = new SqlDataAdapter(query, conn);

                //    SqlCommandBuilder   cmdBuilder = new SqlCommandBuilder(da);
                ds = new DataSet();


            }
            catch (SqlException sqlEx)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void insertCommand(SqlCommand c)
        {
            try
            {
                conn.ConnectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prince Anand\Documents\Visual Studio 2013\Projects\CSToDoList\CSToDoList\TaskStorage.mdf;Integrated Security=True");
                conn.Open();

                c.Connection = conn;
                c.ExecuteNonQuery();
                refreshData();
                //    string query = "SELECT * FROM CategoryTotal";

                //     da = new SqlDataAdapter(query, conn);

                //    SqlCommandBuilder   cmdBuilder = new SqlCommandBuilder(da);

                MessageBox.Show("inserted successfully");


            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show(sqlEx.Message);

            }
          
            finally
            {

                conn.Close();
            }
        }
        public void refreshData()
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();

                //    string query = "SELECT * FROM CategoryTotal";

                //     da = new SqlDataAdapter(query, conn);

                //    SqlCommandBuilder   cmdBuilder = new SqlCommandBuilder(da);
                ds = new DataSet();


            }
            catch (SqlException sqlEx)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void updateDatabase()
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();

                //    string query = "SELECT * FROM CategoryTotal";

                //     da = new SqlDataAdapter(query, conn);

                //    SqlCommandBuilder   cmdBuilder = new SqlCommandBuilder(da);
                ds = new DataSet();


            }
            catch (SqlException sqlEx)
            {

            }
         
            finally
            {
                conn.Close();
            }
        }

        public void selectData(SqlCommand c)
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();

               
  

                using(dr = c.ExecuteReader())
                {
                    while(dr.Read())
                    {

                    }
                }


                //     da = new SqlDataAdapter(query, conn);

                //    SqlCommandBuilder   cmdBuilder = new SqlCommandBuilder(da);
                ds = new DataSet();


            }
            catch (SqlException sqlEx)
            {

            }
          
            finally
            {
                conn.Close();
            }
        }
    }
}
