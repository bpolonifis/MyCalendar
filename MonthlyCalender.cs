using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*Monthly Calender Diplay tasks or Event in that particular month. 
 * By pressing Next or Previous you can Change the Display accordingly.
 * In addition StripMenu offers some extra options already existing in buttons
 */
 

namespace MyCalender
{
    public partial class MonthlyCalender : Form
    {
        
        public static string  static_month, static_year;

        static DateTime now = DateTime.Now;
        static int month = now.Month;
        static int year = now.Year;

        public MonthlyCalender()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = Convert.ToString(month);
            static_year = Convert.ToString(year);

            //first days of the month.
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month)+1;

            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // usercontrol for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
           
        }

       


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void daToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.ForeColor = dlg.Color;
            }
        }

        private void nextMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;
            DisplayDays();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;
            DisplayDays();
        }

        private void previousMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            DisplayDays();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            DisplayDays();
        }

        private void currentMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            daycontainer.Controls.Clear();
            DisplayDays();
        }


        public void todaysTaskListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            TodaysTaskList TodaysTaskList = new TodaysTaskList();
            TodaysTaskList.Show();
        }


        private void brainDumpListToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            BrainDumpList BrainDumpList = new BrainDumpList();
            BrainDumpList.Show();


        }

        private void archieveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchieveList ArchieveList = new ArchieveList();
            ArchieveList.Show();
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
