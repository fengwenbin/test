﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.4959
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码由 xsd 自动生成, Version=2.0.50727.3038。
// 
namespace tdps._20201._005 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    
    [System.Xml.Serialization.XmlRootAttribute("taxML", Namespace="", IsNullable=false)]
    public partial class T_taxML {
        
        private T_taxMLSbbFwyyysJcxmjemxb sbbFwyyysJcxmjemxbField;
        
        private T_taxMLVersion versionField;
        
        private T_taxMLName nameField;
        
        private T_taxMLCnName cnNameField;
        
        /// <remarks/>
        public T_taxMLSbbFwyyysJcxmjemxb sbbFwyyysJcxmjemxb {
            get {
                return this.sbbFwyyysJcxmjemxbField;
            }
            set {
                this.sbbFwyyysJcxmjemxbField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public T_taxMLVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public T_taxMLName name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public T_taxMLCnName cnName {
            get {
                return this.cnNameField;
            }
            set {
                this.cnNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public partial class T_taxMLSbbFwyyysJcxmjemxb {
        
        private T_taxMLSbbFwyyysJcxmjemxbHead headField;
        
        private T_taxMLSbbFwyyysJcxmjemxbBody bodyField;
        
        /// <remarks/>
        public T_taxMLSbbFwyyysJcxmjemxbHead head {
            get {
                return this.headField;
            }
            set {
                this.headField = value;
            }
        }
        
        /// <remarks/>
        public T_taxMLSbbFwyyysJcxmjemxbBody body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public partial class T_taxMLSbbFwyyysJcxmjemxbHead {
        
        private sbbPublicHead publicHeadField;
        
        /// <remarks/>
        public sbbPublicHead publicHead {
            get {
                return this.publicHeadField;
            }
            set {
                this.publicHeadField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    
    public partial class sbbPublicHead {
        
        private string nsrsbhField;
        
        private string nsrmcField;
        
        private string tbrqField;
        
        private string tbrField;
        
        private rqfw sssqField;
        
        private string dymmField;
        
        /// <remarks/>
        public string nsrsbh {
            get {
                return this.nsrsbhField;
            }
            set {
                this.nsrsbhField = value;
            }
        }
        
        /// <remarks/>
        public string nsrmc {
            get {
                return this.nsrmcField;
            }
            set {
                this.nsrmcField = value;
            }
        }
        
        /// <remarks/>
        public string tbrq {
            get {
                return this.tbrqField;
            }
            set {
                this.tbrqField = value;
            }
        }
        
        /// <remarks/>
        public string tbr {
            get {
                return this.tbrField;
            }
            set {
                this.tbrField = value;
            }
        }
        
        /// <remarks/>
        public rqfw sssq {
            get {
                return this.sssqField;
            }
            set {
                this.sssqField = value;
            }
        }
        
        /// <remarks/>
        public string dymm {
            get {
                return this.dymmField;
            }
            set {
                this.dymmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    
    public partial class rqfw {
        
        private string rqQField;
        
        private string rqZField;
        
        /// <remarks/>
        public string rqQ {
            get {
                return this.rqQField;
            }
            set {
                this.rqQField = value;
            }
        }
        
        /// <remarks/>
        public string rqZ {
            get {
                return this.rqZField;
            }
            set {
                this.rqZField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public partial class T_taxMLSbbFwyyysJcxmjemxbBody {
        
        private T_taxMLSbbFwyyysJcxmjemxbBodyYsxm[] ysxmsField;
        
        private double hjxxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ysxm", IsNullable=false)]
        public T_taxMLSbbFwyyysJcxmjemxbBodyYsxm[] ysxms {
            get {
                return this.ysxmsField;
            }
            set {
                this.ysxmsField = value;
            }
        }
        
        /// <remarks/>
        public double hjxx {
            get {
                return this.hjxxField;
            }
            set {
                this.hjxxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public partial class T_taxMLSbbFwyyysJcxmjemxbBodyYsxm {
        
        private string ysxmdmField;
        
        private string ysxmmcField;
        
        private T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm[] jcxmsField;
        
        private double xjxxField;
        
        /// <remarks/>
        public string ysxmdm {
            get {
                return this.ysxmdmField;
            }
            set {
                this.ysxmdmField = value;
            }
        }
        
        /// <remarks/>
        public string ysxmmc {
            get {
                return this.ysxmmcField;
            }
            set {
                this.ysxmmcField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("jcxm", IsNullable=false)]
        public T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm[] jcxms {
            get {
                return this.jcxmsField;
            }
            set {
                this.jcxmsField = value;
            }
        }
        
        /// <remarks/>
        public double xjxx {
            get {
                return this.xjxxField;
            }
            set {
                this.xjxxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public partial class T_taxMLSbbFwyyysJcxmjemxbBodyYsxmJcxm {
        
        private long lcField;
        
        private string jcxmdmField;
        
        private string jcxmmcField;
        
        private double jcjeField;
        
        /// <remarks/>
        public long lc {
            get {
                return this.lcField;
            }
            set {
                this.lcField = value;
            }
        }
        
        /// <remarks/>
        public string jcxmdm {
            get {
                return this.jcxmdmField;
            }
            set {
                this.jcxmdmField = value;
            }
        }
        
        /// <remarks/>
        public string jcxmmc {
            get {
                return this.jcxmmcField;
            }
            set {
                this.jcxmmcField = value;
            }
        }
        
        /// <remarks/>
        public double jcje {
            get {
                return this.jcjeField;
            }
            set {
                this.jcjeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public enum T_taxMLVersion {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("V1.0")]
        V10,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public enum T_taxMLName {
        
        /// <remarks/>
        sbbFwyyysJcxmjemxb,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="")]
    public enum T_taxMLCnName {
        
        /// <remarks/>
        服务业营业税减除项目金额明细表,
    }
}
