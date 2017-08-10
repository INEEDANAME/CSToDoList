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
using System.Data.Sql;

namespace CSToDoList
{
    public partial class MainWindow : Form
    {
    
 
        private bool detailsPanelShowing = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      
        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            txtToDoInput.Text.Trim();
            if (txtToDoInput.Text.Length == 0)
            {
                MessageBox.Show("Todo can not be blank");
            }
            else
            {
                //Get the Currently selected list

                DataTable listID = this.listsTableAdapter.GetData();

                int index = lbCategoryList.SelectedIndex;
                int id = listID.Rows[index].Field<int>(0);
                this.tasksTableAdapter.Insert(txtToDoInput.Text, null, null, string.Empty, id);
                this.tasksTableAdapter.Update(this.todoDataSet.Tasks);
                MessageBox.Show("Added succesfully!");
                }

            }
       

        private void btnNewList_Click(object sender, EventArgs e)
        {
            CreateListForm frm = new CreateListForm(this.listsTableAdapter, this.todoDataSet);
            frm.Show();
 
        } 

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            if (!detailsPanelShowing)
            {
                baseSplitContainer.SplitterDistance = 240;
                detailsPanelShowing = true;
            }
            else
            {
                baseSplitContainer.SplitterDistance = 55;
                detailsPanelShowing = false;
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.todoDataSet.Tasks);
            // TODO: This line of code loads data into the 'todoDataSet.Lists' table. You can move, or remove it, as needed.
            this.listsTableAdapter.Fill(this.todoDataSet.Lists);
   
        }

        private void ShowTasks(object sender, EventArgs e)
        {

        }

        private void lbTasks_SelectedValueChanged(object sender, EventArgs e)
        {
           // dbh.ShowDetails(lbTasks.SelectedValue.ToString());
        }

        private void RefreshDataSet(object sender, EventArgs e)
        {
            this.listsTableAdapter.Fill(this.todoDataSet.Lists);
            this.tasksTableAdapter.Fill(this.todoDataSet.Tasks);
        }

        private void ShowTaskDetails(object sender, MouseEventArgs e)
        {
            DetailsPanel panel = new DetailsPanel(this.todoDataSet, this.tasksTableAdapter, lbTasks.SelectedValue.ToString());
            panel.Show();
        }
    }
}
