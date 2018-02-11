using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_HYDLBLL 的摘要说明。
	/// </summary>
	public class DM_HYDLBLL
	{
		private readonly tdps.DAL.DM_HYDLDAL dal=new tdps.DAL.DM_HYDLDAL();
		public DM_HYDLBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string hydl_dm)
		{
			return dal.Exists(hydl_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_HYDL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_HYDL model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string hydl_dm)
		{
			
			dal.Delete(hydl_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_HYDL GetModel(string hydl_dm)
		{
			
			return dal.GetModel(hydl_dm);
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
		public List<tdps.Model.DM_HYDL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_HYDL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYDL> modelList = new List<tdps.Model.DM_HYDL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYDL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYDL();
					model.hydl_dm=dt.Rows[n]["hydl_dm"].ToString();
					model.hydl_mc=dt.Rows[n]["hydl_mc"].ToString();
					model.hydl_jc=dt.Rows[n]["hydl_jc"].ToString();
					model.hyml_dm=dt.Rows[n]["hyml_dm"].ToString();
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

