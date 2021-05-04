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

        private void btnSignin_Click(object sender, EventArgs e)
        {
            String Username, Password;
            Username = txtUsername.Text;
            Password = txtPassword.Text;

            if ((Username == "Gabriel" && Password == "sorullo") || (Username == "A" && Password == "1234"))
                {
                this.Hide();
                Form2 Form2 = new Form2();
                Form2.Show();
                }
            else
            {
                MessageBox.Show("animal escribelo bien", "ERROR", MessageBoxButtons.OK);
            }
            
                
        }
    }
}
