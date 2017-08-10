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
    public partial class MainWindow : Form
    {
        SqlCommand cmd;
        DatabaseHandler dbh = new DatabaseHandler();

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

                MessageBox.Show(lbCategoryList.SelectedValue.ToString());
                int listID = dbh.getListID(lbCategoryList.SelectedValue.ToString());
                if (listID == -2 || listID == -1)
                {
                    MessageBox.Show("An Error Occured in loading a list ID for insertion of the task");
                }
                else
                {
                    //INSERT The List into tasks
                    string insert = "Insert into Tasks(taskName, ListID) values(@taskName, @listID)";

                    cmd = new SqlCommand(insert);

                    cmd.Parameters.AddWithValue("@taskName", txtToDoInput.Text);
                    cmd.Parameters.AddWithValue("@listID", listID);
                    //DEPRECATED - Will be configured through the DetailsPanel

                  //  cmd.Parameters.AddWithValue("@taskDue", dtDueDate.Value.ToShortDateString());
                  //  cmd.Parameters.AddWithValue("@taskReminder", dtRemindDate.Value.ToShortDateString());
                  //  cmd.Parameters.AddWithValue("@taskNotes", txtTaskNotes.Text);
                    

                    if (lbCategoryList.Items.Count == 0)
                    {
                        cmd.Parameters.AddWithValue("@taskCategory", "Default");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@taskCategory", lbCategoryList.SelectedItem.ToString());
                    }

                    dbh.insertCommand(cmd);
 
                }

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
    }
}
