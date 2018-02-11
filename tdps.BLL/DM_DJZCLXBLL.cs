using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_DJZCLXBLL 的摘要说明。
	/// </summary>
	public class DM_DJZCLXBLL
	{
		private readonly tdps.DAL.DM_DJZCLXDAL dal=new tdps.DAL.DM_DJZCLXDAL();
		public DM_DJZCLXBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string djzclx_dm)
		{
			return dal.Exists(djzclx_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_DJZCLX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_DJZCLX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string djzclx_dm)
		{
			
			dal.Delete(djzclx_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_DJZCLX GetModel(string djzclx_dm)
		{
			
			return dal.GetModel(djzclx_dm);
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
		public List<tdps.Model.DM_DJZCLX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_DJZCLX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_DJZCLX> modelList = new List<tdps.Model.DM_DJZCLX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_DJZCLX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_DJZCLX();
					model.djzclx_dm=dt.Rows[n]["djzclx_dm"].ToString();
					model.djzclx_mc=dt.Rows[n]["djzclx_mc"].ToString();
					model.djzclx_zl_dm=dt.Rows[n]["djzclx_zl_dm"].ToString();
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

