
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Reflection;
using Microsoft.Win32;

namespace CarWorkServer
{
    public partial class FormMain : Form
    {
        private IPAddress localAdddress;
        //IP地址
        private TcpListener tcpListener;
        //服务端                              
        private TcpClient tcpClient = null;
        //客户端                            
        private NetworkStream networkStream;
        //网络流

        string ReadMessage = null;
        string message = null;
     
        string id = null;
        MySqlCommand mycmd = null;
        MySqlConnection mycon = null;
        MySqlDataReader reader = null;
        object number = null;
        int Number = 0;
        string baiDu = null;
        //经纬度转换后的字符串
        string[] baiDU = new string[2];
        //转换后的经纬度
        string constr = null;
        //连接数据库驱动
        string sql = null;
        //操作数据库SQL语句
        string temMax = null;
        //温度上限
        string temMin = null;
        //温度下限
        string carID = null;
        //汽车ID
        byte[] sendByte;
        //发送字节流
        string sendString = null;
        //发送字符串
        string iD = null;
        //序号
        
        int pos = -1;
        //定时器 
        
        public FormMain()
        {
            InitializeComponent();
            this.notifyIcon1.Visible = true;
            //OpenWin();
        }
        
        /// <summary>
        /// 开始侦听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 开始侦听ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress[] listenIp = Dns.GetHostAddresses("");
                localAdddress = listenIp[2];
                //绑定IP
                int port = 10000;
                //定义端口                           
                tcpListener = new TcpListener(localAdddress, port);
                tcpListener.Start();
                Thread threadAccept = new Thread(AcceptClientConnect);
                threadAccept.Start();
            }
            catch (Exception error)
            {
                if (localAdddress != null)
                {
                    localAdddress = null;
                }
                MessageBox.Show(error.Message + "\n" + "侦听失败");
            }
        }
       
        /// <summary>
        /// 打开手机绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPhone formPhone = new FormPhone();
            formPhone.Show();
        }

        /// <summary>
        /// 连接客户端
        /// </summary>
        private void AcceptClientConnect()
        {
            try
            {
                tcpClient = tcpListener.AcceptTcpClient();
                networkStream = tcpClient.GetStream();
                pos = 1;
                Thread threadReceive = new Thread(ReceiveMessage);
                threadReceive.Start();
            }
            catch
            {
                if (networkStream != null)
                {
                    networkStream.Close();
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
                timer1.Stop();
            }
        }

        /// <summary>
        /// 下位机接收
        /// </summary>
        private void ReceiveMessage()
        {
            try
            {
                Byte[] ReceiveData = new Byte[128];
                while (true)
                {
                    networkStream.Read(ReceiveData, 0, ReceiveData.Length);
                    ReadMessage = System.Text.Encoding.ASCII.GetString(ReceiveData);
                    for (int i = 0; i < 128; i++)
                    {
                        if (ReadMessage[i].ToString() != "\0")
                        {
                            message = message + ReadMessage[i].ToString();
                        }
                    }
                    if (message != "")
                    {
                        string[] q = new string[8];
                        q = message.Split(',');
                        Mysql(q);
                        Array.Clear(ReceiveData, 0, ReceiveData.Length);
                        message = null;
                        ReadMessage = null;
                    }
                }
            }
            catch
            {
                if (networkStream != null)
                {
                    networkStream.Close();
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
            }
        }

        /// <summary>
        /// 下位机插入数据库
        /// </summary>
        /// <param name="a">数据</param>
        private void Mysql(String[] a)
        {
            string[] b = a;
            DateTime now = new DateTime();
            now = DateTime.Now;
            string Now = now.ToString();
            constr = "server = localhost;User Id = root;password = 306306306;Database = data";
            mycon = new MySqlConnection(constr);
            try
            {
                mycon.Open();
            }
            catch
            {
                if(mycon!=null)
                {
                    mycon.Close();
                }
            }
            finally
            {
                string sql2 = "select count(*) from car";
                mycmd = new MySqlCommand(sql2, mycon);
                number = mycmd.ExecuteScalar();
                Number = int.Parse(number.ToString()) + 1;
                id = Number.ToString();
                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (b[i] == "")
                        {
                            b[i] = "0";
                        }
                    }
                    //baiDu = GetLonLatUrl(b[2],b[3]);
                    //baiDU = baiDu.Split(',');
                    //b[2] = baiDU[0];
                    //b[3] = baiDU[1];
                    string sql3 = "insert into car values('" + id + "','" + b[0] + "','" + b[1] + "','" + b[2] + "','" + b[3] + "','" + b[4] + "','" + b[5] + "','" + b[6] + "','" + b[7] + "','" + Now + "')";
                    mycmd = new MySqlCommand(sql3, mycon);
                    mycmd.ExecuteNonQuery();
                    b = null;
                }
                catch
                {
                    if(mycmd!=null)
                    {
                        mycmd.Dispose();
                    }
                    if (mycon != null)
                    {
                        mycon.Close();
                    }
                }
            }
        }

        /// <summary>
         ///关闭侦听 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void 关闭侦听ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tcpListener.Stop();
            }
            catch
            {
                MessageBox.Show("监听尚未开始关闭无效（1）", "提示");
            }
        }

        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 断开连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 0;
            if (tcpClient != null)
            {
                try
                {
                    if (networkStream != null)
                    {
                        networkStream.Close();
                    }
                    if (tcpClient != null)
                    {
                        tcpClient.Close();
                    }
                    Thread threadAccept = new Thread(AcceptClientConnect);
                    threadAccept.Start();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                MessageBox.Show("还没有连接，请先与客户端连接", "提示");
            }
        }

        /// <summary>
        /// 窗口程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region GPS百度经纬度转换
        /// <summary>
        /// 传入经度纬度
        /// </summary>
        /// <param name="lat">经度</param>
        /// <param name="lon">纬度</param>
        public static string  GetLonLatUrl(string lat,string lon)
        {
            string LonLat = "";
            //string url = "http://api.map.baidu.com/ag/coord/convert?from=0&x=" + lon + "&y=" + lat + "&callback=BMap.Convertor.cbk_7594";
            string url = "http://api.map.baidu.com/geocoder/v2/?ak=&callback=renderReverse&location="+lat+","+lon+"";
            HttpWebRequest requst = (HttpWebRequest)HttpWebRequest.Create(url);//http传输协议
            HttpWebResponse respone = (HttpWebResponse)requst.GetResponse();//活的http的网络资源
            Stream stream = respone.GetResponseStream();//转换成字节流
            StreamReader sr = new StreamReader(stream, Encoding.GetEncoding("utf-8"));//已utf-8模式读取数据
            string responestr = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();//释放资源
            string[] responeArr = responestr.Split('\"');
            if(responeArr.Length>=11)
            {
                LonLat = GetbyBase64("utf-8", responeArr[5]) + "," + GetbyBase64("utf-8", responeArr[9]);
            }
            return LonLat;
        }
        /// <summary>
        /// 解析base64信息数据
        /// </summary>
        /// <param name="code_type">解析编码格式</param>
        /// <param name="code">传入的base64位值</param>
        /// <returns></returns>
        public static  string GetbyBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }
