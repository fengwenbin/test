using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_HYMXDAL。
	/// </summary>
	public class DM_HYMXDAL
	{
		public DM_HYMXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hymx_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(hymx_dm) from DM_HYMX");
			strSql.Append(" where hymx_dm=@hymx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hymx_dm", DbType.String,10)};
			parameters[0].Value = hymx_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYMX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_HYMX(");
			strSql.Append("hymx_dm,hymx_mc,hymx_jc,hydl_dm,xybz)");
			strSql.Append(" values (");
			strSql.Append("@hymx_dm,@hymx_mc,@hymx_jc,@hydl_dm,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hymx_dm", DbType.String,4),
					new SQLiteParameter("@hymx_mc", DbType.String,40),
					new SQLiteParameter("@hymx_jc", DbType.String,40),
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hymx_dm;
			parameters[1].Value = model.hymx_mc;
			parameters[2].Value = model.hymx_jc;
			parameters[3].Value = model.hydl_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYMX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_HYMX set ");
			strSql.Append("hymx_mc=@hymx_mc,");
			strSql.Append("hymx_jc=@hymx_jc,");
			strSql.Append("hydl_dm=@hydl_dm,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where hymx_dm=@hymx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hymx_dm", DbType.String,4),
					new SQLiteParameter("@hymx_mc", DbType.String,40),
					new SQLiteParameter("@hymx_jc", DbType.String,40),
					new SQLiteParameter("@hydl_dm", DbType.String,2),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.hymx_dm;
			parameters[1].Value = model.hymx_mc;
			parameters[2].Value = model.hymx_jc;
			parameters[3].Value = model.hydl_dm;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hymx_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_HYMX ");
			strSql.Append(" where hymx_dm=@hymx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hymx_dm", DbType.String,10)};
			parameters[0].Value = hymx_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYMX GetModel(string hymx_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select hymx_dm,hymx_mc,hymx_jc,hydl_dm,xybz from DM_HYMX ");
			strSql.Append(" where hymx_dm=@hymx_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@hymx_dm", DbType.String,10)};
			parameters[0].Value = hymx_dm;

			tdps.Model.DM_HYMX model=new tdps.Model.DM_HYMX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.hymx_dm=ds.Tables[0].Rows[0]["hymx_dm"].ToString();
				model.hymx_mc=ds.Tables[0].Rows[0]["hymx_mc"].ToString();
				model.hymx_jc=ds.Tables[0].Rows[0]["hymx_jc"].ToString();
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
			strSql.Append("select hymx_dm,hymx_mc,hymx_jc,hydl_dm,xybz ");
			strSql.Append(" FROM DM_HYMX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

