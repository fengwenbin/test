using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using System.Data;

namespace tdps.DAL
{
    public class PrintHistoryDAL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.PrintHistory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PrintHistory(");
            strSql.Append("SbxxID,PrintUser,PrintTime,Items)");
            strSql.Append(" values (");
            strSql.Append("@SbxxID,@PrintUser,@PrintTime,@Items)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SbxxID", DbType.Int32,4),
					new SQLiteParameter("@PrintUser", DbType.String,40),
					new SQLiteParameter("@PrintTime", DbType.String,40),
					new SQLiteParameter("@Items", DbType.String,2)};
            parameters[0].Value = model.SbxxID;
            parameters[1].Value = model.PrintUser;
            parameters[2].Value = model.PrintTime;
            parameters[3].Value = model.Items;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SbxxID,PrintUser,PrintTime,Items ");
            strSql.Append(" FROM PrintHistory ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListJoin(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SZ,SBZLMC,PrintUser,PrintTime FROM PrintHistory ,SBXX");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }
    }
}
