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

namespace laboratorio19
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

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.database1DataSet.user);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string usr = txtUser.Text;
            string pwd = txtPassword.Text;



            con = new OleDbConnection("Provider=Microsoft.Jet.OLED8; Data Source=" + Application.StartupPath + "\\database.mdb;Persist Security Info=False;");
                cmd = new OleDbCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = ($"SELECT*FROM users where user='{user}' AND password='{password}'"); //buscar el driver.
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Form f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Username or passwoerd is incorrect");
            }

            con.Close(); //IMPORTANTE
        }
    }
}
