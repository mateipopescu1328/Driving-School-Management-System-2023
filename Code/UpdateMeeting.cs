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
    public partial class UpdateMeeting : Form
    {

        MeetingClass meeting = new MeetingClass();
        public UpdateMeeting()
        {
            InitializeComponent();
            showInstData();
            showData();
            showAutoData();
        }

        private void UpdateMeeting_Load(object sender, EventArgs e)
        {
            showData();

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

        // Show data of the course 
        private void showData()
        {
            //to show course list on datagridview
            DataGridView_meeting.DataSource = meeting.getMeeting(new MySqlCommand("SELECT * FROM `sedinte`"));
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (textBox_type.Text == "" || textBox_date.Text == "" || textBox_instid.Text == "" || textBox_numin.Text == "" || textBox_id.Text == "")
            {
                MessageBox.Show("Need Meeting data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_instid.Text);
                int instid = Convert.ToInt32(textBox_instid.Text);
                string numin = textBox_numin.Text;
                string type = textBox_type.Text;
                DateTime date = textBox_date.Value;
                int hr = Convert.ToInt32(textBox_h.Text);
                string prog = textBox_prog.Text;
                string location = textBox_location.Text;


                if (meeting.updateMeeting(id, instid, numin, type, date, hr, prog, location))
                {
                    showData();
                    clear_button.PerformClick();
                    MessageBox.Show("meeting update successfuly", "Update Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error-Meeting not Edit", "Update Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox_type.Clear();
            textBox_date.Value = DateTime.Now;
            textBox_h.Clear();
            textBox_prog.Clear();
            textBox_location.Clear();
            textBox_instid.Clear();
            textBox_numin.Clear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Equals(""))
            {
                MessageBox.Show("Need Meeting Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (meeting.deleteMeeting(id))
                    {
                        showData();
                        clear_button.PerformClick();
                        MessageBox.Show("Meeting Deleted", "Removed Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Removed Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void search_button_Click(object sender, EventArgs e)
            {
            //To Search course and show on datagridview
            DataGridView_meeting.DataSource = meeting.getMeeting(new MySqlCommand("SELECT * FROM `sedinte` WHERE CONCAT(`Tip_sedinta`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void DataGridView_meeting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView_meeting.CurrentRow.Cells[0].Value.ToString();
            textBox_instid.Text = DataGridView_meeting.CurrentRow.Cells[1].Value.ToString();
            textBox_numin.Text = DataGridView_meeting.CurrentRow.Cells[2].Value.ToString();
            textBox_type.Text = DataGridView_meeting.CurrentRow.Cells[3].Value.ToString();
            textBox_date.Value = (DateTime)DataGridView_meeting.CurrentRow.Cells[4].Value;
            textBox_h.Text = DataGridView_meeting.CurrentRow.Cells[5].Value.ToString();
            textBox_prog.Text = DataGridView_meeting.CurrentRow.Cells[6].Value.ToString();
            textBox_location.Text = DataGridView_meeting.CurrentRow.Cells[7].Value.ToString();
        }
    }

    
}
