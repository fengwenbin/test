using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBZFBLL ��ժҪ˵����
	/// </summary>
	public partial class SBZFBLL
	{
		private readonly tdps.DAL.SBZFDAL dal=new tdps.DAL.SBZFDAL();
		public SBZFBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int FID)
		{
			return dal.Exists(FID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBZF model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.SBZF model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int FID)
		{
			
			dal.Delete(FID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.SBZF GetModel(int FID)
		{
			
			return dal.GetModel(FID);
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.SBZF> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.SBZF> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBZF> modelList = new List<tdps.Model.SBZF>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBZF model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBZF();
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
					model.SBZFFSSJ=dt.Rows[n]["SBZFFSSJ"].ToString();
					model.SBZFCLSJ=dt.Rows[n]["SBZFCLSJ"].ToString();
					model.JYLSH=dt.Rows[n]["JYLSH"].ToString();
					model.DZYZData=dt.Rows[n]["DZYZData"].ToString();
					model.SBWJ=dt.Rows[n]["SBWJ"].ToString();
					model.SBZL=dt.Rows[n]["SBZL"].ToString();
					model.SBSJ=dt.Rows[n]["SBSJ"].ToString();
					if(dt.Rows[n]["SBSE"].ToString()!="")
					{
						model.SBSE=decimal.Parse(dt.Rows[n]["SBSE"].ToString());
					}
					model.TSXX=dt.Rows[n]["TSXX"].ToString();
					model.SBZLMC=dt.Rows[n]["SBZLMC"].ToString();
					if(dt.Rows[n]["SBCS"].ToString()!="")
					{
						model.SBCS=int.Parse(dt.Rows[n]["SBCS"].ToString());
					}
					model.SSQQ=dt.Rows[n]["SSQQ"].ToString();
					model.SSQZ=dt.Rows[n]["SSQZ"].ToString();
					model.FKDM=dt.Rows[n]["FKDM"].ToString();
					model.FKXX=dt.Rows[n]["FKXX"].ToString();
					model.SBZFSJ=dt.Rows[n]["SBZFSJ"].ToString();
					model.MW=dt.Rows[n]["MW"].ToString();
					model.SZ=dt.Rows[n]["SZ"].ToString();
					model.FileName=dt.Rows[n]["FileName"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}


		#endregion  ��Ա����
	}
}

