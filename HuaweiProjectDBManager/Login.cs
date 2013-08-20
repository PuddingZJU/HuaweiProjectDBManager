using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuaweiProjectDBManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            addersstextbox.Text = "";
            accounttextbox.Text = "";
            pwdtextbox.Text = "";
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string sqlconnstr = "Data Source=" + addersstextbox.Text + ";uid=" + accounttextbox.Text +
                ";pwd=" + pwdtextbox.Text + ";Initial Catalog="+DBNameBox.Text+";";
            SqlConnection SqlConn = new SqlConnection(sqlconnstr);
            if (SqlConn.State == ConnectionState.Open)
            {
                SqlConn.Close();
            }
            try
            {
                SqlConn.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (SqlConn.State == ConnectionState.Open)
            {
                SqlConn.Close();
                MainForm dm = new MainForm(SqlConn);
                dm.Show();
                this.Hide();
            }
                
        }
    }
}
