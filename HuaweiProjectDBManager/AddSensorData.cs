using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace HuaweiProjectDBManager
{
    public partial class AddSensorData : Form
    {
        private SqlConnection sqlConnection;
        private int CurID = 0; 
        public AddSensorData(SqlConnection _sqlConnection,int _Cur_ID)
        {
            CurID = _Cur_ID;
            sqlConnection = _sqlConnection;
            InitializeComponent();
        }

        private void AddSensorData_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.RootFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //openFileDialog.Filter = "xml files (*.xml)|*.xml";
            ///openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                filepathnamebox.Text = folderBrowserDialog1.SelectedPath; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (filepathnamebox.Text == "" || DeviceIDBOX.Text == "" || OperatorIDBox.Text == "" || SRbox.Text == "")
            {
                MessageBox.Show("信息不完整");
                return;
            }
            string _filepath = filepathnamebox.Text;
            string configpath = _filepath + "\\config.txt";
            if (!File.Exists(configpath))
            {
                MessageBox.Show("Config file is not exist");
                return;
            }
           // try
           // {
                
                String line;
                using (StreamReader sr = new StreamReader(configpath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] unit = line.Split(new String[]{"\t"},StringSplitOptions.RemoveEmptyEntries);
                        int[] paras = new int[7];
                        for (int i = 0; i < paras.Length; i++)
			            {
                            paras[i] = Convert.ToInt32(unit[i]);
			            }
                        AddSingleFile(_filepath+"\\", Convert.ToInt32(OperatorIDBox.Text), Convert.ToInt32(DeviceIDBOX.Text), paras[0], paras[1], paras[2], paras[3], paras[4], paras[5], paras[6]);
                    }
                }
           // }
           // catch (Exception configfile_e)
           // {
           //     MessageBox.Show(configfile_e.Message);
           //     return;
           // }
            
            MessageBox.Show("导入成功");
            this.Close();
        }
        private void AddSingleFile(string filepath,  int OperatorID, int DeviceID,int fileID,int PositionID,int BGActivityID,int ActivityID,
            int TotalFrame, int ActivityBframe, int ActivityEframe)
        {
            String xmlstr;
            using (StreamReader sr = new StreamReader(filepath + fileID + ".xml")) 
            {
                xmlstr = sr.ReadToEnd();
            }
            FileInfo fi = new FileInfo(filepath + fileID + ".xml");
            string sqlcmdstr = "insert into dba.SensorDataTable(ID,Data,BackgroundActivityID," +
            "ActivityID,DeviceID,OperatorID,SampleRate,PositionID,ActivityBeginFrame,ActivityEndFrame,TotalFrames,CreateTime) values('" + CurID + "','" +
            xmlstr + "','" + BGActivityID + "','" + ActivityID + "','" + DeviceID + "','" + OperatorID + "','" + 50 + "','" + PositionID + "','" + ActivityBframe + "','" +
            ActivityEframe + "','" + TotalFrame + "','"+ fi.LastWriteTime.ToString()+"')";
            CurID += 1;
            //try
            //{
                sqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlcmdstr, sqlConnection);
                sqlCmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    sqlConnection.Close();
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
             sqlConnection.Close();
           
        }
    }
}
