using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_BZBLL ��ժҪ˵����
	/// </summary>
	public class DM_BZBLL
	{
		private readonly tdps.DAL.DM_BZDAL dal=new tdps.DAL.DM_BZDAL();
		public DM_BZBLL()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_BZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_BZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete();
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_BZ GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
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
		public List<tdps.Model.DM_BZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_BZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_BZ> modelList = new List<tdps.Model.DM_BZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_BZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_BZ();
					model.bz_dm=dt.Rows[n]["bz_dm"].ToString();
					model.bz_mc=dt.Rows[n]["bz_mc"].ToString();
					if(dt.Rows[n]["bz_dw"].ToString()!="")
					{
						model.bz_dw=decimal.Parse(dt.Rows[n]["bz_dw"].ToString());
					}
					if(dt.Rows[n]["bz_hl"].ToString()!="")
					{
						model.bz_hl=decimal.Parse(dt.Rows[n]["bz_hl"].ToString());
					}
					model.xybz=dt.Rows[n]["xybz"].ToString();
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

