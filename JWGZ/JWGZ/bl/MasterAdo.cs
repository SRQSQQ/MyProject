using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class MasterAdo
    {
        DbCommon dbcommon = new DbCommon();
        /* ************************************
        * DataSet GetMaster()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetMaster()
        {
            DataSet ds = new DataSet();
            String sql = "select * from master";
            String table = "master";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectMaster(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectMaster方法，
        *			将SelectMaster方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectMaster方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectMaster(String sql)
        {
            DataSet ds = new DataSet();
            String table = "master";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteMaster(String key,String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    key，数据库中表的主键属性，SQL语句中删除表的条件where
        *           id，key的值
        * 返回值	无返回值
        **************************************/
        public void DeleteMaster(String key, String id)
        {
            String sql = "delete from master where " + key + " = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateMaster(String id, String t_id, String t_name, String mas_hour, String mas_point, String tut_point, String goal_point, String sum, String is_tutor, String term)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, mas_hour, mas_point, tut_point, goal_point, sum, is_tutor, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateMaster(String id, String t_id, String t_name, String mas_hour, String mas_point, String tut_point, String goal_point, String sum, String is_tutor, String term)
        {
            String sql = "update master set 主讲教师号 = '" + t_id + "',主讲教师姓名 = '" + t_name + "',研究生学时 = '" + mas_hour + "',研究生教分 = '" + mas_point + "',指导教分 = '" + tut_point + "' ,目标教分 = '" + goal_point + "',总教分 = '" + sum + "',硕导 = '" + is_tutor + "',学期 = '" + term + "' where ID = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertMaster(String id, String t_id, String t_name, String mas_hour, String mas_point, String tut_point, String goal_point, String sum, String is_tutor, String term)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, cousre_seq, mas_hour, mas_point, tut_point, goal_point, sum, is_tutor, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertMaster(String id, String t_id, String t_name, String mas_hour, String mas_point, String tut_point, String goal_point, String sum, String is_tutor, String term)
        {
            String sql = "insert into master values(" + id + ",'" + t_id + "','" + t_name + "','" + mas_hour + "','" + mas_point + "','" + tut_point + "','" + goal_point + "','" + sum + "','" + is_tutor + "','" + term + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
