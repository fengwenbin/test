using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类KKCLDAL。
	/// </summary>
	public partial class KKCLDAL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(tdps.Model.KKCL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(FID) from KKCL");
            strSql.Append(" where  FileName=@FileName  ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@FileName", DbType.String,200)};
            parameters[0].Value = model.FileName;

            return SQLiteHelper.Exists(strSql.ToString(), parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.KKCL model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into KKCL(");
            strSql.Append("SBXXID,HZLX,NSRSBH,NSRMC,SWJGMC,YHDM,YHZH,KKFSSJ,KKCLSJ,JYLSH,DZYZData,SBWJ,SBZL,TSXX,ZT,ZJE,KKJE,WJJE,SBZLMC,SBCS,SSQQ,SSQZ,KKSJ,SBFKYZM,FKDM,FKXX,SZ,FileName,MW)");
            strSql.Append(" values (");
            strSql.Append("@SBXXID,@HZLX,@NSRSBH,@NSRMC,@SWJGMC,@YHDM,@YHZH,@KKFSSJ,@KKCLSJ,@JYLSH,@DZYZData,@SBWJ,@SBZL,@TSXX,@ZT,@ZJE,@KKJE,@WJJE,@SBZLMC,@SBCS,@SSQQ,@SSQZ,@KKSJ,@SBFKYZM,@FKDM,@FKXX,@SZ,@FileName,@MW)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@HZLX", DbType.String,4),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@SWJGMC", DbType.String,80),
					new SQLiteParameter("@YHDM", DbType.String,12),
					new SQLiteParameter("@YHZH", DbType.String,50),
					new SQLiteParameter("@KKFSSJ", DbType.String,20),
					new SQLiteParameter("@KKCLSJ", DbType.String,20),
					new SQLiteParameter("@JYLSH", DbType.String,30),
					new SQLiteParameter("@DZYZData", DbType.String),
					new SQLiteParameter("@SBWJ", DbType.String,100),
					new SQLiteParameter("@SBZL", DbType.String,20),
					new SQLiteParameter("@TSXX", DbType.String),
					new SQLiteParameter("@ZT", DbType.String,20),
					new SQLiteParameter("@ZJE", DbType.Decimal,9),
					new SQLiteParameter("@KKJE", DbType.Decimal,9),
					new SQLiteParameter("@WJJE", DbType.Decimal,9),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@KKSJ", DbType.String,20),
					new SQLiteParameter("@SBFKYZM", DbType.String,20),
					new SQLiteParameter("@FKDM", DbType.String,20),
					new SQLiteParameter("@FKXX", DbType.String),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@MW", DbType.String)};
            parameters[0].Value = model.SBXXID;
            parameters[1].Value = model.HZLX;
            parameters[2].Value = model.NSRSBH;
            parameters[3].Value = model.NSRMC;
            parameters[4].Value = model.SWJGMC;
            parameters[5].Value = model.YHDM;
            parameters[6].Value = model.YHZH;
            parameters[7].Value = model.KKFSSJ;
            parameters[8].Value = model.KKCLSJ;
            parameters[9].Value = model.JYLSH;
            parameters[10].Value = model.DZYZData;
            parameters[11].Value = model.SBWJ;
            parameters[12].Value = model.SBZL;
            parameters[13].Value = model.TSXX;
            parameters[14].Value = model.ZT;
            parameters[15].Value = model.ZJE;
            parameters[16].Value = model.KKJE;
            parameters[17].Value = model.WJJE;
            parameters[18].Value = model.SBZLMC;
            parameters[19].Value = model.SBCS;
            parameters[20].Value = model.SSQQ;
            parameters[21].Value = model.SSQZ;
            parameters[22].Value = model.KKSJ;
            parameters[23].Value = model.SBFKYZM;
            parameters[24].Value = model.FKDM;
            parameters[25].Value = model.FKXX;
            parameters[26].Value = model.SZ;
            parameters[27].Value = model.FileName;
            parameters[28].Value = model.MW;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySQL(string strSql)
        {
            return SQLiteHelper.ExecuteDataSet(strSql);
        }
		#endregion  成员方法
	}
}

