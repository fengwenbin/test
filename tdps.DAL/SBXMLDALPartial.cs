using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using tdps.DBUtility;
using tdps.Model;
namespace tdps.DAL
{
    public partial class SBXMLDAL
    {
        public static string SHXYDM;
        public static string NSRSBH;

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.SBXML model, object trans)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("insert into SBXML(");
            strSql.Append("SBXXID,FileName,SBXMLData)");
            strSql.Append(" values (");
            strSql.Append("@SBXXID,@FileName,@SBXMLData)");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@SBXXID", DbType.Int32,4),
                    new SQLiteParameter("@FileName", DbType.String,200),
                    new SQLiteParameter("@SBXMLData", DbType.String)};
            parameters[0].Value = model.SBXXID;
            parameters[1].Value = model.FileName;
            parameters[2].Value = RefactoringXMLData(model.SBXMLData, model.FileName);
            //var tag = new object();
            //RefactoringXMLData(tag);
            //string xmlPath = string.Format("{0}\\xml\\{0}", "");
            //CreateXMLFile(tag, xmlPath);
            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        private string RefactoringXMLData(string xmlData, string fileName)
        {

            string rtValue = string.Empty;

            //如果有社会信用代码，则需要将报表数据公共头里面的税号用社会信用代码进行替换
            if (!string.IsNullOrEmpty(SBXMLDAL.SHXYDM) && SHXYDM != NSRSBH)
            {
                if (fileName == "10431_005")
                {
                    rtValue = xmlData;
                }
                else
                {
                    byte[] outputb = Convert.FromBase64String(xmlData);
                    string orgStr = Encoding.Default.GetString(outputb);

                    var reg = new System.Text.RegularExpressions.Regex("publicHead>.*?<.*?nsrsbh[^>]*?>(.*?)</.*?nsrsbh>.*?</.*?publicHead>",System.Text.RegularExpressions.RegexOptions.Singleline);
                    orgStr = reg.Replace(orgStr, (m) =>
                    {
                        return m.Value.Replace(m.Groups[1].Value, SBXMLDAL.SHXYDM);
                    });
                    byte[] bytes = Encoding.Default.GetBytes(orgStr);
                    rtValue = Convert.ToBase64String(bytes);
                }
            }
            else
            {
                rtValue = xmlData;
            }

            return rtValue;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID, string FileName, object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SBXML ");
            strSql.Append(" where SBXXID=@SBXXID and FileName=@FileName ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@SBXXID", DbType.Int32,4),
                    new SQLiteParameter("@FileName", DbType.String,50)};
            parameters[0].Value = SBXXID;
            parameters[1].Value = FileName;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }

        /// <summary>
        /// 删除多条数据
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SBXML ");
            strSql.Append(" where SBXXID=@SBXXID ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@SBXXID", DbType.Int32,4)};
            parameters[0].Value = SBXXID;

            SQLiteHelper.ExecuteNonQueryByTransaction(strSql.ToString(), (SQLiteTransaction)trans, parameters);
        }
        /// <summary>
        /// 根据sql语句查询一条填报数据信息
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>报表数据信息对象</returns>
        public SBXML GetModelBySql(string sql)
        {
            SBXML model = null;

            using (IDataReader dr = SQLiteHelper.ExecuteReader(sql))
            {
                if (dr.Read())
                {
                    model = new SBXML();
                    model.SBXXID = Convert.ToInt32(dr["sbxxid"].ToString());
                    model.FileName = dr["fileName"].ToString();
                    model.SBXMLData = dr["SBXMLData"].ToString();
                }
            }
            return model;
        }
    }
}
