using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuaweiProjectDBManager
{
    public partial class SearchForm : Form
    {
        public string sqlcomstr ="";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcomstr = richTextBox1.Text;
            this.Close();
        }
    }
}
