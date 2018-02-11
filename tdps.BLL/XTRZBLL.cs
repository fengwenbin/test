using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���XTRZBLL ��ժҪ˵����
	/// </summary>
	public class XTRZBLL
	{
		private readonly tdps.DAL.XTRZDAL dal=new tdps.DAL.XTRZDAL();
		public XTRZBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int XH)
		{
			return dal.Exists(XH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.XTRZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.XTRZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int XH)
		{
			
			dal.Delete(XH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.XTRZ GetModel(int XH)
		{
			
			return dal.GetModel(XH);
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
		public List<tdps.Model.XTRZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.XTRZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.XTRZ> modelList = new List<tdps.Model.XTRZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.XTRZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.XTRZ();
					if(dt.Rows[n]["XH"].ToString()!="")
					{
						model.XH=int.Parse(dt.Rows[n]["XH"].ToString());
					}
					model.LR=dt.Rows[n]["LR"].ToString();
					model.RQ=dt.Rows[n]["RQ"].ToString();
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

