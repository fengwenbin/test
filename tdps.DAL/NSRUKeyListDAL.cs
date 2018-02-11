using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using tdps.DBUtility;
using System.Data.SQLite;

namespace tdps.DAL
{
    public class NSRUKeyListDAL
    {
        public NSRUKeyListDAL()
		{}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string nsrsbh,string ukeyid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(ukeyid) from NSRUKeyList");
            strSql.Append(" where nsrsbh=@nsrsbh and ukeyid=@ukeyid ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,20),
                    new SQLiteParameter("@ukeyid", DbType.String,20)};
            parameters[0].Value = nsrsbh;
            parameters[1].Value = ukeyid;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRUKeyList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into NSRUKeyList(");
            strSql.Append("nsrsbh,ukeyid)");
            strSql.Append(" values (");
            strSql.Append("@nsrsbh,@ukeyid)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,20),
					new SQLiteParameter("@ukeyid", DbType.String,20)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.UKeyID;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRUKeyList model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into NSRUKeyList(");
            strSql.Append("nsrsbh,ukeyid)");
            strSql.Append(" values (");
            strSql.Append("@nsrsbh,@ukeyid)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,20),
					new SQLiteParameter("@ukeyid", DbType.String,20)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.UKeyID;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nsrsbh,ukeyid ");
            strSql.Append(" FROM NSRUKeyList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        public int Delete(string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRUKeyList");
            if (where.Trim() != "")
            {
                strSql.Append(" where " + where);
            }

            return SQLiteHelper.ExecuteNonQuery(strSql.ToString());
        }

        public int Delete(string where,object tran)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRUKeyList");
            if (where.Trim() != "")
            {
                strSql.Append(" where " + where);
            }

            return SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(),(SQLiteTransaction)tran);
        }
    }
}
