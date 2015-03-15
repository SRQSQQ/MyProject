using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JWGZ
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }
        public frmDetail(String t_name, String term)
        {
            InitializeComponent();
            String gboxText = term + "-"+ t_name;
            gboxT_detail.Text = gboxText;
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            try
            {
                String term = gboxT_detail.Text.Substring(0, 5);
                String t_name = gboxT_detail.Text.Substring(6, 3);

                String ConStr = string.Format(//设置数据库连接字符串
    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\历史.mdb");
                OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
                OleDbDataAdapter oleDap = new OleDbDataAdapter(//创建数据适配器对象
                    "select * from " + term + " where 姓名 LIKE '%" + t_name + "%'", oleCon);
                DataSet ds = new DataSet();//创建数据集
                oleDap.Fill(ds, "" + term + "");//填充数据集
                this.DgvDetail.DataSource =//设置数据源
        ds.Tables[0].DefaultView;
                DgvDetail.Columns["ID"].Visible = false;
                oleCon.Close();//关闭数据库连接
                oleCon.Dispose();//释放连接资源
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注意");
            }
        }
    }
}
