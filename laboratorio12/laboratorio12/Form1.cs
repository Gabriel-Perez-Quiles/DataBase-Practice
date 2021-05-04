using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResetiar_Click(object sender, EventArgs e)
        {
            //frituras//
            radSorrullo.Checked = false;
            radSorrudog.Checked = false;
            radPastelillos.Checked = false;
            radpizza.Checked = false;
            radAlcapurria.Checked = false;

            //salsas//aderezos//
            chkHoneyM.Checked = false;
            chkKetchup.Checked = false;
            chkMayoK.Checked = false;
            chkRanch.Checked = false;
            chkSpicyPig.Checked = false;

            //vebidas//
            radCafe.Checked = false;
            radChina.Checked = false;
            radCoca.Checked = false;
            radCocoRico.Checked = false;
            radPepsi.Checked = false;
            radSprite.Checked = false;
            radTropical.Checked = false;
            radTe.Checked = false;

            //Total//
            msjSub.Text = " ";
            msjTax.Text = " ";
            msjTotal.Text = " ";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variables//Empieza la calculacion
            double Subtotal;
            double Tax = .115;
            double Total;

            double Vevidas = 0.00;
            double Frituras = 0.00;
            double SalsaAderezo = 0.00;

            if (radSorrullo.Checked)
            {
                Frituras = 1.00;
            }
            else if (radAlcapurria.Checked)
            {
                Frituras = 1.50;
            }

            if (radPastelillos.Checked)
            {
                Frituras = 0.85;
            }
            else if (radpizza.Checked)
            {
                Frituras = 1.00;
            }

            if(radSorrudog.Checked)
            {
                Frituras = 1.00;
            }
            else if(radPepsi.Checked)
            {
                Vevidas = 1.00;
            }
            if (radSprite.Checked)
            {
                Vevidas = 1.00;
            }
            else if (radCoca.Checked)
            {
                Vevidas = 1.00;
            }
            if (radCocoRico.Checked)
            {
                Vevidas = 1.00;
            }
            else if (radCafe.Checked)
            {
                Vevidas = 0.50;
            }
            if (radChina.Checked)
            {
                Vevidas = 1.25;
            }
            else if (radTe.Checked)
            {
                Vevidas = 2.00;
            }
            if (radTropical.Checked)
            {
                Vevidas = 1.25;
            }
            else if (false);
            


            //S
            SalsaAderezo += (chkHoneyM.Checked ? 0.70 : 0.00);
            SalsaAderezo += (chkKetchup.Checked ? 0.25 : 0.00);
            SalsaAderezo += (chkMayoK.Checked ? 0.25 : 0.00);
            SalsaAderezo += (chkRanch.Checked ? 0.25 : 0.00);
            SalsaAderezo += (chkSpicyPig.Checked ? 0.70 : 0.00);


            Subtotal = Frituras + SalsaAderezo + Vevidas;
            Tax = Tax * Subtotal;
            Total = Subtotal + Tax;

            msjSub.Text = Subtotal.ToString("c");
            msjTax.Text = Tax.ToString("c");
            msjTotal.Text = Total.ToString("c");
        }

        private void linkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
