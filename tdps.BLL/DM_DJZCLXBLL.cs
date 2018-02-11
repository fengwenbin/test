using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_DJZCLXBLL ��ժҪ˵����
	/// </summary>
	public class DM_DJZCLXBLL
	{
		private readonly tdps.DAL.DM_DJZCLXDAL dal=new tdps.DAL.DM_DJZCLXDAL();
		public DM_DJZCLXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string djzclx_dm)
		{
			return dal.Exists(djzclx_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_DJZCLX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_DJZCLX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string djzclx_dm)
		{
			
			dal.Delete(djzclx_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_DJZCLX GetModel(string djzclx_dm)
		{
			
			return dal.GetModel(djzclx_dm);
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
		public List<tdps.Model.DM_DJZCLX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_DJZCLX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_DJZCLX> modelList = new List<tdps.Model.DM_DJZCLX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_DJZCLX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_DJZCLX();
					model.djzclx_dm=dt.Rows[n]["djzclx_dm"].ToString();
					model.djzclx_mc=dt.Rows[n]["djzclx_mc"].ToString();
					model.djzclx_zl_dm=dt.Rows[n]["djzclx_zl_dm"].ToString();
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

