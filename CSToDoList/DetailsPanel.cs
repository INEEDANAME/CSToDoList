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
            // TODO: Complete member initialization
            this.todoDataSet = todoDataSet;
            this.tasksTableAdapter = tasksTableAdapter;
            this.taskName = taskname;

            InitializeComponent();

            SetInitValues();
        }

        private void btnDueDate_Click(object sender, EventArgs e)
        {

        }

        private void SaveChanges(object sender, FormClosingEventArgs e)
        {
         
        }

        private void SetInitValues()
        {
            DataTable tasks = this.tasksTableAdapter.GetDataByTaskName(this.taskName);
           
         //   this.tasksTableAdapter.Insert(txtToDoInput.Text, DateTime.MinValue, DateTime.MinValue, string.Empty, id);
        }
    }
}
