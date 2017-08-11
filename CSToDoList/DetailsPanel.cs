using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSToDoList
{
    public partial class DetailsPanel : Form
    {
        private TodoDataSet todoDataSet;
        private TodoDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private string taskName;

        public DetailsPanel()
        {
            InitializeComponent();
        }

        public DetailsPanel(TodoDataSet todoDataSet, TodoDataSetTableAdapters.TasksTableAdapter tasksTableAdapter, string taskname)
        {
            this.todoDataSet = todoDataSet;
            this.tasksTableAdapter = tasksTableAdapter;
            this.taskName = taskname;

            InitializeComponent();
            SetInitValues();
        }

        private void btnDueDate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tasks = this.tasksTableAdapter.GetData();
                DataRow[] selectedTask = tasks.Select("TaskName ='" + this.taskName + "'");

                selectedTask[0]["taskDue"] = dtDue.Value.ToString();
                this.tasksTableAdapter.Update(this.todoDataSet.Tasks);
                this.tasksTableAdapter.Update(selectedTask[0]);
            }catch(Exception ex)
            {
                MessageBox.Show("Unable to modify task detail, sorry!");
                Console.WriteLine("DueDateError: " + ex.Message.ToString());
            }
       
        }

        private void SetInitValues()
        {
            try
            {
                DataTable tasks = this.tasksTableAdapter.GetData();
                DataRow[] selectedTask = tasks.Select("TaskName ='" + this.taskName + "'");

                if (!(selectedTask[0]["taskDue"].Equals(System.DBNull.Value)))
                {
                    dtDue.Value = DateTime.Parse(selectedTask[0]["taskDue"].ToString());
                }

                if (!(selectedTask[0]["taskReminder"].Equals(System.DBNull.Value)))
                {
                    dtReminder.Value = DateTime.Parse(selectedTask[0]["taskReminder"].ToString());
                }

                if (!(selectedTask[0]["taskNotes"].ToString().Length == 0))
                {
                    txtToDoNotes.Text = selectedTask[0]["taskNotes"].ToString();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("An error occured when loading the task details!");
                Console.WriteLine("TaskDetailLoad: " + ex.Message.ToString());
                this.Close();
            }
        }

        private void btnReminderDate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tasks = this.tasksTableAdapter.GetData();
                DataRow[] selectedTask = tasks.Select("TaskName ='" + this.taskName + "'");

                selectedTask[0]["taskReminder"] = dtReminder.Value.ToString();
                tasks.AcceptChanges();
                selectedTask[0].AcceptChanges();
                this.tasksTableAdapter.Update(this.todoDataSet.Tasks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save task detail changes. Please try again");
                Console.WriteLine("ReminderSaveDetail Error:" + ex.Message.ToString());
            }
           
        }

        private void SetTaskNotes(object sender, EventArgs e)
        {
            try
            {
                DataTable tasks = this.tasksTableAdapter.GetData();
                DataRow[] selectedTask = tasks.Select("TaskName ='" + this.taskName + "'");

                selectedTask[0]["taskNotes"] = txtToDoNotes.Text;
                this.tasksTableAdapter.Update(this.todoDataSet.Tasks);
                this.tasksTableAdapter.Update(selectedTask[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save task detail changes. Please try again");
                Console.WriteLine("NotesSaveDetail Error:" + ex.Message.ToString());
            }


        }
    }
}
