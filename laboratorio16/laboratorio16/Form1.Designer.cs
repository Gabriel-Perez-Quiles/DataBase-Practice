namespace laboratorio16
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBackC = new System.Windows.Forms.Button();
            this.btnColorD = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAlignment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(0, 2);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 1;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackC
            // 
            this.btnBackC.Location = new System.Drawing.Point(162, 2);
            this.btnBackC.Name = "btnBackC";
            this.btnBackC.Size = new System.Drawing.Size(75, 23);
            this.btnBackC.TabIndex = 3;
            this.btnBackC.Text = "Back Color";
            this.btnBackC.UseVisualStyleBackColor = true;
            this.btnBackC.Click += new System.EventHandler(this.btnBackC_Click);
            // 
            // btnColorD
            // 
            this.btnColorD.Location = new System.Drawing.Point(243, 2);
            this.btnColorD.Name = "btnColorD";
            this.btnColorD.Size = new System.Drawing.Size(75, 23);
            this.btnColorD.TabIndex = 4;
            this.btnColorD.Text = "Color Dialog";
            this.btnColorD.UseVisualStyleBackColor = true;
            this.btnColorD.Click += new System.EventHandler(this.btnColorD_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Bullets";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(486, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Font-Size";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAlignment
            // 
            this.btnAlignment.Location = new System.Drawing.Point(324, 2);
            this.btnAlignment.Name = "btnAlignment";
            this.btnAlignment.Size = new System.Drawing.Size(75, 23);
            this.btnAlignment.TabIndex = 8;
            this.btnAlignment.Text = "Alignment";
            this.btnAlignment.UseVisualStyleBackColor = true;
            this.btnAlignment.Click += new System.EventHandler(this.btnAlignment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 261);
            this.Controls.Add(this.btnAlignment);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnColorD);
            this.Controls.Add(this.btnBackC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBackC;
        private System.Windows.Forms.Button btnColorD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAlignment;
    }
}

