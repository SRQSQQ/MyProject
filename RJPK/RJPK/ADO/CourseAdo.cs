using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RJPK.DB;

namespace RJPK.ADO
{
    class CourseAdo
    {
        DbCommon dbcommon = new DbCommon();

        /* ************************************
        * DataSet GetCourse()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetCourse()
        {
            DataSet ds = new DataSet();
            String sql = "select * from Course";
            String table = "Course";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet GetCourseName()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetCourseName()
        {
            DataSet ds = new DataSet();
            String sql = "select distinct 课程名称 from Course";
            String table = "Course";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet GetCourseInfo(String sql)
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetCourseInfo(String sql)
        {
            DataSet ds = new DataSet();        
            String table = "Course";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void UpdateCourse(String number, String theoryTime, String practiceTime, String                * experimentTime)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    number, theoryTime, practiceTime, experimentTime
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateCoures(String id, String number, String theoryTime, String practiceTime, String experimentTime)
        {
            String sql = "update CourseCal set 班级人数 = '" + number + "',讲课学时 = '"
                + theoryTime + "',实践学时 = '" + practiceTime + "',实验学时 = '" + experimentTime + "' where ID = '" + id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }      
    }
}
