using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���YJSCLBLL ��ժҪ˵����
	/// </summary>
	public partial class YJSCLBLL
	{
		#region  ��Ա����


        public bool Exists(string FileName)
        {
           return dal.Exists(FileName);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.YJSCL model ,object trans)
		{
            dal.Add(model, trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.YJSCL model, object trans)
		{
			dal.Update(model,trans);
		}

		#endregion  ��Ա����
	}
}

