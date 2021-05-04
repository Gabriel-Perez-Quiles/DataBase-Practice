namespace laboratorio12
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpFrituras = new System.Windows.Forms.GroupBox();
            this.radSorrudog = new System.Windows.Forms.RadioButton();
            this.radPastelillos = new System.Windows.Forms.RadioButton();
            this.radpizza = new System.Windows.Forms.RadioButton();
            this.radAlcapurria = new System.Windows.Forms.RadioButton();
            this.radSorrullo = new System.Windows.Forms.RadioButton();
            this.grpVebidas = new System.Windows.Forms.GroupBox();
            this.radChina = new System.Windows.Forms.RadioButton();
            this.radCafe = new System.Windows.Forms.RadioButton();
            this.radTe = new System.Windows.Forms.RadioButton();
            this.radCoca = new System.Windows.Forms.RadioButton();
            this.radPepsi = new System.Windows.Forms.RadioButton();
            this.radCocoRico = new System.Windows.Forms.RadioButton();
            this.radTropical = new System.Windows.Forms.RadioButton();
            this.radSprite = new System.Windows.Forms.RadioButton();
            this.linkSalir = new System.Windows.Forms.LinkLabel();
            this.Subtotal = new System.Windows.Forms.Label();
            this.grpSalsaAderezo = new System.Windows.Forms.GroupBox();
            this.chkHoneyM = new System.Windows.Forms.CheckBox();
            this.chkSpicyPig = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkRanch = new System.Windows.Forms.CheckBox();
            this.chkMayoK = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.msjTotal = new System.Windows.Forms.Label();
            this.msjTax = new System.Windows.Forms.Label();
            this.msjSub = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.btnResetiar = new System.Windows.Forms.Button();
            this.grpFrituras.SuspendLayout();
            this.grpVebidas.SuspendLayout();
            this.grpSalsaAderezo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(269, 254);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpFrituras
            // 
            this.grpFrituras.Controls.Add(this.radSorrudog);
            this.grpFrituras.Controls.Add(this.radPastelillos);
            this.grpFrituras.Controls.Add(this.radpizza);
            this.grpFrituras.Controls.Add(this.radAlcapurria);
            this.grpFrituras.Controls.Add(this.radSorrullo);
            this.grpFrituras.Location = new System.Drawing.Point(12, 12);
            this.grpFrituras.Name = "grpFrituras";
            this.grpFrituras.Size = new System.Drawing.Size(225, 117);
            this.grpFrituras.TabIndex = 1;
            this.grpFrituras.TabStop = false;
            this.grpFrituras.Text = "Frituras";
            // 
            // radSorrudog
            // 
            this.radSorrudog.AutoSize = true;
            this.radSorrudog.Location = new System.Drawing.Point(108, 42);
            this.radSorrudog.Name = "radSorrudog";
            this.radSorrudog.Size = new System.Drawing.Size(119, 17);
            this.radSorrudog.TabIndex = 8;
            this.radSorrudog.TabStop = true;
            this.radSorrudog.Text = "Sorrullo dogs($1.00)";
            this.radSorrudog.UseVisualStyleBackColor = true;
            // 
            // radPastelillos
            // 
            this.radPastelillos.AutoSize = true;
            this.radPastelillos.Location = new System.Drawing.Point(108, 19);
            this.radPastelillos.Name = "radPastelillos";
            this.radPastelillos.Size = new System.Drawing.Size(95, 17);
            this.radPastelillos.TabIndex = 3;
            this.radPastelillos.TabStop = true;
            this.radPastelillos.Text = "Pastelillos($85)";
            this.radPastelillos.UseVisualStyleBackColor = true;
            // 
            // radpizza
            // 
            this.radpizza.AutoSize = true;
            this.radpizza.Location = new System.Drawing.Point(59, 65);
            this.radpizza.Name = "radpizza";
            this.radpizza.Size = new System.Drawing.Size(109, 30);
            this.radpizza.TabIndex = 2;
            this.radpizza.TabStop = true;
            this.radpizza.Text = "Empanadilla pizza\r\n         ($1.00)";
            this.radpizza.UseVisualStyleBackColor = true;
            // 
            // radAlcapurria
            // 
            this.radAlcapurria.AutoSize = true;
            this.radAlcapurria.Location = new System.Drawing.Point(7, 43);
            this.radAlcapurria.Name = "radAlcapurria";
            this.radAlcapurria.Size = new System.Drawing.Size(105, 17);
            this.radAlcapurria.TabIndex = 1;
            this.radAlcapurria.TabStop = true;
            this.radAlcapurria.Text = "Alcapurria($1.50)";
            this.radAlcapurria.UseVisualStyleBackColor = true;
            // 
            // radSorrullo
            // 
            this.radSorrullo.AutoSize = true;
            this.radSorrullo.Location = new System.Drawing.Point(7, 20);
            this.radSorrullo.Name = "radSorrullo";
            this.radSorrullo.Size = new System.Drawing.Size(93, 17);
            this.radSorrullo.TabIndex = 0;
            this.radSorrullo.TabStop = true;
            this.radSorrullo.Text = "Sorrullo($1.00)";
            this.radSorrullo.UseVisualStyleBackColor = true;
            // 
            // grpVebidas
            // 
            this.grpVebidas.Controls.Add(this.radChina);
            this.grpVebidas.Controls.Add(this.radCafe);
            this.grpVebidas.Controls.Add(this.radTe);
            this.grpVebidas.Controls.Add(this.radCoca);
            this.grpVebidas.Controls.Add(this.radPepsi);
            this.grpVebidas.Controls.Add(this.radCocoRico);
            this.grpVebidas.Controls.Add(this.radTropical);
            this.grpVebidas.Controls.Add(this.radSprite);
            this.grpVebidas.Location = new System.Drawing.Point(254, 12);
            this.grpVebidas.Name = "grpVebidas";
            this.grpVebidas.Size = new System.Drawing.Size(248, 117);
            this.grpVebidas.TabIndex = 2;
            this.grpVebidas.TabStop = false;
            this.grpVebidas.Text = "Vevidas ";
            // 
            // radChina
            // 
            this.radChina.AutoSize = true;
            this.radChina.Location = new System.Drawing.Point(118, 42);
            this.radChina.Name = "radChina";
            this.radChina.Size = new System.Drawing.Size(111, 17);
            this.radChina.TabIndex = 8;
            this.radChina.TabStop = true;
            this.radChina.Text = "Jugo China($1.25)";
            this.radChina.UseVisualStyleBackColor = true;
            // 
            // radCafe
            // 
            this.radCafe.AutoSize = true;
            this.radCafe.Location = new System.Drawing.Point(118, 65);
            this.radCafe.Name = "radCafe";
            this.radCafe.Size = new System.Drawing.Size(80, 17);
            this.radCafe.TabIndex = 9;
            this.radCafe.TabStop = true;
            this.radCafe.Text = "Cafe($0.50)";
            this.radCafe.UseVisualStyleBackColor = true;
            // 
            // radTe
            // 
            this.radTe.AutoSize = true;
            this.radTe.Location = new System.Drawing.Point(118, 88);
            this.radTe.Name = "radTe";
            this.radTe.Size = new System.Drawing.Size(122, 17);
            this.radTe.TabIndex = 10;
            this.radTe.TabStop = true;
            this.radTe.Text = "Te  Campana($2.00)";
            this.radTe.UseVisualStyleBackColor = true;
            // 
            // radCoca
            // 
            this.radCoca.AutoSize = true;
            this.radCoca.Location = new System.Drawing.Point(6, 19);
            this.radCoca.Name = "radCoca";
            this.radCoca.Size = new System.Drawing.Size(106, 17);
            this.radCoca.TabIndex = 8;
            this.radCoca.TabStop = true;
            this.radCoca.Text = "Coca-cola($1.00)";
            this.radCoca.UseVisualStyleBackColor = true;
            // 
            // radPepsi
            // 
            this.radPepsi.AutoSize = true;
            this.radPepsi.Location = new System.Drawing.Point(6, 42);
            this.radPepsi.Name = "radPepsi";
            this.radPepsi.Size = new System.Drawing.Size(84, 17);
            this.radPepsi.TabIndex = 9;
            this.radPepsi.TabStop = true;
            this.radPepsi.Text = "Pepsi($1.00)";
            this.radPepsi.UseVisualStyleBackColor = true;
            // 
            // radCocoRico
            // 
            this.radCocoRico.AutoSize = true;
            this.radCocoRico.Location = new System.Drawing.Point(6, 65);
            this.radCocoRico.Name = "radCocoRico";
            this.radCocoRico.Size = new System.Drawing.Size(103, 17);
            this.radCocoRico.TabIndex = 10;
            this.radCocoRico.TabStop = true;
            this.radCocoRico.Text = "Coco-rico($1.00)";
            this.radCocoRico.UseVisualStyleBackColor = true;
            // 
            // radTropical
            // 
            this.radTropical.AutoSize = true;
            this.radTropical.Location = new System.Drawing.Point(118, 19);
            this.radTropical.Name = "radTropical";
            this.radTropical.Size = new System.Drawing.Size(118, 17);
            this.radTropical.TabIndex = 11;
            this.radTropical.TabStop = true;
            this.radTropical.Text = "Jugo tropical($1.25)";
            this.radTropical.UseVisualStyleBackColor = true;
            // 
            // radSprite
            // 
            this.radSprite.AutoSize = true;
            this.radSprite.Location = new System.Drawing.Point(6, 88);
            this.radSprite.Name = "radSprite";
            this.radSprite.Size = new System.Drawing.Size(85, 17);
            this.radSprite.TabIndex = 12;
            this.radSprite.TabStop = true;
            this.radSprite.Text = "Sprite($1.00)";
            this.radSprite.UseVisualStyleBackColor = true;
            // 
            // linkSalir
            // 
            this.linkSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.linkSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkSalir.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkSalir.Location = new System.Drawing.Point(460, 254);
            this.linkSalir.Name = "linkSalir";
            this.linkSalir.Size = new System.Drawing.Size(42, 23);
            this.linkSalir.TabIndex = 3;
            this.linkSalir.TabStop = true;
            this.linkSalir.Text = "Salir";
            this.linkSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSalir_LinkClicked);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(25, 16);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(49, 13);
            this.Subtotal.TabIndex = 4;
            this.Subtotal.Text = "Subtotal:";
            // 
            // grpSalsaAderezo
            // 
            this.grpSalsaAderezo.Controls.Add(this.chkHoneyM);
            this.grpSalsaAderezo.Controls.Add(this.chkSpicyPig);
            this.grpSalsaAderezo.Controls.Add(this.chkKetchup);
            this.grpSalsaAderezo.Controls.Add(this.chkRanch);
            this.grpSalsaAderezo.Controls.Add(this.chkMayoK);
            this.grpSalsaAderezo.Location = new System.Drawing.Point(37, 131);
            this.grpSalsaAderezo.Name = "grpSalsaAderezo";
            this.grpSalsaAderezo.Size = new System.Drawing.Size(200, 117);
            this.grpSalsaAderezo.TabIndex = 5;
            this.grpSalsaAderezo.TabStop = false;
            this.grpSalsaAderezo.Text = "Salsas y aderezos";
            // 
            // chkHoneyM
            // 
            this.chkHoneyM.AutoSize = true;
            this.chkHoneyM.Location = new System.Drawing.Point(46, 79);
            this.chkHoneyM.Name = "chkHoneyM";
            this.chkHoneyM.Size = new System.Drawing.Size(97, 30);
            this.chkHoneyM.TabIndex = 4;
            this.chkHoneyM.Text = "Honey mustard\r\n        ($0.50)";
            this.chkHoneyM.UseVisualStyleBackColor = true;
            // 
            // chkSpicyPig
            // 
            this.chkSpicyPig.AutoSize = true;
            this.chkSpicyPig.Location = new System.Drawing.Point(108, 21);
            this.chkSpicyPig.Name = "chkSpicyPig";
            this.chkSpicyPig.Size = new System.Drawing.Size(69, 30);
            this.chkSpicyPig.TabIndex = 3;
            this.chkSpicyPig.Text = "Spicy pig\r\n  ($0.70)";
            this.chkSpicyPig.UseVisualStyleBackColor = true;
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(108, 58);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(98, 17);
            this.chkKetchup.TabIndex = 2;
            this.chkKetchup.Text = "Ketshup($0.25)";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // chkRanch
            // 
            this.chkRanch.AutoSize = true;
            this.chkRanch.Location = new System.Drawing.Point(11, 58);
            this.chkRanch.Name = "chkRanch";
            this.chkRanch.Size = new System.Drawing.Size(91, 17);
            this.chkRanch.TabIndex = 1;
            this.chkRanch.Text = "Ranch($0.25)";
            this.chkRanch.UseVisualStyleBackColor = true;
            // 
            // chkMayoK
            // 
            this.chkMayoK.AutoSize = true;
            this.chkMayoK.Location = new System.Drawing.Point(11, 21);
            this.chkMayoK.Name = "chkMayoK";
            this.chkMayoK.Size = new System.Drawing.Size(95, 30);
            this.chkMayoK.TabIndex = 0;
            this.chkMayoK.Text = "Mayo-Ketchup\r\n      ($0.25)";
            this.chkMayoK.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.msjTotal);
            this.groupBox4.Controls.Add(this.msjTax);
            this.groupBox4.Controls.Add(this.msjSub);
            this.groupBox4.Controls.Add(this.Total);
            this.groupBox4.Controls.Add(this.Tax);
            this.groupBox4.Controls.Add(this.Subtotal);
            this.groupBox4.Location = new System.Drawing.Point(254, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // msjTotal
            // 
            this.msjTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msjTotal.Location = new System.Drawing.Point(75, 71);
            this.msjTotal.Name = "msjTotal";
            this.msjTotal.Size = new System.Drawing.Size(100, 23);
            this.msjTotal.TabIndex = 9;
            // 
            // msjTax
            // 
            this.msjTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msjTax.Location = new System.Drawing.Point(75, 34);
            this.msjTax.Name = "msjTax";
            this.msjTax.Size = new System.Drawing.Size(100, 23);
            this.msjTax.TabIndex = 8;
            // 
            // msjSub
            // 
            this.msjSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msjSub.Location = new System.Drawing.Point(75, 10);
            this.msjSub.Name = "msjSub";
            this.msjSub.Size = new System.Drawing.Size(100, 23);
            this.msjSub.TabIndex = 7;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(40, 72);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total:";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(46, 35);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(28, 13);
            this.Tax.TabIndex = 5;
            this.Tax.Text = "Tax:";
            // 
            // btnResetiar
            // 
            this.btnResetiar.Location = new System.Drawing.Point(377, 254);
            this.btnResetiar.Name = "btnResetiar";
            this.btnResetiar.Size = new System.Drawing.Size(75, 23);
            this.btnResetiar.TabIndex = 7;
            this.btnResetiar.Text = "Resetiar";
            this.btnResetiar.UseVisualStyleBackColor = true;
            this.btnResetiar.Click += new System.EventHandler(this.btnResetiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 291);
            this.Controls.Add(this.btnResetiar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpSalsaAderezo);
            this.Controls.Add(this.linkSalir);
            this.Controls.Add(this.grpVebidas);
            this.Controls.Add(this.grpFrituras);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Frituras y algo mas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFrituras.ResumeLayout(false);
            this.grpFrituras.PerformLayout();
            this.grpVebidas.ResumeLayout(false);
            this.grpVebidas.PerformLayout();
            this.grpSalsaAderezo.ResumeLayout(false);
            this.grpSalsaAderezo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpFrituras;
        private System.Windows.Forms.RadioButton radSorrudog;
        private System.Windows.Forms.RadioButton radPastelillos;
        private System.Windows.Forms.RadioButton radpizza;
        private System.Windows.Forms.RadioButton radAlcapurria;
        private System.Windows.Forms.RadioButton radSorrullo;
        private System.Windows.Forms.GroupBox grpVebidas;
        private System.Windows.Forms.RadioButton radChina;
        private System.Windows.Forms.RadioButton radCafe;
        private System.Windows.Forms.RadioButton radTe;
        private System.Windows.Forms.RadioButton radCoca;
        private System.Windows.Forms.RadioButton radPepsi;
        private System.Windows.Forms.RadioButton radCocoRico;
        private System.Windows.Forms.RadioButton radTropical;
        private System.Windows.Forms.RadioButton radSprite;
        private System.Windows.Forms.LinkLabel linkSalir;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.GroupBox grpSalsaAderezo;
        private System.Windows.Forms.CheckBox chkHoneyM;
        private System.Windows.Forms.CheckBox chkSpicyPig;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkRanch;
        private System.Windows.Forms.CheckBox chkMayoK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label msjTotal;
        private System.Windows.Forms.Label msjTax;
        private System.Windows.Forms.Label msjSub;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Button btnResetiar;
    }
}

