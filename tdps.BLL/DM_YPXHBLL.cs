using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_YPXHBLL 的摘要说明。
	/// </summary>
	public class DM_YPXHBLL
	{
		private readonly tdps.DAL.DM_YPXHDAL dal=new tdps.DAL.DM_YPXHDAL();
		public DM_YPXHBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ypxh_dm)
		{
			return dal.Exists(ypxh_dm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_YPXH model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_YPXH model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string ypxh_dm)
		{
			
			dal.Delete(ypxh_dm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_YPXH GetModel(string ypxh_dm)
		{
			
			return dal.GetModel(ypxh_dm);
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
		public List<tdps.Model.DM_YPXH> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_YPXH> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_YPXH> modelList = new List<tdps.Model.DM_YPXH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_YPXH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_YPXH();
					model.ypxh_dm=dt.Rows[n]["ypxh_dm"].ToString();
					model.ypxh_mc=dt.Rows[n]["ypxh_mc"].ToString();
					model.bz=dt.Rows[n]["bz"].ToString();
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

