using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���GSKHYHBLL ��ժҪ˵����
	/// </summary>
	public partial class GSKHYHBLL
	{
		
		#region  ��Ա����
		
		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.GSKHYH model, object trans)
		{
			dal.Add(model, trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.GSKHYH model, object trans)
		{
			dal.Update(model, trans);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
        public void Delete(string NSRSBH, object trans)
		{			
			dal.Delete(NSRSBH, trans);
		}

        /// <summary>
        /// ȡ��Ĭ��
        /// </summary>
        /// <returns></returns>
        public void CancelSFMR(string NSRSBH, object trans)
        {
            dal.CancelSFMR(NSRSBH,trans);
        }

		#endregion  ��Ա����
	}
}

