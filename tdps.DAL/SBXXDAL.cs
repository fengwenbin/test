using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类SBXXDAL。
	/// </summary>
	public partial class SBXXDAL
	{
		public SBXXDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SBXXID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(SBXXID) from SBXX");
			strSql.Append(" where SBXXID=@SBXXID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
			parameters[0].Value = SBXXID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBXX(");
            strSql.Append("DLZH,NSRSBH,SZ,SBZLCODE,SBZLMC,SSQQ,SSQZ,SBBWJ,BBZT,TBSJ,SBJSZT,SLSJ,CLSJ,JSSJ,SBQNF,SBQYF,FileName,SBCS,SSQLX,SBSE,SheetZT,BBTXCS,CWBBFSJG,CWBB_FileName)");
			strSql.Append(" values (");
            strSql.Append("@DLZH,@NSRSBH,@SZ,@SBZLCODE,@SBZLMC,@SSQQ,@SSQZ,@SBBWJ,@BBZT,@TBSJ,@SBJSZT,@SLSJ,@CLSJ,@JSSJ,@SBQNF,@SBQYF,@FileName,@SBCS,@SSQLX,@SBSE,@SheetZT,@BBTXCS,@CWBBFSJG,@CWBB_FileName)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@SBZLCODE", DbType.String,10),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@SBBWJ", DbType.String),
					new SQLiteParameter("@BBZT", DbType.String,4),
					new SQLiteParameter("@TBSJ", DbType.String,20),
					new SQLiteParameter("@SBJSZT", DbType.String,4),
					new SQLiteParameter("@SLSJ", DbType.String,20),
					new SQLiteParameter("@CLSJ", DbType.String,20),
					new SQLiteParameter("@JSSJ", DbType.String,20),
					new SQLiteParameter("@SBQNF", DbType.String,4),
					new SQLiteParameter("@SBQYF", DbType.String,2),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQLX", DbType.Int32,4),
					new SQLiteParameter("@SBSE", DbType.Decimal,9),
					new SQLiteParameter("@SheetZT", DbType.String,50),
                    new SQLiteParameter("@BBTXCS", DbType.String,200),
                                           new SQLiteParameter("@CWBBFSJG", DbType.String,1),
                                           new SQLiteParameter("@CWBB_FileName", DbType.String,200)};
			parameters[0].Value = model.DLZH;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.SZ;
			parameters[3].Value = model.SBZLCODE;
			parameters[4].Value = model.SBZLMC;
			parameters[5].Value = model.SSQQ;
			parameters[6].Value = model.SSQZ;
			parameters[7].Value = model.SBBWJ;
			parameters[8].Value = model.BBZT;
			parameters[9].Value = model.TBSJ;
			parameters[10].Value = model.SBJSZT;
			parameters[11].Value = model.SLSJ;
			parameters[12].Value = model.CLSJ;
			parameters[13].Value = model.JSSJ;
			parameters[14].Value = model.SBQNF;
			parameters[15].Value = model.SBQYF;
			parameters[16].Value = model.FileName;
			parameters[17].Value = model.SBCS;
			parameters[18].Value = model.SSQLX;
			parameters[19].Value = model.SBSE;
			parameters[20].Value = model.SheetZT;
            parameters[21].Value = model.BBTXCS;
            parameters[22].Value = model.CWBBFSJG;
            parameters[23].Value = model.CWBBFileName;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SBXX set ");
			strSql.Append("DLZH=@DLZH,");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("SZ=@SZ,");
			strSql.Append("SBZLCODE=@SBZLCODE,");
			strSql.Append("SBZLMC=@SBZLMC,");
			strSql.Append("SSQQ=@SSQQ,");
			strSql.Append("SSQZ=@SSQZ,");
			strSql.Append("SBBWJ=@SBBWJ,");
			strSql.Append("BBZT=@BBZT,");
			strSql.Append("TBSJ=@TBSJ,");
			strSql.Append("SBJSZT=@SBJSZT,");
            strSql.Append("SLSJ=@SLSJ,");            
			strSql.Append("CLSJ=@CLSJ,");
			strSql.Append("JSSJ=@JSSJ,");
			strSql.Append("SBQNF=@SBQNF,");
			strSql.Append("SBQYF=@SBQYF,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("SBCS=@SBCS,");
			strSql.Append("SSQLX=@SSQLX,");
			strSql.Append("SBSE=@SBSE,");
			strSql.Append("DYMM=@DYMM,");
            strSql.Append("SBLSH=@SBLSH,");
            strSql.Append("SBFSSJ=@SBFSSJ,");
            strSql.Append("CELLVERSION=@CELLVERSION,");
            strSql.Append("DKFPRQQ=@DKFPRQQ,");
            strSql.Append("DKFPRQZ=@DKFPRQZ,");
            strSql.Append("SJBS=@SJBS,");
            strSql.Append("BBTXCS = @BBTXCS,");
            strSql.Append("CWBBFSJG = @CWBBFSJG,");
            strSql.Append("CWBB_FileName = @CWBB_FileName");
			strSql.Append(" where SBXXID=@SBXXID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@SZ", DbType.String,20),
					new SQLiteParameter("@SBZLCODE", DbType.String,10),
					new SQLiteParameter("@SBZLMC", DbType.String,80),
					new SQLiteParameter("@SSQQ", DbType.String,20),
					new SQLiteParameter("@SSQZ", DbType.String,20),
					new SQLiteParameter("@SBBWJ", DbType.String),
					new SQLiteParameter("@BBZT", DbType.String,4),
					new SQLiteParameter("@TBSJ", DbType.String,20),
					new SQLiteParameter("@SBJSZT", DbType.String,4),
					new SQLiteParameter("@SLSJ", DbType.String,20),                  
					new SQLiteParameter("@CLSJ", DbType.String,20),
					new SQLiteParameter("@JSSJ", DbType.String,20),
					new SQLiteParameter("@SBQNF", DbType.String,4),
					new SQLiteParameter("@SBQYF", DbType.String,2),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@SBCS", DbType.Int32,4),
					new SQLiteParameter("@SSQLX", DbType.Int32,4),
					new SQLiteParameter("@SBSE", DbType.Decimal,9),
					new SQLiteParameter("@SheetZT", DbType.String,50),
                    new SQLiteParameter("@SBLSH", DbType.String,100),
					new SQLiteParameter("@DYMM", DbType.String,50),
                    new SQLiteParameter("@SBFSSJ", DbType.String,20),
                    new SQLiteParameter("@CELLVERSION", DbType.String,50),
                    new SQLiteParameter("@DKFPRQQ", DbType.String,50),
                    new SQLiteParameter("@DKFPRQZ", DbType.String,50),
                    new SQLiteParameter("@SJBS", DbType.String,16),
                    new SQLiteParameter("@BBTXCS", DbType.String,200),
                                           new SQLiteParameter("@CWBBFSJG", DbType.String,1),
                                           new SQLiteParameter("@CWBB_FileName", DbType.String,200)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.DLZH;
			parameters[2].Value = model.NSRSBH;
			parameters[3].Value = model.SZ;
			parameters[4].Value = model.SBZLCODE;
			parameters[5].Value = model.SBZLMC;
			parameters[6].Value = model.SSQQ;
			parameters[7].Value = model.SSQZ;
			parameters[8].Value = model.SBBWJ;
			parameters[9].Value = model.BBZT;
			parameters[10].Value = model.TBSJ;
			parameters[11].Value = model.SBJSZT;
			parameters[12].Value = model.SLSJ;
			parameters[13].Value = model.CLSJ;
			parameters[14].Value = model.JSSJ;
			parameters[15].Value = model.SBQNF;
			parameters[16].Value = model.SBQYF;
			parameters[17].Value = model.FileName;
			parameters[18].Value = model.SBCS;
			parameters[19].Value = model.SSQLX;
			parameters[20].Value = model.SBSE;
			parameters[21].Value = model.SheetZT;
            parameters[22].Value = model.SBLSH;
            parameters[23].Value = model.DYMM;
            parameters[24].Value = model.SBFSSJ;
            parameters[25].Value = model.CELLVERSION;
            parameters[26].Value = model.DKFPRQQ;
            parameters[27].Value = model.DKFPRQZ;
            parameters[28].Value = model.SJBS;
            parameters[29].Value = model.BBTXCS;
            parameters[30].Value = model.CWBBFSJG;
            parameters[31].Value = model.CWBBFileName;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int SBXXID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBXX ");
			strSql.Append(" where SBXXID=@SBXXID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
			parameters[0].Value = SBXXID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SBXX GetModel(int SBXXID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select SBXXID,DLZH,NSRSBH,SZ,SBZLCODE,SBZLMC,SSQQ,SSQZ,SBBWJ,BBZT,TBSJ,SBJSZT,SLSJ,CLSJ,JSSJ,SBQNF,SBQYF,FileName,SBCS,SSQLX,SBSE,SBLSH,DYMM,SheetZT,SBFSSJ,CELLVERSION,DKFPRQQ,DKFPRQZ,SJBS,BBTXCS,CWBBFSJG,CWBB_FileName from SBXX ");
			strSql.Append(" where SBXXID=@SBXXID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
			parameters[0].Value = SBXXID;

			tdps.Model.SBXX model=new tdps.Model.SBXX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SBXXID"].ToString()!="")
				{
					model.SBXXID=int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
				}
				model.DLZH=ds.Tables[0].Rows[0]["DLZH"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.SZ=ds.Tables[0].Rows[0]["SZ"].ToString();
				model.SBZLCODE=ds.Tables[0].Rows[0]["SBZLCODE"].ToString();
				model.SBZLMC=ds.Tables[0].Rows[0]["SBZLMC"].ToString();
				model.SSQQ=ds.Tables[0].Rows[0]["SSQQ"].ToString();
				model.SSQZ=ds.Tables[0].Rows[0]["SSQZ"].ToString();
				model.SBBWJ=ds.Tables[0].Rows[0]["SBBWJ"].ToString();
				model.BBZT=ds.Tables[0].Rows[0]["BBZT"].ToString();
				model.TBSJ=ds.Tables[0].Rows[0]["TBSJ"].ToString();
				model.SBJSZT=ds.Tables[0].Rows[0]["SBJSZT"].ToString();
				model.SLSJ=ds.Tables[0].Rows[0]["SLSJ"].ToString();
				model.CLSJ=ds.Tables[0].Rows[0]["CLSJ"].ToString();
				model.JSSJ=ds.Tables[0].Rows[0]["JSSJ"].ToString();
				model.SBQNF=ds.Tables[0].Rows[0]["SBQNF"].ToString();
				model.SBQYF=ds.Tables[0].Rows[0]["SBQYF"].ToString();
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
                model.SBFSSJ = ds.Tables[0].Rows[0]["SBFSSJ"].ToString();
				if(ds.Tables[0].Rows[0]["SBCS"].ToString()!="")
				{
					model.SBCS=int.Parse(ds.Tables[0].Rows[0]["SBCS"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SSQLX"].ToString()!="")
				{
					model.SSQLX=int.Parse(ds.Tables[0].Rows[0]["SSQLX"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SBSE"].ToString()!="")
				{
					model.SBSE=decimal.Parse(ds.Tables[0].Rows[0]["SBSE"].ToString());
				}
                model.SBLSH = ds.Tables[0].Rows[0]["SBLSH"].ToString();
                model.DYMM = ds.Tables[0].Rows[0]["DYMM"].ToString();
				model.SheetZT=ds.Tables[0].Rows[0]["SheetZT"].ToString();
                model.CELLVERSION = ds.Tables[0].Rows[0]["CELLVERSION"].ToString();
                model.DKFPRQQ = ds.Tables[0].Rows[0]["DKFPRQQ"].ToString();
                model.DKFPRQZ = ds.Tables[0].Rows[0]["DKFPRQZ"].ToString();
                model.SJBS = ds.Tables[0].Rows[0]["SJBS"].ToString();
                model.BBTXCS = ds.Tables[0].Rows[0]["BBTXCS"].ToString();
                model.CWBBFSJG = ds.Tables[0].Rows[0]["CWBBFSJG"].ToString();
                model.CWBBFileName = ds.Tables[0].Rows[0]["CWBB_FileName"].ToString();
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
            strSql.Append("select SBXXID,DLZH,NSRSBH,SZ,SBZLCODE,SBZLMC,SSQQ,SSQZ,SBBWJ,BBZT,TBSJ,SBJSZT,SLSJ,CLSJ,JSSJ,SBQNF,SBQYF,FileName,SBCS,SSQLX,SBSE,SBLSH,DYMM,SheetZT,SBFSSJ,CELLVERSION,DKFPRQQ,DKFPRQZ,SJBS,BBTXCS,CWBBFSJG,CWBB_FileName ");
			strSql.Append(" FROM SBXX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

