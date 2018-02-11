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
		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.USERQXB model,object trans)
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

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string DLZH, string NSRSBH, object trans)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from USERQXB ");
            strSql.Append(" where DLZH=@DLZH and NSRSBH=@NSRSBH");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),new SQLiteParameter("@NSRSBH", DbType.String,20)};
            parameters[0].Value = DLZH;
            parameters[1].Value = NSRSBH;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }


	
		#endregion  成员方法
	}
}

