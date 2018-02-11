using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBXMLBLL 的摘要说明。
	/// </summary>
	public partial class SBXMLBLL
	{
		private readonly tdps.DAL.SBXMLDAL dal=new tdps.DAL.SBXMLDAL();
		public SBXMLBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SBXXID,string FileName)
		{
			return dal.Exists(SBXXID,FileName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXML model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBXML model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int SBXXID,string FileName)
		{
			
			dal.Delete(SBXXID,FileName);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.SBXML GetModel(int SBXXID,string FileName)
		{
			
			return dal.GetModel(SBXXID,FileName);
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
		public List<tdps.Model.SBXML> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.SBXML> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBXML> modelList = new List<tdps.Model.SBXML>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBXML model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBXML();
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
					model.FileName=dt.Rows[n]["FileName"].ToString();
					model.SBXMLData=dt.Rows[n]["SBXMLData"].ToString();
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

