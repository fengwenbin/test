using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DYMXBLL ��ժҪ˵����
	/// </summary>
	public partial class DYMXBLL
	{
		private readonly tdps.DAL.DYMXDAL dal=new tdps.DAL.DYMXDAL();
		public DYMXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string SPHM,string JKPZXH,string DYSXH)
		{
			return dal.Exists(SPHM,JKPZXH,DYSXH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DYMX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DYMX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string SPHM,string JKPZXH,string DYSXH)
		{
			
			dal.Delete(SPHM,JKPZXH,DYSXH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DYMX GetModel(string SPHM,string JKPZXH,string DYSXH)
		{
			
			return dal.GetModel(SPHM,JKPZXH,DYSXH);
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
		public List<tdps.Model.DYMX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DYMX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DYMX> modelList = new List<tdps.Model.DYMX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DYMX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DYMX();
					model.SPHM=dt.Rows[n]["SPHM"].ToString();
					model.JKPZXH=dt.Rows[n]["JKPZXH"].ToString();
					model.DYSXH=dt.Rows[n]["DYSXH"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
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

