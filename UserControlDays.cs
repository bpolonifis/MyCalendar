using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
/* This User Control Day is used to display stored tasks or events.
 */

namespace MyCalender
{
    public partial class UserControlDays : UserControl
    {
        // static variable for day;
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbDays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbDays.Text;
            //start timer if usercontroldays is click
            DisplayEventLoop.Start();
            TaskForm eventform = new TaskForm();
            eventform.Show();
        }

        private void txevent_Click(object sender, EventArgs e)
        {

        }

        //method to display event

        private void displayEvent()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            string SqlQuery = "SELECT * FROM TblCalendar WHERE Date = @Date";
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.Parameters.AddWithValue("Date", lbDays.Text + "-" +MonthlyCalender.static_month+ "-" +  MonthlyCalender.static_year);


            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["Task"].ToString();
                Console.WriteLine(lbevent.Text);
              
            }
            reader.Dispose();
            cmd.Dispose();
            con.Close();

           

            

            

        }
        // timer for auto display event if new event is added
          
        private void DisplayEventLoop_Tick(object sender, EventArgs e)
        {
            //call the displayEvent method
            displayEvent();
        }

        private void contextMenuStrip_Day_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
