using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���NSRXXBLL ��ժҪ˵����
	/// </summary>
	public partial class NSRXXBLL
	{
		#region  ��Ա����
	
		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.NSRXX model, object trans)
		{
			dal.Add(model, trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.NSRXX model, object trans)
		{
			dal.Update(model, trans);
		}

        public int UpdateSbmm(string nsrxx,string sbmm)
        {
            return dal.UpdateSBMM(nsrxx, sbmm);
        }

		#endregion  ��Ա����
	}
}

