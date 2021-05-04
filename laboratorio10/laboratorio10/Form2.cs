using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(this.Form_Closing);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e) {
            DialogResult frmclose =
                            MessageBox.Show("Do you want to exit?", "Closing", MessageBoxButtons.YesNo);
            if (frmclose == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
