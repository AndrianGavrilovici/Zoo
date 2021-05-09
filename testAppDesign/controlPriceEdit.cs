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
    public partial class controlPriceEdit : UserControl {
        public controlPriceEdit() {
            InitializeComponent();
            noExistAnimal.Hide();
            panelContent.Hide();
            succesEdit.Hide();
        }
        int animalNum = 0;
        private void inputSpecies_TextChanged(object sender, EventArgs e) {
            noExistAnimal.Hide();
            panelContent.Hide();
            succesEdit.Hide();
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

        private void inputNewPrice_TextChanged(object sender, EventArgs e) {
            succesEdit.Hide();
        }

        private void inputNewPrice_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnEditPrice_Click(this, new EventArgs());
        }

        private void btnEditPrice_Click(object sender, EventArgs e) {
            int newPrice = Int32.Parse(inputNewPrice.Text);
            userData data = new userData();
            nameAnimal.Text = data.Animals[animalNum];
            quantityMale.Text = data.Quantity[animalNum, 0].ToString();
            quantityFemale.Text = data.Quantity[animalNum, 1].ToString();
            data.editPrice(newPrice, animalNum, "admin");
            succesEdit.Show();
        }
    }
}
