using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类NSRXXBLL 的摘要说明。
	/// </summary>
    public partial class BBJYTJBLL
	{
		private readonly tdps.DAL.BBJYTJDAL dal=new tdps.DAL.BBJYTJDAL();
        public BBJYTJBLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SBXXID,string JYLXCODE)
		{
            return dal.Exists(SBXXID, JYLXCODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.BBJYTJ model)
		{
			dal.Add(model);
		}


        public void Add(tdps.Model.BBJYTJ model,object tran)
        {
            dal.Add(model, tran);
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(string SBXXID, string JYLXCODE)
		{

            dal.Delete(SBXXID, JYLXCODE);
		}

        public void Delete(string SBXXID, string JYLXCODE, object tran)
        {

            dal.Delete(SBXXID, JYLXCODE, tran);
        }

        public void DeleteAll(string SBXXID, object trans)
        {
            dal.DeleteAll(SBXXID, trans);
        }

        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }


		#endregion  成员方法
	}
}

