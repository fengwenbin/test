using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����XTSZDAL��
	/// </summary>
	public partial class XTSZDAL
	{
		public XTSZDAL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string XTBBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(XTBBH) from XTSZ");
			strSql.Append(" where XTBBH=@XTBBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,50)};
			parameters[0].Value = XTBBH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.XTSZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XTSZ(");
			strSql.Append("XTBBH,GXSJ)");
			strSql.Append(" values (");
			strSql.Append("@XTBBH,@GXSJ)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,20),
					new SQLiteParameter("@GXSJ", DbType.String,20)};
			parameters[0].Value = model.XTBBH;
			parameters[1].Value = model.GXSJ;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.XTSZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XTSZ set ");
			strSql.Append("GXSJ=@GXSJ");
			strSql.Append(" where XTBBH=@XTBBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,20),
					new SQLiteParameter("@GXSJ", DbType.String,20)};
			parameters[0].Value = model.XTBBH;
			parameters[1].Value = model.GXSJ;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string XTBBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from XTSZ ");
			strSql.Append(" where XTBBH=@XTBBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,50)};
			parameters[0].Value = XTBBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.XTSZ GetModel(string XTBBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XTBBH,GXSJ from XTSZ ");
			strSql.Append(" where XTBBH=@XTBBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@XTBBH", DbType.String,50)};
			parameters[0].Value = XTBBH;

			tdps.Model.XTSZ model=new tdps.Model.XTSZ();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.XTBBH=ds.Tables[0].Rows[0]["XTBBH"].ToString();
				model.GXSJ=ds.Tables[0].Rows[0]["GXSJ"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XTBBH,GXSJ ");
			strSql.Append(" FROM XTSZ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����
	}
}

