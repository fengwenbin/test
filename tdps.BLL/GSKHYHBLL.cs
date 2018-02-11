using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���GSKHYHBLL ��ժҪ˵����
	/// </summary>
	public partial class GSKHYHBLL
	{
		private readonly tdps.DAL.GSKHYHDAL dal=new tdps.DAL.GSKHYHDAL();
		public GSKHYHBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string NSRSBH,string KHZH)
		{
			return dal.Exists(NSRSBH,KHZH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.GSKHYH model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.GSKHYH model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string NSRSBH,string KHZH)
		{
			
			dal.Delete(NSRSBH,KHZH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.GSKHYH GetModel(string NSRSBH,string KHZH)
		{
			
			return dal.GetModel(NSRSBH,KHZH);
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
		public List<tdps.Model.GSKHYH> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.GSKHYH> DataTableToList(DataTable dt)
		{
			List<tdps.Model.GSKHYH> modelList = new List<tdps.Model.GSKHYH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.GSKHYH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.GSKHYH();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.KHZH=dt.Rows[n]["KHZH"].ToString();
					model.KHYHZL=dt.Rows[n]["KHYHZL"].ToString();
					model.KHYH=dt.Rows[n]["KHYH"].ToString();
					if(dt.Rows[n]["IsDefault"].ToString()!="")
					{
						model.IsDefault=int.Parse(dt.Rows[n]["IsDefault"].ToString());
					}
					model.KHYHMC=dt.Rows[n]["KHYHMC"].ToString();
					model.KHYHZLMC=dt.Rows[n]["KHYHZLMC"].ToString();
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

