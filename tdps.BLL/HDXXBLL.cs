using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类HDXXBLL 的摘要说明。
	/// </summary>
	public partial class HDXXBLL
	{
		private readonly tdps.DAL.HDXXDAL dal=new tdps.DAL.HDXXDAL();
		public HDXXBLL()
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
		public void Add(tdps.Model.HDXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.HDXX model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// 更新核定信息的更新时间
        /// </summary>
        public void UpdateGXSJ(tdps.Model.HDXX model)
        {
            dal.UpdateGXSJ(model);
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
		public tdps.Model.HDXX GetModel(string NSRSBH)
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
		public List<tdps.Model.HDXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.HDXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.HDXX> modelList = new List<tdps.Model.HDXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.HDXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.HDXX();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.FileName=dt.Rows[n]["FileName"].ToString();
					model.HDXXXML=dt.Rows[n]["HDXXXML"].ToString();
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

