using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBZFBLL ��ժҪ˵����
	/// </summary>
	public partial class SBZFBLL
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
        public bool Exists(tdps.Model.SBZF model)
		{
			return dal.Exists( model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBZF model,object trans)
		{
            dal.Add(model, trans);
		}

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(tdps.Model.SBZF model, object trans)
        {
            dal.Update(model, trans);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {
            dal.Delete(SBXXID, trans);
        }

        /// <summary>
        /// �õ�һ��ʵ�����
        /// </summary>
        public tdps.Model.SBZF GetModelBySBXXID(int SBXXID)
        {
           return dal.GetModelBySBXXID(SBXXID);
        }

		#endregion  ��Ա����
	}
}

