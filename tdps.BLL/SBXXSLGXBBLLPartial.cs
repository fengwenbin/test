using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBXXSLGXBBLL ��ժҪ˵����
	/// </summary>
	public partial class SBXXSLGXBBLL
	{
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBXXSLGXB model,object trans)
		{
			dal.Add(model,trans);
		}

		#endregion  ��Ա����
	}
}

