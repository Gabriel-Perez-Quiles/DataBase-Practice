using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio7
{
    public partial class Laboratorio7 : Form
    {
        public Laboratorio7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            MiniMsj.Text = " ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            MiniMsj.Text = (nombre + "  " + apellido1 + "  "+ apellido2);
        }
    }
}
