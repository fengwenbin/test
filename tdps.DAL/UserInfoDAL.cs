using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
namespace tdps.DAL
{
	/// <summary>
	/// ���ݷ�����UserInfoDAL��
	/// </summary>
	public partial class UserInfoDAL
	{
		public UserInfoDAL()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string DLZH,string NSRSBH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(DLZH) from UserInfo");
			strSql.Append(" where DLZH=@DLZH ");
            strSql.Append(" and NSRSBH=@NSRSBH ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,50),
                    new SQLiteParameter("@NSRSBH", DbType.String,20)};
			parameters[0].Value = DLZH;
            parameters[1].Value = NSRSBH;

			return SQLiteHelper.Exists(strSql.ToString(),parameters);
		}

        
        public void UpdateDLZTtoN()
        {
            string sql = "update UserInfo set DLZT='N'";

            SQLiteHelper.ExecuteNonQuery(sql);
        }


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(tdps.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
			strSql.Append("DLZH,DLMM,NSRSBH,CWJSBM,NSRMC,ZSXM,XB,SJHM,QQ,SFZHM,EMAIL,YZBM,DZ,TJSJ,DLSJ,DLZT,DLCS)");
			strSql.Append(" values (");
            strSql.Append("@DLZH,@DLMM,@NSRSBH,@CWJSBM,@NSRMC,@ZSXM,@XB,@SJHM,@QQ,@SFZHM,@EMAIL,@YZBM,@DZ,@TJSJ,@DLSJ,@DLZT,@DLCS)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@DLMM", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@CWJSBM", DbType.String,2),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@ZSXM", DbType.String,20),
					new SQLiteParameter("@XB", DbType.String,2),
					new SQLiteParameter("@SJHM", DbType.String,20),
					new SQLiteParameter("@QQ", DbType.String,20),
					new SQLiteParameter("@SFZHM", DbType.String,20),
					new SQLiteParameter("@EMAIL", DbType.String,100),
					new SQLiteParameter("@YZBM", DbType.String,6),
					new SQLiteParameter("@DZ", DbType.String,200),
					new SQLiteParameter("@TJSJ", DbType.String,20),
                    new SQLiteParameter("@DLSJ", DbType.String,20),
                   new SQLiteParameter("@DLZT", DbType.String,1),
                   new SQLiteParameter("@DLCS", DbType.String,400)};
			parameters[0].Value = model.DLZH;
			parameters[1].Value = model.DLMM;
			parameters[2].Value = model.NSRSBH;
			parameters[3].Value = model.CWJSBM;
			parameters[4].Value = model.NSRMC;
			parameters[5].Value = model.ZSXM;
			parameters[6].Value = model.XB;
			parameters[7].Value = model.SJHM;
			parameters[8].Value = model.QQ;
			parameters[9].Value = model.SFZHM;
			parameters[10].Value = model.EMAIL;
			parameters[11].Value = model.YZBM;
			parameters[12].Value = model.DZ;
			parameters[13].Value = model.TJSJ;
            parameters[14].Value = model.DLSJ;
            parameters[15].Value = model.DLZT;
            parameters[16].Value = model.DLCS;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(tdps.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("DLMM=@DLMM,");
			strSql.Append("NSRMC=@NSRMC,");
			strSql.Append("ZSXM=@ZSXM,");
			strSql.Append("XB=@XB,");
			strSql.Append("SJHM=@SJHM,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("SFZHM=@SFZHM,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("YZBM=@YZBM,");
			strSql.Append("DZ=@DZ,");
			strSql.Append("TJSJ=@TJSJ,");
            strSql.Append("DLSJ=@DLSJ,");
            strSql.Append("DLZT=@DLZT,");
            strSql.Append("DLCS=@DLCS");
            strSql.Append(" where DLZH=@DLZH and NSRSBH=@NSRSBH");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,20),
					new SQLiteParameter("@DLMM", DbType.String,20),
					new SQLiteParameter("@NSRSBH", DbType.String,20),
					new SQLiteParameter("@NSRMC", DbType.String,80),
					new SQLiteParameter("@ZSXM", DbType.String,20),
					new SQLiteParameter("@XB", DbType.String,2),
					new SQLiteParameter("@SJHM", DbType.String,20),
					new SQLiteParameter("@QQ", DbType.String,20),
					new SQLiteParameter("@SFZHM", DbType.String,20),
					new SQLiteParameter("@EMAIL", DbType.String,100),
					new SQLiteParameter("@YZBM", DbType.String,6),
					new SQLiteParameter("@DZ", DbType.String,200),
					new SQLiteParameter("@TJSJ", DbType.String,20),
                    new SQLiteParameter("@DLSJ", DbType.String,20),
                                           new SQLiteParameter("@DLZT", DbType.String,1),
                                           new SQLiteParameter("@DLCS", DbType.String,400)};
			parameters[0].Value = model.DLZH;
			parameters[1].Value = model.DLMM;
			parameters[2].Value = model.NSRSBH;
			parameters[3].Value = model.NSRMC;
			parameters[4].Value = model.ZSXM;
			parameters[5].Value = model.XB;
			parameters[6].Value = model.SJHM;
			parameters[7].Value = model.QQ;
			parameters[8].Value = model.SFZHM;
			parameters[9].Value = model.EMAIL;
			parameters[10].Value = model.YZBM;
			parameters[11].Value = model.DZ;
			parameters[12].Value = model.TJSJ;
            parameters[13].Value = model.DLSJ;
            parameters[14].Value = model.DLZT;
            parameters[15].Value = model.DLCS;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string DLZH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where DLZH=@DLZH ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,50)};
			parameters[0].Value = DLZH;

			SQLiteHelper.ExecuteNonQuery(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public tdps.Model.UserInfo GetModel(string DLZH,string NSRSBH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DLZH,DLMM,NSRSBH,CWJSBM,NSRMC,ZSXM,XB,SJHM,QQ,SFZHM,EMAIL,YZBM,DZ,TJSJ,DLSJ,DLZT,DLCS from UserInfo ");
            strSql.Append(" where DLZH=@DLZH and NSRSBH=@NSRSBH");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@DLZH", DbType.String,50),
                    new SQLiteParameter("@NSRSBH", DbType.String,20)};
			parameters[0].Value = DLZH;
            parameters[1].Value = NSRSBH;

			tdps.Model.UserInfo model=new tdps.Model.UserInfo();
			DataSet ds=SQLiteHelper.ExecuteDataSet(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.DLZH=ds.Tables[0].Rows[0]["DLZH"].ToString();
				model.DLMM=ds.Tables[0].Rows[0]["DLMM"].ToString();
				model.NSRSBH=ds.Tables[0].Rows[0]["NSRSBH"].ToString();
				model.CWJSBM=ds.Tables[0].Rows[0]["CWJSBM"].ToString();
				model.NSRMC=ds.Tables[0].Rows[0]["NSRMC"].ToString();
				model.ZSXM=ds.Tables[0].Rows[0]["ZSXM"].ToString();
				model.XB=ds.Tables[0].Rows[0]["XB"].ToString();
				model.SJHM=ds.Tables[0].Rows[0]["SJHM"].ToString();
				model.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				model.SFZHM=ds.Tables[0].Rows[0]["SFZHM"].ToString();
				model.EMAIL=ds.Tables[0].Rows[0]["EMAIL"].ToString();
				model.YZBM=ds.Tables[0].Rows[0]["YZBM"].ToString();
				model.DZ=ds.Tables[0].Rows[0]["DZ"].ToString();
				model.TJSJ=ds.Tables[0].Rows[0]["TJSJ"].ToString();
                model.DLSJ = ds.Tables[0].Rows[0]["DLSJ"].ToString();
                model.DLZT = ds.Tables[0].Rows[0]["DLZT"].ToString();
                model.DLCS = ds.Tables[0].Rows[0]["DLCS"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DLZH,DLMM,NSRSBH,CWJSBM,NSRMC,ZSXM,XB,SJHM,QQ,SFZHM,EMAIL,YZBM,DZ,TJSJ,DLSJ,DLZT,DLCS ");
			strSql.Append(" FROM UserInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SQLiteHelper.ExecuteDataSet(strSql.ToString());
		}


		#endregion  ��Ա����

	}
}

