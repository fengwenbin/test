using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类UserInfoBLL 的摘要说明。
	/// </summary>
	public partial class UserInfoBLL
	{
		private readonly tdps.DAL.UserInfoDAL dal=new tdps.DAL.UserInfoDAL();
		public UserInfoBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DLZH,string NSRSBH)
		{
			return dal.Exists(DLZH,NSRSBH);
		}

        public void UpdateDLZTtoN()
        {
            dal.UpdateDLZTtoN();
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.UserInfo model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.UserInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string DLZH)
		{
			
			dal.Delete(DLZH);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.UserInfo GetModel(string DLZH,string nsrsbh)
		{

            return dal.GetModel(DLZH, nsrsbh);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.UserInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.UserInfo> DataTableToList(DataTable dt)
		{
			List<tdps.Model.UserInfo> modelList = new List<tdps.Model.UserInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.UserInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.UserInfo();
					model.DLZH=dt.Rows[n]["DLZH"].ToString();
					model.DLMM=dt.Rows[n]["DLMM"].ToString();
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.CWJSBM=dt.Rows[n]["CWJSBM"].ToString();
					model.NSRMC=dt.Rows[n]["NSRMC"].ToString();
					model.ZSXM=dt.Rows[n]["ZSXM"].ToString();
					model.XB=dt.Rows[n]["XB"].ToString();
					model.SJHM=dt.Rows[n]["SJHM"].ToString();
					model.QQ=dt.Rows[n]["QQ"].ToString();
					model.SFZHM=dt.Rows[n]["SFZHM"].ToString();
					model.EMAIL=dt.Rows[n]["EMAIL"].ToString();
					model.YZBM=dt.Rows[n]["YZBM"].ToString();
					model.DZ=dt.Rows[n]["DZ"].ToString();
					model.TJSJ=dt.Rows[n]["TJSJ"].ToString();
                    model.DLSJ = dt.Rows[n]["DLSJ"].ToString();
                    model.DLZT = dt.Rows[n]["DLZT"].ToString();
                    model.DLCS = dt.Rows[n]["DLCS"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}


		#endregion  成员方法
       
	}
}

