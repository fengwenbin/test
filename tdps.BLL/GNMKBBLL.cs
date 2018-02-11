using System;
using System.Data;
using System.Collections.Generic;
namespace tdps.Model
{
	/// <summary>
	/// 实体类GNMKB 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class GNMKBBLL
	{
        private readonly tdps.DAL.GNMKBDAL dal = new tdps.DAL.GNMKBDAL();

        public GNMKBBLL()
		{}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(tdps.Model.GNMKB model)
        {
            if (dal.Update(model)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新多条记录
        /// </summary>
        public bool Update(List<GNMKB> list)
        {
            return dal.UpdateList(list);
        }
        

        public List<tdps.Model.GNMKB> GetList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tdps.Model.GNMKB> DataTableToList(DataTable dt)
        {
            List<tdps.Model.GNMKB> modelList = new List<tdps.Model.GNMKB>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                tdps.Model.GNMKB model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new tdps.Model.GNMKB();
                    model.ID = dt.Rows[n]["ID"].ToString();
                    model.GNMC = dt.Rows[n]["GNMC"].ToString();
                    model.GNBH = dt.Rows[n]["GNBH"].ToString();
                    model.SFBX = dt.Rows[n]["SFBX"].ToString();
                    model.SFKY = dt.Rows[n]["SFKY"].ToString();
                    model.SJ = dt.Rows[n]["SJ"].ToString();
                    model.SWJGT = dt.Rows[n]["SWJGT"].ToString();
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        public bool SFCZ(string gnbh,string nsrsbh)
        {
            return dal.SFCZ(gnbh, nsrsbh);
        }

        public bool XZGN(GNMKB gn)
        {
            if (dal.XZGN(gn) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.GNMKB GetModel(string gnbh,string nsrsbh)
        {

            return dal.GetModel(gnbh, nsrsbh);
        }
	}
}

