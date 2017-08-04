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
           
            string insert = "Insert into Person(personName,personEmail) values(@personName, @personEmail)";
            cmd = new SqlCommand(insert);
            cmd.Parameters.AddWithValue("@personName", txtName.Text);
            //cmd.Parameters.AddWithValue("@personType", cbCategory.SelectedText);
            cmd.Parameters.AddWithValue("@personEmail", txtEmail.Text);
            dbh.insertCommand(cmd);
            cmd.Parameters.Clear();

            insert = "INSERT INTO Lists(ListName, ListCategory) VALUES(@listName, @listCategory)";
            cmd = new SqlCommand(insert);
            
            cmd.Parameters.AddWithValue("@listName", txtName.Text);
            cmd.Parameters.AddWithValue("listCategory", cbCategory.Text);
            dbh.insertCommand(cmd);
        }

      
    }
}
