using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class Dean_allowanceAdo
    {
        DbCommon dbcommon = new DbCommon();
        /* ************************************
        * DataSet GetDean_allowance()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetDean_allowance()
        {
            DataSet ds = new DataSet();
            String sql = "select * from dean_allowance";
            String table = "dean_allowance";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectDean_allowance(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectDean_allowance方法，
        *			将SelectDean_allowance方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectDean_allowance方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectDean_allowance(String sql)
        {
            DataSet ds = new DataSet();
            String table = "dean_allowance";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteDean_allowance(String key,String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    key，数据库中表的主键属性，SQL语句中删除表的条件where
        *           id，key的值
        * 返回值	无返回值
        **************************************/
        public void DeleteDean_allowance(String key, String id)
        {
            String sql = "delete from dean_allowance where " + key + " = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateDean_allowance(String id, String t_id, String t_name, String exp_allow_point, String statement, String term)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, exp_allow_point, statement, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateDean_allowance(String id, String t_id, String t_name, String exp_allow_point, String statement, String term)
        {
            String sql = "update dean_allowance set 教师ID = '" + t_id + "',教师名 = '" + t_name + "',教分 = '" + exp_allow_point + "',说明 = '" + statement + "',学期 = '" + term + "' where ID = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertDean_allowance(String id, String t_id, String t_name, String exp_allow_point, String statement, String term)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, exp_allow_point, statement, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertDean_allowance(String id, String t_id, String t_name, String exp_allow_point, String statement, String term)
        {
            String sql = "insert into dean_allowance values(" + id + ",'" + t_id + "','" + t_name + "','" + exp_allow_point + "','" + statement + "','" + term + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
