using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���ClientVersionBLL ��ժҪ˵����
	/// </summary>
	public class ClientVersionBLL
	{
		private readonly tdps.DAL.ClientVersionDAL dal=new tdps.DAL.ClientVersionDAL();
		public ClientVersionBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.ClientVersion model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.ClientVersion model)
		{
			dal.Update(model);
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
		public tdps.Model.ClientVersion GetModel(string NSRSBH)
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
		public List<tdps.Model.ClientVersion> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.ClientVersion> DataTableToList(DataTable dt)
		{
			List<tdps.Model.ClientVersion> modelList = new List<tdps.Model.ClientVersion>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.ClientVersion model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.ClientVersion();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.Version=dt.Rows[n]["Version"].ToString();
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

