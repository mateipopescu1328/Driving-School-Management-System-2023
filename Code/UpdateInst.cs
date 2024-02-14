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
    public partial class UpdateInst : Form
    {
        InstructClass instruct = new InstructClass();
        public UpdateInst()
        {
            InitializeComponent();
            showTable();
        }

        private void UpdateInst_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show student list in DatagridView
        public void showTable()
        {
            DataGridView_student.DataSource = instruct.getInstructlist(new MySqlCommand("SELECT * FROM `instructori`"));
        }






        //create a function to verify
        bool verify()
        {
            if ((textBox_Exp.Text == "") || (textBox_Cat.Text == "") || (textBox_Idang.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

       

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox_Exp.Clear();
            textBox_Cat.Clear();
            textBox_Idang.Clear();
            textBox_id.Clear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //remove the selected Student
            int id = Convert.ToInt32(textBox_id.Text);
            //Show a confirmation message before delete the student
            if (MessageBox.Show("Are you sure you want to remove this instruct", "Remove Instruct", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (instruct.deleteInstruct(id))
                {
                    showTable();
                    MessageBox.Show("Instruct Removed", "Remove instruct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_button.PerformClick();
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            // update student record
            int id = Convert.ToInt32(textBox_id.Text);
            int aid = Convert.ToInt32(textBox_Idang.Text);
            string exper = textBox_Exp.Text;
            string categ = textBox_Cat.Text;



            if (verify())
            {
                try
                {
                    if (instruct.updateInstruct(id, aid, exper, categ))
                    {
                        showTable();
                        MessageBox.Show("Instruct data update", "Update Instruct", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Empty Field", "Update Instruct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = instruct.searchInstruct(textBox_search.Text);
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Idang.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Exp.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();
            textBox_Cat.Text = DataGridView_student.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
