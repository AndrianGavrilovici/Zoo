using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAppDesign {
    public partial class controlDelCategory : UserControl {
        public controlDelCategory() {
            InitializeComponent();
            noExistAnimal.Hide();
            panelContent.Hide();
            succesDelete.Hide();
        }
        int animalNum = 0;
        private void inputSpecies_TextChanged(object sender, EventArgs e) {
            noExistAnimal.Hide();
            panelContent.Hide();
            succesDelete.Hide();
        }
        private void inputSpecies_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(this, new EventArgs());
        }
        private void btnEnter_Click(object sender, EventArgs e) {
            string search = inputSpecies.Text;
            userData data = new userData();
            
            if (data.Verification(search, ref animalNum)) {
                panelContent.Show();  
            } else noExistAnimal.Show();
        }

        private void btnMale_Click(object sender, EventArgs e) {
            userData data = new userData();
            data.deleteCategory(animalNum, 1, "admin");
            succesDelete.Show();
        }

        private void btnFemale_Click(object sender, EventArgs e) {
            userData data = new userData();
            data.deleteCategory(animalNum, 2, "admin");
            succesDelete.Show();
        }

        private void btnBoth_Click(object sender, EventArgs e) {
            userData data = new userData();
            data.deleteCategory(animalNum, 3, "admin");
            succesDelete.Show();
        }
    }
}
