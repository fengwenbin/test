using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���TZGGBLL ��ժҪ˵����
	/// </summary>
	public class TZGGBLL
	{
		private readonly tdps.DAL.TZGGDAL dal=new tdps.DAL.TZGGDAL();
		public TZGGBLL()
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
		public void Add(tdps.Model.TZGG model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.TZGG model)
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
		public tdps.Model.TZGG GetModel(int FID)
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
		public List<tdps.Model.TZGG> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.TZGG> DataTableToList(DataTable dt)
		{
			List<tdps.Model.TZGG> modelList = new List<tdps.Model.TZGG>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.TZGG model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.TZGG();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.GGBT=dt.Rows[n]["GGBT"].ToString();
					model.FSJG=dt.Rows[n]["FSJG"].ToString();
					model.FSRQ=dt.Rows[n]["FSRQ"].ToString();
					model.YDYQ=dt.Rows[n]["YDYQ"].ToString();
					model.ZT=dt.Rows[n]["ZT"].ToString();
					model.GGLR=dt.Rows[n]["GGLR"].ToString();
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

