using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "WAAAAAAAAA";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Violet;
        }

        private void btnBackC_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;
        }

        private void btnColorD_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.SelectionColor;

            if(colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                colorDialog1.Color != richTextBox1.SelectionColor)

            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Arial Black", 24, FontStyle.Underline);
        }

        private void btnAlignment_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true; 
        }
    }
}
