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
        private string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TaskStorage.mdf;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dylan\documents\visual studio 2013\Projects\CSToDoList\CSToDoList\TaskStorage.mdf;Integrated Security=True");
        private SqlCommand com = new SqlCommand();
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlDataReader dr;
   


        public void openConnection()
        {
           
        }

        public void closeConnection()
        {
           
        }

        public void insertCommand(SqlCommand c)
        {
            
                conn.ConnectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dylan\documents\visual studio 2013\Projects\CSToDoList\CSToDoList\TaskStorage.mdf;Integrated Security=True");
                conn.Open();

                SqlTransaction t = conn.BeginTransaction("Transaction");

                
                c.Connection = conn;
                c.Transaction = t;
                c.ExecuteNonQuery();
                t.Commit();
               
                
                MessageBox.Show("inserted successfully");


                conn.Close();
            
        }

        public int getListID(string listName)
        {

            try
            {
                conn.ConnectionString = connString;
                conn.Open();

                string select = "SELECT ListId FROM Lists WHERE ListName = @listname";
                SqlCommand cmd = new SqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@listname", int.Parse(listName));
                dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    dr.Read();
                 return dr.GetInt32(0);
                }
                else
                {
                 return -2;
                }

            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("An error occured while trying to get a list ID");
            }
            return -1;
        }

        public int getPersonID(string personName)
        {
            try
            {
                conn.ConnectionString = connString;
                conn.Open();

                string query = "SELECT personID FROM Person WHERE personName = @name";

                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@name", personName);
    

                dr = cmd.ExecuteReader();
                
   
                if (dr.HasRows)
                {
                    dr.Read();
                    return dr.GetInt32(0);
                }
                else
                {
                    return -2;
                }

              
             }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);

            }

            finally
            {
                conn.Close();
        
            }

            return -1;

        }

        public void refreshData()
        {
           
        }

        public void updateDatabase()
        {
            
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
