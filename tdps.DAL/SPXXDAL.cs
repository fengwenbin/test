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
		public SPXXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SPHM)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(SPHM) from SPXX");
			strSql.Append(" where SPHM=@SPHM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50)};
			parameters[0].Value = SPHM;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SPXX model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SPXX model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string SPHM)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SPXX ");
			strSql.Append(" where SPHM=@SPHM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50)};
			parameters[0].Value = SPHM;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete1(string SPHM)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SPXX ");
            strSql.Append(" where SPHM=@SPHM or BZ=@SPHM");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50)};
            parameters[0].Value = SPHM;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SPXX GetModel(string SPHM)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SPHM,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,SSSQ_Q,SSSQ_Z,SL,KSSL,JKSJ,SJJE,ZSXMDM,ZSXMMC,ZSPMDM,ZSPMMC,JYLXDM,JYLXMC,PZZLDM,PZZLMC,YHZH,BZ,WSPZH,ZSSWJGDM,ZSSWJGMC,WSZKJSJ from SPXX ");
			strSql.Append(" where SPHM=@SPHM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50)};
			parameters[0].Value = SPHM;

			tdps.Model.SPXX model=new tdps.Model.SPXX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.SPHM=ds.Tables[0].Rows[0]["SPHM"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.NSRSWJGDM=ds.Tables[0].Rows[0]["NSRSWJGDM"].ToString();
				model.NSRSWJGMC=ds.Tables[0].Rows[0]["NSRSWJGMC"].ToString();
				model.SSSQ_Q=ds.Tables[0].Rows[0]["SSSQ_Q"].ToString();
				model.SSSQ_Z=ds.Tables[0].Rows[0]["SSSQ_Z"].ToString();
				if(ds.Tables[0].Rows[0]["SL"].ToString()!="")
				{
					model.SL=decimal.Parse(ds.Tables[0].Rows[0]["SL"].ToString());
				}
				model.KSSL=ds.Tables[0].Rows[0]["KSSL"].ToString();
				model.JKSJ=ds.Tables[0].Rows[0]["JKSJ"].ToString();
				if(ds.Tables[0].Rows[0]["SJJE"].ToString()!="")
				{
					model.SJJE=decimal.Parse(ds.Tables[0].Rows[0]["SJJE"].ToString());
				}
				model.ZSXMDM=ds.Tables[0].Rows[0]["ZSXMDM"].ToString();
				model.ZSXMMC=ds.Tables[0].Rows[0]["ZSXMMC"].ToString();
				model.ZSPMDM=ds.Tables[0].Rows[0]["ZSPMDM"].ToString();
				model.ZSPMMC=ds.Tables[0].Rows[0]["ZSPMMC"].ToString();
				model.JYLXDM=ds.Tables[0].Rows[0]["JYLXDM"].ToString();
				model.JYLXMC=ds.Tables[0].Rows[0]["JYLXMC"].ToString();
				model.PZZLDM=ds.Tables[0].Rows[0]["PZZLDM"].ToString();
				model.PZZLMC=ds.Tables[0].Rows[0]["PZZLMC"].ToString();
				model.YHZH=ds.Tables[0].Rows[0]["YHZH"].ToString();
				model.BZ=ds.Tables[0].Rows[0]["BZ"].ToString();
				model.WSPZH=ds.Tables[0].Rows[0]["WSPZH"].ToString();
				model.ZSSWJGDM=ds.Tables[0].Rows[0]["ZSSWJGDM"].ToString();
				model.ZSSWJGMC=ds.Tables[0].Rows[0]["ZSSWJGMC"].ToString();
				model.WSZKJSJ=ds.Tables[0].Rows[0]["WSZKJSJ"].ToString();
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
        public tdps.Model.SPXX GetModel1(string SPHM)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SPHM,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,SSSQ_Q,SSSQ_Z,SL,KSSL,JKSJ,SJJE,ZSXMDM,ZSXMMC,ZSPMDM,ZSPMMC,JYLXDM,JYLXMC,PZZLDM,PZZLMC,YHZH,BZ,WSPZH,ZSSWJGDM,ZSSWJGMC,WSZKJSJ from SPXX ");
            strSql.Append(" where SPHM=@SPHM or BZ=@SPHM Limit 1");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,50)};
            parameters[0].Value = SPHM;

            tdps.Model.SPXX model = new tdps.Model.SPXX();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.SPHM = ds.Tables[0].Rows[0]["SPHM"].ToString();
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
                model.NSRMC = ds.Tables[0].Rows[0]["NSRMC"].ToString();
                model.NSRSWJGDM = ds.Tables[0].Rows[0]["NSRSWJGDM"].ToString();
                model.NSRSWJGMC = ds.Tables[0].Rows[0]["NSRSWJGMC"].ToString();
                model.SSSQ_Q = ds.Tables[0].Rows[0]["SSSQ_Q"].ToString();
                model.SSSQ_Z = ds.Tables[0].Rows[0]["SSSQ_Z"].ToString();
                if (ds.Tables[0].Rows[0]["SL"].ToString() != "")
                {
                    model.SL = decimal.Parse(ds.Tables[0].Rows[0]["SL"].ToString());
                }
                model.KSSL = ds.Tables[0].Rows[0]["KSSL"].ToString();
                model.JKSJ = ds.Tables[0].Rows[0]["JKSJ"].ToString();
                if (ds.Tables[0].Rows[0]["SJJE"].ToString() != "")
                {
                    model.SJJE = decimal.Parse(ds.Tables[0].Rows[0]["SJJE"].ToString());
                }
                model.ZSXMDM = ds.Tables[0].Rows[0]["ZSXMDM"].ToString();
                model.ZSXMMC = ds.Tables[0].Rows[0]["ZSXMMC"].ToString();
                model.ZSPMDM = ds.Tables[0].Rows[0]["ZSPMDM"].ToString();
                model.ZSPMMC = ds.Tables[0].Rows[0]["ZSPMMC"].ToString();
                model.JYLXDM = ds.Tables[0].Rows[0]["JYLXDM"].ToString();
                model.JYLXMC = ds.Tables[0].Rows[0]["JYLXMC"].ToString();
                model.PZZLDM = ds.Tables[0].Rows[0]["PZZLDM"].ToString();
                model.PZZLMC = ds.Tables[0].Rows[0]["PZZLMC"].ToString();
                model.YHZH = ds.Tables[0].Rows[0]["YHZH"].ToString();
                model.BZ = ds.Tables[0].Rows[0]["BZ"].ToString();
                model.WSPZH = ds.Tables[0].Rows[0]["WSPZH"].ToString();
                model.ZSSWJGDM = ds.Tables[0].Rows[0]["ZSSWJGDM"].ToString();
                model.ZSSWJGMC = ds.Tables[0].Rows[0]["ZSSWJGMC"].ToString();
                model.WSZKJSJ = ds.Tables[0].Rows[0]["WSZKJSJ"].ToString();
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
			strSql.Append("select SPHM,NSRSBH,NSRMC,NSRSWJGDM,NSRSWJGMC,SSSQ_Q,SSSQ_Z,SL,KSSL,JKSJ,SJJE,ZSXMDM,ZSXMMC,ZSPMDM,ZSPMMC,JYLXDM,JYLXMC,PZZLDM,PZZLMC,YHZH,BZ,WSPZH,ZSSWJGDM,ZSSWJGMC,WSZKJSJ ");
			strSql.Append(" FROM SPXX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

