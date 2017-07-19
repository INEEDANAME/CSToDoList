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
    public partial class MainWindow : Form
    {
        public string textBoxList;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBToDoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            string inputData = txtBToDoInput.Text;
            lbToDoList.Items.Add(inputData);


            //
      //      showListDetailslb.Items.Add(textBoxList);

        }

        private void baseSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createList_Click(object sender, EventArgs e)
        {
        NewListForm frm = new NewListForm();
        frm.Show();

        }

        private void showListDetailslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
