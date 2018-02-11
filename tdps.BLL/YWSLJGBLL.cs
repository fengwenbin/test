using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���YWSLJGBLL ��ժҪ˵����
	/// </summary>
	public partial class YWSLJGBLL
	{
		private readonly tdps.DAL.YWSLJGDAL dal=new tdps.DAL.YWSLJGDAL();
		public YWSLJGBLL()
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
		public void Add(tdps.Model.YWSLJG model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.YWSLJG model)
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
        /// ɾ����������
        /// </summary>
        public void Delete(string where,object tran)
        {

            dal.Delete(where, tran);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.YWSLJG GetModel(int FID)
		{
			
			return dal.GetModel(FID);
		}
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public tdps.Model.YWSLJG GetModel(string whereSql)
        {

            return dal.GetModel(whereSql);
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
		public List<tdps.Model.YWSLJG> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.YWSLJG> DataTableToList(DataTable dt)
		{
			List<tdps.Model.YWSLJG> modelList = new List<tdps.Model.YWSLJG>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.YWSLJG model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.YWSLJG();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.FileName=dt.Rows[n]["FileName"].ToString();
					model.returnCode=dt.Rows[n]["returnCode"].ToString();
					model.returnMessage=dt.Rows[n]["returnMessage"].ToString();
					model.businessID=dt.Rows[n]["businessID"].ToString();
					model.jmm=dt.Rows[n]["jmm"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.createTime=dt.Rows[n]["createTime"].ToString();
					model.SWJGDM=dt.Rows[n]["SWJGDM"].ToString();
					model.JYSLXX=dt.Rows[n]["JYSLXX"].ToString();
					model.swjgMc=dt.Rows[n]["swjgMc"].ToString();
					model.DZYZData=dt.Rows[n]["DZYZData"].ToString();
					model.MW=dt.Rows[n]["MW"].ToString();
					model.SLLX=dt.Rows[n]["SLLX"].ToString();
					model.KHDFSSJ=dt.Rows[n]["KHDFSSJ"].ToString();
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

