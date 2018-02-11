using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DBVersionBLL 的摘要说明。
	/// </summary>
	public class DBVersionBLL
	{
		private readonly tdps.DAL.DBVersionDAL dal=new tdps.DAL.DBVersionDAL();
		public DBVersionBLL()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DBVersion model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DBVersion model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
            dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DBVersion GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DBVersion> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DBVersion> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DBVersion> modelList = new List<tdps.Model.DBVersion>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DBVersion model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DBVersion();
					if(dt.Rows[n]["version"].ToString()!="")
					{
						model.version=int.Parse(dt.Rows[n]["version"].ToString());
					}
					model.UKeyID=dt.Rows[n]["UKeyID"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}


		#endregion  成员方法
	}
}

