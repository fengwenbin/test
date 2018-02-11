using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类YJSCLDAL。
	/// </summary>
	public partial class YJSCLDAL
	{
		public YJSCLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from YJSCL");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.YJSCL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YJSCL(");
			strSql.Append("HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,YJFSSJ,YJCLSJ,JYLSH,DZYZData,ZSXM_DM,ZSXM_MC,ZSPM_DM,ZSPM_MC,SL,TSXX,ZT,YJJE,SSQQ,SSQZ,SBFKYZM,FKDM,FKXX,FileName,MW)");
			strSql.Append(" values (");
			strSql.Append("@HZLX,@NSRSBH,@NSRMC,@SWJGMC,@YHDM,@YHZH,@YJFSSJ,@YJCLSJ,@JYLSH,@DZYZData,@ZSXM_DM,@ZSXM_MC,@ZSPM_DM,@ZSPM_MC,@SL,@TSXX,@ZT,@YJJE,@SSQQ,@SSQZ,@SBFKYZM,@FKDM,@FKXX,@FileName,@MW)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@YHDM", DbType.String,12),
					new SQLiteParameter("@YHZH", DbType.String,50),
					new SQLiteParameter("@YJFSSJ", DbType.String,20),
					new SQLiteParameter("@YJCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@ZSXM_DM", DbType.String,20),
					new SQLiteParameter("@ZSXM_MC", DbType.String,50),
					new SQLiteParameter("@ZSPM_DM", DbType.String,20),
					new SQLiteParameter("@ZSPM_MC", DbType.String,50),
					new SQLiteParameter("@SL", DbType.Decimal,9),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@YJJE", DbType.Decimal,9),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@SBFKYZM", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@MW", DbType.String)};
			parameters[0].Value = model.HZLX;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.NSRMC;
			parameters[3].Value = model.SWJGMC;
			parameters[4].Value = model.YHDM;
			parameters[5].Value = model.YHZH;
			parameters[6].Value = model.YJFSSJ;
			parameters[7].Value = model.YJCLSJ;
			parameters[8].Value = model.JYLSH;
			parameters[9].Value = model.DZYZData;
			parameters[10].Value = model.ZSXM_DM;
			parameters[11].Value = model.ZSXM_MC;
			parameters[12].Value = model.ZSPM_DM;
			parameters[13].Value = model.ZSPM_MC;
			parameters[14].Value = model.SL;
			parameters[15].Value = model.TSXX;
			parameters[16].Value = model.ZT;
			parameters[17].Value = model.YJJE;
			parameters[18].Value = model.SSQQ;
			parameters[19].Value = model.SSQZ;
			parameters[20].Value = model.SBFKYZM;
			parameters[21].Value = model.FKDM;
			parameters[22].Value = model.FKXX;
			parameters[23].Value = model.FileName;
			parameters[24].Value = model.MW;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.YJSCL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YJSCL set ");
			strSql.Append("HZLX=@HZLX,");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("NSRMC=@NSRMC,");
			strSql.Append("SWJGMC=@SWJGMC,");
			strSql.Append("YHDM=@YHDM,");
			strSql.Append("YHZH=@YHZH,");
			strSql.Append("YJFSSJ=@YJFSSJ,");
			strSql.Append("YJCLSJ=@YJCLSJ,");
			strSql.Append("JYLSH=@JYLSH,");
			strSql.Append("DZYZData=@DZYZData,");
			strSql.Append("ZSXM_DM=@ZSXM_DM,");
			strSql.Append("ZSXM_MC=@ZSXM_MC,");
			strSql.Append("ZSPM_DM=@ZSPM_DM,");
			strSql.Append("ZSPM_MC=@ZSPM_MC,");
			strSql.Append("SL=@SL,");
			strSql.Append("TSXX=@TSXX,");
			strSql.Append("ZT=@ZT,");
			strSql.Append("YJJE=@YJJE,");
			strSql.Append("SSQQ=@SSQQ,");
			strSql.Append("SSQZ=@SSQZ,");
			strSql.Append("SBFKYZM=@SBFKYZM,");
			strSql.Append("FKDM=@FKDM,");
			strSql.Append("FKXX=@FKXX,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("MW=@MW");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@YHDM", DbType.String,12),
					new SQLiteParameter("@YHZH", DbType.String,50),
					new SQLiteParameter("@YJFSSJ", DbType.String,20),
					new SQLiteParameter("@YJCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@ZSXM_DM", DbType.String,20),
					new SQLiteParameter("@ZSXM_MC", DbType.String,50),
					new SQLiteParameter("@ZSPM_DM", DbType.String,20),
					new SQLiteParameter("@ZSPM_MC", DbType.String,50),
					new SQLiteParameter("@SL", DbType.Decimal,9),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@YJJE", DbType.Decimal,9),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@SBFKYZM", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@MW", DbType.String)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.HZLX;
			parameters[2].Value = model.NSRSBH;
			parameters[3].Value = model.NSRMC;
			parameters[4].Value = model.SWJGMC;
			parameters[5].Value = model.YHDM;
			parameters[6].Value = model.YHZH;
			parameters[7].Value = model.YJFSSJ;
			parameters[8].Value = model.YJCLSJ;
			parameters[9].Value = model.JYLSH;
			parameters[10].Value = model.DZYZData;
			parameters[11].Value = model.ZSXM_DM;
			parameters[12].Value = model.ZSXM_MC;
			parameters[13].Value = model.ZSPM_DM;
			parameters[14].Value = model.ZSPM_MC;
			parameters[15].Value = model.SL;
			parameters[16].Value = model.TSXX;
			parameters[17].Value = model.ZT;
			parameters[18].Value = model.YJJE;
			parameters[19].Value = model.SSQQ;
			parameters[20].Value = model.SSQZ;
			parameters[21].Value = model.SBFKYZM;
			parameters[22].Value = model.FKDM;
			parameters[23].Value = model.FKXX;
			parameters[24].Value = model.FileName;
			parameters[25].Value = model.MW;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YJSCL ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 删除多条数据
        /// </summary>
        public void Delete(string where)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YJSCL ");
            strSql.Append(" where " + where);

            SQLiteHelper.ExecuteNonQuery(strSql.ToString());
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.YJSCL GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,YJFSSJ,YJCLSJ,JYLSH,DZYZData,ZSXM_DM,ZSXM_MC,ZSPM_DM,ZSPM_MC,SL,TSXX,ZT,YJJE,SSQQ,SSQZ,SBFKYZM,FKDM,FKXX,FileName,MW from YJSCL ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			tdps.Model.YJSCL model=new tdps.Model.YJSCL();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				model.HZLX=ds.Tables[0].Rows[0]["HZLX"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.SWJGMC=ds.Tables[0].Rows[0]["SWJGMC"].ToString();
				model.YHDM=ds.Tables[0].Rows[0]["YHDM"].ToString();
				model.YHZH=ds.Tables[0].Rows[0]["YHZH"].ToString();
				model.YJFSSJ=ds.Tables[0].Rows[0]["YJFSSJ"].ToString();
				model.YJCLSJ=ds.Tables[0].Rows[0]["YJCLSJ"].ToString();
				model.JYLSH=ds.Tables[0].Rows[0]["JYLSH"].ToString();
				model.DZYZData=ds.Tables[0].Rows[0]["DZYZData"].ToString();
				model.ZSXM_DM=ds.Tables[0].Rows[0]["ZSXM_DM"].ToString();
				model.ZSXM_MC=ds.Tables[0].Rows[0]["ZSXM_MC"].ToString();
				model.ZSPM_DM=ds.Tables[0].Rows[0]["ZSPM_DM"].ToString();
				model.ZSPM_MC=ds.Tables[0].Rows[0]["ZSPM_MC"].ToString();
				if(ds.Tables[0].Rows[0]["SL"].ToString()!="")
				{
					model.SL=decimal.Parse(ds.Tables[0].Rows[0]["SL"].ToString());
				}
				model.TSXX=ds.Tables[0].Rows[0]["TSXX"].ToString();
				model.ZT=ds.Tables[0].Rows[0]["ZT"].ToString();
				if(ds.Tables[0].Rows[0]["YJJE"].ToString()!="")
				{
					model.YJJE=decimal.Parse(ds.Tables[0].Rows[0]["YJJE"].ToString());
				}
				model.SSQQ=ds.Tables[0].Rows[0]["SSQQ"].ToString();
				model.SSQZ=ds.Tables[0].Rows[0]["SSQZ"].ToString();
				model.SBFKYZM=ds.Tables[0].Rows[0]["SBFKYZM"].ToString();
				model.FKDM=ds.Tables[0].Rows[0]["FKDM"].ToString();
				model.FKXX=ds.Tables[0].Rows[0]["FKXX"].ToString();
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				model.MW=ds.Tables[0].Rows[0]["MW"].ToString();
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
			strSql.Append("select FID,HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,YJFSSJ,YJCLSJ,JYLSH,DZYZData,ZSXM_DM,ZSXM_MC,ZSPM_DM,ZSPM_MC,SL,TSXX,ZT,YJJE,SSQQ,SSQZ,SBFKYZM,FKDM,FKXX,FileName,MW ");
			strSql.Append(" FROM YJSCL ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

