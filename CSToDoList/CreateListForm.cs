using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CSToDoList
{
    public partial class CreateListForm : Form
    {
        SqlCommand cmd;
        DatabaseHandler dbh = new DatabaseHandler();
        public CreateListForm()
        {
            InitializeComponent();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            txtEmail.Text.Trim();
            txtName.Text.Trim();

            if (txtEmail.Text.Length == 0 && txtName.Text.Length == 0)
            {
                MessageBox.Show("Please ensure that Name & E-Mail is properly filled-in");
            }
            else
            {
                //INSERT PERSON 
                string insert = "Insert into Person(personName,personEmail) values(@personName, @personEmail)";
                cmd = new SqlCommand(insert);
                cmd.Parameters.AddWithValue("@personName", txtName.Text);
                cmd.Parameters.AddWithValue("@personEmail", txtEmail.Text);

                dbh.insertCommand(cmd);
                cmd.Parameters.Clear();

                //GET PERSON ID
                int personID = dbh.getPersonID(txtName.Text);
                if ( personID == -2)
                {
                    MessageBox.Show("An Error has occured in getting the personID, the list has not been created Err: -2");
                }
                else
                {

                    //INSERT LIST
                    insert = "INSERT INTO Lists(ListName, personID, ListCategory) VALUES(@listName, @personID, @listCategory)";
                    cmd = new SqlCommand(insert);

                    cmd.Parameters.AddWithValue("@listName", txtName.Text);
                    cmd.Parameters.AddWithValue("@personID", personID);
                    cmd.Parameters.AddWithValue("@listCategory", cbCategory.Text);
                    dbh.insertCommand(cmd);

                

                }
              
            }
        }

      
    }
}
