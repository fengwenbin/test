using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类GSKHYHDAL。
	/// </summary>
	public partial class GSKHYHDAL
	{
		public GSKHYHDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NSRSBH,string KHZH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(NSRSBH) from GSKHYH");
			strSql.Append(" where NSRSBH=@NSRSBH and KHZH=@KHZH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50),
					new SQLiteParameter("@KHZH", DbType.String,50)};
			parameters[0].Value = NSRSBH;
			parameters[1].Value = KHZH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.GSKHYH model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.GSKHYH model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH,string KHZH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GSKHYH ");
			strSql.Append(" where NSRSBH=@NSRSBH and KHZH=@KHZH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50),
					new SQLiteParameter("@KHZH", DbType.String,50)};
			parameters[0].Value = NSRSBH;
			parameters[1].Value = KHZH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.GSKHYH GetModel(string NSRSBH,string KHZH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NSRSBH,KHZH,KHYHZL,KHYH,IsDefault,KHYHMC,KHYHZLMC from GSKHYH ");
			strSql.Append(" where NSRSBH=@NSRSBH and KHZH=@KHZH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50),
					new SQLiteParameter("@KHZH", DbType.String,50)};
			parameters[0].Value = NSRSBH;
			parameters[1].Value = KHZH;

			tdps.Model.GSKHYH model=new tdps.Model.GSKHYH();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.KHZH=ds.Tables[0].Rows[0]["KHZH"].ToString();
				model.KHYHZL=ds.Tables[0].Rows[0]["KHYHZL"].ToString();
				model.KHYH=ds.Tables[0].Rows[0]["KHYH"].ToString();
				if(ds.Tables[0].Rows[0]["IsDefault"].ToString()!="")
				{
					model.IsDefault=int.Parse(ds.Tables[0].Rows[0]["IsDefault"].ToString());
				}
				model.KHYHMC=ds.Tables[0].Rows[0]["KHYHMC"].ToString();
				model.KHYHZLMC=ds.Tables[0].Rows[0]["KHYHZLMC"].ToString();
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
            strSql.Append("select NSRSBH,KHYHZL,KHYHZLMC,KHYH,KHYHMC,KHZH,IsDefault,rowid as anum");
			strSql.Append(" FROM GSKHYH ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

