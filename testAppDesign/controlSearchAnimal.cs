using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace testAppDesign
{
    public partial class controlSearchAnimal : UserControl
    {
        public controlSearchAnimal()
        {
            InitializeComponent();
            noExistAnimal.Hide();
            panelContent.Hide();
        }
        private void inputNameAnimal_TextChanged(object sender, EventArgs e)
        {
            panelContent.Hide();
            noExistAnimal.Hide();
        }
        private void inputSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = inputSearch.Text;
            userData data = new userData();
            int animalNum = 0;
            if (data.Verification (search, ref animalNum))
            {
                panelContent.Show();
                nameAnimal.Text = data.Animals[animalNum];
                quantityMale.Text = data.Quantity[animalNum, 0].ToString();
                quantityFemale.Text = data.Quantity[animalNum, 1].ToString();
                priceAnimal.Text = data.Price[animalNum].ToString() + "$";
            }
            else noExistAnimal.Show();
        }
    }
}
