using System;
using System.Collections.Generic;
using System.Text;
using tdps.Model;

namespace tdps.BLL
{
   public partial class SBXMLBLL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.SBXML model,object trans)
        {
            dal.Add(model,trans);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID, string FileName,object trans)
        {
            dal.Delete(SBXXID, FileName,trans);
        }

        /// <summary>
        /// 删除多条数据
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {
            dal.Delete(SBXXID,  trans);
        }
        #region 扩展方法
       /// <summary>
       /// 根据sql语句查询一条填报数据信息
       /// </summary>
       /// <param name="sql">sql语句</param>
       /// <returns>报表数据信息对象</returns>
        public SBXML GetModelBySql(string sql)
        {
            return dal.GetModelBySql(sql);
        }
        #endregion
    }
}
