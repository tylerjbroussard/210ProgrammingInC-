namespace FormSpace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLemonCan = new System.Windows.Forms.Button();
            this.buttonOrangeCan = new System.Windows.Forms.Button();
            this.buttonRegularCan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonHalfdollar = new System.Windows.Forms.Button();
            this.ButtonQuarter = new System.Windows.Forms.Button();
            this.ButtonDime = new System.Windows.Forms.Button();
            this.ButtonNickel = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.exactChangeBox = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonServiceNotes = new System.Windows.Forms.Button();
            this.groupBoxMoney = new System.Windows.Forms.GroupBox();
            this.listViewCoinCount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEmptyRack = new System.Windows.Forms.Button();
            this.groupBoxCan = new System.Windows.Forms.GroupBox();
            this.buttonRefillRack = new System.Windows.Forms.Button();
            this.listViewFlavorCapacity = new System.Windows.Forms.ListView();
            this.columnHeaderFlavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonStockSnacks = new System.Windows.Forms.Button();
            this.listBoxSnacks = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxMoney.SuspendLayout();
            this.groupBoxCan.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(327, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(251, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLemonCan
            // 
            this.buttonLemonCan.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.buttonLemonCan.ForeColor = System.Drawing.Color.Black;
            this.buttonLemonCan.Location = new System.Drawing.Point(251, 364);
            this.buttonLemonCan.Name = "buttonLemonCan";
            this.buttonLemonCan.Size = new System.Drawing.Size(86, 36);
            this.buttonLemonCan.TabIndex = 15;
            this.buttonLemonCan.Text = "Lemon";
            this.buttonLemonCan.UseVisualStyleBackColor = true;
            this.buttonLemonCan.Click += new System.EventHandler(this.ButtonLemon_Click);
            // 
            // buttonOrangeCan
            // 
            this.buttonOrangeCan.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.buttonOrangeCan.ForeColor = System.Drawing.Color.Black;
            this.buttonOrangeCan.Location = new System.Drawing.Point(129, 364);
            this.buttonOrangeCan.Name = "buttonOrangeCan";
            this.buttonOrangeCan.Size = new System.Drawing.Size(86, 36);
            this.buttonOrangeCan.TabIndex = 14;
            this.buttonOrangeCan.Text = "Orange";
            this.buttonOrangeCan.UseVisualStyleBackColor = true;
            this.buttonOrangeCan.Click += new System.EventHandler(this.ButtonOrange_Click);
            // 
            // buttonRegularCan
            // 
            this.buttonRegularCan.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.buttonRegularCan.ForeColor = System.Drawing.Color.Black;
            this.buttonRegularCan.Location = new System.Drawing.Point(10, 364);
            this.buttonRegularCan.Name = "buttonRegularCan";
            this.buttonRegularCan.Size = new System.Drawing.Size(86, 36);
            this.buttonRegularCan.TabIndex = 13;
            this.buttonRegularCan.Text = "Regular";
            this.buttonRegularCan.UseVisualStyleBackColor = true;
            this.buttonRegularCan.Click += new System.EventHandler(this.ButtonRegular_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonHalfdollar
            // 
            this.ButtonHalfdollar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.ButtonHalfdollar.ForeColor = System.Drawing.Color.Black;
            this.ButtonHalfdollar.Location = new System.Drawing.Point(619, 270);
            this.ButtonHalfdollar.Name = "ButtonHalfdollar";
            this.ButtonHalfdollar.Size = new System.Drawing.Size(86, 36);
            this.ButtonHalfdollar.TabIndex = 20;
            this.ButtonHalfdollar.Text = "$0.50";
            this.ButtonHalfdollar.UseVisualStyleBackColor = true;
            this.ButtonHalfdollar.Click += new System.EventHandler(this.ButtonHalfdollar_Click);
            // 
            // ButtonQuarter
            // 
            this.ButtonQuarter.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.ButtonQuarter.ForeColor = System.Drawing.Color.Black;
            this.ButtonQuarter.Location = new System.Drawing.Point(513, 270);
            this.ButtonQuarter.Name = "ButtonQuarter";
            this.ButtonQuarter.Size = new System.Drawing.Size(86, 36);
            this.ButtonQuarter.TabIndex = 19;
            this.ButtonQuarter.Text = "$0.25";
            this.ButtonQuarter.UseVisualStyleBackColor = true;
            this.ButtonQuarter.Click += new System.EventHandler(this.ButtonQuarter_Click);
            // 
            // ButtonDime
            // 
            this.ButtonDime.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.ButtonDime.ForeColor = System.Drawing.Color.Black;
            this.ButtonDime.Location = new System.Drawing.Point(619, 195);
            this.ButtonDime.Name = "ButtonDime";
            this.ButtonDime.Size = new System.Drawing.Size(86, 36);
            this.ButtonDime.TabIndex = 18;
            this.ButtonDime.Text = "$0.10";
            this.ButtonDime.UseVisualStyleBackColor = true;
            this.ButtonDime.Click += new System.EventHandler(this.ButtonDime_Click);
            // 
            // ButtonNickel
            // 
            this.ButtonNickel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.ButtonNickel.ForeColor = System.Drawing.Color.Black;
            this.ButtonNickel.Location = new System.Drawing.Point(513, 195);
            this.ButtonNickel.Name = "ButtonNickel";
            this.ButtonNickel.Size = new System.Drawing.Size(86, 36);
            this.ButtonNickel.TabIndex = 17;
            this.ButtonNickel.Text = "$0.05";
            this.ButtonNickel.UseVisualStyleBackColor = true;
            this.ButtonNickel.Click += new System.EventHandler(this.ButtonNickel_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(96)))), ((int)(((byte)(51)))));
            this.changeButton.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.changeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeButton.Location = new System.Drawing.Point(513, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(192, 36);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalAmountLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.totalAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.totalAmountLabel.Location = new System.Drawing.Point(513, 71);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(3);
            this.totalAmountLabel.MaximumSize = new System.Drawing.Size(150, 50);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Padding = new System.Windows.Forms.Padding(10);
            this.totalAmountLabel.Size = new System.Drawing.Size(22, 41);
            this.totalAmountLabel.TabIndex = 23;
            // 
            // exactChangeBox
            // 
            this.exactChangeBox.AutoSize = true;
            this.exactChangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.exactChangeBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.exactChangeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.exactChangeBox.Location = new System.Drawing.Point(496, 140);
            this.exactChangeBox.Name = "exactChangeBox";
            this.exactChangeBox.Padding = new System.Windows.Forms.Padding(10);
            this.exactChangeBox.Size = new System.Drawing.Size(218, 39);
            this.exactChangeBox.TabIndex = 22;
            this.exactChangeBox.Text = "Please use exact change!!!";
            this.exactChangeBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InstructionLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.InstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.InstructionLabel.Location = new System.Drawing.Point(513, 6);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Padding = new System.Windows.Forms.Padding(10);
            this.InstructionLabel.Size = new System.Drawing.Size(22, 41);
            this.InstructionLabel.TabIndex = 21;
            // 
            // mainTabControl
            // 
            this.mainTabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(5, 5);
            this.mainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(827, 500);
            this.mainTabControl.TabIndex = 24;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainTabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.totalAmountLabel);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.exactChangeBox);
            this.tabPage1.Controls.Add(this.buttonRegularCan);
            this.tabPage1.Controls.Add(this.InstructionLabel);
            this.tabPage1.Controls.Add(this.buttonOrangeCan);
            this.tabPage1.Controls.Add(this.ButtonHalfdollar);
            this.tabPage1.Controls.Add(this.buttonLemonCan);
            this.tabPage1.Controls.Add(this.ButtonQuarter);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.ButtonDime);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.ButtonNickel);
            this.tabPage1.Controls.Add(this.changeButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vend";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.buttonServiceNotes);
            this.tabPage2.Controls.Add(this.groupBoxMoney);
            this.tabPage2.Controls.Add(this.groupBoxCan);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service";
            // 
            // buttonServiceNotes
            // 
            this.buttonServiceNotes.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonServiceNotes.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonServiceNotes.Location = new System.Drawing.Point(678, 28);
            this.buttonServiceNotes.Name = "buttonServiceNotes";
            this.buttonServiceNotes.Size = new System.Drawing.Size(98, 81);
            this.buttonServiceNotes.TabIndex = 7;
            this.buttonServiceNotes.Text = "Service Notes";
            this.buttonServiceNotes.UseVisualStyleBackColor = false;
            this.buttonServiceNotes.Click += new System.EventHandler(this.ButtonServiceNotes_Click);
            // 
            // groupBoxMoney
            // 
            this.groupBoxMoney.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMoney.Controls.Add(this.listViewCoinCount);
            this.groupBoxMoney.Controls.Add(this.buttonEmptyRack);
            this.groupBoxMoney.Location = new System.Drawing.Point(8, 212);
            this.groupBoxMoney.Name = "groupBoxMoney";
            this.groupBoxMoney.Size = new System.Drawing.Size(628, 252);
            this.groupBoxMoney.TabIndex = 6;
            this.groupBoxMoney.TabStop = false;
            this.groupBoxMoney.Text = "Money Box";
            // 
            // listViewCoinCount
            // 
            this.listViewCoinCount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCoinCount.LabelWrap = false;
            this.listViewCoinCount.Location = new System.Drawing.Point(21, 26);
            this.listViewCoinCount.Name = "listViewCoinCount";
            this.listViewCoinCount.Size = new System.Drawing.Size(257, 164);
            this.listViewCoinCount.TabIndex = 4;
            this.listViewCoinCount.UseCompatibleStateImageBehavior = false;
            this.listViewCoinCount.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coin";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 77;
            // 
            // buttonEmptyRack
            // 
            this.buttonEmptyRack.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEmptyRack.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonEmptyRack.Location = new System.Drawing.Point(476, 26);
            this.buttonEmptyRack.Name = "buttonEmptyRack";
            this.buttonEmptyRack.Size = new System.Drawing.Size(98, 77);
            this.buttonEmptyRack.TabIndex = 2;
            this.buttonEmptyRack.Text = "Empty Coinbox";
            this.buttonEmptyRack.UseVisualStyleBackColor = false;
            this.buttonEmptyRack.Click += new System.EventHandler(this.ButtonEmptyCoinBox_Click);
            // 
            // groupBoxCan
            // 
            this.groupBoxCan.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCan.Controls.Add(this.buttonRefillRack);
            this.groupBoxCan.Controls.Add(this.listViewFlavorCapacity);
            this.groupBoxCan.Location = new System.Drawing.Point(8, 6);
            this.groupBoxCan.Name = "groupBoxCan";
            this.groupBoxCan.Size = new System.Drawing.Size(628, 202);
            this.groupBoxCan.TabIndex = 5;
            this.groupBoxCan.TabStop = false;
            this.groupBoxCan.Text = "Can Box";
            // 
            // buttonRefillRack
            // 
            this.buttonRefillRack.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRefillRack.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonRefillRack.Location = new System.Drawing.Point(476, 22);
            this.buttonRefillRack.Name = "buttonRefillRack";
            this.buttonRefillRack.Size = new System.Drawing.Size(98, 81);
            this.buttonRefillRack.TabIndex = 0;
            this.buttonRefillRack.Text = "Refill Can Rack";
            this.buttonRefillRack.UseVisualStyleBackColor = false;
            this.buttonRefillRack.Click += new System.EventHandler(this.ButtonRefillRack_Click);
            // 
            // listViewFlavorCapacity
            // 
            this.listViewFlavorCapacity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlavor,
            this.columnHeaderCapacity});
            this.listViewFlavorCapacity.LabelWrap = false;
            this.listViewFlavorCapacity.Location = new System.Drawing.Point(21, 22);
            this.listViewFlavorCapacity.Name = "listViewFlavorCapacity";
            this.listViewFlavorCapacity.Size = new System.Drawing.Size(180, 164);
            this.listViewFlavorCapacity.TabIndex = 1;
            this.listViewFlavorCapacity.UseCompatibleStateImageBehavior = false;
            this.listViewFlavorCapacity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFlavor
            // 
            this.columnHeaderFlavor.Text = "Flavor";
            this.columnHeaderFlavor.Width = 87;
            // 
            // columnHeaderCapacity
            // 
            this.columnHeaderCapacity.Text = "Capacity";
            this.columnHeaderCapacity.Width = 89;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.buttonStockSnacks);
            this.tabPage3.Controls.Add(this.listBoxSnacks);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(819, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Snacks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 289);
            this.textBox1.TabIndex = 2;
            // 
            // buttonStockSnacks
            // 
            this.buttonStockSnacks.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonStockSnacks.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonStockSnacks.Location = new System.Drawing.Point(22, 340);
            this.buttonStockSnacks.Name = "buttonStockSnacks";
            this.buttonStockSnacks.Size = new System.Drawing.Size(216, 81);
            this.buttonStockSnacks.TabIndex = 1;
            this.buttonStockSnacks.Text = "Stock Machine with Snacks";
            this.buttonStockSnacks.UseVisualStyleBackColor = false;
            this.buttonStockSnacks.Click += new System.EventHandler(this.ButtonStockSnacks_Click);
            // 
            // listBoxSnacks
            // 
            this.listBoxSnacks.FormattingEnabled = true;
            this.listBoxSnacks.ItemHeight = 19;
            this.listBoxSnacks.Location = new System.Drawing.Point(22, 21);
            this.listBoxSnacks.Name = "listBoxSnacks";
            this.listBoxSnacks.Size = new System.Drawing.Size(216, 289);
            this.listBoxSnacks.TabIndex = 0;
            this.listBoxSnacks.SelectedIndexChanged += new System.EventHandler(this.ListBoxSnacks_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(827, 500);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Soda Dispenser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxMoney.ResumeLayout(false);
            this.groupBoxCan.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLemonCan;
        private System.Windows.Forms.Button buttonOrangeCan;
        private System.Windows.Forms.Button buttonRegularCan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ButtonHalfdollar;
        private System.Windows.Forms.Button ButtonQuarter;
        private System.Windows.Forms.Button ButtonDime;
        private System.Windows.Forms.Button ButtonNickel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label exactChangeBox;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonRefillRack;
        private System.Windows.Forms.ListView listViewFlavorCapacity;
        private System.Windows.Forms.Button buttonEmptyRack;
        private System.Windows.Forms.ColumnHeader columnHeaderFlavor;
        private System.Windows.Forms.ColumnHeader columnHeaderCapacity;
        private System.Windows.Forms.ListView listViewCoinCount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBoxMoney;
        private System.Windows.Forms.GroupBox groupBoxCan;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonServiceNotes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStockSnacks;
        private System.Windows.Forms.ListBox listBoxSnacks;
    }
}

