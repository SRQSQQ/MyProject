using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class DepartAdo
    {
        DbCommon dbcommon = new DbCommon();

        /* ************************************
        * DataSet GetDepart()
        * 功能	    将查询数据库的SQL语句传递给GetDataSet方法，
        *			将GetDataSet方法的查询结果返回
        * 参数	    无参数
        * 返回值	将GetDataSet方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet GetDepart()
        {
            DataSet ds = new DataSet();
            String sql = "select * from depart";
            String table = "depart";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectDepart(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectDepart方法，
        *			将SelectDepart方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectDepart方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectDepart(String sql)
        {
            DataSet ds = new DataSet();
            String table = "depart";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteDepart(String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id，key的值    
        * 返回值	无返回值
        **************************************/
        public void DeleteDepart(String id)
        {
            String sql = "delete from depart where  系ID = '" + id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateDepart(String depart_id, String depart, String school, String status)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    depart_id, depart, school, status
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateDepart(String depart_id, String depart, String school, String status)
        {
            String sql = "update depart set 系名 = '" + depart + "',院名 = '"
                + school + "',状态 = '" + status + "' where 系ID = '" + depart_id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertDepart(String depart_id, String depart, String school, String status)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    depart_id, depart, school, status
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertDepart(String depart_id, String depart, String school, String status)
        {
            String sql = "insert into depart values('" + depart_id + "','" + depart + "','"
                + school + "','" + status + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
