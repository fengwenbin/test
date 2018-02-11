using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
    /// <summary>
    /// 数据访问类NSRFZJGDAL。
    /// </summary>
    public partial class NSRFZJGDAL
    {
        public NSRFZJGDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string zjgNsrsbh, string fzjgNsrsbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(zjgNsrsbh) from NSRFZJG");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and fzjgNsrsbh=@fzjgNsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@zjgNsrsbh", DbType.String,50),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,50)};
            parameters[0].Value = zjgNsrsbh;
            parameters[1].Value = fzjgNsrsbh;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRFZJG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into NSRFZJG(");
            strSql.Append("nsrsbh,zjgNsrsbh,fzjgNsrsbh,fzjgMc,sxysSrze,sxysGzze,sxysZcze,sxysHj,fpbl,fpse,kjzg,LXDH,YYDZ,ND,rqQ,rqZ)");
            strSql.Append(" values (");
            strSql.Append("@nsrsbh,@zjgNsrsbh,@fzjgNsrsbh,@fzjgMc,@sxysSrze,@sxysGzze,@sxysZcze,@sxysHj,@fpbl,@fpse,@kjzg,@LXDH,@YYDZ,@ND,@rqQ,@rqZ)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,20),
					new SQLiteParameter("@zjgNsrsbh", DbType.String,20),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,20),
					new SQLiteParameter("@fzjgMc", DbType.String,80),
					new SQLiteParameter("@sxysSrze", DbType.Decimal,9),
					new SQLiteParameter("@sxysGzze", DbType.Decimal,9),
					new SQLiteParameter("@sxysZcze", DbType.Decimal,9),
					new SQLiteParameter("@sxysHj", DbType.Decimal,9),
					new SQLiteParameter("@fpbl", DbType.String,20),
					new SQLiteParameter("@fpse", DbType.Decimal,9),
					new SQLiteParameter("@kjzg", DbType.String,20),
					new SQLiteParameter("@LXDH", DbType.String,20),
					new SQLiteParameter("@YYDZ", DbType.String,100),
					new SQLiteParameter("@ND", DbType.String,4),
					new SQLiteParameter("@rqQ", DbType.String,20),
					new SQLiteParameter("@rqZ", DbType.String,20)};
            parameters[0].Value = model.nsrsbh;
            parameters[1].Value = model.zjgNsrsbh;
            parameters[2].Value = model.fzjgNsrsbh;
            parameters[3].Value = model.fzjgMc;
            parameters[4].Value = model.sxysSrze;
            parameters[5].Value = model.sxysGzze;
            parameters[6].Value = model.sxysZcze;
            parameters[7].Value = model.sxysHj;
            parameters[8].Value = model.fpbl;
            parameters[9].Value = model.fpse;
            parameters[10].Value = model.kjzg;
            parameters[11].Value = model.LXDH;
            parameters[12].Value = model.YYDZ;
            parameters[13].Value = model.ND;
            parameters[14].Value = model.rqQ;
            parameters[15].Value = model.rqZ;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.NSRFZJG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NSRFZJG set ");
            strSql.Append("nsrsbh=@nsrsbh,");
            strSql.Append("fzjgMc=@fzjgMc,");
            strSql.Append("sxysSrze=@sxysSrze,");
            strSql.Append("sxysGzze=@sxysGzze,");
            strSql.Append("sxysZcze=@sxysZcze,");
            strSql.Append("sxysHj=@sxysHj,");
            strSql.Append("fpbl=@fpbl,");
            strSql.Append("fpse=@fpse,");
            strSql.Append("kjzg=@kjzg,");
            strSql.Append("LXDH=@LXDH,");
            strSql.Append("YYDZ=@YYDZ,");
            strSql.Append("ND=@ND,");
            strSql.Append("rqQ=@rqQ,");
            strSql.Append("rqZ=@rqZ");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and fzjgNsrsbh=@fzjgNsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,20),
					new SQLiteParameter("@zjgNsrsbh", DbType.String,20),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,20),
					new SQLiteParameter("@fzjgMc", DbType.String,80),
					new SQLiteParameter("@sxysSrze", DbType.Decimal,9),
					new SQLiteParameter("@sxysGzze", DbType.Decimal,9),
					new SQLiteParameter("@sxysZcze", DbType.Decimal,9),
					new SQLiteParameter("@sxysHj", DbType.Decimal,9),
					new SQLiteParameter("@fpbl", DbType.String,20),
					new SQLiteParameter("@fpse", DbType.Decimal,9),
					new SQLiteParameter("@kjzg", DbType.String,20),
					new SQLiteParameter("@LXDH", DbType.String,20),
					new SQLiteParameter("@YYDZ", DbType.String,100),
					new SQLiteParameter("@ND", DbType.String,4),
					new SQLiteParameter("@rqQ", DbType.String,20),
					new SQLiteParameter("@rqZ", DbType.String,20) };
            parameters[0].Value = model.nsrsbh;
            parameters[1].Value = model.zjgNsrsbh;
            parameters[2].Value = model.fzjgNsrsbh;
            parameters[3].Value = model.fzjgMc;
            parameters[4].Value = model.sxysSrze;
            parameters[5].Value = model.sxysGzze;
            parameters[6].Value = model.sxysZcze;
            parameters[7].Value = model.sxysHj;
            parameters[8].Value = model.fpbl;
            parameters[9].Value = model.fpse;
            parameters[10].Value = model.kjzg;
            parameters[11].Value = model.LXDH;
            parameters[12].Value = model.YYDZ;
            parameters[13].Value = model.ND;
            parameters[14].Value = model.rqQ;
            parameters[15].Value = model.rqZ;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string zjgNsrsbh, string fzjgNsrsbh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRFZJG ");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and fzjgNsrsbh=@fzjgNsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@zjgNsrsbh", DbType.String,50),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,50)};
            parameters[0].Value = zjgNsrsbh;
            parameters[1].Value = fzjgNsrsbh;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.NSRFZJG GetModel(string zjgNsrsbh, string fzjgNsrsbh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nsrsbh,zjgNsrsbh,fzjgNsrsbh,fzjgMc,sxysSrze,sxysGzze,sxysZcze,sxysHj,fpbl,fpse,kjzg,LXDH,YYDZ,ND,rqQ,rqZ from NSRFZJG ");
            strSql.Append(" where zjgNsrsbh=@zjgNsrsbh and fzjgNsrsbh=@fzjgNsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@zjgNsrsbh", DbType.String,50),
					new SQLiteParameter("@fzjgNsrsbh", DbType.String,50)};
            parameters[0].Value = zjgNsrsbh;
            parameters[1].Value = fzjgNsrsbh;

            tdps.Model.NSRFZJG model = new tdps.Model.NSRFZJG();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.nsrsbh = ds.Tables[0].Rows[0]["nsrsbh"].ToString();
                model.zjgNsrsbh = ds.Tables[0].Rows[0]["zjgNsrsbh"].ToString();
                model.fzjgNsrsbh = ds.Tables[0].Rows[0]["fzjgNsrsbh"].ToString();
                model.fzjgMc = ds.Tables[0].Rows[0]["fzjgMc"].ToString();
                if (ds.Tables[0].Rows[0]["sxysSrze"].ToString() != "")
                {
                    model.sxysSrze = decimal.Parse(ds.Tables[0].Rows[0]["sxysSrze"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sxysGzze"].ToString() != "")
                {
                    model.sxysGzze = decimal.Parse(ds.Tables[0].Rows[0]["sxysGzze"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sxysZcze"].ToString() != "")
                {
                    model.sxysZcze = decimal.Parse(ds.Tables[0].Rows[0]["sxysZcze"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sxysHj"].ToString() != "")
                {
                    model.sxysHj = decimal.Parse(ds.Tables[0].Rows[0]["sxysHj"].ToString());
                }
                model.fpbl = ds.Tables[0].Rows[0]["fpbl"].ToString();
                if (ds.Tables[0].Rows[0]["fpse"].ToString() != "")
                {
                    model.fpse = decimal.Parse(ds.Tables[0].Rows[0]["fpse"].ToString());
                }
                model.kjzg = ds.Tables[0].Rows[0]["kjzg"].ToString();
                model.LXDH = ds.Tables[0].Rows[0]["LXDH"].ToString();
                model.YYDZ = ds.Tables[0].Rows[0]["YYDZ"].ToString();
                model.ND = ds.Tables[0].Rows[0]["ND"].ToString();
                model.rqQ = ds.Tables[0].Rows[0]["rqQ"].ToString();
                model.rqZ = ds.Tables[0].Rows[0]["rqZ"].ToString();

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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nsrsbh,zjgNsrsbh,fzjgNsrsbh,fzjgMc,sxysSrze,sxysGzze,sxysZcze,sxysHj,fpbl,fpse,kjzg,LXDH,YYDZ,ND,rqQ,rqZ ");
            strSql.Append(" FROM NSRFZJG");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by rqQ desc");
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }


        #endregion  成员方法
    }
}

