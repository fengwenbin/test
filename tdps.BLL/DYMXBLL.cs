using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DYMXBLL 的摘要说明。
	/// </summary>
	public partial class DYMXBLL
	{
		private readonly tdps.DAL.DYMXDAL dal=new tdps.DAL.DYMXDAL();
		public DYMXBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SPHM,string JKPZXH,string DYSXH)
		{
			return dal.Exists(SPHM,JKPZXH,DYSXH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.DYMX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DYMX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string SPHM,string JKPZXH,string DYSXH)
		{
			
			dal.Delete(SPHM,JKPZXH,DYSXH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.DYMX GetModel(string SPHM,string JKPZXH,string DYSXH)
		{
			
			return dal.GetModel(SPHM,JKPZXH,DYSXH);
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
		public List<tdps.Model.DYMX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DYMX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DYMX> modelList = new List<tdps.Model.DYMX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DYMX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DYMX();
					model.SPHM=dt.Rows[n]["SPHM"].ToString();
					model.JKPZXH=dt.Rows[n]["JKPZXH"].ToString();
					model.DYSXH=dt.Rows[n]["DYSXH"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
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

