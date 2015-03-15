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
    public partial class FormPhone : Form
    {
        string carId = null;
        string constr = null;
        MySqlConnection mycon = null;
        MySqlCommand mycmd = null;
        MySqlDataReader reader=null;
        string sql = null;
        object number = null;
        int Number = 0;
        string id = null;

        public FormPhone()
        {
            InitializeComponent();
            Mysql();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxCarNo.Text != "" && textBoxPhono.Text != "")
            {
                constr = "server = localhost;User Id = root;password = 306306306;Database = data";
                mycon = new MySqlConnection(constr);
                try
                {
                    mycon.Open();
                    sql = "update bound set PHONE='" + textBoxPhono.Text + "',FLAGS='1' where CARID= '" + comboBoxCarNo.Text + "'";
                    mycmd = new MySqlCommand(sql, mycon);
                    mycmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                }
                finally
                {
                    if (mycmd != null)
                    {
                        mycmd.Dispose();
                    }
                    if (mycon != null)
                    {
                        mycon.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("车号或手机号不能为空","提示");
            }
            Mysql();
        }
        private void Mysql()
        {
            comboBoxCarNo.Items.Clear(); 
            constr = "server = localhost;User Id = root;password = 306306306;Database = data";
            mycon = new MySqlConnection(constr);
            try
            {
                mycon.Open();
                sql = "select CARID from bound where FLAGS = '0'";
                mycmd = new MySqlCommand(sql, mycon);
                reader = mycmd.ExecuteReader();
                while (reader.Read())
                {
                    carId = reader[0].ToString();
                    comboBoxCarNo.Items.Add(carId);
                }
            }
            catch
            {}
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
            }
        }
    }
}
