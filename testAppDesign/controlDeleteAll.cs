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
    public partial class controlDeleteAll : UserControl {
        public controlDeleteAll() {
            InitializeComponent();
            succesDelete.Hide();
        }

        private void btnDelAll_Click(object sender, EventArgs e) {
            userData data = new userData();
            data.deleteAllAnimals("admin");
            succesDelete.Show();
        }
    }
}
