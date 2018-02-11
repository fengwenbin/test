using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类DLFWQSZBLL 的摘要说明。
	/// </summary>
	public class DLFWQSZBLL
	{
		private readonly tdps.DAL.DLFWQSZDAL dal=new tdps.DAL.DLFWQSZDAL();
		public DLFWQSZBLL()
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
		public void Add(tdps.Model.DLFWQSZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.DLFWQSZ model)
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
		public tdps.Model.DLFWQSZ GetModel(int FID)
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
		public List<tdps.Model.DLFWQSZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.DLFWQSZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DLFWQSZ> modelList = new List<tdps.Model.DLFWQSZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DLFWQSZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DLFWQSZ();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.DLLX=dt.Rows[n]["DLLX"].ToString();
					model.DLDZ=dt.Rows[n]["DLDZ"].ToString();
					if(dt.Rows[n]["DLDK"].ToString()!="")
					{
						model.DLDK=int.Parse(dt.Rows[n]["DLDK"].ToString());
					}
					if(dt.Rows[n]["YHYZ"].ToString()!="")
					{
						model.YHYZ=int.Parse(dt.Rows[n]["YHYZ"].ToString());
					}
					model.YHM=dt.Rows[n]["YHM"].ToString();
					model.MM=dt.Rows[n]["MM"].ToString();
					model.GXSJ=dt.Rows[n]["GXSJ"].ToString();
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

