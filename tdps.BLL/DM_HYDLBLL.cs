using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_HYDLBLL ��ժҪ˵����
	/// </summary>
	public class DM_HYDLBLL
	{
		private readonly tdps.DAL.DM_HYDLDAL dal=new tdps.DAL.DM_HYDLDAL();
		public DM_HYDLBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string hydl_dm)
		{
			return dal.Exists(hydl_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_HYDL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_HYDL model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string hydl_dm)
		{
			
			dal.Delete(hydl_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_HYDL GetModel(string hydl_dm)
		{
			
			return dal.GetModel(hydl_dm);
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
		public List<tdps.Model.DM_HYDL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_HYDL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYDL> modelList = new List<tdps.Model.DM_HYDL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYDL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYDL();
					model.hydl_dm=dt.Rows[n]["hydl_dm"].ToString();
					model.hydl_mc=dt.Rows[n]["hydl_mc"].ToString();
					model.hydl_jc=dt.Rows[n]["hydl_jc"].ToString();
					model.hyml_dm=dt.Rows[n]["hyml_dm"].ToString();
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

