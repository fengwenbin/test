using System;
using System.Collections.Generic;
using System.Text;
using tdps.Model;

namespace tdps.BLL
{
    public partial class NSRZJGBLL
    {
        /// <summary>
        /// 更新总机构信息，带有事务控制
        /// </summary>
        /// <param name="model">总机构信息</param>
        /// <param name="tran">事务对象</param>
        /// <returns>更新结果</returns>
        public int Update(NSRZJG model, object tran)
        {
            return dal.Update(model, tran);
        }
        public NSRZJG GetSumInfoByNsrsbhNd(string nsrsbh, string nd)
        {
            return dal.GetSumInfoByNsrsbhNd(nsrsbh, nd);
        }
        public NSRZJG GetSumInfoByNsrsbhNd(string nsrsbh, string nd, string fzjgnsrshb)
        {
            return dal.GetSumInfoByNsrsbhNd(nsrsbh, nd, fzjgnsrshb);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string nsrsbh, string nd)
        {

            dal.Delete(nsrsbh, nd);
        }
    }
}
