using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����DYMXDAL��
	/// </summary>
	public partial class DYMXDAL
	{
		#region  ��Ա����


		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.DYMX model, object trans)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into DYMX(");
            strSql.Append("SPHM,JKPZXH,DYSXH,NSRSBH)");
            strSql.Append(" values (");
            strSql.Append("@SPHM,@JKPZXH,@DYSXH,@NSRSBH)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SPHM", DbType.String,20),
					new SQLiteParameter("@JKPZXH", DbType.String,15),
					new SQLiteParameter("@DYSXH", DbType.String,10),
					new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = model.SPHM;
            parameters[1].Value = model.JKPZXH;
            parameters[2].Value = model.DYSXH;
            parameters[3].Value = model.NSRSBH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

		
		#endregion  ��Ա����
	}
}

