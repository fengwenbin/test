using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_DJFFBLL 的摘要说明。
	/// </summary>
	public class DM_DJFFBLL
	{
		private readonly tdps.DAL.DM_DJFFDAL dal=new tdps.DAL.DM_DJFFDAL();
		public DM_DJFFBLL()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_DJFF model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_DJFF model)
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
		public tdps.Model.DM_DJFF GetModel()
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
		public List<tdps.Model.DM_DJFF> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_DJFF> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_DJFF> modelList = new List<tdps.Model.DM_DJFF>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_DJFF model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_DJFF();
					model.djff_dm=dt.Rows[n]["djff_dm"].ToString();
					model.djff_mc=dt.Rows[n]["djff_mc"].ToString();
					model.djff_jc=dt.Rows[n]["djff_jc"].ToString();
					model.yxbz=dt.Rows[n]["yxbz"].ToString();
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

