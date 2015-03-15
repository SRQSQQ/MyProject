using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class ExperimentAdo
    {
        DbCommon dbcommon = new DbCommon();
        /* ************************************
        * DataSet GetExperiment()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetExperiment()
        {
            DataSet ds = new DataSet();
            String sql = "select * from experiment";
            String table = "experiment";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectExperiment(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectExperiment方法，
        *			将SelectExperiment方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectExperiment方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectExperiment(String sql)
        {
            DataSet ds = new DataSet();
            String table = "experiment";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }
        /* ************************************
        * void DeleteExperiment(String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id，key的值    
        * 返回值	无返回值
        **************************************/
        public void DeleteExperiment(String key, String id)
        {
            String sql = "delete from experiment where " + key + " = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateExperiment(String id, String t_id, String t_name, String rank, String exp_ori, String exp_point, String depart_name, String term)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, rank, exp_ori, exp_point, depart_name, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateExperiment(String id, String t_id, String t_name, String rank, String exp_ori, String exp_point, String depart_name, String term)
        {
            String sql = "update experiment set 教师ID = '" + t_id + "',教师名 = '"
                + t_name + "',职称 = '" + rank + "',实验原始 = '"+ exp_ori + "',实验教分 = '"
                + exp_point + "',开课院系 = '"+ depart_name + "',学期 = '"
                + term + "' where ID = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertExperiment(String id, String t_id, String t_name, String rank, String exp_ori, String exp_point, String depart_name, String term)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, rank, exp_ori, exp_point, depart_name, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertExperiment(String id, String t_id, String t_name, String rank, String exp_ori, String exp_point, String depart_name, String term)
        {
            String sql = "insert into experiment values('" + id + "','" + t_id + "','" + t_name + "','" + rank + "','" + exp_ori + "','" + exp_point + "','" + depart_name + "','" + term + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
