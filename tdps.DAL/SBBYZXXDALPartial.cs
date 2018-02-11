using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����SBBYZXXDAL��
	/// </summary>
	public partial class SBBYZXXDAL
	{
		#region  ��Ա����


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.SBBYZXX model,object trans)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into SBBYZXX(");
            strSql.Append("SBXXID,SheetInx,Col,Row,ErrorContent,Type)");
            strSql.Append(" values (");
            strSql.Append("@SBXXID,@SheetInx,@Col,@Row,@ErrorContent,@Type)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@SBXXID", DbType.Int32,4),
					new SQLiteParameter("@SheetInx", DbType.Int32,4),
					new SQLiteParameter("@Col", DbType.Int32,4),
					new SQLiteParameter("@Row", DbType.Int32,4),
					new SQLiteParameter("@ErrorContent", DbType.String),
					new SQLiteParameter("@Type", DbType.Int32,4)};
            parameters[0].Value = model.SBXXID;
            parameters[1].Value = model.SheetInx;
            parameters[2].Value = model.Col;
            parameters[3].Value = model.Row;
            parameters[4].Value = model.ErrorContent;
            parameters[5].Value = model.Type;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int _sbxxId,object tran)
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBBYZXX ");
            strSql.Append(" where SBXXID=@SBXXID");
            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@SBXXID", DbType.Int32,4)
                                           };
            parameters[0].Value = _sbxxId;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)tran, parameters);
		}

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int _sbxxId, string _type,object tran)
        {
            //�ñ���������Ϣ�����Զ�������/�����ֶ�
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SBBYZXX ");
            strSql.Append(" where SBXXID=@SBXXID and Type=@Type");
            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@SBXXID", DbType.Int32,4),new SQLiteParameter("@Type", DbType.String, 2)
                                           };
            parameters[0].Value = _sbxxId;
            parameters[1].Value = _type;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)tran, parameters);
        }

		#endregion  ��Ա����
	}
}

