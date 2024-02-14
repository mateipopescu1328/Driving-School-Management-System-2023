using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_School
{
    public partial class DisplayMeeting : Form
    {
        MeetingClass meeting = new MeetingClass();
        public DisplayMeeting()
        {
            InitializeComponent();
            showTable();
        }
        private void Display_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show student list in DatagridView
        public void showTable()
        {
            DataGridView_meeting.DataSource = meeting.getMeeting(new MySqlCommand("SELECT * FROM `sedinte`"));
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            DataGridView_meeting.DataSource = meeting.searchMeeting(textBox_search.Text);
        }
    }
}
