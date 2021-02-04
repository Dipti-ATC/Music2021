using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music2021
{
    public partial class Form1 : Form
    {
        //create an instance of the database class
        Database myDatabase = new Database();
        public Form1()
        {
            InitializeComponent();
            loadDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadDB()
        {
            //load the owner datagrid view
            DisplayDataGridViewOwner();
        }
        public void DisplayDataGridViewOwner()
        {
            DGVOwner.DataSource = null;// Claer out the old data

            try
            {
                DGVOwner.DataSource = myDatabase.FillDGVOwnerWithOwner();//pass the datatable to the data grid view
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
