using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using RJPK.ADO;
using System.IO;

namespace RJPK
{
    public partial class DC : Form
    {
        CourseAdo courseAdo = new CourseAdo();

        public DC()
        {
            InitializeComponent();
        }

        private void btn_SelectExcel_Click(object sender, EventArgs e)
        {
//             OpenFileDialog openExcel = new OpenFileDialog();//实例化打开对话框对象
//             openExcel.Filter = "Excel文件|*.xls";//设置打开文件筛选器
//             openExcel.Multiselect = false;//设置打开对话框中不能多选
//             if (openExcel.ShowDialog() == DialogResult.OK)//判断是否选择了文件
//             {
//                 txt_Excel.Text = openExcel.FileName;//显示选择的Excel文件
//             }
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Excel.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(txt_Excel.Text + @"\data.xls"))
                {
                    FileInfo f = new FileInfo("" + Application.StartupPath + @"\data.xls");
                    f.CopyTo(txt_Excel.Text + @"\data.xls");
                }

                String dcPath = txt_Excel.Text + @"\data.xls";  //导出路径

                string sql_id = "SELECT TOP 1 * FROM History ORDER BY ID DESC";
                DataSet ds_id = courseAdo.GetCourseInfo(sql_id);

                string P_str_Con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\data.mdb;Persist Security Info=True";//记录连接Access的语句
                string P_str_Sql = "";//存储要执行的SQL语句
                OleDbConnection oledbcon = new OleDbConnection(P_str_Con);//实例化OLEDB连接对象
                OleDbCommand oledbcom;//定义OleDbCommand对象
                oledbcon.Open();//打开数据库连接
                //向Excel工作表中导入数据
                for (int flags = 1; flags <= Convert.ToInt32(ds_id.Tables[0].Rows[0][0]); flags++)
                {
/*                    P_str_Sql = @"select * into [Excel 8.0;database=" + txt_Excel.Text + "]." + "[" + flags + "] from History where ID = '" + flags + "'";//记录连接Excel的语句*/
                    P_str_Sql = @"select 课程代码,课程名称,班级,班级人数,讲课学时,实验学时,实践学时,理论合班系数,理论重复课系数,理论公式,理论教分,实验公式,实验教分,实践公式,实践教分,教分,总计 into [Excel 8.0;database=" + dcPath + "]." + "[" + flags + "] from History where ID = '" + flags + "'";//记录连接Excel的语句
                    oledbcom = new System.Data.OleDb.OleDbCommand(P_str_Sql, oledbcon);//实例化OleDbCommand对象
                    oledbcom.ExecuteNonQuery();//执行SQL语句，将数据表的内容导入到Excel中
                }
                oledbcon.Close();//关闭数据库连接
                oledbcon.Dispose();//释放资源
                MessageBox.Show("导出成功！数据已导出到" + dcPath + "路径下！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
/*                MessageBox.Show("请注意Excel文件是否正在使用或者Excel文件中已存在预导出工作表！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                MessageBox.Show(ex.Message, "导出");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
