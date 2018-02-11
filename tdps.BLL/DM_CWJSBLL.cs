using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_CWJSBLL ��ժҪ˵����
	/// </summary>
	public class DM_CWJSBLL
	{
		private readonly tdps.DAL.DM_CWJSDAL dal=new tdps.DAL.DM_CWJSDAL();
		public DM_CWJSBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string CWJSBM)
		{
			return dal.Exists(CWJSBM);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_CWJS model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_CWJS model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string CWJSBM)
		{
			
			dal.Delete(CWJSBM);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_CWJS GetModel(string CWJSBM)
		{
			
			return dal.GetModel(CWJSBM);
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
		public List<tdps.Model.DM_CWJS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_CWJS> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_CWJS> modelList = new List<tdps.Model.DM_CWJS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_CWJS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_CWJS();
					model.CWJSBM=dt.Rows[n]["CWJSBM"].ToString();
					model.CWJSMC=dt.Rows[n]["CWJSMC"].ToString();
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

