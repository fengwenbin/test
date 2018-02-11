using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
using System.Text;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_GJBLL ��ժҪ˵����
	/// </summary>
	public class DM_GJBLL
	{
		private readonly tdps.DAL.DM_GJDAL dal=new tdps.DAL.DM_GJDAL();
		public DM_GJBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string gj_dm)
		{
			return dal.Exists(gj_dm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_GJ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_GJ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string gj_dm)
		{
			
			dal.Delete(gj_dm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_GJ GetModel(string gj_dm)
		{
			
			return dal.GetModel(gj_dm);
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
		public List<tdps.Model.DM_GJ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_GJ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_GJ> modelList = new List<tdps.Model.DM_GJ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_GJ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_GJ();
					model.gj_dm=dt.Rows[n]["gj_dm"].ToString();
					model.gj_mc=dt.Rows[n]["gj_mc"].ToString();
					model.gj_jc=dt.Rows[n]["gj_jc"].ToString();
					model.xybz=dt.Rows[n]["xybz"].ToString();
					model.gj_mc_yw=dt.Rows[n]["gj_mc_yw"].ToString();
					model.gj_jc_yw=dt.Rows[n]["gj_jc_yw"].ToString();
					model.gj_jc_yw2=dt.Rows[n]["gj_jc_yw2"].ToString();
					model.gj_jc_yw3=dt.Rows[n]["gj_jc_yw3"].ToString();
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


        public StringBuilder GetDroplist()
        {
            return dal.GetDroplistGj();
        }

        public StringBuilder GetDroplist2()
        {
            return dal.GetDroplistGj2();
        }

		#endregion  ��Ա����
	}
}

