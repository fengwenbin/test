using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DYMXBLL ��ժҪ˵����
	/// </summary>
	public partial class DYMXBLL
	{
		#region  ��Ա����
		
		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.DYMX model,object trans)
        {
            dal.Add(model, trans);
        }

		#endregion  ��Ա����
	}
}

