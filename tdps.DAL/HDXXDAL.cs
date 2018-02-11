using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类HDXXDAL。
	/// </summary>
	public class HDXXDAL
	{
		public HDXXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NSRSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(NSRSBH) from HDXX");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string NSRSBH,int SZFL)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(NSRSBH) from HDXX");
            strSql.Append(" where NSRSBH=@NSRSBH and SZFL=@SZFL");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50),
                    new SQLiteParameter("@SZFL",DbType.Int32,4)};
            parameters[0].Value = NSRSBH;
            parameters[1].Value = SZFL;
            return SQLiteHelper.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.HDXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HDXX(");
			strSql.Append("NSRSBH,FileName,HDXXXML,SZFL,GXSJ)");
			strSql.Append(" values (");
            strSql.Append("@NSRSBH,@FileName,@HDXXXML,@SZFL,@GXSJ)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,50),
					new SQLiteParameter("@HDXXXML", DbType.String),
                    new SQLiteParameter("@SZFL",DbType.Int32,4),
                    new SQLiteParameter("@GXSJ",DbType.String,10)};
			parameters[0].Value = model.NSRSBH;
			parameters[1].Value = model.FileName;
			parameters[2].Value = model.HDXXXML;
            parameters[3].Value = model.SZFL;
            parameters[4].Value = model.GXSJ;
			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.HDXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HDXX set ");
			strSql.Append("FileName=@FileName,");
			strSql.Append("HDXXXML=@HDXXXML,");
            strSql.Append("GXSJ=@GXSJ");
			strSql.Append(" where NSRSBH=@NSRSBH and SZFL=@SZFL ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,50),
					new SQLiteParameter("@HDXXXML", DbType.String),
                    new SQLiteParameter("@SZFL",DbType.Int32,4),
                    new SQLiteParameter("@GXSJ",DbType.String,15)};
			parameters[0].Value = model.NSRSBH;
			parameters[1].Value = model.FileName;
			parameters[2].Value = model.HDXXXML;
            parameters[3].Value = model.SZFL;
            parameters[4].Value = model.GXSJ;
			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 更新核定信息的更新时间
        /// </summary>
        public void UpdateGXSJ(tdps.Model.HDXX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HDXX set ");
            strSql.Append("GXSJ=@GXSJ");
            strSql.Append(" where NSRSBH=@NSRSBH and SZFL=@SZFL ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@GXSJ", DbType.String,10),
                    new SQLiteParameter("@SZFL",DbType.Int32,4)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.GXSJ;
            parameters[2].Value = model.SZFL;
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HDXX ");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string NSRSBH,int SZFL)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from HDXX ");
            strSql.Append(" where NSRSBH=@NSRSBH and SZFL=@SZFL ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50),
                    new SQLiteParameter("@SZFL",DbType.Int32,4)};
            parameters[0].Value = NSRSBH;
            parameters[1].Value = SZFL;
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.HDXX GetModel(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select NSRSBH,FileName,HDXXXML,SZFL,GXSJ from HDXX ");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			tdps.Model.HDXX model=new tdps.Model.HDXX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				model.HDXXXML=ds.Tables[0].Rows[0]["HDXXXML"].ToString();
                model.SZFL = int.Parse(ds.Tables[0].Rows[0]["SZFL"].ToString());
                model.GXSJ = ds.Tables[0].Rows[0]["GXSJ"].ToString();
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
        public tdps.Model.HDXX GetModel(string NSRSBH,int SZFL)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NSRSBH,FileName,HDXXXML,SZFL,GXSJ from HDXX ");
            strSql.Append(" where NSRSBH=@NSRSBH and SZFL=@SZFL");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50),
                                           new SQLiteParameter("@SZFL",DbType.Int32,4)};
            parameters[0].Value = NSRSBH;
            parameters[1].Value = SZFL;
            tdps.Model.HDXX model = new tdps.Model.HDXX();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
                model.FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                model.HDXXXML = ds.Tables[0].Rows[0]["HDXXXML"].ToString();
                model.SZFL = int.Parse(ds.Tables[0].Rows[0]["SZFL"].ToString());
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
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select NSRSBH,FileName,HDXXXML,SZFL,GXSJ ");
			strSql.Append(" FROM HDXX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

