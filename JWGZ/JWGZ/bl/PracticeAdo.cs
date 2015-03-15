using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class PracticeAdo
    {
        DbCommon dbcommon = new DbCommon();
        /* ************************************
        * DataSet GetPractice()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetPractice()
        {
            DataSet ds = new DataSet();
            String sql = "select ID,课程号,课程名称,开课院系,主讲教师号,主讲教师姓名,主讲教师职称,折合教分,学期 from practiceCourse";
            String table = "practiceCourse";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectPractice(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectPractice方法，
        *			将SelectPractice方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectPractice方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectPractice(String sql)
        {
            DataSet ds = new DataSet();
            String table = "practiceCourse";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeletePractice(String key,String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    key，数据库中表的主键属性，SQL语句中删除表的条件where
        *           id，key的值
        * 返回值	无返回值
        **************************************/
        public void DeletePractice(String key, String id)
        {
            String sql = "delete from practiceCourse where " + key + " = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdatePractice(String id, String course_id, String course_name, String open_dep, String t_id, 
        * String teach_name, String rank, String rank_weight, String prac_week, String prac_num, String prac_class,        * String prac_location, String cal_formula, String prac_point, String term)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, course_id, course_name, open_dep, t_id, teach_name, rank, rank_weight,                             * prac_week, prac_num, prac_class, prac_location, cal_formula, prac_point, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdatePractice(String id, String course_id, String course_name, String open_dep, String t_id, String teach_name, String rank, String prac_point, String term)
        {
            String sql = "update practiceCourse set 课程号 = '" + course_id + "',课程名称 = '" + course_name + "',开课院系 = '" + open_dep + "',主讲教师号 = '" + t_id + "',主讲教师姓名 = '" + teach_name + "' ,主讲教师职称 = '" + rank + "',折合教分 = '" + prac_point + "',学期 = '" + term + "' where ID = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertPractice(String id, String course_id, String course_name, String open_dep, String t_id, 
        * String teach_name, String rank, String rank_weight, String prac_week, String prac_num, String prac_class,        * String prac_location, String cal_formula, String prac_point, String term)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, course_id, course_name, open_dep, t_id, teach_name, rank, rank_weight,                             * prac_week, prac_num, prac_class, prac_location, cal_formula, prac_point, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertPractice(String id, String course_id, String course_name, String open_dep, String t_id, String teach_name, String rank, String rank_weight, String prac_week, String prac_num, String prac_class, String prac_location, String cal_formula, String prac_point, String term)
        {
            String sql = "insert into practiceCourse values(" + id + ",'" + course_id + "','" + course_name + "','" + open_dep + "','" + t_id + "','" + teach_name + "','" + rank + "','" + rank_weight + "','" + prac_week + "','" + prac_num + "','" + prac_class + "','" + prac_location + "','" + cal_formula + "','" + prac_point + "','" + term + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
