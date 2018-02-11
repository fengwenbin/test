using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_YPXHDAL。
	/// </summary>
	public class DM_YPXHDAL
	{
		public DM_YPXHDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ypxh_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(ypxh_dm) from DM_YPXH");
			strSql.Append(" where ypxh_dm=@ypxh_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ypxh_dm", DbType.String,10)};
			parameters[0].Value = ypxh_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_YPXH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_YPXH(");
			strSql.Append("ypxh_dm,ypxh_mc,bz,xybz)");
			strSql.Append(" values (");
			strSql.Append("@ypxh_dm,@ypxh_mc,@bz,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ypxh_dm", DbType.String,3),
					new SQLiteParameter("@ypxh_mc", DbType.String,20),
					new SQLiteParameter("@bz", DbType.String,50),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.ypxh_dm;
			parameters[1].Value = model.ypxh_mc;
			parameters[2].Value = model.bz;
			parameters[3].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_YPXH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_YPXH set ");
			strSql.Append("ypxh_mc=@ypxh_mc,");
			strSql.Append("bz=@bz,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where ypxh_dm=@ypxh_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ypxh_dm", DbType.String,3),
					new SQLiteParameter("@ypxh_mc", DbType.String,20),
					new SQLiteParameter("@bz", DbType.String,50),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.ypxh_dm;
			parameters[1].Value = model.ypxh_mc;
			parameters[2].Value = model.bz;
			parameters[3].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string ypxh_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_YPXH ");
			strSql.Append(" where ypxh_dm=@ypxh_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ypxh_dm", DbType.String,10)};
			parameters[0].Value = ypxh_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_YPXH GetModel(string ypxh_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ypxh_dm,ypxh_mc,bz,xybz from DM_YPXH ");
			strSql.Append(" where ypxh_dm=@ypxh_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ypxh_dm", DbType.String,10)};
			parameters[0].Value = ypxh_dm;

			tdps.Model.DM_YPXH model=new tdps.Model.DM_YPXH();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ypxh_dm=ds.Tables[0].Rows[0]["ypxh_dm"].ToString();
				model.ypxh_mc=ds.Tables[0].Rows[0]["ypxh_mc"].ToString();
				model.bz=ds.Tables[0].Rows[0]["bz"].ToString();
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
			strSql.Append("select ypxh_dm,ypxh_mc,bz,xybz ");
			strSql.Append(" FROM DM_YPXH ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

