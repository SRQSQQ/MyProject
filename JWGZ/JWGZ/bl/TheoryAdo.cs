using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class TheoryAdo
    {
        DbCommon dbcommon = new DbCommon();
        /* ************************************
        * DataSet GetTheory()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetTheory()
        {
            DataSet ds = new DataSet();
            String sql = "select ID,课程号,课程名称,开课院系,主讲教师号,主讲教师姓名,主讲教师职称,合班,讲课学时,选课人数,折合教分,学期 from theoryCourse";
            String table = "theoryCourse";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectTheory(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectTheory方法，
        *			将SelectTheory方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectTheory方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectTheory(String sql)
        {
            DataSet ds = new DataSet();
            String table = "theoryCourse";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteTheory(String key,String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    key，数据库中表的主键属性，SQL语句中删除表的条件where
        *           id，key的值
        * 返回值	无返回值
        **************************************/
        public void DeleteTheory(String key, String id)
        {
            String sql = "delete from theoryCourse where " + key + " = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateTheory(String id, String course_id, String cousre_seq, String course_name, String open_dep,           *String t_id, String teach_name, String rank, String teach_class, String teach_hour, String teach_number,          *String number_weight, String course_weight, String desc_weight, String rank_weight, String spe_weight,            *String qua_weight, String cal_weight, String teach_point, String term)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, course_id, cousre_seq, course_name, open_dep, t_id, teach_name, rank, teach_class,                 *teach_hour, teach_number, number_weight, course_weight, desc_weight, rank_weight, spe_weight, qua_weight,         *cal_weight, teach_point, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateTheory(String id, String course_id, String course_name, String open_dep, String t_id, String teach_name, String rank, String teach_class, String teach_hour, String teach_number, String teach_point, String term)
        {
            String sql = "update theoryCourse set 课程号 = '" + course_id + "',课程名称 = '" + course_name + "',开课院系 = '" + open_dep + "',主讲教师号 = '" + t_id + "',主讲教师姓名 = '" + teach_name + "' ,主讲教师职称 = '" + rank + "',合班 = '" + teach_class + "',讲课学时 = '" + teach_hour + "',选课人数 = '" + teach_number + "',折合教分 = '" + teach_point + "',学期 = '" + term + "' where ID = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertTheory(String id, String course_id, String cousre_seq, String course_name, String open_dep,           *String t_id, String teach_name, String rank, String teach_class, String teach_hour, String teach_number,          *String number_weight, String course_weight, String desc_weight, String rank_weight, String spe_weight,            *String qua_weight, String cal_weight, String teach_point, String term)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, course_id, cousre_seq, course_name, open_dep, t_id, teach_name, rank, teach_class,                 *teach_hour, teach_number, number_weight, course_weight, desc_weight, rank_weight, spe_weight, qua_weight,         *cal_weight, teach_point, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertTheory(String id, String course_id, String cousre_seq, String course_name, String open_dep, String t_id, String teach_name, String rank, String teach_class, String teach_hour, String teach_number, String number_weight, String course_weight, String desc_weight, String rank_weight, String spe_weight, String qua_weight, String cal_weight, String teach_point, String term)
        {
            String sql = "insert into theoryCourse values(" + id + ",'" + course_id + "','" + cousre_seq + "','" + course_name + "','" + open_dep + "','" + t_id + "','" + teach_name + "','" + rank + "','" + teach_class + "','" + teach_hour + "','" + teach_number + "','" + number_weight + "','" + course_weight + "','" + desc_weight + "','" + rank_weight + "','" + spe_weight + "','" + qua_weight + "','" + cal_weight + "','" + teach_point + "','" + term + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
