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
    public partial class controlAddNew : UserControl {
        public controlAddNew() {
            InitializeComponent();
            existAnimal.Hide();
            wasAdded.Hide();
            panelAdd.Hide();
        }

        private void inputAddNew_TextChanged(object sender, EventArgs e) {
            existAnimal.Hide();
            wasAdded.Hide();
            panelAdd.Hide();
        }
        private void inputAddNew_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(this, new EventArgs());
        }
        private void btnEnter_Click(object sender, EventArgs e) {
            string add = inputAddNew.Text;
            userData data = new userData();
            int animalNum = 0;
            if (!data.Verification(add, ref animalNum)) {
                panelAdd.Show();
                nameAnimal.Text = add;
            } else existAnimal.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            userData data = new userData();
            int _male = Int32.Parse(quantityMale.Text);
            int _female = Int32.Parse(quantityFemale.Text);
            int _price = Int32.Parse(price.Text);
            data.addNewAnimal(nameAnimal.Text, _male, _female, _price, "admin");
            wasAdded.Show();
            quantityMale.Text = "";
            quantityFemale.Text = "";
            price.Text = "";
        }
    }
}
