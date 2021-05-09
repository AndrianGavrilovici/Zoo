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
    public partial class ControlPass : UserControl {
        public ControlPass() {
            InitializeComponent();
            incorrectPass.Visible = false;
        }
        private static string password = "admin";
        private string _passInput;
        private string PassInput() {
            string _passInput = inputPassword.Text;
            return _passInput;
        }
        private void btnEnter_Click(object sender, EventArgs e) {
            _passInput = PassInput();
            if (!_passInput.Equals(password)) {
                incorrectPass.Visible = true;
            }
            else {
                if (!home.Instance.PnlLeft.Controls.ContainsKey("controlAdminMenu")) {
                    controlAdminMenu adminMenu = new controlAdminMenu();
                    adminMenu.Dock = DockStyle.Fill;
                    home.Instance.PnlLeft.Controls.Add(adminMenu);
                }
                home.Instance.PnlLeft.Controls["controlAdminMenu"].BringToFront();
                home.Instance.BackButton.Visible = true;
                controlSearchAnimal search = new controlSearchAnimal();
                search.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(search);
                home.Instance.PnlContainer.Controls["controlSearchAnimal"].BringToFront();
                home.Instance.BackButton.Visible = true;
            }
        }

        private void inputPassword_TextChanged(object sender, EventArgs e) {
            incorrectPass.Visible = false;
        }

        private void inputPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(this, new EventArgs());
        }
    }
}
