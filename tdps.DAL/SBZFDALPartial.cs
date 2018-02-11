using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类SBZFDAL。
	/// </summary>
	public partial class SBZFDAL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(tdps.Model.SBZF model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from SBZF");
            strSql.Append(" where FileName=@FileName ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FileName", DbType.String,200)};
            parameters[0].Value = model.FileName;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBZF model,object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBZF(");
			strSql.Append("SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,SBZFFSSJ,SBZFCLSJ,JYLSH,DZYZData,SBWJ,SBZL,SBSJ,SBSE,TSXX,SBZLMC,SBCS,SSQQ,SSQZ,FKDM,FKXX,SBZFSJ,MW,SZ,FileName)");
			strSql.Append(" values (");
			strSql.Append("@SBXXID,@HZLX,@NSRSBH,@NSRMC,@SWJGMC,@SBZFFSSJ,@SBZFCLSJ,@JYLSH,@DZYZData,@SBWJ,@SBZL,@SBSJ,@SBSE,@TSXX,@SBZLMC,@SBCS,@SSQQ,@SSQZ,@FKDM,@FKXX,@SBZFSJ,@MW,@SZ,@FileName)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@SBZFFSSJ", DbType.String,20),
					new SQLiteParameter("@SBZFCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@SBSJ", DbType.String,20),
					new SQLiteParameter("@SBSE", DbType.Decimal,9),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@SBZFSJ", DbType.String,20),
					new SQLiteParameter("@MW", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.HZLX;
			parameters[2].Value = model.NSRSBH;
			parameters[3].Value = model.NSRMC;
			parameters[4].Value = model.SWJGMC;
			parameters[5].Value = model.SBZFFSSJ;
			parameters[6].Value = model.SBZFCLSJ;
			parameters[7].Value = model.JYLSH;
			parameters[8].Value = model.DZYZData;
			parameters[9].Value = model.SBWJ;
			parameters[10].Value = model.SBZL;
			parameters[11].Value = model.SBSJ;
			parameters[12].Value = model.SBSE;
			parameters[13].Value = model.TSXX;
			parameters[14].Value = model.SBZLMC;
			parameters[15].Value = model.SBCS;
			parameters[16].Value = model.SSQQ;
			parameters[17].Value = model.SSQZ;
			parameters[18].Value = model.FKDM;
			parameters[19].Value = model.FKXX;
			parameters[20].Value = model.SBZFSJ;
			parameters[21].Value = model.MW;
			parameters[22].Value = model.SZ;
			parameters[23].Value = model.FileName;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.SBZF model,object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SBZF set ");
            strSql.Append("SBXXID=@SBXXID,");
            strSql.Append("HZLX=@HZLX,");
            strSql.Append("NSRSBH=@NSRSBH,");
            strSql.Append("NSRMC=@NSRMC,");
            strSql.Append("SWJGMC=@SWJGMC,");
            strSql.Append("SBZFFSSJ=@SBZFFSSJ,");
            strSql.Append("SBZFCLSJ=@SBZFCLSJ,");
            strSql.Append("JYLSH=@JYLSH,");
            strSql.Append("DZYZData=@DZYZData,");
            strSql.Append("SBWJ=@SBWJ,");
            strSql.Append("SBZL=@SBZL,");
            strSql.Append("SBSJ=@SBSJ,");
            strSql.Append("SBSE=@SBSE,");
            strSql.Append("TSXX=@TSXX,");
            strSql.Append("SBZLMC=@SBZLMC,");
            strSql.Append("SBCS=@SBCS,");
            strSql.Append("SSQQ=@SSQQ,");
            strSql.Append("SSQZ=@SSQZ,");
            strSql.Append("FKDM=@FKDM,");
            strSql.Append("FKXX=@FKXX,");
            strSql.Append("SBZFSJ=@SBZFSJ,");
            strSql.Append("MW=@MW,");
            strSql.Append("SZ=@SZ,");
            strSql.Append("FileName=@FileName");
            strSql.Append(" where FID=@FID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@SBZFFSSJ", DbType.String,20),
					new SQLiteParameter("@SBZFCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@SBSJ", DbType.String,20),
					new SQLiteParameter("@SBSE", DbType.Decimal,9),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@SBZFSJ", DbType.String,20),
					new SQLiteParameter("@MW", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200)};
            parameters[0].Value = model.FID;
            parameters[1].Value = model.SBXXID;
            parameters[2].Value = model.HZLX;
            parameters[3].Value = model.NSRSBH;
            parameters[4].Value = model.NSRMC;
            parameters[5].Value = model.SWJGMC;
            parameters[6].Value = model.SBZFFSSJ;
            parameters[7].Value = model.SBZFCLSJ;
            parameters[8].Value = model.JYLSH;
            parameters[9].Value = model.DZYZData;
            parameters[10].Value = model.SBWJ;
            parameters[11].Value = model.SBZL;
            parameters[12].Value = model.SBSJ;
            parameters[13].Value = model.SBSE;
            parameters[14].Value = model.TSXX;
            parameters[15].Value = model.SBZLMC;
            parameters[16].Value = model.SBCS;
            parameters[17].Value = model.SSQQ;
            parameters[18].Value = model.SSQZ;
            parameters[19].Value = model.FKDM;
            parameters[20].Value = model.FKXX;
            parameters[21].Value = model.SBZFSJ;
            parameters[22].Value = model.MW;
            parameters[23].Value = model.SZ;
            parameters[24].Value = model.FileName;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SBZF ");
            strSql.Append(" where SBXXID=@SBXXID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
            parameters[0].Value = SBXXID;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }




        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.SBZF GetModelBySBXXID(int SBXXID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FID,SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,SBZFFSSJ,SBZFCLSJ,JYLSH,DZYZData,SBWJ,SBZL,SBSJ,SBSE,TSXX,SBZLMC,SBCS,SSQQ,SSQZ,FKDM,FKXX,SBZFSJ,MW,SZ,FileName from SBZF ");
            strSql.Append(" where SBXXID=@SBXXID ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
            parameters[0].Value = SBXXID;

            tdps.Model.SBZF model = new tdps.Model.SBZF();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["FID"].ToString() != "")
                {
                    model.FID = int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SBXXID"].ToString() != "")
                {
                    model.SBXXID = int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
                }
                model.HZLX = ds.Tables[0].Rows[0]["HZLX"].ToString();
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
                model.NSRMC = ds.Tables[0].Rows[0]["NSRMC"].ToString();
                model.SWJGMC = ds.Tables[0].Rows[0]["SWJGMC"].ToString();
                model.SBZFFSSJ = ds.Tables[0].Rows[0]["SBZFFSSJ"].ToString();
                model.SBZFCLSJ = ds.Tables[0].Rows[0]["SBZFCLSJ"].ToString();
                model.JYLSH = ds.Tables[0].Rows[0]["JYLSH"].ToString();
                model.DZYZData = ds.Tables[0].Rows[0]["DZYZData"].ToString();
                model.SBWJ = ds.Tables[0].Rows[0]["SBWJ"].ToString();
                model.SBZL = ds.Tables[0].Rows[0]["SBZL"].ToString();
                model.SBSJ = ds.Tables[0].Rows[0]["SBSJ"].ToString();
                if (ds.Tables[0].Rows[0]["SBSE"].ToString() != "")
                {
                    model.SBSE = decimal.Parse(ds.Tables[0].Rows[0]["SBSE"].ToString());
                }
                model.TSXX = ds.Tables[0].Rows[0]["TSXX"].ToString();
                model.SBZLMC = ds.Tables[0].Rows[0]["SBZLMC"].ToString();
                if (ds.Tables[0].Rows[0]["SBCS"].ToString() != "")
                {
                    model.SBCS = int.Parse(ds.Tables[0].Rows[0]["SBCS"].ToString());
                }
                model.SSQQ = ds.Tables[0].Rows[0]["SSQQ"].ToString();
                model.SSQZ = ds.Tables[0].Rows[0]["SSQZ"].ToString();
                model.FKDM = ds.Tables[0].Rows[0]["FKDM"].ToString();
                model.FKXX = ds.Tables[0].Rows[0]["FKXX"].ToString();
                model.SBZFSJ = ds.Tables[0].Rows[0]["SBZFSJ"].ToString();
                model.MW = ds.Tables[0].Rows[0]["MW"].ToString();
                model.SZ = ds.Tables[0].Rows[0]["SZ"].ToString();
                model.FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
		
		#endregion  成员方法
	}
}

