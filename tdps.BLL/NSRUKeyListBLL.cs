using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace tdps.BLL
{
    public class NSRUKeyListBLL
    {
        private readonly tdps.DAL.NSRUKeyListDAL dal = new tdps.DAL.NSRUKeyListDAL();

        public NSRUKeyListBLL()
		{}

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string nsrsbh,string ukeyid)
		{
            return dal.Exists(nsrsbh, ukeyid);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRUKeyList model)
        {
            dal.Add(model);
        }

        public void Add(tdps.Model.NSRUKeyList model,object tran)
        {
            dal.Add(model, tran);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.NSRUKeyList> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.NSRUKeyList> DataTableToList(DataTable dt)
        {
            List<tdps.Model.NSRUKeyList> modelList = new List<tdps.Model.NSRUKeyList>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                tdps.Model.NSRUKeyList model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new tdps.Model.NSRUKeyList();

                    model.NSRSBH = dt.Rows[n]["NSRSBH"].ToString();
                    model.UKeyID = dt.Rows[n]["UKeyID"].ToString();
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string where)
        {

            dal.Delete(where);
        }
        public void Delete(string where,object tran)
        {

            dal.Delete(where,tran);
        }
    }
}
