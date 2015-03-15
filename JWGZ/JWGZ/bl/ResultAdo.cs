using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class ResultAdo
    {
        DbCommon dbcommon = new DbCommon();
        /* ************************************
        * DataSet GetResult()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetResult()
        {
            DataSet ds = new DataSet();
            String sql = "select ID,教师号,姓名,职称,硕导,学院,系,身份证号,总计,学期 from result";
            String table = "result";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectResult(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectResult方法，
        *			将SelectResult方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectResult方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectResult(String sql)
        {
            DataSet ds = new DataSet();
            String table = "result";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteResult(String key,String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    key，数据库中表的主键属性，SQL语句中删除表的条件where
        *           id，key的值
        * 返回值	无返回值
        **************************************/
        public void DeleteResult(String key, String id)
        {
            String sql = "delete from result where " + key + " = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateResult(String id, String t_id, String t_name, String rank, String is_tutor, String school, String depart, String card_id, String point_sum, String term)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, rank, is_tutor, school, depart, card_id, point_sum, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateResult(String id, String t_id, String t_name, String rank, String is_tutor, String school, String depart, String card_id, String point_sum, String term)
        {
            String sql = "update result set 教师号 = '" + t_id + "',姓名 = '" + t_name + "',职称 = '" + rank + "',硕导 = '" + is_tutor + "',学院 = '" + school + "' ,系 = '" + depart + "',身份证号 = '" + card_id + "',总计 = '" + point_sum + "',学期 = '" + term + "' where ID = " + id + "";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertResult(String id, String t_id, String t_name, String rank, String is_tutor, String school,                       String depart, String card_id, String mas_hour, String mas_point, String tut_point, String                        goal_point, String adult_point, String teach_hour, String teach_point, String prac_week,                          String prac_point, String dean_point, String exp_ori, String exp_point, String                                    exp_allow_point, String point_sum, String term)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id, t_id, t_name, rank, is_tutor, school, depart, card_id, mas_hour, mas_point, tut_point,                        goal_point, adult_point, teach_hour, teach_point, prac_week, prac_point, dean_point, exp_ori,                     exp_point, exp_allow_point, point_sum, term
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertResult(String id, String t_id, String t_name, String rank, String is_tutor, String school, String depart, String card_id, String mas_hour, String mas_point, String tut_point, String goal_point, String adult_point, String teach_hour, String teach_point, String prac_week, String prac_point, String dean_point, String exp_ori, String exp_point, String exp_allow_point, String point_sum, String term)
        {
            String sql = "insert into result values(" + id + ",'" + t_id + "','" + t_name + "','" + rank + "','" + is_tutor + "','" + school + "','" + depart + "','" + card_id + "','" + mas_hour + "','" + mas_point + "','" + tut_point + "','" + goal_point + "','" + adult_point + "','" + teach_hour + "','" + teach_point + "','" + prac_week + "','" + prac_point + "','" + dean_point + "','" + exp_ori + "','" + exp_point + "','" + exp_allow_point + "','" + point_sum + "','" + term + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
