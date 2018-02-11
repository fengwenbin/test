using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类UserFunctionDAL。
	/// </summary>
	public class UserFunctionDAL
	{
		public UserFunctionDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(ID) from UserFunction");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4)};
			parameters[0].Value = ID;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.UserFunction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserFunction(");
			strSql.Append("NSRSBH,DLZH,GNBH,SFKY,SFBX)");
			strSql.Append(" values (");
			strSql.Append("@NSRSBH,@DLZH,@GNBH,@SFKY,@SFBX)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,30),
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@GNBH", DbType.String,5),
					new SQLiteParameter("@SFKY", DbType.String,1),
					new SQLiteParameter("@SFBX", DbType.String,1)};
			parameters[0].Value = model.NSRSBH;
			parameters[1].Value = model.DLZH;
			parameters[2].Value = model.GNBH;
			parameters[3].Value = model.SFKY;
			parameters[4].Value = model.SFBX;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.UserFunction model, object trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserFunction(");
            strSql.Append("NSRSBH,DLZH,GNBH,SFKY,SFBX)");
            strSql.Append(" values (");
            strSql.Append("@NSRSBH,@DLZH,@GNBH,@SFKY,@SFBX)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@NSRSBH", DbType.String,30),
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@GNBH", DbType.String,5),
					new SQLiteParameter("@SFKY", DbType.String,1),
					new SQLiteParameter("@SFBX", DbType.String,1)};
            parameters[0].Value = model.NSRSBH;
            parameters[1].Value = model.DLZH;
            parameters[2].Value = model.GNBH;
            parameters[3].Value = model.SFKY;
            parameters[4].Value = model.SFBX;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.UserFunction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserFunction set ");
			strSql.Append("NSRSBH=@NSRSBH,");
			strSql.Append("DLZH=@DLZH,");
			strSql.Append("GNBH=@GNBH,");
			strSql.Append("SFKY=@SFKY,");
			strSql.Append("SFBX=@SFBX");
            strSql.Append(" where NSRSBH=@NSRSBH and DLZH=@DLZH and GNBH=@GNBH");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4),
					new SQLiteParameter("@NSRSBH", DbType.String,30),
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@GNBH", DbType.String,5),
					new SQLiteParameter("@SFKY", DbType.String,1),
					new SQLiteParameter("@SFBX", DbType.String,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.NSRSBH;
			parameters[2].Value = model.DLZH;
			parameters[3].Value = model.GNBH;
			parameters[4].Value = model.SFKY;
			parameters[5].Value = model.SFBX;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserFunction ");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.Int32,4)};
			parameters[0].Value = ID;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.UserFunction GetModel(string dlzh,string nsrsbh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,NSRSBH,DLZH,GNBH,SFKY,SFBX from UserFunction ");
            strSql.Append(" where dlzh=@dlzh and nsrsbh=@nsrsbh");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@dlzh", DbType.String,30),
                                           new SQLiteParameter("@nsrsbh", DbType.String,20)};
            parameters[0].Value = dlzh;
            parameters[1].Value = nsrsbh;

			tdps.Model.UserFunction model=new tdps.Model.UserFunction();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.DLZH=ds.Tables[0].Rows[0]["DLZH"].ToString();
				model.GNBH=ds.Tables[0].Rows[0]["GNBH"].ToString();
				if(ds.Tables[0].Rows[0]["SFKY"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["SFKY"].ToString()=="1")||(ds.Tables[0].Rows[0]["SFKY"].ToString().ToLower()=="true"))
					{
						model.SFKY="1";
					}
					else
					{
						model.SFKY="0";
					}
				}
				if(ds.Tables[0].Rows[0]["SFBX"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["SFBX"].ToString()=="1")||(ds.Tables[0].Rows[0]["SFBX"].ToString().ToLower()=="true"))
					{
						model.SFBX="1";
					}
					else
					{
						model.SFBX="0";
					}
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
			strSql.Append("select ID,NSRSBH,DLZH,GNBH,SFKY,SFBX ");
			strSql.Append(" FROM UserFunction ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  成员方法
	}
}

