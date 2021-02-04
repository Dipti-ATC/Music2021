using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Music2021
{
    class Database
    {
        //Create Connection , Command and an Adapter
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        public Database()//shortcut for constructor- type ctor and tab two times
        {
            //create a connection string, make sure to change it
            //Data Source=VHMASTW-20\SQLEXPRESS;Initial Catalog=Music;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            try
            {
                string connectionString = @"Data Source=VHMASTW-20\SQLEXPRESS;Initial Catalog=Music;Integrated Security=True;";
                Connection.ConnectionString = connectionString;
                Command.Connection = Connection;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public DataTable FillDGVOwnerWithOwner()
        {
            //create a datatable
           
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("SELECT * FROM Owner", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();//open a connection to the DB
                da.Fill(dt); //fill the datatable from the SQL
                Connection.Close();//close the connection
            }
            return dt;//pass the datatable data to the DataGridView
        }

    }
}
