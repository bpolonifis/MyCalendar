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

/* This Form displays all Tasks to be completed in general.
 */

namespace MyCalender
{
    public partial class BrainDumpList : Form
    {
        public BrainDumpList()
        {
            InitializeComponent();
            //FillDGV();

        }

        private void BrainDumpList_Load(object sender, EventArgs e)
        {
            FillDGV();
        }
        private void FillDGV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            string query = "SELECT *  FROM TblCalendar WHERE CheckBit = 0";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            BrainDumpListdataGridView.DataSource = dt;
            con.Close();
        }
    }
}
