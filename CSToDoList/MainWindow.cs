using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSToDoList
{
    public partial class MainWindow : Form
    {
        DataSet ds;

        SqlCommandBuilder cmdBuild;
        SqlDataAdapter da;
        SqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDataSet);

        }

        private void txtbToDoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDataSet);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.projectDataSet.Person);
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Project.mdf;Integrated Security=True");

            da = new SqlDataAdapter("Select * from Person", conn);
            ds = new DataSet();
            da.Fill(ds, "STable");
            

        }
    }
}
