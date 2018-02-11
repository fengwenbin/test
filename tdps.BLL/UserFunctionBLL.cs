using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类UserFunctionBLL 的摘要说明。
	/// </summary>
	public class UserFunctionBLL
	{
		private readonly tdps.DAL.UserFunctionDAL dal=new tdps.DAL.UserFunctionDAL();
		public UserFunctionBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.UserFunction model)
		{
			dal.Add(model);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.UserFunction model, object trans)
        {
            dal.Add(model, trans);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.UserFunction model)
		{
			dal.Update(model);
		}

        public bool Update(List<tdps.Model.UserFunction> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        dal.Update(list[i]);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tdps.Model.UserFunction GetModel(string dlzh,string nsrsbh)
		{

            return dal.GetModel(dlzh, nsrsbh);
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
		public List<tdps.Model.UserFunction> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tdps.Model.UserFunction> DataTableToList(DataTable dt)
		{
			List<tdps.Model.UserFunction> modelList = new List<tdps.Model.UserFunction>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				tdps.Model.UserFunction model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new tdps.Model.UserFunction();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.NSRSBH=dt.Rows[n]["NSRSBH"].ToString();
					model.DLZH=dt.Rows[n]["DLZH"].ToString();
					model.GNBH=dt.Rows[n]["GNBH"].ToString();
					if(dt.Rows[n]["SFKY"].ToString()!="")
					{
						if((dt.Rows[n]["SFKY"].ToString()=="1")||(dt.Rows[n]["SFKY"].ToString().ToLower()=="true"))
						{
						model.SFKY="1";
						}
						else
						{
							model.SFKY="0";
						}
					}
					if(dt.Rows[n]["SFBX"].ToString()!="")
					{
						if((dt.Rows[n]["SFBX"].ToString()=="1")||(dt.Rows[n]["SFBX"].ToString().ToLower()=="true"))
						{
						model.SFBX="1";
						}
						else
						{
							model.SFBX="0";
						}
					}
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

        public bool GetSFSH(string dlzh, string nsrsbh)
        {
            bool rtValue = false;
            GNMKBBLL gnbll = new GNMKBBLL();
            List<GNMKB> gnList = gnbll.GetList(string.Format(" NSRSBH='{0}' and gnbh='{1}'",nsrsbh,"2005"));
            if (gnList != null && gnList.Count > 0)
            {
                if (dlzh != null && nsrsbh != null)
                {
                    List<UserFunction> list = GetModelList(string.Format(" dlzh='{0}' and nsrsbh = '{1}' and gnbh='2005'", dlzh, nsrsbh));

                    if (list != null && list.Count == 0)
                    {
                        rtValue = true;
                    }
                }
            }
            return rtValue;
        }


		#endregion  成员方法
	}
}

