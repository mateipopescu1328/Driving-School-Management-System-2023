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
    public partial class DisplayInst : Form
    {

        InstructClass instruct = new InstructClass();
        public DisplayInst()
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
            DataGridView_student.DataSource = instruct.getInstructlist(new MySqlCommand("SELECT * FROM `instructori`"));
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = instruct.searchInstruct(textBox_search.Text);
        }
    }
}
