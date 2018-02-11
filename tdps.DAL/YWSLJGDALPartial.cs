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
		#region  成员方法
		/// <summary>
        /// 得到最大FID
		/// </summary>
        public int GetMaxFID()
		{
            return SQLiteHelper.GetMaxID("FID", "YWSLJG");
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.YWSLJG model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YWSLJG(");
            strSql.Append("FileName,returnCode,returnMessage,businessID,jmm,NSRSBH,NSRMC,createTime,SWJGDM,JYSLXX,swjgMc,DZYZData,MW,SLLX,KHDFSSJ,SSQQ,SSQZ,ZSXM_DM,ZSXM_MC,ZSPM_DM,ZSPM_MC)");
			strSql.Append(" values (");
            strSql.Append("@FileName,@returnCode,@returnMessage,@businessID,@jmm,@NSRSBH,@NSRMC,@createTime,@SWJGDM,@JYSLXX,@swjgMc,@DZYZData,@MW,@SLLX,@KHDFSSJ,@SSQQ,@SSQZ,@ZSXM_DM,@ZSXM_MC,@ZSPM_DM,@ZSPM_MC)");
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
					new SQLiteParameter("@KHDFSSJ", DbType.String,20),
                                           
					new SQLiteParameter("@SSQQ", DbType.String),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@ZSXM_DM", DbType.String),
					new SQLiteParameter("@ZSXM_MC", DbType.String),
					new SQLiteParameter("@ZSPM_DM", DbType.String,20),
					new SQLiteParameter("@ZSPM_MC", DbType.String,20)};
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

            parameters[15].Value = model.ssqq;
            parameters[16].Value = model.ssqz;
            parameters[17].Value = model.zsxm_dm;
            parameters[18].Value = model.zsxm_mc;
            parameters[19].Value = model.zspm_dm;
            parameters[20].Value = model.zspm_mc;
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}
		

		#endregion  成员方法
	}
}

