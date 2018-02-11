using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using System.Data;
namespace tdps.DAL
{
    /// <summary>
    /// 数据访问类DLNSRXXDAL。
    /// </summary>
    public class DLNSRXXDAL
    {

        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string DLZH, string NSRSBH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(DLZH) from DLNSRXX");
            strSql.Append(" where DLZH=@DLZH and   NSRSBH=@NSRSBH ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
                    new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = DLZH;
            parameters[1].Value = NSRSBH;
            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.DLNSRXX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DLNSRXX(");
            strSql.Append("DLZH,NSRSBH)");
            strSql.Append(" values (");
            strSql.Append("@DLZH,@NSRSBH)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = model.DLZH;
            parameters[1].Value = model.NSRSBH;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.DLNSRXX model,object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DLNSRXX(");
            strSql.Append("DLZH,NSRSBH)");
            strSql.Append(" values (");
            strSql.Append("@DLZH,@NSRSBH)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = model.DLZH;
            parameters[1].Value = model.NSRSBH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(),(SQLiteTransaction)trans, parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.DLNSRXX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DLNSRXX set ");
            strSql.Append("NSRSBH=@NSRSBH");
            strSql.Append(" where DLZH=@DLZH ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = model.DLZH;
            parameters[1].Value = model.NSRSBH;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.DLNSRXX model,object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DLNSRXX set ");
            strSql.Append("NSRSBH=@NSRSBH");
            strSql.Append(" where DLZH=@DLZH ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = model.DLZH;
            parameters[1].Value = model.NSRSBH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(),(SQLiteTransaction)trans,parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string DLZH, string NSRSBH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DLNSRXX  where 1=1");
            if (!string.IsNullOrEmpty(DLZH))
                strSql.Append(string.Format(" and DLZH='{0}' ", DLZH));
            if (!string.IsNullOrEmpty(NSRSBH))
                strSql.AppendFormat(" and NSRSBH='{0}'", NSRSBH);
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), null);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string DLZH, string NSRSBH,object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DLNSRXX  where 1=1");
            if (!string.IsNullOrEmpty(DLZH))
                strSql.Append(string.Format(" and DLZH='{0}' ", DLZH));
            if (!string.IsNullOrEmpty(NSRSBH))
                strSql.AppendFormat(" and NSRSBH='{0}'", NSRSBH);
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans,null);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.DLNSRXX GetModel(string DLZH)
        {
            return null;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DLNSRXX.dlzh,DLNSRXX.nsrsbh,NSRXX.NSRMC  ");
            strSql.Append(" from DLNSRXX LEFT JOIN NSRXX ON DLNSRXX.NSRSBH = NSRXX.NSRSBH ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }


        #endregion  成员方法

    }
}
