using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
    /// <summary>
    /// 数据访问类NSRXXDAL。
    /// </summary>
    public partial class NSRXXDAL
    {
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRXX model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into NSRXX(");
            strSql.Append("NSRSBH,NSRMC,FDDBRMC,ZCDZ,YYDZ,DHHM,YB,QYHGDM,FileName,fdqnsr,fdqrqq,fdqrqz,hzqynsr,hzqyrqq,hzqyrqz,TDPSID,DQSJ,NFYDQ,TSYHLX,SHXYDM)");
            strSql.Append(" values (");
            strSql.Append("@NSRSBH,@NSRMC,@FDDBRMC,@ZCDZ,@YYDZ,@DHHM,@YB,@QYHGDM,@FileName,@fdqnsr,@fdqrqq,@fdqrqz,@hzqynsr,@hzqyrqq,@hzqyrqz,@TDPSID,@DQSJ,@NFYDQ,@TSYHLX,@SHXYDM)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@NSRSBH", DbType.String,20),
                    new SQLiteParameter("@NSRMC", DbType.String,80),
                    new SQLiteParameter("@FDDBRMC", DbType.String,70),
                    new SQLiteParameter("@ZCDZ", DbType.String,80),
                    new SQLiteParameter("@YYDZ", DbType.String,80),
                    new SQLiteParameter("@DHHM", DbType.String,20),
                    new SQLiteParameter("@YB", DbType.String,20),
                    new SQLiteParameter("@QYHGDM", DbType.String,20),
					//new SQLiteParameter("@SBMM", DbType.String,8),
					new SQLiteParameter("@FileName", DbType.String,50),
                    new SQLiteParameter("@fdqnsr", DbType.String,1),
                    new SQLiteParameter("@fdqrqq", DbType.String,20),
                    new SQLiteParameter("@fdqrqz", DbType.String,20),
                    new SQLiteParameter("@hzqynsr", DbType.String,1),
                    new SQLiteParameter("@hzqyrqq", DbType.String,20),
                    new SQLiteParameter("@hzqyrqz", DbType.String,20),
                    new SQLiteParameter("@TDPSID", DbType.String,20),
                    new SQLiteParameter("@DQSJ", DbType.String,20),
                    new SQLiteParameter("@NFYDQ", DbType.String,1),
                    new SQLiteParameter("@TSYHLX", DbType.String,10),
                    new SQLiteParameter("@SHXYDM", DbType.String,50)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.NSRMC;
            parameters[2].Value = model.FDDBRMC;
            parameters[3].Value = model.ZCDZ;
            parameters[4].Value = model.YYDZ;
            parameters[5].Value = model.DHHM;
            parameters[6].Value = model.YB;
            parameters[7].Value = model.QYHGDM;
            //parameters[8].Value = model.SBMM;
            parameters[8].Value = model.FileName;
            parameters[9].Value = model.FDQNSR;
            parameters[10].Value = model.fdqrqq;
            parameters[11].Value = model.fdqrqz;
            parameters[12].Value = model.hzqynsr;
            parameters[13].Value = model.hzqyrqq;
            parameters[14].Value = model.hzqyrqz;
            parameters[15].Value = model.TDPSID;
            parameters[16].Value = model.DQSJ;
            parameters[17].Value = model.NFYDQ;
            parameters[18].Value = model.TSYHLX;
            parameters[19].Value = model.SHXYDM;
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.NSRXX model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NSRXX set ");
            strSql.Append("NSRMC=@NSRMC,");
            strSql.Append("FDDBRMC=@FDDBRMC,");
            strSql.Append("ZCDZ=@ZCDZ,");
            strSql.Append("YYDZ=@YYDZ,");
            strSql.Append("DHHM=@DHHM,");
            strSql.Append("YB=@YB,");
            strSql.Append("QYHGDM=@QYHGDM,");
            //strSql.Append("SBMM=@SBMM,");
            strSql.Append("FileName=@FileName,");
            strSql.Append("fdqnsr=@fdqnsr,");
            strSql.Append("fdqrqq=@fdqrqq,");
            strSql.Append("fdqrqz=@fdqrqz,");
            strSql.Append("hzqynsr=@hzqynsr,");
            strSql.Append("hzqyrqq=@hzqyrqq,");
            strSql.Append("hzqyrqz=@hzqyrqz,");
            strSql.Append("TDPSID=@TDPSID,");
            strSql.Append("DQSJ=@DQSJ,");
            strSql.Append("NFYDQ=@NFYDQ,");
            strSql.Append("TSYHLX=@TSYHLX,");
            strSql.Append("SHXYDM=@SHXYDM");
            strSql.Append(" where NSRSBH=@NSRSBH ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@NSRSBH", DbType.String,20),
                    new SQLiteParameter("@NSRMC", DbType.String,80),
                    new SQLiteParameter("@FDDBRMC", DbType.String,70),
                    new SQLiteParameter("@ZCDZ", DbType.String,80),
                    new SQLiteParameter("@YYDZ", DbType.String,80),
                    new SQLiteParameter("@DHHM", DbType.String,20),
                    new SQLiteParameter("@YB", DbType.String,20),
                    new SQLiteParameter("@QYHGDM", DbType.String,20),
					//new SQLiteParameter("@SBMM", DbType.String,8),
					new SQLiteParameter("@FileName", DbType.String,50),
                    new SQLiteParameter("@fdqnsr", DbType.String,1),
                    new SQLiteParameter("@fdqrqq", DbType.String,20),
                    new SQLiteParameter("@fdqrqz", DbType.String,20),
                    new SQLiteParameter("@hzqynsr", DbType.String,1),
                    new SQLiteParameter("@hzqyrqq", DbType.String,20),
                    new SQLiteParameter("@hzqyrqz", DbType.String,20),
                    new SQLiteParameter("@TDPSID", DbType.String,20),
                    new SQLiteParameter("@DQSJ", DbType.String,20),
                                           new SQLiteParameter("@NFYDQ", DbType.String,1),
                                           new SQLiteParameter("@TSYHLX", DbType.String,10),
                                           new SQLiteParameter("@SHXYDM", DbType.String,50)
   };
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.NSRMC;
            parameters[2].Value = model.FDDBRMC;
            parameters[3].Value = model.ZCDZ;
            parameters[4].Value = model.YYDZ;
            parameters[5].Value = model.DHHM;
            parameters[6].Value = model.YB;
            parameters[7].Value = model.QYHGDM;
            //parameters[8].Value = model.SBMM;
            parameters[8].Value = model.FileName;
            parameters[9].Value = model.FDQNSR;
            parameters[10].Value = model.fdqrqq;
            parameters[11].Value = model.fdqrqz;
            parameters[12].Value = model.hzqynsr;
            parameters[13].Value = model.hzqyrqq;
            parameters[14].Value = model.hzqyrqz;
            parameters[15].Value = model.TDPSID;
            parameters[16].Value = model.DQSJ;
            parameters[17].Value = model.NFYDQ;
            parameters[18].Value = model.TSYHLX;
            parameters[19].Value = model.SHXYDM;
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 修改申报密码
        /// </summary>
        /// <param name="nsrsbh"></param>
        /// <param name="sbmm"></param>
        /// <returns></returns>
        public int UpdateSBMM(string nsrsbh, string sbmm)
        {
            string sql = "update NSRXX set SBMM='" + sbmm + "' where NSRSBH='" + nsrsbh + "'";
            return SQLiteHelper.ExecuteSql(sql);
        }
        #endregion  成员方法
    }
}

