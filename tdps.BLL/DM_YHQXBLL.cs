using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_YHQXBLL 的摘要说明。
	/// </summary>
	public class DM_YHQXBLL
	{
		private readonly tdps.DAL.DM_YHQXDAL dal=new tdps.DAL.DM_YHQXDAL();
		public DM_YHQXBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string QXBM)
		{
			return dal.Exists(QXBM);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_YHQX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_YHQX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string QXBM)
		{
			
			dal.Delete(QXBM);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_YHQX GetModel(string QXBM)
		{
			
			return dal.GetModel(QXBM);
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
		public List<tdps.Model.DM_YHQX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_YHQX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_YHQX> modelList = new List<tdps.Model.DM_YHQX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_YHQX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_YHQX();
					model.QXBM=dt.Rows[n]["QXBM"].ToString();
					model.QXMC=dt.Rows[n]["QXMC"].ToString();
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

