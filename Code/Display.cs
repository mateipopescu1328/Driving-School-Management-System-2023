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
    public partial class Display : Form
    {

        StudentClass student = new StudentClass();
        public Display()
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
            DataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `elevi`"));
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
        }
    }
}
