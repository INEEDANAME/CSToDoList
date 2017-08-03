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
            cmd = new SqlCommand();
            string insert = "Insert into Tasks values(@taskName, @personID, @taskDue, @taskReminder, @taskNotes, @taskCategory)";
            cmd.Parameters.AddWithValue("@taskName", txtbToDoInput.Text);
         //   cmd.Parameters.AddWithValue("@personID", txtbToDoInput.Text);
          //  cmd.Parameters.AddWithValue("@taskID", txtbToDoInput.Text);
            cmd.Parameters.AddWithValue("@taskDue", dtDueDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@taskReminder", dtRemindDate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@taskNotes", textBox1.Text);
      //      cmd.Parameters.AddWithValue("@taskCategory", ); 

            dbh.insertCommand(cmd);
            
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
    }
}
