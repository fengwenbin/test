using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���NSRXXDSBLL ��ժҪ˵����
	/// </summary>
	public partial class NSRXXDSBLL
	{
		private readonly tdps.DAL.NSRXXDSDAL dal=new tdps.DAL.NSRXXDSDAL();
		public NSRXXDSBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string NSRSBH)
		{
			return dal.Exists(NSRSBH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.NSRXXDS model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.NSRXXDS model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			dal.Delete(NSRSBH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.NSRXXDS GetModel(string NSRSBH)
		{
			
			return dal.GetModel(NSRSBH);
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
		public List<tdps.Model.NSRXXDS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.NSRXXDS> DataTableToList(DataTable dt)
		{
			List<tdps.Model.NSRXXDS> modelList = new List<tdps.Model.NSRXXDS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.NSRXXDS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.NSRXXDS();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.SSHY=dt.Rows[n]["SSHY"].ToString();
					model.SSYH=dt.Rows[n]["SSYH"].ToString();
					model.QYDJZCL=dt.Rows[n]["QYDJZCL"].ToString();
					model.NSLX=dt.Rows[n]["NSLX"].ToString();
					if(dt.Rows[n]["SFTYHSJG"].ToString()!="")
					{
						model.SFTYHSJG=int.Parse(dt.Rows[n]["SFTYHSJG"].ToString());
					}
					model.ZGSWJG=dt.Rows[n]["ZGSWJG"].ToString();
					model.ZGSWJG_MC=dt.Rows[n]["ZGSWJG_MC"].ToString();
					model.NSR_SWJG_DM=dt.Rows[n]["NSR_SWJG_DM"].ToString();
					if(dt.Rows[n]["JKBZ"].ToString()!="")
					{
						model.JKBZ=int.Parse(dt.Rows[n]["JKBZ"].ToString());
					}
					model.XY=dt.Rows[n]["XY"].ToString();
					model.LSGX=dt.Rows[n]["LSGX"].ToString();
					model.NSRBM=dt.Rows[n]["NSRBM"].ToString();
					model.NSRZT=dt.Rows[n]["NSRZT"].ToString();
					model.ZGY=dt.Rows[n]["ZGY"].ToString();
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

