using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���DSKHYHBLL ��ժҪ˵����
	/// </summary>
	public partial class DSKHYHBLL
	{
		
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Add(tdps.Model.DSKHYH model, object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(tdps.Model.DSKHYH model, object trans)
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

		#endregion  ��Ա����
	}
}

