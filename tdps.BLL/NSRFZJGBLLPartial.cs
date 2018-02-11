using System;
using System.Collections.Generic;
using System.Text;
using tdps.Model;
using System.Data;

namespace tdps.BLL
{
    public partial class NSRFZJGBLL
    {
        /// <summary>
        /// 根据传入的sql语句获得带有数据对象的集合
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>数据集合</returns>
        public IList<NSRFZJG> GetModelListBySqlStr(string sql)
        {
            return dal.GetModelListBySqlStr(sql);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(NSRFZJG model)
        {
            return dal.Exists(model);
        }
        /// <summary>
        /// 根据sql获取数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>数据集</returns>
        public DataTable GetDataTableBySqlStr(string sql)
        {
            return dal.GetDataTableBySqlStr(sql);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string zjgNsrsbh, string fzjgNsrsbh, string nd)
        {
            return dal.Delete(zjgNsrsbh, fzjgNsrsbh, nd);
        }
        /// <summary>
        /// 删除某个总机构下某年度所有分支机构数据
        /// </summary>
        public int DeleteAllByZjgandNd(string zjgNsrsbh, string nd)
        {
            return dal.DeleteAllByZjgandNd(zjgNsrsbh, nd);
        }
        /// <summary>
        /// 更新指定纳税人识别号的分支机构信息
        /// </summary>
        /// <param name="zjgNsrsbh_old">原纳税人识别号</param>
        /// <param name="zjgNsrsbh_new">新的纳税人识别号</param>
        /// <param name="tran">事务对象</param>
        /// <returns>影响行数</returns>
        public int Update(string zjgNsrsbh_old, string zjgNsrsbh_new, object tran)
        {
            return dal.Update(zjgNsrsbh_old, zjgNsrsbh_new, tran);
        }

        public int Update(string strSQL, object tran)
        {
            return dal.Update(strSQL, tran);
        }
        /// <summary>
        /// 计算分配比例
        /// </summary>
        /// <param name="nd">年度</param>
        /// <param name="zjgnsrsbh">总机构纳税人识别号</param>
        /// <param name="xsw">分配比例小数位</param>
        /// <returns>影响的行数</returns>
        public int ComputeScale(string nd, string zjgnsrsbh,int xsw)
        {
            return dal.ComputeScale(nd, zjgnsrsbh, xsw);
        }
    }

}
