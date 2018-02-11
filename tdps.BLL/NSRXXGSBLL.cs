using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���NSRXXGSBLL ��ժҪ˵����
	/// </summary>
	public partial class NSRXXGSBLL
	{
		private readonly tdps.DAL.NSRXXGSDAL dal=new tdps.DAL.NSRXXGSDAL();
		public NSRXXGSBLL()
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
		public void Add(tdps.Model.NSRXXGS model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.NSRXXGS model)
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
		public tdps.Model.NSRXXGS GetModel(string NSRSBH)
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
		public List<tdps.Model.NSRXXGS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.NSRXXGS> DataTableToList(DataTable dt)
		{
			List<tdps.Model.NSRXXGS> modelList = new List<tdps.Model.NSRXXGS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.NSRXXGS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.NSRXXGS();
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
                    model.NSRZT_MC = dt.Rows[n]["NSRZT_MC"].ToString();
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

