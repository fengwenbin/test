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
		public SBXXSLGXBDAL()
		{}
		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXXSLGXB model)
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

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBXXSLGXB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SBXXSLGXB set ");
			strSql.Append("FID=@FID,");
			strSql.Append("SBXXID=@SBXXID");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@FID", DbType.Int32,4),
					new SQLiteParameter("@SBXXID", DbType.Int32,4)};
			parameters[0].Value = model.FID;
			parameters[1].Value = model.SBXXID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除多条数据
		/// </summary>
		public void Delete(string where, object trans)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBXXSLGXB ");
            strSql.Append(" where " + where);

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans,null);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SBXXSLGXB GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,SBXXID from SBXXSLGXB ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			tdps.Model.SBXXSLGXB model=new tdps.Model.SBXXSLGXB();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["FID"].ToString()!="")
				{
					model.FID=int.Parse(ds.Tables[0].Rows[0]["FID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SBXXID"].ToString()!="")
				{
					model.SBXXID=int.Parse(ds.Tables[0].Rows[0]["SBXXID"].ToString());
				}
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
			strSql.Append("select FID,SBXXID ");
			strSql.Append(" FROM SBXXSLGXB ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

