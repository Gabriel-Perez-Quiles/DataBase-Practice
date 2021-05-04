using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio5
{
    public partial class laboratorio5 : Form
    {
        public laboratorio5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtNombre.Text = " ";
            //txtApellido.Text = " ";

            txtNombre.Clear();
            txtApellido.Clear();
            Msj.Text = " ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            // MessageBox.Show("Bienvenid@ " + nombre + " " + apellido);

            Msj.Text = (nombre + " " + apellido);
        }
    }
}
