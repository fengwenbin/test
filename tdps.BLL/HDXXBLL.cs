using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���HDXXBLL ��ժҪ˵����
	/// </summary>
	public partial class HDXXBLL
	{
		private readonly tdps.DAL.HDXXDAL dal=new tdps.DAL.HDXXDAL();
		public HDXXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string NSRSBH)
		{
			return dal.Exists(NSRSBH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.HDXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.HDXX model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// ���º˶���Ϣ�ĸ���ʱ��
        /// </summary>
        public void UpdateGXSJ(tdps.Model.HDXX model)
        {
            dal.UpdateGXSJ(model);
        }

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string NSRSBH)
		{
			
			dal.Delete(NSRSBH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.HDXX GetModel(string NSRSBH)
		{
			
			return dal.GetModel(NSRSBH);
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
		public List<tdps.Model.HDXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.HDXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.HDXX> modelList = new List<tdps.Model.HDXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.HDXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.HDXX();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.FileName=dt.Rows[n]["FileName"].ToString();
					model.HDXXXML=dt.Rows[n]["HDXXXML"].ToString();
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

