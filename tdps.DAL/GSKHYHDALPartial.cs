using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类GSKHYHDAL。
	/// </summary>
	public partial class GSKHYHDAL
	{
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.GSKHYH model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into GSKHYH(");
            strSql.Append("NSRSBH,KHZH,KHYHZL,KHYH,IsDefault,KHYHMC,KHYHZLMC)");
            strSql.Append(" values (");
            strSql.Append("@NSRSBH,@KHZH,@KHYHZL,@KHYH,@IsDefault,@KHYHMC,@KHYHZLMC)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@KHZH", DbType.String,25),
					new SQLiteParameter("@KHYHZL", DbType.String,4),
					new SQLiteParameter("@KHYH", DbType.String,30),
					new SQLiteParameter("@IsDefault", DbType.Int32,4),
					new SQLiteParameter("@KHYHMC", DbType.String,50),
					new SQLiteParameter("@KHYHZLMC", DbType.String,50)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.KHZH;
            parameters[2].Value = model.KHYHZL;
            parameters[3].Value = model.KHYH;
            parameters[4].Value = model.IsDefault;
            parameters[5].Value = model.KHYHMC;
            parameters[6].Value = model.KHYHZLMC;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.GSKHYH model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update GSKHYH set ");
            strSql.Append("KHYHZL=@KHYHZL,");
            strSql.Append("KHYH=@KHYH,");
            strSql.Append("IsDefault=@IsDefault,");
            strSql.Append("KHYHMC=@KHYHMC,");
            strSql.Append("KHYHZLMC=@KHYHZLMC");
            strSql.Append(" where NSRSBH=@NSRSBH and KHZH=@KHZH ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@KHZH", DbType.String,25),
					new SQLiteParameter("@KHYHZL", DbType.String,4),
					new SQLiteParameter("@KHYH", DbType.String,30),
					new SQLiteParameter("@IsDefault", DbType.Int32,4),
					new SQLiteParameter("@KHYHMC", DbType.String,50),
					new SQLiteParameter("@KHYHZLMC", DbType.String,50)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.KHZH;
            parameters[2].Value = model.KHYHZL;
            parameters[3].Value = model.KHYH;
            parameters[4].Value = model.IsDefault;
            parameters[5].Value = model.KHYHMC;
            parameters[6].Value = model.KHYHZLMC;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH,object trans)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GSKHYH ");
			strSql.Append(" where NSRSBH=@NSRSBH  ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

        /// <summary>
        /// 取消默认
        /// </summary>
        /// <returns></returns>
        public void CancelSFMR(string NSRSBH, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update GSKHYH set IsDefault = 0  where IsDefault= 1 and NSRSBH='" + NSRSBH + "'");
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, null);
        }
		#endregion  成员方法
	}
}

