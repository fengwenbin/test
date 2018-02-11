using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���XTSZBLL ��ժҪ˵����
	/// </summary>
	public partial class XTSZBLL
	{
		private readonly tdps.DAL.XTSZDAL dal=new tdps.DAL.XTSZDAL();
		public XTSZBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string XTBBH)
		{
			return dal.Exists(XTBBH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.XTSZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.XTSZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string XTBBH)
		{
			
			dal.Delete(XTBBH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.XTSZ GetModel(string XTBBH)
		{
			
			return dal.GetModel(XTBBH);
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
		public List<tdps.Model.XTSZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.XTSZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.XTSZ> modelList = new List<tdps.Model.XTSZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.XTSZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.XTSZ();
					model.XTBBH=dt.Rows[n]["XTBBH"].ToString();
					model.GXSJ=dt.Rows[n]["GXSJ"].ToString();
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

