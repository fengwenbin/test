using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类WLSZDAL。
	/// </summary>
	public class WLSZDAL
	{
		public WLSZDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from WLSZ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.WLSZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WLSZ(");
            strSql.Append("FWQIP,FWQDK,SFMR,SFQYNQLJ,SZFL)");
			strSql.Append(" values (");
            strSql.Append("@FWQIP,@FWQDK,@SFMR,@SFQYNQLJ,@SZFL)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FWQIP", DbType.String,35),
					new SQLiteParameter("@FWQDK", DbType.Int32,4),
					new SQLiteParameter("@SFMR", DbType.Int32,4),
					new SQLiteParameter("@SFQYNQLJ", DbType.Int32,4),
                    new SQLiteParameter("@GXSJ", DbType.String,20),
                    new SQLiteParameter("@SZFL",DbType.Int32,4)};
			parameters[0].Value = model.FWQIP;
			parameters[1].Value = model.FWQDK;
			parameters[2].Value = model.SFMR;
			parameters[3].Value = model.SFQYNQLJ;
            parameters[4].Value = model.GXSJ;
            parameters[5].Value = model.SZFL;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.WLSZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WLSZ set ");
			strSql.Append("FWQIP=@FWQIP,");
			strSql.Append("FWQDK=@FWQDK,");
			strSql.Append("SFMR=@SFMR,");
            strSql.Append("SZFL=@SZFL,");
			strSql.Append("SFQYNQLJ=@SFQYNQLJ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@FWQIP", DbType.String,35),
					new SQLiteParameter("@FWQDK", DbType.Int32,4),
					new SQLiteParameter("@SFMR", DbType.Int32,4),
					new SQLiteParameter("@SFQYNQLJ", DbType.Int32,4),
                    new SQLiteParameter("@GXSJ", DbType.String,20),
                    new SQLiteParameter("@SZFL",DbType.Int32,4)
        };
			parameters[0].Value = model.FID;
			parameters[1].Value = model.FWQIP;
			parameters[2].Value = model.FWQDK;
			parameters[3].Value = model.SFMR;
			parameters[4].Value = model.SFQYNQLJ;
            parameters[5].Value = model.GXSJ;
            parameters[6].Value = model.SZFL;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WLSZ ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.WLSZ GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select FID,FWQIP,FWQDK,SFMR,SFQYNQLJ,GXSJ,SZFL from WLSZ ");
			strSql.Append(" where FID=@FID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4)};
			parameters[0].Value = FID;

			tdps.Model.WLSZ model=new tdps.Model.WLSZ();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				model.FWQIP=ds.Tables[0].Rows[0]["FWQIP"].ToString();
				if(ds.Tables[0].Rows[0]["FWQDK"].ToString()!="")
				{
					model.FWQDK=int.Parse(ds.Tables[0].Rows[0]["FWQDK"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SFMR"].ToString()!="")
				{
					model.SFMR=int.Parse(ds.Tables[0].Rows[0]["SFMR"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SFQYNQLJ"].ToString()!="")
				{
					model.SFQYNQLJ=int.Parse(ds.Tables[0].Rows[0]["SFQYNQLJ"].ToString());
				}
                if (ds.Tables[0].Rows[0]["SZFL"].ToString() != "")
                {
                    model.SZFL = int.Parse(ds.Tables[0].Rows[0]["SZFL"].ToString());
                }
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
            strSql.Append("select FID,FWQIP,FWQDK,SFMR,SFQYNQLJ,GXSJ,SZFL ");
			strSql.Append(" FROM WLSZ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法

        #region 自定义成员方法

        /// <summary>
        /// 取消默认
        /// </summary>
        /// <param name="szfl">税种分类</param>
        /// <returns></returns>
        public void CancelSFMR(int szfl)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("update WLSZ set SFMR = 0  where SFMR= 1 and SZFL={0}",szfl);
            SQLiteHelper.ExecuteNonQuery(strSql.ToString(),null);
        }

        #endregion  成员方法
	}
}

