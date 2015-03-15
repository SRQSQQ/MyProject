using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RJPK.DB
{
    public class DbCommon
    {
//         String ConStr = string.Format(//设置数据库连接字符串
// @"Provider=Microsoft.Jet.OLEDB.4.0;Data source='E:\visual studio 2010\Projects\RJPK\RJPK\bin\Debug\data.mdb'");        

        String ConStr = string.Format(//设置数据库连接字符串
@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\data.mdb");
        /* ************************************
        * DataSet GetDataSet(String sql, String table)
        * 功能	    连接数据库并查询，将查询结果填充到DataSet中
        *			并返回
        * 参数	    sql，查询数据库中表的SQL语句
        *			table，要查询数据库的的表
        * 返回值	将填充了数据库中表的DataSet数据集ds返回
        **************************************/
        public DataSet GetDataSet(String sql, String table)
        {
            OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
            oleCon.Open();
            OleDbDataAdapter oleDap = new OleDbDataAdapter(//创建数据适配器对象
                sql, oleCon);
            DataSet ds = new DataSet();//创建数据集
            oleDap.Fill(ds, table);//填充数据集
            oleCon.Close();//关闭数据库连接
            oleCon.Dispose();//释放连接资源
            return ds;
        }

        /* ************************************
        * void ExcuteUpdateTable(String sql)
        * 功能	    连接数据库,执行操作数据库的SQL语句
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	无返回值
        **************************************/
        public void ExcuteUpdateTable(String sql)
        {
            try
            {
                OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
                oleCon.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oleCon;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                oleCon.Close();//关闭数据库连接
                oleCon.Dispose();//释放连接资源
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "连接数据库");
            }
        }
    }
}
