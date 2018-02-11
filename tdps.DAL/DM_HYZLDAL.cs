using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_HYZLDAL。
	/// </summary>
	public class DM_HYZLDAL
	{
		public DM_HYZLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hyzl_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(hyzl_dm) from DM_HYZL");
			strSql.Append(" where hyzl_dm=@hyzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyzl_dm", DbType.String,10)};
			parameters[0].Value = hyzl_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYZL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_HYZL(");
			strSql.Append("hyzl_dm,hyzl_mc,hyzl_jc,hydl_dm,xybz)");
			strSql.Append(" values (");
			strSql.Append("@hyzl_dm,@hyzl_mc,@hyzl_jc,@hydl_dm,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyzl_dm", DbType.String,4),
					new SQLiteParameter("@hyzl_mc", DbType.String,40),
					new SQLiteParameter("@hyzl_jc", DbType.String,40),
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hyzl_dm;
			parameters[1].Value = model.hyzl_mc;
			parameters[2].Value = model.hyzl_jc;
			parameters[3].Value = model.hydl_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYZL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_HYZL set ");
			strSql.Append("hyzl_mc=@hyzl_mc,");
			strSql.Append("hyzl_jc=@hyzl_jc,");
			strSql.Append("hydl_dm=@hydl_dm,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where hyzl_dm=@hyzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyzl_dm", DbType.String,4),
					new SQLiteParameter("@hyzl_mc", DbType.String,40),
					new SQLiteParameter("@hyzl_jc", DbType.String,40),
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hyzl_dm;
			parameters[1].Value = model.hyzl_mc;
			parameters[2].Value = model.hyzl_jc;
			parameters[3].Value = model.hydl_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hyzl_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_HYZL ");
			strSql.Append(" where hyzl_dm=@hyzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyzl_dm", DbType.String,10)};
			parameters[0].Value = hyzl_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYZL GetModel(string hyzl_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select hyzl_dm,hyzl_mc,hyzl_jc,hydl_dm,xybz from DM_HYZL ");
			strSql.Append(" where hyzl_dm=@hyzl_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hyzl_dm", DbType.String,10)};
			parameters[0].Value = hyzl_dm;

			tdps.Model.DM_HYZL model=new tdps.Model.DM_HYZL();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.hyzl_dm=ds.Tables[0].Rows[0]["hyzl_dm"].ToString();
				model.hyzl_mc=ds.Tables[0].Rows[0]["hyzl_mc"].ToString();
				model.hyzl_jc=ds.Tables[0].Rows[0]["hyzl_jc"].ToString();
				model.hydl_dm=ds.Tables[0].Rows[0]["hydl_dm"].ToString();
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
			strSql.Append("select hyzl_dm,hyzl_mc,hyzl_jc,hydl_dm,xybz ");
			strSql.Append(" FROM DM_HYZL ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

