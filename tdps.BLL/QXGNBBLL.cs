using System;
using System.Collections.Generic;
using System.Text;
using tdps.Model;

namespace tdps.BLL
{
    public partial class QXGNBBLL
    {

        private readonly tdps.DAL.QXGNBDAL dal = new tdps.DAL.QXGNBDAL();
        public QXGNBBLL()
        { }

        public bool SFCZ(string _gnbh, string _qxbh)
        {
            return dal.SFCZ(_qxbh, _gnbh);
        }

        public bool BCXX(List<QXGNB> _list, string _userName)
        {
            return dal.BC(_list, _userName);
        }

        //登录帐号是否具有此功能
        public bool SFJYGN(string _dlzh, string _gnbh)
        {
            return dal.SFJYGN(_gnbh, _dlzh);
        }   
    }
}
