using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����ClientVersionDAL��
	/// </summary>
	public class ClientVersionDAL
	{
		public ClientVersionDAL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(ID) from ClientVersion");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4)};
			parameters[0].Value = ID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.ClientVersion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ClientVersion(");
			strSql.Append("NSRSBH,Version)");
			strSql.Append(" values (");
			strSql.Append("@NSRSBH,@Version)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,30),
					new SQLiteParameter("@Version", DbType.String,10)};
			parameters[0].Value = model.NSRSBH;
			parameters[1].Value = model.Version;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.ClientVersion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ClientVersion set ");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("Version=@Version");
            strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4),
					new SQLiteParameter("@NSRSBH", DbType.String,30),
					new SQLiteParameter("@Version", DbType.String,10)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.Version;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ClientVersion ");
            strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.ClientVersion GetModel(string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,NSRSBH,Version from ClientVersion ");
            strSql.Append(" where NSRSBH=@NSRSBH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = NSRSBH;

			tdps.Model.ClientVersion model=new tdps.Model.ClientVersion();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.Version=ds.Tables[0].Rows[0]["Version"].ToString();
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
			strSql.Append("select ID,NSRSBH,Version ");
			strSql.Append(" FROM ClientVersion ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����
	}
}

