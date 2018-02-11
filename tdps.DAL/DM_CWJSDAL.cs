using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����DM_CWJSDAL��
	/// </summary>
	public class DM_CWJSDAL
	{
		public DM_CWJSDAL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string CWJSBM)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(CWJSBM) from DM_CWJS");
			strSql.Append(" where CWJSBM=@CWJSBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CWJSBM", DbType.String,50)};
			parameters[0].Value = CWJSBM;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_CWJS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_CWJS(");
			strSql.Append("CWJSBM,CWJSMC)");
			strSql.Append(" values (");
			strSql.Append("@CWJSBM,@CWJSMC)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CWJSBM", DbType.String,2),
					new SQLiteParameter("@CWJSMC", DbType.String,20)};
			parameters[0].Value = model.CWJSBM;
			parameters[1].Value = model.CWJSMC;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_CWJS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_CWJS set ");
			strSql.Append("CWJSMC=@CWJSMC");
			strSql.Append(" where CWJSBM=@CWJSBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CWJSBM", DbType.String,2),
					new SQLiteParameter("@CWJSMC", DbType.String,20)};
			parameters[0].Value = model.CWJSBM;
			parameters[1].Value = model.CWJSMC;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string CWJSBM)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_CWJS ");
			strSql.Append(" where CWJSBM=@CWJSBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CWJSBM", DbType.String,50)};
			parameters[0].Value = CWJSBM;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_CWJS GetModel(string CWJSBM)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CWJSBM,CWJSMC from DM_CWJS ");
			strSql.Append(" where CWJSBM=@CWJSBM ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@CWJSBM", DbType.String,50)};
			parameters[0].Value = CWJSBM;

			tdps.Model.DM_CWJS model=new tdps.Model.DM_CWJS();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.CWJSBM=ds.Tables[0].Rows[0]["CWJSBM"].ToString();
				model.CWJSMC=ds.Tables[0].Rows[0]["CWJSMC"].ToString();
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
			strSql.Append("select CWJSBM,CWJSMC ");
			strSql.Append(" FROM DM_CWJS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����
	}
}

