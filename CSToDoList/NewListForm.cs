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
    public partial class NewListForm : Form
    {
        public static string setValueForListBoxText="";
        public NewListForm()
        {
            InitializeComponent();
   
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to List successfully");
        }

        private void createList_Click(object sender, EventArgs e)
        {
            setValueForListBoxText = textBox1.Text;
           // MessageBox.Show("List created successfully");
           
            MainWindow mw = new MainWindow();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
       
    }
}
