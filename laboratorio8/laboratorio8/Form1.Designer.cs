namespace laboratorio8
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.CurrentYear = new System.Windows.Forms.Label();
            this.BirthYear = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.txtCurrentY = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CurrentYear
            // 
            this.CurrentYear.AutoSize = true;
            this.CurrentYear.Location = new System.Drawing.Point(12, 47);
            this.CurrentYear.Name = "CurrentYear";
            this.CurrentYear.Size = new System.Drawing.Size(97, 13);
            this.CurrentYear.TabIndex = 2;
            this.CurrentYear.Text = "Enter Current Year:";
            // 
            // BirthYear
            // 
            this.BirthYear.AutoSize = true;
            this.BirthYear.Location = new System.Drawing.Point(12, 74);
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Size = new System.Drawing.Size(84, 13);
            this.BirthYear.TabIndex = 3;
            this.BirthYear.Text = "Enter Birth Year:";
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(140, 70);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(100, 20);
            this.txtBirthYear.TabIndex = 4;
            // 
            // txtCurrentY
            // 
            this.txtCurrentY.Location = new System.Drawing.Point(140, 40);
            this.txtCurrentY.Name = "txtCurrentY";
            this.txtCurrentY.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentY.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensaje.Location = new System.Drawing.Point(49, 159);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(186, 53);
            this.lblMensaje.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtCurrentY);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.BirthYear);
            this.Controls.Add(this.CurrentYear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "laboratorio8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label CurrentYear;
        private System.Windows.Forms.Label BirthYear;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.TextBox txtCurrentY;
        private System.Windows.Forms.Label lblMensaje;
    }
}

