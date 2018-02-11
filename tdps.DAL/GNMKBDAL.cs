using System;
using System.Collections.Generic;
using System.Text;
using tdps.DBUtility;
using System.Data;
using System.Data.SQLite;
using tdps.Model;

namespace tdps.DAL
{
    /// <summary>
    /// 数据访问类GNMKBDAL。
    /// </summary>
    public partial class GNMKBDAL
    {
        public GNMKBDAL()
        { }


        /// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(tdps.Model.GNMKB model)
        {
            string _sql = "update GNMKB set "
                + " GNMC = '" + model.GNMC + "'"
                + " SJ = '" + model.SJ + "'"
                + " SFKY = " + model.SFKY
                + " SFBX = " + model.SFBX
                + " SWJGT = " + model.SWJGT
                + " where GNBH='" + model.GNBH + "' and NSRSBH = '" + model.NSRSBH + "'";
            return SQLiteHelper.ExecuteSql(_sql);
        }
        
        ///
        public bool UpdateList(List<tdps.Model.GNMKB> _list)
        {
            SQLiteConnection conn = null;
            SQLiteTransaction tran = null;
            try
            {
                if (_list != null && _list.Count > 0)
                {
                    conn = new SQLiteConnection(SQLiteHelper.connectionString);
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();
                    //开启事务
                    tran = conn.BeginTransaction();
                    for (int i = 0; i < _list.Count; i++)
                    {
                        if (_list[i].CZLX.Equals("1"))
                        {
                            StringBuilder _sql = new StringBuilder();
                            _sql.Append("update GNMKB set ");
                            _sql.Append(" SFKY=" + (_list[i].SFKY.Trim().Length > 0 ? _list[i].SFKY.Trim() : "SFKY"));
                            _sql.Append(",SJ=" + (_list[i].SJ.Trim().Length > 0 ? "'" + _list[i].SJ.Trim() + "'" : "SJ"));
                            _sql.Append(",SFBX=" + (_list[i].SFBX.Trim().Length > 0 ? _list[i].SFBX.Trim() : "SFBX"));
                            _sql.Append(",SWJGT=" + (_list[i].SWJGT.Trim().Length > 0 ? _list[i].SWJGT.Trim() : "SWJGT"));
                            _sql.Append(" where GNBH='" + _list[i].GNBH + "' and NSRSBH = '" + _list[i].NSRSBH + "'"); ;
                                
                            if (SQLiteHelper.ExecuteSqlTran(conn, tran, _sql.ToString()) > 0)
                            {
                                continue;
                            }
                            else
                            {
                                tran.Rollback();
                                return false;
                            }
                        }
                        else if (_list[i].CZLX.Equals("0"))
                        {
                            string strSql = "insert into GNMKB(GNMC,SJ,GNBH,NSRSBH) VALUES('" + _list[i].GNMC + "','" + _list[i].SJ + "','" + _list[i].GNBH + "','" + _list[i].NSRSBH + "')";

                            if (SQLiteHelper.ExecuteSqlTran(conn, tran, strSql) > 0)
                            {
                                continue;
                            }
                            else
                            {
                                tran.Rollback();
                                return false;
                            }
                        }
                    }


                }
                else
                {
                    tran.Rollback();
                    return false;
                }
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct ID,GNMC,SJ,SFKY,CASE WHEN (select count(QXGNB.bh) from QXGNB where QXGNB.GNBH = GNMKB.GNBH and QXGNB.SFBX = 1) > 0 THEN 1 ELSE 0 END as SFBX,SWJGT,GNBH ");
            strSql.Append(" FROM GNMKB ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return SQLiteHelper.ExecuteDataSet(strSql.ToString());
        }

        /// <summary>
        /// 验证功能信息是否存在
        /// </summary>
        /// <param name="gnbh"></param>
        /// <returns></returns>
        public bool SFCZ(string gnbh,string nsrsbh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(ID) from GNMKB ");
            if (gnbh != null && gnbh.Trim().Length > 0)
            {
                strSql.Append(" where GNBH='" + gnbh + "'");
                strSql.Append(" and NSRSBH='" + nsrsbh + "'");
            }

            if (SQLiteHelper.ExecuteDataSet(strSql.ToString()) != null)
            {
                int rowCount = Convert.ToInt32(SQLiteHelper.ExecuteDataSet(strSql.ToString()).Tables[0].Rows[0][0]);

                if (rowCount > 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 新增功能模块
        /// </summary>
        /// <param name="gn"></param>
        /// <returns></returns>
        public int XZGN(GNMKB gn)
        {
            if (gn != null)
            {
                string strSql = "insert into GNMKB(GNMC,SJ,GNBH,NSRSBH) VALUES('" + gn.GNMC + "','" + gn.SJ + "','" + gn.GNBH + "','" + gn .NSRSBH+ "')";

                return SQLiteHelper.ExecuteSql(strSql);
            }
            return 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.GNMKB GetModel(string gnbh,string nsrsbh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,GNMC,SJ,SFKY,SFBX,SWJGT,GNBH,NSRSBH from GNMKB ");
            strSql.Append(" where gnbh=@gnbh and nsrsbh=@nsrsbh");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@gnbh", DbType.String,4),
                    new SQLiteParameter("@nsrsbh", DbType.String,20)};
            parameters[0].Value = gnbh;
            parameters[1].Value = nsrsbh;

            tdps.Model.GNMKB model = new tdps.Model.GNMKB();
            DataSet ds = SQLiteHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                //{
                    model.ID = ds.Tables[0].Rows[0]["ID"].ToString();
                //}
                model.GNMC = ds.Tables[0].Rows[0]["GNMC"].ToString();
                model.SJ = ds.Tables[0].Rows[0]["SJ"].ToString();
                model.SFKY = ds.Tables[0].Rows[0]["SFKY"].ToString();
                model.SFBX = ds.Tables[0].Rows[0]["SFBX"].ToString();
                model.SWJGT = ds.Tables[0].Rows[0]["SWJGT"].ToString();
                model.GNBH = ds.Tables[0].Rows[0]["GNBH"].ToString();
                model.NSRSBH = ds.Tables[0].Rows[0]["NSRSBH"].ToString();
                //if (ds.Tables[0].Rows[0]["SFKY"].ToString() != "")
                //{
                //    if ((ds.Tables[0].Rows[0]["SFKY"].ToString() == "1") || (ds.Tables[0].Rows[0]["SFKY"].ToString().ToLower() == "true"))
                //    {
                //        model.SFKY = "1";
                //    }
                //    else
                //    {
                //        model.SFKY = "0";
                //    }
                //}
                //if (ds.Tables[0].Rows[0]["SFBX"].ToString() != "")
                //{
                //    if ((ds.Tables[0].Rows[0]["SFBX"].ToString() == "1") || (ds.Tables[0].Rows[0]["SFBX"].ToString().ToLower() == "true"))
                //    {
                //        model.SFBX = "1";
                //    }
                //    else
                //    {
                //        model.SFBX = "0";
                //    }
                //}
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
