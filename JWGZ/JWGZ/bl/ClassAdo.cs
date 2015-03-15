using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class ClassAdo
    {
        DbCommon dbcommon = new DbCommon();

        /* ************************************
         * DataSet GetClass()
         * 功能	    将查询数据库的SQL语句传递给GetClass方法，
         *			将GetClass方法的查询结果返回
         * 参数	    无参数
         * 返回值	将GetClass方法返回的的查询结果DataSet数据集ds
         *          返回
         **************************************/
        public DataSet GetClass()
        {
            DataSet ds = new DataSet();
            String sql = "select * from class";
            String table = "class";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectClass(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectClass方法，
        *			将SelectClass方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectClass方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectClass(String sql)
        {
            DataSet ds = new DataSet();
            String table = "class";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteClass(String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id，key的值    
        * 返回值	无返回值
        **************************************/
        public void DeleteClass(String id)
        {
            String sql = "delete from class where  班级ID = '" + id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateClass(String class_id, String class_name, String school, String discipline, String                    * enter_year,String graduate_year, String number)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    class_id, class_name, school, discipline, enter_year, graduate_year, number
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateClass(String class_id, String class_name, String school)
        {
            String sql = "update class set 班级名 = '" + class_name + "',院系 = '" + school + "' where 班级ID = '" + class_id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }
        /* ************************************
        * void InsertClass(String class_id, String class_name, String school, String discipline, String                    * enter_year,String graduate_year, String number)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    class_id, class_name, school, discipline, enter_year, graduate_year, number
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertClass(String class_id, String class_name, String school)
        {
            String sql = "insert into class values('" + class_id + "','" + class_name + "','" + school + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
