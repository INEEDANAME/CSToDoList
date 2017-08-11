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
using System.Data.Sql;
using System.Configuration;

namespace CSToDoList
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }   
        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            try
            {
                txtToDoInput.Text.Trim();
                if (txtToDoInput.Text.Length == 0)
                {
                    MessageBox.Show("To-do can not be blank!");
                }
                else
                {
                    if (lbCategoryList.Items.Count == 0)
                    {
                        this.tasksTableAdapter.Insert(txtToDoInput.Text, null, null, string.Empty, 0);
                        this.tasksTableAdapter.Update(this.todoDataSet.Tasks);
                        txtToDoInput.Text = string.Empty;
                        RefreshDataSet(sender, e);
                    }
                    else
                    {
                        //Get the Currently selected list
                        DataTable listID = this.listsTableAdapter.GetData();

                        int index = lbCategoryList.SelectedIndex;
                        int id = listID.Rows[index].Field<int>(0);
                        this.tasksTableAdapter.Insert(txtToDoInput.Text, null, null, string.Empty, id);
                        txtToDoInput.Text = string.Empty;
                        RefreshDataSet(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured when adding a to-do");
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
        }
      
        private void btnNewList_Click(object sender, EventArgs e)
        {
            CreateListForm frm = new CreateListForm(this.listsTableAdapter, this.todoDataSet);
            frm.Show();
        } 

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            txtToDoInput.Text = string.Empty;

            if (lbTasks.Items.Count == 0)
            {
                MessageBox.Show("You have no Tasks left to complete! Well done");
            }
            else
            {
                try
                {
                    SqlConnection delCon =
                    new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TaskStorage.mdf;Integrated Security=True;Connect Timeout=30");

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE Tasks WHERE TaskName = @taskname";
                    cmd.Parameters.AddWithValue("@taskname", this.lbTasks.SelectedValue.ToString());
                    cmd.Connection = delCon;

                    delCon.Open();
                    cmd.ExecuteNonQuery();
                    delCon.Close();

                    this.tasksTableAdapter.Fill(this.todoDataSet.Tasks);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured when clearing this task!");
                    Console.WriteLine("ERROR: " + ex.Message.ToString());
                }
               

            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'todoDataSet.Tasks' table. You can move, or remove it, as needed.
                this.tasksTableAdapter.Fill(this.todoDataSet.Tasks);
                // TODO: This line of code loads data into the 'todoDataSet.Lists' table. You can move, or remove it, as needed.
                this.listsTableAdapter.Fill(this.todoDataSet.Lists);

            }
            catch (Exception ex)
            {
                MessageBox.Show("The application is unable to load properly. Please ensure that all files are in the proper location");
                Console.WriteLine("Loading Error:" + ex.Message.ToString());
            }
          
        }

        private void RefreshDataSet(object sender, EventArgs e)
        {
            this.listsTableAdapter.Fill(this.todoDataSet.Lists);
            this.tasksTableAdapter.Fill(this.todoDataSet.Tasks);
        }

        private void ShowTaskDetails(object sender, MouseEventArgs e)
        {
            if (lbTasks.Items.Count > 0)
            {

                DetailsPanel panel = new DetailsPanel(this.todoDataSet, this.tasksTableAdapter, lbTasks.SelectedValue.ToString());
                panel.Show();

            }
        }

        private void AddToDo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddTodo_Click(sender, e);
                RefreshDataSet(sender, e);
            }

        }

        private void ClearText(object sender, EventArgs e)
        {
            txtToDoInput.Text = string.Empty;
        }

        private void RemoveList(object sender, MouseEventArgs e)
        {
            if (lbTasks.Items.Count > 0)
            {
                string list = lbCategoryList.SelectedValue.ToString();
                DialogResult ask = MessageBox.Show("Really Remove the List?","Warning", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection delCon =
                        new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\TaskStorage.mdf;Integrated Security=True;Connect Timeout=30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "DELETE Lists WHERE ListName = @listname";
                        cmd.Parameters.AddWithValue("@listname", list);
                        cmd.Connection = delCon;

                        delCon.Open();
                        cmd.ExecuteNonQuery();
                        delCon.Close();

                        RefreshDataSet(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured when clearing this list!");
                        Console.WriteLine("ERROR: " + ex.Message.ToString());
                    }

                }


            }

        }

        private void PopulateTextBox(object sender, EventArgs e)
        {
            if (lbTasks.Items.Count > 0)
            {
                txtToDoInput.Text = lbTasks.SelectedValue.ToString();
            }
        }
    }
}