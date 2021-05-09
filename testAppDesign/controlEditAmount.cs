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
    public partial class controlEditAmount : UserControl {
        public controlEditAmount() {
            InitializeComponent();
            noExistAnimal.Hide();
            panelAdding.Hide();
            textSuccesAdded.Hide();
            panelDelete.Hide();
            textSuccesDeleted.Hide();
        }
        int animalNum = 0;
        private void inputSpecies_TextChanged(object sender, EventArgs e) {
            noExistAnimal.Hide();
            numberAddMale.Text = "0";
            numberAddFemale.Text = "0";
            textSuccesAdded.Hide();
            numberDeleteMale.Text = "0";
            numberDeleteFemale.Text = "0";
            textSuccesDeleted.Hide();
        }
        private void btnAdding_Click(object sender, EventArgs e) {
            string search = inputSpecies.Text;
            userData data = new userData();
            if (data.Verification(search, ref animalNum)) {
                numberAddMale.Text = "0";
                numberAddFemale.Text = "0";
                textSuccesDeleted.Hide();
                textSuccesAdded.Hide();
                panelAdding.Show();
            } else noExistAnimal.Show();
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            string search = inputSpecies.Text;
            userData data = new userData();
            if (data.Verification(search, ref animalNum)) {
                numberDeleteMale.Text = "0";
                numberDeleteFemale.Text = "0";
                textSuccesDeleted.Hide();
                textSuccesAdded.Hide();
                panelDelete.Show();
            } else noExistAnimal.Show();
        }
        private void numberAddMale_TextChanged(object sender, EventArgs e) {
            textSuccesAdded.Hide();
        }
        private void numberAddFemale_TextChanged(object sender, EventArgs e) {
            textSuccesAdded.Hide();
        }
        private void numberAddMale_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnAddAmount_Click(this, new EventArgs());
        }
        private void numberAddFemale_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnAddAmount_Click(this, new EventArgs());
        }
        private void btnAddAmount_Click(object sender, EventArgs e) {
            int addMale = Int32.Parse(numberAddMale.Text);
            int addFemale = Int32.Parse(numberAddFemale.Text);
            userData data = new userData();
            data.editAmount(addMale, addFemale, animalNum, "add");
            textSuccesAdded.Show();
        }

        private void numberDeleteMale_TextChanged(object sender, EventArgs e) {
            textSuccesDeleted.Hide();
        }

        private void numberDeleteFemale_TextChanged(object sender, EventArgs e) {
            textSuccesDeleted.Hide();
        }
        private void numberDeleteMale_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnDeleteAmount_Click(this, new EventArgs());
        }

        private void numberDeleteFemale_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnDeleteAmount_Click(this, new EventArgs());
        }
        private void btnDeleteAmount_Click(object sender, EventArgs e) {
            int deleteMale = Int32.Parse(numberDeleteMale.Text);
            int deleteFemale = Int32.Parse(numberDeleteFemale.Text);
            userData data = new userData();
            data.editAmount(deleteMale, deleteFemale, animalNum, "delete");
            textSuccesDeleted.Show();
        }

        
    }
}
