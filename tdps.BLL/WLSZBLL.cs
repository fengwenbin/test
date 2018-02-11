using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类WLSZBLL 的摘要说明。
	/// </summary>
	public class WLSZBLL
	{
		private readonly tdps.DAL.WLSZDAL dal=new tdps.DAL.WLSZDAL();
		public WLSZBLL()
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
		public void Add(tdps.Model.WLSZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.WLSZ model)
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
		public tdps.Model.WLSZ GetModel(int FID)
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
		public List<tdps.Model.WLSZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.WLSZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.WLSZ> modelList = new List<tdps.Model.WLSZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.WLSZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.WLSZ();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.FWQIP=dt.Rows[n]["FWQIP"].ToString();
					if(dt.Rows[n]["FWQDK"].ToString()!="")
					{
						model.FWQDK=int.Parse(dt.Rows[n]["FWQDK"].ToString());
					}
					if(dt.Rows[n]["SFMR"].ToString()!="")
					{
						model.SFMR=int.Parse(dt.Rows[n]["SFMR"].ToString());
					}
					if(dt.Rows[n]["SFQYNQLJ"].ToString()!="")
					{
						model.SFQYNQLJ=int.Parse(dt.Rows[n]["SFQYNQLJ"].ToString());
					}
                    model.GXSJ = dt.Rows[n]["GXSJ"].ToString();
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

        #region 自定义成员方法
        /// <summary>
        /// 取消默认
        /// </summary>
        /// <param name="szfl">税种分类</param>
        /// <returns></returns>
        public void CancelSFMR(int szfl)
        {
            dal.CancelSFMR(szfl);
        }
        #endregion  成员方法
	}
}

