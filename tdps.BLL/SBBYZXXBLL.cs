using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBBYZXXBLL 的摘要说明。
	/// </summary>
	public partial class SBBYZXXBLL
	{
		private readonly tdps.DAL.SBBYZXXDAL dal=new tdps.DAL.SBBYZXXDAL();
		public SBBYZXXBLL()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBBYZXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBBYZXX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SBBYZXX GetModel()
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
		public List<tdps.Model.SBBYZXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.SBBYZXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBBYZXX> modelList = new List<tdps.Model.SBBYZXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBBYZXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBBYZXX();
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
					if(dt.Rows[n]["SheetInx"].ToString()!="")
					{
						model.SheetInx=int.Parse(dt.Rows[n]["SheetInx"].ToString());
					}
					if(dt.Rows[n]["Col"].ToString()!="")
					{
						model.Col=int.Parse(dt.Rows[n]["Col"].ToString());
					}
					if(dt.Rows[n]["Row"].ToString()!="")
					{
						model.Row=int.Parse(dt.Rows[n]["Row"].ToString());
					}
					model.ErrorContent=dt.Rows[n]["ErrorContent"].ToString();
					if(dt.Rows[n]["Type"].ToString()!="")
					{
						model.Type=int.Parse(dt.Rows[n]["Type"].ToString());
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

