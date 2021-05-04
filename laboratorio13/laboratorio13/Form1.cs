using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            {
                String item = listBox1.SelectedItem.ToString();
                txtSelected.Text = item;
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();

            int index = listBox1.FindString(Items.Text);

            if(index < 0)
            {
                MessageBox.Show("Item not found.", "Warning");
                Items.Text = String.Empty;
            }
            else
            {
                listBox1.SelectedIndex = index;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtSelected.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedIndex >=0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);

                txtSelected.Text = "";
            }
        }
    }
}
