using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SPXXBLL ��ժҪ˵����
	/// </summary>
	public partial class SPXXBLL
	{
		#region  ��Ա����
		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.SPXX model, object trans)
		{
            dal.Add(model, trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.SPXX model, object trans)
		{
            dal.Update(model, trans);
		}

		#endregion  ��Ա����
	}
}

