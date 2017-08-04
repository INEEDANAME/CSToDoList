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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbToDoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
           
            string insert = "Insert into Tasks(taskName,taskDue,taskReminder,taskNotes) values(@taskName, @taskDue, @taskReminder, @taskNotes)";

            cmd = new SqlCommand(insert); 
            cmd.Parameters.AddWithValue("@taskName", txtToDoInput.Text);
         //   cmd.Parameters.AddWithValue("@personID", txtbToDoInput.Text);
          //  cmd.Parameters.AddWithValue("@taskID", txtbToDoInput.Text);
            cmd.Parameters.AddWithValue("@taskDue", dtDueDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@taskReminder", dtRemindDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@taskNotes", txtTaskNotes.Text);
          //  cmd.Parameters.AddWithValue("@taskCategory", lbCategoryList.SelectedItem.ToString() ); 

            dbh.insertCommand(cmd);
            this.tasksBindingSource.ResetBindings(false);
            this.tasksTableAdapter.Fill(this.taskStorageDataSet.Tasks);
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            CreateListForm frm = new CreateListForm();
            frm.Show();
        }

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            if (baseSplitContainer.SplitterDistance == 63)
            {
                baseSplitContainer.SplitterDistance = 240;
            }
            else
            {
                baseSplitContainer.SplitterDistance = 63;
            }
        }

        private void baseSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskStorageDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.taskStorageDataSet.Tasks);
        


        }
    }
}
