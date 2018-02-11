using System;
using System.Collections.Generic;
using System.Text;
using tdpsclient.common;
using tdps.Model;
using AxCELL50Lib;
using tdps.BLL;
using System.IO;
using tdps._20201._001;
using System.Data.SQLite;
using tdps.DBUtility;
using tdps._20201._002;
using tdps._20201._003;
using tdps._20201._004;
using tdps._20201._005;
using tdps._20201._006;
using tdps._20201._007;

namespace tdps._20201
{
    /// <summary>
    /// 报表操作类，用来执行验证报表数据和保存报表数据的方法。
    /// </summary>
    public class ReportOperation : ReportOperationBase
    {
        private static _DCell2000Events_ButtonCellClickedEventHandler buttonCellClicked = new _DCell2000Events_ButtonCellClickedEventHandler(ReportOperation_ButtonCellClicked);

        /// <summary>
        /// 验证报表数据，如存在问题则将验证结果添加到ValidateInfo集合中。
        /// </summary>
        /// <param name="_valInfoList">验证信息集合</param>
        /// <returns>验证结果，true:通过，false:不通过</returns>
        public override bool ValidateData(ref IList<SBBYZXX> _valInfoList)
        {
            bool validateResult = true;
            SBBYZXX errorInfo = null;

            //在这里可以直接获取父类中设置的属性值。
            //this.Cell报表对象
            //this.SBZL;申报种类
            //this.SSQ_Q;所属期起
            //this.SSQ_Z;所属期止
            if (this.Cell != null)
            {
                AxCell _cell = (AxCell)this.Cell;//获取到报表对象
                int row = 0;

                #region 20201_001数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域内是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "A20201_0_1", "2,3,5,10,11,13,14,15", out row))
                {
                    //验证数据区域内的数据行是否填写完整
                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "A20201_0_1", ref _valInfoList, "1"))
                    //{
                    //    validateResult = false;
                    //}

                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "A20201_0_2", ref _valInfoList, "1"))
                    //{
                    //    validateResult = false;
                    //}
                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "营业税纳税申请表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }
                #endregion

                #endregion

