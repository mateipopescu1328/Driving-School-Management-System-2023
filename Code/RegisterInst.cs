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
    public partial class RegisterInst : Form
    {
        InstructClass instruct = new InstructClass();
        public RegisterInst()
        {
            InitializeComponent();
            showTable();
        }

        private void RegisterInst_Load(object sender, EventArgs e)
        {
            showTable();
        }
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
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string experi = textBox_Exp.Text;
            string categ = textBox_Cat.Text;
            int idang = Convert.ToInt32(textBox_Idang.Text);

            if (verify())
            {
                try
                {
                    if (instruct.insertInstruct(idang, experi, categ))
                    {
                        showTable();
                        MessageBox.Show("New Instruct Added", "Add Instruct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Instruct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
