using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
    /// <summary>
    /// 数据访问类NSRZJGDAL。
    /// </summary>
    public partial class NSRZJGDAL
    {
        public NSRZJGDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string nsrsbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(nsrsbh) from NSRZJG");
            strSql.Append(" where nsrsbh=@nsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50)};
            parameters[0].Value = nsrsbh;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRZJG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into NSRZJG(");
            strSql.Append("nsrsbh,zjgNsrsbh,zjgMc,kjzg,LXDH,ND,SRZE,GZZE,ZCZE,HJ,QDZT)");
            strSql.Append(" values (");
            strSql.Append("@nsrsbh,@zjgNsrsbh,@zjgMc,@kjzg,@LXDH,@ND,@SRZE,@GZZE,@ZCZE,@HJ,@QDZT)");
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
					new SQLiteParameter("@HJ", DbType.Decimal,9),
                    new SQLiteParameter("@QDZT", DbType.String,1) };
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
            parameters[10].Value = model.QDZT;
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.NSRZJG model)
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
            strSql.Append("QDZT=@QDZT");
            strSql.Append(" where nsrsbh=@nsrsbh ");
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
					new SQLiteParameter("@HJ", DbType.Decimal,9),
                    new SQLiteParameter("@QDZT", DbType.String,1)};
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
            parameters[10].Value = model.QDZT;
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string nsrsbh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NSRZJG ");
            strSql.Append(" where nsrsbh=@nsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50)};
            parameters[0].Value = nsrsbh;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.NSRZJG GetModel(string nsrsbh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nsrsbh,zjgNsrsbh,zjgMc,kjzg,LXDH,ND,SRZE,GZZE,ZCZE,HJ,QDZT from NSRZJG ");
            strSql.Append(" where nsrsbh=@nsrsbh ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@nsrsbh", DbType.String,50)};
            parameters[0].Value = nsrsbh;

            tdps.Model.NSRZJG model = new tdps.Model.NSRZJG();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.nsrsbh = ds.Tables[0].Rows[0]["nsrsbh"].ToString();
                model.zjgNsrsbh = ds.Tables[0].Rows[0]["zjgNsrsbh"].ToString();
                model.zjgMc = ds.Tables[0].Rows[0]["zjgMc"].ToString();
                model.kjzg = ds.Tables[0].Rows[0]["kjzg"].ToString();
                model.LXDH = ds.Tables[0].Rows[0]["LXDH"].ToString();
                model.ND = ds.Tables[0].Rows[0]["ND"].ToString();
                if (ds.Tables[0].Rows[0]["SRZE"].ToString() != "")
                {
                    model.SRZE = decimal.Parse(ds.Tables[0].Rows[0]["SRZE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GZZE"].ToString() != "")
                {
                    model.GZZE = decimal.Parse(ds.Tables[0].Rows[0]["GZZE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ZCZE"].ToString() != "")
                {
                    model.ZCZE = decimal.Parse(ds.Tables[0].Rows[0]["ZCZE"].ToString());
                }
                if (ds.Tables[0].Rows[0]["HJ"].ToString() != "")
                {
                    model.HJ = decimal.Parse(ds.Tables[0].Rows[0]["HJ"].ToString());
                }
                model.QDZT = ds.Tables[0].Rows[0]["QDZT"].ToString();
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
            strSql.Append("select nsrsbh,zjgNsrsbh,zjgMc,kjzg,LXDH,ND,SRZE,GZZE,ZCZE,HJ,QDZT ");
            strSql.Append(" FROM NSRZJG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }


        #endregion  成员方法
    }
}

