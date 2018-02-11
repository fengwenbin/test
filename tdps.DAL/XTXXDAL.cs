using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类XTXXDAL。
	/// </summary>
	public class XTXXDAL
	{
		public XTXXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from XTXX");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.XTXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XTXX(");
			strSql.Append("FSRQ,ZT,LR,XXLX)");
			strSql.Append(" values (");
			strSql.Append("@FSRQ,@ZT,@LR,@XXLX)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FSRQ", DbType.String,20),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@LR", DbType.String),
					new SQLiteParameter("@XXLX", DbType.String,4)};
			parameters[0].Value = model.FSRQ;
			parameters[1].Value = model.ZT;
			parameters[2].Value = model.LR;
			parameters[3].Value = model.XXLX;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.XTXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XTXX set ");
			strSql.Append("FSRQ=@FSRQ,");
			strSql.Append("ZT=@ZT,");
			strSql.Append("LR=@LR,");
			strSql.Append("XXLX=@XXLX");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@FSRQ", DbType.String,20),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@LR", DbType.String),
					new SQLiteParameter("@XXLX", DbType.String,4)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.FSRQ;
			parameters[2].Value = model.ZT;
			parameters[3].Value = model.LR;
			parameters[4].Value = model.XXLX;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from XTXX ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.XTXX GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,FSRQ,ZT,LR,XXLX from XTXX ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			tdps.Model.XTXX model=new tdps.Model.XTXX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				model.FSRQ=ds.Tables[0].Rows[0]["FSRQ"].ToString();
				model.ZT=ds.Tables[0].Rows[0]["ZT"].ToString();
				model.LR=ds.Tables[0].Rows[0]["LR"].ToString();
				model.XXLX=ds.Tables[0].Rows[0]["XXLX"].ToString();
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
			strSql.Append("select FID,FSRQ,ZT,LR,XXLX ");
			strSql.Append(" FROM XTXX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

