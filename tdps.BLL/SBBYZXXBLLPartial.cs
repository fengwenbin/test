using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBBYZXXBLL 的摘要说明。
	/// </summary>
	public partial class SBBYZXXBLL
	{
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBBYZXX model,object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// 删除指定申报信息ID的错误信息数据
		/// </summary>
		public void Delete(int sbxxID,object trans)
		{
			//该表无主键信息，请自定义主键/条件字段
			dal.Delete(sbxxID,trans);
		}

        public void Delete(int sbxxID,string type, object trans)
        {
            //该表无主键信息，请自定义主键/条件字段
            dal.Delete(sbxxID,type, trans);
        }
		#endregion  成员方法
	}
}

