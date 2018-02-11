using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using tdps.Model;

namespace tdps.BLL
{
    public class DLNSRXXBLL
    {
        private readonly tdps.DAL.DLNSRXXDAL dal = new tdps.DAL.DLNSRXXDAL();
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string dlzh,string nsrsbh)
        {
            return dal.Exists(dlzh,nsrsbh);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.DLNSRXX model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.DLNSRXX model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string dlzh, string nsrsbh)
        {

            dal.Delete(dlzh,nsrsbh);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.DLNSRXX model,object trans)
        {
            dal.Add(model,trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.DLNSRXX model,object trans)
        {
            dal.Update(model,trans);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string dlzh, string nsrsbh,object trans)
        {

            dal.Delete(dlzh,nsrsbh,trans);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.DLNSRXX GetModel(string dlzh)
        {

            return dal.GetModel(dlzh);
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
        public List<tdps.Model.DLNSRXX> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.DLNSRXX> DataTableToList(DataTable dt)
        {
            List<tdps.Model.DLNSRXX> modelList = new List<tdps.Model.DLNSRXX>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                tdps.Model.DLNSRXX model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new tdps.Model.DLNSRXX();
                    if (dt.Rows[n]["DLZH"].ToString() != "")
                    {
                        model.DLZH = dt.Rows[n]["DLZH"].ToString();
                    }
                    model.NSRSBH = dt.Rows[n]["NSRSBH"].ToString();
                    NSRXX nsrxx = new NSRXX();
                    nsrxx.NSRMC = dt.Rows[n]["NSRMC"].ToString();
                    model.NSRXX = nsrxx;
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
