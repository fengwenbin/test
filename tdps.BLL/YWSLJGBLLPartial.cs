using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���YWSLJGBLL ��ժҪ˵����
	/// </summary>
	public partial class YWSLJGBLL
	{
		#region  ��Ա����
		
		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.YWSLJG model, object trans)
		{
			dal.Add(model,trans);
		}		

		/// <summary>
		/// �õ����FID
		/// </summary>
		public int GetMaxFID()
		{
            return dal.GetMaxFID();
		}

		#endregion  ��Ա����
	}
}

