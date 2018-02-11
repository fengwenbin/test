using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类TZGGBLL 的摘要说明。
	/// </summary>
	public class TZGGBLL
	{
		private readonly tdps.DAL.TZGGDAL dal=new tdps.DAL.TZGGDAL();
		public TZGGBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			return dal.Exists(FID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.TZGG model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.TZGG model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int FID)
		{
			
			dal.Delete(FID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.TZGG GetModel(int FID)
		{
			
			return dal.GetModel(FID);
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
		public List<tdps.Model.TZGG> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.TZGG> DataTableToList(DataTable dt)
		{
			List<tdps.Model.TZGG> modelList = new List<tdps.Model.TZGG>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.TZGG model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.TZGG();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.GGBT=dt.Rows[n]["GGBT"].ToString();
					model.FSJG=dt.Rows[n]["FSJG"].ToString();
					model.FSRQ=dt.Rows[n]["FSRQ"].ToString();
					model.YDYQ=dt.Rows[n]["YDYQ"].ToString();
					model.ZT=dt.Rows[n]["ZT"].ToString();
					model.GGLR=dt.Rows[n]["GGLR"].ToString();
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

