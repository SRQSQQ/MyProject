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
    public partial class FormSearch : Form
    {
        string[] searchNoCar;
        string[] searchYesCar;
        string strCon = null;
        string strCom = null;
        MySqlConnection myCon = null;
        MySqlDataAdapter myData = null;
        DataSet myDataSet = null;
        

        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="空余小车查询")
            {
                SearchNoCar();
            }
            else
            {
                SearchYesCar();
            }
        }

        private void SearchNoCar()
        {
            dataGridViewCar.DataSource = null;
            try
            {
                dataGridViewCar.Rows.Clear();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            try
            {
                strCon = "server = localhost;User Id = root;password = 306306306;Database = data";
                myCon = new MySqlConnection(strCon);
                myCon.Open();
                try
                {
                    strCom = "select CARID from bound where FLAGS = '0'";
                    myData = new MySqlDataAdapter(strCom, myCon);
                    myDataSet = new DataSet();
                    myData.Fill(myDataSet);
                    dataGridViewCar.DataSource = myDataSet.Tables[0];

                    dataGridViewCar.Columns[0].HeaderText = "汽车ID";
                }
                catch
                {
                    MessageBox.Show("请输入正确的选项");
                    if (myData != null)
                    {
                        myData.Dispose();
                    }
                    if (myDataSet != null)
                    {
                        myDataSet.Dispose();
                    }
                    if (myCon != null)
                    {
                        myCon.Close();
                    }
                }
                finally
                {
                    if (myData != null)
                    {
                        myData.Dispose();
                    }
                    if (myDataSet != null)
                    {
                        myDataSet.Dispose();
                    }
                    if (myCon != null)
                    {
                        myCon.Close();
                    }
                }
            }
            catch
            {
                if (myCon != null)
                {
                    myCon.Close();
                }
            }
        }

        private void SearchYesCar()
        {
            dataGridViewCar.DataSource = null;
            try
            {
                dataGridViewCar.Rows.Clear();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            try
            {
                strCon = "server = localhost;User Id = root;password = 306306306;Database = data";
                myCon = new MySqlConnection(strCon);
                myCon.Open();
                try
                {
                    strCom = "select CARID,PHONE from bound where FLAGS = '1'";
                    MySqlDataAdapter mda = new MySqlDataAdapter(strCom, myCon);
                    myDataSet = new DataSet();
                    myData.Fill(myDataSet, "Car");
                    dataGridViewCar.DataMember = "Car";
                    dataGridViewCar.DataSource = myDataSet.Tables[0];

                    dataGridViewCar.Columns[0].HeaderText = "汽车ID";
                    dataGridViewCar.Columns[1].HeaderText = "绑定手机号";
                }
                catch
                {
                    MessageBox.Show("请输入正确的选项");
                    if (myData != null)
                    {
                        myData.Dispose();
                    }
                    if (myDataSet != null)
                    {
                        myDataSet.Dispose();
                    }
                    if (myCon != null)
                    {
                        myCon.Close();
                    }
                }
                finally
                {
                    if (myData != null)
                    {
                        myData.Dispose();
                    }
                    if (myDataSet != null)
                    {
                        myDataSet.Dispose();
                    }
                    if (myCon != null)
                    {
                        myCon.Close();
                    }
                }
            }
            catch
            {
                if (myCon != null)
                {
                    myCon.Close();
                }
            }
        }
    }
}
