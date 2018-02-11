using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace tdps.BLL
{
    public class PrintHistoryBLL
    {
        private readonly tdps.DAL.PrintHistoryDAL dal = new tdps.DAL.PrintHistoryDAL();
        public PrintHistoryBLL()
        {
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.PrintHistory model)
        {
            dal.Add(model);
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
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListJoin(string str)
        {
            return dal.GetListJoin(str);
        }

    }
}
