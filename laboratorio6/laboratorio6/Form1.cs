using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;

            MessageBox.Show("Bienvenid@ " + nombre + " " + apellido1 + " " + apellido2);
        }
    }
}
