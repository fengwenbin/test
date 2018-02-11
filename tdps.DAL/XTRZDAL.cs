using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类XTRZDAL。
	/// </summary>
	public class XTRZDAL
	{
		public XTRZDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int XH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(XH) from XTRZ");
			strSql.Append(" where XH=@XH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XH", DbType.Int32,4)};
			parameters[0].Value = XH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.XTRZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XTRZ(");
			strSql.Append("LR,RQ)");
			strSql.Append(" values (");
			strSql.Append("@LR,@RQ)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@LR", DbType.String),
					new SQLiteParameter("@RQ", DbType.String,20)};
			parameters[0].Value = model.LR;
			parameters[1].Value = model.RQ;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.XTRZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XTRZ set ");
			strSql.Append("LR=@LR,");
			strSql.Append("RQ=@RQ");
			strSql.Append(" where XH=@XH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XH", DbType.Int32,4),
					new SQLiteParameter("@LR", DbType.String),
					new SQLiteParameter("@RQ", DbType.String,20)};
			parameters[0].Value = model.XH;
			parameters[1].Value = model.LR;
			parameters[2].Value = model.RQ;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int XH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from XTRZ ");
			strSql.Append(" where XH=@XH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XH", DbType.Int32,4)};
			parameters[0].Value = XH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.XTRZ GetModel(int XH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XH,LR,RQ from XTRZ ");
			strSql.Append(" where XH=@XH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XH", DbType.Int32,4)};
			parameters[0].Value = XH;

			tdps.Model.XTRZ model=new tdps.Model.XTRZ();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["XH"].ToString()!="")
				{
					model.XH=int.Parse(ds.Tables[0].Rows[0]["XH"].ToString());
				}
				model.LR=ds.Tables[0].Rows[0]["LR"].ToString();
				model.RQ=ds.Tables[0].Rows[0]["RQ"].ToString();
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
			strSql.Append("select XH,LR,RQ ");
			strSql.Append(" FROM XTRZ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

