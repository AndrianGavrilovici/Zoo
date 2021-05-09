namespace testAppDesign {
    partial class controlPriceEdit {
        /// <summary> 
        /// Required constructor variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Free up all used resources.
        /// </summary>
        /// <param name="disposing">true if the managed resource should be deleted; otherwise, it is false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Required method for constructor support - do not modify
        /// the contents of this method using a code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPriceEdit));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.noExistAnimal = new System.Windows.Forms.Label();
            this.textEnterAnimal = new System.Windows.Forms.Label();
            this.inputSpecies = new System.Windows.Forms.TextBox();
            this.bunifuRountInput = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnEditPrice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.succesEdit = new System.Windows.Forms.Label();
            this.inputNewPrice = new System.Windows.Forms.TextBox();
            this.bunifuSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.textPrice = new System.Windows.Forms.Label();
            this.quantityFemale = new System.Windows.Forms.Label();
            this.quantityMale = new System.Windows.Forms.Label();
            this.textFemale = new System.Windows.Forms.Label();
            this.nameAnimal = new System.Windows.Forms.Label();
            this.textMale = new System.Windows.Forms.Label();
            this.textAnimal = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.btnEnter);
            this.panelSearch.Controls.Add(this.noExistAnimal);
            this.panelSearch.Controls.Add(this.textEnterAnimal);
            this.panelSearch.Controls.Add(this.inputSpecies);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(990, 222);
            this.panelSearch.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Activecolor = System.Drawing.Color.Transparent;
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.BorderRadius = 0;
            this.btnEnter.ButtonText = "";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnter.Iconimage")));
            this.btnEnter.Iconimage_right = null;
            this.btnEnter.Iconimage_right_Selected = null;
            this.btnEnter.Iconimage_Selected = null;
            this.btnEnter.IconMarginLeft = 0;
            this.btnEnter.IconMarginRight = 0;
            this.btnEnter.IconRightVisible = true;
            this.btnEnter.IconRightZoom = 0D;
            this.btnEnter.IconVisible = true;
            this.btnEnter.IconZoom = 80D;
            this.btnEnter.IsTab = false;
            this.btnEnter.Location = new System.Drawing.Point(766, 97);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(65, 65);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.Textcolor = System.Drawing.Color.White;
            this.btnEnter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // noExistAnimal
            // 
            this.noExistAnimal.AutoSize = true;
            this.noExistAnimal.BackColor = System.Drawing.Color.Transparent;
            this.noExistAnimal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noExistAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.noExistAnimal.Location = new System.Drawing.Point(86, 172);
            this.noExistAnimal.MinimumSize = new System.Drawing.Size(674, 26);
            this.noExistAnimal.Name = "noExistAnimal";
            this.noExistAnimal.Size = new System.Drawing.Size(674, 26);
            this.noExistAnimal.TabIndex = 11;
            this.noExistAnimal.Text = "Sorry. There is no such animal in our store.";
            this.noExistAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textEnterAnimal
            // 
            this.textEnterAnimal.AutoSize = true;
            this.textEnterAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textEnterAnimal.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEnterAnimal.ForeColor = System.Drawing.Color.Black;
            this.textEnterAnimal.Location = new System.Drawing.Point(81, 64);
            this.textEnterAnimal.MinimumSize = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.Name = "textEnterAnimal";
            this.textEnterAnimal.Size = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.TabIndex = 10;
            this.textEnterAnimal.Text = "Enter the species of the animal";
            this.textEnterAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSpecies
            // 
            this.inputSpecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSpecies.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSpecies.Location = new System.Drawing.Point(86, 124);
            this.inputSpecies.Name = "inputSpecies";
            this.inputSpecies.Size = new System.Drawing.Size(674, 38);
            this.inputSpecies.TabIndex = 9;
            this.inputSpecies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSpecies.TextChanged += new System.EventHandler(this.inputSpecies_TextChanged);
            this.inputSpecies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSpecies_KeyDown);
            // 
            // bunifuRountInput
            // 
            this.bunifuRountInput.ElipseRadius = 10;
            this.bunifuRountInput.TargetControl = this.inputSpecies;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.btnEditPrice);
            this.panelContent.Controls.Add(this.succesEdit);
            this.panelContent.Controls.Add(this.inputNewPrice);
            this.panelContent.Controls.Add(this.bunifuSeparator);
            this.panelContent.Controls.Add(this.textPrice);
            this.panelContent.Controls.Add(this.quantityFemale);
            this.panelContent.Controls.Add(this.quantityMale);
            this.panelContent.Controls.Add(this.textFemale);
            this.panelContent.Controls.Add(this.nameAnimal);
            this.panelContent.Controls.Add(this.textMale);
            this.panelContent.Controls.Add(this.textAnimal);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(0, 245);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(990, 381);
            this.panelContent.TabIndex = 1;
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.Activecolor = System.Drawing.Color.Transparent;
            this.btnEditPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPrice.BorderRadius = 0;
            this.btnEditPrice.ButtonText = "Edit Price";
            this.btnEditPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPrice.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditPrice.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditPrice.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditPrice.Iconimage")));
            this.btnEditPrice.Iconimage_right = null;
            this.btnEditPrice.Iconimage_right_Selected = null;
            this.btnEditPrice.Iconimage_Selected = null;
            this.btnEditPrice.IconMarginLeft = 0;
            this.btnEditPrice.IconMarginRight = 0;
            this.btnEditPrice.IconRightVisible = true;
            this.btnEditPrice.IconRightZoom = 0D;
            this.btnEditPrice.IconVisible = true;
            this.btnEditPrice.IconZoom = 120D;
            this.btnEditPrice.IsTab = false;
            this.btnEditPrice.Location = new System.Drawing.Point(303, 222);
            this.btnEditPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEditPrice.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEditPrice.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnEditPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditPrice.selected = false;
            this.btnEditPrice.Size = new System.Drawing.Size(239, 65);
            this.btnEditPrice.TabIndex = 22;
            this.btnEditPrice.Text = "Edit Price";
            this.btnEditPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPrice.Textcolor = System.Drawing.Color.Black;
            this.btnEditPrice.TextFont = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditPrice.Click += new System.EventHandler(this.btnEditPrice_Click);
            // 
            // succesEdit
            // 
            this.succesEdit.AutoSize = true;
            this.succesEdit.BackColor = System.Drawing.Color.Transparent;
            this.succesEdit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succesEdit.ForeColor = System.Drawing.Color.Lime;
            this.succesEdit.Location = new System.Drawing.Point(253, 304);
            this.succesEdit.Name = "succesEdit";
            this.succesEdit.Size = new System.Drawing.Size(354, 26);
            this.succesEdit.TabIndex = 21;
            this.succesEdit.Text = "The price has been successfully edited!";
            this.succesEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // inputNewPrice
            // 
            this.inputNewPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNewPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNewPrice.Location = new System.Drawing.Point(665, 142);
            this.inputNewPrice.Name = "inputNewPrice";
            this.inputNewPrice.Size = new System.Drawing.Size(110, 30);
            this.inputNewPrice.TabIndex = 20;
            this.inputNewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNewPrice.TextChanged += new System.EventHandler(this.inputNewPrice_TextChanged);
            this.inputNewPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputNewPrice_KeyDown);
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator.LineThickness = 3;
            this.bunifuSeparator.Location = new System.Drawing.Point(36, 103);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(780, 12);
            this.bunifuSeparator.TabIndex = 19;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = false;
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.Transparent;
            this.textPrice.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.Black;
            this.textPrice.Location = new System.Drawing.Point(673, 60);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(85, 40);
            this.textPrice.TabIndex = 12;
            this.textPrice.Text = "Price";
            // 
            // quantityFemale
            // 
            this.quantityFemale.AutoSize = true;
            this.quantityFemale.BackColor = System.Drawing.Color.Transparent;
            this.quantityFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityFemale.ForeColor = System.Drawing.Color.Black;
            this.quantityFemale.Location = new System.Drawing.Point(467, 132);
            this.quantityFemale.MinimumSize = new System.Drawing.Size(113, 40);
            this.quantityFemale.Name = "quantityFemale";
            this.quantityFemale.Size = new System.Drawing.Size(113, 40);
            this.quantityFemale.TabIndex = 13;
            this.quantityFemale.Text = "Female";
            this.quantityFemale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityMale
            // 
            this.quantityMale.AutoSize = true;
            this.quantityMale.BackColor = System.Drawing.Color.Transparent;
            this.quantityMale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityMale.ForeColor = System.Drawing.Color.Black;
            this.quantityMale.Location = new System.Drawing.Point(296, 132);
            this.quantityMale.MinimumSize = new System.Drawing.Size(81, 40);
            this.quantityMale.Name = "quantityMale";
            this.quantityMale.Size = new System.Drawing.Size(81, 40);
            this.quantityMale.TabIndex = 14;
            this.quantityMale.Text = "Male";
            this.quantityMale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFemale
            // 
            this.textFemale.AutoSize = true;
            this.textFemale.BackColor = System.Drawing.Color.Transparent;
            this.textFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFemale.ForeColor = System.Drawing.Color.Black;
            this.textFemale.Location = new System.Drawing.Point(467, 60);
            this.textFemale.Name = "textFemale";
            this.textFemale.Size = new System.Drawing.Size(113, 40);
            this.textFemale.TabIndex = 15;
            this.textFemale.Text = "Female";
            // 
            // nameAnimal
            // 
            this.nameAnimal.AutoSize = true;
            this.nameAnimal.BackColor = System.Drawing.Color.Transparent;
            this.nameAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAnimal.ForeColor = System.Drawing.Color.Black;
            this.nameAnimal.Location = new System.Drawing.Point(45, 132);
            this.nameAnimal.MinimumSize = new System.Drawing.Size(185, 40);
            this.nameAnimal.Name = "nameAnimal";
            this.nameAnimal.Size = new System.Drawing.Size(185, 40);
            this.nameAnimal.TabIndex = 16;
            this.nameAnimal.Text = "name Animal";
            this.nameAnimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textMale
            // 
            this.textMale.AutoSize = true;
            this.textMale.BackColor = System.Drawing.Color.Transparent;
            this.textMale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale.ForeColor = System.Drawing.Color.Black;
            this.textMale.Location = new System.Drawing.Point(296, 60);
            this.textMale.Name = "textMale";
            this.textMale.Size = new System.Drawing.Size(81, 40);
            this.textMale.TabIndex = 17;
            this.textMale.Text = "Male";
            // 
            // textAnimal
            // 
            this.textAnimal.AutoSize = true;
            this.textAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAnimal.ForeColor = System.Drawing.Color.Black;
            this.textAnimal.Location = new System.Drawing.Point(84, 60);
            this.textAnimal.Name = "textAnimal";
            this.textAnimal.Size = new System.Drawing.Size(107, 40);
            this.textAnimal.TabIndex = 18;
            this.textAnimal.Text = "Animal";
            // 
            // controlPriceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelContent);
            this.DoubleBuffered = true;
            this.Name = "controlPriceEdit";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
        private System.Windows.Forms.Label noExistAnimal;
        private System.Windows.Forms.Label textEnterAnimal;
        private System.Windows.Forms.TextBox inputSpecies;
        private Bunifu.Framework.UI.BunifuElipse bunifuRountInput;
        private System.Windows.Forms.Panel panelContent;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label quantityFemale;
        private System.Windows.Forms.Label quantityMale;
        private System.Windows.Forms.Label textFemale;
        private System.Windows.Forms.Label nameAnimal;
        private System.Windows.Forms.Label textMale;
        private System.Windows.Forms.Label textAnimal;
        private System.Windows.Forms.TextBox inputNewPrice;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditPrice;
        private System.Windows.Forms.Label succesEdit;
    }
}
