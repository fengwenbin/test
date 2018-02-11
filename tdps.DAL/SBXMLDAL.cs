using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类SBXMLDAL。
	/// </summary>
	public partial class SBXMLDAL
	{
		public SBXMLDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SBXXID,string FileName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(SBXXID) from SBXML");
			strSql.Append(" where SBXXID=@SBXXID and FileName=@FileName ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@FileName", DbType.String,50)};
			parameters[0].Value = SBXXID;
			parameters[1].Value = FileName;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXML model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBXML(");
			strSql.Append("SBXXID,FileName,SBXMLData)");
			strSql.Append(" values (");
			strSql.Append("@SBXXID,@FileName,@SBXMLData)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@SBXMLData", DbType.String)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.FileName;
            parameters[2].Value = RefactoringXMLData(model.SBXMLData, model.FileName);

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBXML model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SBXML set ");
			strSql.Append("SBXMLData=@SBXMLData");
			strSql.Append(" where SBXXID=@SBXXID and FileName=@FileName ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@FileName", DbType.String,200),
					new SQLiteParameter("@SBXMLData", DbType.String)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.FileName;
			parameters[2].Value = model.SBXMLData;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int SBXXID,string FileName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBXML ");
			strSql.Append(" where SBXXID=@SBXXID and FileName=@FileName ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@FileName", DbType.String,50)};
			parameters[0].Value = SBXXID;
			parameters[1].Value = FileName;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SBXML GetModel(int SBXXID,string FileName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SBXXID,FileName,SBXMLData from SBXML ");
			strSql.Append(" where SBXXID=@SBXXID and FileName=@FileName ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@FileName", DbType.String,50)};
			parameters[0].Value = SBXXID;
			parameters[1].Value = FileName;

			tdps.Model.SBXML model=new tdps.Model.SBXML();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SBXXID"].ToString()!="")
				{
					model.SBXXID=int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
				}
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				model.SBXMLData=ds.Tables[0].Rows[0]["SBXMLData"].ToString();
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
			strSql.Append("select SBXXID,FileName,SBXMLData ");
			strSql.Append(" FROM SBXML ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

