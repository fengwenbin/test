using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBBYZXXBLL ��ժҪ˵����
	/// </summary>
	public partial class SBBYZXXBLL
	{
		private readonly tdps.DAL.SBBYZXXDAL dal=new tdps.DAL.SBBYZXXDAL();
		public SBBYZXXBLL()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBBYZXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.SBBYZXX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete();
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.SBBYZXX GetModel()
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
		public List<tdps.Model.SBBYZXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.SBBYZXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SBBYZXX> modelList = new List<tdps.Model.SBBYZXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SBBYZXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SBBYZXX();
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
					if(dt.Rows[n]["SheetInx"].ToString()!="")
					{
						model.SheetInx=int.Parse(dt.Rows[n]["SheetInx"].ToString());
					}
					if(dt.Rows[n]["Col"].ToString()!="")
					{
						model.Col=int.Parse(dt.Rows[n]["Col"].ToString());
					}
					if(dt.Rows[n]["Row"].ToString()!="")
					{
						model.Row=int.Parse(dt.Rows[n]["Row"].ToString());
					}
					model.ErrorContent=dt.Rows[n]["ErrorContent"].ToString();
					if(dt.Rows[n]["Type"].ToString()!="")
					{
						model.Type=int.Parse(dt.Rows[n]["Type"].ToString());
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

