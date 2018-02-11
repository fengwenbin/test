using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBCLBLL 的摘要说明。
	/// </summary>
	public partial class SBCLBLL
	{
		private readonly tdps.DAL.SBCLDAL dal=new tdps.DAL.SBCLDAL();
		public SBCLBLL()
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
		public void Add(tdps.Model.SBCL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBCL model)
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
		public tdps.Model.SBCL GetModel(int FID)
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
		public List<tdps.Model.SBCL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.SBCL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBCL> modelList = new List<tdps.Model.SBCL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBCL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBCL();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
					model.HZLX=dt.Rows[n]["HZLX"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.SWJGMC=dt.Rows[n]["SWJGMC"].ToString();
					model.SBFSSJ=dt.Rows[n]["SBFSSJ"].ToString();
					model.SBCLSJ=dt.Rows[n]["SBCLSJ"].ToString();
					model.JYLSH=dt.Rows[n]["JYLSH"].ToString();
					model.JMM=dt.Rows[n]["JMM"].ToString();
					model.DZYZData=dt.Rows[n]["DZYZData"].ToString();
					model.SBWJ=dt.Rows[n]["SBWJ"].ToString();
					model.SBBZLMC=dt.Rows[n]["SBBZLMC"].ToString();
					model.SBZL=dt.Rows[n]["SBZL"].ToString();
					if(dt.Rows[n]["SBSE"].ToString()!="")
					{
						model.SBSE=decimal.Parse(dt.Rows[n]["SBSE"].ToString());
					}
					model.TSXX=dt.Rows[n]["TSXX"].ToString();
					if(dt.Rows[n]["SBCS"].ToString()!="")
					{
						model.SBCS=int.Parse(dt.Rows[n]["SBCS"].ToString());
					}
					model.SSQQ=dt.Rows[n]["SSQQ"].ToString();
					model.SSQZ=dt.Rows[n]["SSQZ"].ToString();
					model.MW=dt.Rows[n]["MW"].ToString();
					model.SZ=dt.Rows[n]["SZ"].ToString();
					model.FKDM=dt.Rows[n]["FKDM"].ToString();
					model.FKXX=dt.Rows[n]["FKXX"].ToString();
					model.FKSJ=dt.Rows[n]["FKSJ"].ToString();
					model.FileName=dt.Rows[n]["FileName"].ToString();
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

