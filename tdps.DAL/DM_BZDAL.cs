using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_BZDAL。
	/// </summary>
	public class DM_BZDAL
	{
		public DM_BZDAL()
		{}
		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_BZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BZ(");
			strSql.Append("bz_dm,bz_mc,bz_dw,bz_hl,xybz)");
			strSql.Append(" values (");
			strSql.Append("@bz_dm,@bz_mc,@bz_dw,@bz_hl,@xybz)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bz_dm", DbType.String,3),
					new SQLiteParameter("@bz_mc", DbType.String,30),
					new SQLiteParameter("@bz_dw", DbType.Decimal,9),
					new SQLiteParameter("@bz_hl", DbType.Decimal,9),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.bz_dm;
			parameters[1].Value = model.bz_mc;
			parameters[2].Value = model.bz_dw;
			parameters[3].Value = model.bz_hl;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_BZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BZ set ");
			strSql.Append("bz_dm=@bz_dm,");
			strSql.Append("bz_mc=@bz_mc,");
			strSql.Append("bz_dw=@bz_dw,");
			strSql.Append("bz_hl=@bz_hl,");
			strSql.Append("xybz=@xybz");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@bz_dm", DbType.String,3),
					new SQLiteParameter("@bz_mc", DbType.String,30),
					new SQLiteParameter("@bz_dw", DbType.Decimal,9),
					new SQLiteParameter("@bz_hl", DbType.Decimal,9),
					new SQLiteParameter("@xybz", DbType.String,1)};
			parameters[0].Value = model.bz_dm;
			parameters[1].Value = model.bz_mc;
			parameters[2].Value = model.bz_dw;
			parameters[3].Value = model.bz_hl;
			parameters[4].Value = model.xybz;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_BZ ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_BZ GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select bz_dm,bz_mc,bz_dw,bz_hl,xybz from DM_BZ ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			tdps.Model.DM_BZ model=new tdps.Model.DM_BZ();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.bz_dm=ds.Tables[0].Rows[0]["bz_dm"].ToString();
				model.bz_mc=ds.Tables[0].Rows[0]["bz_mc"].ToString();
				if(ds.Tables[0].Rows[0]["bz_dw"].ToString()!="")
				{
					model.bz_dw=decimal.Parse(ds.Tables[0].Rows[0]["bz_dw"].ToString());
				}
				if(ds.Tables[0].Rows[0]["bz_hl"].ToString()!="")
				{
					model.bz_hl=decimal.Parse(ds.Tables[0].Rows[0]["bz_hl"].ToString());
				}
				model.xybz=ds.Tables[0].Rows[0]["xybz"].ToString();
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
			strSql.Append("select bz_dm,bz_mc,bz_dw,bz_hl,xybz ");
			strSql.Append(" FROM DM_BZ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

