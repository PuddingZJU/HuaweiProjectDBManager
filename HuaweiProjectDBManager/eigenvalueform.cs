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
    public partial class eigenvalueform : Form
    {
        DataSet eds;
        public eigenvalueform(DataSet _eds)
        {
            eds = _eds;
            InitializeComponent();
        }

        private void eigenvalueform_Load(object sender, EventArgs e)
        {
            elist.BeginUpdate();
            for (int i = 1; i < eds.Tables[0].Columns.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = eds.Tables[0].Columns[i].ColumnName.ToString();
                lvi.SubItems.Add(eds.Tables[0].Rows[0][i].ToString());
                elist.Items.Add(lvi);
            }
            elist.EndUpdate();
        }
    }
}
