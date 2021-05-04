namespace laboratorio11
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
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBluejam = new System.Windows.Forms.CheckBox();
            this.chkButter = new System.Windows.Forms.CheckBox();
            this.chkStrawjam = new System.Windows.Forms.CheckBox();
            this.chkCreamCheese = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radWheatBagel = new System.Windows.Forms.RadioButton();
            this.radWhiteBagel = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.msjTotal = new System.Windows.Forms.Label();
            this.msjTax = new System.Windows.Forms.Label();
            this.msjSubt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radCappuccino = new System.Windows.Forms.RadioButton();
            this.radRegularCoffe = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(365, 384);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(24, 13);
            this.linkExit.TabIndex = 2;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(263, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(345, 340);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(22, 27);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(22, 56);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBluejam);
            this.groupBox1.Controls.Add(this.chkButter);
            this.groupBox1.Controls.Add(this.chkStrawjam);
            this.groupBox1.Controls.Add(this.chkCreamCheese);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick your topping";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkBluejam
            // 
            this.chkBluejam.AutoSize = true;
            this.chkBluejam.Location = new System.Drawing.Point(26, 60);
            this.chkBluejam.Name = "chkBluejam";
            this.chkBluejam.Size = new System.Drawing.Size(122, 17);
            this.chkBluejam.TabIndex = 5;
            this.chkBluejam.Text = "Blueberry jam($0.75)";
            this.chkBluejam.UseVisualStyleBackColor = true;
            // 
            // chkButter
            // 
            this.chkButter.AutoSize = true;
            this.chkButter.Location = new System.Drawing.Point(26, 83);
            this.chkButter.Name = "chkButter";
            this.chkButter.Size = new System.Drawing.Size(87, 17);
            this.chkButter.TabIndex = 6;
            this.chkButter.Text = "Butter($0.50)";
            this.chkButter.UseVisualStyleBackColor = true;
            // 
            // chkStrawjam
            // 
            this.chkStrawjam.AutoSize = true;
            this.chkStrawjam.Location = new System.Drawing.Point(26, 42);
            this.chkStrawjam.Name = "chkStrawjam";
            this.chkStrawjam.Size = new System.Drawing.Size(128, 17);
            this.chkStrawjam.TabIndex = 1;
            this.chkStrawjam.Text = "Strawberry jam($0.75)";
            this.chkStrawjam.UseVisualStyleBackColor = true;
            // 
            // chkCreamCheese
            // 
            this.chkCreamCheese.AutoSize = true;
            this.chkCreamCheese.Location = new System.Drawing.Point(26, 19);
            this.chkCreamCheese.Name = "chkCreamCheese";
            this.chkCreamCheese.Size = new System.Drawing.Size(128, 17);
            this.chkCreamCheese.TabIndex = 0;
            this.chkCreamCheese.Text = "Cream Cheese($0.50)";
            this.chkCreamCheese.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radWheatBagel);
            this.groupBox2.Controls.Add(this.radWhiteBagel);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick a Bagel";
            // 
            // radWheatBagel
            // 
            this.radWheatBagel.AutoSize = true;
            this.radWheatBagel.Location = new System.Drawing.Point(30, 54);
            this.radWheatBagel.Name = "radWheatBagel";
            this.radWheatBagel.Size = new System.Drawing.Size(124, 17);
            this.radWheatBagel.TabIndex = 1;
            this.radWheatBagel.TabStop = true;
            this.radWheatBagel.Text = "Whole Wheat($1.50)";
            this.radWheatBagel.UseVisualStyleBackColor = true;
            // 
            // radWhiteBagel
            // 
            this.radWhiteBagel.AutoSize = true;
            this.radWhiteBagel.Location = new System.Drawing.Point(30, 20);
            this.radWhiteBagel.Name = "radWhiteBagel";
            this.radWhiteBagel.Size = new System.Drawing.Size(86, 17);
            this.radWhiteBagel.TabIndex = 0;
            this.radWhiteBagel.TabStop = true;
            this.radWhiteBagel.Text = "White($1.25)";
            this.radWhiteBagel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msjTotal);
            this.groupBox3.Controls.Add(this.msjTax);
            this.groupBox3.Controls.Add(this.msjSubt);
            this.groupBox3.Controls.Add(this.lblSubtotal);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Location = new System.Drawing.Point(235, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 125);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // msjTotal
            // 
            this.msjTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msjTotal.Location = new System.Drawing.Point(85, 83);
            this.msjTotal.Name = "msjTotal";
            this.msjTotal.Size = new System.Drawing.Size(100, 23);
            this.msjTotal.TabIndex = 14;
            // 
            // msjTax
            // 
            this.msjTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msjTax.Location = new System.Drawing.Point(85, 54);
            this.msjTax.Name = "msjTax";
            this.msjTax.Size = new System.Drawing.Size(100, 23);
            this.msjTax.TabIndex = 13;
            // 
            // msjSubt
            // 
            this.msjSubt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msjSubt.Location = new System.Drawing.Point(85, 19);
            this.msjSubt.Name = "msjSubt";
            this.msjSubt.Size = new System.Drawing.Size(100, 23);
            this.msjSubt.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radCappuccino);
            this.groupBox4.Controls.Add(this.radRegularCoffe);
            this.groupBox4.Controls.Add(this.radNone);
            this.groupBox4.Location = new System.Drawing.Point(235, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Want coffe with that?";
            // 
            // radCappuccino
            // 
            this.radCappuccino.AutoSize = true;
            this.radCappuccino.Location = new System.Drawing.Point(25, 68);
            this.radCappuccino.Name = "radCappuccino";
            this.radCappuccino.Size = new System.Drawing.Size(115, 17);
            this.radCappuccino.TabIndex = 2;
            this.radCappuccino.TabStop = true;
            this.radCappuccino.Text = "Cappuccino($2.00)";
            this.radCappuccino.UseVisualStyleBackColor = true;
            // 
            // radRegularCoffe
            // 
            this.radRegularCoffe.AutoSize = true;
            this.radRegularCoffe.Location = new System.Drawing.Point(25, 44);
            this.radRegularCoffe.Name = "radRegularCoffe";
            this.radRegularCoffe.Size = new System.Drawing.Size(123, 17);
            this.radRegularCoffe.TabIndex = 1;
            this.radRegularCoffe.TabStop = true;
            this.radRegularCoffe.Text = "Regular Coffe($1.25)";
            this.radRegularCoffe.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Location = new System.Drawing.Point(25, 20);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(51, 17);
            this.radNone.TabIndex = 0;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 406);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.linkExit);
            this.Name = "Form1";
            this.Text = "Bagel and Coffe Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBluejam;
        private System.Windows.Forms.CheckBox chkButter;
        private System.Windows.Forms.CheckBox chkStrawjam;
        private System.Windows.Forms.CheckBox chkCreamCheese;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radWheatBagel;
        private System.Windows.Forms.RadioButton radWhiteBagel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label msjTotal;
        private System.Windows.Forms.Label msjTax;
        private System.Windows.Forms.Label msjSubt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radCappuccino;
        private System.Windows.Forms.RadioButton radRegularCoffe;
        private System.Windows.Forms.RadioButton radNone;
    }
}

