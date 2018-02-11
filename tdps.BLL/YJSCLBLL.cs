using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���YJSCLBLL ��ժҪ˵����
	/// </summary>
	public partial class YJSCLBLL
	{
		private readonly tdps.DAL.YJSCLDAL dal=new tdps.DAL.YJSCLDAL();
		public YJSCLBLL()
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
		public void Add(tdps.Model.YJSCL model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.YJSCL model)
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
		public tdps.Model.YJSCL GetModel(int FID)
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
		public List<tdps.Model.YJSCL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<tdps.Model.YJSCL> DataTableToList(DataTable dt)
		{
			List<tdps.Model.YJSCL> modelList = new List<tdps.Model.YJSCL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.YJSCL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.YJSCL();
					if(dt.Rows[n]["FID"].ToString()!="")
					{
						model.FID=int.Parse(dt.Rows[n]["FID"].ToString());
					}
					model.HZLX=dt.Rows[n]["HZLX"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.SWJGMC=dt.Rows[n]["SWJGMC"].ToString();
					model.YHDM=dt.Rows[n]["YHDM"].ToString();
					model.YHZH=dt.Rows[n]["YHZH"].ToString();
					model.YJFSSJ=dt.Rows[n]["YJFSSJ"].ToString();
					model.YJCLSJ=dt.Rows[n]["YJCLSJ"].ToString();
					model.JYLSH=dt.Rows[n]["JYLSH"].ToString();
					model.DZYZData=dt.Rows[n]["DZYZData"].ToString();
					model.ZSXM_DM=dt.Rows[n]["ZSXM_DM"].ToString();
					model.ZSXM_MC=dt.Rows[n]["ZSXM_MC"].ToString();
					model.ZSPM_DM=dt.Rows[n]["ZSPM_DM"].ToString();
					model.ZSPM_MC=dt.Rows[n]["ZSPM_MC"].ToString();
					if(dt.Rows[n]["SL"].ToString()!="")
					{
						model.SL=decimal.Parse(dt.Rows[n]["SL"].ToString());
					}
					model.TSXX=dt.Rows[n]["TSXX"].ToString();
					model.ZT=dt.Rows[n]["ZT"].ToString();
					if(dt.Rows[n]["YJJE"].ToString()!="")
					{
						model.YJJE=decimal.Parse(dt.Rows[n]["YJJE"].ToString());
					}
					model.SSQQ=dt.Rows[n]["SSQQ"].ToString();
					model.SSQZ=dt.Rows[n]["SSQZ"].ToString();
					model.SBFKYZM=dt.Rows[n]["SBFKYZM"].ToString();
					model.FKDM=dt.Rows[n]["FKDM"].ToString();
					model.FKXX=dt.Rows[n]["FKXX"].ToString();
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

