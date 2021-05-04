using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int currentYear = Int32.Parse(txtCurrentY.Text);
                int birthYear = Int32.Parse(txtBirthYear.Text);
                int age;

                age = (currentYear - birthYear);

                lblMensaje.Text = age.ToString();
            }
            catch
            {
                MessageBox.Show("Verificar los datos entrados", "ERROR", MessageBoxButtons.OK);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBirthYear.Clear();
            txtCurrentY.Clear();
            lblMensaje.Text = " ";
        }
    }
}
