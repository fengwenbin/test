using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类SBCLDAL。
	/// </summary>
	public partial class SBCLDAL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(tdps.Model.SBCL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from SBCL");
            strSql.Append(" where FileName=@FileName or SBXXID =@SBXXID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
                    new SQLiteParameter("@FileName", DbType.String,200)};
            parameters[0].Value = model.SBXXID;
            parameters[1].Value = model.FileName;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.SBCL model ,object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SBCL(");
            strSql.Append("SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,SBFSSJ,SBCLSJ,JYLSH,JMM,DZYZData,SBWJ,SBBZLMC,SBZL,SBSE,TSXX,SBCS,SSQQ,SSQZ,MW,SZ,FKDM,FKXX,FKSJ,FileName)");
            strSql.Append(" values (");
            strSql.Append("@SBXXID,@HZLX,@NSRSBH,@NSRMC,@SWJGMC,@SBFSSJ,@SBCLSJ,@JYLSH,@JMM,@DZYZData,@SBWJ,@SBBZLMC,@SBZL,@SBSE,@TSXX,@SBCS,@SSQQ,@SSQZ,@MW,@SZ,@FKDM,@FKXX,@FKSJ,@FileName)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@SBFSSJ", DbType.String,20),
					new SQLiteParameter("@SBCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@JMM", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBBZLMC", DbType.String,80),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@SBSE", DbType.Decimal,9),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@MW", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@FKSJ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200)};
            parameters[0].Value = model.SBXXID;
            parameters[1].Value = model.HZLX;
            parameters[2].Value = model.NSRSBH;
            parameters[3].Value = model.NSRMC;
            parameters[4].Value = model.SWJGMC;
            parameters[5].Value = model.SBFSSJ;
            parameters[6].Value = model.SBCLSJ;
            parameters[7].Value = model.JYLSH;
            parameters[8].Value = model.JMM;
            parameters[9].Value = model.DZYZData;
            parameters[10].Value = model.SBWJ;
            parameters[11].Value = model.SBBZLMC;
            parameters[12].Value = model.SBZL;
            parameters[13].Value = model.SBSE;
            parameters[14].Value = model.TSXX;
            parameters[15].Value = model.SBCS;
            parameters[16].Value = model.SSQQ;
            parameters[17].Value = model.SSQZ;
            parameters[18].Value = model.MW;
            parameters[19].Value = model.SZ;
            parameters[20].Value = model.FKDM;
            parameters[21].Value = model.FKXX;
            parameters[22].Value = model.FKSJ;
            parameters[23].Value = model.FileName;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.SBCL model,object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SBCL set ");
            strSql.Append("SBXXID=@SBXXID,");
            strSql.Append("HZLX=@HZLX,");
            strSql.Append("NSRSBH=@NSRSBH,");
            strSql.Append("NSRMC=@NSRMC,");
            strSql.Append("SWJGMC=@SWJGMC,");
            strSql.Append("SBFSSJ=@SBFSSJ,");
            strSql.Append("SBCLSJ=@SBCLSJ,");
            strSql.Append("JYLSH=@JYLSH,");
            strSql.Append("JMM=@JMM,");
            strSql.Append("DZYZData=@DZYZData,");
            strSql.Append("SBWJ=@SBWJ,");
            strSql.Append("SBBZLMC=@SBBZLMC,");
            strSql.Append("SBZL=@SBZL,");
            strSql.Append("SBSE=@SBSE,");
            strSql.Append("TSXX=@TSXX,");
            strSql.Append("SBCS=@SBCS,");
            strSql.Append("SSQQ=@SSQQ,");
            strSql.Append("SSQZ=@SSQZ,");
            strSql.Append("MW=@MW,");
            strSql.Append("SZ=@SZ,");
            strSql.Append("FKDM=@FKDM,");
            strSql.Append("FKXX=@FKXX,");
            strSql.Append("FKSJ=@FKSJ,");
            strSql.Append("FileName=@FileName");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@SBFSSJ", DbType.String,20),
					new SQLiteParameter("@SBCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@JMM", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBBZLMC", DbType.String,80),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@SBSE", DbType.Decimal,9),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@MW", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@FKSJ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200)};
            parameters[0].Value = model.FID;
            parameters[1].Value = model.SBXXID;
            parameters[2].Value = model.HZLX;
            parameters[3].Value = model.NSRSBH;
            parameters[4].Value = model.NSRMC;
            parameters[5].Value = model.SWJGMC;
            parameters[6].Value = model.SBFSSJ;
            parameters[7].Value = model.SBCLSJ;
            parameters[8].Value = model.JYLSH;
            parameters[9].Value = model.JMM;
            parameters[10].Value = model.DZYZData;
            parameters[11].Value = model.SBWJ;
            parameters[12].Value = model.SBBZLMC;
            parameters[13].Value = model.SBZL;
            parameters[14].Value = model.SBSE;
            parameters[15].Value = model.TSXX;
            parameters[16].Value = model.SBCS;
            parameters[17].Value = model.SSQQ;
            parameters[18].Value = model.SSQZ;
            parameters[19].Value = model.MW;
            parameters[20].Value = model.SZ;
            parameters[21].Value = model.FKDM;
            parameters[22].Value = model.FKXX;
            parameters[23].Value = model.FKSJ;
            parameters[24].Value = model.FileName;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SBCL ");
            strSql.Append(" where SBXXID=@SBXXID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
            parameters[0].Value = SBXXID;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 根据条件删除
        /// </summary>
        public void Delete(string where, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SBCL ");
            strSql.Append(" where 1=@SBXXID ");
            strSql.Append(" and " + where);

            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
            parameters[0].Value = 1;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.SBCL GetModelBySBXXID(int SBXXID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FID,SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,SBFSSJ,SBCLSJ,JYLSH,JMM,DZYZData,SBWJ,SBBZLMC,SBZL,SBSE,TSXX,SBCS,SSQQ,SSQZ,MW,SZ,FKDM,FKXX,FKSJ,FileName from SBCL ");
            strSql.Append(" where SBXXID=@SBXXID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
            parameters[0].Value = SBXXID;

            tdps.Model.SBCL model = new tdps.Model.SBCL();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["FID"].ToString() != "")
                {
                    model.FID = int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SBXXID"].ToString() != "")
                {
                    model.SBXXID = int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
                }
                model.HZLX = ds.Tables[0].Rows[0]["HZLX"].ToString();
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
                model.NSRMC = ds.Tables[0].Rows[0]["NSRMC"].ToString();
                model.SWJGMC = ds.Tables[0].Rows[0]["SWJGMC"].ToString();
                model.SBFSSJ = ds.Tables[0].Rows[0]["SBFSSJ"].ToString();
                model.SBCLSJ = ds.Tables[0].Rows[0]["SBCLSJ"].ToString();
                model.JYLSH = ds.Tables[0].Rows[0]["JYLSH"].ToString();
                model.JMM = ds.Tables[0].Rows[0]["JMM"].ToString();
                model.DZYZData = ds.Tables[0].Rows[0]["DZYZData"].ToString();
                model.SBWJ = ds.Tables[0].Rows[0]["SBWJ"].ToString();
                model.SBBZLMC = ds.Tables[0].Rows[0]["SBBZLMC"].ToString();
                model.SBZL = ds.Tables[0].Rows[0]["SBZL"].ToString();
                if (ds.Tables[0].Rows[0]["SBSE"].ToString() != "")
                {
                    model.SBSE = decimal.Parse(ds.Tables[0].Rows[0]["SBSE"].ToString());
                }
                model.TSXX = ds.Tables[0].Rows[0]["TSXX"].ToString();
                if (ds.Tables[0].Rows[0]["SBCS"].ToString() != "")
                {
                    model.SBCS = int.Parse(ds.Tables[0].Rows[0]["SBCS"].ToString());
                }
                model.SSQQ = ds.Tables[0].Rows[0]["SSQQ"].ToString();
                model.SSQZ = ds.Tables[0].Rows[0]["SSQZ"].ToString();
                model.MW = ds.Tables[0].Rows[0]["MW"].ToString();
                model.SZ = ds.Tables[0].Rows[0]["SZ"].ToString();
                model.FKDM = ds.Tables[0].Rows[0]["FKDM"].ToString();
                model.FKXX = ds.Tables[0].Rows[0]["FKXX"].ToString();
                model.FKSJ = ds.Tables[0].Rows[0]["FKSJ"].ToString();
                model.FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

		#endregion  成员方法
	}
}

