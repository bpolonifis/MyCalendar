using System;
using System.Collections;
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
/*With this TaskForm you can create new Tasks, update or Delete.
 * The first registerd Task of each Day.
 * The CheckBit Default Value is false.
 */




namespace MyCalender
{
    public partial class TaskForm : Form
    {
     


        public TaskForm()
        {
            InitializeComponent();
            FillDGV();

        }



        private void EventForm_Load(object sender, EventArgs e)
        {
            //static variable 
            txdate.Text = UserControlDays.static_day  + "-" + MonthlyCalender.static_month + "-" + MonthlyCalender.static_year;

        }

        private void FillDGV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string Date = txdate.Text;

            con.Open();
            string query = "SELECT *  FROM TblCalendar WHERE Date = Date";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DayTaskDataGridView.DataSource = dt;
            con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            con.Open();
            SqlCommand cmd = new SqlCommand("SaveEvent", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            string Date = txdate.Text;
            string Task = txevent.Text;

            cmd.Parameters.Add(new SqlParameter("@Date", Date));
            cmd.Parameters.Add(new SqlParameter("@Task", Task));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved");
            cmd.Dispose();
            con.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateTask", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            string Date = txdate.Text;
            string Task = txevent.Text;


            cmd.Parameters.Add(new SqlParameter("@Date",  txdate.Text));
            cmd.Parameters.Add(new SqlParameter("@Task",  txevent.Text));
            cmd.Parameters.Add(new SqlParameter("@CheckBit", 1));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Updated");
            cmd.Dispose();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteTask", con);

            MessageBox.Show("Delete");
            cmd.Dispose();
            con.Close();
        }

        private void DayTaskDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
