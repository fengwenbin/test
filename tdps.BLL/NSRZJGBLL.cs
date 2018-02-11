using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
    /// <summary>
    /// 业务逻辑类NSRZJGBLL 的摘要说明。
    /// </summary>
    public partial class NSRZJGBLL
    {
        private readonly tdps.DAL.NSRZJGDAL dal = new tdps.DAL.NSRZJGDAL();
        public NSRZJGBLL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string nsrsbh)
        {
            return dal.Exists(nsrsbh);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string nsrsbh, string nd)
        {
            return dal.Exists(nsrsbh, nd);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRZJG model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.NSRZJG model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 根据SQL语句更新数据
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="tran"></param>
        public void Update(string strSQL, object tran)
        {
            dal.Update(strSQL, tran);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string nsrsbh)
        {

            dal.Delete(nsrsbh);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.NSRZJG GetModel(string nsrsbh)
        {

            return dal.GetModel(nsrsbh);
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
        public List<tdps.Model.NSRZJG> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.NSRZJG> DataTableToList(DataTable dt)
        {
            List<tdps.Model.NSRZJG> modelList = new List<tdps.Model.NSRZJG>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                tdps.Model.NSRZJG model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new tdps.Model.NSRZJG();
                    model.nsrsbh = dt.Rows[n]["nsrsbh"].ToString();
                    model.zjgNsrsbh = dt.Rows[n]["zjgNsrsbh"].ToString();
                    model.zjgMc = dt.Rows[n]["zjgMc"].ToString();
                    model.kjzg = dt.Rows[n]["kjzg"].ToString();
                    model.LXDH = dt.Rows[n]["LXDH"].ToString();
                    model.ND = dt.Rows[n]["ND"].ToString();
                    if (dt.Rows[n]["SRZE"].ToString() != "")
                    {
                        model.SRZE = decimal.Parse(dt.Rows[n]["SRZE"].ToString());
                    }
                    if (dt.Rows[n]["GZZE"].ToString() != "")
                    {
                        model.GZZE = decimal.Parse(dt.Rows[n]["GZZE"].ToString());
                    }
                    if (dt.Rows[n]["ZCZE"].ToString() != "")
                    {
                        model.ZCZE = decimal.Parse(dt.Rows[n]["ZCZE"].ToString());
                    }
                    if (dt.Rows[n]["HJ"].ToString() != "")
                    {
                        model.HJ = decimal.Parse(dt.Rows[n]["HJ"].ToString());
                    }
                    if (dt.Rows[n]["QDZT"].ToString() != "")
                    {
                        model.QDZT = dt.Rows[n]["QDZT"].ToString();
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


        #endregion  成员方法
    }
}

