using Guna.UI2.WinForms;
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
    public partial class OWNER_AND_PET_REGISTRATION : Form
    {   
        public OWNER_AND_PET_REGISTRATION()
        {
            InitializeComponent();          
        }

        private void OWNER_AND_PET_REGISTRATION_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // Check if any of the textboxes is empty
            if (string.IsNullOrWhiteSpace(pet_name.Text) ||
                string.IsNullOrWhiteSpace(pet_breed.Text) ||
                string.IsNullOrWhiteSpace(pet_color.Text) ||
                string.IsNullOrWhiteSpace(pet_gender.Text) ||
                string.IsNullOrWhiteSpace(owner_name.Text) ||
                string.IsNullOrWhiteSpace(owner_address.Text))
            {
                // Show a MessageBox indicating that one or more fields are empty
                MessageBox.Show("Please fill in all fields before submitting.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Perform the submission logic here (e.g., saving data to a database)
                // ...

                // Close the form after submission
                this.Close();
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {                  
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
