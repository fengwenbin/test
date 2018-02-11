using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using System.Data;
namespace tdps.DAL
{
    /// <summary>
    /// 数据访问类BBJYTJDAL。
    /// </summary>
    public class BBJYTJDAL
    {

        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SBXXID, string JYLXCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from DLFWQSZ");
            strSql.Append(" where SBXXID=@SBXXID and JYLXCODE=@JYLXCODE");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),new SQLiteParameter("@JYLXCODE", DbType.String,10)};
            parameters[0].Value = SBXXID;
            parameters[1].Value = JYLXCODE;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.BBJYTJ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into BBJYTJ(");
            strSql.Append("NSRSBH,SBZLCODE,SSQQ,SSQZ,JYLXCODE,JYLXCOUNT,SBXXID)");
            strSql.Append(" values (");
            strSql.Append("@NSRSBH,@SBZLCODE,@SSQQ,@SSQZ,@JYLXCODE,@JYLXCOUNT,@SBXXID)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@SBZLCODE", DbType.String,20),
                    new SQLiteParameter("@SSQQ", DbType.String,20),
                    new SQLiteParameter("@SSQZ", DbType.String,20),
                    new SQLiteParameter("@JYLXCODE", DbType.String,20),
                    new SQLiteParameter("@JYLXCOUNT", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4)                       
                                           };
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.SBZLCODE;
            parameters[2].Value = model.SSQQ;
            parameters[3].Value = model.SSQZ;
            parameters[4].Value = model.JYLXCODE;
            parameters[5].Value = model.JYLXCOUNT;
            parameters[6].Value = model.SBXXID;


            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.BBJYTJ model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into BBJYTJ(");
            strSql.Append("NSRSBH,SBZLCODE,SSQQ,SSQZ,JYLXCODE,JYLXCOUNT,SBXXID)");
            strSql.Append(" values (");
            strSql.Append("@NSRSBH,@SBZLCODE,@SSQQ,@SSQZ,@JYLXCODE,@JYLXCOUNT,@SBXXID)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@SBZLCODE", DbType.String,20),
                    new SQLiteParameter("@SSQQ", DbType.String,20),
                    new SQLiteParameter("@SSQZ", DbType.String,20),
                    new SQLiteParameter("@JYLXCODE", DbType.String,20),
                    new SQLiteParameter("@JYLXCOUNT", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4)                       
                                           };
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.SBZLCODE;
            parameters[2].Value = model.SSQQ;
            parameters[3].Value = model.SSQZ;
            parameters[4].Value = model.JYLXCODE;
            parameters[5].Value = model.JYLXCOUNT;
            parameters[6].Value = model.SBXXID;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(),(SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string SBXXID,string JYLXCODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from BBJYTJ ");
            strSql.Append(" where SBXXID=@SBXXID ");
            strSql.Append(" and JYLXCODE=@JYLXCODE ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),new SQLiteParameter("@JYLXCODE", DbType.String,10)};
            parameters[0].Value = SBXXID;
            parameters[1].Value = JYLXCODE;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }


        public void Delete(string SBXXID, string JYLXCODE, object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from BBJYTJ ");
            strSql.Append(" where SBXXID=@SBXXID ");
            strSql.Append(" and JYLXCODE=@JYLXCODE ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),new SQLiteParameter("@JYLXCODE", DbType.String,10)};
            parameters[0].Value = SBXXID;
            parameters[1].Value = JYLXCODE;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, null);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteAll(string SBXXID, object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from BBJYTJ  where 1=1");
            if (!string.IsNullOrEmpty(SBXXID))
                strSql.Append(string.Format(" and SBXXID='{0}' ", SBXXID));
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans,null);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  from BBJYTJ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }


        #endregion  成员方法

    }
}
