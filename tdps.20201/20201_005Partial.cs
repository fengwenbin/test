using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._005
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbFwyyysJcxmjemxbField = new T_taxMLSbbFwyyysJcxmjemxb();
        }
    }

    public partial class T_taxMLSbbFwyyysJcxmjemxb
    {
        public T_taxMLSbbFwyyysJcxmjemxb()
        {
            headField = new T_taxMLSbbFwyyysJcxmjemxbHead();
            bodyField = new T_taxMLSbbFwyyysJcxmjemxbBody();
        }
    }

    public partial class T_taxMLSbbFwyyysJcxmjemxbHead
    {
        public T_taxMLSbbFwyyysJcxmjemxbHead()
        {
            publicHeadField = new sbbPublicHead();
        }
    }

    public partial class sbbPublicHead
    {
        public sbbPublicHead()
        {
            sssqField = new rqfw();
        }
    }
}
