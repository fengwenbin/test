using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using System.Data;

namespace tdps.DAL
{
    public partial class XTSZDAL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.XTSZ model,object tran)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into XTSZ(");
            strSql.Append("XTBBH,GXSJ)");
            strSql.Append(" values (");
            strSql.Append("@XTBBH,@GXSJ)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,20),
					new SQLiteParameter("@GXSJ", DbType.String,20)};
            parameters[0].Value = model.XTBBH;
            parameters[1].Value = model.GXSJ;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)tran,parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.XTSZ model,object tran)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update XTSZ set ");
            strSql.Append("GXSJ=@GXSJ");
            strSql.Append(" where XTBBH=@XTBBH ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,20),
					new SQLiteParameter("@GXSJ", DbType.String,20)};
            parameters[0].Value = model.XTBBH;
            parameters[1].Value = model.GXSJ;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)tran, parameters);
        }
        /// <summary>
        /// 删除所有数据
        /// </summary>
        public void Delete(object tran)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from XTSZ");
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)tran, null);
        }
    }
}
