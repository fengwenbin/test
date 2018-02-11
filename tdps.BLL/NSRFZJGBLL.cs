using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
    /// <summary>
    /// 业务逻辑类NSRFZJGBLL 的摘要说明。
    /// </summary>
    public partial class NSRFZJGBLL
    {
        private readonly tdps.DAL.NSRFZJGDAL dal = new tdps.DAL.NSRFZJGDAL();
        public NSRFZJGBLL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string zjgNsrsbh, string fzjgNsrsbh)
        {
            return dal.Exists(zjgNsrsbh, fzjgNsrsbh);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.NSRFZJG model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.NSRFZJG model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string zjgNsrsbh, string fzjgNsrsbh)
        {

            dal.Delete(zjgNsrsbh, fzjgNsrsbh);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.NSRFZJG GetModel(string zjgNsrsbh, string fzjgNsrsbh)
        {

            return dal.GetModel(zjgNsrsbh, fzjgNsrsbh);
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
        public List<tdps.Model.NSRFZJG> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.NSRFZJG> DataTableToList(DataTable dt)
        {
            List<tdps.Model.NSRFZJG> modelList = new List<tdps.Model.NSRFZJG>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                tdps.Model.NSRFZJG model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new tdps.Model.NSRFZJG();
                    model.nsrsbh = dt.Rows[n]["nsrsbh"].ToString();
                    model.zjgNsrsbh = dt.Rows[n]["zjgNsrsbh"].ToString();
                    model.fzjgNsrsbh = dt.Rows[n]["fzjgNsrsbh"].ToString();
                    model.fzjgMc = dt.Rows[n]["fzjgMc"].ToString();
                    if (dt.Rows[n]["sxysSrze"].ToString() != "")
                    {
                        model.sxysSrze = decimal.Parse(dt.Rows[n]["sxysSrze"].ToString());
                    }
                    if (dt.Rows[n]["sxysGzze"].ToString() != "")
                    {
                        model.sxysGzze = decimal.Parse(dt.Rows[n]["sxysGzze"].ToString());
                    }
                    if (dt.Rows[n]["sxysZcze"].ToString() != "")
                    {
                        model.sxysZcze = decimal.Parse(dt.Rows[n]["sxysZcze"].ToString());
                    }
                    if (dt.Rows[n]["sxysHj"].ToString() != "")
                    {
                        model.sxysHj = decimal.Parse(dt.Rows[n]["sxysHj"].ToString());
                    }
                    model.fpbl = dt.Rows[n]["fpbl"].ToString();
                    if (dt.Rows[n]["fpse"].ToString() != "")
                    {
                        model.fpse = decimal.Parse(dt.Rows[n]["fpse"].ToString());
                    }
                    model.kjzg = dt.Rows[n]["kjzg"].ToString();
                    model.LXDH = dt.Rows[n]["LXDH"].ToString();
                    model.YYDZ = dt.Rows[n]["YYDZ"].ToString();
                    model.ND = dt.Rows[n]["ND"].ToString();
                    model.rqQ = dt.Rows[n]["rqQ"].ToString();
                    model.rqZ = dt.Rows[n]["rqZ"].ToString();
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

