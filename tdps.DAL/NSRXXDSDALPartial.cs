using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类NSRXXDSDAL。
	/// </summary>
	public partial class NSRXXDSDAL
	{
		#region  成员方法
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.NSRXXDS model,object trans)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into NSRXXDS(");
            strSql.Append("NSRSBH,SSHY,SSYH,QYDJZCL,NSLX,SFTYHSJG,ZGSWJG,ZGSWJG_MC,NSR_SWJG_DM,JKBZ,XY,LSGX,NSRBM,NSRZT,ZGY,SSHY_MC,QYDJZCL_MC,LSGX_MC)");
            strSql.Append(" values (");
            strSql.Append("@NSRSBH,@SSHY,@SSYH,@QYDJZCL,@NSLX,@SFTYHSJG,@ZGSWJG,@ZGSWJG_MC,@NSR_SWJG_DM,@JKBZ,@XY,@LSGX,@NSRBM,@NSRZT,@ZGY,@SSHY_MC,@QYDJZCL_MC,@LSGX_MC)");
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
                    new SQLiteParameter("@SSHY_MC", DbType.String,50),
                    new SQLiteParameter("@QYDJZCL_MC", DbType.String,50),
                    new SQLiteParameter("@LSGX_MC", DbType.String,50)};
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
            parameters[15].Value = model.SSHY_MC;
            parameters[16].Value = model.QYDJZCL_MC;
            parameters[17].Value = model.LSGX_MC;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.NSRXXDS model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NSRXXDS set ");
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
            strSql.Append("ZGY=@ZGY");
            strSql.Append("SSHY_MC=@SSHY_MC,");
            strSql.Append("QYDJZCL_MC=@QYDJZCL_MC,");
            strSql.Append("LSGX_MC=@LSGX_MC");
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
                    new SQLiteParameter("@SSHY_MC", DbType.String,50),
                    new SQLiteParameter("@QYDJZCL_MC", DbType.String,50),
                    new SQLiteParameter("@LSGX_MC", DbType.String,50)};
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
            parameters[15].Value = model.SSHY_MC;
            parameters[16].Value = model.QYDJZCL_MC;
            parameters[17].Value = model.LSGX_MC;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }
		#endregion  成员方法
	}
}

