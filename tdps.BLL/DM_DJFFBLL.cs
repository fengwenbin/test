using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DM_DJFFBLL ��ժҪ˵����
	/// </summary>
	public class DM_DJFFBLL
	{
		private readonly tdps.DAL.DM_DJFFDAL dal=new tdps.DAL.DM_DJFFDAL();
		public DM_DJFFBLL()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DM_DJFF model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DM_DJFF model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete();
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DM_DJFF GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
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
		public List<tdps.Model.DM_DJFF> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DM_DJFF> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DM_DJFF> modelList = new List<tdps.Model.DM_DJFF>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DM_DJFF model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DM_DJFF();
					model.djff_dm=dt.Rows[n]["djff_dm"].ToString();
					model.djff_mc=dt.Rows[n]["djff_mc"].ToString();
					model.djff_jc=dt.Rows[n]["djff_jc"].ToString();
					model.yxbz=dt.Rows[n]["yxbz"].ToString();
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

