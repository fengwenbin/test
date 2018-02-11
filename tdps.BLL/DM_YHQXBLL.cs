using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_YHQXBLL ��ժҪ˵����
	/// </summary>
	public class DM_YHQXBLL
	{
		private readonly tdps.DAL.DM_YHQXDAL dal=new tdps.DAL.DM_YHQXDAL();
		public DM_YHQXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string QXBM)
		{
			return dal.Exists(QXBM);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_YHQX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_YHQX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string QXBM)
		{
			
			dal.Delete(QXBM);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_YHQX GetModel(string QXBM)
		{
			
			return dal.GetModel(QXBM);
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
		public List<tdps.Model.DM_YHQX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_YHQX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_YHQX> modelList = new List<tdps.Model.DM_YHQX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_YHQX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_YHQX();
					model.QXBM=dt.Rows[n]["QXBM"].ToString();
					model.QXMC=dt.Rows[n]["QXMC"].ToString();
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

