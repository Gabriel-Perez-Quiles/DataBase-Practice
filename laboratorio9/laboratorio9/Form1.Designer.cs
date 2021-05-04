namespace laboratorio9
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
            this.btnClear = new System.Windows.Forms.Button();
            this.CantHorasTrabajadas = new System.Windows.Forms.Label();
            this.CantPagaHora = new System.Windows.Forms.Label();
            this.txtCantTrabajas = new System.Windows.Forms.TextBox();
            this.txtCantPaga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(51, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CantHorasTrabajadas
            // 
            this.CantHorasTrabajadas.AutoSize = true;
            this.CantHorasTrabajadas.Location = new System.Drawing.Point(12, 23);
            this.CantHorasTrabajadas.Name = "CantHorasTrabajadas";
            this.CantHorasTrabajadas.Size = new System.Drawing.Size(148, 13);
            this.CantHorasTrabajadas.TabIndex = 2;
            this.CantHorasTrabajadas.Text = "Cantidad de horas trabajadas:";
            // 
            // CantPagaHora
            // 
            this.CantPagaHora.AutoSize = true;
            this.CantPagaHora.Location = new System.Drawing.Point(12, 65);
            this.CantPagaHora.Name = "CantPagaHora";
            this.CantPagaHora.Size = new System.Drawing.Size(136, 13);
            this.CantPagaHora.TabIndex = 3;
            this.CantPagaHora.Text = "Cantidad de paga por hora:";
            // 
            // txtCantTrabajas
            // 
            this.txtCantTrabajas.Location = new System.Drawing.Point(158, 16);
            this.txtCantTrabajas.Name = "txtCantTrabajas";
            this.txtCantTrabajas.Size = new System.Drawing.Size(100, 20);
            this.txtCantTrabajas.TabIndex = 4;
            // 
            // txtCantPaga
            // 
            this.txtCantPaga.Location = new System.Drawing.Point(158, 58);
            this.txtCantPaga.Name = "txtCantPaga";
            this.txtCantPaga.Size = new System.Drawing.Size(100, 20);
            this.txtCantPaga.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.txtCantPaga);
            this.Controls.Add(this.txtCantTrabajas);
            this.Controls.Add(this.CantPagaHora);
            this.Controls.Add(this.CantHorasTrabajadas);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "laboratorio9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label CantHorasTrabajadas;
        private System.Windows.Forms.Label CantPagaHora;
        private System.Windows.Forms.TextBox txtCantTrabajas;
        private System.Windows.Forms.TextBox txtCantPaga;
    }
}

