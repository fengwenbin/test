using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// ҵ���߼���SBBYZXXBLL ��ժҪ˵����
	/// </summary>
	public partial class SBBYZXXBLL
	{
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBBYZXX model,object trans)
		{
			dal.Add(model,trans);
		}

		/// <summary>
		/// ɾ��ָ���걨��ϢID�Ĵ�����Ϣ����
		/// </summary>
		public void Delete(int sbxxID,object trans)
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete(sbxxID,trans);
		}

        public void Delete(int sbxxID,string type, object trans)
        {
            //�ñ���������Ϣ�����Զ�������/�����ֶ�
            dal.Delete(sbxxID,type, trans);
        }
		#endregion  ��Ա����
	}
}

