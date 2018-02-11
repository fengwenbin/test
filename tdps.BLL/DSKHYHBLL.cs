using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DSKHYHBLL ��ժҪ˵����
	/// </summary>
	public partial class DSKHYHBLL
	{
		private readonly tdps.DAL.DSKHYHDAL dal=new tdps.DAL.DSKHYHDAL();
		public DSKHYHBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string KHZH,string NSRSBH)
		{
			return dal.Exists(KHZH,NSRSBH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.DSKHYH model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DSKHYH model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string KHZH,string NSRSBH)
		{
			
			dal.Delete(KHZH,NSRSBH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.DSKHYH GetModel(string KHZH,string NSRSBH)
		{
			
			return dal.GetModel(KHZH,NSRSBH);
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
		public List<tdps.Model.DSKHYH> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DSKHYH> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DSKHYH> modelList = new List<tdps.Model.DSKHYH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DSKHYH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DSKHYH();
					model.KHZH=dt.Rows[n]["KHZH"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.KHYHZL=dt.Rows[n]["KHYHZL"].ToString();
					model.KHYH=dt.Rows[n]["KHYH"].ToString();
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

