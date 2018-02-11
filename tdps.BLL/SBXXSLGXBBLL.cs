using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBXXSLGXBBLL 的摘要说明。
	/// </summary>
	public partial class SBXXSLGXBBLL
	{
		private readonly tdps.DAL.SBXXSLGXBDAL dal=new tdps.DAL.SBXXSLGXBDAL();
		public SBXXSLGXBBLL()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXXSLGXB model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBXXSLGXB model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(string where, object trans)
		{
			//该表无主键信息，请自定义主键/条件字段
			dal.Delete(where, trans);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SBXXSLGXB GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
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
		public List<tdps.Model.SBXXSLGXB> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.SBXXSLGXB> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBXXSLGXB> modelList = new List<tdps.Model.SBXXSLGXB>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBXXSLGXB model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBXXSLGXB();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
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

