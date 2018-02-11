using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_HYDLDAL。
	/// </summary>
	public class DM_HYDLDAL
	{
		public DM_HYDLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hydl_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(hydl_dm) from DM_HYDL");
			strSql.Append(" where hydl_dm=@hydl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hydl_dm", DbType.String,10)};
			parameters[0].Value = hydl_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYDL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_HYDL(");
			strSql.Append("hydl_dm,hydl_mc,hydl_jc,hyml_dm,xybz)");
			strSql.Append(" values (");
			strSql.Append("@hydl_dm,@hydl_mc,@hydl_jc,@hyml_dm,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@hydl_mc", DbType.String,40),
					new SQLiteParameter("@hydl_jc", DbType.String,40),
					new SQLiteParameter("@hyml_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hydl_dm;
			parameters[1].Value = model.hydl_mc;
			parameters[2].Value = model.hydl_jc;
			parameters[3].Value = model.hyml_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYDL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_HYDL set ");
			strSql.Append("hydl_mc=@hydl_mc,");
			strSql.Append("hydl_jc=@hydl_jc,");
			strSql.Append("hyml_dm=@hyml_dm,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where hydl_dm=@hydl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@hydl_mc", DbType.String,40),
					new SQLiteParameter("@hydl_jc", DbType.String,40),
					new SQLiteParameter("@hyml_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hydl_dm;
			parameters[1].Value = model.hydl_mc;
			parameters[2].Value = model.hydl_jc;
			parameters[3].Value = model.hyml_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hydl_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_HYDL ");
			strSql.Append(" where hydl_dm=@hydl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hydl_dm", DbType.String,10)};
			parameters[0].Value = hydl_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYDL GetModel(string hydl_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select hydl_dm,hydl_mc,hydl_jc,hyml_dm,xybz from DM_HYDL ");
			strSql.Append(" where hydl_dm=@hydl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hydl_dm", DbType.String,10)};
			parameters[0].Value = hydl_dm;

			tdps.Model.DM_HYDL model=new tdps.Model.DM_HYDL();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.hydl_dm=ds.Tables[0].Rows[0]["hydl_dm"].ToString();
				model.hydl_mc=ds.Tables[0].Rows[0]["hydl_mc"].ToString();
				model.hydl_jc=ds.Tables[0].Rows[0]["hydl_jc"].ToString();
				model.hyml_dm=ds.Tables[0].Rows[0]["hyml_dm"].ToString();
				model.xybz=ds.Tables[0].Rows[0]["xybz"].ToString();
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
			strSql.Append("select hydl_dm,hydl_mc,hydl_jc,hyml_dm,xybz ");
			strSql.Append(" FROM DM_HYDL ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

