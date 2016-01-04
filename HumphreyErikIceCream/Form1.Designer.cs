namespace HumphreyErikIceCream
{
    partial class frmIceCreamParlour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIceCreamParlour));
            this.cboContainer = new System.Windows.Forms.ComboBox();
            this.lblTitleContainer = new System.Windows.Forms.Label();
            this.lstSelectFlavour = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grpServingSize = new System.Windows.Forms.GroupBox();
            this.picSampleSpoon = new System.Windows.Forms.PictureBox();
            this.radSizeLarge = new System.Windows.Forms.RadioButton();
            this.radSizeMedium = new System.Windows.Forms.RadioButton();
            this.radSizeSmall = new System.Windows.Forms.RadioButton();
            this.radSizeSample = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkBlackberries = new System.Windows.Forms.CheckBox();
            this.chkCandyHearts = new System.Windows.Forms.CheckBox();
            this.chkCherries = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.chkPeanuts = new System.Windows.Forms.CheckBox();
            this.picTopCandyHearts = new System.Windows.Forms.PictureBox();
            this.picTopChocolateSauce = new System.Windows.Forms.PictureBox();
            this.picTopSprinkles = new System.Windows.Forms.PictureBox();
            this.picTopBlackberries = new System.Windows.Forms.PictureBox();
            this.picTopPeanuts = new System.Windows.Forms.PictureBox();
            this.picTopCherries = new System.Windows.Forms.PictureBox();
            this.picParlourTitle = new System.Windows.Forms.PictureBox();
            this.lblTitleFlavour = new System.Windows.Forms.Label();
            this.lblNoToppings = new System.Windows.Forms.Label();
            this.grpServingSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSampleSpoon)).BeginInit();
            this.grpToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopCandyHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopChocolateSauce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopSprinkles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBlackberries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPeanuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopCherries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParlourTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // cboContainer
            // 
            this.cboContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboContainer.FormattingEnabled = true;
            this.cboContainer.Items.AddRange(new object[] {
            "Glass bowl",
            "Paper cup",
            "Sundae glass",
            "Waffle bowl",
            "Waffle cone"});
            this.cboContainer.Location = new System.Drawing.Point(18, 135);
            this.cboContainer.Name = "cboContainer";
            this.cboContainer.Size = new System.Drawing.Size(121, 21);
            this.cboContainer.Sorted = true;
            this.cboContainer.TabIndex = 1;
            this.cboContainer.TabStop = false;
            this.cboContainer.Text = "Select a container";
            // 
            // lblTitleContainer
            // 
            this.lblTitleContainer.AutoSize = true;
            this.lblTitleContainer.Location = new System.Drawing.Point(18, 116);
            this.lblTitleContainer.Name = "lblTitleContainer";
            this.lblTitleContainer.Size = new System.Drawing.Size(52, 13);
            this.lblTitleContainer.TabIndex = 2;
            this.lblTitleContainer.Text = "Container";
            // 
            // lstSelectFlavour
            // 
            this.lstSelectFlavour.FormattingEnabled = true;
            this.lstSelectFlavour.Location = new System.Drawing.Point(282, 114);
            this.lstSelectFlavour.Name = "lstSelectFlavour";
            this.lstSelectFlavour.Size = new System.Drawing.Size(193, 147);
            this.lstSelectFlavour.TabIndex = 3;
            this.lstSelectFlavour.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(326, 331);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(115, 34);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // grpServingSize
            // 
            this.grpServingSize.Controls.Add(this.cboContainer);
            this.grpServingSize.Controls.Add(this.picSampleSpoon);
            this.grpServingSize.Controls.Add(this.radSizeLarge);
            this.grpServingSize.Controls.Add(this.radSizeMedium);
            this.grpServingSize.Controls.Add(this.radSizeSmall);
            this.grpServingSize.Controls.Add(this.radSizeSample);
            this.grpServingSize.Controls.Add(this.lblTitleContainer);
            this.grpServingSize.Location = new System.Drawing.Point(26, 95);
            this.grpServingSize.Name = "grpServingSize";
            this.grpServingSize.Size = new System.Drawing.Size(180, 172);
            this.grpServingSize.TabIndex = 6;
            this.grpServingSize.TabStop = false;
            this.grpServingSize.Text = "Size";
            // 
            // picSampleSpoon
            // 
            this.picSampleSpoon.BackColor = System.Drawing.Color.Transparent;
            this.picSampleSpoon.Image = global::HumphreyErikIceCream.Properties.Resources.imgSpoonIcon;
            this.picSampleSpoon.Location = new System.Drawing.Point(21, 132);
            this.picSampleSpoon.Name = "picSampleSpoon";
            this.picSampleSpoon.Size = new System.Drawing.Size(93, 34);
            this.picSampleSpoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSampleSpoon.TabIndex = 9;
            this.picSampleSpoon.TabStop = false;
            this.picSampleSpoon.Visible = false;
            // 
            // radSizeLarge
            // 
            this.radSizeLarge.AutoSize = true;
            this.radSizeLarge.Location = new System.Drawing.Point(21, 87);
            this.radSizeLarge.Name = "radSizeLarge";
            this.radSizeLarge.Size = new System.Drawing.Size(52, 17);
            this.radSizeLarge.TabIndex = 4;
            this.radSizeLarge.Text = "Large";
            this.radSizeLarge.UseVisualStyleBackColor = true;
            this.radSizeLarge.CheckedChanged += new System.EventHandler(this.radSizeSample_Unchecked);
            // 
            // radSizeMedium
            // 
            this.radSizeMedium.AutoSize = true;
            this.radSizeMedium.Location = new System.Drawing.Point(21, 64);
            this.radSizeMedium.Name = "radSizeMedium";
            this.radSizeMedium.Size = new System.Drawing.Size(62, 17);
            this.radSizeMedium.TabIndex = 2;
            this.radSizeMedium.Text = "Medium";
            this.radSizeMedium.UseVisualStyleBackColor = true;
            this.radSizeMedium.CheckedChanged += new System.EventHandler(this.radSizeSample_Unchecked);
            // 
            // radSizeSmall
            // 
            this.radSizeSmall.AutoSize = true;
            this.radSizeSmall.Location = new System.Drawing.Point(21, 41);
            this.radSizeSmall.Name = "radSizeSmall";
            this.radSizeSmall.Size = new System.Drawing.Size(50, 17);
            this.radSizeSmall.TabIndex = 1;
            this.radSizeSmall.Text = "Small";
            this.radSizeSmall.UseVisualStyleBackColor = true;
            this.radSizeSmall.CheckedChanged += new System.EventHandler(this.radSizeSample_Unchecked);
            // 
            // radSizeSample
            // 
            this.radSizeSample.AutoSize = true;
            this.radSizeSample.Location = new System.Drawing.Point(21, 19);
            this.radSizeSample.Name = "radSizeSample";
            this.radSizeSample.Size = new System.Drawing.Size(60, 17);
            this.radSizeSample.TabIndex = 0;
            this.radSizeSample.Text = "Sample";
            this.radSizeSample.UseVisualStyleBackColor = true;
            this.radSizeSample.CheckedChanged += new System.EventHandler(this.radSizeSample_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkBlackberries);
            this.grpToppings.Controls.Add(this.chkCandyHearts);
            this.grpToppings.Controls.Add(this.chkCherries);
            this.grpToppings.Controls.Add(this.chkSprinkles);
            this.grpToppings.Controls.Add(this.chkChocolate);
            this.grpToppings.Controls.Add(this.chkPeanuts);
            this.grpToppings.Controls.Add(this.picTopCandyHearts);
            this.grpToppings.Controls.Add(this.picTopChocolateSauce);
            this.grpToppings.Controls.Add(this.picTopSprinkles);
            this.grpToppings.Controls.Add(this.picTopBlackberries);
            this.grpToppings.Controls.Add(this.picTopPeanuts);
            this.grpToppings.Controls.Add(this.picTopCherries);
            this.grpToppings.Location = new System.Drawing.Point(26, 273);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(249, 174);
            this.grpToppings.TabIndex = 7;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkBlackberries
            // 
            this.chkBlackberries.AutoSize = true;
            this.chkBlackberries.Location = new System.Drawing.Point(157, 70);
            this.chkBlackberries.Name = "chkBlackberries";
            this.chkBlackberries.Size = new System.Drawing.Size(84, 17);
            this.chkBlackberries.TabIndex = 13;
            this.chkBlackberries.TabStop = false;
            this.chkBlackberries.Text = "Blackberries";
            this.chkBlackberries.UseVisualStyleBackColor = true;
            // 
            // chkCandyHearts
            // 
            this.chkCandyHearts.AutoSize = true;
            this.chkCandyHearts.Location = new System.Drawing.Point(158, 142);
            this.chkCandyHearts.Name = "chkCandyHearts";
            this.chkCandyHearts.Size = new System.Drawing.Size(88, 17);
            this.chkCandyHearts.TabIndex = 12;
            this.chkCandyHearts.TabStop = false;
            this.chkCandyHearts.Text = "Candy hearts";
            this.chkCandyHearts.UseVisualStyleBackColor = true;
            // 
            // chkCherries
            // 
            this.chkCherries.AutoSize = true;
            this.chkCherries.Location = new System.Drawing.Point(86, 142);
            this.chkCherries.Name = "chkCherries";
            this.chkCherries.Size = new System.Drawing.Size(64, 17);
            this.chkCherries.TabIndex = 11;
            this.chkCherries.TabStop = false;
            this.chkCherries.Text = "Cherries";
            this.chkCherries.UseVisualStyleBackColor = true;
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(16, 142);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(69, 17);
            this.chkSprinkles.TabIndex = 9;
            this.chkSprinkles.TabStop = false;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Location = new System.Drawing.Point(84, 70);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(74, 17);
            this.chkChocolate.TabIndex = 8;
            this.chkChocolate.TabStop = false;
            this.chkChocolate.Text = "Chocolate";
            this.chkChocolate.UseVisualStyleBackColor = true;
            // 
            // chkPeanuts
            // 
            this.chkPeanuts.AutoSize = true;
            this.chkPeanuts.Location = new System.Drawing.Point(16, 70);
            this.chkPeanuts.Name = "chkPeanuts";
            this.chkPeanuts.Size = new System.Drawing.Size(65, 17);
            this.chkPeanuts.TabIndex = 0;
            this.chkPeanuts.TabStop = false;
            this.chkPeanuts.Text = "Peanuts";
            this.chkPeanuts.UseVisualStyleBackColor = true;
            // 
            // picTopCandyHearts
            // 
            this.picTopCandyHearts.Image = global::HumphreyErikIceCream.Properties.Resources.imgTopCandyHearts;
            this.picTopCandyHearts.Location = new System.Drawing.Point(158, 93);
            this.picTopCandyHearts.Name = "picTopCandyHearts";
            this.picTopCandyHearts.Size = new System.Drawing.Size(65, 43);
            this.picTopCandyHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopCandyHearts.TabIndex = 7;
            this.picTopCandyHearts.TabStop = false;
            // 
            // picTopChocolateSauce
            // 
            this.picTopChocolateSauce.Image = global::HumphreyErikIceCream.Properties.Resources.imgTopChocolateSauce;
            this.picTopChocolateSauce.Location = new System.Drawing.Point(86, 21);
            this.picTopChocolateSauce.Name = "picTopChocolateSauce";
            this.picTopChocolateSauce.Size = new System.Drawing.Size(65, 43);
            this.picTopChocolateSauce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopChocolateSauce.TabIndex = 5;
            this.picTopChocolateSauce.TabStop = false;
            // 
            // picTopSprinkles
            // 
            this.picTopSprinkles.Image = global::HumphreyErikIceCream.Properties.Resources.imgTopSprinkles1;
            this.picTopSprinkles.Location = new System.Drawing.Point(16, 93);
            this.picTopSprinkles.Name = "picTopSprinkles";
            this.picTopSprinkles.Size = new System.Drawing.Size(65, 43);
            this.picTopSprinkles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopSprinkles.TabIndex = 2;
            this.picTopSprinkles.TabStop = false;
            // 
            // picTopBlackberries
            // 
            this.picTopBlackberries.Image = global::HumphreyErikIceCream.Properties.Resources.imgTopBlackberries;
            this.picTopBlackberries.Location = new System.Drawing.Point(157, 21);
            this.picTopBlackberries.Name = "picTopBlackberries";
            this.picTopBlackberries.Size = new System.Drawing.Size(65, 43);
            this.picTopBlackberries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopBlackberries.TabIndex = 6;
            this.picTopBlackberries.TabStop = false;
            // 
            // picTopPeanuts
            // 
            this.picTopPeanuts.BackColor = System.Drawing.Color.Transparent;
            this.picTopPeanuts.Image = global::HumphreyErikIceCream.Properties.Resources.imgTopPeanuts;
            this.picTopPeanuts.Location = new System.Drawing.Point(16, 21);
            this.picTopPeanuts.Name = "picTopPeanuts";
            this.picTopPeanuts.Size = new System.Drawing.Size(65, 43);
            this.picTopPeanuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopPeanuts.TabIndex = 1;
            this.picTopPeanuts.TabStop = false;
            // 
            // picTopCherries
            // 
            this.picTopCherries.Image = global::HumphreyErikIceCream.Properties.Resources.imgTopCherries;
            this.picTopCherries.Location = new System.Drawing.Point(87, 93);
            this.picTopCherries.Name = "picTopCherries";
            this.picTopCherries.Size = new System.Drawing.Size(65, 43);
            this.picTopCherries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopCherries.TabIndex = 3;
            this.picTopCherries.TabStop = false;
            // 
            // picParlourTitle
            // 
            this.picParlourTitle.BackColor = System.Drawing.Color.Transparent;
            this.picParlourTitle.Image = global::HumphreyErikIceCream.Properties.Resources.imgICPTitleCanadianSpelling;
            this.picParlourTitle.Location = new System.Drawing.Point(26, 12);
            this.picParlourTitle.Name = "picParlourTitle";
            this.picParlourTitle.Size = new System.Drawing.Size(450, 61);
            this.picParlourTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picParlourTitle.TabIndex = 8;
            this.picParlourTitle.TabStop = false;
            // 
            // lblTitleFlavour
            // 
            this.lblTitleFlavour.AutoSize = true;
            this.lblTitleFlavour.Location = new System.Drawing.Point(279, 98);
            this.lblTitleFlavour.Name = "lblTitleFlavour";
            this.lblTitleFlavour.Size = new System.Drawing.Size(42, 13);
            this.lblTitleFlavour.TabIndex = 4;
            this.lblTitleFlavour.Text = "Flavour";
            // 
            // lblNoToppings
            // 
            this.lblNoToppings.AutoSize = true;
            this.lblNoToppings.Location = new System.Drawing.Point(344, 294);
            this.lblNoToppings.Name = "lblNoToppings";
            this.lblNoToppings.Size = new System.Drawing.Size(0, 13);
            this.lblNoToppings.TabIndex = 9;
            this.lblNoToppings.Visible = false;
            // 
            // frmIceCreamParlour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.lblNoToppings);
            this.Controls.Add(this.picParlourTitle);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpServingSize);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTitleFlavour);
            this.Controls.Add(this.lstSelectFlavour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIceCreamParlour";
            this.Text = "Erik Humphrey\'s Ice Cream Parlour";
            this.Load += new System.EventHandler(this.frmIceCreamParlour_Load);
            this.grpServingSize.ResumeLayout(false);
            this.grpServingSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSampleSpoon)).EndInit();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopCandyHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopChocolateSauce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopSprinkles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBlackberries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPeanuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopCherries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParlourTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboContainer;
        private System.Windows.Forms.Label lblTitleContainer;
        private System.Windows.Forms.ListBox lstSelectFlavour;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox grpServingSize;
        private System.Windows.Forms.RadioButton radSizeSample;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.PictureBox picParlourTitle;
        private System.Windows.Forms.RadioButton radSizeLarge;
        private System.Windows.Forms.RadioButton radSizeMedium;
        private System.Windows.Forms.RadioButton radSizeSmall;
        private System.Windows.Forms.CheckBox chkPeanuts;
        private System.Windows.Forms.PictureBox picTopPeanuts;
        private System.Windows.Forms.PictureBox picTopSprinkles;
        private System.Windows.Forms.PictureBox picTopChocolateSauce;
        private System.Windows.Forms.PictureBox picTopCherries;
        private System.Windows.Forms.PictureBox picTopCandyHearts;
        private System.Windows.Forms.PictureBox picTopBlackberries;
        private System.Windows.Forms.CheckBox chkBlackberries;
        private System.Windows.Forms.CheckBox chkCandyHearts;
        private System.Windows.Forms.CheckBox chkCherries;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.PictureBox picSampleSpoon;
        private System.Windows.Forms.Label lblTitleFlavour;
        private System.Windows.Forms.Label lblNoToppings;
    }
}

