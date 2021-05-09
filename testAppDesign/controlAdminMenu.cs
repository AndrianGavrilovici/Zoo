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
    public partial class controlAdminMenu : UserControl {
        public controlAdminMenu() {
            InitializeComponent();
            activeBar.Height = btnSearch.Height - 1;
            activeBar.Top = btnSearch.Top;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            activeBar.Height = btnSearch.Height - 1;
            activeBar.Top = btnSearch.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlSearchAnimal")) {
                controlSearchAnimal search = new controlSearchAnimal();
                search.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(search);
            }
            home.Instance.PnlContainer.Controls["controlSearchAnimal"].BringToFront();
        }
        private void btnShowAll_Click(object sender, EventArgs e) {
            activeBar.Height = btnShowAll.Height - 1;
            activeBar.Top = btnShowAll.Top;
            
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlShowAll")) {
                controlShowAll showAll = new controlShowAll();
                showAll.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(showAll);
            }
            home.Instance.PnlContainer.Controls["controlShowAll"].BringToFront();
        }
        private void btnAddNew_Click(object sender, EventArgs e) {
            activeBar.Height = btnAddNew.Height - 1;
            activeBar.Top = btnAddNew.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlAddNew")) {
                controlAddNew addNew = new controlAddNew();
                addNew.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(addNew);
            }
            home.Instance.PnlContainer.Controls["controlAddNew"].BringToFront();
        }

        private void btnEditAmount_Click(object sender, EventArgs e) {
            activeBar.Height = btnEditAmount.Height - 1;
            activeBar.Top = btnEditAmount.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlEditAmount")) {
                controlEditAmount editAmount = new controlEditAmount();
                editAmount.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(editAmount);
            }
            home.Instance.PnlContainer.Controls["controlEditAmount"].BringToFront();
        }

        private void btnPriceEdit_Click(object sender, EventArgs e) {
            activeBar.Height = btnPriceEdit.Height - 1;
            activeBar.Top = btnPriceEdit.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlPriceEdit")) {
                controlPriceEdit priceEdit = new controlPriceEdit();
                priceEdit.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(priceEdit);
            }
            home.Instance.PnlContainer.Controls["controlPriceEdit"].BringToFront();
        }

        private void btnDelCategory_Click(object sender, EventArgs e) {
            activeBar.Height = btnDelCategory.Height - 1;
            activeBar.Top = btnDelCategory.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlDelCategory")) {
                controlDelCategory delCategory = new controlDelCategory();
                delCategory.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(delCategory);
            }
            home.Instance.PnlContainer.Controls["controlDelCategory"].BringToFront();
        }

        private void btnDelAll_Click(object sender, EventArgs e) {
            activeBar.Height = btnDelAll.Height - 1;
            activeBar.Top = btnDelAll.Top;
            if (!home.Instance.PnlLeft.Controls.ContainsKey("controlDeleteAll")) {
                controlDeleteAll delAll = new controlDeleteAll();
                delAll.Dock = DockStyle.Fill;
                home.Instance.PnlContainer.Controls.Add(delAll);
            }
            home.Instance.PnlContainer.Controls["controlDeleteAll"].BringToFront();
        }


    }
}
