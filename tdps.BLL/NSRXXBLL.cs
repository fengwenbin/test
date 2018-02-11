using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类NSRXXBLL 的摘要说明。
	/// </summary>
    public partial class NSRXXBLL
	{
		private readonly tdps.DAL.NSRXXDAL dal=new tdps.DAL.NSRXXDAL();
		public NSRXXBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NSRSBH)
		{
			return dal.Exists(NSRSBH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.NSRXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.NSRXX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			dal.Delete(NSRSBH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.NSRXX GetModel(string NSRSBH)
		{
			
			return dal.GetModel(NSRSBH);
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
		public List<tdps.Model.NSRXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.NSRXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.NSRXX> modelList = new List<tdps.Model.NSRXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.NSRXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.NSRXX();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.FDDBRMC=dt.Rows[n]["FDDBRMC"].ToString();
					model.ZCDZ=dt.Rows[n]["ZCDZ"].ToString();
					model.YYDZ=dt.Rows[n]["YYDZ"].ToString();
					model.DHHM=dt.Rows[n]["DHHM"].ToString();
                    //if(dt.Rows[n]["YB"].ToString()!="")
                    //{
						model.YB=dt.Rows[n]["YB"].ToString();
                    //}
					model.QYHGDM=dt.Rows[n]["QYHGDM"].ToString();
					//model.SBMM=dt.Rows[n]["SBMM"].ToString();
					model.FileName=dt.Rows[n]["FileName"].ToString();
                    model.FDQNSR = dt.Rows[n]["fdqnsr"].ToString();
                    model.TDPSID = dt.Rows[n]["TDPSID"].ToString();
                    model.NFYDQ = dt.Rows[n]["NFYDQ"].ToString();
                    model.TSYHLX = dt.Rows[n]["TSYHLX"].ToString();
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

