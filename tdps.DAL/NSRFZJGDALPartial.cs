using System;
using System.Collections.Generic;
using System.Text;
using tdps.Model;
using System.Data;
using tdps.DBUtility;
using System.Data.SQLite;

namespace tdps.DAL
{
    public partial class NSRFZJGDAL
    {
        public IList<NSRFZJG> GetModelListBySqlStr(string sql)
        {
            IDataReader dr = null;
            List<NSRFZJG> fzjgList = new List<NSRFZJG>();
            using (dr = SQLiteHelper.ExecuteReader(sql))
            {
                while (dr.Read())
                {
                    NSRFZJG model = new NSRFZJG();
                    if (dr["nsrsbh"] != DBNull.Value)
                        model.nsrsbh = dr["nsrsbh"].ToString();
                    if (dr["zjgNsrsbh"] != DBNull.Value)
                        model.zjgNsrsbh = dr["zjgNsrsbh"].ToString();
                    if (dr["fzjgNsrsbh"] != DBNull.Value)
                        model.fzjgNsrsbh = dr["fzjgNsrsbh"].ToString();
                    if (dr["fzjgMc"] != DBNull.Value)
                        model.fzjgMc = dr["fzjgMc"].ToString();
                    if (dr["sxysSrze"] != DBNull.Value)
                    {
                        model.sxysSrze = decimal.Parse(dr["sxysSrze"].ToString());
                    }
                    if (dr["sxysGzze"] != DBNull.Value)
                    {
                        model.sxysGzze = decimal.Parse(dr["sxysGzze"].ToString());
                    }
                    if (dr["sxysZcze"] != DBNull.Value)
                    {
                        model.sxysZcze = decimal.Parse(dr["sxysZcze"].ToString());
                    }
                    if (dr["sxysHj"] != DBNull.Value)
                    {
                        model.sxysHj = decimal.Parse(dr["sxysHj"].ToString());
                    }
                    if (dr["fpbl"] != DBNull.Value)
                        model.fpbl = dr["fpbl"].ToString();
                    if (dr["fpse"] != DBNull.Value)
                    {
                        model.fpse = decimal.Parse(dr["fpse"].ToString());
                    }
                    if (dr["kjzg"] != DBNull.Value)
                        model.kjzg = dr["kjzg"].ToString();
                    if (dr["LXDH"] != DBNull.Value)
                        model.LXDH = dr["LXDH"].ToString();
                    if (dr["YYDZ"] != DBNull.Value)
                        model.YYDZ = dr["YYDZ"].ToString();
                    if (dr["ND"] != DBNull.Value)
                        model.ND = dr["ND"].ToString();
                    if (dr["rqQ"] != DBNull.Value)
                        model.rqQ = dr["rqQ"].ToString();
                    if (dr["rqZ"] != DBNull.Value)
                        model.rqZ = dr["rqZ"].ToString();
                    fzjgList.Add(model);
                }
            }
            return fzjgList;
        }
        /// <summary>
        /// 根据sql获取数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>数据集</returns>
        public DataTable GetDataTableBySqlStr(string sql)
        {
            DataTable dt = null;
            DataSet ds = null;
            using (ds = SQLiteHelper.ExecuteDataSet(sql))
            {
                if (ds != null)
                    dt = ds.Tables[0];
            }
            return dt;
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(NSRFZJG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(zjgNsrsbh) from NSRFZJG");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and fzjgNsrsbh=@fzjgNsrsbh and nd=@nd");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@zjgNsrsbh", DbType.String,50),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,50),
                                           new SQLiteParameter("@nd",DbType.String,4)};
            parameters[0].Value = model.zjgNsrsbh;
            parameters[1].Value = model.fzjgNsrsbh;
            parameters[2].Value = model.ND;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string zjgNsrsbh, string fzjgNsrsbh, string nd)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRFZJG ");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and fzjgNsrsbh=@fzjgNsrsbh and nd=@nd ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@zjgNsrsbh", DbType.String,50),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,50),
                                           new SQLiteParameter("@nd", DbType.String,4)};
            parameters[0].Value = zjgNsrsbh;
            parameters[1].Value = fzjgNsrsbh;
            parameters[2].Value = nd;

            return SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 删除某个总机构下某年度所有分支机构数据
        /// </summary>
        public int DeleteAllByZjgandNd(string zjgNsrsbh, string nd)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRFZJG ");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and nd=@nd ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@zjgNsrsbh", DbType.String,50),
                                           new SQLiteParameter("@nd", DbType.String,4)};
            parameters[0].Value = zjgNsrsbh;
            parameters[1].Value = nd;

            return SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新分支机构的新的总机构纳税人识别号。
        /// </summary>
        public int Update(string zjgNsrsbh_old, string zjgNsrsbh_new, object tran)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NSRFZJG set zjgNsrsbh=@new_zjgNsrsbh ");
            strSql.Append(" where zjgNsrsbh=@old_zjgNsrsbh");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@new_zjgNsrsbh", DbType.String,50),
					new SQLiteParameter("@old_zjgNsrsbh", DbType.String,50)
                                           };
            parameters[0].Value = zjgNsrsbh_new;
            parameters[1].Value = zjgNsrsbh_old;

            return SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)tran, parameters);
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public int Update(string strSql, object tran)
        {
            return SQLiteHelper.ExecuteNonQueryByTransaction(strSql, (SQLiteTransaction)tran, null);
        }
        /// <summary>
        /// 计算分配比例
        /// </summary>
        /// <param name="nd">年度</param>
        /// <param name="zjgnsrsbh">年度</param>
        /// <param name="xsw">分配比例的小数位</param>
        /// <returns>影响的行数</returns>
        public int ComputeScale(string nd, string zjgnsrsbh,int xsw)
        {
            string sql = @"SELECT sum(sxyssrze) AS TOTALSRZE,
sum(sxysGzze) AS TOTALGZZE,
SUM(sxysZcze) AS TOTALZCZE
FROM NSRFZJG WHERE ND=@nd and ZJGNSRSBH=@zjgnsrsbh ";
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nd", DbType.String,4),
                    new SQLiteParameter("@zjgnsrsbh",DbType.String,40)
                                           };
            parameters[0].Value = nd;
            parameters[1].Value = zjgnsrsbh;
            SQLiteParameter[] fzjgparam = {
                    new SQLiteParameter("@fpbl", DbType.String,20),
					new SQLiteParameter("@nd", DbType.String,4),
                    new SQLiteParameter("@fzjgnsrsbh", DbType.String,20)
                                           };
            //取出所有工资总额
            int count = 0;
            DataSet ds = SQLiteHelper.ExecuteDataSet(sql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {

                double totalsrze = double.Parse(ds.Tables[0].Rows[0]["TOTALSRZE"].ToString());
                double totalgzze = double.Parse(ds.Tables[0].Rows[0]["TOTALGZZE"].ToString());
                double totalzcze = double.Parse(ds.Tables[0].Rows[0]["TOTALZCZE"].ToString());
                sql = @"select * from nsrfzjg where nd=@nd and zjgnsrsbh=@zjgnsrsbh ";
                DataSet fzjgds = SQLiteHelper.ExecuteDataSet(sql, parameters);

                if (fzjgds != null && fzjgds.Tables[0].Rows.Count == 1)
                {
                    double fpbl = 1;
                    fzjgparam[0].Value = fpbl.ToString();
                    fzjgparam[1].Value = nd;
                    fzjgparam[2].Value = fzjgds.Tables[0].Rows[0]["fzjgnsrsbh"].ToString();
                    sql = @"update nsrfzjg set fpbl=@fpbl where nd=@nd and fzjgnsrsbh=@fzjgnsrsbh";
                    count += SQLiteHelper.ExecuteNonQuery(sql, fzjgparam);
                }
                else
                {
                    for (int i = 0; i < fzjgds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = fzjgds.Tables[0].Rows[i];
                        double srze = double.Parse(row["sxyssrze"].ToString());
                        double gzze = double.Parse(row["sxysGzze"].ToString());
                        double zcze = double.Parse(row["sxysZcze"].ToString());
                        double fpbl = Math.Round(Math.Round(totalsrze > 0 ? srze / totalsrze * 0.35 : 0, xsw, MidpointRounding.AwayFromZero) + Math.Round(totalgzze > 0 ? gzze / totalgzze * 0.35 : 0, xsw, MidpointRounding.AwayFromZero) + Math.Round(totalzcze > 0 ? zcze / totalzcze * 0.3 : 0, xsw, MidpointRounding.AwayFromZero), xsw);
                        //if(xsw==10)
                        //    fzjgparam[0].Value = fpbl.ToString("f10");
                        //else
                        //    fzjgparam[0].Value = fpbl.ToString("f6");
                        fzjgparam[0].Value = fpbl.ToString(string.Format("f{0}", xsw));
                        fzjgparam[1].Value = nd;
                        fzjgparam[2].Value = row["fzjgnsrsbh"].ToString();
                        sql = @"update nsrfzjg set fpbl=@fpbl where nd=@nd and fzjgnsrsbh=@fzjgnsrsbh";
                        count += SQLiteHelper.ExecuteNonQuery(sql, fzjgparam);
                    }
                }
            }
            return count;
        }
    }
}
