using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using System.Data;
using tdps.Model;

namespace tdps.DAL
{
    public partial class NSRZJGDAL
    {
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(tdps.Model.NSRZJG model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NSRZJG set ");
            strSql.Append("zjgNsrsbh=@zjgNsrsbh,");
            strSql.Append("zjgMc=@zjgMc,");
            strSql.Append("kjzg=@kjzg,");
            strSql.Append("LXDH=@LXDH,");
            strSql.Append("ND=@ND,");
            strSql.Append("SRZE=@SRZE,");
            strSql.Append("GZZE=@GZZE,");
            strSql.Append("ZCZE=@ZCZE,");
            strSql.Append("HJ=@HJ");
            strSql.Append(" where zjgnsrsbh=@nsrsbh and ND=@ND");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,20),
					new SQLiteParameter("@zjgNsrsbh", DbType.String,20),
					new SQLiteParameter("@zjgMc", DbType.String,80),
					new SQLiteParameter("@kjzg", DbType.String,20),
					new SQLiteParameter("@LXDH", DbType.String,20),
					new SQLiteParameter("@ND", DbType.String,4),
					new SQLiteParameter("@SRZE", DbType.Decimal,9),
					new SQLiteParameter("@GZZE", DbType.Decimal,9),
					new SQLiteParameter("@ZCZE", DbType.Decimal,9),
					new SQLiteParameter("@HJ", DbType.Decimal,9)};
            parameters[0].Value = model.nsrsbh;
            parameters[1].Value = model.zjgNsrsbh;
            parameters[2].Value = model.zjgMc;
            parameters[3].Value = model.kjzg;
            parameters[4].Value = model.LXDH;
            parameters[5].Value = model.ND;
            parameters[6].Value = model.SRZE;
            parameters[7].Value = model.GZZE;
            parameters[8].Value = model.ZCZE;
            parameters[9].Value = model.HJ;

            return SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 通过SQL语句更新数据
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public int Update(string strSQL, object trans)
        {
            if (trans != null)
                return SQLiteHelper.ExecuteNonQueryByTransaction(strSQL, (SQLiteTransaction)trans, null);
            else
                return SQLiteHelper.ExecuteNonQuery(strSQL, null);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string nsrsbh, string nd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRZJG ");
            strSql.Append(" where nsrsbh=@nsrsbh and nd=@nd ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50),
                                            new SQLiteParameter("@nd", DbType.String,4)};
            parameters[0].Value = nsrsbh;
            parameters[1].Value = nd;
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="nsrsbh">总机构纳税人识别号</param>
        /// <param name="nd">年度</param>
        /// <returns>是否存在记录</returns>
        public bool Exists(string nsrsbh, string nd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(nsrsbh) from NSRZJG");
            strSql.Append(" where zjgnsrsbh=@nsrsbh and nd=@nd ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50),
                                           new SQLiteParameter("@nd", DbType.String,4)};
            parameters[0].Value = nsrsbh;
            parameters[1].Value = nd;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }
        public NSRZJG GetSumInfoByNsrsbhNd(string nsrsbh, string nd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                @"select NSRZJG.GZZE,mm.fzjggzze,
NSRZJG.ZCZE,mm.fzjgzcze,NSRZJG.SRZE,mm.fzjgSrze
 from NSRZJG  
LEFT JOIN (select sum(NSRFZJG.sxysGzze) as fzjggzze,sum(NSRFZJG.sxysZcze)
as fzjgzcze,sum(NSRFZJG.sxysSrze)as fzjgSrze,nsrsbh,ND from NSRFZJG GROUP BY nsrsbh,ND) mm
on mm.nsrsbh=NSRZJG.nsrsbh and mm.ND=NSRZJG.ND 
where NSRZJG.nsrsbh=@nsrsbh and NSRZJG.nd=@nd ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50),
                                           new SQLiteParameter("@nd", DbType.String,4)};
            parameters[0].Value = nsrsbh;
            parameters[1].Value = nd;
            NSRZJG zjg = new NSRZJG();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow row = ds.Tables[0].Rows[i];
                    zjg.GZZE = Convert.ToDecimal(row["GZZE"].ToString());
                    zjg.ZCZE = Convert.ToDecimal(row["ZCZE"].ToString());
                    zjg.SRZE = Convert.ToDecimal(row["SRZE"].ToString());
                    NSRFZJG fzjg = new NSRFZJG();
                    if (row["fzjggzze"] != DBNull.Value)
                        fzjg.sxysGzze = Convert.ToDecimal(row["fzjggzze"].ToString());
                    if (row["fzjgzcze"] != DBNull.Value)
                        fzjg.sxysZcze = Convert.ToDecimal(row["fzjgzcze"].ToString());
                    if (row["fzjgSrze"] != DBNull.Value)
                        fzjg.sxysSrze = Convert.ToDecimal(row["fzjgSrze"].ToString());
                    zjg.NSRFZJG = fzjg;
                }
            }
            return zjg;
        }
        /// <summary>
        /// 获取纳税人各种资产汇总值
        /// </summary>
        /// <param name="nsrsbh">总机构纳税人识别号</param>
        /// <param name="nd">年度</param>
        /// <param name="pcNsrfzjgbh">要排除的分支机构纳税人识别号</param>
        /// <returns>装载总机构及分支机构资产数据的对象</returns>
        public NSRZJG GetSumInfoByNsrsbhNd(string nsrsbh, string nd, string pcNsrfzjgbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                @"select NSRZJG.GZZE,mm.fzjggzze,
NSRZJG.ZCZE,mm.fzjgzcze,NSRZJG.SRZE,mm.fzjgSrze
 from NSRZJG  
LEFT JOIN (select sum(NSRFZJG.sxysGzze) as fzjggzze,sum(NSRFZJG.sxysZcze)
as fzjgzcze,sum(NSRFZJG.sxysSrze)as fzjgSrze,nsrsbh,ND from NSRFZJG where fzjgnsrsbh !=@fzjgnsrsbh GROUP BY nsrsbh,ND) mm
on mm.nsrsbh=NSRZJG.nsrsbh and mm.ND=NSRZJG.ND 
where NSRZJG.nsrsbh=@nsrsbh and NSRZJG.nd=@nd ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50),
                    new SQLiteParameter("@fzjgnsrsbh",DbType.String,50), 
                                           new SQLiteParameter("@nd", DbType.String,4)};
            parameters[0].Value = nsrsbh;
            parameters[1].Value = pcNsrfzjgbh;
            parameters[2].Value = nd;
            NSRZJG zjg = new NSRZJG();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow row = ds.Tables[0].Rows[i];
                    zjg.GZZE = Convert.ToDecimal(row["GZZE"].ToString());
                    zjg.ZCZE = Convert.ToDecimal(row["ZCZE"].ToString());
                    zjg.SRZE = Convert.ToDecimal(row["SRZE"].ToString());
                    NSRFZJG fzjg = new NSRFZJG();
                    if (row["fzjggzze"] != DBNull.Value)
                        fzjg.sxysGzze = Convert.ToDecimal(row["fzjggzze"].ToString());
                    if (row["fzjgzcze"] != DBNull.Value)
                        fzjg.sxysZcze = Convert.ToDecimal(row["fzjgzcze"].ToString());
                    if (row["fzjgSrze"] != DBNull.Value)
                        fzjg.sxysSrze = Convert.ToDecimal(row["fzjgSrze"].ToString());
                    zjg.NSRFZJG = fzjg;
                }
            }
            return zjg;
        }
    }
}
