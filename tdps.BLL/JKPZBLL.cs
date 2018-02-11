using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类JKPZBLL 的摘要说明。
	/// </summary>
	public partial class JKPZBLL
	{
		private readonly tdps.DAL.JKPZDAL dal=new tdps.DAL.JKPZDAL();
		public JKPZBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string JKPZXH)
		{
			return dal.Exists(JKPZXH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.JKPZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.JKPZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string JKPZXH)
		{
			
			dal.Delete(JKPZXH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.JKPZ GetModel(string JKPZXH)
		{
			
			return dal.GetModel(JKPZXH);
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
		public List<tdps.Model.JKPZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.JKPZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.JKPZ> modelList = new List<tdps.Model.JKPZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.JKPZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.JKPZ();
					model.JKPZXH=dt.Rows[n]["JKPZXH"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.NSRSWJGDM=dt.Rows[n]["NSRSWJGDM"].ToString();
					model.NSRSWJGMC=dt.Rows[n]["NSRSWJGMC"].ToString();
					model.ZSSWJGDM=dt.Rows[n]["ZSSWJGDM"].ToString();
					model.ZSSWJGMC=dt.Rows[n]["ZSSWJGMC"].ToString();
					model.PZDYFS=dt.Rows[n]["PZDYFS"].ToString();
					model.DYSJ=dt.Rows[n]["DYSJ"].ToString();
					if(dt.Rows[n]["HJJE"].ToString()!="")
					{
						model.HJJE=decimal.Parse(dt.Rows[n]["HJJE"].ToString());
					}
					model.FWM=dt.Rows[n]["FWM"].ToString();
					model.DZYZDATA=dt.Rows[n]["DZYZDATA"].ToString();
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

