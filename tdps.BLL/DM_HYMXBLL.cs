using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_HYMXBLL ��ժҪ˵����
	/// </summary>
	public class DM_HYMXBLL
	{
		private readonly tdps.DAL.DM_HYMXDAL dal=new tdps.DAL.DM_HYMXDAL();
		public DM_HYMXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string hymx_dm)
		{
			return dal.Exists(hymx_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_HYMX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_HYMX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string hymx_dm)
		{
			
			dal.Delete(hymx_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_HYMX GetModel(string hymx_dm)
		{
			
			return dal.GetModel(hymx_dm);
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
		public List<tdps.Model.DM_HYMX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_HYMX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_HYMX> modelList = new List<tdps.Model.DM_HYMX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_HYMX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_HYMX();
					model.hymx_dm=dt.Rows[n]["hymx_dm"].ToString();
					model.hymx_mc=dt.Rows[n]["hymx_mc"].ToString();
					model.hymx_jc=dt.Rows[n]["hymx_jc"].ToString();
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

