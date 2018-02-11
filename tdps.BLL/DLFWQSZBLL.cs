using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DLFWQSZBLL ��ժҪ˵����
	/// </summary>
	public class DLFWQSZBLL
	{
		private readonly tdps.DAL.DLFWQSZDAL dal=new tdps.DAL.DLFWQSZDAL();
		public DLFWQSZBLL()
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
		public void Add(tdps.Model.DLFWQSZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.DLFWQSZ model)
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
		public tdps.Model.DLFWQSZ GetModel(int FID)
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
		public List<tdps.Model.DLFWQSZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.DLFWQSZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.DLFWQSZ> modelList = new List<tdps.Model.DLFWQSZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.DLFWQSZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.DLFWQSZ();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.DLLX=dt.Rows[n]["DLLX"].ToString();
					model.DLDZ=dt.Rows[n]["DLDZ"].ToString();
					if(dt.Rows[n]["DLDK"].ToString()!="")
					{
						model.DLDK=int.Parse(dt.Rows[n]["DLDK"].ToString());
					}
					if(dt.Rows[n]["YHYZ"].ToString()!="")
					{
						model.YHYZ=int.Parse(dt.Rows[n]["YHYZ"].ToString());
					}
					model.YHM=dt.Rows[n]["YHM"].ToString();
					model.MM=dt.Rows[n]["MM"].ToString();
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

