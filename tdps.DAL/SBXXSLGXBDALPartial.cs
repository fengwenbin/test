using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类SBXXSLGXBDAL。
	/// </summary>
	public partial class SBXXSLGXBDAL
	{
		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXXSLGXB model ,object trans)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBXXSLGXB(");
			strSql.Append("FID,SBXXID)");
			strSql.Append(" values (");
			strSql.Append("@FID,@SBXXID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.SBXXID;

			SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}

		#endregion  成员方法
	}
}

