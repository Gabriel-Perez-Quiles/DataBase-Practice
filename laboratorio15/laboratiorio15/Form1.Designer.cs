namespace laboratiorio15
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
            this.lbName = new System.Windows.Forms.Label();
            this.lblCty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CbCty = new System.Windows.Forms.ComboBox();
            this.RtB = new System.Windows.Forms.RichTextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lblCty
            // 
            this.lblCty.AutoSize = true;
            this.lblCty.Location = new System.Drawing.Point(0, 45);
            this.lblCty.Name = "lblCty";
            this.lblCty.Size = new System.Drawing.Size(22, 13);
            this.lblCty.TabIndex = 1;
            this.lblCty.Text = "Cty";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(41, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // CbCty
            // 
            this.CbCty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCty.FormattingEnabled = true;
            this.CbCty.Items.AddRange(new object[] {
            "Lares",
            "Arecibo",
            "Hatillo",
            "San Juan",
            "Barcelonata",
            "Vega Baja"});
            this.CbCty.Location = new System.Drawing.Point(41, 37);
            this.CbCty.Name = "CbCty";
            this.CbCty.Size = new System.Drawing.Size(108, 21);
            this.CbCty.TabIndex = 4;
            // 
            // RtB
            // 
            this.RtB.Location = new System.Drawing.Point(12, 122);
            this.RtB.Name = "RtB";
            this.RtB.Size = new System.Drawing.Size(256, 159);
            this.RtB.TabIndex = 5;
            this.RtB.Text = "";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(41, 74);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(122, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 293);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.RtB);
            this.Controls.Add(this.CbCty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCty);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lblCty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox CbCty;
        private System.Windows.Forms.RichTextBox RtB;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnReset;
    }
}

