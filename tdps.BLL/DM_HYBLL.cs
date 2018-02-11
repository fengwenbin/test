using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_HYBLL ��ժҪ˵����
	/// </summary>
	public class DM_HYBLL
	{
		private readonly tdps.DAL.DM_HYDAL dal=new tdps.DAL.DM_HYDAL();
		public DM_HYBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string hy_dm)
		{
			return dal.Exists(hy_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_HY model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_HY model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string hy_dm)
		{
			
			dal.Delete(hy_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_HY GetModel(string hy_dm)
		{
			
			return dal.GetModel(hy_dm);
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
		public List<tdps.Model.DM_HY> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_HY> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HY> modelList = new List<tdps.Model.DM_HY>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HY model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HY();
					model.hy_dm=dt.Rows[n]["hy_dm"].ToString();
					model.hy_mc=dt.Rows[n]["hy_mc"].ToString();
					model.hy_jc=dt.Rows[n]["hy_jc"].ToString();
					model.hydl_dm=dt.Rows[n]["hydl_dm"].ToString();
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

