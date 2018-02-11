using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DYMXDAL。
	/// </summary>
	public partial class DYMXDAL
	{
		public DYMXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SPHM,string JKPZXH,string DYSXH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(SPHM) from DYMX");
			strSql.Append(" where SPHM=@SPHM and JKPZXH=@JKPZXH and DYSXH=@DYSXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50),
					new SQLiteParameter("@JKPZXH", DbType.String,50),
					new SQLiteParameter("@DYSXH", DbType.String,50)};
			parameters[0].Value = SPHM;
			parameters[1].Value = JKPZXH;
			parameters[2].Value = DYSXH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DYMX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DYMX(");
			strSql.Append("SPHM,JKPZXH,DYSXH,NSRSBH)");
			strSql.Append(" values (");
			strSql.Append("@SPHM,@JKPZXH,@DYSXH,@NSRSBH)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,20),
					new SQLiteParameter("@JKPZXH", DbType.String,15),
					new SQLiteParameter("@DYSXH", DbType.String,10),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
			parameters[0].Value = model.SPHM;
			parameters[1].Value = model.JKPZXH;
			parameters[2].Value = model.DYSXH;
			parameters[3].Value = model.NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DYMX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DYMX set ");
			strSql.Append("NSRSBH=@NSRSBH");
			strSql.Append(" where SPHM=@SPHM and JKPZXH=@JKPZXH and DYSXH=@DYSXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,20),
					new SQLiteParameter("@JKPZXH", DbType.String,15),
					new SQLiteParameter("@DYSXH", DbType.String,10),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
			parameters[0].Value = model.SPHM;
			parameters[1].Value = model.JKPZXH;
			parameters[2].Value = model.DYSXH;
			parameters[3].Value = model.NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string SPHM,string JKPZXH,string DYSXH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DYMX ");
			strSql.Append(" where SPHM=@SPHM and JKPZXH=@JKPZXH and DYSXH=@DYSXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50),
					new SQLiteParameter("@JKPZXH", DbType.String,50),
					new SQLiteParameter("@DYSXH", DbType.String,50)};
			parameters[0].Value = SPHM;
			parameters[1].Value = JKPZXH;
			parameters[2].Value = DYSXH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DYMX GetModel(string SPHM,string JKPZXH,string DYSXH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SPHM,JKPZXH,DYSXH,NSRSBH from DYMX ");
			strSql.Append(" where SPHM=@SPHM and JKPZXH=@JKPZXH and DYSXH=@DYSXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50),
					new SQLiteParameter("@JKPZXH", DbType.String,50),
					new SQLiteParameter("@DYSXH", DbType.String,50)};
			parameters[0].Value = SPHM;
			parameters[1].Value = JKPZXH;
			parameters[2].Value = DYSXH;

			tdps.Model.DYMX model=new tdps.Model.DYMX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.SPHM=ds.Tables[0].Rows[0]["SPHM"].ToString();
				model.JKPZXH=ds.Tables[0].Rows[0]["JKPZXH"].ToString();
				model.DYSXH=ds.Tables[0].Rows[0]["DYSXH"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
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
			strSql.Append("select SPHM,JKPZXH,DYSXH,NSRSBH ");
			strSql.Append(" FROM DYMX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

