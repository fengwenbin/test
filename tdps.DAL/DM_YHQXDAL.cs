using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_YHQXDAL。
	/// </summary>
	public class DM_YHQXDAL
	{
		public DM_YHQXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string QXBM)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(QXBM) from DM_YHQX");
			strSql.Append(" where QXBM=@QXBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@QXBM", DbType.String,50)};
			parameters[0].Value = QXBM;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_YHQX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_YHQX(");
			strSql.Append("QXBM,QXMC)");
			strSql.Append(" values (");
			strSql.Append("@QXBM,@QXMC)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@QXBM", DbType.String,4),
					new SQLiteParameter("@QXMC", DbType.String,20)};
			parameters[0].Value = model.QXBM;
			parameters[1].Value = model.QXMC;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_YHQX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_YHQX set ");
			strSql.Append("QXMC=@QXMC");
			strSql.Append(" where QXBM=@QXBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@QXBM", DbType.String,4),
					new SQLiteParameter("@QXMC", DbType.String,20)};
			parameters[0].Value = model.QXBM;
			parameters[1].Value = model.QXMC;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string QXBM)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_YHQX ");
			strSql.Append(" where QXBM=@QXBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@QXBM", DbType.String,50)};
			parameters[0].Value = QXBM;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_YHQX GetModel(string QXBM)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select QXBM,QXMC from DM_YHQX ");
			strSql.Append(" where QXBM=@QXBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@QXBM", DbType.String,50)};
			parameters[0].Value = QXBM;

			tdps.Model.DM_YHQX model=new tdps.Model.DM_YHQX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.QXBM=ds.Tables[0].Rows[0]["QXBM"].ToString();
				model.QXMC=ds.Tables[0].Rows[0]["QXMC"].ToString();
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
			strSql.Append("select QXBM,QXMC ");
			strSql.Append(" FROM DM_YHQX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

