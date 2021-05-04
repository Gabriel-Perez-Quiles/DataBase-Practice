using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorioRichAsig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                colorDialog1.Color != richTextBox1.SelectionColor)

            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
