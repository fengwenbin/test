using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBXXBLL ��ժҪ˵����
	/// </summary>
	public partial class SBXXBLL
	{
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBXX model,object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.SBXX model,object trans)
		{
			dal.Update(model,trans);
		}

        /// <summary>
        /// ���²��񱨱�SBXX������
        /// </summary>
        public void UpdateCWBB(tdps.Model.SBXX model, object trans)
        {
            dal.UpdateCWBB(model, trans);
        }

        ///// <summary>
        ///// ����һ�����ݣ����汾�ֶθ���
        ///// </summary>
        public void Update1(tdps.Model.SBXX model, object trans)
        {
            dal.Update1(model, trans);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {

            dal.Delete(SBXXID,trans);
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(tdps.Model.SBXX model)
        {
            return dal.Exists(model);
        }

        /// <summary>
        /// ��������б�,����SQL���
        /// </summary>
        /// <param name="strsql">SQL���</param>
        /// <returns></returns>
        public DataSet GetListBySQL(string strsql)
        {
            return dal.GetListBySQL(strsql);
        }

        /// <summary>
        /// ���¶������ݵ���д״̬
        /// </summary>
        public void UpdateBBZTState(string state, string SBXXIDs, object trans)
        {
            dal.UpdateBBZTState(state, SBXXIDs, trans);
        }

        /// <summary>
        /// ���¶������ݵ��걨״̬
        /// </summary>
        public void UpdateState(string state, string SBXXIDs, object trans)
        {
            dal.UpdateState(state, SBXXIDs, trans);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public tdps.Model.SBXX GetModel(tdps.Model.SBXX model)
        {

            return dal.GetModel(model);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public tdps.Model.SBXX GetModel(tdps.Model.SBXX model,string a)
        {

            return dal.GetModel(model,"");
        }

		#endregion  ��Ա����
	}
}

