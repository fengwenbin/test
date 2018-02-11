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
		#region  成员方法


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.UserInfo model,object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.UserInfo model, object trans)
		{
			dal.Update(model, trans);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string DLZH,object trans)
		{
			
			dal.Delete(DLZH, trans);
		}
	
		#endregion  成员方法

        #region  自定义方法
        /// <summary>
        /// 获得纳税人识别号数据列表
        /// </summary>
        public DataSet GetNSRSBHList()
        {
            return dal.GetNSRSBHList();
        }

        /// <summary>
        /// 纳税人识别号的用户个数
        /// </summary>
        /// <returns></returns>
        public int GetUserNumbyNSRSBH(string NSRSBH)
        {
            return dal.GetUserNumbyNSRSBH(NSRSBH);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <param name="NSRSBH"></param>
        /// <returns></returns>
        public tdps.Model.UserInfo Login(string username, string NSRSBH)
        {
            return dal.Login(username,NSRSBH);
        }
        #endregion  自定义方法
	}
}

