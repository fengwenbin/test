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
		public DSKHYHDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string KHZH,string NSRSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(KHZH) from DSKHYH");
			strSql.Append(" where KHZH=@KHZH and NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@KHZH", DbType.String,50),
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = KHZH;
			parameters[1].Value = NSRSBH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DSKHYH model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DSKHYH model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string KHZH,string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DSKHYH ");
			strSql.Append(" where KHZH=@KHZH and NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@KHZH", DbType.String,50),
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = KHZH;
			parameters[1].Value = NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DSKHYH GetModel(string KHZH,string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select KHZH,NSRSBH,KHYHZL,KHYH from DSKHYH ");
			strSql.Append(" where KHZH=@KHZH and NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@KHZH", DbType.String,50),
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = KHZH;
			parameters[1].Value = NSRSBH;

			tdps.Model.DSKHYH model=new tdps.Model.DSKHYH();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.KHZH=ds.Tables[0].Rows[0]["KHZH"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.KHYHZL=ds.Tables[0].Rows[0]["KHYHZL"].ToString();
				model.KHYH=ds.Tables[0].Rows[0]["KHYH"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select KHZH,NSRSBH,KHYHZL,KHYH ");
			strSql.Append(" FROM DSKHYH ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

