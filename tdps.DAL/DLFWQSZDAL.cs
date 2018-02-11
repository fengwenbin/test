using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
    /// 数据访问类DLFWQSZDAL。
	/// </summary>
	public class DLFWQSZDAL
	{
		public DLFWQSZDAL()
		{}
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(FID) from DLFWQSZ");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
            parameters[0].Value = FID;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.DLFWQSZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DLFWQSZ(");
            strSql.Append("DLLX,DLDZ,DLDK,YHYZ,YHM,MM,GXSJ)");
            strSql.Append(" values (");
            strSql.Append("@DLLX,@DLDZ,@DLDK,@YHYZ,@YHM,@MM,@GXSJ)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLLX", DbType.String,30),
					new SQLiteParameter("@DLDZ", DbType.String,120),
					new SQLiteParameter("@DLDK", DbType.Int32,4),
					new SQLiteParameter("@YHYZ", DbType.Int32,4),
					new SQLiteParameter("@YHM", DbType.String,60),
					new SQLiteParameter("@MM", DbType.String,40),
					new SQLiteParameter("@GXSJ", DbType.String,20)};
            parameters[0].Value = model.DLLX;
            parameters[1].Value = model.DLDZ;
            parameters[2].Value = model.DLDK;
            parameters[3].Value = model.YHYZ;
            parameters[4].Value = model.YHM;
            parameters[5].Value = model.MM;
            parameters[6].Value = model.GXSJ;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.DLFWQSZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DLFWQSZ set ");
            strSql.Append("DLLX=@DLLX,");
            strSql.Append("DLDZ=@DLDZ,");
            strSql.Append("DLDK=@DLDK,");
            strSql.Append("YHYZ=@YHYZ,");
            strSql.Append("YHM=@YHM,");
            strSql.Append("MM=@MM,");
            strSql.Append("GXSJ=@GXSJ");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@DLLX", DbType.String,30),
					new SQLiteParameter("@DLDZ", DbType.String,120),
					new SQLiteParameter("@DLDK", DbType.Int32,4),
					new SQLiteParameter("@YHYZ", DbType.Int32,4),
					new SQLiteParameter("@YHM", DbType.String,60),
					new SQLiteParameter("@MM", DbType.String,40),
					new SQLiteParameter("@GXSJ", DbType.String,20)};
            parameters[0].Value = model.FID;
            parameters[1].Value = model.DLLX;
            parameters[2].Value = model.DLDZ;
            parameters[3].Value = model.DLDK;
            parameters[4].Value = model.YHYZ;
            parameters[5].Value = model.YHM;
            parameters[6].Value = model.MM;
            parameters[7].Value = model.GXSJ;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int FID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DLFWQSZ ");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
            parameters[0].Value = FID;

            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.DLFWQSZ GetModel(int FID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FID,DLLX,DLDZ,DLDK,YHYZ,YHM,MM,GXSJ from DLFWQSZ ");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
            parameters[0].Value = FID;

            tdps.Model.DLFWQSZ model = new tdps.Model.DLFWQSZ();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["FID"].ToString() != "")
                {
                    model.FID = int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
                }
                model.DLLX = ds.Tables[0].Rows[0]["DLLX"].ToString();
                model.DLDZ = ds.Tables[0].Rows[0]["DLDZ"].ToString();
                if (ds.Tables[0].Rows[0]["DLDK"].ToString() != "")
                {
                    model.DLDK = int.Parse(ds.Tables[0].Rows[0]["DLDK"].ToString());
                }
                if (ds.Tables[0].Rows[0]["YHYZ"].ToString() != "")
                {
                    model.YHYZ = int.Parse(ds.Tables[0].Rows[0]["YHYZ"].ToString());
                }
                model.YHM = ds.Tables[0].Rows[0]["YHM"].ToString();
                model.MM = ds.Tables[0].Rows[0]["MM"].ToString();
                model.GXSJ = ds.Tables[0].Rows[0]["GXSJ"].ToString();
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
            strSql.Append("select FID,DLLX,DLDZ,DLDK,YHYZ,YHM,MM,GXSJ ");
            strSql.Append(" FROM DLFWQSZ ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }


        #endregion  成员方法
    }
}

