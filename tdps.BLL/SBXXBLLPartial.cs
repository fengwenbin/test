using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBXXBLL 的摘要说明。
	/// </summary>
	public partial class SBXXBLL
	{
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXX model,object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(tdps.Model.SBXX model,object trans)
		{
			dal.Update(model,trans);
		}

        /// <summary>
        /// 更新财务报表SBXX中数据
        /// </summary>
        public void UpdateCWBB(tdps.Model.SBXX model, object trans)
        {
            dal.UpdateCWBB(model, trans);
        }

        ///// <summary>
        ///// 更新一条数据，带版本字段更新
        ///// </summary>
        public void Update1(tdps.Model.SBXX model, object trans)
        {
            dal.Update1(model, trans);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {

            dal.Delete(SBXXID,trans);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(tdps.Model.SBXX model)
        {
            return dal.Exists(model);
        }

        /// <summary>
        /// 获得数据列表,根据SQL语句
        /// </summary>
        /// <param name="strsql">SQL语句</param>
        /// <returns></returns>
        public DataSet GetListBySQL(string strsql)
        {
            return dal.GetListBySQL(strsql);
        }

        /// <summary>
        /// 更新多条数据的填写状态
        /// </summary>
        public void UpdateBBZTState(string state, string SBXXIDs, object trans)
        {
            dal.UpdateBBZTState(state, SBXXIDs, trans);
        }

        /// <summary>
        /// 更新多条数据的申报状态
        /// </summary>
        public void UpdateState(string state, string SBXXIDs, object trans)
        {
            dal.UpdateState(state, SBXXIDs, trans);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.SBXX GetModel(tdps.Model.SBXX model)
        {

            return dal.GetModel(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.SBXX GetModel(tdps.Model.SBXX model,string a)
        {

            return dal.GetModel(model,"");
        }

		#endregion  成员方法
	}
}

