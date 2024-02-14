using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_School
{
    public partial class Update : Form
    {
        StudentClass student = new StudentClass();
        public Update()
        {
            InitializeComponent();
            showTable();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show student list in DatagridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `elevi`"));
        }

       

        

        
        //create a function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") ||
                (textBox_cnp.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        
      

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_cnp.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //remove the selected Student
            int id = Convert.ToInt32(textBox_id.Text);
            //Show a confirmation message before delete the student
            if (MessageBox.Show("Are you sure you want to remove this student", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deleteStudent(id))
                {
                    showTable();
                    MessageBox.Show("Student Removed", "Remove student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_button.PerformClick();
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            // update student record
            int id = Convert.ToInt32(textBox_id.Text);
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            string CNP = textBox_cnp.Text;
            string address = textBox_address.Text;
            string phone = textBox_phone.Text;



            if (verify())
            {
                try
                {
                    if (student.updateStudent(id, fname, lname, CNP, address, phone))
                    {
                        showTable();
                        MessageBox.Show("Student data update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_button.PerformClick();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();
            textBox_cnp.Text = DataGridView_student.CurrentRow.Cells[3].Value.ToString();
            textBox_address.Text = DataGridView_student.CurrentRow.Cells[4].Value.ToString();
            textBox_phone.Text = DataGridView_student.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