#endregion

        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pos == 1)
            {
                constr = "server = localhost;User Id = root;password = wangxiyu;Database = data";
                mycon = new MySqlConnection(constr);
                try
                {
                    mycon.Open();
                }
                catch
                {
                    if(mycon!=null)
                    {
                        mycon.Close();
                    }
                }
                finally
                {
                    try
                    {
                        sql = "select * from alarm where FLAGS = '0'";
                        mycmd = new MySqlCommand(sql, mycon);
                        reader = mycmd.ExecuteReader();
                        while (reader.Read())
                        {
                            iD = reader[0].ToString();
                            carID = reader[1].ToString();
                            temMax = reader[2].ToString();
                            temMin = reader[3].ToString();
                            Send(carID, temMax, temMin);
                        }
                        if (reader != null)
                        {
                            reader.Close();
                        }
                        if (mycmd != null)
                        {
                            mycmd.Dispose();
                        }
                        sql = "UPDATE alarm SET FLAGS = 1 WHERE ID='" + iD + "'";
                        mycmd = new MySqlCommand(sql, mycon);
                        mycmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        if(reader!=null)
                        {
                            reader.Close();
                        }
                        if(mycmd!=null)
                        {
                            mycmd.Dispose();
                        }
                        if (mycon != null)
                        {
                            mycon.Close();
                        }
                    }
                    finally
                    {
                        if (reader != null)
                        {
                            reader.Close();
                        }
                        if (mycmd != null)
                        {
                            mycmd.Dispose();
                        }
                        if (mycon != null)
                        {
                            mycon.Close();
                        }
                        sql = null;
                        mycmd = null;
                        reader = null;
                        mycon = null;
                  
                        iD = null;
                        carID = null;
                        temMax = null;
                        temMin = null;
                    }
                }
            }
        }

        /// <summary>
       /// 发送函数
       /// </summary>
       /// <param name="carID">汽车号</param>
       /// <param name="temMax">温度上限</param>
       /// <param name="temMin">温度下限</param>
        private void Send(string carID,string temMax,string temMin)
        {
            sendString = carID + "," + temMax + "," + temMin;
            sendByte = System.Text.Encoding.Default.GetBytes(sendString);
            networkStream.Write(sendByte, 0, sendByte.Length);
            Array.Clear(sendByte, 0, sendByte.Length);
            sendString = null;
        }

        /// <summary>
        /// 开机自起
        /// </summary>
        private void OpenWin()
        {
            try
            {
                string starupPath = Application.ExecutablePath;
                RegistryKey local = Registry.LocalMachine;
                RegistryKey run = local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                try
                {
                    run.SetValue("WinForm", starupPath);
                    local.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }

        /// <summary>
        /// 信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSearch_Click_1(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.Show();
        }
    }
}
