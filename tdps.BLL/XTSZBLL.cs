using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类XTSZBLL 的摘要说明。
	/// </summary>
	public partial class XTSZBLL
	{
		private readonly tdps.DAL.XTSZDAL dal=new tdps.DAL.XTSZDAL();
		public XTSZBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string XTBBH)
		{
			return dal.Exists(XTBBH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.XTSZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.XTSZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string XTBBH)
		{
			
			dal.Delete(XTBBH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.XTSZ GetModel(string XTBBH)
		{
			
			return dal.GetModel(XTBBH);
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
		public List<tdps.Model.XTSZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.XTSZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.XTSZ> modelList = new List<tdps.Model.XTSZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.XTSZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.XTSZ();
					model.XTBBH=dt.Rows[n]["XTBBH"].ToString();
					model.GXSJ=dt.Rows[n]["GXSJ"].ToString();
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

