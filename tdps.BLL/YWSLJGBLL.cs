using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类YWSLJGBLL 的摘要说明。
	/// </summary>
	public partial class YWSLJGBLL
	{
		private readonly tdps.DAL.YWSLJGDAL dal=new tdps.DAL.YWSLJGDAL();
		public YWSLJGBLL()
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
		public void Add(tdps.Model.YWSLJG model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.YWSLJG model)
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
        /// 删除多条数据
        /// </summary>
        public void Delete(string where,object tran)
        {

            dal.Delete(where, tran);
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.YWSLJG GetModel(int FID)
		{
			
			return dal.GetModel(FID);
		}
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.YWSLJG GetModel(string whereSql)
        {

            return dal.GetModel(whereSql);
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
		public List<tdps.Model.YWSLJG> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.YWSLJG> DataTableToList(DataTable dt)
		{
			List<tdps.Model.YWSLJG> modelList = new List<tdps.Model.YWSLJG>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.YWSLJG model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.YWSLJG();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.FileName=dt.Rows[n]["FileName"].ToString();
					model.returnCode=dt.Rows[n]["returnCode"].ToString();
					model.returnMessage=dt.Rows[n]["returnMessage"].ToString();
					model.businessID=dt.Rows[n]["businessID"].ToString();
					model.jmm=dt.Rows[n]["jmm"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.createTime=dt.Rows[n]["createTime"].ToString();
					model.SWJGDM=dt.Rows[n]["SWJGDM"].ToString();
					model.JYSLXX=dt.Rows[n]["JYSLXX"].ToString();
					model.swjgMc=dt.Rows[n]["swjgMc"].ToString();
					model.DZYZData=dt.Rows[n]["DZYZData"].ToString();
					model.MW=dt.Rows[n]["MW"].ToString();
					model.SLLX=dt.Rows[n]["SLLX"].ToString();
					model.KHDFSSJ=dt.Rows[n]["KHDFSSJ"].ToString();
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

