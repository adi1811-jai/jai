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
    public partial class ADMIN_PATIENTS_AND_ANIMALS : Form
    {
    
        public ADMIN_PATIENTS_AND_ANIMALS()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OWNER_AND_PET_REGISTRATION owner_and_pet_registration = new OWNER_AND_PET_REGISTRATION();
            owner_and_pet_registration.ShowDialog();
        }

        private void ADMIN_PATIENTS_AND_ANIMALS_Load(object sender, EventArgs e)
        {

        }

    }
}
