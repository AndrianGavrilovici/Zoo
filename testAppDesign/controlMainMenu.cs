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
    public partial class controlMainMenu : UserControl
    {
        public controlMainMenu()
        {
            InitializeComponent();
            /* Active button of the main menu set as the USER MENU button */
            activeBar.Height = btnHome.Height - 1;
            activeBar.Top = btnHome.Top;
        }
        private void btnHome_Click(object sender, EventArgs e) {
            activeBar.Height = btnHome.Height - 1;
            activeBar.Top = btnHome.Top;
            controlMainContainer mainText = new controlMainContainer();
            mainText.Dock = DockStyle.Fill;
            home.Instance.PnlContainer.Controls["controlMainContainer"].BringToFront();
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            /* Active button of the main menu set as the USER MENU button */
            activeBar.Height = btnUserMenu.Height - 1;
            activeBar.Top = btnUserMenu.Top;
            /* Change to USER MENU */
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlUserMenu"))
            {
                controlUserMenu userMenu = new controlUserMenu();
                userMenu.Dock = DockStyle.Fill;
                home.Instance.PnlLeft.Controls.Add(userMenu);
            }
            home.Instance.PnlLeft.Controls["controlUserMenu"].BringToFront();
            /* Add Content Search in main box */
            controlSearchAnimal search = new controlSearchAnimal();
            search.Dock = DockStyle.Fill;
            home.Instance.PnlContainer.Controls.Add(search);
            home.Instance.PnlContainer.Controls["controlSearchAnimal"].BringToFront();
            home.Instance.BackButton.Visible = true;
        }

        private void btnAdminMenu_Click(object sender, EventArgs e)
        {
            /* Active button of the main menu set as the ADMIN MENU button */
            activeBar.Height = btnAdminMenu.Height - 1;
            activeBar.Top = btnAdminMenu.Top;
            /* Add Content Search in main box */
            ControlPass pass = new ControlPass();
            pass.Dock = DockStyle.Fill;
            home.Instance.PnlContainer.Controls.Add(pass);
            home.Instance.PnlContainer.Controls["ControlPass"].BringToFront();
            home.Instance.BackButton.Visible = false;

        }
    }
}
