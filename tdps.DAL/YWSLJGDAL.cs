using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类YWSLJGDAL。
	/// </summary>
	public partial class YWSLJGDAL
	{
		public YWSLJGDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from YWSLJG");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.YWSLJG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YWSLJG(");
			strSql.Append("FileName,returnCode,returnMessage,businessID,jmm,NSRSBH,NSRMC,createTime,SWJGDM,JYSLXX,swjgMc,DZYZData,MW,SLLX,KHDFSSJ)");
			strSql.Append(" values (");
			strSql.Append("@FileName,@returnCode,@returnMessage,@businessID,@jmm,@NSRSBH,@NSRMC,@createTime,@SWJGDM,@JYSLXX,@swjgMc,@DZYZData,@MW,@SLLX,@KHDFSSJ)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FileName", DbType.String,50),
					new SQLiteParameter("@returnCode", DbType.String,8),
					new SQLiteParameter("@returnMessage", DbType.String,50),
					new SQLiteParameter("@businessID", DbType.String,20),
					new SQLiteParameter("@jmm", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@createTime", DbType.String,20),
					new SQLiteParameter("@SWJGDM", DbType.String,20),
					new SQLiteParameter("@JYSLXX", DbType.String),
					new SQLiteParameter("@swjgMc", DbType.String,20),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@MW", DbType.String),
					new SQLiteParameter("@SLLX", DbType.String,20),
					new SQLiteParameter("@KHDFSSJ", DbType.String,20)};
			parameters[0].Value = model.FileName;
			parameters[1].Value = model.returnCode;
			parameters[2].Value = model.returnMessage;
			parameters[3].Value = model.businessID;
			parameters[4].Value = model.jmm;
			parameters[5].Value = model.NSRSBH;
			parameters[6].Value = model.NSRMC;
			parameters[7].Value = model.createTime;
			parameters[8].Value = model.SWJGDM;
			parameters[9].Value = model.JYSLXX;
			parameters[10].Value = model.swjgMc;
			parameters[11].Value = model.DZYZData;
			parameters[12].Value = model.MW;
			parameters[13].Value = model.SLLX;
			parameters[14].Value = model.KHDFSSJ;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.YWSLJG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YWSLJG set ");
			strSql.Append("FileName=@FileName,");
			strSql.Append("returnCode=@returnCode,");
			strSql.Append("returnMessage=@returnMessage,");
			strSql.Append("businessID=@businessID,");
			strSql.Append("jmm=@jmm,");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("NSRMC=@NSRMC,");
			strSql.Append("createTime=@createTime,");
			strSql.Append("SWJGDM=@SWJGDM,");
			strSql.Append("JYSLXX=@JYSLXX,");
			strSql.Append("swjgMc=@swjgMc,");
			strSql.Append("DZYZData=@DZYZData,");
			strSql.Append("MW=@MW,");
			strSql.Append("SLLX=@SLLX,");
			strSql.Append("KHDFSSJ=@KHDFSSJ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@FileName", DbType.String,50),
					new SQLiteParameter("@returnCode", DbType.String,8),
					new SQLiteParameter("@returnMessage", DbType.String,50),
					new SQLiteParameter("@businessID", DbType.String,20),
					new SQLiteParameter("@jmm", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@createTime", DbType.String,20),
					new SQLiteParameter("@SWJGDM", DbType.String,20),
					new SQLiteParameter("@JYSLXX", DbType.String),
					new SQLiteParameter("@swjgMc", DbType.String,20),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@MW", DbType.String),
					new SQLiteParameter("@SLLX", DbType.String,20),
					new SQLiteParameter("@KHDFSSJ", DbType.String,20)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.FileName;
			parameters[2].Value = model.returnCode;
			parameters[3].Value = model.returnMessage;
			parameters[4].Value = model.businessID;
			parameters[5].Value = model.jmm;
			parameters[6].Value = model.NSRSBH;
			parameters[7].Value = model.NSRMC;
			parameters[8].Value = model.createTime;
			parameters[9].Value = model.SWJGDM;
			parameters[10].Value = model.JYSLXX;
			parameters[11].Value = model.swjgMc;
			parameters[12].Value = model.DZYZData;
			parameters[13].Value = model.MW;
			parameters[14].Value = model.SLLX;
			parameters[15].Value = model.KHDFSSJ;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YWSLJG ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string where,object tran)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YWSLJG ");
            strSql.Append(" where " + where);

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(),(SQLiteTransaction)tran,null);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.YWSLJG GetModel(string whereSql)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 FID,FileName,returnCode,returnMessage,businessID,jmm,NSRSBH,NSRMC,createTime,SWJGDM,JYSLXX,swjgMc,DZYZData,MW,SLLX,KHDFSSJ,ZSXM_DM,ZSXM_MC,ZSPM_DM,ZSPM_MC,SSQQ,SSQZ from YWSLJG ");
            strSql.Append(" where 1=1 and " + whereSql + " order by fid desc");

            tdps.Model.YWSLJG model = new tdps.Model.YWSLJG();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["FID"].ToString() != "")
                {
                    model.FID = int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
                }
                model.FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                model.returnCode = ds.Tables[0].Rows[0]["returnCode"].ToString();
                model.returnMessage = ds.Tables[0].Rows[0]["returnMessage"].ToString();
                model.businessID = ds.Tables[0].Rows[0]["businessID"].ToString();
                model.jmm = ds.Tables[0].Rows[0]["jmm"].ToString();
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
                model.NSRMC = ds.Tables[0].Rows[0]["NSRMC"].ToString();
                model.createTime = ds.Tables[0].Rows[0]["createTime"].ToString();
                model.SWJGDM = ds.Tables[0].Rows[0]["SWJGDM"].ToString();
                model.JYSLXX = ds.Tables[0].Rows[0]["JYSLXX"].ToString();
                model.swjgMc = ds.Tables[0].Rows[0]["swjgMc"].ToString();
                model.DZYZData = ds.Tables[0].Rows[0]["DZYZData"].ToString();
                model.MW = ds.Tables[0].Rows[0]["MW"].ToString();
                model.SLLX = ds.Tables[0].Rows[0]["SLLX"].ToString();
                model.KHDFSSJ = ds.Tables[0].Rows[0]["KHDFSSJ"].ToString();

                model.ssqq = ds.Tables[0].Rows[0]["SSQQ"].ToString();
                model.ssqz = ds.Tables[0].Rows[0]["SSQZ"].ToString();
                model.zspm_dm = ds.Tables[0].Rows[0]["ZSPM_DM"].ToString();
                model.zspm_mc = ds.Tables[0].Rows[0]["ZSPM_MC"].ToString();
                model.zsxm_dm = ds.Tables[0].Rows[0]["ZSXM_DM"].ToString();
                model.zsxm_mc = ds.Tables[0].Rows[0]["ZSXM_MC"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.YWSLJG GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select FID,FileName,returnCode,returnMessage,businessID,jmm,NSRSBH,NSRMC,createTime,SWJGDM,JYSLXX,swjgMc,DZYZData,MW,SLLX,KHDFSSJ,ZSXM_DM,ZSXM_MC,ZSPM_DM,ZSPM_MC,SSQQ,SSQZ from YWSLJG ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			tdps.Model.YWSLJG model=new tdps.Model.YWSLJG();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				model.returnCode=ds.Tables[0].Rows[0]["returnCode"].ToString();
				model.returnMessage=ds.Tables[0].Rows[0]["returnMessage"].ToString();
				model.businessID=ds.Tables[0].Rows[0]["businessID"].ToString();
				model.jmm=ds.Tables[0].Rows[0]["jmm"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.createTime=ds.Tables[0].Rows[0]["createTime"].ToString();
				model.SWJGDM=ds.Tables[0].Rows[0]["SWJGDM"].ToString();
				model.JYSLXX=ds.Tables[0].Rows[0]["JYSLXX"].ToString();
				model.swjgMc=ds.Tables[0].Rows[0]["swjgMc"].ToString();
				model.DZYZData=ds.Tables[0].Rows[0]["DZYZData"].ToString();
				model.MW=ds.Tables[0].Rows[0]["MW"].ToString();
				model.SLLX=ds.Tables[0].Rows[0]["SLLX"].ToString();
				model.KHDFSSJ=ds.Tables[0].Rows[0]["KHDFSSJ"].ToString();

                model.ssqq = ds.Tables[0].Rows[0]["SSQQ"].ToString();
                model.ssqz = ds.Tables[0].Rows[0]["SSQZ"].ToString();
                model.zspm_dm = ds.Tables[0].Rows[0]["ZSPM_DM"].ToString();
                model.zspm_mc = ds.Tables[0].Rows[0]["ZSPM_MC"].ToString();
                model.zsxm_dm = ds.Tables[0].Rows[0]["ZSXM_DM"].ToString();
                model.zsxm_mc = ds.Tables[0].Rows[0]["ZSXM_MC"].ToString();
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
			strSql.Append("select FID,FileName,returnCode,returnMessage,businessID,jmm,NSRSBH,NSRMC,createTime,SWJGDM,JYSLXX,swjgMc,DZYZData,MW,SLLX,KHDFSSJ ");
			strSql.Append(" FROM YWSLJG ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

