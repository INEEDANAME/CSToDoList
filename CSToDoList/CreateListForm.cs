using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            txtListName.Text.Trim();

            if (txtListName.Text.Length == 0)
            {
                MessageBox.Show("List Name Can Not Be Empty");
            }
            else if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category");
            }
            else
            {
                //INSERT LIST
                string insert = "INSERT INTO Lists(ListName, ListCategory) VALUES(@listName, @listCategory)";
                cmd = new SqlCommand(insert);

                cmd.Parameters.AddWithValue("@listName", txtListName.Text);
                cmd.Parameters.AddWithValue("@listCategory", cbCategory.Text);
                dbh.insertCommand(cmd);

                

                this.Close();

                
            }
        }
    }
}
