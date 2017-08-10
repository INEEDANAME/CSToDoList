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
        private TodoDataSetTableAdapters.ListsTableAdapter listsTableAdapter;
        private TodoDataSet dataset;


        public CreateListForm()
        {
            InitializeComponent();
        }

        public CreateListForm(TodoDataSetTableAdapters.ListsTableAdapter listsTableAdapter, TodoDataSet tdDataSet)
        {
            // TODO: Complete member initialization
            this.listsTableAdapter = listsTableAdapter;
            this.dataset = tdDataSet;
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
                 //  string insert = "INSERT INTO Lists(ListName, ListCategory) VALUES(@listName, @listCategory)";
                //  cmd = new SqlCommand(insert);

               // cmd.Parameters.AddWithValue("@listName", txtListName.Text);
               // cmd.Parameters.AddWithValue("@listCategory", cbCategory.Text);

                this.listsTableAdapter.Insert(txtListName.Text, cbCategory.Text);
                this.listsTableAdapter.Update(this.dataset.Lists);
           
              //  dbh.insertCommand(cmd)
                this.Close();

                
            }
        }
    }
}
