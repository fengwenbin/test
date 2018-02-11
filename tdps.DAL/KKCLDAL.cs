using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类KKCLDAL。
	/// </summary>
	public partial class KKCLDAL
	{
		public KKCLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from KKCL");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.KKCL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KKCL(");
			strSql.Append("SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,KKFSSJ,KKCLSJ,JYLSH,DZYZData,SBWJ,SBZL,TSXX,ZT,ZJE,KKJE,WJJE,SBZLMC,SBCS,SSQQ,SSQZ,KKSJ,SBFKYZM,FKDM,FKXX,SZ,FileName,MW)");
			strSql.Append(" values (");
			strSql.Append("@SBXXID,@HZLX,@NSRSBH,@NSRMC,@SWJGMC,@YHDM,@YHZH,@KKFSSJ,@KKCLSJ,@JYLSH,@DZYZData,@SBWJ,@SBZL,@TSXX,@ZT,@ZJE,@KKJE,@WJJE,@SBZLMC,@SBCS,@SSQQ,@SSQZ,@KKSJ,@SBFKYZM,@FKDM,@FKXX,@SZ,@FileName,@MW)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@YHDM", DbType.String,12),
					new SQLiteParameter("@YHZH", DbType.String,50),
					new SQLiteParameter("@KKFSSJ", DbType.String,20),
					new SQLiteParameter("@KKCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@ZJE", DbType.Decimal,9),
					new SQLiteParameter("@KKJE", DbType.Decimal,9),
					new SQLiteParameter("@WJJE", DbType.Decimal,9),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@KKSJ", DbType.String,20),
					new SQLiteParameter("@SBFKYZM", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@MW", DbType.String)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.HZLX;
			parameters[2].Value = model.NSRSBH;
			parameters[3].Value = model.NSRMC;
			parameters[4].Value = model.SWJGMC;
			parameters[5].Value = model.YHDM;
			parameters[6].Value = model.YHZH;
			parameters[7].Value = model.KKFSSJ;
			parameters[8].Value = model.KKCLSJ;
			parameters[9].Value = model.JYLSH;
			parameters[10].Value = model.DZYZData;
			parameters[11].Value = model.SBWJ;
			parameters[12].Value = model.SBZL;
			parameters[13].Value = model.TSXX;
			parameters[14].Value = model.ZT;
			parameters[15].Value = model.ZJE;
			parameters[16].Value = model.KKJE;
			parameters[17].Value = model.WJJE;
			parameters[18].Value = model.SBZLMC;
			parameters[19].Value = model.SBCS;
			parameters[20].Value = model.SSQQ;
			parameters[21].Value = model.SSQZ;
			parameters[22].Value = model.KKSJ;
			parameters[23].Value = model.SBFKYZM;
			parameters[24].Value = model.FKDM;
			parameters[25].Value = model.FKXX;
			parameters[26].Value = model.SZ;
			parameters[27].Value = model.FileName;
			parameters[28].Value = model.MW;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.KKCL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KKCL set ");
			strSql.Append("SBXXID=@SBXXID,");
			strSql.Append("HZLX=@HZLX,");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("NSRMC=@NSRMC,");
			strSql.Append("SWJGMC=@SWJGMC,");
			strSql.Append("YHDM=@YHDM,");
			strSql.Append("YHZH=@YHZH,");
			strSql.Append("KKFSSJ=@KKFSSJ,");
			strSql.Append("KKCLSJ=@KKCLSJ,");
			strSql.Append("JYLSH=@JYLSH,");
			strSql.Append("DZYZData=@DZYZData,");
			strSql.Append("SBWJ=@SBWJ,");
			strSql.Append("SBZL=@SBZL,");
			strSql.Append("TSXX=@TSXX,");
			strSql.Append("ZT=@ZT,");
			strSql.Append("ZJE=@ZJE,");
			strSql.Append("KKJE=@KKJE,");
			strSql.Append("WJJE=@WJJE,");
			strSql.Append("SBZLMC=@SBZLMC,");
			strSql.Append("SBCS=@SBCS,");
			strSql.Append("SSQQ=@SSQQ,");
			strSql.Append("SSQZ=@SSQZ,");
			strSql.Append("KKSJ=@KKSJ,");
			strSql.Append("SBFKYZM=@SBFKYZM,");
			strSql.Append("FKDM=@FKDM,");
			strSql.Append("FKXX=@FKXX,");
			strSql.Append("SZ=@SZ,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("MW=@MW");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@YHDM", DbType.String,12),
					new SQLiteParameter("@YHZH", DbType.String,50),
					new SQLiteParameter("@KKFSSJ", DbType.String,20),
					new SQLiteParameter("@KKCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@ZJE", DbType.Decimal,9),
					new SQLiteParameter("@KKJE", DbType.Decimal,9),
					new SQLiteParameter("@WJJE", DbType.Decimal,9),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@KKSJ", DbType.String,20),
					new SQLiteParameter("@SBFKYZM", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@MW", DbType.String)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.SBXXID;
			parameters[2].Value = model.HZLX;
			parameters[3].Value = model.NSRSBH;
			parameters[4].Value = model.NSRMC;
			parameters[5].Value = model.SWJGMC;
			parameters[6].Value = model.YHDM;
			parameters[7].Value = model.YHZH;
			parameters[8].Value = model.KKFSSJ;
			parameters[9].Value = model.KKCLSJ;
			parameters[10].Value = model.JYLSH;
			parameters[11].Value = model.DZYZData;
			parameters[12].Value = model.SBWJ;
			parameters[13].Value = model.SBZL;
			parameters[14].Value = model.TSXX;
			parameters[15].Value = model.ZT;
			parameters[16].Value = model.ZJE;
			parameters[17].Value = model.KKJE;
			parameters[18].Value = model.WJJE;
			parameters[19].Value = model.SBZLMC;
			parameters[20].Value = model.SBCS;
			parameters[21].Value = model.SSQQ;
			parameters[22].Value = model.SSQZ;
			parameters[23].Value = model.KKSJ;
			parameters[24].Value = model.SBFKYZM;
			parameters[25].Value = model.FKDM;
			parameters[26].Value = model.FKXX;
			parameters[27].Value = model.SZ;
			parameters[28].Value = model.FileName;
			parameters[29].Value = model.MW;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KKCL ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int FID, object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KKCL ");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
            parameters[0].Value = FID;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans,parameters);
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.KKCL GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,KKFSSJ,KKCLSJ,JYLSH,DZYZData,SBWJ,SBZL,TSXX,ZT,ZJE,KKJE,WJJE,SBZLMC,SBCS,SSQQ,SSQZ,KKSJ,SBFKYZM,FKDM,FKXX,SZ,FileName,MW from KKCL ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			tdps.Model.KKCL model=new tdps.Model.KKCL();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SBXXID"].ToString()!="")
				{
					model.SBXXID=int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
				}
				model.HZLX=ds.Tables[0].Rows[0]["HZLX"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.SWJGMC=ds.Tables[0].Rows[0]["SWJGMC"].ToString();
				model.YHDM=ds.Tables[0].Rows[0]["YHDM"].ToString();
				model.YHZH=ds.Tables[0].Rows[0]["YHZH"].ToString();
				model.KKFSSJ=ds.Tables[0].Rows[0]["KKFSSJ"].ToString();
				model.KKCLSJ=ds.Tables[0].Rows[0]["KKCLSJ"].ToString();
				model.JYLSH=ds.Tables[0].Rows[0]["JYLSH"].ToString();
				model.DZYZData=ds.Tables[0].Rows[0]["DZYZData"].ToString();
				model.SBWJ=ds.Tables[0].Rows[0]["SBWJ"].ToString();
				model.SBZL=ds.Tables[0].Rows[0]["SBZL"].ToString();
				model.TSXX=ds.Tables[0].Rows[0]["TSXX"].ToString();
				model.ZT=ds.Tables[0].Rows[0]["ZT"].ToString();
				if(ds.Tables[0].Rows[0]["ZJE"].ToString()!="")
				{
					model.ZJE=decimal.Parse(ds.Tables[0].Rows[0]["ZJE"].ToString());
				}
				if(ds.Tables[0].Rows[0]["KKJE"].ToString()!="")
				{
					model.KKJE=decimal.Parse(ds.Tables[0].Rows[0]["KKJE"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WJJE"].ToString()!="")
				{
					model.WJJE=decimal.Parse(ds.Tables[0].Rows[0]["WJJE"].ToString());
				}
				model.SBZLMC=ds.Tables[0].Rows[0]["SBZLMC"].ToString();
				if(ds.Tables[0].Rows[0]["SBCS"].ToString()!="")
				{
					model.SBCS=int.Parse(ds.Tables[0].Rows[0]["SBCS"].ToString());
				}
				model.SSQQ=ds.Tables[0].Rows[0]["SSQQ"].ToString();
				model.SSQZ=ds.Tables[0].Rows[0]["SSQZ"].ToString();
				model.KKSJ=ds.Tables[0].Rows[0]["KKSJ"].ToString();
				model.SBFKYZM=ds.Tables[0].Rows[0]["SBFKYZM"].ToString();
				model.FKDM=ds.Tables[0].Rows[0]["FKDM"].ToString();
				model.FKXX=ds.Tables[0].Rows[0]["FKXX"].ToString();
				model.SZ=ds.Tables[0].Rows[0]["SZ"].ToString();
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
			strSql.Append("select FID,SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,KKFSSJ,KKCLSJ,JYLSH,DZYZData,SBWJ,SBZL,TSXX,ZT,ZJE,KKJE,WJJE,SBZLMC,SBCS,SSQQ,SSQZ,KKSJ,SBFKYZM,FKDM,FKXX,SZ,FileName,MW ");
			strSql.Append(" FROM KKCL ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

