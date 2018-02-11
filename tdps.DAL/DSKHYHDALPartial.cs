using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DSKHYHDAL。
	/// </summary>
	public partial class DSKHYHDAL
	{

		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.DSKHYH model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DSKHYH(");
			strSql.Append("KHZH,NSRSBH,KHYHZL,KHYH)");
			strSql.Append(" values (");
			strSql.Append("@KHZH,@NSRSBH,@KHYHZL,@KHYH)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@KHZH", DbType.String,25),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@KHYHZL", DbType.String,4),
					new SQLiteParameter("@KHYH", DbType.String,30)};
			parameters[0].Value = model.KHZH;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.KHYHZL;
			parameters[3].Value = model.KHYH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.DSKHYH model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DSKHYH set ");
			strSql.Append("KHYHZL=@KHYHZL,");
			strSql.Append("KHYH=@KHYH");
			strSql.Append(" where KHZH=@KHZH and NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@KHZH", DbType.String,25),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@KHYHZL", DbType.String,4),
					new SQLiteParameter("@KHYH", DbType.String,30)};
			parameters[0].Value = model.KHZH;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.KHYHZL;
			parameters[3].Value = model.KHYH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete( string NSRSBH, object trans)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DSKHYH ");
			strSql.Append(" where  NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}


		#endregion  成员方法
	}
}

