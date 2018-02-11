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
        private readonly tdps.DAL.SBXXDAL dal = new tdps.DAL.SBXXDAL();
        public SBXXBLL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SBXXID)
        {
            return dal.Exists(SBXXID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.SBXX model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.SBXX model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID)
        {

            dal.Delete(SBXXID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.SBXX GetModel(int SBXXID)
        {

            return dal.GetModel(SBXXID);
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
        public List<tdps.Model.SBXX> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.SBXX> DataTableToList(DataTable dt)
        {
            List<tdps.Model.SBXX> modelList = new List<tdps.Model.SBXX>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                tdps.Model.SBXX model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new tdps.Model.SBXX();
                    if (dt.Rows[n]["SBXXID"].ToString() != "")
                    {
                        model.SBXXID = int.Parse(dt.Rows[n]["SBXXID"].ToString());
                    }
                    model.DLZH = dt.Rows[n]["DLZH"].ToString();
                    model.NSRSBH = dt.Rows[n]["NSRSBH"].ToString();
                    model.SZ = dt.Rows[n]["SZ"].ToString();
                    model.SBZLCODE = dt.Rows[n]["SBZLCODE"].ToString();
                    model.SBZLMC = dt.Rows[n]["SBZLMC"].ToString();
                    model.SSQQ = dt.Rows[n]["SSQQ"].ToString();
                    model.SSQZ = dt.Rows[n]["SSQZ"].ToString();
                    model.SBBWJ = dt.Rows[n]["SBBWJ"].ToString();
                    model.BBZT = dt.Rows[n]["BBZT"].ToString();
                    model.TBSJ = dt.Rows[n]["TBSJ"].ToString();
                    model.SBJSZT = dt.Rows[n]["SBJSZT"].ToString();
                    model.SBFSSJ = dt.Rows[n]["SBFSSJ"].ToString();
                    model.SLSJ = dt.Rows[n]["SLSJ"].ToString();
                    model.CLSJ = dt.Rows[n]["CLSJ"].ToString();
                    model.JSSJ = dt.Rows[n]["JSSJ"].ToString();
                    model.SBQNF = dt.Rows[n]["SBQNF"].ToString();
                    model.SBQYF = dt.Rows[n]["SBQYF"].ToString();
                    model.FileName = dt.Rows[n]["FileName"].ToString();
                    if (dt.Rows[n]["SBCS"].ToString() != "")
                    {
                        model.SBCS = int.Parse(dt.Rows[n]["SBCS"].ToString());
                    }
                    if (dt.Rows[n]["SSQLX"].ToString() != "")
                    {
                        model.SSQLX = int.Parse(dt.Rows[n]["SSQLX"].ToString());
                    }
                    if (dt.Rows[n]["SBSE"].ToString() != "")
                    {
                        model.SBSE = decimal.Parse(dt.Rows[n]["SBSE"].ToString());
                    }
                    model.SheetZT = dt.Rows[n]["SheetZT"].ToString();
                    model.CELLVERSION = dt.Rows[n]["CELLVERSION"].ToString();
                    model.SJBS = dt.Rows[n]["SJBS"].ToString();
                    model.DKFPRQQ = dt.Rows[n]["DKFPRQQ"].ToString();
                    model.DKFPRQZ = dt.Rows[n]["DKFPRQZ"].ToString();
                    model.BBTXCS = dt.Rows[n]["BBTXCS"].ToString();
                    model.CWBBFSJG = dt.Rows[n]["CWBBFSJG"].ToString();
                    model.CWBBFileName = dt.Rows[n]["CWBB_FileName"].ToString();
                    if (dt.Rows[n]["SBLSH"] != null)
                        model.SBLSH = dt.Rows[n]["SBLSH"].ToString();
                    if (dt.Rows[n]["DYMM"] != null)
                        model.DYMM = dt.Rows[n]["DYMM"].ToString();
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

