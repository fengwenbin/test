using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DBVersionDAL。
	/// </summary>
	public class DBVersionDAL
	{
		public DBVersionDAL()
		{}
		#region  成员方法


		/// <summary>
		/// 增加一条数据
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
		/// 更新一条数据
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
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DBVersion ");
			SQLiteHelper.ExecuteNonQuery(strSql.ToString());
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DBVersion GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
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
		/// 获得数据列表
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


		#endregion  成员方法
	}
}

