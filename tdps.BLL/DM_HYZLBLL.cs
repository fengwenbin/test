using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_HYZLBLL ��ժҪ˵����
	/// </summary>
	public class DM_HYZLBLL
	{
		private readonly tdps.DAL.DM_HYZLDAL dal=new tdps.DAL.DM_HYZLDAL();
		public DM_HYZLBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string hyzl_dm)
		{
			return dal.Exists(hyzl_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_HYZL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_HYZL model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string hyzl_dm)
		{
			
			dal.Delete(hyzl_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_HYZL GetModel(string hyzl_dm)
		{
			
			return dal.GetModel(hyzl_dm);
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
		public List<tdps.Model.DM_HYZL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_HYZL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYZL> modelList = new List<tdps.Model.DM_HYZL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYZL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYZL();
					model.hyzl_dm=dt.Rows[n]["hyzl_dm"].ToString();
					model.hyzl_mc=dt.Rows[n]["hyzl_mc"].ToString();
					model.hyzl_jc=dt.Rows[n]["hyzl_jc"].ToString();
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

