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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void showHideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void passwordTextBox_OnValueChanged(object sender, EventArgs e)
        {
         
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SIGNUP signup = new SIGNUP();
            this.Hide();
            signup.Show();
        }

        private void confirm_password_OnValueChanged(object sender, EventArgs e)
        {
        
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SIGNUP sIGNUP = new SIGNUP();   
            this.Hide();    
            sIGNUP.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ADMIN_SIDEPANEL admin_sidepanel = new ADMIN_SIDEPANEL();
            this.Hide();
            admin_sidepanel.Show();
        }

        private void passwordTextBox_OnValueChanged_1(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;

        }

        private void showHideCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            // Check if the CheckBox is checked
            if (showHideCheckBox.Checked)
            {
                // If checked, show the password
                passwordTextBox.isPassword = false;

            }
            else
            {
                // If unchecked, hide the password
                passwordTextBox.isPassword = true;

            }
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
