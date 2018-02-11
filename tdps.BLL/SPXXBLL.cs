using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SPXXBLL ��ժҪ˵����
	/// </summary>
	public partial class SPXXBLL
	{
		private readonly tdps.DAL.SPXXDAL dal=new tdps.DAL.SPXXDAL();
		public SPXXBLL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string SPHM)
		{
			return dal.Exists(SPHM);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SPXX model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.SPXX model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string SPHM)
		{
			
			dal.Delete(SPHM);
		}

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete1(string SPHM)
        {

            dal.Delete1(SPHM);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.SPXX GetModel(string SPHM)
		{
			
			return dal.GetModel(SPHM);
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public tdps.Model.SPXX GetModel1(string SPHM)
        {

            return dal.GetModel1(SPHM);
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
		public List<tdps.Model.SPXX> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.SPXX> DataTableToList(DataTable dt)
		{
			List<tdps.Model.SPXX> modelList = new List<tdps.Model.SPXX>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.SPXX model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.SPXX();
					model.SPHM=dt.Rows[n]["SPHM"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.NSRSWJGDM=dt.Rows[n]["NSRSWJGDM"].ToString();
					model.NSRSWJGMC=dt.Rows[n]["NSRSWJGMC"].ToString();
					model.SSSQ_Q=dt.Rows[n]["SSSQ_Q"].ToString();
					model.SSSQ_Z=dt.Rows[n]["SSSQ_Z"].ToString();
					if(dt.Rows[n]["SL"].ToString()!="")
					{
						model.SL=decimal.Parse(dt.Rows[n]["SL"].ToString());
					}
					model.KSSL=dt.Rows[n]["KSSL"].ToString();
					model.JKSJ=dt.Rows[n]["JKSJ"].ToString();
					if(dt.Rows[n]["SJJE"].ToString()!="")
					{
						model.SJJE=decimal.Parse(dt.Rows[n]["SJJE"].ToString());
					}
					model.ZSXMDM=dt.Rows[n]["ZSXMDM"].ToString();
					model.ZSXMMC=dt.Rows[n]["ZSXMMC"].ToString();
					model.ZSPMDM=dt.Rows[n]["ZSPMDM"].ToString();
					model.ZSPMMC=dt.Rows[n]["ZSPMMC"].ToString();
					model.JYLXDM=dt.Rows[n]["JYLXDM"].ToString();
					model.JYLXMC=dt.Rows[n]["JYLXMC"].ToString();
					model.PZZLDM=dt.Rows[n]["PZZLDM"].ToString();
					model.PZZLMC=dt.Rows[n]["PZZLMC"].ToString();
					model.YHZH=dt.Rows[n]["YHZH"].ToString();
					model.BZ=dt.Rows[n]["BZ"].ToString();
					model.WSPZH=dt.Rows[n]["WSPZH"].ToString();
					model.ZSSWJGDM=dt.Rows[n]["ZSSWJGDM"].ToString();
					model.ZSSWJGMC=dt.Rows[n]["ZSSWJGMC"].ToString();
					model.WSZKJSJ=dt.Rows[n]["WSZKJSJ"].ToString();
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

