using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_PZZLDAL。
	/// </summary>
	public class DM_PZZLDAL
	{
		public DM_PZZLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string pzzl_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(pzzl_dm) from DM_PZZL");
			strSql.Append(" where pzzl_dm=@pzzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pzzl_dm", DbType.String,10)};
			parameters[0].Value = pzzl_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_PZZL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_PZZL(");
			strSql.Append("pzzl_dm,pzzl_mc,swws_dm,yspz_dm)");
			strSql.Append(" values (");
			strSql.Append("@pzzl_dm,@pzzl_mc,@swws_dm,@yspz_dm)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pzzl_dm", DbType.String,5),
					new SQLiteParameter("@pzzl_mc", DbType.String,50),
					new SQLiteParameter("@swws_dm", DbType.String,6),
					new SQLiteParameter("@yspz_dm", DbType.String,3)};
			parameters[0].Value = model.pzzl_dm;
			parameters[1].Value = model.pzzl_mc;
			parameters[2].Value = model.swws_dm;
			parameters[3].Value = model.yspz_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_PZZL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_PZZL set ");
			strSql.Append("pzzl_mc=@pzzl_mc,");
			strSql.Append("swws_dm=@swws_dm,");
			strSql.Append("yspz_dm=@yspz_dm");
			strSql.Append(" where pzzl_dm=@pzzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pzzl_dm", DbType.String,5),
					new SQLiteParameter("@pzzl_mc", DbType.String,50),
					new SQLiteParameter("@swws_dm", DbType.String,6),
					new SQLiteParameter("@yspz_dm", DbType.String,3)};
			parameters[0].Value = model.pzzl_dm;
			parameters[1].Value = model.pzzl_mc;
			parameters[2].Value = model.swws_dm;
			parameters[3].Value = model.yspz_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string pzzl_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_PZZL ");
			strSql.Append(" where pzzl_dm=@pzzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pzzl_dm", DbType.String,10)};
			parameters[0].Value = pzzl_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_PZZL GetModel(string pzzl_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select pzzl_dm,pzzl_mc,swws_dm,yspz_dm from DM_PZZL ");
			strSql.Append(" where pzzl_dm=@pzzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pzzl_dm", DbType.String,10)};
			parameters[0].Value = pzzl_dm;

			tdps.Model.DM_PZZL model=new tdps.Model.DM_PZZL();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.pzzl_dm=ds.Tables[0].Rows[0]["pzzl_dm"].ToString();
				model.pzzl_mc=ds.Tables[0].Rows[0]["pzzl_mc"].ToString();
				model.swws_dm=ds.Tables[0].Rows[0]["swws_dm"].ToString();
				model.yspz_dm=ds.Tables[0].Rows[0]["yspz_dm"].ToString();
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
			strSql.Append("select pzzl_dm,pzzl_mc,swws_dm,yspz_dm ");
			strSql.Append(" FROM DM_PZZL ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

