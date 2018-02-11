using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���XTXXBLL ��ժҪ˵����
	/// </summary>
	public class XTXXBLL
	{
		private readonly tdps.DAL.XTXXDAL dal=new tdps.DAL.XTXXDAL();
		public XTXXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int FID)
		{
			return dal.Exists(FID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.XTXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.XTXX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int FID)
		{
			
			dal.Delete(FID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.XTXX GetModel(int FID)
		{
			
			return dal.GetModel(FID);
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
		public List<tdps.Model.XTXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.XTXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.XTXX> modelList = new List<tdps.Model.XTXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.XTXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.XTXX();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.FSRQ=dt.Rows[n]["FSRQ"].ToString();
					model.ZT=dt.Rows[n]["ZT"].ToString();
					model.LR=dt.Rows[n]["LR"].ToString();
					model.XXLX=dt.Rows[n]["XXLX"].ToString();
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

