using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����SBBYZXXDAL��
	/// </summary>
	public partial class SBBYZXXDAL
	{
		public SBBYZXXDAL()
		{}
		#region  ��Ա����


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBBYZXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBBYZXX(");
			strSql.Append("SBXXID,SheetInx,Col,Row,ErrorContent,Type)");
			strSql.Append(" values (");
			strSql.Append("@SBXXID,@SheetInx,@Col,@Row,@ErrorContent,@Type)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@SheetInx", DbType.Int32,4),
					new SQLiteParameter("@Col", DbType.Int32,4),
					new SQLiteParameter("@Row", DbType.Int32,4),
					new SQLiteParameter("@ErrorContent", DbType.String),
					new SQLiteParameter("@Type", DbType.Int32,4)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.SheetInx;
			parameters[2].Value = model.Col;
			parameters[3].Value = model.Row;
			parameters[4].Value = model.ErrorContent;
			parameters[5].Value = model.Type;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.SBBYZXX model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SBBYZXX set ");
			strSql.Append("SBXXID=@SBXXID,");
			strSql.Append("SheetInx=@SheetInx,");
			strSql.Append("Col=@Col,");
			strSql.Append("Row=@Row,");
			strSql.Append("ErrorContent=@ErrorContent,");
			strSql.Append("Type=@Type");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@SheetInx", DbType.Int32,4),
					new SQLiteParameter("@Col", DbType.Int32,4),
					new SQLiteParameter("@Row", DbType.Int32,4),
					new SQLiteParameter("@ErrorContent", DbType.String),
					new SQLiteParameter("@Type", DbType.Int32,4)};
			parameters[0].Value = model.SBXXID;
			parameters[1].Value = model.SheetInx;
			parameters[2].Value = model.Col;
			parameters[3].Value = model.Row;
			parameters[4].Value = model.ErrorContent;
			parameters[5].Value = model.Type;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBBYZXX ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.SBBYZXX GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SBXXID,SheetInx,Col,Row,ErrorContent,Type from SBBYZXX ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			tdps.Model.SBBYZXX model=new tdps.Model.SBBYZXX();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SBXXID"].ToString()!="")
				{
					model.SBXXID=int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SheetInx"].ToString()!="")
				{
					model.SheetInx=int.Parse(ds.Tables[0].Rows[0]["SheetInx"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Col"].ToString()!="")
				{
					model.Col=int.Parse(ds.Tables[0].Rows[0]["Col"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Row"].ToString()!="")
				{
					model.Row=int.Parse(ds.Tables[0].Rows[0]["Row"].ToString());
				}
				model.ErrorContent=ds.Tables[0].Rows[0]["ErrorContent"].ToString();
				if(ds.Tables[0].Rows[0]["Type"].ToString()!="")
				{
					model.Type=int.Parse(ds.Tables[0].Rows[0]["Type"].ToString());
				}
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
			strSql.Append("select SBXXID,SheetInx,Col,Row,ErrorContent,Type ");
			strSql.Append(" FROM SBBYZXX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����
	}
}

