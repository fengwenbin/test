using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DM_CWJSBLL 的摘要说明。
	/// </summary>
	public class DM_CWJSBLL
	{
		private readonly tdps.DAL.DM_CWJSDAL dal=new tdps.DAL.DM_CWJSDAL();
		public DM_CWJSBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CWJSBM)
		{
			return dal.Exists(CWJSBM);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DM_CWJS model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DM_CWJS model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string CWJSBM)
		{
			
			dal.Delete(CWJSBM);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DM_CWJS GetModel(string CWJSBM)
		{
			
			return dal.GetModel(CWJSBM);
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
		public List<tdps.Model.DM_CWJS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DM_CWJS> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_CWJS> modelList = new List<tdps.Model.DM_CWJS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_CWJS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_CWJS();
					model.CWJSBM=dt.Rows[n]["CWJSBM"].ToString();
					model.CWJSMC=dt.Rows[n]["CWJSMC"].ToString();
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

