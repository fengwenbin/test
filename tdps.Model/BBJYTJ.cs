using System;
using System.Collections.Generic;
using System.Text;

namespace tdps.Model
{
    public class BBJYTJ
    {
        #region Model
        private string _nsrsbh;
        private string _sbzlcode;
        private string _ssqq;
        private string _ssqz;
        private string _jylxcode;
        private int _jylxcount;
        private int _sbxxid;
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string NSRSBH
        {
            set { _nsrsbh = value; }
            get { return _nsrsbh; }
        }
        /// <summary>
        /// 申报种类CODE
        /// </summary>
        public string SBZLCODE
        {
            set { _sbzlcode = value; }
            get { return _sbzlcode; }
        }
        /// <summary>
        /// 所属期起
        /// </summary>
        public string SSQQ
        {
            get { return _ssqq; }
            set { _ssqq = value; }
        }
        /// <summary>
        /// 所属期止
        /// </summary>
        public string SSQZ
        {
            get { return _ssqz; }
            set { _ssqz = value; }
        }
        /// <summary>
        /// 校验类型CODE
        /// </summary>
        public string JYLXCODE
        {
            get { return _jylxcode; }
            set { _jylxcode = value; }
        }
        /// <summary>
        /// 校验类型次数
        /// </summary>
        public int JYLXCOUNT
        {
            get { return _jylxcount; }
            set { _jylxcount = value; }
        }
        /// <summary>
        /// 申报信息ID
        /// </summary>
        public int SBXXID
        {
            get { return _sbxxid; }
            set { _sbxxid = value; }
        }
        #endregion Model

    }
}
