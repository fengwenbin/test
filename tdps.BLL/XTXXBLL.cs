using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类XTXXBLL 的摘要说明。
	/// </summary>
	public class XTXXBLL
	{
		private readonly tdps.DAL.XTXXDAL dal=new tdps.DAL.XTXXDAL();
		public XTXXBLL()
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
		public void Add(tdps.Model.XTXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.XTXX model)
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
		public tdps.Model.XTXX GetModel(int FID)
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
		public List<tdps.Model.XTXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.XTXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.XTXX> modelList = new List<tdps.Model.XTXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.XTXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.XTXX();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.FSRQ=dt.Rows[n]["FSRQ"].ToString();
					model.ZT=dt.Rows[n]["ZT"].ToString();
					model.LR=dt.Rows[n]["LR"].ToString();
					model.XXLX=dt.Rows[n]["XXLX"].ToString();
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

