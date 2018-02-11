using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类NSRXXGSDAL。
	/// </summary>
	public partial class NSRXXGSDAL
	{
		public NSRXXGSDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NSRSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(NSRSBH) from NSRXXGS");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.NSRXXGS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NSRXXGS(");
            strSql.Append("NSRSBH,SSHY,SSYH,QYDJZCL,NSLX,SFTYHSJG,ZGSWJG,ZGSWJG_MC,NSR_SWJG_DM,JKBZ,XY,LSGX,NSRBM,NSRZT,ZGY,NSRZT_MC)");
			strSql.Append(" values (");
            strSql.Append("@NSRSBH,@SSHY,@SSYH,@QYDJZCL,@NSLX,@SFTYHSJG,@ZGSWJG,@ZGSWJG_MC,@NSR_SWJG_DM,@JKBZ,@XY,@LSGX,@NSRBM,@NSRZT,@ZGY,@NSRZT_MC)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@SSHY", DbType.String,60),
					new SQLiteParameter("@SSYH", DbType.String,50),
					new SQLiteParameter("@QYDJZCL", DbType.String,60),
					new SQLiteParameter("@NSLX", DbType.String,50),
					new SQLiteParameter("@SFTYHSJG", DbType.Int32,4),
					new SQLiteParameter("@ZGSWJG", DbType.String,20),
					new SQLiteParameter("@ZGSWJG_MC", DbType.String,100),
					new SQLiteParameter("@NSR_SWJG_DM", DbType.String,20),
					new SQLiteParameter("@JKBZ", DbType.Int32,4),
					new SQLiteParameter("@XY", DbType.String,50),
					new SQLiteParameter("@LSGX", DbType.String,100),
					new SQLiteParameter("@NSRBM", DbType.String,20),
					new SQLiteParameter("@NSRZT", DbType.String,2),
					new SQLiteParameter("@ZGY", DbType.String,30),
                    new SQLiteParameter("@NSRZT_MC", DbType.String,30)};
			parameters[0].Value = model.NSRSBH;
			parameters[1].Value = model.SSHY;
			parameters[2].Value = model.SSYH;
			parameters[3].Value = model.QYDJZCL;
			parameters[4].Value = model.NSLX;
			parameters[5].Value = model.SFTYHSJG;
			parameters[6].Value = model.ZGSWJG;
			parameters[7].Value = model.ZGSWJG_MC;
			parameters[8].Value = model.NSR_SWJG_DM;
			parameters[9].Value = model.JKBZ;
			parameters[10].Value = model.XY;
			parameters[11].Value = model.LSGX;
			parameters[12].Value = model.NSRBM;
			parameters[13].Value = model.NSRZT;
			parameters[14].Value = model.ZGY;
            parameters[15].Value = model.NSRZT_MC;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.NSRXXGS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NSRXXGS set ");
			strSql.Append("SSHY=@SSHY,");
			strSql.Append("SSYH=@SSYH,");
			strSql.Append("QYDJZCL=@QYDJZCL,");
			strSql.Append("NSLX=@NSLX,");
			strSql.Append("SFTYHSJG=@SFTYHSJG,");
			strSql.Append("ZGSWJG=@ZGSWJG,");
			strSql.Append("ZGSWJG_MC=@ZGSWJG_MC,");
			strSql.Append("NSR_SWJG_DM=@NSR_SWJG_DM,");
			strSql.Append("JKBZ=@JKBZ,");
			strSql.Append("XY=@XY,");
			strSql.Append("LSGX=@LSGX,");
			strSql.Append("NSRBM=@NSRBM,");
			strSql.Append("NSRZT=@NSRZT,");
			strSql.Append("ZGY=@ZGY,");
            strSql.Append("NSRZT_MC=@NSRZT_MC");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@SSHY", DbType.String,60),
					new SQLiteParameter("@SSYH", DbType.String,50),
					new SQLiteParameter("@QYDJZCL", DbType.String,60),
					new SQLiteParameter("@NSLX", DbType.String,50),
					new SQLiteParameter("@SFTYHSJG", DbType.Int32,4),
					new SQLiteParameter("@ZGSWJG", DbType.String,20),
					new SQLiteParameter("@ZGSWJG_MC", DbType.String,100),
					new SQLiteParameter("@NSR_SWJG_DM", DbType.String,20),
					new SQLiteParameter("@JKBZ", DbType.Int32,4),
					new SQLiteParameter("@XY", DbType.String,50),
					new SQLiteParameter("@LSGX", DbType.String,100),
					new SQLiteParameter("@NSRBM", DbType.String,20),
					new SQLiteParameter("@NSRZT", DbType.String,2),
					new SQLiteParameter("@ZGY", DbType.String,30),
                    new SQLiteParameter("@NSRZT_MC", DbType.String,30)};
			parameters[0].Value = model.NSRSBH;
			parameters[1].Value = model.SSHY;
			parameters[2].Value = model.SSYH;
			parameters[3].Value = model.QYDJZCL;
			parameters[4].Value = model.NSLX;
			parameters[5].Value = model.SFTYHSJG;
			parameters[6].Value = model.ZGSWJG;
			parameters[7].Value = model.ZGSWJG_MC;
			parameters[8].Value = model.NSR_SWJG_DM;
			parameters[9].Value = model.JKBZ;
			parameters[10].Value = model.XY;
			parameters[11].Value = model.LSGX;
			parameters[12].Value = model.NSRBM;
			parameters[13].Value = model.NSRZT;
			parameters[14].Value = model.ZGY;
            parameters[15].Value = model.NSRZT_MC;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NSRXXGS ");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.NSRXXGS GetModel(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select NSRSBH,SSHY,SSYH,QYDJZCL,NSLX,SFTYHSJG,ZGSWJG,ZGSWJG_MC,NSR_SWJG_DM,JKBZ,XY,LSGX,NSRBM,NSRZT,ZGY,SSHY_MC,QYDJZCL_MC,LSGX_MC,NSRZT_MC,nsrzg_dm from NSRXXGS ");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			tdps.Model.NSRXXGS model=new tdps.Model.NSRXXGS();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.SSHY=ds.Tables[0].Rows[0]["SSHY"].ToString();
                model.SSHY_MC = ds.Tables[0].Rows[0]["SSHY_MC"].ToString();
				model.SSYH=ds.Tables[0].Rows[0]["SSYH"].ToString();
				model.QYDJZCL=ds.Tables[0].Rows[0]["QYDJZCL"].ToString();
                model.QYDJZCL_MC = ds.Tables[0].Rows[0]["QYDJZCL_MC"].ToString();
				model.NSLX=ds.Tables[0].Rows[0]["NSLX"].ToString();
				if(ds.Tables[0].Rows[0]["SFTYHSJG"].ToString()!="")
				{
					model.SFTYHSJG=int.Parse(ds.Tables[0].Rows[0]["SFTYHSJG"].ToString());
				}
				model.ZGSWJG=ds.Tables[0].Rows[0]["ZGSWJG"].ToString();
				model.ZGSWJG_MC=ds.Tables[0].Rows[0]["ZGSWJG_MC"].ToString();
				model.NSR_SWJG_DM=ds.Tables[0].Rows[0]["NSR_SWJG_DM"].ToString();
				if(ds.Tables[0].Rows[0]["JKBZ"].ToString()!="")
				{
					model.JKBZ=int.Parse(ds.Tables[0].Rows[0]["JKBZ"].ToString());
				}
				model.XY=ds.Tables[0].Rows[0]["XY"].ToString();
				model.LSGX=ds.Tables[0].Rows[0]["LSGX"].ToString();
                model.LSGX_MC = ds.Tables[0].Rows[0]["LSGX_MC"].ToString();
				model.NSRBM=ds.Tables[0].Rows[0]["NSRBM"].ToString();
				model.NSRZT=ds.Tables[0].Rows[0]["NSRZT"].ToString();
				model.ZGY=ds.Tables[0].Rows[0]["ZGY"].ToString();
                model.NSRZT_MC = ds.Tables[0].Rows[0]["NSRZT_MC"].ToString();
                model.nsrzg_dm = ds.Tables[0].Rows[0]["nsrzg_dm"].ToString();
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
            strSql.Append("select NSRSBH,SSHY,SSYH,QYDJZCL,NSLX,SFTYHSJG,ZGSWJG,ZGSWJG_MC,NSR_SWJG_DM,JKBZ,XY,LSGX,NSRBM,NSRZT,ZGY,SSHY_MC,QYDJZCL_MC,LSGX_MC,NSRZT_MC ");
			strSql.Append(" FROM NSRXXGS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

