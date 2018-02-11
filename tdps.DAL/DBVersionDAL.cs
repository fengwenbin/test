using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����DBVersionDAL��
	/// </summary>
	public class DBVersionDAL
	{
		public DBVersionDAL()
		{}
		#region  ��Ա����


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DBVersion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DBVersion(");
			strSql.Append("version,UKeyID)");
			strSql.Append(" values (");
			strSql.Append("@version,@UKeyID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@version", DbType.Int32,4),
					new SQLiteParameter("@UKeyID", DbType.String,20)};
			parameters[0].Value = model.version;
			parameters[1].Value = model.UKeyID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DBVersion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DBVersion set ");
			strSql.Append("version=@version,");
			strSql.Append("UKeyID=@UKeyID");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@version", DbType.Int32,4),
					new SQLiteParameter("@UKeyID", DbType.String,20)};
			parameters[0].Value = model.version;
			parameters[1].Value = model.UKeyID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DBVersion ");
			SQLiteHelper.ExecuteNonQuery(strSql.ToString());
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DBVersion GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select version,UKeyID from DBVersion ");

			tdps.Model.DBVersion model=new tdps.Model.DBVersion();
			DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["version"].ToString()!="")
				{
					model.version=int.Parse(ds.Tables[0].Rows[0]["version"].ToString());
				}
				model.UKeyID = ds.Tables[0].Rows[0]["UKeyID"].ToString();
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
			strSql.Append("select version,UKeyID ");
			strSql.Append(" FROM DBVersion ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����
	}
}

