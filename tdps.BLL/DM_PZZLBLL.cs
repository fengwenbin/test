using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_PZZLBLL ��ժҪ˵����
	/// </summary>
	public class DM_PZZLBLL
	{
		private readonly tdps.DAL.DM_PZZLDAL dal=new tdps.DAL.DM_PZZLDAL();
		public DM_PZZLBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string pzzl_dm)
		{
			return dal.Exists(pzzl_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_PZZL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_PZZL model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string pzzl_dm)
		{
			
			dal.Delete(pzzl_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_PZZL GetModel(string pzzl_dm)
		{
			
			return dal.GetModel(pzzl_dm);
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
		public List<tdps.Model.DM_PZZL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_PZZL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_PZZL> modelList = new List<tdps.Model.DM_PZZL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_PZZL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_PZZL();
					model.pzzl_dm=dt.Rows[n]["pzzl_dm"].ToString();
					model.pzzl_mc=dt.Rows[n]["pzzl_mc"].ToString();
					model.swws_dm=dt.Rows[n]["swws_dm"].ToString();
					model.yspz_dm=dt.Rows[n]["yspz_dm"].ToString();
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

