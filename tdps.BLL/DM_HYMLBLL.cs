using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_HYMLBLL 的摘要说明。
	/// </summary>
	public class DM_HYMLBLL
	{
		private readonly tdps.DAL.DM_HYMLDAL dal=new tdps.DAL.DM_HYMLDAL();
		public DM_HYMLBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hyml_dm)
		{
			return dal.Exists(hyml_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYML model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYML model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hyml_dm)
		{
			
			dal.Delete(hyml_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYML GetModel(string hyml_dm)
		{
			
			return dal.GetModel(hyml_dm);
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
		public List<tdps.Model.DM_HYML> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_HYML> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYML> modelList = new List<tdps.Model.DM_HYML>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYML model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYML();
					model.hyml_dm=dt.Rows[n]["hyml_dm"].ToString();
					model.hyml_mc=dt.Rows[n]["hyml_mc"].ToString();
					model.hyml_jc=dt.Rows[n]["hyml_jc"].ToString();
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

