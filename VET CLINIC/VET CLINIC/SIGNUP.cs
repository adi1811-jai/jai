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
    public partial class SIGNUP : Form
    {
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            this.Hide();
            login.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void showHideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the CheckBox is checked
            if (showHideCheckBox.Checked)
            {
                // If checked, show the password
                passwordTextBox.isPassword = false;
                confirm_password.isPassword = false;

            }
            else
            {
                // If unchecked, hide the password
                passwordTextBox.isPassword = true;
                confirm_password.isPassword= true;
            }
        }

        private void passwordTextBox_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;
        }

        private void confirm_password_OnValueChanged(object sender, EventArgs e)
        {
            confirm_password.isPassword = true;
        }
    }
}
