﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al curso de COMP3900", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2); 
        }
    }
}
