using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���NSRXXDSBLL ��ժҪ˵����
	/// </summary>
	public partial class NSRXXDSBLL
	{

		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.NSRXXDS model, object trans)
		{
			dal.Add(model, trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.NSRXXDS model, object trans)
		{
			dal.Update(model,  trans);
		}

	
		#endregion  ��Ա����
	}
}

