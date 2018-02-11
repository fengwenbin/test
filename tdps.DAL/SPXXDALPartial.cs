using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类SPXXDAL。
	/// </summary>
	public partial class SPXXDAL
	{
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.SPXX model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SPXX(");
			strSql.Append("SPHM,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,SSSQ_Q,SSSQ_Z,SL,KSSL,JKSJ,SJJE,ZSXMDM,ZSXMMC,ZSPMDM,ZSPMMC,JYLXDM,JYLXMC,PZZLDM,PZZLMC,YHZH,BZ,WSPZH,ZSSWJGDM,ZSSWJGMC,WSZKJSJ)");
			strSql.Append(" values (");
			strSql.Append("@SPHM,@NSRSBH,@NSRMC,@NSRSWJGDM,@NSRSWJGMC,@SSSQ_Q,@SSSQ_Z,@SL,@KSSL,@JKSJ,@SJJE,@ZSXMDM,@ZSXMMC,@ZSPMDM,@ZSPMMC,@JYLXDM,@JYLXMC,@PZZLDM,@PZZLMC,@YHZH,@BZ,@WSPZH,@ZSSWJGDM,@ZSSWJGMC,@WSZKJSJ)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@NSRSWJGDM", DbType.String,9),
					new SQLiteParameter("@NSRSWJGMC", DbType.String,80),
					new SQLiteParameter("@SSSQ_Q", DbType.String,20),
					new SQLiteParameter("@SSSQ_Z", DbType.String,20),
					new SQLiteParameter("@SL", DbType.Decimal,9),
					new SQLiteParameter("@KSSL", DbType.String,20),
					new SQLiteParameter("@JKSJ", DbType.String,20),
					new SQLiteParameter("@SJJE", DbType.Decimal,9),
					new SQLiteParameter("@ZSXMDM", DbType.String,2),
					new SQLiteParameter("@ZSXMMC", DbType.String,80),
					new SQLiteParameter("@ZSPMDM", DbType.String,4),
					new SQLiteParameter("@ZSPMMC", DbType.String,80),
					new SQLiteParameter("@JYLXDM", DbType.String,8),
					new SQLiteParameter("@JYLXMC", DbType.String,80),
					new SQLiteParameter("@PZZLDM", DbType.String,5),
					new SQLiteParameter("@PZZLMC", DbType.String,80),
					new SQLiteParameter("@YHZH", DbType.String,12),
					new SQLiteParameter("@BZ", DbType.String,1000),
					new SQLiteParameter("@WSPZH", DbType.String,20),
					new SQLiteParameter("@ZSSWJGDM", DbType.String,11),
					new SQLiteParameter("@ZSSWJGMC", DbType.String,80),
					new SQLiteParameter("@WSZKJSJ", DbType.String,20)};
			parameters[0].Value = model.SPHM;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.NSRMC;
			parameters[3].Value = model.NSRSWJGDM;
			parameters[4].Value = model.NSRSWJGMC;
			parameters[5].Value = model.SSSQ_Q;
			parameters[6].Value = model.SSSQ_Z;
			parameters[7].Value = model.SL;
			parameters[8].Value = model.KSSL;
			parameters[9].Value = model.JKSJ;
			parameters[10].Value = model.SJJE;
			parameters[11].Value = model.ZSXMDM;
			parameters[12].Value = model.ZSXMMC;
			parameters[13].Value = model.ZSPMDM;
			parameters[14].Value = model.ZSPMMC;
			parameters[15].Value = model.JYLXDM;
			parameters[16].Value = model.JYLXMC;
			parameters[17].Value = model.PZZLDM;
			parameters[18].Value = model.PZZLMC;
			parameters[19].Value = model.YHZH;
			parameters[20].Value = model.BZ;
			parameters[21].Value = model.WSPZH;
			parameters[22].Value = model.ZSSWJGDM;
			parameters[23].Value = model.ZSSWJGMC;
			parameters[24].Value = model.WSZKJSJ;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.SPXX model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SPXX set ");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("NSRMC=@NSRMC,");
			strSql.Append("NSRSWJGDM=@NSRSWJGDM,");
			strSql.Append("NSRSWJGMC=@NSRSWJGMC,");
			strSql.Append("SSSQ_Q=@SSSQ_Q,");
			strSql.Append("SSSQ_Z=@SSSQ_Z,");
			strSql.Append("SL=@SL,");
			strSql.Append("KSSL=@KSSL,");
			strSql.Append("JKSJ=@JKSJ,");
			strSql.Append("SJJE=@SJJE,");
			strSql.Append("ZSXMDM=@ZSXMDM,");
			strSql.Append("ZSXMMC=@ZSXMMC,");
			strSql.Append("ZSPMDM=@ZSPMDM,");
			strSql.Append("ZSPMMC=@ZSPMMC,");
			strSql.Append("JYLXDM=@JYLXDM,");
			strSql.Append("JYLXMC=@JYLXMC,");
			strSql.Append("PZZLDM=@PZZLDM,");
			strSql.Append("PZZLMC=@PZZLMC,");
			strSql.Append("YHZH=@YHZH,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("WSPZH=@WSPZH,");
			strSql.Append("ZSSWJGDM=@ZSSWJGDM,");
			strSql.Append("ZSSWJGMC=@ZSSWJGMC,");
			strSql.Append("WSZKJSJ=@WSZKJSJ");
			strSql.Append(" where SPHM=@SPHM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@NSRSWJGDM", DbType.String,9),
					new SQLiteParameter("@NSRSWJGMC", DbType.String,80),
					new SQLiteParameter("@SSSQ_Q", DbType.String,20),
					new SQLiteParameter("@SSSQ_Z", DbType.String,20),
					new SQLiteParameter("@SL", DbType.Decimal,9),
					new SQLiteParameter("@KSSL", DbType.String,20),
					new SQLiteParameter("@JKSJ", DbType.String,20),
					new SQLiteParameter("@SJJE", DbType.Decimal,9),
					new SQLiteParameter("@ZSXMDM", DbType.String,2),
					new SQLiteParameter("@ZSXMMC", DbType.String,80),
					new SQLiteParameter("@ZSPMDM", DbType.String,4),
					new SQLiteParameter("@ZSPMMC", DbType.String,80),
					new SQLiteParameter("@JYLXDM", DbType.String,8),
					new SQLiteParameter("@JYLXMC", DbType.String,80),
					new SQLiteParameter("@PZZLDM", DbType.String,5),
					new SQLiteParameter("@PZZLMC", DbType.String,80),
					new SQLiteParameter("@YHZH", DbType.String,12),
					new SQLiteParameter("@BZ", DbType.String,1000),
					new SQLiteParameter("@WSPZH", DbType.String,20),
					new SQLiteParameter("@ZSSWJGDM", DbType.String,11),
					new SQLiteParameter("@ZSSWJGMC", DbType.String,80),
					new SQLiteParameter("@WSZKJSJ", DbType.String,20)};
			parameters[0].Value = model.SPHM;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.NSRMC;
			parameters[3].Value = model.NSRSWJGDM;
			parameters[4].Value = model.NSRSWJGMC;
			parameters[5].Value = model.SSSQ_Q;
			parameters[6].Value = model.SSSQ_Z;
			parameters[7].Value = model.SL;
			parameters[8].Value = model.KSSL;
			parameters[9].Value = model.JKSJ;
			parameters[10].Value = model.SJJE;
			parameters[11].Value = model.ZSXMDM;
			parameters[12].Value = model.ZSXMMC;
			parameters[13].Value = model.ZSPMDM;
			parameters[14].Value = model.ZSPMMC;
			parameters[15].Value = model.JYLXDM;
			parameters[16].Value = model.JYLXMC;
			parameters[17].Value = model.PZZLDM;
			parameters[18].Value = model.PZZLMC;
			parameters[19].Value = model.YHZH;
			parameters[20].Value = model.BZ;
			parameters[21].Value = model.WSPZH;
			parameters[22].Value = model.ZSSWJGDM;
			parameters[23].Value = model.ZSSWJGMC;
			parameters[24].Value = model.WSZKJSJ;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

		#endregion  成员方法
	}
}

