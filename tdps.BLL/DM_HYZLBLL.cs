using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_HYZLBLL 的摘要说明。
	/// </summary>
	public class DM_HYZLBLL
	{
		private readonly tdps.DAL.DM_HYZLDAL dal=new tdps.DAL.DM_HYZLDAL();
		public DM_HYZLBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hyzl_dm)
		{
			return dal.Exists(hyzl_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYZL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYZL model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hyzl_dm)
		{
			
			dal.Delete(hyzl_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYZL GetModel(string hyzl_dm)
		{
			
			return dal.GetModel(hyzl_dm);
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
		public List<tdps.Model.DM_HYZL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_HYZL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYZL> modelList = new List<tdps.Model.DM_HYZL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYZL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYZL();
					model.hyzl_dm=dt.Rows[n]["hyzl_dm"].ToString();
					model.hyzl_mc=dt.Rows[n]["hyzl_mc"].ToString();
					model.hyzl_jc=dt.Rows[n]["hyzl_jc"].ToString();
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

