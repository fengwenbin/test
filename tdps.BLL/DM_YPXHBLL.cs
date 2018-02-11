using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_YPXHBLL ��ժҪ˵����
	/// </summary>
	public class DM_YPXHBLL
	{
		private readonly tdps.DAL.DM_YPXHDAL dal=new tdps.DAL.DM_YPXHDAL();
		public DM_YPXHBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string ypxh_dm)
		{
			return dal.Exists(ypxh_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_YPXH model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_YPXH model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string ypxh_dm)
		{
			
			dal.Delete(ypxh_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_YPXH GetModel(string ypxh_dm)
		{
			
			return dal.GetModel(ypxh_dm);
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
		public List<tdps.Model.DM_YPXH> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_YPXH> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_YPXH> modelList = new List<tdps.Model.DM_YPXH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_YPXH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_YPXH();
					model.ypxh_dm=dt.Rows[n]["ypxh_dm"].ToString();
					model.ypxh_mc=dt.Rows[n]["ypxh_mc"].ToString();
					model.bz=dt.Rows[n]["bz"].ToString();
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

