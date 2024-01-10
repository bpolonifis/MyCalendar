using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* This Form Displays all Achieved Tasks.
 */

namespace MyCalender
{
    public partial class ArchieveList : Form
    {
        
        
        public ArchieveList( )
        {
            InitializeComponent();
            //FillDGV();
        }
        private void ArchieveList_Load(object sender, EventArgs e)
        {
            FillDGV();
        }
        private void FillDGV() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            string query = "SELECT *  FROM TblCalendar WHERE CheckBit = 1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            TaskListDataGridView.DataSource = dt;
            con.Close();
        }

    }
}
