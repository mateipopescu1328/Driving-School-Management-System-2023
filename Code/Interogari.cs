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
    public partial class Interogari : Form
    {
        InterClass inter = new InterClass();
        public Interogari()
        {
            InitializeComponent();
        }

        private void Interogari_Load(object sender, EventArgs e)
        {

        }

        private void inter_1_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_1();
        }

        private void inter_2_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_2();
        }

        private void inter_3_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_3();
        }

        private void inter_4_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_4();
        }

        private void inter_5_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_5();
        }

        private void inter_6_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_6();
        }

        private void inter_7_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_7();
        }

        private void inter_8_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_8();
        }

        private void inter_9_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_9();
        }

        private void inter_10_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = inter.getInter_10();
        }

        private void inter_list_Click(object sender, EventArgs e)
        {
       
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Text", typeof(string));

            dataTable.Rows.Add("inter_1:  Instructorii cu experienta ridicata");
            dataTable.Rows.Add("inter_2:  Instructorii si masina cu exp ridicata ce au avut sedinte dupa 2023 si un progres bun");
            dataTable.Rows.Add("inter_3:  Elevii si feedback-ul celor ce au numele 'Popescu'");
            dataTable.Rows.Add("inter_4:  Elevii si masina cu feedback-ul 'Bun' si progres 'Multumit'");
            dataTable.Rows.Add("inter_5:  Instructorii si tipul de transmisie ce lucreaza pe o masina marca 'Skoda'");
            dataTable.Rows.Add("inter_6:  Elevii, masina si instructrii la lectiile de caegoria 'B'");
            dataTable.Rows.Add("inter_7:  Instructorii si salariul lor, care nu au experienta 'ridicata'");
            dataTable.Rows.Add("inter_8:  Instructorii care au mai multe sedinte");
            dataTable.Rows.Add("inter_9:  Instructorii cu cel mai mare salariu in functie de experienta");
            dataTable.Rows.Add("inter_10: Instructorii care au avut sedinte in ianuarie 2024");

            DataGridView_inter.DataSource = dataTable;

            
            DataGridView_inter.DefaultCellStyle.ForeColor = Color.Black; 
            DataGridView_inter.DefaultCellStyle.BackColor = Color.White; 

        
            DataGridView_inter.Update();
            DataGridView_inter.Refresh();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            DataGridView_inter.DataSource = null;
        }
    }
}
