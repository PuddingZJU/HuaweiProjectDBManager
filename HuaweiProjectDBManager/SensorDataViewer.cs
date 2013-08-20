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
using System.Diagnostics;
namespace HuaweiProjectDBManager
{
    public partial class SensorDataViewer : Form
    {
        String[] sensordata = new String[14];
        String[] devicedata = new String[3];
        String[] operatordata = new String[5];
        SqlConnection sqlConnection;
        String[] activitylist = new String[] { "向前摔倒膝盖着地", "向前摔倒手臂向前保护着地", "向前摔倒平躺着地"
            , "向右侧摔倒平躺着地", "向左侧摔倒平躺着地", "向后跌倒，坐在地上", "向后跌倒，倒在地上","摔倒后爬起"
            , "从椅子上面起身", "从椅子上面快速起身", "缓慢坐到椅子", "快速坐到椅子", "躺倒床上（不测单肩包位置）"
            , "从床上爬起来（不测单肩包位置）" ,"步行" , "快速步行", "弯腰捡起地上的东西然后起身", "慢跑", "快跑", "上楼梯", "下楼梯"
            , "开车", "上车", "下车", "快速蹲下", "原地起跳","向前跳跃" };
        String[] positionlist = new String[] { "胸前口袋（左）", "胸前口袋（右）", "裤子侧口袋（左）", "裤子侧口袋（右）",
            "外衣口袋（左）", "外衣口袋（右）", "单肩包（左）", "单肩包（右）" };
        String[] activitytypelist = new String[] { "走路", "跑步", "驾车", "摔倒", "日常行为" };
        String[] backgroundactivity = new String[] { "静止", "走路", "跑步" };
        public SensorDataViewer(String[] _sensordata,String[] _operatordata,String[] _devicedata,SqlConnection _sqconn)
        {
            sqlConnection = _sqconn;
            sensordata = _sensordata;
            devicedata = _devicedata;
            operatordata = _operatordata;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SensorDataViewer_Load(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(sensordata[1]);
            xmldoc.Save("temp.xml");
            IDlabel.Text += sensordata[0];
            Alabel.Text += activitylist[Convert.ToInt32(sensordata[3]) - 1];
            BGAlabel.Text += backgroundactivity[Convert.ToInt32(sensordata[2]) - 1]; ;
            Dlabel.Text += sensordata[4];
            Olabel.Text += sensordata[5];
            SRlabel.Text += sensordata[6] + " Hz";
            Plabel.Text += positionlist[Convert.ToInt32(sensordata[7]) - 1];
            Tlabel.Text += sensordata[8];
            ASFlabel.Text += sensordata[11];
            AEFlabel.Text += sensordata[12];
            TFlabel.Text += sensordata[13];
            Dnamelabel.Text += devicedata[0];
            Dvendorlabel.Text += devicedata[1];
            Dversionlabel.Text += devicedata[2];
            Onamelabel.Text += operatordata[0];
            Oagelabel.Text += operatordata[2];
            Osexlabel.Text += operatordata[1];
            Oheightlabel.Text += operatordata[3]+" cm";
            Oweightlabel.Text += operatordata[4] + " kg";
            Process process = new Process();//创建进程对象  
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe" ;//"";//设定需要执行的命令  
            startInfo.Arguments = "/C "+"show_data.py " +"temp.xml";//表示执行完命令后马上退出  
            startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
            startInfo.RedirectStandardInput = false;//不重定向输入  
            startInfo.RedirectStandardOutput = false; //重定向输出  
            startInfo.CreateNoWindow = true;//不创建窗口  
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            Apic.Image = new Bitmap(@"temp_A.jpg");
            Mpic.Image = new Bitmap(@"temp_M.jpg");
            Gpic.Image = new Bitmap(@"temp_G.jpg");
            Rpic.Image = new Bitmap(@"temp_R.jpg");
        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            String sqlcmdstr = "SELECT * FROM [dba].[eigenvaluetable] where ID = '" + sensordata[0] + "'";
            SqlCommand sqlcmd = new SqlCommand(sqlcmdstr, sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            eigenvalueform ef = new eigenvalueform(ds);
            ef.ShowDialog();
            sqlConnection.Close();
        }
    }
}
