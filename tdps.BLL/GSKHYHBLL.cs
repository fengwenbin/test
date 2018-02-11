using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类GSKHYHBLL 的摘要说明。
	/// </summary>
	public partial class GSKHYHBLL
	{
		private readonly tdps.DAL.GSKHYHDAL dal=new tdps.DAL.GSKHYHDAL();
		public GSKHYHBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NSRSBH,string KHZH)
		{
			return dal.Exists(NSRSBH,KHZH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.GSKHYH model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.GSKHYH model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string NSRSBH,string KHZH)
		{
			
			dal.Delete(NSRSBH,KHZH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.GSKHYH GetModel(string NSRSBH,string KHZH)
		{
			
			return dal.GetModel(NSRSBH,KHZH);
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
		public List<tdps.Model.GSKHYH> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.GSKHYH> DataTableToList(DataTable dt)
		{
			List<tdps.Model.GSKHYH> modelList = new List<tdps.Model.GSKHYH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.GSKHYH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.GSKHYH();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.KHZH=dt.Rows[n]["KHZH"].ToString();
					model.KHYHZL=dt.Rows[n]["KHYHZL"].ToString();
					model.KHYH=dt.Rows[n]["KHYH"].ToString();
					if(dt.Rows[n]["IsDefault"].ToString()!="")
					{
						model.IsDefault=int.Parse(dt.Rows[n]["IsDefault"].ToString());
					}
					model.KHYHMC=dt.Rows[n]["KHYHMC"].ToString();
					model.KHYHZLMC=dt.Rows[n]["KHYHZLMC"].ToString();
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

