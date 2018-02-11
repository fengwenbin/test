using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类JKPZDAL。
	/// </summary>
	public partial class JKPZDAL
	{
		public JKPZDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string JKPZXH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(JKPZXH) from JKPZ");
			strSql.Append(" where JKPZXH=@JKPZXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@JKPZXH", DbType.String,50)};
			parameters[0].Value = JKPZXH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.JKPZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JKPZ(");
			strSql.Append("JKPZXH,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,ZSSWJGDM,ZSSWJGMC,PZDYFS,DYSJ,HJJE,FWM,DZYZDATA)");
			strSql.Append(" values (");
			strSql.Append("@JKPZXH,@NSRSBH,@NSRMC,@NSRSWJGDM,@NSRSWJGMC,@ZSSWJGDM,@ZSSWJGMC,@PZDYFS,@DYSJ,@HJJE,@FWM,@DZYZDATA)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@JKPZXH", DbType.String,15),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@NSRSWJGDM", DbType.String,9),
					new SQLiteParameter("@NSRSWJGMC", DbType.String,80),
					new SQLiteParameter("@ZSSWJGDM", DbType.String,9),
					new SQLiteParameter("@ZSSWJGMC", DbType.String,80),
					new SQLiteParameter("@PZDYFS", DbType.String,20),
					new SQLiteParameter("@DYSJ", DbType.String,20),
					new SQLiteParameter("@HJJE", DbType.Decimal,9),
					new SQLiteParameter("@FWM", DbType.String,35),
					new SQLiteParameter("@DZYZDATA", DbType.String,80)};
			parameters[0].Value = model.JKPZXH;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.NSRMC;
			parameters[3].Value = model.NSRSWJGDM;
			parameters[4].Value = model.NSRSWJGMC;
			parameters[5].Value = model.ZSSWJGDM;
			parameters[6].Value = model.ZSSWJGMC;
			parameters[7].Value = model.PZDYFS;
			parameters[8].Value = model.DYSJ;
			parameters[9].Value = model.HJJE;
			parameters[10].Value = model.FWM;
			parameters[11].Value = model.DZYZDATA;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.JKPZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JKPZ set ");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("NSRMC=@NSRMC,");
			strSql.Append("NSRSWJGDM=@NSRSWJGDM,");
			strSql.Append("NSRSWJGMC=@NSRSWJGMC,");
			strSql.Append("ZSSWJGDM=@ZSSWJGDM,");
			strSql.Append("ZSSWJGMC=@ZSSWJGMC,");
			strSql.Append("PZDYFS=@PZDYFS,");
			strSql.Append("DYSJ=@DYSJ,");
			strSql.Append("HJJE=@HJJE,");
			strSql.Append("FWM=@FWM,");
			strSql.Append("DZYZDATA=@DZYZDATA");
			strSql.Append(" where JKPZXH=@JKPZXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@JKPZXH", DbType.String,15),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@NSRSWJGDM", DbType.String,9),
					new SQLiteParameter("@NSRSWJGMC", DbType.String,80),
					new SQLiteParameter("@ZSSWJGDM", DbType.String,9),
					new SQLiteParameter("@ZSSWJGMC", DbType.String,80),
					new SQLiteParameter("@PZDYFS", DbType.String,20),
					new SQLiteParameter("@DYSJ", DbType.String,20),
					new SQLiteParameter("@HJJE", DbType.Decimal,9),
					new SQLiteParameter("@FWM", DbType.String,35),
					new SQLiteParameter("@DZYZDATA", DbType.String,80)};
			parameters[0].Value = model.JKPZXH;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.NSRMC;
			parameters[3].Value = model.NSRSWJGDM;
			parameters[4].Value = model.NSRSWJGMC;
			parameters[5].Value = model.ZSSWJGDM;
			parameters[6].Value = model.ZSSWJGMC;
			parameters[7].Value = model.PZDYFS;
			parameters[8].Value = model.DYSJ;
			parameters[9].Value = model.HJJE;
			parameters[10].Value = model.FWM;
			parameters[11].Value = model.DZYZDATA;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string JKPZXH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JKPZ ");
			strSql.Append(" where JKPZXH=@JKPZXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@JKPZXH", DbType.String,50)};
			parameters[0].Value = JKPZXH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.JKPZ GetModel(string JKPZXH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select JKPZXH,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,ZSSWJGDM,ZSSWJGMC,PZDYFS,DYSJ,HJJE,FWM,DZYZDATA from JKPZ ");
			strSql.Append(" where JKPZXH=@JKPZXH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@JKPZXH", DbType.String,50)};
			parameters[0].Value = JKPZXH;

			tdps.Model.JKPZ model=new tdps.Model.JKPZ();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.JKPZXH=ds.Tables[0].Rows[0]["JKPZXH"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.NSRSWJGDM=ds.Tables[0].Rows[0]["NSRSWJGDM"].ToString();
				model.NSRSWJGMC=ds.Tables[0].Rows[0]["NSRSWJGMC"].ToString();
				model.ZSSWJGDM=ds.Tables[0].Rows[0]["ZSSWJGDM"].ToString();
				model.ZSSWJGMC=ds.Tables[0].Rows[0]["ZSSWJGMC"].ToString();
				model.PZDYFS=ds.Tables[0].Rows[0]["PZDYFS"].ToString();
				model.DYSJ=ds.Tables[0].Rows[0]["DYSJ"].ToString();
				if(ds.Tables[0].Rows[0]["HJJE"].ToString()!="")
				{
					model.HJJE=decimal.Parse(ds.Tables[0].Rows[0]["HJJE"].ToString());
				}
				model.FWM=ds.Tables[0].Rows[0]["FWM"].ToString();
				model.DZYZDATA=ds.Tables[0].Rows[0]["DZYZDATA"].ToString();
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
			strSql.Append("select JKPZXH,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,ZSSWJGDM,ZSSWJGMC,PZDYFS,DYSJ,HJJE,FWM,DZYZDATA ");
			strSql.Append(" FROM JKPZ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

