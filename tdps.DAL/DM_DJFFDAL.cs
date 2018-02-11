using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����DM_DJFFDAL��
	/// </summary>
	public class DM_DJFFDAL
	{
		public DM_DJFFDAL()
		{}
		#region  ��Ա����


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_DJFF model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_DJFF(");
			strSql.Append("djff_dm,djff_mc,djff_jc,yxbz,xybz)");
			strSql.Append(" values (");
			strSql.Append("@djff_dm,@djff_mc,@djff_jc,@yxbz,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djff_dm", DbType.String,2),
					new SQLiteParameter("@djff_mc", DbType.String,40),
					new SQLiteParameter("@djff_jc", DbType.String,30),
					new SQLiteParameter("@yxbz", DbType.String,1),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.djff_dm;
			parameters[1].Value = model.djff_mc;
			parameters[2].Value = model.djff_jc;
			parameters[3].Value = model.yxbz;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_DJFF model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_DJFF set ");
			strSql.Append("djff_dm=@djff_dm,");
			strSql.Append("djff_mc=@djff_mc,");
			strSql.Append("djff_jc=@djff_jc,");
			strSql.Append("yxbz=@yxbz,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@djff_dm", DbType.String,2),
					new SQLiteParameter("@djff_mc", DbType.String,40),
					new SQLiteParameter("@djff_jc", DbType.String,30),
					new SQLiteParameter("@yxbz", DbType.String,1),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.djff_dm;
			parameters[1].Value = model.djff_mc;
			parameters[2].Value = model.djff_jc;
			parameters[3].Value = model.yxbz;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_DJFF ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_DJFF GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select djff_dm,djff_mc,djff_jc,yxbz,xybz from DM_DJFF ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			tdps.Model.DM_DJFF model=new tdps.Model.DM_DJFF();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.djff_dm=ds.Tables[0].Rows[0]["djff_dm"].ToString();
				model.djff_mc=ds.Tables[0].Rows[0]["djff_mc"].ToString();
				model.djff_jc=ds.Tables[0].Rows[0]["djff_jc"].ToString();
				model.yxbz=ds.Tables[0].Rows[0]["yxbz"].ToString();
				model.xybz=ds.Tables[0].Rows[0]["xybz"].ToString();
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
			strSql.Append("select djff_dm,djff_mc,djff_jc,yxbz,xybz ");
			strSql.Append(" FROM DM_DJFF ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����
	}
}

