using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_HYDAL。
	/// </summary>
	public class DM_HYDAL
	{
		public DM_HYDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hy_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(hy_dm) from DM_HY");
			strSql.Append(" where hy_dm=@hy_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hy_dm", DbType.String,10)};
			parameters[0].Value = hy_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_HY(");
			strSql.Append("hy_dm,hy_mc,hy_jc,hydl_dm,xybz)");
			strSql.Append(" values (");
			strSql.Append("@hy_dm,@hy_mc,@hy_jc,@hydl_dm,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hy_dm", DbType.String,4),
					new SQLiteParameter("@hy_mc", DbType.String,40),
					new SQLiteParameter("@hy_jc", DbType.String,40),
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hy_dm;
			parameters[1].Value = model.hy_mc;
			parameters[2].Value = model.hy_jc;
			parameters[3].Value = model.hydl_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_HY set ");
			strSql.Append("hy_mc=@hy_mc,");
			strSql.Append("hy_jc=@hy_jc,");
			strSql.Append("hydl_dm=@hydl_dm,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where hy_dm=@hy_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hy_dm", DbType.String,4),
					new SQLiteParameter("@hy_mc", DbType.String,40),
					new SQLiteParameter("@hy_jc", DbType.String,40),
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hy_dm;
			parameters[1].Value = model.hy_mc;
			parameters[2].Value = model.hy_jc;
			parameters[3].Value = model.hydl_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hy_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_HY ");
			strSql.Append(" where hy_dm=@hy_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hy_dm", DbType.String,10)};
			parameters[0].Value = hy_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HY GetModel(string hy_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select hy_dm,hy_mc,hy_jc,hydl_dm,xybz from DM_HY ");
			strSql.Append(" where hy_dm=@hy_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hy_dm", DbType.String,10)};
			parameters[0].Value = hy_dm;

			tdps.Model.DM_HY model=new tdps.Model.DM_HY();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.hy_dm=ds.Tables[0].Rows[0]["hy_dm"].ToString();
				model.hy_mc=ds.Tables[0].Rows[0]["hy_mc"].ToString();
				model.hy_jc=ds.Tables[0].Rows[0]["hy_jc"].ToString();
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
			strSql.Append("select hy_dm,hy_mc,hy_jc,hydl_dm,xybz ");
			strSql.Append(" FROM DM_HY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

