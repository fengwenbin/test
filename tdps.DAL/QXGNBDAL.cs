using System;
using System.Collections.Generic;
using System.Text;
using tdps.DBUtility;
using tdps.Model;
using System.Data.SQLite;

namespace tdps.DAL
{
    public partial class QXGNBDAL
    {
        public QXGNBDAL()
        { }

        public bool SFCZ(string _qxbh, string _gnbh)
        {
            string _str = "select bh from QXGNB where GNBH='" + _gnbh + "' and QXBH='" + _qxbh+"'";
            if (SQLiteHelper.ExecuteDataSet(_str).Tables[0].Rows != null && SQLiteHelper.ExecuteDataSet(_str).Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool BC(List<QXGNB> _list, string _userName)
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
                            string _insertSql = "insert into QXGNB(GNBH,QXBH,CJR,CJSJ,XGR,XGSJ) values('" + _list[i].GNBH + "','"
                                + _list[i].QXBH + "','" + _userName + "','"
                                + DateTime.Now.Date.ToString() + "','" + _userName + "','" + DateTime.Now.Date.ToString() + "')";

                            if (SQLiteHelper.ExecuteSqlTran(conn, tran, _insertSql) > 0)
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
                            string _deleteSql = "delete from QXGNB where GNBH = '" + _list[i].GNBH + "' and QXBH = '" + _list[i].QXBH + "'";

                            if (SQLiteHelper.ExecuteSqlTran(conn, tran, _deleteSql) > 0)
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
        }

        //根据登录帐号查询，登录帐号是否具有某个功能
        public bool SFJYGN(string _gnbh,string _dlzh)
        {
            string str = "SELECT ui.DLZH,g.GNMC FROM UserInfo ui,USERQXB uq,QXGNB q,GNMKB g"
                +" where ui.DLZH = uq.DLZH" 
                +" and uq.QXBM = q.QXBH"
                +" and q.GNBH = g.GNBH"
                + " and g.GNBH = '" + _gnbh + "'"
                + " and ui.DLZH = '" + _dlzh + "'";

            if (SQLiteHelper.ExecuteDataSet(str).Tables[0].Rows != null && SQLiteHelper.ExecuteDataSet(str).Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
