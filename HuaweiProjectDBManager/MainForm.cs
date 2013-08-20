using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;
namespace HuaweiProjectDBManager
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection;
        DataSet sensordatatable;
        DataSet querydatatable;
        DataSet devicetable = new DataSet();
        DataSet operatortable = new DataSet();
        int height;
        int width;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(SqlConnection _sqlConnection)
        {
            sqlConnection = _sqlConnection;
            InitializeComponent();
        }

        private void DataManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadDB() //加载数据库的3张表
        {       
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
            string sqlcmdstr_sensordata = "SELECT [ID],[DataTypeID],[ActivityID],[DeviceID],[OperatorID],[PositionID],[SampleRate],[CreateTime],[TotalChannelNum],[ActivityBeginFrameID],[ActivityEndFrameID] FROM SensorDataTable";
            string sqlcmdstr_device = "select * from DeviceTable";
            string sqlcmdstr_operator = "select * from OperatorTable";
            SqlCommand sqlcmd_sensordata = new SqlCommand(sqlcmdstr_sensordata, sqlConnection);
            SqlCommand sqlcmd_device = new SqlCommand(sqlcmdstr_device, sqlConnection);
            SqlCommand sqlcmd_operator = new SqlCommand(sqlcmdstr_operator, sqlConnection);
            SqlDataAdapter sda_sensordata = new SqlDataAdapter(sqlcmd_sensordata);
            SqlDataAdapter sda_device = new SqlDataAdapter(sqlcmd_device);
            SqlDataAdapter sda_operator = new SqlDataAdapter(sqlcmd_operator);
            sensordatatable = new DataSet();
            sda_sensordata.Fill(sensordatatable);
            sda_operator.Fill(operatortable);
            sda_device.Fill(devicetable);
            querydatatable = sensordatatable;
            DBView.DataSource = querydatatable.Tables[0];
            sqlConnection.Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            height = this.Height;
            width = this.Width;
            loadDB();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            AddSensorData asd = new AddSensorData(sqlConnection, sensordatatable.Tables[0].Rows.Count+1);
            asd.ShowDialog();
            loadDB();
        }

        private void DBView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String[] sensordata = new String[14];
            for (int i = 0; i < sensordata.Length; i++)
            {
                sensordata[i] = querydatatable.Tables[0].Rows[e.RowIndex][i].ToString();
            }
            String[] devicedata = new String[3];
            for (int i = 0; i < devicedata.Length; i++)
            {
                devicedata[i] = devicetable.Tables[0].Rows[Convert.ToInt32(sensordata[4])-1][i+1].ToString();
            }
            String[] operatordata = new String[5];
            for (int i = 0; i < operatordata.Length; i++)
            {
                operatordata[i] = operatortable.Tables[0].Rows[Convert.ToInt32(sensordata[5])-1][i+1].ToString();
            }
            SensorDataViewer sdv = new SensorDataViewer(sensordata,operatordata,devicedata,sqlConnection);
            sdv.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //SearchForm sf = new SearchForm();
            //sf.ShowDialog();
            //if (sf.sqlcomstr == "")
            //    return;
            //String sqlcommstr = sf.sqlcomstr;
            //try
            //{
            //    sqlConnection.Open();
            //    SqlCommand sqlcmd = new SqlCommand(sqlcommstr, sqlConnection);
            //    SqlDataAdapter data = new SqlDataAdapter(sqlcmd);
            //    querydatatable = new DataSet();
            //    data.Fill(querydatatable);
            //    DBView.DataSource = querydatatable.Tables[0];
            //    sqlConnection.Close();
                
            //}
            //catch (Exception ex)
            //{
            //    sqlConnection.Close();
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //    return;
            //}
            String filepath = "\\alldata\\";
            String content = "";
            for (int i = 0; i < sensordatatable.Tables[0].Rows.Count; i++)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(sensordatatable.Tables[0].Rows[i][1].ToString());
                int x = i + 1;
                xmldoc.Save(filepath + x.ToString() + ".xml");
                content += x.ToString() + "\t" + sensordatatable.Tables[0].Rows[i][11].ToString() + "\t" + sensordatatable.Tables[0].Rows[i][12].ToString() + "\r\n";
            }
            using (StreamWriter sw = new StreamWriter(filepath + "config.txt"))
            {
                sw.Write(content);
            }
            MessageBox.Show("Success");

        }

        private void ExitPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //DBView.Width = this.width - 150;
            //DBView.Height = this.height - 20;
            

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {            

            //DBView.Width = this.width - 100;
            //DBView.Height = this.height - 20;
        }
    }
}
