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
        public string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dylan\Documents\Visual Studio 2013\Projects\CSToDoList\CSToDoList\TaskStorage.mdf;Integrated Security=True";
        private SqlConnection conn;
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
                conn = new SqlConnection(connString);
                conn.Open();
                c.Connection = conn;

                c.ExecuteNonQuery();
                            
                MessageBox.Show("inserted successfully");


                conn.Close();
            
        }

        public int getListID(string listName)
        {

          
                conn = new SqlConnection(connString);
                conn.Open();

                string select = "SELECT ListId FROM Lists WHERE ListName = @listname";
                SqlCommand cmd = new SqlCommand(select, conn);
                MessageBox.Show(listName);
                cmd.Parameters.AddWithValue("@listname", listName);
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
                    conn.Close();
                    return dr.GetInt32(0);
                }
                else
                {
                    conn.Close();
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

            public void ShowDetails(string taskname)
            {

                conn = new SqlConnection(connString);
                conn.Open();

                string select = "SELECT taskName, taskDue, taskReminder, taskNotes FROM Tasks WHERE taskName = @taskName";
                SqlCommand cmd = new SqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@taskName", taskname);
                using(dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {

                        DetailsPanel details = new DetailsPanel(dr.GetString(0), dr.GetSqlDateTime(1), dr.GetSqlDateTime(2), dr.GetString(3));
                        details.Show();
                    }
                    else
                    {
                      
                    }
                }


                conn.Close();
            }

            internal void UpdateTaskDetails(string taskName, DateTime due, DateTime reminder, string taskNotes)
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string update = "";
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("inserted successfully");


                conn.Close();
                
            }
    }
    }
