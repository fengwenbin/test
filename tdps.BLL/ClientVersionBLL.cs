using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类ClientVersionBLL 的摘要说明。
	/// </summary>
	public class ClientVersionBLL
	{
		private readonly tdps.DAL.ClientVersionDAL dal=new tdps.DAL.ClientVersionDAL();
		public ClientVersionBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.ClientVersion model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.ClientVersion model)
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
		public tdps.Model.ClientVersion GetModel(string NSRSBH)
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
		public List<tdps.Model.ClientVersion> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.ClientVersion> DataTableToList(DataTable dt)
		{
			List<tdps.Model.ClientVersion> modelList = new List<tdps.Model.ClientVersion>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.ClientVersion model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.ClientVersion();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.Version=dt.Rows[n]["Version"].ToString();
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

