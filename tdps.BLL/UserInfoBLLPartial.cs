using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���UserInfoBLL ��ժҪ˵����
	/// </summary>
	public partial class UserInfoBLL
	{
		#region  ��Ա����


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.UserInfo model,object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.UserInfo model, object trans)
		{
			dal.Update(model, trans);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string DLZH,object trans)
		{
			
			dal.Delete(DLZH, trans);
		}
	
		#endregion  ��Ա����

        #region  �Զ��巽��
        /// <summary>
        /// �����˰��ʶ��������б�
        /// </summary>
        public DataSet GetNSRSBHList()
        {
            return dal.GetNSRSBHList();
        }

        /// <summary>
        /// ��˰��ʶ��ŵ��û�����
        /// </summary>
        /// <returns></returns>
        public int GetUserNumbyNSRSBH(string NSRSBH)
        {
            return dal.GetUserNumbyNSRSBH(NSRSBH);
        }
        /// <summary>
        /// ��¼
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <param name="NSRSBH"></param>
        /// <returns></returns>
        public tdps.Model.UserInfo Login(string username, string NSRSBH)
        {
            return dal.Login(username,NSRSBH);
        }
        #endregion  �Զ��巽��
	}
}

