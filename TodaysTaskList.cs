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

namespace MyCalender
{
    public partial class TodaysTaskList : Form
    {
        static DateTime now = DateTime.Now;
        
        public TodaysTaskList()
        {
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
           
            con.Open();
            string Today = now.Day + "-" + now.Month + "-" + now.Year;
            string query = "SELECT *  FROM TblCalendar WHERE date = 'Today'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            TodaysTaskListDataGridView.DataSource = dt;
            con.Close();
        }
    }
}
