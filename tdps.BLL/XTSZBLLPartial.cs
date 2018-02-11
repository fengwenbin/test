using System;
using System.Collections.Generic;
using System.Text;

namespace tdps.BLL
{
   public partial class XTSZBLL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.XTSZ model,object tran)
        {
            dal.Add(model,tran);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.XTSZ model,object tran)
        {
            dal.Update(model,tran);
        }
        /// <summary>
        /// 删除全部数据
        /// </summary>
        public void Delete(object tran)
        {
            dal.Delete(tran);
        }

    }
}
