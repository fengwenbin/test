using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_HYMLDAL。
	/// </summary>
	public class DM_HYMLDAL
	{
		public DM_HYMLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hyml_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(hyml_dm) from DM_HYML");
			strSql.Append(" where hyml_dm=@hyml_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyml_dm", DbType.String,10)};
			parameters[0].Value = hyml_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYML model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_HYML(");
			strSql.Append("hyml_dm,hyml_mc,hyml_jc)");
			strSql.Append(" values (");
			strSql.Append("@hyml_dm,@hyml_mc,@hyml_jc)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyml_dm", DbType.String,2),
					new SQLiteParameter("@hyml_mc", DbType.String,30),
					new SQLiteParameter("@hyml_jc", DbType.String,30)};
			parameters[0].Value = model.hyml_dm;
			parameters[1].Value = model.hyml_mc;
			parameters[2].Value = model.hyml_jc;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYML model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_HYML set ");
			strSql.Append("hyml_mc=@hyml_mc,");
			strSql.Append("hyml_jc=@hyml_jc");
			strSql.Append(" where hyml_dm=@hyml_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyml_dm", DbType.String,2),
					new SQLiteParameter("@hyml_mc", DbType.String,30),
					new SQLiteParameter("@hyml_jc", DbType.String,30)};
			parameters[0].Value = model.hyml_dm;
			parameters[1].Value = model.hyml_mc;
			parameters[2].Value = model.hyml_jc;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hyml_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_HYML ");
			strSql.Append(" where hyml_dm=@hyml_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyml_dm", DbType.String,10)};
			parameters[0].Value = hyml_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYML GetModel(string hyml_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select hyml_dm,hyml_mc,hyml_jc from DM_HYML ");
			strSql.Append(" where hyml_dm=@hyml_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyml_dm", DbType.String,10)};
			parameters[0].Value = hyml_dm;

			tdps.Model.DM_HYML model=new tdps.Model.DM_HYML();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.hyml_dm=ds.Tables[0].Rows[0]["hyml_dm"].ToString();
				model.hyml_mc=ds.Tables[0].Rows[0]["hyml_mc"].ToString();
				model.hyml_jc=ds.Tables[0].Rows[0]["hyml_jc"].ToString();
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
			strSql.Append("select hyml_dm,hyml_mc,hyml_jc ");
			strSql.Append(" FROM DM_HYML ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

