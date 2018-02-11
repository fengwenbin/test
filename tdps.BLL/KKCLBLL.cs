using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���KKCLBLL ��ժҪ˵����
	/// </summary>
	public partial class KKCLBLL
	{
		private readonly tdps.DAL.KKCLDAL dal=new tdps.DAL.KKCLDAL();
		public KKCLBLL()
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
		public void Add(tdps.Model.KKCL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.KKCL model)
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
        /// ɾ��һ������
        /// </summary>
        public void Delete(int FID,object trans)
        {

            dal.Delete(FID, trans);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.KKCL GetModel(int FID)
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
		public List<tdps.Model.KKCL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.KKCL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.KKCL> modelList = new List<tdps.Model.KKCL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.KKCL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.KKCL();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					if(dt.Rows[n]["SBXXID"].ToString()!="")
					{
						model.SBXXID=int.Parse(dt.Rows[n]["SBXXID"].ToString());
					}
					model.HZLX=dt.Rows[n]["HZLX"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.SWJGMC=dt.Rows[n]["SWJGMC"].ToString();
					model.YHDM=dt.Rows[n]["YHDM"].ToString();
					model.YHZH=dt.Rows[n]["YHZH"].ToString();
					model.KKFSSJ=dt.Rows[n]["KKFSSJ"].ToString();
					model.KKCLSJ=dt.Rows[n]["KKCLSJ"].ToString();
					model.JYLSH=dt.Rows[n]["JYLSH"].ToString();
					model.DZYZData=dt.Rows[n]["DZYZData"].ToString();
					model.SBWJ=dt.Rows[n]["SBWJ"].ToString();
					model.SBZL=dt.Rows[n]["SBZL"].ToString();
					model.TSXX=dt.Rows[n]["TSXX"].ToString();
					model.ZT=dt.Rows[n]["ZT"].ToString();
					if(dt.Rows[n]["ZJE"].ToString()!="")
					{
						model.ZJE=decimal.Parse(dt.Rows[n]["ZJE"].ToString());
					}
					if(dt.Rows[n]["KKJE"].ToString()!="")
					{
						model.KKJE=decimal.Parse(dt.Rows[n]["KKJE"].ToString());
					}
					if(dt.Rows[n]["WJJE"].ToString()!="")
					{
						model.WJJE=decimal.Parse(dt.Rows[n]["WJJE"].ToString());
					}
					model.SBZLMC=dt.Rows[n]["SBZLMC"].ToString();
					if(dt.Rows[n]["SBCS"].ToString()!="")
					{
						model.SBCS=int.Parse(dt.Rows[n]["SBCS"].ToString());
					}
					model.SSQQ=dt.Rows[n]["SSQQ"].ToString();
					model.SSQZ=dt.Rows[n]["SSQZ"].ToString();
					model.KKSJ=dt.Rows[n]["KKSJ"].ToString();
					model.SBFKYZM=dt.Rows[n]["SBFKYZM"].ToString();
					model.FKDM=dt.Rows[n]["FKDM"].ToString();
					model.FKXX=dt.Rows[n]["FKXX"].ToString();
					model.SZ=dt.Rows[n]["SZ"].ToString();
					model.FileName=dt.Rows[n]["FileName"].ToString();
					model.MW=dt.Rows[n]["MW"].ToString();
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

