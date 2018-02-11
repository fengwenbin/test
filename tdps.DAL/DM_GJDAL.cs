using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类DM_GJDAL。
	/// </summary>
	public class DM_GJDAL
	{
		public DM_GJDAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string gj_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(gj_dm) from DM_GJ");
			strSql.Append(" where gj_dm=@gj_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@gj_dm", DbType.String,50)};
			parameters[0].Value = gj_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_GJ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_GJ(");
			strSql.Append("gj_dm,gj_mc,gj_jc,xybz,gj_mc_yw,gj_jc_yw,gj_jc_yw2,gj_jc_yw3)");
			strSql.Append(" values (");
			strSql.Append("@gj_dm,@gj_mc,@gj_jc,@xybz,@gj_mc_yw,@gj_jc_yw,@gj_jc_yw2,@gj_jc_yw3)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@gj_dm", DbType.String,3),
					new SQLiteParameter("@gj_mc", DbType.String,40),
					new SQLiteParameter("@gj_jc", DbType.String,30),
					new SQLiteParameter("@xybz", DbType.String,1),
					new SQLiteParameter("@gj_mc_yw", DbType.String,70),
					new SQLiteParameter("@gj_jc_yw", DbType.String,70),
					new SQLiteParameter("@gj_jc_yw2", DbType.String,2),
					new SQLiteParameter("@gj_jc_yw3", DbType.String,3)};
			parameters[0].Value = model.gj_dm;
			parameters[1].Value = model.gj_mc;
			parameters[2].Value = model.gj_jc;
			parameters[3].Value = model.xybz;
			parameters[4].Value = model.gj_mc_yw;
			parameters[5].Value = model.gj_jc_yw;
			parameters[6].Value = model.gj_jc_yw2;
			parameters[7].Value = model.gj_jc_yw3;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_GJ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_GJ set ");
			strSql.Append("gj_mc=@gj_mc,");
			strSql.Append("gj_jc=@gj_jc,");
			strSql.Append("xybz=@xybz,");
			strSql.Append("gj_mc_yw=@gj_mc_yw,");
			strSql.Append("gj_jc_yw=@gj_jc_yw,");
			strSql.Append("gj_jc_yw2=@gj_jc_yw2,");
			strSql.Append("gj_jc_yw3=@gj_jc_yw3");
			strSql.Append(" where gj_dm=@gj_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@gj_dm", DbType.String,3),
					new SQLiteParameter("@gj_mc", DbType.String,40),
					new SQLiteParameter("@gj_jc", DbType.String,30),
					new SQLiteParameter("@xybz", DbType.String,1),
					new SQLiteParameter("@gj_mc_yw", DbType.String,70),
					new SQLiteParameter("@gj_jc_yw", DbType.String,70),
					new SQLiteParameter("@gj_jc_yw2", DbType.String,2),
					new SQLiteParameter("@gj_jc_yw3", DbType.String,3)};
			parameters[0].Value = model.gj_dm;
			parameters[1].Value = model.gj_mc;
			parameters[2].Value = model.gj_jc;
			parameters[3].Value = model.xybz;
			parameters[4].Value = model.gj_mc_yw;
			parameters[5].Value = model.gj_jc_yw;
			parameters[6].Value = model.gj_jc_yw2;
			parameters[7].Value = model.gj_jc_yw3;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string gj_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_GJ ");
			strSql.Append(" where gj_dm=@gj_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@gj_dm", DbType.String,50)};
			parameters[0].Value = gj_dm;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_GJ GetModel(string gj_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select gj_dm,gj_mc,gj_jc,xybz,gj_mc_yw,gj_jc_yw,gj_jc_yw2,gj_jc_yw3 from DM_GJ ");
			strSql.Append(" where gj_dm=@gj_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@gj_dm", DbType.String,50)};
			parameters[0].Value = gj_dm;

			tdps.Model.DM_GJ model=new tdps.Model.DM_GJ();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.gj_dm=ds.Tables[0].Rows[0]["gj_dm"].ToString();
				model.gj_mc=ds.Tables[0].Rows[0]["gj_mc"].ToString();
				model.gj_jc=ds.Tables[0].Rows[0]["gj_jc"].ToString();
				model.xybz=ds.Tables[0].Rows[0]["xybz"].ToString();
				model.gj_mc_yw=ds.Tables[0].Rows[0]["gj_mc_yw"].ToString();
				model.gj_jc_yw=ds.Tables[0].Rows[0]["gj_jc_yw"].ToString();
				model.gj_jc_yw2=ds.Tables[0].Rows[0]["gj_jc_yw2"].ToString();
				model.gj_jc_yw3=ds.Tables[0].Rows[0]["gj_jc_yw3"].ToString();
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
			strSql.Append("select gj_dm,gj_mc,gj_jc,xybz,gj_mc_yw,gj_jc_yw,gj_jc_yw2,gj_jc_yw3 ");
			strSql.Append(" FROM DM_GJ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}

        public StringBuilder GetDroplistGj()
        {
            StringBuilder stb = new StringBuilder();
            string sql = "SELECT gj_dm,gj_mc FROM DM_GJ ";            
            using (SQLiteDataReader sqlred = SQLiteHelper.ExecuteReader(sql))
            {
               while(sqlred.Read())
               {
                   stb.AppendFormat("{1}\t{0}\r\n", sqlred.GetString(0), sqlred.GetString(1));
               }
            }
            return stb;
        }

        public StringBuilder GetDroplistGj2()
        {
            StringBuilder stb = new StringBuilder();
            string sql = "SELECT gj_dm,gj_mc FROM DM_GJ ";
            using (SQLiteDataReader sqlred = SQLiteHelper.ExecuteReader(sql))
            {
                while (sqlred.Read())
                {
                    stb.AppendFormat("{1}\t{0}\r\n", sqlred.GetString(0), sqlred.GetString(1) + "(" + sqlred.GetString(0)+")");
                }
            }
            return stb;
        }

		#endregion  成员方法
	}
}

