using System;
using System.Collections.Generic;
using System.Text;

namespace tdps.BLL
{
   public partial class HDXXBLL
    {
       /// <summary>
        /// 是否存在该记录
        /// </summary>
       public bool Exists(string NSRSBH, int SZFL)
       {
           return dal.Exists(NSRSBH, SZFL);
       }
       /// <summary>
        /// 删除一条数据
        /// </summary>
       public void Delete(string NSRSBH, int SZFL)
       {
           dal.Delete(NSRSBH, SZFL);
       }
       /// <summary>
        /// 得到一个对象实体
        /// </summary>
       public tdps.Model.HDXX GetModel(string NSRSBH, int SZFL)
       {
           return dal.GetModel(NSRSBH, SZFL);
       }
    }
}
