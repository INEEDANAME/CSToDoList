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
            try
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
                    this.listsTableAdapter.Insert(txtListName.Text, cbCategory.Text);
                    this.listsTableAdapter.Update(this.dataset.Lists);

                    this.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("An error has occured creating a list!");
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
        }
    }
}
