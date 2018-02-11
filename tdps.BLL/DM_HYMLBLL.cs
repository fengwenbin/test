using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_HYMLBLL ��ժҪ˵����
	/// </summary>
	public class DM_HYMLBLL
	{
		private readonly tdps.DAL.DM_HYMLDAL dal=new tdps.DAL.DM_HYMLDAL();
		public DM_HYMLBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string hyml_dm)
		{
			return dal.Exists(hyml_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_HYML model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_HYML model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string hyml_dm)
		{
			
			dal.Delete(hyml_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_HYML GetModel(string hyml_dm)
		{
			
			return dal.GetModel(hyml_dm);
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
		public List<tdps.Model.DM_HYML> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_HYML> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYML> modelList = new List<tdps.Model.DM_HYML>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYML model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYML();
					model.hyml_dm=dt.Rows[n]["hyml_dm"].ToString();
					model.hyml_mc=dt.Rows[n]["hyml_mc"].ToString();
					model.hyml_jc=dt.Rows[n]["hyml_jc"].ToString();
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

