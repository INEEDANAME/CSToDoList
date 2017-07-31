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
               lbToDoList.Items.Add(txtbToDoInput.Text);
            
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
