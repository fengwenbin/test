using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBCLBLL ��ժҪ˵����
	/// </summary>
	public partial class SBCLBLL
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
        public bool Exists(tdps.Model.SBCL model)
		{
            return dal.Exists(model);
		}

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(tdps.Model.SBCL model,object trans)
        {
            dal.Add(model, trans);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(tdps.Model.SBCL model, object trans)
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
        //
        public void Delete(string where, object trans)
        {
            dal.Delete(where, trans);
        }


         /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public tdps.Model.SBCL GetModelBySBXXID(int SBXXID)
        {
            return dal.GetModelBySBXXID(SBXXID);
        }

		#endregion  ��Ա����
	}
}

