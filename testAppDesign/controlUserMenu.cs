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
    public partial class controlUserMenu : UserControl {
        public controlUserMenu() {
            InitializeComponent();
            activeBar.Height = btnSearch.Height - 1;
            activeBar.Top = btnSearch.Top;
        }
        public Bunifu.Framework.UI.BunifuFlatButton BtnBasket {
            get { return btnBasket; }
            set { btnBasket = value; }
        }
        private void btnSearch_Click(object sender, EventArgs e) {
            /* Active button of the main menu set as the SEARCH button */
            activeBar.Height = btnSearch.Height - 1;
            activeBar.Top = btnSearch.Top;
            /* Add Content Search in MAIN BOX */
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlSearchAnimal"))
            {
                controlSearchAnimal search = new controlSearchAnimal();
                search.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(search);
            }
            home.Instance.PnlContainer.Controls["controlSearchAnimal"].BringToFront();
        }

        private void btnShowAll_Click(object sender, EventArgs e) {
             /* Active button of the main menu set as the SHOW ALL button */
            activeBar.Height = btnShowAll.Height - 1;
            activeBar.Top = btnShowAll.Top;
            /* Add Content SHOW ALL in MAIN BOX */
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlShowAll"))
            {
                controlShowAll showAll = new controlShowAll();
                showAll.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(showAll);
            }
            home.Instance.PnlContainer.Controls["controlShowAll"].BringToFront();
        }

        private void btnBasket_Click(object sender, EventArgs e) {
            activeBar.Height = btnBasket.Height - 1;
            activeBar.Top = btnBasket.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlBasket")) {
                controlBasket basket = new controlBasket();
                basket.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(basket);
            }
            home.Instance.PnlContainer.Controls["controlBasket"].BringToFront();
        }
    }
}
