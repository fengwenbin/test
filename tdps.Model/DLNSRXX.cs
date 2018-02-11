using System;
using System.Collections.Generic;
using System.Text;

namespace tdps.Model
{
    public class DLNSRXX
    {
        #region Model
        private string _nsrsbh;
        private string _dlzh;
        private NSRXX _nsrxx;
        /// <summary>
        /// 登录账号
        /// </summary>
        public string DLZH
        {
            set { _dlzh = value; }
            get { return _dlzh; }
        }
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string NSRSBH
        {
            set { _nsrsbh = value; }
            get { return _nsrsbh; }
        }
        public NSRXX NSRXX
        {
            get { return _nsrxx; }
            set { _nsrxx = value; }
        }
        #endregion Model

    }
}
