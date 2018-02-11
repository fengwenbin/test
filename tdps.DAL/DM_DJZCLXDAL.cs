using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_DJZCLXDAL。
	/// </summary>
	public class DM_DJZCLXDAL
	{
		public DM_DJZCLXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string djzclx_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(djzclx_dm) from DM_DJZCLX");
			strSql.Append(" where djzclx_dm=@djzclx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djzclx_dm", DbType.String,10)};
			parameters[0].Value = djzclx_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_DJZCLX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_DJZCLX(");
			strSql.Append("djzclx_dm,djzclx_mc,djzclx_zl_dm)");
			strSql.Append(" values (");
			strSql.Append("@djzclx_dm,@djzclx_mc,@djzclx_zl_dm)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djzclx_dm", DbType.String,3),
					new SQLiteParameter("@djzclx_mc", DbType.String,50),
					new SQLiteParameter("@djzclx_zl_dm", DbType.String,3)};
			parameters[0].Value = model.djzclx_dm;
			parameters[1].Value = model.djzclx_mc;
			parameters[2].Value = model.djzclx_zl_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_DJZCLX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_DJZCLX set ");
			strSql.Append("djzclx_mc=@djzclx_mc,");
			strSql.Append("djzclx_zl_dm=@djzclx_zl_dm");
			strSql.Append(" where djzclx_dm=@djzclx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djzclx_dm", DbType.String,3),
					new SQLiteParameter("@djzclx_mc", DbType.String,50),
					new SQLiteParameter("@djzclx_zl_dm", DbType.String,3)};
			parameters[0].Value = model.djzclx_dm;
			parameters[1].Value = model.djzclx_mc;
			parameters[2].Value = model.djzclx_zl_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string djzclx_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_DJZCLX ");
			strSql.Append(" where djzclx_dm=@djzclx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djzclx_dm", DbType.String,10)};
			parameters[0].Value = djzclx_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_DJZCLX GetModel(string djzclx_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select djzclx_dm,djzclx_mc,djzclx_zl_dm from DM_DJZCLX ");
			strSql.Append(" where djzclx_dm=@djzclx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djzclx_dm", DbType.String,10)};
			parameters[0].Value = djzclx_dm;

			tdps.Model.DM_DJZCLX model=new tdps.Model.DM_DJZCLX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.djzclx_dm=ds.Tables[0].Rows[0]["djzclx_dm"].ToString();
				model.djzclx_mc=ds.Tables[0].Rows[0]["djzclx_mc"].ToString();
				model.djzclx_zl_dm=ds.Tables[0].Rows[0]["djzclx_zl_dm"].ToString();
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
			strSql.Append("select djzclx_dm,djzclx_mc,djzclx_zl_dm ");
			strSql.Append(" FROM DM_DJZCLX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

