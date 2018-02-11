using System;
using System.Collections.Generic;
using System.Text;

namespace tdps.Model
{
    public class PrintHistory
    {
        private int _PrintID;
        private int _SbxxID;
        private string _PrintUser;
        private string _PrintTime;
        private string _Items;

        public int PrintID
        {
            set { _PrintID = value; }
            get { return _PrintID; }
        }

        public int SbxxID
        {
            set { _SbxxID = value; }
            get { return _SbxxID; }
        }

        public string PrintUser
        {
            set { _PrintUser = value; }
            get { return _PrintUser; }
        }

        public string PrintTime
        {
            set { _PrintTime = value; }
            get { return _PrintTime; }
        }

        public string Items
        {
            set { _Items = value; }
            get { return _Items; }
        }

    }
}
