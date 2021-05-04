using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio14
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtNumber.Clear();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int x, N, suma = 0;

            N = int.Parse(txtNumber.Text);

            for(x = 1; x<=N; x++)
            {
                suma = suma + x;

                if(checkBox1.Checked == true)
                {
                    listBox1.Items.Add($"sumando: {x} suma Parcial:{suma}");
                }
            }
            listBox1.Items.Add($"La suma TOTAL es:{suma}");
        }
    }
}
