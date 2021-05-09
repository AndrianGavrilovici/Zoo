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
    public partial class controlBasket : UserControl {       
        public controlBasket() {
            InitializeComponent();
            AddLabel();
        }
        public void AddLabel(int number = 0, bool start = false) {
            textAnimal.Text = number.ToString();
            if (start == false) return;
            userData data = new userData();         
            for (int num = number; num < number + 1; num++)
                for (int i = 0; i < 4; i++) {
                    //Create label
                    Label label = new System.Windows.Forms.Label();
                    //Setting for label
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    label.ForeColor = System.Drawing.Color.Black;
                    //Position label on screen and set text
                    switch (i) {
                        case 0:
                            label.MinimumSize = new System.Drawing.Size(185, 40);
                            label.Location = new System.Drawing.Point(65, 100 + (num * 60));
                            label.Text = data.Animals[num];
                            break;
                        case 1:
                            label.MinimumSize = new System.Drawing.Size(81, 40);
                            label.Location = new System.Drawing.Point(300, 100 + (num * 60));
                            label.Text = data.Quantity[num, 0].ToString();
                            break;
                        case 2:
                            label.MinimumSize = new System.Drawing.Size(113, 40);
                            label.Location = new System.Drawing.Point(460, 100 + (num * 60));
                            label.Text = data.Quantity[num, 1].ToString();
                            break;
                        case 3:
                            label.MinimumSize = new System.Drawing.Size(85, 40);
                            label.Location = new System.Drawing.Point(655, 100 + (num * 60));
                            label.Text = data.Price[num].ToString() + "$";
                            label.Cursor = System.Windows.Forms.Cursors.Hand;
                            label.MouseHover += new System.EventHandler(label_MouseHover);
                            label.MouseLeave += new System.EventHandler(label_MouseLeave);
                            label.Click += new System.EventHandler(label_Click);
                            void label_MouseHover(object sender, EventArgs e) {
                                label.ForeColor = Color.Orange;
                            }
                            void label_MouseLeave(object sender, EventArgs e) {
                                label.ForeColor = Color.Black;
                            }
                            void label_Click(object sender, EventArgs e) {
                                label.ForeColor = Color.DarkOrange;
                            }
                            break;
                    }
                    label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                    //Add controls to form
                }
        }
    }
}
