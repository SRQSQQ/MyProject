using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JWGZ.com;

namespace JWGZ.bl
{
    class RankAdo
    {
        DbCommon dbcommon = new DbCommon();

        /* ************************************
         * DataSet GetRank()
         * 功能	    将查询数据库的SQL语句传递给GetRank方法，
         *			将GetRank方法的查询结果返回
         * 参数	    无参数
         * 返回值	将GetRank方法返回的的查询结果DataSet数据集ds
         *          返回
         **************************************/
        public DataSet GetRank()
        {
            DataSet ds = new DataSet();
            String sql = "select * from rank";
            String table = "rank";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * DataSet SelectRank(String sql)
        * 功能	    将查询数据库的SQL语句传递给SelectRank方法，
        *			将SelectRank方法的查询结果返回
        * 参数	    sql，查询数据库中表的SQL语句
        * 返回值	将SelectRank方法返回的的查询结果DataSet数据集ds
        *          返回
        **************************************/
        public DataSet SelectRank(String sql)
        {
            DataSet ds = new DataSet();
            String table = "rank";
            ds = dbcommon.GetDataSet(sql, table);
            return ds;
        }

        /* ************************************
        * void DeleteRank(String id)
        * 功能	    将删除数据库中表的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    id，key的值    
        * 返回值	无返回值
        **************************************/
        public void DeleteRank(String id)
        {
            String sql = "delete from rank where  职称ID = '" + id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void UpdateRank(String rank_id, String rank, String rank_weight)
        * 功能	    将修改数据库中表数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    rank_id, rank, rank_weight
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void UpdateRank(String rank_id, String rank, String rank_weight)
        {
            String sql = "update rank set 职称 = '" + rank + "',职称系数 = '"
                + rank_weight + "' where 职称ID = '" + rank_id + "'";
            dbcommon.ExcuteUpdateTable(sql);
        }

        /* ************************************
        * void InsertDepart(String rank_id, String rank, String rank_weight)
        * 功能	    将向数据库中表插入数据的SQL语句传递给
        *			ExcuteUpdateTable方法
        * 参数	    rank_id, rank, rank_weight
        *           数据库中要操作表的属性 
        * 返回值	无返回值
        **************************************/
        public void InsertRank(String rank_id, String rank, String rank_weight)
        {
            String sql = "insert into rank values('" + rank_id + "','" + rank + "','"
                + rank_weight + "')";
            dbcommon.ExcuteUpdateTable(sql);
        }
    }
}
