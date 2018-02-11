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
		public NSRXXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NSRSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(NSRSBH) from NSRXX");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.NSRXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NSRXX(");
            strSql.Append("NSRSBH,NSRMC,FDDBRMC,ZCDZ,YYDZ,DHHM,YB,QYHGDM,FileName,fdqnsr,TSYHLX,SHXYDM)");
			strSql.Append(" values (");
            strSql.Append("@NSRSBH,@NSRMC,@FDDBRMC,@ZCDZ,@YYDZ,@DHHM,@YB,@QYHGDM,@FileName,@fdqnsr,@TSYHLX,@SHXYDM)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@FDDBRMC", DbType.String,70),
					new SQLiteParameter("@ZCDZ", DbType.String,80),
					new SQLiteParameter("@YYDZ", DbType.String,80),
					new SQLiteParameter("@DHHM", DbType.String,20),
					new SQLiteParameter("@YB", DbType.String,10),
					new SQLiteParameter("@QYHGDM", DbType.String,20),
					//new SQLiteParameter("@SBMM", DbType.String,8),
					new SQLiteParameter("@FileName", DbType.String,50),
                    new SQLiteParameter("@fdqnsr", DbType.String,1),
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
            parameters[9].Value = model.FDQNSR ;
            parameters[10].Value = model.TSYHLX;
            parameters[11].Value = model.SHXYDM;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.NSRXX model)
		{
			StringBuilder strSql=new StringBuilder();
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
            strSql.Append("TDPSID=@TDPSID,");
            strSql.Append("CAFWQZS=@CAFWQZS,");
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
                    new SQLiteParameter("@TDPSID", DbType.String,20),
                    new SQLiteParameter("@CAFWQZS", DbType.String,2000),
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
            parameters[10].Value = model.TDPSID;
            parameters[11].Value = model.CAFWQZS;
            parameters[12].Value = model.DQSJ;
            parameters[13].Value = model.NFYDQ;
            parameters[14].Value = model.TSYHLX;
            parameters[15].Value = model.SHXYDM;
			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
        
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NSRXX ");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.NSRXX GetModel(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select NSRSBH,NSRMC,FDDBRMC,ZCDZ,YYDZ,DHHM,YB,QYHGDM,FileName,fdqnsr,fdqrqq,fdqrqz,hzqynsr,hzqyrqq,hzqyrqz,TDPSID,CAFWQZS,DQSJ,NFYDQ,TSYHLX,SHXYDM from NSRXX ");
			strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,50)};
			parameters[0].Value = NSRSBH;

			tdps.Model.NSRXX model=new tdps.Model.NSRXX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.FDDBRMC=ds.Tables[0].Rows[0]["FDDBRMC"].ToString();
				model.ZCDZ=ds.Tables[0].Rows[0]["ZCDZ"].ToString();
				model.YYDZ=ds.Tables[0].Rows[0]["YYDZ"].ToString();
				model.DHHM=ds.Tables[0].Rows[0]["DHHM"].ToString();
                //if(ds.Tables[0].Rows[0]["YB"].ToString()!="")
                //{
					model.YB=ds.Tables[0].Rows[0]["YB"].ToString();
                //}
				model.QYHGDM=ds.Tables[0].Rows[0]["QYHGDM"].ToString();
				//model.SBMM=ds.Tables[0].Rows[0]["SBMM"].ToString();
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
                model.FDQNSR = ds.Tables[0].Rows[0]["fdqnsr"].ToString();
                model.fdqrqq = ds.Tables[0].Rows[0]["fdqrqq"].ToString();
                model.fdqrqz = ds.Tables[0].Rows[0]["fdqrqz"].ToString();
                model.hzqynsr = ds.Tables[0].Rows[0]["hzqynsr"].ToString();
                model.hzqyrqq = ds.Tables[0].Rows[0]["hzqyrqq"].ToString();
                model.hzqyrqz = ds.Tables[0].Rows[0]["hzqyrqz"].ToString();
                model.TDPSID = ds.Tables[0].Rows[0]["TDPSID"].ToString();
                model.CAFWQZS = ds.Tables[0].Rows[0]["CAFWQZS"].ToString();
                model.DQSJ = ds.Tables[0].Rows[0]["DQSJ"].ToString();
                model.NFYDQ = ds.Tables[0].Rows[0]["NFYDQ"].ToString();
                model.TSYHLX = ds.Tables[0].Rows[0]["TSYHLX"].ToString();
                model.SHXYDM = ds.Tables[0].Rows[0]["SHXYDM"].ToString();
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
            strSql.Append("select NSRSBH,NSRMC,FDDBRMC,ZCDZ,YYDZ,DHHM,YB,QYHGDM,SBMM,FileName,fdqnsr,TDPSID,NFYDQ,TSYHLX,SHXYDM ");
			strSql.Append(" FROM NSRXX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}

		#endregion  成员方法
	}
}

