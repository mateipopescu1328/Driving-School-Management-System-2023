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
    public partial class RegisterMeeting : Form
    {
        MeetingClass meeting = new MeetingClass();
        public RegisterMeeting()
        {
            InitializeComponent();
            showInstData();
            showData();
            showAutoData();
        }

        private void showAutoData()
        {
            //to show course list on datagridview
            DataGridView_auto.DataSource = meeting.getAuto(new MySqlCommand("SELECT Numar_inmatriculare FROM `autovehicule`"));
        }


        private void showInstData()
        {
            //to show course list on datagridview
            DataGridView_inst.DataSource = meeting.getInst(new MySqlCommand("SELECT Instructor_ID FROM `instructori`"));
        }
        private void RegisterMeeting_Load(object sender, EventArgs e)
        {
            showInstData();
            showData(); 
            showAutoData();
        }

        private void showData()
        {
            //to show course list on datagridview
            DataGridView_meeting.DataSource = meeting.getMeeting(new MySqlCommand("SELECT * FROM `sedinte`"));
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (textBox_type.Text == "" || textBox_h.Text == "" || textBox_date.Text == "" || textBox_prog.Text == "" || textBox_location.Text == "")
            {
                MessageBox.Show("Need Meeting data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                int instid = Convert.ToInt32(textBox_instid.Text);
                string numin = textBox_numin.Text;
                string type = textBox_type.Text;
                DateTime date= textBox_date.Value;
                int hr = Convert.ToInt32(textBox_h.Text);
                string prog = textBox_prog.Text;
                string location = textBox_location.Text;
                

                if (meeting.insetMeeting(type ,instid, numin, date, hr, prog, location))
                {
                    showData();
                    clear_button.PerformClick();
                    MessageBox.Show("New Meeting inserted", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Meeting not insert", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox_type.Clear();
            textBox_date.Value=DateTime.Now;
            textBox_h.Clear(); 
            textBox_prog.Clear();
            textBox_location.Clear();
            textBox_instid.Clear();
            textBox_numin.Clear();
        }
    }
}
