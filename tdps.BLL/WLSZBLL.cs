using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���WLSZBLL ��ժҪ˵����
	/// </summary>
	public class WLSZBLL
	{
		private readonly tdps.DAL.WLSZDAL dal=new tdps.DAL.WLSZDAL();
		public WLSZBLL()
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
		public void Add(tdps.Model.WLSZ model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.WLSZ model)
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
		public tdps.Model.WLSZ GetModel(int FID)
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
		public List<tdps.Model.WLSZ> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.WLSZ> DataTableToList(DataTable dt)
		{
			List<tdps.Model.WLSZ> modelList = new List<tdps.Model.WLSZ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.WLSZ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.WLSZ();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.FWQIP=dt.Rows[n]["FWQIP"].ToString();
					if(dt.Rows[n]["FWQDK"].ToString()!="")
					{
						model.FWQDK=int.Parse(dt.Rows[n]["FWQDK"].ToString());
					}
					if(dt.Rows[n]["SFMR"].ToString()!="")
					{
						model.SFMR=int.Parse(dt.Rows[n]["SFMR"].ToString());
					}
					if(dt.Rows[n]["SFQYNQLJ"].ToString()!="")
					{
						model.SFQYNQLJ=int.Parse(dt.Rows[n]["SFQYNQLJ"].ToString());
					}
                    model.GXSJ = dt.Rows[n]["GXSJ"].ToString();
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

        #region �Զ����Ա����
        /// <summary>
        /// ȡ��Ĭ��
        /// </summary>
        /// <param name="szfl">˰�ַ���</param>
        /// <returns></returns>
        public void CancelSFMR(int szfl)
        {
            dal.CancelSFMR(szfl);
        }
        #endregion  ��Ա����
	}
}

