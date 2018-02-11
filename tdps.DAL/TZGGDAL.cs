using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类TZGGDAL。
	/// </summary>
	public class TZGGDAL
	{
		public TZGGDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from TZGG");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.TZGG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TZGG(");
			strSql.Append("GGBT,FSJG,FSRQ,YDYQ,ZT,GGLR)");
			strSql.Append(" values (");
			strSql.Append("@GGBT,@FSJG,@FSRQ,@YDYQ,@ZT,@GGLR)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GGBT", DbType.String,50),
					new SQLiteParameter("@FSJG", DbType.String,50),
					new SQLiteParameter("@FSRQ", DbType.String,20),
					new SQLiteParameter("@YDYQ", DbType.String,50),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@GGLR", DbType.String)};
			parameters[0].Value = model.GGBT;
			parameters[1].Value = model.FSJG;
			parameters[2].Value = model.FSRQ;
			parameters[3].Value = model.YDYQ;
			parameters[4].Value = model.ZT;
			parameters[5].Value = model.GGLR;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.TZGG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TZGG set ");
			strSql.Append("GGBT=@GGBT,");
			strSql.Append("FSJG=@FSJG,");
			strSql.Append("FSRQ=@FSRQ,");
			strSql.Append("YDYQ=@YDYQ,");
			strSql.Append("ZT=@ZT,");
			strSql.Append("GGLR=@GGLR");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@GGBT", DbType.String,50),
					new SQLiteParameter("@FSJG", DbType.String,50),
					new SQLiteParameter("@FSRQ", DbType.String,20),
					new SQLiteParameter("@YDYQ", DbType.String,50),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@GGLR", DbType.String)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.GGBT;
			parameters[2].Value = model.FSJG;
			parameters[3].Value = model.FSRQ;
			parameters[4].Value = model.YDYQ;
			parameters[5].Value = model.ZT;
			parameters[6].Value = model.GGLR;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TZGG ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.TZGG GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,GGBT,FSJG,FSRQ,YDYQ,ZT,GGLR from TZGG ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			tdps.Model.TZGG model=new tdps.Model.TZGG();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				model.GGBT=ds.Tables[0].Rows[0]["GGBT"].ToString();
				model.FSJG=ds.Tables[0].Rows[0]["FSJG"].ToString();
				model.FSRQ=ds.Tables[0].Rows[0]["FSRQ"].ToString();
				model.YDYQ=ds.Tables[0].Rows[0]["YDYQ"].ToString();
				model.ZT=ds.Tables[0].Rows[0]["ZT"].ToString();
				model.GGLR=ds.Tables[0].Rows[0]["GGLR"].ToString();
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
			strSql.Append("select FID,GGBT,FSJG,FSRQ,YDYQ,ZT,GGLR ");
			strSql.Append(" FROM TZGG ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

