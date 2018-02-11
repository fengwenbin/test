using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBXXSLGXBBLL ��ժҪ˵����
	/// </summary>
	public partial class SBXXSLGXBBLL
	{
		private readonly tdps.DAL.SBXXSLGXBDAL dal=new tdps.DAL.SBXXSLGXBDAL();
		public SBXXSLGXBBLL()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBXXSLGXB model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.SBXXSLGXB model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
        public void Delete(string where, object trans)
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete(where, trans);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.SBXXSLGXB GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
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
		public List<tdps.Model.SBXXSLGXB> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.SBXXSLGXB> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBXXSLGXB> modelList = new List<tdps.Model.SBXXSLGXB>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBXXSLGXB model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBXXSLGXB();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
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

