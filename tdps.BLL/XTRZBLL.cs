using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类XTRZBLL 的摘要说明。
	/// </summary>
	public class XTRZBLL
	{
		private readonly tdps.DAL.XTRZDAL dal=new tdps.DAL.XTRZDAL();
		public XTRZBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int XH)
		{
			return dal.Exists(XH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.XTRZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.XTRZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int XH)
		{
			
			dal.Delete(XH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.XTRZ GetModel(int XH)
		{
			
			return dal.GetModel(XH);
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
		public List<tdps.Model.XTRZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.XTRZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.XTRZ> modelList = new List<tdps.Model.XTRZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.XTRZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.XTRZ();
					if(dt.Rows[n]["XH"].ToString()!="")
					{
						model.XH=int.Parse(dt.Rows[n]["XH"].ToString());
					}
					model.LR=dt.Rows[n]["LR"].ToString();
					model.RQ=dt.Rows[n]["RQ"].ToString();
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

