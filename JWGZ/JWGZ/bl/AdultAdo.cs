using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class AdultAdo
    {
        DbCommon dbcommon = new DbCommon();

        /* ************************************
         * DataSet GetAdult()
         * 功能	    将查询数据库的SQL语句传递给GetAdult方法，
         *			将GetAdult方法的查询结果返回
         * 参数	    无参数
         * 返回值	将GetRank方法返回的的查询结果DataSet数据集ds
         *          返回
         **************************************/
        public DataSet GetAdult()
        {
            DataSet ds = new DataSet();
            String sql = "select * from adult";
            String table = "adult";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectAdult(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectAdult方法，
        *			将SelectAdult方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectAdult方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectAdult(String sql)
        {
            DataSet ds = new DataSet();
            String table = "adult";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }
    }
}