                #region 20201_002数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "A20201_1_1", "2,4,5,7,10,11,15,16", out row))
                {
                    //验证数据区域内的数据行是否填写完整
                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "A20201_1_1", ref _valInfoList, "1"))
                    //{
                    //    validateResult = false;
                    //}
                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "交通运输业营业税纳税申请表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }

                #endregion

                #endregion

                #region 20201_003数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "A20201_2_1", "2,3,5,6,10,11,13,14", out row))
                {
                    //验证数据区域内的数据行是否填写完整
                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "A20201_2_1", ref _valInfoList, "1,2"))
                    //{
                    //    validateResult = false;
                    //}
                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "交通运输业营业税纳税申请表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }

                #endregion

                #endregion

                #region 20201_004数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "A20201_3_1", "2,3,5,6,10,11,13,14", out row))
                {
                    //验证数据区域内的数据行是否填写完整
                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "A20201_3_1", ref _valInfoList, "1,2"))
                    //{
                    //    validateResult = false;
                    //}
                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "交通运输业营业税纳税申请表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }

                #endregion

                #endregion

                #region 20201_005数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "A20201_4_1", "4,5,6,7,8,9,10", out row))
                {

                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "交通运输业营业税纳税申请表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }

                #endregion

                #endregion

                #region 20201_006数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域内是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "A20201_5_2", "2,3,4,5,6,7,8,9,10,11,12,13,14,15,16", out row))
                {

                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "异地提供建筑业劳务税款缴纳情况申报表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }

                #endregion

                #endregion

                #region 20201_007数据验证

                #region 非空验证

                #endregion

                #region 数据行验证

                //验证数据区域是否填写了数据
                if (!ValidateUtil.GetValidateAreaNull(_cell, "20201_6_1", "3,5,6,7,9,10,14,15,17,18,19", out row)
                    && !ValidateUtil.GetValidateAreaNull(_cell, "20201_6_2", "3,5,6,7,9,10,14,15,17,18,19", out row))
                {
                    ////验证数据区域内的数据行是否填写完整
                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "20201_6_1", ref _valInfoList, "1,2,3"))
                    //{
                    //    validateResult = false;
                    //}

                    //if (!ValidateUtil.GetValidateRowIsFull(_cell, "20201_6_2", ref _valInfoList, "1,2,3"))
                    //{
                    //    validateResult = false;
                    //}
                }
                else
                {
                    validateResult = false;

                    errorInfo = new SBBYZXX();
                    errorInfo.ErrorContent = "建筑业营业税纳税申报表至少需要填写一行数据！";
                    _valInfoList.Add(errorInfo);
                }

                #endregion

                #endregion

                return validateResult;
            }
            else
            {
                errorInfo = new SBBYZXX();
                errorInfo.ErrorContent = "未获取到表格对象，程序错误。";
                _valInfoList.Add(errorInfo);
                return false;
            }

            
        }
        /// <summary>
        /// 保存报表数据。
        /// </summary>
        /// <param name="_sbxxid">申报信息ID</param>
        /// <returns>验证结果，true:保存成功，false:不成功</returns>
        public override bool SaveData(string _sbxxid)
        {
            SBXXBLL bll = new SBXXBLL(); //申报信息
            SBBYZXXBLL sbbyzbll = new SBBYZXXBLL(); //申报表验证信息
            //保存申报表信息
            //组装申报表对象信息
            SBXX sbxx = new SBXX();
            sbxx.SBXXID = int.Parse(_sbxxid);//申报信息ID
            sbxx = bll.GetModel(sbxx.SBXXID);
            //加一个变量用来判断当前是新增还是修改操作。
            //bool addState = false;
            sbxx.DLZH = GlobalValue.UserName;

            //测试临时屏蔽
            //sbxx.SBZLMC = GlobalValue.GetHDXXSBZL(this.SBZL).SBZLMC;

            AxCell _cell = (AxCell)this.Cell;
            SetWriteDate();
            sbxx.SBBWJ = _cell.SaveToBase64Str();//申报表文件
            sbxx.BBZT = ((int)(this.ValidateList.Count > 0 ? EnumReportState.TX : EnumReportState.DSH)).ToString();//申报表状态
            sbxx.TBSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sbxx.SBSE = decimal.Parse(GetCellDouble(12,24,0).ToString ());

            //执行保存数据表的方法
            using (SQLiteConnection conn = new SQLiteConnection(SQLiteHelper.connectionString))
            {
                SQLiteTransaction sqlTra = null;

                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();
                    sqlTra = conn.BeginTransaction();
                    bll.Update(sbxx, sqlTra);//更新申报记录信息
                    sbbyzbll.Delete(sbxx.SBXXID, sqlTra);//先删除已有验证信息
                    if (this.ValidateList.Count > 0)//如果当前的验证信息不为空，那么认为是既要保存填报信息，还要保存验证信息
                    {
                        //保存验证信息时，采用先删除已有验证信息再插入的方式进行处理

                        for (int i = 0; i < this.ValidateList.Count; i++)
                        {
                            SBBYZXX sbbyzxx = this.ValidateList[i];
                            sbbyzxx.SBXXID = sbxx.SBXXID;
                            sbbyzbll.Add(sbbyzxx, sqlTra);
                        }
                    }
                    else
                    {
                        SBXMLBLL xmlBll = new SBXMLBLL();
                        SBXML _001 = GetXmlBySheet(int.Parse(_sbxxid), "001", _cell);//获得主表数据
                        if (_001 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _001.FileName, sqlTra);//删除报表数据
                            if (_001.SBXMLData != null)
                                xmlBll.Add(_001, sqlTra);//插入报表数据
                        }

                        SBXML _002 = GetXmlBySheet(int.Parse(_sbxxid), "002", _cell);//第二张报表的数据
                        if (_002 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _002.FileName, sqlTra);//删除报表数据
                            if (_002.SBXMLData != null)
                                xmlBll.Add(_002, sqlTra);//插入报表数据
                        }

                        SBXML _003 = GetXmlBySheet(int.Parse(_sbxxid), "003", _cell);//第三张报表的数据
                        if (_003 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _003.FileName, sqlTra);//删除报表数据
                            if (_003.SBXMLData != null)
                                xmlBll.Add(_003, sqlTra);//插入报表数据
                        }

                        SBXML _004 = GetXmlBySheet(int.Parse(_sbxxid), "004", _cell);//第四张报表的数据
                        if (_004 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _004.FileName, sqlTra);//删除报表数据
                            if (_004.SBXMLData != null)
                                xmlBll.Add(_004, sqlTra);//插入报表数据
                        }

                        SBXML _005 = GetXmlBySheet(int.Parse(_sbxxid), "005", _cell);//第五张报表的数据
                        if (_005 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _005.FileName, sqlTra);//删除报表数据
                            xmlBll.Add(_005, sqlTra);//插入报表数据
                        }

                        SBXML _006 = GetXmlBySheet(int.Parse(_sbxxid), "006", _cell);//第五张报表的数据
                        if (_006 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _006.FileName, sqlTra);//删除报表数据
                            if (_004.SBXMLData != null)
                                xmlBll.Add(_006, sqlTra);//插入报表数据
                        }

                        SBXML _007 = GetXmlBySheet(int.Parse(_sbxxid), "007", _cell);//第五张报表的数据
                        if (_007 != null)
                        {
                            xmlBll.Delete(int.Parse(_sbxxid), _007.FileName, sqlTra);//删除报表数据
                            if (_007.SBXMLData != null)
                                xmlBll.Add(_007, sqlTra);//插入报表数据
                        }
                    }

                    sqlTra.Commit();
                }
                catch (Exception ex)
                {
                    sqlTra.Rollback();
                    //MessageBox.Show(ex.Message);
                    throw;
                }
            }

            return true;

        }

        /// <summary>
        /// 根据申报表名称，从cell文件中获取数据并转换成xml文件，取得xml文件中的字符内容。
        /// </summary>
        /// <param name="_sbxxID">申报信息ID</param>
        /// <param name="sheetName">申报表名称</param>
        /// <param name="_cell">华表文件</param>
        /// <returns>已经转换之后的申报表对象</returns>
        private SBXML GetXmlBySheet(int _sbxxID, String sheetName, AxCell _cell)
        {
            bool isSubmit = true;
            SBXML _sbxml = new SBXML();
            double tempValue = 0.00d;
            string xmlPath = string.Format("{0}\\xml\\20201", GlobalValue.TempPath);//临时xml输出路径
            if (!Directory.Exists(xmlPath))
            {
                Directory.CreateDirectory(xmlPath);
            }
            xmlPath = string.Format("{0}\\{1}.xml", xmlPath, sheetName);//生成xml文件的路径

            int sheet, startRow, endRow, startCol, endCol, errorRow;
            sheet = startRow = endRow = startCol = endCol = errorRow = 0;

            switch (sheetName)
            {
                case "001":
                    //设置第一张表的填报内容
                    tdps._20201._001.T_taxML t_taxML01 = new tdps._20201._001.T_taxML();

                    #region 公共表头

                    t_taxML01.sbbYys.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML01.sbbYys.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML01.sbbYys.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML01.sbbYys.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    //t_taxML01.sbbYys.head.publicHead.tbr = _cell.GetCellString(9, 26, 0);//填表人
                    t_taxML01.sbbYys.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(10, 5, 0)).ToString("yyyyMMdd");//填表日期
                    t_taxML01.sbbYys.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_001", _cell.GetCellString(10, 5, 0));//打印密码

                    #endregion

                    #region 私有表头

                    //t_taxML01.sbbYys.head.privateHead.cwfzr="";
                    t_taxML01.sbbYys.head.privateHead.nsrfddbr = _cell.GetCellString(15, 26, 0);//纳税人法定代表人
                    t_taxML01.sbbYys.head.privateHead.nsrlxdh = _cell.GetCellString(18, 26, 0);//纳税人联系电话

                    #endregion

                    #region 报表内容

                    startCol = 1;
                    startRow = 10;
                    endCol = 18;
                    endRow = 20;
                    sheet = 0;
                    int iLC = 0;//栏次

                    IList<tdps._20201._001.T8_ysxm> list_ysxm = new List<tdps._20201._001.T8_ysxm>();
                    IList<tdps._20201._001.T8_ysxm> list_dkdjysxm = new List<tdps._20201._001.T8_ysxm>();

                    #region 应税项目

                    if (_cell.GetAreaVar("A20201_0_1", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        
                        for (int i = startRow; i <= endRow; i++)
                        {
                            string strTempValue = _cell.GetCellString(2, i, 0);

                            if (strTempValue != null && strTempValue.Trim().Length > 0)
                            {
                                tdps._20201._001.T8_ysxm _obj = new tdps._20201._001.T8_ysxm();

                                iLC++;
                                _obj.lc = iLC;
                                ////_obj.ysxmdm = "";//应税项目代码
                                if (i == 15 || i == 16)
                                    _obj.ysxmmc = "娱乐业";
                                else
                                    _obj.ysxmmc = _cell.GetCellString(1, i, 0).Trim().Length > 0 ? _cell.GetCellString(1, i, 0):"";//应税项目名称
                                _obj.jssr = _cell.GetCellString(2, i, 0).Trim().Length > 0 ? GetCellDouble(1, i, 0) : 0.00;//应税收入
                                _obj.jcje = _cell.GetCellString(3, i, 0).Trim().Length > 0 ? GetCellDouble(3, i, 0) : 0.00;//应税减除项目金额
                                _obj.yye = _cell.GetCellString(4, i, 0).Trim().Length > 0 ? GetCellDouble(4, i, 0) : 0.00;//应税营业额
                                _obj.mssr = _cell.GetCellString(5, i, 0).Trim().Length > 0 ? GetCellDouble(5, i, 0) : 0.00;//免税收入
                                _obj.sl = _cell.GetCellString(6, i, 0).Trim().Length > 0 ? GetCellDouble(6, i, 0) : 0.00;//税率
                                _obj.skxj = _cell.GetCellString(7, i, 0).Trim().Length > 0 ? GetCellDouble(7, i, 0) : 0.00;//本期税款小计
                                _obj.ynse = _cell.GetCellString(8, i, 0).Trim().Length > 0 ? GetCellDouble(8, i, 0) : 0.00;//本期应纳税额
                                _obj.mse = _cell.GetCellString(9, i, 0).Trim().Length > 0 ? GetCellDouble(9, i, 0) : 0.00;//免（减）税额
                                _obj.qjse = _cell.GetCellString(10, i, 0).Trim().Length > 0 ? GetCellDouble(10, i, 0) : 0.00;//期初欠缴税额
                                _obj.djse = _cell.GetCellString(11, i, 0).Trim().Length > 0 ? GetCellDouble(11, i, 0) : 0.00;//前期多缴税额
                                _obj.ynsexj = _cell.GetCellString(12, i, 0).Trim().Length > 0 ? GetCellDouble(12, i, 0) : 0.00;//本期已缴税额小计
                                _obj.yjynse = _cell.GetCellString(13, i, 0).Trim().Length > 0 ? GetCellDouble(13, i, 0) : 0.00;//已缴本期应纳税额
                                _obj.ybkjse = _cell.GetCellString(14, i, 0).Trim().Length > 0 ? GetCellDouble(14, i, 0) : 0.00;//本期已被扣缴税额
                                _obj.yjqjse = _cell.GetCellString(15, i, 0).Trim().Length > 0 ? GetCellDouble(15, i, 0) : 0.00;//本期已缴欠缴税额
                                _obj.yjsexj = _cell.GetCellString(16, i, 0).Trim().Length > 0 ? GetCellDouble(16, i, 0) : 0.00;//本期应缴税额小计
                                _obj.qmyjse = _cell.GetCellString(17, i, 0).Trim().Length > 0 ? GetCellDouble(17, i, 0) : 0.00;//本期期末应缴税额
                                _obj.qmyjqjse = _cell.GetCellString(18, i, 0).Trim().Length > 0 ? GetCellDouble(18, i, 0) : 0.00;//本期期末应缴欠缴税额

                                list_ysxm.Add(_obj);
                            }
                        }

                        if (list_ysxm != null && list_ysxm.Count > 0)
                        {
                            tdps._20201._001.T8_ysxm[] arr = new tdps._20201._001.T8_ysxm[list_ysxm.Count];
                            list_ysxm.CopyTo(arr, 0);
                            t_taxML01.sbbYys.body.ysxms.ysxm = arr;
                        }
                        else
                        {
                            isSubmit = false;
                        }
                    }

                    #endregion

                    #region 小计

                    T_taxMLSbbYysBodyYsxmsXjxx _obj_XJ = new T_taxMLSbbYysBodyYsxmsXjxx();

                    _obj_XJ.lc = iLC++;
                    ////_obj_XJ.ysxmdm = "";//应税项目代码
                    _obj_XJ.jssr = _cell.GetCellString(2, 21, 0).Trim().Length > 0 ? GetCellDouble(1, 21, 0) : 0.00;//应税收入
                    _obj_XJ.jcje = _cell.GetCellString(3, 21, 0).Trim().Length > 0 ? GetCellDouble(3, 21, 0) : 0.00;//应税减除项目金额
                    _obj_XJ.yye = _cell.GetCellString(4, 21, 0).Trim().Length > 0 ? GetCellDouble(4, 21, 0) : 0.00;//应税营业额
                    _obj_XJ.mssr = _cell.GetCellString(5, 21, 0).Trim().Length > 0 ? GetCellDouble(5, 21, 0) : 0.00;//免税收入
                    //_obj_XJ.sl = GetCellDouble(6, 21, 0);//税率
                    _obj_XJ.skxj = _cell.GetCellString(7, 21, 0).Trim().Length > 0 ? GetCellDouble(7, 21, 0) : 0.00;//本期税款小计
                    _obj_XJ.ynse = _cell.GetCellString(8, 21, 0).Trim().Length > 0 ? GetCellDouble(8, 21, 0) : 0.00;//本期应纳税额
                    _obj_XJ.mse = _cell.GetCellString(9, 21, 0).Trim().Length > 0 ? GetCellDouble(9, 21, 0) : 0.00;//免（减）税额
                    _obj_XJ.qjse = _cell.GetCellString(10, 21, 0).Trim().Length > 0 ? GetCellDouble(10, 21, 0) : 0.00;//期初欠缴税额
                    _obj_XJ.djse = _cell.GetCellString(11, 21, 0).Trim().Length > 0 ? GetCellDouble(11, 21, 0) : 0.00;//前期多缴税额
                    _obj_XJ.ynsexj = _cell.GetCellString(12, 21, 0).Trim().Length > 0 ? GetCellDouble(12, 21, 0) : 0.00;//本期已缴税额小计
                    _obj_XJ.yjynse = _cell.GetCellString(13, 21, 0).Trim().Length > 0 ? GetCellDouble(13, 21, 0) : 0.00;//已缴本期应纳税额
                    _obj_XJ.ybkjse = _cell.GetCellString(14, 21, 0).Trim().Length > 0 ? GetCellDouble(14, 21, 0) : 0.00;//本期已被扣缴税额
                    _obj_XJ.yjqjse = _cell.GetCellString(15, 21, 0).Trim().Length > 0 ? GetCellDouble(15, 21, 0) : 0.00;//本期已缴欠缴税额
                    _obj_XJ.yjsexj = _cell.GetCellString(16, 21, 0).Trim().Length > 0 ? GetCellDouble(16, 21, 0) : 0.00;//本期应缴税额小计
                    _obj_XJ.qmyjse = _cell.GetCellString(17, 21, 0).Trim().Length > 0 ? GetCellDouble(17, 21, 0) : 0.00;//本期期末应缴税额
                    _obj_XJ.qmyjqjse = _cell.GetCellString(18, 21, 0).Trim().Length > 0 ? GetCellDouble(18, 21, 0) : 0.00;//本期期末应缴欠缴税额

                    t_taxML01.sbbYys.body.ysxms.xjxx = _obj_XJ;

                    #endregion

                    #region 代扣代缴项目

                    for (int i = 22; i <= 23; i++)
                    {
                        string strTempValue = _cell.GetCellString(2, i, 0);

                        if (strTempValue != null && strTempValue.Trim().Length > 0)
                        {
                            iLC++;

                            tdps._20201._001.T8_ysxm _obj = new tdps._20201._001.T8_ysxm();

                            _obj.lc = iLC;
                            ////_obj.ysxmdm = "";//应税项目代码
                            _obj.ysxmmc = _cell.GetCellString(1, i, 0).Trim().Length > 0 ? _cell.GetCellString(1, i, 0) : "";//应税项目名称
                            _obj.jssr = _cell.GetCellString(2, i, 0).Trim().Length > 0 ? GetCellDouble(2, i, 0) : 0.00;//应税收入
                            _obj.jcje = _cell.GetCellString(3, i, 0).Trim().Length > 0 ? GetCellDouble(3, i, 0) : 0.00;//应税减除项目金额
                            _obj.yye = _cell.GetCellString(4, i, 0).Trim().Length > 0 ? GetCellDouble(4, i, 0) : 0.00;//应税营业额
                            _obj.mssr = _cell.GetCellString(5, i, 0).Trim().Length > 0 ? GetCellDouble(5, i, 0) : 0.00;//免税收入
                            _obj.sl = _cell.GetCellString(6, i, 0).Trim().Length > 0 ? GetCellDouble(6, i, 0) : 0.00;//税率
                            _obj.skxj = _cell.GetCellString(7, i, 0).Trim().Length > 0 ? GetCellDouble(7, i, 0) : 0.00;//本期税款小计
                            _obj.ynse = _cell.GetCellString(8, i, 0).Trim().Length > 0 ? GetCellDouble(8, i, 0) : 0.00;//本期应纳税额
                            _obj.mse = _cell.GetCellString(9, i, 0).Trim().Length > 0 ? GetCellDouble(9, i, 0) : 0.00;//免（减）税额
                            _obj.qjse = _cell.GetCellString(10, i, 0).Trim().Length > 0 ? GetCellDouble(10, i, 0) : 0.00;//期初欠缴税额
                            _obj.djse = _cell.GetCellString(11, i, 0).Trim().Trim().Length > 0 ? GetCellDouble(11, i, 0) : 0.00;//前期多缴税额
                            _obj.ynsexj = _cell.GetCellString(12, i, 0).Trim().Length > 0 ? GetCellDouble(12, i, 0) : 0.00;//本期已缴税额小计
                            _obj.yjynse = _cell.GetCellString(13, i, 0).Trim().Length > 0 ? GetCellDouble(13, i, 0) : 0.00;//已缴本期应纳税额
                            _obj.ybkjse = _cell.GetCellString(14, i, 0).Trim().Length > 0 ? GetCellDouble(14, i, 0) : 0.00;//本期已被扣缴税额
                            _obj.yjqjse = _cell.GetCellString(15, i, 0).Trim().Length > 0 ? GetCellDouble(15, i, 0) : 0.00;//本期已缴欠缴税额
                            _obj.yjsexj = _cell.GetCellString(16, i, 0).Trim().Length > 0 ? GetCellDouble(16, i, 0) : 0.00;//本期应缴税额小计
                            _obj.qmyjse = _cell.GetCellString(17, i, 0).Trim().Length > 0 ? GetCellDouble(17, i, 0) : 0.00;//本期期末应缴税额
                            _obj.qmyjqjse = _cell.GetCellString(18, i, 0).Trim().Length > 0 ? GetCellDouble(18, i, 0) : 0.00;//本期期末应缴欠缴税额

                            list_dkdjysxm.Add(_obj);
                        }
                    }

                    if (list_dkdjysxm != null && list_dkdjysxm.Count > 0)
                    {
                        tdps._20201._001.T8_ysxm[] arr = new tdps._20201._001.T8_ysxm[list_dkdjysxm.Count];
                        list_dkdjysxm.CopyTo(arr, 0);
                        t_taxML01.sbbYys.body.ysxms.dkdjysxm = arr;
                    }

                    #endregion

                    #endregion

                    #region 合计

                    T_taxMLSbbYysBodyHjxx _obj_HJ = new T_taxMLSbbYysBodyHjxx();

                    _obj_HJ.lc = iLC++;
                    ////_obj_HJ.ysxmdm = "";//应税项目代码
                    _obj_HJ.jssr = _cell.GetCellString(2, 21, 0).Trim().Length > 0 ? GetCellDouble(2, 21, 0) : 0.00;//应税收入
                    _obj_HJ.jcje = _cell.GetCellString(3, 21, 0).Trim().Length > 0 ? GetCellDouble(3, 21, 0) : 0.00;//应税减除项目金额
                    _obj_HJ.yye = _cell.GetCellString(4, 21, 0).Trim().Length > 0 ? GetCellDouble(4, 21, 0) : 0.00;//应税营业额
                    _obj_HJ.mssr = _cell.GetCellString(5, 21, 0).Trim().Length > 0 ? GetCellDouble(5, 21, 0) : 0.00;//免税收入
                    //_obj_XJ.sl = GetCellDouble(6, 21, 0);//税率
                    _obj_HJ.skxj = _cell.GetCellString(7, 21, 0).Trim().Length > 0 ? GetCellDouble(7, 21, 0) : 0.00;//本期税款小计
                    _obj_HJ.ynse = _cell.GetCellString(8, 21, 0).Trim().Length > 0 ? GetCellDouble(8, 21, 0) : 0.00;//本期应纳税额
                    _obj_HJ.mse = _cell.GetCellString(9, 21, 0).Trim().Length > 0 ? GetCellDouble(9, 21, 0) : 0.00;//免（减）税额
                    _obj_HJ.qjse = _cell.GetCellString(10, 21, 0).Trim().Length > 0 ? GetCellDouble(10, 21, 0) : 0.00;//期初欠缴税额
                    _obj_HJ.djse = _cell.GetCellString(11, 21, 0).Trim().Length > 0 ? GetCellDouble(11, 21, 0) : 0.00;//前期多缴税额
                    _obj_HJ.ynsexj = _cell.GetCellString(12, 21, 0).Trim().Length > 0 ? GetCellDouble(12, 21, 0) : 0.00;//本期已缴税额小计
                    _obj_HJ.yjynse = _cell.GetCellString(13, 21, 0).Trim().Length > 0 ? GetCellDouble(13, 21, 0) : 0.00;//已缴本期应纳税额
                    _obj_HJ.ybkjse = _cell.GetCellString(14, 21, 0).Trim().Length > 0 ? GetCellDouble(14, 21, 0) : 0.00;//本期已被扣缴税额
                    _obj_HJ.yjqjse = _cell.GetCellString(15, 21, 0).Trim().Length > 0 ? GetCellDouble(15, 21, 0) : 0.00;//本期已缴欠缴税额
                    _obj_HJ.yjsexj = _cell.GetCellString(16, 21, 0).Trim().Length > 0 ? GetCellDouble(16, 21, 0) : 0.00;//本期应缴税额小计
                    _obj_HJ.qmyjse = _cell.GetCellString(17, 21, 0).Trim().Length > 0 ? GetCellDouble(17, 21, 0) : 0.00;//本期期末应缴税额
                    _obj_HJ.qmyjqjse = _cell.GetCellString(18, 21, 0).Trim().Length > 0 ? GetCellDouble(18, 21, 0) : 0.00;//本期期末应缴欠缴税额

                    t_taxML01.sbbYys.body.hjxx = _obj_HJ;

                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML01, xmlPath);//生成xml文件

                    break;

                case "002":
                    //设置第二张报表的填报内容
                    tdps._20201._002.T_taxML t_taxML02 = new tdps._20201._002.T_taxML();

                    #region 公共表头

                    t_taxML02.sbbJtysyyys.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML02.sbbJtysyyys.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML02.sbbJtysyyys.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML02.sbbJtysyyys.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    t_taxML02.sbbJtysyyys.head.publicHead.tbr = "";
                    t_taxML02.sbbJtysyyys.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(11, 5, 1)).ToString("yyyyMMdd");//填表日期
                    t_taxML02.sbbJtysyyys.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_002", _cell.GetCellString(11, 5, 1));//打印密码

                    #endregion

                    #region 私有表头

                    //没有私有表头

                    #endregion

                    #region 填报内容

                    int iLC2 = 1;//栏次
                    startCol = startRow = endCol = endRow = sheet = 0;
                    IList<T_taxMLSbbJtysyyysBodyYsxm> list_ysxm2=new List<T_taxMLSbbJtysyyysBodyYsxm>();

                    if (_cell.GetAreaVar("A20201_1_1", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        for (int i = startRow; i <= endRow; i++)
                        {
                            string strTempValue = _cell.GetCellString(2, i, 1);

                            if (strTempValue != null && strTempValue.Trim().Length > 0)
                            {
                                T_taxMLSbbJtysyyysBodyYsxm _obj = new T_taxMLSbbJtysyyysBodyYsxm();

                                iLC2++;
                                _obj.lc = iLC2;
                                _obj.ysxmdm = "0";
                                _obj.ysxmmc = _cell.GetCellString(1, i, sheet).Trim().Length > 0 ? _cell.GetCellString(1, i, sheet) : "";
                                _obj.jssr = _cell.GetCellString(2, i, sheet).Trim().Length > 0 ? GetCellDouble(2, i, sheet) : 0.00;
                                _obj.jcjexj = _cell.GetCellString(3, i, sheet).Trim().Length > 0 ? GetCellDouble(3, i, sheet) : 0.00;
                                _obj.zfhzfje = _cell.GetCellString(4, i, sheet).Trim().Length > 0 ? GetCellDouble(4, i, sheet) : 0.00;
                                _obj.qtjcje = _cell.GetCellString(5, i, sheet).Trim().Length > 0 ? GetCellDouble(5, i, sheet) : 0.00;
                                _obj.yye = _cell.GetCellString(6, i, sheet).Trim().Length > 0 ? GetCellDouble(6, i, sheet) : 0.00;
                                _obj.mssr = _cell.GetCellString(7, i, sheet).Trim().Length > 0 ? GetCellDouble(7, i, sheet) : 0.00;
                                _obj.sl = _cell.GetCellString(8, i, sheet).Trim().Length > 0 ? GetCellDouble(8, i, sheet) : 0.00;
                                _obj.skxj = _cell.GetCellString(9, i, sheet).Trim().Length > 0 ? GetCellDouble(9, i, sheet) : 0.00;
                                _obj.ynse = _cell.GetCellString(10, i, sheet).Trim().Length > 0 ? GetCellDouble(10, i, sheet) : 0.00;
                                _obj.mse = _cell.GetCellString(11, i, sheet).Trim().Length > 0 ? GetCellDouble(11, i, sheet) : 0.00;
                                _obj.qjse = _cell.GetCellString(12, i, sheet).Trim().Length > 0 ? GetCellDouble(12, i, sheet) : 0.00;
                                _obj.djse = _cell.GetCellString(13, i, sheet).Trim().Length > 0 ? GetCellDouble(13, i, sheet) : 0.00;
                                _obj.ynsexj = _cell.GetCellString(14, i, sheet).Trim().Length > 0 ? GetCellDouble(14, i, sheet) : 0.00;
                                _obj.yjynse = _cell.GetCellString(15, i, sheet).Trim().Length > 0 ? GetCellDouble(15, i, sheet) : 0.00;
                                _obj.yjqjse = _cell.GetCellString(16, i, sheet).Trim().Length > 0 ? GetCellDouble(16, i, sheet) : 0.00;
                                _obj.yjsexj = _cell.GetCellString(17, i, sheet).Trim().Length > 0 ? GetCellDouble(17, i, sheet) : 0.00;
                                _obj.qmyjse = _cell.GetCellString(18, i, sheet).Trim().Length > 0 ? GetCellDouble(18, i, sheet) : 0.00;
                                _obj.qmyjqjse = _cell.GetCellString(19, i, sheet).Trim().Length > 0 ? GetCellDouble(19, i, sheet) : 0.00;

                                list_ysxm2.Add(_obj);
                            }
                        }

                        if (list_ysxm2 != null && list_ysxm2.Count > 0)
                        {
                            T_taxMLSbbJtysyyysBodyYsxm[] arr = new T_taxMLSbbJtysyyysBodyYsxm[list_ysxm2.Count];
                            list_ysxm2.CopyTo(arr, 0);
                            t_taxML02.sbbJtysyyys.body.ysxms = arr;
                        }
                        else
                        {
                            isSubmit = false;
                        }
                    }

                    #endregion

                    #region 合计

                    T_taxMLSbbJtysyyysBodyHjxx _obj_HJ2 = new T_taxMLSbbJtysyyysBodyHjxx();

                    //_obj_HJ2.lc=;
                    _obj_HJ2.jssr = _cell.GetCellString(2, 24, 1).Trim().Length > 0 ? GetCellDouble(2, 24, 1) : 0.00;
                    _obj_HJ2.jcjexj = _cell.GetCellString(3, 24, 1).Trim().Length > 0 ? GetCellDouble(3, 24, 1) : 0.00;
                    _obj_HJ2.zfhzfje = _cell.GetCellString(4, 24, 1).Trim().Length > 0 ? GetCellDouble(4, 24, 1) : 0.00;
                    _obj_HJ2.qtjcje = _cell.GetCellString(5, 24, 1).Trim().Length > 0 ? GetCellDouble(5, 24, 1) : 0.00;
                    _obj_HJ2.yye = _cell.GetCellString(6, 24, 1).Trim().Length > 0 ? GetCellDouble(6, 24, 1) : 0.00;
                    _obj_HJ2.mssr = _cell.GetCellString(7, 24, 1).Trim().Length > 0 ? GetCellDouble(7, 24, 1) : 0.00;
                    //_obj_HJ2.sl=;
                    _obj_HJ2.skxj = _cell.GetCellString(9, 24, 1).Trim().Length > 0 ? GetCellDouble(9, 24, 1) : 0.00;
                    _obj_HJ2.ynse = _cell.GetCellString(10, 24, 1).Trim().Length > 0 ? GetCellDouble(10, 24, 1) : 0.00;
                    _obj_HJ2.mse = _cell.GetCellString(11, 24, 1).Trim().Length > 0 ? GetCellDouble(11, 24, 1) : 0.00;
                    _obj_HJ2.qjse = _cell.GetCellString(12, 24, 1).Trim().Length > 0 ? GetCellDouble(12, 24, 1) : 0.00;
                    _obj_HJ2.djse = _cell.GetCellString(13, 24, 1).Trim().Length > 0 ? GetCellDouble(13, 24, 1) : 0.00;
                    _obj_HJ2.ynsexj = _cell.GetCellString(14, 24, 1).Trim().Length > 0 ? GetCellDouble(14, 24, 1) : 0.00;
                    _obj_HJ2.yjynse = _cell.GetCellString(15, 25, 1).Trim().Length > 0 ? GetCellDouble(15, 25, 1) : 0.00;
                    _obj_HJ2.yjqjse = _cell.GetCellString(16, 25, 1).Trim().Length > 0 ? GetCellDouble(16, 25, 1) : 0.00;
                    _obj_HJ2.yjsexj = _cell.GetCellString(17, 25, 1).Trim().Length > 0 ? GetCellDouble(17, 25, 1) : 0.00;
                    _obj_HJ2.qmyjse = _cell.GetCellString(18, 25, 1).Trim().Length > 0 ? GetCellDouble(18, 25, 1) : 0.00;
                    _obj_HJ2.qmyjqjse = _cell.GetCellString(19, 25, 1).Trim().Length > 0 ? GetCellDouble(19, 25, 1) : 0.00;

                    t_taxML02.sbbJtysyyys.body.hjxx = _obj_HJ2;

                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML02, xmlPath);//生成xml文件

                    break;
                case "003":
                    //设置第三张报表的填报内容
                    tdps._20201._003.T_taxML t_taxML03 = new tdps._20201._003.T_taxML();

                    #region 公共表头

                    t_taxML03.sbbYlyyys.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML03.sbbYlyyys.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML03.sbbYlyyys.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML03.sbbYlyyys.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    t_taxML03.sbbYlyyys.head.publicHead.tbr = "";
                    t_taxML03.sbbYlyyys.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(8, 5, 2)).ToString("yyyyMMdd");//填表日期
                    t_taxML03.sbbYlyyys.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_003", _cell.GetCellString(8, 5, 2));//打印密码

                    #endregion

                    #region 私有表头
                    
                    //没有

                    #endregion

                    #region 填报内容

                    startCol = startRow = endCol = endRow = sheet = 0;
                    IList<T_taxMLSbbYlyyysBodyYsxm> list_ysxm3 = new List<T_taxMLSbbYlyyysBodyYsxm>();

                    if (_cell.GetAreaVar("A20201_2_1", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        for (int i = startRow; i <= endRow; i++)
                        {
                            string strTempValue = _cell.GetCellString(3, i, 1);

                            if (strTempValue != null && strTempValue.Trim().Length > 0)
                            {
                                T_taxMLSbbYlyyysBodyYsxm _obj = new T_taxMLSbbYlyyysBodyYsxm();

                                //_obj.lc=;
                                _obj.ysxmdm = "0";
                                if (i >= 12 && i <= 15)
                                    _obj.ysxmmc = "卡拉OK歌舞厅";
                                else if (i >= 16 && i <= 18)
                                    _obj.ysxmmc = "音乐、茶座";
                                else if (i >= 21 && i <= 24)
                                    _obj.ysxmmc = "游艺场";
                                else if (i >= 26 && i <= 27)
                                    _obj.ysxmmc = "其他";
                                else
                                    _obj.ysxmmc = _cell.GetCellString(1, i, sheet).Trim().Length > 0 ? _cell.GetCellString(1, i, sheet) : "";

                                _obj.jssr = _cell.GetCellString(3, i, sheet).Trim().Length > 0 ? GetCellDouble(3, i, sheet) : 0.00;
                                _obj.jcje = _cell.GetCellString(4, i, sheet).Trim().Length > 0 ? GetCellDouble(4, i, sheet) : 0.00;
                                _obj.yye = _cell.GetCellString(5, i, sheet).Trim().Length > 0 ? GetCellDouble(5, i, sheet) : 0.00;
                                _obj.mssr = _cell.GetCellString(6, i, sheet).Trim().Length > 0 ? GetCellDouble(6, i, sheet) : 0.00;
                                _obj.sl = _cell.GetCellString(7, i, sheet).Trim().Length > 0 ? GetCellDouble(7, i, sheet) : 0.00;
                                _obj.skxj = _cell.GetCellString(8, i, sheet).Trim().Length > 0 ? GetCellDouble(8, i, sheet) : 0.00;
                                _obj.ynse = _cell.GetCellString(9, i, sheet).Trim().Length > 0 ? GetCellDouble(9, i, sheet) : 0.00;
                                _obj.mse = _cell.GetCellString(10, i, sheet).Trim().Length > 0 ? GetCellDouble(10, i, sheet) : 0.00;
                                _obj.qjse = _cell.GetCellString(11, i, sheet).Trim().Length > 0 ? GetCellDouble(11, i, sheet) : 0.00;
                                _obj.djse = _cell.GetCellString(12, i, sheet).Trim().Length > 0 ? GetCellDouble(12, i, sheet) : 0.00;
                                _obj.ynsexj = _cell.GetCellString(13, i, sheet).Trim().Length > 0 ? GetCellDouble(13, i, sheet) : 0.00;
                                _obj.yjynse = _cell.GetCellString(14, i, sheet).Trim().Length > 0 ? GetCellDouble(14, i, sheet) : 0.00;
                                _obj.yjqjse = _cell.GetCellString(15, i, sheet).Trim().Length > 0 ? GetCellDouble(15, i, sheet) : 0.00;
                                _obj.yjsexj = _cell.GetCellString(16, i, sheet).Trim().Length > 0 ? GetCellDouble(16, i, sheet) : 0.00;
                                _obj.qmyjse = _cell.GetCellString(17, i, sheet).Trim().Length > 0 ? GetCellDouble(17, i, sheet) : 0.00;
                                _obj.qmyjqjse = _cell.GetCellString(18, i, sheet).Trim().Length > 0 ? GetCellDouble(18, i, sheet) : 0.00;

                                list_ysxm3.Add(_obj);
                            }

                        }

                        if (list_ysxm3 != null && list_ysxm3.Count > 0)
                        {
                            T_taxMLSbbYlyyysBodyYsxm[] arr = new T_taxMLSbbYlyyysBodyYsxm[list_ysxm3.Count];
                            list_ysxm3.CopyTo(arr, 0);
                            t_taxML03.sbbYlyyys.body.ysxms = arr;
                        }
                        else
                        {
                            isSubmit = false;
                        }
                    }
                         
                    #endregion

                    #region 合计

                    T_taxMLSbbYlyyysBodyHjxx t_taxML03_HJ = new T_taxMLSbbYlyyysBodyHjxx();
                    //t_taxML03_HJ.lc=;
                    t_taxML03_HJ.jssr = _cell.GetCellString(3, 28, 2).Trim().Length > 0 ? GetCellDouble(3, 28, 2) : 0.00;
                    t_taxML03_HJ.jcje = _cell.GetCellString(4, 28, 2).Trim().Length > 0 ? GetCellDouble(4, 28, 2) : 0.00;
                    t_taxML03_HJ.yye = _cell.GetCellString(5, 28, 2).Trim().Length > 0 ? GetCellDouble(5, 28, 2) : 0.00;
                    t_taxML03_HJ.mssr = _cell.GetCellString(6, 28, 2).Trim().Length > 0 ? GetCellDouble(6, 28, 2) : 0.00;
                    //t_taxML03_HJ.sl=;
                    t_taxML03_HJ.skxj = _cell.GetCellString(8, 28, 2).Trim().Length > 0 ? GetCellDouble(8, 28, 2) : 0.00;
                    t_taxML03_HJ.ynse = _cell.GetCellString(9, 28, 2).Trim().Length > 0 ? GetCellDouble(9, 28, 2) : 0.00;
                    t_taxML03_HJ.mse = _cell.GetCellString(10, 28, 2).Trim().Length > 0 ? GetCellDouble(10, 28, 2) : 0.00;
                    t_taxML03_HJ.qjse = _cell.GetCellString(11, 28, 2).Trim().Length > 0 ? GetCellDouble(11, 28, 2) : 0.00;
                    t_taxML03_HJ.djse = _cell.GetCellString(12, 28, 2).Trim().Length > 0 ? GetCellDouble(12, 28, 2) : 0.00;
                    t_taxML03_HJ.ynsexj = _cell.GetCellString(13, 28, 2).Trim().Length > 0 ? GetCellDouble(13, 28, 2) : 0.00;
                    t_taxML03_HJ.yjynse = _cell.GetCellString(14, 28, 2).Trim().Length > 0 ? GetCellDouble(14, 28, 2) : 0.00;
                    t_taxML03_HJ.yjqjse = _cell.GetCellString(15, 28, 2).Trim().Length > 0 ? GetCellDouble(15, 28, 2) : 0.00;
                    t_taxML03_HJ.yjsexj = _cell.GetCellString(16, 28, 2).Trim().Length > 0 ? GetCellDouble(16, 28, 2) : 0.00;
                    t_taxML03_HJ.qmyjse = _cell.GetCellString(17, 28, 2).Trim().Length > 0 ? GetCellDouble(17, 28, 2) : 0.00;
                    t_taxML03_HJ.qmyjqjse = _cell.GetCellString(18, 28, 2).Trim().Length > 0 ? GetCellDouble(18, 28, 2) : 0.00;

                    t_taxML03.sbbYlyyys.body.hjxx = t_taxML03_HJ;

                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML03, xmlPath);//生成xml文件

                    break;

                case "004":
                    //设置第四张报表的填报内容
                    tdps._20201._004.T_taxML t_taxML04 = new tdps._20201._004.T_taxML();

                    #region 公共表头

                    t_taxML04.sbbFwyyys.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML04.sbbFwyyys.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML04.sbbFwyyys.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML04.sbbFwyyys.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    t_taxML04.sbbFwyyys.head.publicHead.tbr = "";
                    t_taxML04.sbbFwyyys.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(10, 5, 3)).ToString("yyyyMMdd");//填表日期
                    t_taxML04.sbbFwyyys.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_004", _cell.GetCellString(10, 5, 3));//打印密码

                    #endregion

                    #region 私有表头

                    //没有

                    #endregion

                    #region 填报内容

                    startCol = startRow = endCol = endRow = sheet = 0;
                    IList<T_taxMLSbbFwyyysBodyYsxm> list_ysxm4 = new List<T_taxMLSbbFwyyysBodyYsxm>();

                    if (_cell.GetAreaVar("A20201_3_1", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        for (int i = startRow; i <= endRow; i++)
                        {
                            string strTempValue = _cell.GetCellString(3, i, 1);

                            if (strTempValue != null && strTempValue.Trim().Length > 0)
                            {
                                T_taxMLSbbFwyyysBodyYsxm _obj = new T_taxMLSbbFwyyysBodyYsxm();

                                //_obj.lc=;
                                _obj.ysxmdm = "0";
                                if (i >= 16 && i <= 19)
                                    _obj.ysxmmc = "代理业";
                                else if(i >= 20 && i <= 23)
                                    _obj.ysxmmc = "其他服务业";
                                else
                                    _obj.ysxmmc = _cell.GetCellString(2, i, sheet);
                                _obj.jssr = _cell.GetCellString(3, i, sheet).Trim().Length > 0 ? GetCellDouble(3, i, sheet) : 0.00;
                                _obj.jcje = _cell.GetCellString(4, i, sheet).Trim().Length > 0 ? GetCellDouble(4, i, sheet) : 0.00;
                                _obj.yye = _cell.GetCellString(5, i, sheet).Trim().Length > 0 ? GetCellDouble(5, i, sheet) : 0.00;
                                _obj.mssr = _cell.GetCellString(6, i, sheet).Trim().Length > 0 ? GetCellDouble(6, i, sheet) : 0.00;
                                _obj.sl = _cell.GetCellString(7, i, sheet).Trim().Length > 0 ? GetCellDouble(7, i, sheet) : 0.00;
                                _obj.skxj = _cell.GetCellString(8, i, sheet).Trim().Length > 0 ? GetCellDouble(8, i, sheet) : 0.00;
                                _obj.ynse = _cell.GetCellString(9, i, sheet).Trim().Length > 0 ? GetCellDouble(9, i, sheet) : 0.00;
                                _obj.mse = _cell.GetCellString(10, i, sheet).Trim().Length > 0 ? GetCellDouble(10, i, sheet) : 0.00;
                                _obj.qjse = _cell.GetCellString(11, i, sheet).Trim().Length > 0 ? GetCellDouble(11, i, sheet) : 0.00;
                                _obj.djse = _cell.GetCellString(12, i, sheet).Trim().Length > 0 ? GetCellDouble(12, i, sheet) : 0.00;
                                _obj.ynsexj = _cell.GetCellString(13, i, sheet).Trim().Length > 0 ? GetCellDouble(13, i, sheet) : 0.00;
                                _obj.yjynse = _cell.GetCellString(14, i, sheet).Trim().Length > 0 ? GetCellDouble(14, i, sheet) : 0.00;
                                _obj.yjqjse = _cell.GetCellString(15, i, sheet).Trim().Length > 0 ? GetCellDouble(15, i, sheet) : 0.00;
                                _obj.yjsexj = _cell.GetCellString(16, i, sheet).Trim().Length > 0 ? GetCellDouble(16, i, sheet) : 0.00;
                                _obj.qmyjse = _cell.GetCellString(17, i, sheet).Trim().Length > 0 ? GetCellDouble(17, i, sheet) : 0.00;
                                _obj.qmyjqjse = _cell.GetCellString(18, i, sheet).Trim().Length > 0 ? GetCellDouble(18, i, sheet) : 0.00;

                                list_ysxm4.Add(_obj);
                            }
                        }

                        if (list_ysxm4 != null && list_ysxm4.Count > 0)
                        {
                            T_taxMLSbbFwyyysBodyYsxm[] arr = new T_taxMLSbbFwyyysBodyYsxm[list_ysxm4.Count];
                            list_ysxm4.CopyTo(arr, 0);
                            t_taxML04.sbbFwyyys.body.ysxms = arr;
                        }
                        else
                        {
                            isSubmit = false;
                        }
                    }

                    #endregion

                    #region 合计

                    T_taxMLSbbFwyyysBodyHjxx t_taxML04_HJ = new T_taxMLSbbFwyyysBodyHjxx();
                    //t_taxML04_HJ.lc=;
                    t_taxML04_HJ.jssr = _cell.GetCellString(3, 24, 3).Trim().Length > 0 ? GetCellDouble(3, 24, 3) : 0.00;
                    t_taxML04_HJ.jcje = _cell.GetCellString(4, 24, 3).Trim().Length > 0 ? GetCellDouble(4, 24, 3) : 0.00;
                    t_taxML04_HJ.yye = _cell.GetCellString(5, 24, 3).Trim().Length > 0 ? GetCellDouble(5, 24, 3) : 0.00;
                    t_taxML04_HJ.mssr = _cell.GetCellString(6, 24, 3).Trim().Length > 0 ? GetCellDouble(6, 24, 3) : 0.00;
                    //t_taxML04_HJ.sl = GetCellDouble(7, 24, 3);
                    t_taxML04_HJ.skxj = _cell.GetCellString(8, 24, 3).Trim().Length > 0 ? GetCellDouble(8, 24, 3) : 0.00;
                    t_taxML04_HJ.ynse = _cell.GetCellString(9, 24, 3).Trim().Length > 0 ? GetCellDouble(9, 24, 3) : 0.00;
                    t_taxML04_HJ.mse = _cell.GetCellString(10, 24, 3).Trim().Length > 0 ? GetCellDouble(10, 24, 3) : 0.00;
                    t_taxML04_HJ.qjse = _cell.GetCellString(11, 24, 3).Trim().Length > 0 ? GetCellDouble(11, 24, 3) : 0.00;
                    t_taxML04_HJ.djse = _cell.GetCellString(12, 24, 3).Trim().Length > 0 ? GetCellDouble(12, 24, 3) : 0.00;
                    t_taxML04_HJ.ynsexj = _cell.GetCellString(13, 24, 3).Trim().Length > 0 ? GetCellDouble(13, 24, 3) : 0.00;
                    t_taxML04_HJ.yjynse = _cell.GetCellString(14, 24, 3).Trim().Length > 0 ? GetCellDouble(14, 24, 3) : 0.00;
                    t_taxML04_HJ.yjqjse = _cell.GetCellString(15, 24, 3).Trim().Length > 0 ? GetCellDouble(15, 24, 3) : 0.00;
                    t_taxML04_HJ.yjsexj = _cell.GetCellString(16, 24, 3).Trim().Length > 0 ? GetCellDouble(16, 24, 3) : 0.00;
                    t_taxML04_HJ.qmyjse = _cell.GetCellString(17, 24, 3).Trim().Length > 0 ? GetCellDouble(17, 24, 3) : 0.00;
                    t_taxML04_HJ.qmyjqjse = _cell.GetCellString(18, 24, 3).Trim().Length > 0 ? GetCellDouble(18, 24, 3) : 0.00;

                    t_taxML04.sbbFwyyys.body.hjxx = t_taxML04_HJ;
                    
                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML04, xmlPath);//生成xml文件

                    break;

                case "005":
                    //设置第五张报表的填报内容
                    tdps._20201._005.T_taxML t_taxML05 = new tdps._20201._005.T_taxML();

                    #region 公共表头

                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.tbr = "";
                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(8, 4, 4)).ToString("yyyyMMdd");//填表日期
                    t_taxML05.sbbFwyyysJcxmjemxb.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_005", _cell.GetCellString(8, 4, 3));//打印密码
                    
                    #endregion

                    #region 私有表头
                    
                    //无

                    #endregion

                    #region 填报内容

                    startCol = startRow = endCol = endRow = sheet = 0;
                    IList<T_taxMLSbbFwyyysJcxmjemxbBodyYsxm> list_ysxm5 = new List<T_taxMLSbbFwyyysJcxmjemxbBodyYsxm>();
                    if (_cell.GetAreaVar("A20201_4_1", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        for (int i = startRow; i <= endRow; i++)
                        {
                            T_taxMLSbbFwyyysJcxmjemxbBodyYsxm _obj = new T_taxMLSbbFwyyysJcxmjemxbBodyYsxm();

                            _obj.ysxmdm = "0";
                            if(i>=6 && i<=7)
                                _obj.ysxmmc = "旅游业";
                            else if(i>=8 && i<=9)
                                _obj.ysxmmc = "广告业";
                            else if(i>=10 && i<=11)
                                _obj.ysxmmc = "代理业";
                            else if(i>=12 && i<=13)
                                _obj.ysxmmc = _cell.GetCellString(1, i, sheet);
                            

                            if (i == 6 || i == 8 || i == 10 || i == 12)
                            {
                                for (int j = 4; j <= 10; j++)
                                {
                                    string strTempValue = _cell.GetCellString(j, i, sheet);
                                    IList<T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm> jcxm_list = new List<T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm>();
                                    if (strTempValue != null && strTempValue.Trim().Length > 0)
                                    {
                                        T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm _obj_child = new T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm();
                                        //_obj_child.lc=;
                                        _obj_child.jcxmdm = "0";
                                        _obj_child.jcxmmc = strTempValue;
                                        _obj_child.jcje = _cell.GetCellString(j, i + 1, sheet).Trim().Length > 0 ? GetCellDouble(j, i + 1, sheet) : 0.00;

                                        jcxm_list.Add(_obj_child);
                                    }

                                    if (jcxm_list != null && jcxm_list.Count > 0)
                                    {
                                        T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm[] arr_child = new T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm[jcxm_list.Count];
                                        jcxm_list.CopyTo(arr_child, 0);
                                        _obj.jcxms = arr_child;
                                    }
                                    else
                                    {
                                        _obj.jcxms = null;
                                    }
                                }
                            }

                            list_ysxm5.Add(_obj);
                        }

                        if (list_ysxm5 != null && list_ysxm5.Count > 0)
                        {
                            T_taxMLSbbFwyyysJcxmjemxbBodyYsxm[] arr = new T_taxMLSbbFwyyysJcxmjemxbBodyYsxm[list_ysxm5.Count];
                            list_ysxm5.CopyTo(arr, 0);
                            t_taxML05.sbbFwyyysJcxmjemxb.body.ysxms = arr;
                        }
                        else
                        {
                            isSubmit = false;
                        }
                    }


                    #endregion

                    #region 合计

                    t_taxML05.sbbFwyyysJcxmjemxb.body.hjxx = _cell.GetCellString(11, 14, sheet).Trim().Length > 0 ? GetCellDouble(11, 14, sheet) : 0.00;

                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML05, xmlPath);//生成xml文件

                    break;

                case "006":
                    //设置第六张报表的填报内容
                    tdps._20201._006.T_taxML t_taxML06 = new tdps._20201._006.T_taxML();

                    #region 公共表头

                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.tbr = "";
                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(9, 4, 5)).ToString("yyyyMMdd");//填表日期
                    t_taxML06.sbbYdtgjzylwskjnqksbb.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_006", _cell.GetCellString(9, 4, 5));//打印密码

                    #endregion

                    #region 私有表头
                    
                    //无

                    #endregion

                    #region 填报内容
                    
                    startCol = startRow = endCol = endRow = sheet = 0;
                    IList<T6_ysxm> list_ysxm6 = new List<T6_ysxm>();
                    if (_cell.GetAreaVar("A20201_5_2", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        int count = endRow / 3;

                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                T6_ysxm _ysxm = new T6_ysxm();
                                _ysxm.ysxmdm = "";
                                _ysxm.ysxmmc = _cell.GetCellString(1, (i * 3) + startRow, sheet);

                                IList<T6_ysxmYsxmmxsYsxmmx> list_ysxmmx = new List<T6_ysxmYsxmmxsYsxmmx>();
                                for (int j = (i * 3) + startRow; j <= endRow; j++)
                                {
                                    T6_ysxmYsxmmxsYsxmmx _obj = new T6_ysxmYsxmmxsYsxmmx();
                                    //_obj.lc = "";
                                    _obj.ynse = _cell.GetCellString(2, j, sheet).Trim().Length > 0 ? GetCellDouble(2, j, sheet) : 0.00;
                                    _obj.ynjkpzh = _cell.GetCellString(3, j, sheet).Trim().Length > 0 ? _cell.GetCellString(3, j, sheet) : "";
                                    _obj.yjse = _cell.GetCellString(4, j, sheet).Trim().Length > 0 ? GetCellDouble(4, j, sheet) : 0.00;
                                    _obj.yjjkpzh = _cell.GetCellString(5, j, sheet).Trim().Length > 0 ? _cell.GetCellString(5, j, sheet) : "";
                                    _obj.kjsssjq = _cell.GetCellString(6, j, sheet).Trim().Length > 0 ? _cell.GetCellString(6, j, sheet) : "";
                                    _obj.kjsssjz = _cell.GetCellString(7, j, sheet).Trim().Length > 0 ? _cell.GetCellString(7, j, sheet) : "";
                                    _obj.kjnsrsbh = _cell.GetCellString(8, j, sheet).Trim().Length > 0 ? _cell.GetCellString(8, j, sheet) : "";
                                    _obj.yrkyysse = _cell.GetCellString(9, j, sheet).Trim().Length > 0 ? GetCellDouble(9, j, sheet) : 0.00;
                                    _obj.yrkjkpzh = _cell.GetCellString(10, j, sheet).Trim().Length > 0 ? _cell.GetCellString(10, j, sheet) : "";
                                    _obj.jksssjq = _cell.GetCellString(11, j, sheet).Trim().Length > 0 ? _cell.GetCellString(11, j, sheet) : "";
                                    _obj.jksssjz = _cell.GetCellString(12, j, sheet).Trim().Length > 0 ? _cell.GetCellString(12, j, sheet) : "";
                                    _obj.hzjmse = _cell.GetCellString(13, j, sheet).Trim().Length > 0 ? GetCellDouble(13, j, sheet) : 0.00;
                                    _obj.jmpzwsh = _cell.GetCellString(14, j, sheet).Trim().Length > 0 ? _cell.GetCellString(14, j, sheet) : "";
                                    _obj.pzwsqsy = _cell.GetCellString(15, j, sheet).Trim().Length > 0 ? _cell.GetCellString(15, j, sheet) : "";
                                    _obj.pzwszzy = _cell.GetCellString(16, j, sheet).Trim().Length > 0 ? _cell.GetCellString(16, j, sheet) : "";

                                    list_ysxmmx.Add(_obj);
                                }

                                if (list_ysxmmx != null && list_ysxmmx.Count > 0)
                                {
                                    T6_ysxmYsxmmxsYsxmmx[] ysxmmx_arr = new T6_ysxmYsxmmxsYsxmmx[list_ysxmmx.Count];
                                    ysxmmx_arr.CopyTo(ysxmmx_arr, 0);
                                    _ysxm.ysxmmxs.ysxmmx = ysxmmx_arr;
                                }


                                list_ysxm6.Add(_ysxm);
                            }

                            if (list_ysxm6 != null && list_ysxm6.Count > 0)
                            {
                                T6_ysxm[] arr = new T6_ysxm[list_ysxm6.Count];
                                list_ysxm6.CopyTo(arr, 0);

                                t_taxML06.sbbYdtgjzylwskjnqksbb.body.ysxms.ysxm = arr;
                            }
                        }
                    }

                    //小计
                    T_taxMLSbbYdtgjzylwskjnqksbbBodyYsxmsXjxx xj = new T_taxMLSbbYdtgjzylwskjnqksbbBodyYsxmsXjxx();
                    xj.ynse = GetCellDouble(2, _cell.GetRows(5) - 8, 5);
                    xj.yjse = GetCellDouble(4, _cell.GetRows(5) - 8, 5);
                    xj.yrkyysse = GetCellDouble(9, _cell.GetRows(5) - 8, 5);
                    xj.hzjmse = GetCellDouble(13, _cell.GetRows(5) - 8, 5);

                    t_taxML06.sbbYdtgjzylwskjnqksbb.body.ysxms.xjxx = xj;

                    //代扣代缴项目
                    T6_ysxm dkdj = new T6_ysxm();
                    dkdj.ysxmdm = "";
                    dkdj.ysxmmc = "代扣代缴项目";
                    T6_ysxmYsxmmxsYsxmmx[] arr_06=new T6_ysxmYsxmmxsYsxmmx[3];
                    for (int i = 0; i < 3; i++)
                    {
                        T6_ysxmYsxmmxsYsxmmx _obj = new T6_ysxmYsxmmxsYsxmmx();

                        _obj.ynse = GetCellDouble(2, _cell.GetRows(5)-(i + 7), 5);
                        _obj.ynjkpzh = _cell.GetCellString(3, _cell.GetRows(5) - (i + 7), 5);
                        _obj.yjse = GetCellDouble(4, _cell.GetRows(5) - (i + 7), 5);
                        _obj.yjjkpzh = _cell.GetCellString(5, _cell.GetRows(5) - (i + 7), 5);
                        _obj.kjsssjq = _cell.GetCellString(6, _cell.GetRows(5) - (i + 7), 5);
                        _obj.kjsssjz = _cell.GetCellString(7, _cell.GetRows(5) - (i + 7), 5);
                        _obj.kjnsrsbh = _cell.GetCellString(8, _cell.GetRows(5) - (i + 7), 5);
                        _obj.yrkyysse = GetCellDouble(9, _cell.GetRows(5) - (i + 7), 5);
                        _obj.yrkjkpzh = _cell.GetCellString(10, _cell.GetRows(5) - (i + 7), 5);
                        _obj.jksssjq = _cell.GetCellString(11, _cell.GetRows(5) - (i + 7), 5);
                        _obj.jksssjz = _cell.GetCellString(12, _cell.GetRows(5) - (i + 7), 5);
                        _obj.hzjmse = GetCellDouble(13, _cell.GetRows(5) - (i + 7), 5);
                        _obj.jmpzwsh = _cell.GetCellString(14, _cell.GetRows(5) - (i + 7), 5);
                        _obj.pzwsqsy = _cell.GetCellString(15, _cell.GetRows(5) - (i + 7), 5);
                        _obj.pzwszzy = _cell.GetCellString(16, _cell.GetRows(5) - (i + 7), 5);

                        arr_06[i] = _obj;
                    }

                    dkdj.ysxmmxs.ysxmmx = arr_06;
                    t_taxML06.sbbYdtgjzylwskjnqksbb.body.ysxms.dkdjxm = dkdj;

                    #endregion

                    #region 合计

                    T_taxMLSbbYdtgjzylwskjnqksbbBodyHjxx hj = new T_taxMLSbbYdtgjzylwskjnqksbbBodyHjxx();

                    hj.ynse = GetCellDouble(2, _cell.GetRows(5) - 4, 5);
                    hj.yjse = GetCellDouble(4, _cell.GetRows(5) - 4, 5);
                    hj.yrkyysse = GetCellDouble(9, _cell.GetRows(5) - 4, 5);
                    hj.hzjmse = GetCellDouble(13, _cell.GetRows(5) - 4, 5);

                    t_taxML06.sbbYdtgjzylwskjnqksbb.body.hjxx = hj;

                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML06, xmlPath);//生成xml文件

                    break;

                case "007":
                    //设置第六张报表的填报内容
                    tdps._20201._007.T_taxML t_taxML07 = new tdps._20201._007.T_taxML();

                    #region 公共表头

                    t_taxML07.sbbJzyyys.head.publicHead.nsrmc = GlobalValue.NSRMC;//纳税人名称
                    t_taxML07.sbbJzyyys.head.publicHead.nsrsbh = GlobalValue.NSRSBH;//纳税人识别号
                    t_taxML07.sbbJzyyys.head.publicHead.sssq.rqQ = DateTime.Parse(this.SSQ_Q).ToString("yyyyMMdd");//所属起始
                    t_taxML07.sbbJzyyys.head.publicHead.sssq.rqZ = DateTime.Parse(this.SSQ_Z).ToString("yyyyMMdd");//所属截止
                    t_taxML07.sbbJzyyys.head.publicHead.tbr = "";
                    t_taxML07.sbbJzyyys.head.publicHead.tbrq = DateTime.Parse(_cell.GetCellString(11, 5, 6)).ToString("yyyyMMdd");//填表日期
                    t_taxML07.sbbJzyyys.head.publicHead.dymm = GlobalValue.GetPrintPassword(GlobalValue.NSRSBH, "20201_007", _cell.GetCellString(11, 5, 6));//打印密码

                    #endregion

                    #region 私有表头
                    
                    //无

                    #endregion

                    #region 填报内容
                    
                    startCol = startRow = endCol = endRow = sheet = 0;
                    T_taxMLSbbJzyyysBodySbxm[] sbxm_arr=new T_taxMLSbbJzyyysBodySbxm[2];
                    T_taxMLSbbJzyyysBodySbxm sbxm1 = new T_taxMLSbbJzyyysBodySbxm();
                    T_taxMLSbbJzyyysBodySbxm sbxm2 = new T_taxMLSbbJzyyysBodySbxm();

                    T_taxMLSbbJzyyysBodySbxmYsxms ysxm1 = new T_taxMLSbbJzyyysBodySbxmYsxms();
                    T_taxMLSbbJzyyysBodySbxmYsxms ysxm2 = new T_taxMLSbbJzyyysBodySbxmYsxms();
                    T_taxMLSbbJzyyysBodySbxmHjxx hj_07=null;
                    T_taxMLSbbJzyyysBodySbxmYsxmsXjxx xj_07 = null;
                    IList<tdps._20201._007.T8_ysxm> ysxm_list_7_1 = new List<tdps._20201._007.T8_ysxm>();
                    #region 本地
                    if (_cell.GetAreaVar("A20201_6_1", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        for (int i = startRow; i <= endRow; i++)
                        {
                            string strTempValue = _cell.GetCellString(2, i, sheet);
                            if (strTempValue != "合计" || strTempValue != "总计")
                            {
                                tdps._20201._007.T8_ysxm _obj = new tdps._20201._007.T8_ysxm();
                                _obj.lc=0;
                                _obj.ysxmdm = "";
                                _obj.ysxmmc = strTempValue;
                                _obj.jssr = GetCellDouble(3,i,sheet);
                                _obj.jcjexj = GetCellDouble(4, i, sheet);
                                _obj.zfgck = GetCellDouble(5, i, sheet);
                                _obj.jcsbk = GetCellDouble(6, i, sheet);
                                _obj.qtjcje = GetCellDouble(7, i, sheet);
                                _obj.yye = GetCellDouble(8, i, sheet);
                                _obj.mssr = GetCellDouble(9, i, sheet);
                                _obj.sl = GetCellDouble(10, i, sheet);
                                _obj.skxj = GetCellDouble(11, i, sheet);
                                _obj.ynse = GetCellDouble(12, i, sheet);
                                _obj.mse = GetCellDouble(13, i, sheet);
                                _obj.qjse = GetCellDouble(14, i, sheet);
                                _obj.djse = GetCellDouble(15, i, sheet);
                                _obj.ynsexj = GetCellDouble(16, i, sheet);
                                _obj.yjynse = GetCellDouble(17, i, sheet);
                                _obj.ybkjse = GetCellDouble(18, i, sheet);
                                _obj.yjqjse = GetCellDouble(19, i, sheet);
                                _obj.yjsexj = GetCellDouble(20, i, sheet);
                                _obj.qmyjse = GetCellDouble(21, i, sheet);
                                _obj.qmyjqjse = GetCellDouble(22, i, sheet);

                                ysxm_list_7_1.Add(_obj);
                            }
                            else if (strTempValue == "合计")
                            {
                                xj_07 = new T_taxMLSbbJzyyysBodySbxmYsxmsXjxx();

                                xj_07.jssr = GetCellDouble(3, i, sheet);
                                xj_07.jcjexj = GetCellDouble(4, i, sheet);
                                xj_07.zfgck = GetCellDouble(5, i, sheet);
                                xj_07.jcsbk = GetCellDouble(6, i, sheet);
                                xj_07.qtjcje = GetCellDouble(7, i, sheet);
                                xj_07.yye = GetCellDouble(8, i, sheet);
                                xj_07.mssr = GetCellDouble(9, i, sheet);
                                xj_07.skxj = GetCellDouble(11, i, sheet);
                                xj_07.ynse = GetCellDouble(12, i, sheet);
                                xj_07.mse = GetCellDouble(13, i, sheet);
                                xj_07.qjse = GetCellDouble(14, i, sheet);
                                xj_07.djse = GetCellDouble(15, i, sheet);
                                xj_07.ynsexj = GetCellDouble(16, i, sheet);
                                xj_07.yjynse = GetCellDouble(17, i, sheet);
                                xj_07.ybkjse = GetCellDouble(18, i, sheet);
                                xj_07.yjqjse = GetCellDouble(19, i, sheet);
                                xj_07.yjsexj = GetCellDouble(20, i, sheet);
                                xj_07.qmyjse = GetCellDouble(21, i, sheet);
                                xj_07.qmyjqjse = GetCellDouble(22, i, sheet);
                            }
                            else if (strTempValue == "总计")
                            {
                                hj_07 = new T_taxMLSbbJzyyysBodySbxmHjxx();

                                hj_07.jssr = GetCellDouble(3, i, sheet);
                                hj_07.jcjexj = GetCellDouble(4, i, sheet);
                                hj_07.zfgck = GetCellDouble(5, i, sheet);
                                hj_07.jcsbk = GetCellDouble(6, i, sheet);
                                hj_07.qtjcje = GetCellDouble(7, i, sheet);
                                hj_07.yye = GetCellDouble(8, i, sheet);
                                hj_07.mssr = GetCellDouble(9, i, sheet);
                                hj_07.skxj = GetCellDouble(11, i, sheet);
                                hj_07.ynse = GetCellDouble(12, i, sheet);
                                hj_07.mse = GetCellDouble(13, i, sheet);
                                hj_07.qjse = GetCellDouble(14, i, sheet);
                                hj_07.djse = GetCellDouble(15, i, sheet);
                                hj_07.ynsexj = GetCellDouble(16, i, sheet);
                                hj_07.yjynse = GetCellDouble(17, i, sheet);
                                hj_07.ybkjse = GetCellDouble(18, i, sheet);
                                hj_07.yjqjse = GetCellDouble(19, i, sheet);
                                hj_07.yjsexj = GetCellDouble(20, i, sheet);
                                hj_07.qmyjse = GetCellDouble(21, i, sheet);
                                hj_07.qmyjqjse = GetCellDouble(22, i, sheet);
                            }
                        }

                        if (ysxm_list_7_1 != null && ysxm_list_7_1.Count > 0)
                        {
                            tdps._20201._007.T8_ysxm[] arr = new tdps._20201._007.T8_ysxm[ysxm_list_7_1.Count];
                            ysxm_list_7_1.CopyTo(arr, 0);
                            ysxm1.ysxm = arr;
                            ysxm1.xjxx = xj_07;
                        }
                        else
                        {
                            isSubmit = false;
                        }

                        sbxm1.ysxms = ysxm1;
                        sbxm1.hjxx = hj_07;
                        sbxm1.sbxmdm = "";
                        sbxm1.sbxmmc = "本地提供建筑业,应税劳务,申报事项";

                        sbxm_arr[0] = sbxm1;
                    }
                    #endregion

                    #region 异地
                    if (_cell.GetAreaVar("A20201_6_2", ref startCol, ref startRow, ref endCol, ref endRow, ref sheet))
                    {
                        ysxm_list_7_1.Clear();

                        for (int i = startRow; i <= endRow; i++)
                        {
                            string strTempValue = _cell.GetCellString(2, i, sheet);
                            if (strTempValue != "合计" || strTempValue != "总计")
                            {
                                tdps._20201._007.T8_ysxm _obj = new tdps._20201._007.T8_ysxm();
                                _obj.lc = 0;
                                _obj.ysxmdm = "";
                                _obj.ysxmmc = strTempValue;
                                _obj.jssr = GetCellDouble(3, i, sheet);
                                _obj.jcjexj = GetCellDouble(4, i, sheet);
                                _obj.zfgck = GetCellDouble(5, i, sheet);
                                _obj.jcsbk = GetCellDouble(6, i, sheet);
                                _obj.qtjcje = GetCellDouble(7, i, sheet);
                                _obj.yye = GetCellDouble(8, i, sheet);
                                _obj.mssr = GetCellDouble(9, i, sheet);
                                _obj.sl = GetCellDouble(10, i, sheet);
                                _obj.skxj = GetCellDouble(11, i, sheet);
                                _obj.ynse = GetCellDouble(12, i, sheet);
                                _obj.mse = GetCellDouble(13, i, sheet);
                                _obj.qjse = GetCellDouble(14, i, sheet);
                                _obj.djse = GetCellDouble(15, i, sheet);
                                _obj.ynsexj = GetCellDouble(16, i, sheet);
                                _obj.yjynse = GetCellDouble(17, i, sheet);
                                _obj.ybkjse = GetCellDouble(18, i, sheet);
                                _obj.yjqjse = GetCellDouble(19, i, sheet);
                                _obj.yjsexj = GetCellDouble(20, i, sheet);
                                _obj.qmyjse = GetCellDouble(21, i, sheet);
                                _obj.qmyjqjse = GetCellDouble(22, i, sheet);

                                ysxm_list_7_1.Add(_obj);
                            }
                            else if (strTempValue == "合计")
                            {
                                xj_07 = new T_taxMLSbbJzyyysBodySbxmYsxmsXjxx();

                                xj_07.jssr = GetCellDouble(3, i, sheet);
                                xj_07.jcjexj = GetCellDouble(4, i, sheet);
                                xj_07.zfgck = GetCellDouble(5, i, sheet);
                                xj_07.jcsbk = GetCellDouble(6, i, sheet);
                                xj_07.qtjcje = GetCellDouble(7, i, sheet);
                                xj_07.yye = GetCellDouble(8, i, sheet);
                                xj_07.mssr = GetCellDouble(9, i, sheet);
                                xj_07.skxj = GetCellDouble(11, i, sheet);
                                xj_07.ynse = GetCellDouble(12, i, sheet);
                                xj_07.mse = GetCellDouble(13, i, sheet);
                                xj_07.qjse = GetCellDouble(14, i, sheet);
                                xj_07.djse = GetCellDouble(15, i, sheet);
                                xj_07.ynsexj = GetCellDouble(16, i, sheet);
                                xj_07.yjynse = GetCellDouble(17, i, sheet);
                                xj_07.ybkjse = GetCellDouble(18, i, sheet);
                                xj_07.yjqjse = GetCellDouble(19, i, sheet);
                                xj_07.yjsexj = GetCellDouble(20, i, sheet);
                                xj_07.qmyjse = GetCellDouble(21, i, sheet);
                                xj_07.qmyjqjse = GetCellDouble(22, i, sheet);
                            }
                            else if (strTempValue == "总计")
                            {
                                hj_07 = new T_taxMLSbbJzyyysBodySbxmHjxx();

                                hj_07.jssr = GetCellDouble(3, i, sheet);
                                hj_07.jcjexj = GetCellDouble(4, i, sheet);
                                hj_07.zfgck = GetCellDouble(5, i, sheet);
                                hj_07.jcsbk = GetCellDouble(6, i, sheet);
                                hj_07.qtjcje = GetCellDouble(7, i, sheet);
                                hj_07.yye = GetCellDouble(8, i, sheet);
                                hj_07.mssr = GetCellDouble(9, i, sheet);
                                hj_07.skxj = GetCellDouble(11, i, sheet);
                                hj_07.ynse = GetCellDouble(12, i, sheet);
                                hj_07.mse = GetCellDouble(13, i, sheet);
                                hj_07.qjse = GetCellDouble(14, i, sheet);
                                hj_07.djse = GetCellDouble(15, i, sheet);
                                hj_07.ynsexj = GetCellDouble(16, i, sheet);
                                hj_07.yjynse = GetCellDouble(17, i, sheet);
                                hj_07.ybkjse = GetCellDouble(18, i, sheet);
                                hj_07.yjqjse = GetCellDouble(19, i, sheet);
                                hj_07.yjsexj = GetCellDouble(20, i, sheet);
                                hj_07.qmyjse = GetCellDouble(21, i, sheet);
                                hj_07.qmyjqjse = GetCellDouble(22, i, sheet);
                            }
                        }

                        if (ysxm_list_7_1 != null && ysxm_list_7_1.Count > 0)
                        {
                            tdps._20201._007.T8_ysxm[] arr = new tdps._20201._007.T8_ysxm[ysxm_list_7_1.Count];
                            ysxm_list_7_1.CopyTo(arr, 0);
                            ysxm2.ysxm = arr;
                            ysxm2.xjxx = xj_07;
                        }
                        else
                        {
                            isSubmit = false;
                        }

                        sbxm2.ysxms = ysxm2;
                        sbxm2.hjxx = hj_07;
                        sbxm2.sbxmdm = "";
                        sbxm2.sbxmmc = "本地提供建筑业,应税劳务,申报事项";

                        sbxm_arr[1] = sbxm2;
                    }
                    #endregion

                    t_taxML07.sbbJzyyys.body.sbxms = sbxm_arr;

                    #endregion

                    XmlHelper.CreateXMLFile(t_taxML07, xmlPath);//生成xml文件

                    break;
            }

            #region 组装申报表对象
            _sbxml.SBXXID = _sbxxID;
            _sbxml.FileName = string.Format("{0}_{1}", this.SBZL, sheetName);
            if (isSubmit)
                _sbxml.SBXMLData = XmlHelper.ReadXMLtoBase64(xmlPath, true);
            #endregion

            return _sbxml;
        }

        /// <summary>
        /// 报表初始化
        /// </summary>
        /// <param name="_sbxxID"></param>
        /// <returns></returns>
        public override bool InitReportData(string _sbxxID)
        {
            if (this.Cell != null)
            {
                AxCell _cell = (AxCell)this.Cell;//获取当前的华表对象                
                InitializeCell(ref _cell);

                #region 初始化开据日期

                SetWriteDate();

                #endregion

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 初始化报表单元格
        /// </summary>
        public void InitializeCell(ref AxCell cell)
        {
            GlobalValue.NSRSBH = "430424753382517";

            //获得纳税人信息
            NSRXXBLL nsrxxdll = new NSRXXBLL();
            NSRXX nsrxx = nsrxxdll.GetModel(GlobalValue.NSRSBH);

            if (cell != null)
            {
                #region 初始化20201_001的数据

                cell.SetCellString(2, 3, 0, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(2, 4, 0, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 5, 0, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(4, 5, 0, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));
                //cell.SetCellString(9, 26, 0, nsrxx.NSRMC);//办税人员
                cell.SetCellString(15, 26, 0, nsrxx.FDDBRMC);//法定代表人
                cell.SetCellString(18, 26, 0, nsrxx.DHHM);//联系电话

                #endregion

                #region 初始化20201_002的数据

                cell.SetCellString(2, 3, 1, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(2, 4, 1, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 5, 1, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(4, 5, 1, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));

                #endregion

                #region 初始化20201_003的数据

                cell.SetCellString(2, 3, 2, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(2, 4, 2, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 5, 2, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(5, 5, 2, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));

                #endregion

                #region 初始化20201_004的数据

                cell.SetCellString(2, 3, 3, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(3, 4, 3, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 5, 3, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(5, 5, 3, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));

                #endregion

                #region 初始化20201_005的数据

                cell.SetCellString(2, 2, 4, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(3, 2, 4, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 4, 4, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(5, 4, 4, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));

                #endregion

                #region 初始化20201_006的数据

                cell.SetCellString(2, 2, 5, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(2, 2, 5, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 4, 5, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(4, 4, 5, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));

                #endregion

                #region 初始化20201_007的数据

                cell.SetCellString(2, 3, 6, nsrxx.NSRSBH);//纳税人识别号
                cell.SetCellString(2, 4, 6, nsrxx.NSRMC);//纳税人名称
                cell.SetCellString(2, 5, 6, DateTime.Parse(this.SSQ_Q).ToString("yyyy年MM月dd日"));
                cell.SetCellString(6, 5, 6, DateTime.Parse(this.SSQ_Z).ToString("yyyy年MM月dd日"));

                #endregion
            }
        }

        /// <summary>
        /// 设置填表日期
        /// </summary>
        public override void SetWriteDate()
        {
            AxCell _cell = (AxCell)this.Cell;//获取当前的华表对象
            if (_cell != null)
            {
                //20201_001填报日期
                _cell.SetCellString(10, 5, 0, DateTime.Today.ToString("yyyy年MM月dd日"));

                //20201_002填报日期
                _cell.SetCellString(11, 5, 1, DateTime.Today.ToString("yyyy年MM月dd日"));

                //20201_003填报日期
                _cell.SetCellString(8, 5, 2, DateTime.Today.ToString("yyyy年MM月dd日"));

                //20201_004填报日期
                _cell.SetCellString(10, 5, 3, DateTime.Today.ToString("yyyy年MM月dd日"));

                //20201_005填报日期
                _cell.SetCellString(8, 4, 4, DateTime.Today.ToString("yyyy年MM月dd日"));

                //20201_006填报日期
                _cell.SetCellString(9, 4, 5, DateTime.Today.ToString("yyyy年MM月dd日"));

                //20201_007填报日期
                _cell.SetCellString(11, 5, 6, DateTime.Today.ToString("yyyy年MM月dd日"));
            }
        }

        /// <summary>
        /// 事件注册
        /// </summary>
        public override void InitCellEvent()
        {
            if (this.Cell != null)
            {
                ((AxCell)this.Cell).ButtonCellClicked -= buttonCellClicked;
                ((AxCell)this.Cell).ButtonCellClicked += buttonCellClicked;
            }
        }

        public static void ReportOperation_ButtonCellClicked(object sender, _DCell2000Events_ButtonCellClickedEvent e)
        {
            //增加应税项目
            if (e.sheetindex == 5)
            {
                AxCell _cell = (AxCell)sender;
                if (MsgHelper.ShowConfirm("是否要新增一个购货方填报记录？") == System.Windows.Forms.DialogResult.Yes)
                {
                    //获取合计行坐标，在该坐标的上部增加单元格
                    int col1 = 0;
                    int row1 = 0;
                    int col2 = 0;
                    int row2 = 0;
                    int sheet = 0;

                    if (_cell.GetAreaVar("A20201_5_1", ref col1, ref row1, ref col2, ref row2, ref sheet))
                    {
                        //1、先插入空行
                        _cell.InsertCleanRow(row1, 3, e.sheetindex);
                        //2、复制模板格式
                        _cell.CopyRange(col1, _cell.GetRows(sheet) - 3, col2, _cell.GetRows(sheet) - 1);
                        //3、粘贴选定区域
                        _cell.Paste(col1, row1, 0, 0, 0);
                        //4、更新SUM公式
                        _cell.SetFormula(2, row2 + 3, sheet, "sum(异地建筑_BM!B9:B" + (row2 + 2) + ")");
                        _cell.SetFormula(4, row2 + 3, sheet, "sum(异地建筑_BM!D9:D" + (row2 + 2) + ")");
                        _cell.SetFormula(9, row2 + 3, sheet, "sum(异地建筑_BM!I9:I" + (row2 + 2) + ")");
                        _cell.SetFormula(13, row2 + 3, sheet, "sum(异地建筑_BM!M9:M" + (row2 + 2) + ")");
                        //5、更新区域位置_合计区域
                        _cell.DefineAreaVar("A20201_5_1", col1, row2 + 3, col2, row2 + 3, sheet);

                        int col1_2 = 0;
                        int row1_2 = 0;
                        int col2_2 = 0;
                        int row2_2 = 0;
                        int sheet_2 = 0;
                        if (_cell.GetAreaVar("A20201_5_2", ref col1_2, ref row1_2, ref col2_2, ref row2_2, ref sheet_2))
                        {
                            _cell.DefineAreaVar("A20201_5_2", col1, row1_2, col2, row2_2 + 3, sheet_2);
                        }   
                    }
                }
            }
        }

        public override bool ValCellVersion(ref string _cellversion, ref string _sbxxcode)
        {
            AxCell _cell = (AxCell)this.Cell;
            if (this.SBZL != "" && _cell.GetCellString(0, 1, 0) != "")
            {
                _cellversion = _cell.GetCellString(0, 1, 0);
                _sbxxcode = this.SBZL;
                return true;
            }
            else
                return false;

        }
    }
}
