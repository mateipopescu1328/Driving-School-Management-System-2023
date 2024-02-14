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
    public partial class MainForm : Form
    {
        StudentClass student = new StudentClass();
        public MainForm()
        {
            InitializeComponent();
            costumizeDesign();
            studentCount();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            pictureBox2.SendToBack();
            panel_top.SendToBack();
            childForm.BringToFront();
            childForm.Show();

        }

        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Total Students : " + student.totalStudent();

        }

        private void costumizeDesign()
        {
            panel_elevsubmenu.Visible = false;
            panel_sedintasubmenu.Visible = false;
            panel_instructorsubmenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_elevsubmenu.Visible == true)
                panel_elevsubmenu.Visible = false;
            if (panel_sedintasubmenu.Visible == true)
                panel_sedintasubmenu.Visible = false;
            if (panel_instructorsubmenu.Visible == true)
                panel_instructorsubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        #region Elevi

        private void button_elevi_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_elevsubmenu);
        }

        private void inregistrare_elevi_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            hideSubmenu();
            studentCount();
        }

        private void modificare_elevi_Click(object sender, EventArgs e)
        {
            openChildForm(new Update());
            hideSubmenu();
            studentCount();
        }

        private void afisare_elevi_Click(object sender, EventArgs e)
        {
            openChildForm(new Display());
            hideSubmenu();
            studentCount();
        }

        #endregion Elevi
        #region Sedinte

        private void button_sedinte_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_sedintasubmenu);
        }

        private void inregistrare_sedinte_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterMeeting());
            hideSubmenu();
        }

        private void modificare_sedinte_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateMeeting());
            hideSubmenu();
        }

        private void afisare_sedinte_Click(object sender, EventArgs e)
        {
            openChildForm(new DisplayMeeting());
            hideSubmenu();
        }

        #endregion Sedinte
        #region Instructori
        private void button_instructori_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_instructorsubmenu);
        }

        private void inregistrare_instructori_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterInst());
            hideSubmenu();
        }

        private void modificarere_instructori_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateInst());
            hideSubmenu();
        }

        private void afisare_instructori_Click(object sender, EventArgs e)
        {
            openChildForm(new DisplayInst());
            hideSubmenu();
        }

        #endregion Instructori

        private void EXIT_but_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                pictureBox2.BringToFront();
                panel_top.BringToFront();
                panel1.BringToFront();
            }
            hideSubmenu();
            studentCount();
        }

        private void INTER_but_Click(object sender, EventArgs e)
        {
            openChildForm(new Interogari());
        }
    }
}
