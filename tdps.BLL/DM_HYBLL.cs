using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_HYBLL 的摘要说明。
	/// </summary>
	public class DM_HYBLL
	{
		private readonly tdps.DAL.DM_HYDAL dal=new tdps.DAL.DM_HYDAL();
		public DM_HYBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hy_dm)
		{
			return dal.Exists(hy_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HY model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HY model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hy_dm)
		{
			
			dal.Delete(hy_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HY GetModel(string hy_dm)
		{
			
			return dal.GetModel(hy_dm);
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
		public List<tdps.Model.DM_HY> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_HY> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HY> modelList = new List<tdps.Model.DM_HY>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HY model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HY();
					model.hy_dm=dt.Rows[n]["hy_dm"].ToString();
					model.hy_mc=dt.Rows[n]["hy_mc"].ToString();
					model.hy_jc=dt.Rows[n]["hy_jc"].ToString();
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

