using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���USERQXBBLL ��ժҪ˵����
	/// </summary>
	public partial class USERQXBBLL
	{
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.USERQXB model,object trans)
		{
			dal.Add(model, trans);
		}


		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string DLZH,string NSRSBH,object trans)
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete(DLZH,NSRSBH,trans);
		}

		
		#endregion  ��Ա����
	}
}

