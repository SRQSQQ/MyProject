using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class TeacherAdo
    {
        DbCommon dbcommon = new DbCommon();

        /* ************************************
        * DataSet GetTeacher()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetTeacher()
        {
            DataSet ds = new DataSet();
            String sql = "select * from teacher";
            String table = "teacher";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectTeacher(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectTeacher方法，
        *			将SelectTeacher方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectTeacher方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectTeacher(String sql)
        {
            DataSet ds = new DataSet();
            String table = "teacher";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteTeacher(String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id，key的值
        * 返回值	无返回值
        **************************************/
        public void DeleteTeacher(String id)
        {
            String sql = "delete from teacher where 教师ID = '" + id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateTeacher(String t_id, String t_name, String depart, String rank,
        *   String card_id, String status, String school)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    t_id, t_name, depart, rank, card_id, status, school
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateTeacher(String t_id, String t_name, String depart, String rank,
            String card_id, String status, String school)
        {
            String sql = "update teacher set 教师名 = '" + t_name + "',系 = '"
                + depart + "',职称 = '" + rank + "',身份证号 = '" + card_id + "',状态 = '"
                + status + "',学院 = '" + school + "' where 教师ID = '" + t_id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertTeacher(String t_id, String t_name, String depart, String rank,
        *   String card_id, String status, String school)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    t_id, t_name, depart, rank, card_id, status, school
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertTeacher(String t_id, String t_name, String depart, String rank,
            String card_id, String status, String school)
        {
            String sql = "insert into teacher values('" + t_id + "','" + t_name + "','"
                + depart + "','" + rank + "','" + card_id + "','"+ status + "','" + school + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
