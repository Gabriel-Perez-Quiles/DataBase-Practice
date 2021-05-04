using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Double horastrabajadas = Double.Parse(txtCantTrabajas.Text);
                Double horaspagadas = Double.Parse(txtCantPaga.Text);
                Double sueldo;

                sueldo = (horastrabajadas * horaspagadas);

                // lblMensaje.Text = age.ToString();
                MessageBox.Show("El sueldo del empleado es" + sueldo + "\n" + sueldo.ToString("C"));
            }
            catch
            {
                MessageBox.Show("Verificar los datos entrados", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCantTrabajas.Clear();
            txtCantPaga.Clear();
            //lblMensaje.Text(" ");
        }
    }
}
