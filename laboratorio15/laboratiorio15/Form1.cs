using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratiorio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Clear();

            RtB.Clear();
            CbCty.ResetText();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string city = CbCty.SelectedItem.ToString();

            RtB.Text += ($"El nombre entrado es {name} y la ciudad es {city}\n");
            //El += nos a~ade.
        }
    }
}
