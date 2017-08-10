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
        private string taskName;
        private System.Data.SqlTypes.SqlDateTime dueDate;
        private System.Data.SqlTypes.SqlDateTime reminderDate;
        private string taskNotes;
        private DatabaseHandler dbh = new DatabaseHandler();

        public DetailsPanel()
        {
            InitializeComponent();
        }

        public DetailsPanel(string taskName, System.Data.SqlTypes.SqlDateTime due, System.Data.SqlTypes.SqlDateTime reminder, string notes)
        {

            this.taskName = taskName;
            this.dueDate = due;
            this.reminderDate = reminder;
            this.taskNotes = notes;

            InitializeComponent();

            this.Name = taskName;
            this.dtDue.Value = this.dueDate.Value;
            this.dtReminder.Value = this.reminderDate.Value;
            this.txtToDoNotes.Text = this.taskNotes;
        }

        private void btnDueDate_Click(object sender, EventArgs e)
        {

        }

        private void SaveChanges(object sender, FormClosingEventArgs e)
        {
            dbh.UpdateTaskDetails(this.taskName, this.dtDue.Value, this.dtReminder.Value, this.txtToDoNotes.Text);
        }
    }
}
