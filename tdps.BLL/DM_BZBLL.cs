using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_BZBLL 的摘要说明。
	/// </summary>
	public class DM_BZBLL
	{
		private readonly tdps.DAL.DM_BZDAL dal=new tdps.DAL.DM_BZDAL();
		public DM_BZBLL()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_BZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_BZ model)
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
		public tdps.Model.DM_BZ GetModel()
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
		public List<tdps.Model.DM_BZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_BZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_BZ> modelList = new List<tdps.Model.DM_BZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_BZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_BZ();
					model.bz_dm=dt.Rows[n]["bz_dm"].ToString();
					model.bz_mc=dt.Rows[n]["bz_mc"].ToString();
					if(dt.Rows[n]["bz_dw"].ToString()!="")
					{
						model.bz_dw=decimal.Parse(dt.Rows[n]["bz_dw"].ToString());
					}
					if(dt.Rows[n]["bz_hl"].ToString()!="")
					{
						model.bz_hl=decimal.Parse(dt.Rows[n]["bz_hl"].ToString());
					}
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

