using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAppDesign
{
    public partial class home : Form
    {
        static home _obj;
        
        public static home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new home();
                }
                return _obj;
            }
        }
        public Panel PnlLeft
        {
            get { return leftPanel; }
            set { leftPanel = value; }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Hide back button
            btnBack.Visible = false;
            _obj = this;
            //Add main menu in left bar
            controlMainMenu mainMenu = new controlMainMenu();
            mainMenu.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(mainMenu);
            //Add Content control in main box
            controlMainContainer mainText = new controlMainContainer();
            mainText.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mainText);
            
            //controlDelCategory delCategory = new controlDelCategory();
            //delCategory.Dock = DockStyle.Fill;
            //panelContainer.Controls.Add(delCategory);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            /* Button function to hide the user's menu and display the main menu */

            panelContainer.Controls["controlMainContainer"].BringToFront();
            leftPanel.Controls["controlMainMenu"].BringToFront();
            btnBack.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
