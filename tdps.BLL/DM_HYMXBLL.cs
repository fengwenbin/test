using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_HYMXBLL 的摘要说明。
	/// </summary>
	public class DM_HYMXBLL
	{
		private readonly tdps.DAL.DM_HYMXDAL dal=new tdps.DAL.DM_HYMXDAL();
		public DM_HYMXBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hymx_dm)
		{
			return dal.Exists(hymx_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYMX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYMX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hymx_dm)
		{
			
			dal.Delete(hymx_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYMX GetModel(string hymx_dm)
		{
			
			return dal.GetModel(hymx_dm);
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
		public List<tdps.Model.DM_HYMX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_HYMX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYMX> modelList = new List<tdps.Model.DM_HYMX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYMX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYMX();
					model.hymx_dm=dt.Rows[n]["hymx_dm"].ToString();
					model.hymx_mc=dt.Rows[n]["hymx_mc"].ToString();
					model.hymx_jc=dt.Rows[n]["hymx_jc"].ToString();
					model.hydl_dm=dt.Rows[n]["hydl_dm"].ToString();
					model.xybz=dt.Rows[n]["xybz"].ToString();
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

