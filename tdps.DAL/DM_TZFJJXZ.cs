/**  版本信息模板在安装目录下，可自行修改。
* DM_TZFJJXZ.cs
*
* 功 能： N/A
* 类 名： DM_TZFJJXZ
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015-01-12 14:39:17   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// 数据访问类:DM_TZFJJXZ
	/// </summary>
	public partial class DM_TZFJJXZDAL
	{
        public DM_TZFJJXZDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string tzfjjxz_dm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_TZFJJXZ");
			strSql.Append(" where tzfjjxz_dm=@tzfjjxz_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tzfjjxz_dm", DbType.String,3)			};
			parameters[0].Value = tzfjjxz_dm;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(tdps.Model.DM_TZFJJXZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_TZFJJXZ(");
			strSql.Append("tzfjjxz_dm,tzfjjxz_mc)");
			strSql.Append(" values (");
			strSql.Append("@tzfjjxz_dm,@tzfjjxz_mc)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tzfjjxz_dm", DbType.String,3),
					new SQLiteParameter("@tzfjjxz_mc", DbType.String,50)};
			parameters[0].Value = model.tzfjjxz_dm;
			parameters[1].Value = model.tzfjjxz_mc;

            int rows = SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tdps.Model.DM_TZFJJXZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_TZFJJXZ set ");
			strSql.Append("tzfjjxz_mc=@tzfjjxz_mc");
			strSql.Append(" where tzfjjxz_dm=@tzfjjxz_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tzfjjxz_mc", DbType.String,50),
					new SQLiteParameter("@tzfjjxz_dm", DbType.String,3)};
			parameters[0].Value = model.tzfjjxz_mc;
			parameters[1].Value = model.tzfjjxz_dm;

            int rows = SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string tzfjjxz_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_TZFJJXZ ");
			strSql.Append(" where tzfjjxz_dm=@tzfjjxz_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tzfjjxz_dm", DbType.String,3)			};
			parameters[0].Value = tzfjjxz_dm;

            int rows = SQLiteHelper.ExecuteNonQuery(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string tzfjjxz_dmlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_TZFJJXZ ");
			strSql.Append(" where tzfjjxz_dm in ("+tzfjjxz_dmlist + ")  ");
			int rows=SQLiteHelper.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_TZFJJXZ GetModel(string tzfjjxz_dm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select tzfjjxz_dm,tzfjjxz_mc from DM_TZFJJXZ ");
			strSql.Append(" where tzfjjxz_dm=@tzfjjxz_dm ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tzfjjxz_dm", DbType.String,3)			};
			parameters[0].Value = tzfjjxz_dm;

			tdps.Model.DM_TZFJJXZ model=new tdps.Model.DM_TZFJJXZ();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_TZFJJXZ DataRowToModel(DataRow row)
		{
			tdps.Model.DM_TZFJJXZ model=new tdps.Model.DM_TZFJJXZ();
			if (row != null)
			{
				if(row["tzfjjxz_dm"]!=null)
				{
					model.tzfjjxz_dm=row["tzfjjxz_dm"].ToString();
				}
				if(row["tzfjjxz_mc"]!=null)
				{
					model.tzfjjxz_mc=row["tzfjjxz_mc"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select tzfjjxz_dm,tzfjjxz_mc ");
			strSql.Append(" FROM DM_TZFJJXZ ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.tzfjjxz_dm desc");
			}
			strSql.Append(")AS Row, T.*  from DM_TZFJJXZ T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "DM_TZFJJXZ";
			parameters[1].Value = "tzfjjxz_dm";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return SQLiteHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

