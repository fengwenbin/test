using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���KKCLBLL ��ժҪ˵����
	/// </summary>
	public partial class KKCLBLL
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
        public bool Exists(tdps.Model.KKCL model)
		{
			return dal.Exists( model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.KKCL model,object trans)
		{
			dal.Add(model,trans);
		}
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetListBySQL(string strSql)
        {
            return dal.GetListBySQL(strSql);
        }
		#endregion  ��Ա����
	}
}

