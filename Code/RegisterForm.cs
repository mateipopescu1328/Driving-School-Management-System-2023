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
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();
        public RegisterForm()
        {
            InitializeComponent();
            showTable();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `elevi`"));
        }

        //create a function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") || (textBox_cnp.Text == ""))
            {
                return false;
            }
            else
                return true;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            string CNP = textBox_cnp.Text;
            string phone = textBox_phone.Text; 
            string address = textBox_address.Text;
           
            if (verify())
            {
                try
                {
                    if (student.insertStudent(fname, lname, CNP, address, phone))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_cnp.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
        }
    }
}
