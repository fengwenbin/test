using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���NSRXXGSBLL ��ժҪ˵����
	/// </summary>
	public partial class NSRXXGSBLL
	{

		#region  ��Ա����
	
		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.NSRXXGS model, object trans)
		{
			dal.Add(model, trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.NSRXXGS model, object trans)
		{
			dal.Update(model, trans);
		}

		#endregion  ��Ա����
	}
}

