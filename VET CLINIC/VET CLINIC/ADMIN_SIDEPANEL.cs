using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VET_CLINIC
{
    public partial class ADMIN_SIDEPANEL : Form
    {
        public ADMIN_SIDEPANEL()
        {
            InitializeComponent();
          

        }



        private void ADMIN_SIDEPANEL_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ADMIN_APPOINTMENTS admin_appointments = new ADMIN_APPOINTMENTS();
            admin_appointments.TopLevel = false;
            panel1.Controls.Add(admin_appointments);
            admin_appointments.BringToFront();
            admin_appointments.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ADMIN_PATIENTS_AND_ANIMALS admin_patients_and_animals= new ADMIN_PATIENTS_AND_ANIMALS();
            admin_patients_and_animals.TopLevel = false;
            panel1.Controls.Add(admin_patients_and_animals);
            admin_patients_and_animals.BringToFront();
            admin_patients_and_animals.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click_1(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            this.Hide();
            login.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            ADMIN_APPOINTMENTS admin_appointments = new ADMIN_APPOINTMENTS();
            admin_appointments.TopLevel = false;
            panel1.Controls.Add(admin_appointments);
            admin_appointments.BringToFront();
            admin_appointments.Show();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            ADMIN_PATIENTS_AND_ANIMALS admin_patients_and_animals = new ADMIN_PATIENTS_AND_ANIMALS();
            admin_patients_and_animals.TopLevel = false;
            panel1.Controls.Add(admin_patients_and_animals);
            admin_patients_and_animals.BringToFront();
            admin_patients_and_animals.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            // Create an instance of ADMIN_SIDEPANEL
            ADMIN_SIDEPANEL admin_sidepanel = new ADMIN_SIDEPANEL();
            admin_sidepanel.TopLevel = false;

            // Set the size of the destination panel1 to match the size of admin_sidepanel.panel1
            panel1.Controls.Add(admin_sidepanel.panel1);
            admin_sidepanel.panel1.Dock = DockStyle.Fill;

            // Show the entire admin_sidepanel
            panel1.Controls.Add(admin_sidepanel);
            admin_sidepanel.Dock = DockStyle.Fill;

            // Show the panel1
            admin_sidepanel.panel1.BringToFront();
            admin_sidepanel.Show();
        }

        private void guna2CustomGradientPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel28_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        