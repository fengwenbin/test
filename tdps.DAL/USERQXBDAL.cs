using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类USERQXBDAL。
	/// </summary>
	public partial class USERQXBDAL
	{
		public USERQXBDAL()
		{}
		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.USERQXB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into USERQXB(");
			strSql.Append("DLZH,QXBM,NSRSBH)");
			strSql.Append(" values (");
			strSql.Append("@DLZH,@QXBM,@NSRSBH)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@QXBM", DbType.String,4),
                    new SQLiteParameter("@NSRSBH", DbType.String,20)};
			parameters[0].Value = model.DLZH;
			parameters[1].Value = model.QXBM;
            parameters[2].Value = model.NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.USERQXB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update USERQXB set ");
			strSql.Append("DLZH=@DLZH,");
			strSql.Append("QXBM=@QXBM,");
            strSql.Append("NSRSBH=@NSRSBH");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@QXBM", DbType.String,4),
                    new SQLiteParameter("@NSRSBH", DbType.String,20)};
			parameters[0].Value = model.DLZH;
			parameters[1].Value = model.QXBM;
            parameters[2].Value = model.NSRSBH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from USERQXB ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.USERQXB GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DLZH,QXBM,NSRSBH from USERQXB ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
};

			tdps.Model.USERQXB model=new tdps.Model.USERQXB();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.DLZH=ds.Tables[0].Rows[0]["DLZH"].ToString();
				model.QXBM=ds.Tables[0].Rows[0]["QXBM"].ToString();
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
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
			strSql.Append("select DLZH,QXBM,NSRSBH ");
			strSql.Append(" FROM USERQXB ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

