using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Laboratorio19
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string usr = txtUser.Text;
            string pwd = txtPass.Text;

            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Database01.mdb;Persist Security Info=False;");
                cmd = new OleDbCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = ($"SELECT * FROM users where users='{usr}' AND password = '{pwd}'");
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close(); // IMPORTANTE
        }
    }
}
