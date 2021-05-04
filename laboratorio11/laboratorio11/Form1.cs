using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radWhiteBagel.Checked = false;
            radWheatBagel.Checked = false;

            //check

            radNone.Checked = false;
            radRegularCoffe.Checked = false;
            radCappuccino.Checked = false;

            chkCreamCheese.Checked = false;
            chkStrawjam.Checked = false;
            chkBluejam.Checked = false;
            chkButter.Checked = false;

            msjSubt.Text = " ";
            msjTax.Text = " ";
            msjTotal.Text = " ";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //This procedure calculates the total

            double lblSubtotal; //holds the order subtotal
            double lblTax = .115; //holds the sales
            double lblTotal; //holds the order total

            double BagelCost = 0.00;
            double CoffeCost = 0.00;
            double ToppingCost = 0.00;

            //Select Bagels
            if (radWhiteBagel.Checked)
            {
                BagelCost = 1.25;
            }
            else if (radWheatBagel.Checked)
            {
                BagelCost = 1.50;
            }

            //select drinks
            if (radRegularCoffe.Checked)
            {
                CoffeCost = 1.25;
            }

            else if(radCappuccino.Checked)
            {
                CoffeCost = 2.00;
            }

            //Select toppings
            ToppingCost += (chkCreamCheese.Checked ? 0.50: 0.00);
            ToppingCost += (chkStrawjam.Checked ? 0.75 : 0.00);
            ToppingCost += (chkBluejam.Checked ? 0.75 : 0.00);
            ToppingCost += (chkButter.Checked ? 0.50 : 0.00);

            //Calculate

            lblSubtotal = BagelCost + ToppingCost + CoffeCost;
            lblTax = lblTax * lblSubtotal;
            lblTotal = lblSubtotal + lblTax;

            msjSubt.Text = lblSubtotal.ToString("c");
            msjTax.Text = lblTax.ToString("c");
            msjTotal.Text = lblTotal.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
