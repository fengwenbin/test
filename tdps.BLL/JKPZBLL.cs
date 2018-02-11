using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���JKPZBLL ��ժҪ˵����
	/// </summary>
	public partial class JKPZBLL
	{
		private readonly tdps.DAL.JKPZDAL dal=new tdps.DAL.JKPZDAL();
		public JKPZBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string JKPZXH)
		{
			return dal.Exists(JKPZXH);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.JKPZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.JKPZ model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string JKPZXH)
		{
			
			dal.Delete(JKPZXH);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.JKPZ GetModel(string JKPZXH)
		{
			
			return dal.GetModel(JKPZXH);
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
		public List<tdps.Model.JKPZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.JKPZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.JKPZ> modelList = new List<tdps.Model.JKPZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.JKPZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.JKPZ();
					model.JKPZXH=dt.Rows[n]["JKPZXH"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.NSRSWJGDM=dt.Rows[n]["NSRSWJGDM"].ToString();
					model.NSRSWJGMC=dt.Rows[n]["NSRSWJGMC"].ToString();
					model.ZSSWJGDM=dt.Rows[n]["ZSSWJGDM"].ToString();
					model.ZSSWJGMC=dt.Rows[n]["ZSSWJGMC"].ToString();
					model.PZDYFS=dt.Rows[n]["PZDYFS"].ToString();
					model.DYSJ=dt.Rows[n]["DYSJ"].ToString();
					if(dt.Rows[n]["HJJE"].ToString()!="")
					{
						model.HJJE=decimal.Parse(dt.Rows[n]["HJJE"].ToString());
					}
					model.FWM=dt.Rows[n]["FWM"].ToString();
					model.DZYZDATA=dt.Rows[n]["DZYZDATA"].ToString();
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

