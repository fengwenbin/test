using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._001
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbYysField = new T_taxMLSbbYys();
            cnNameField = new T_taxMLCnName();
        }
    }

    public partial class T_taxMLSbbYys
    {
        public T_taxMLSbbYys()
        {
            headField = new T_taxMLSbbYysHead();
            bodyField = new T_taxMLSbbYysBody();
        }
    }

    public partial class T_taxMLSbbYysHead
    {
        public T_taxMLSbbYysHead()
        {
            publicHeadField = new sbbPublicHead();
            privateHeadField = new T_taxMLSbbYysHeadPrivateHead();
        }
    }

    public partial class sbbPublicHead
    {
        public sbbPublicHead()
        {
            sssqField = new rqfw();
        }
    }

    public partial class T_taxMLSbbYysBody
    {
        public T_taxMLSbbYysBody()
        {
            ysxmsField = new T_taxMLSbbYysBodyYsxms();
            hjxxField = new T_taxMLSbbYysBodyHjxx();
        }
    }

    public partial class T_taxMLSbbYysBodyYsxms
    {
        public T_taxMLSbbYysBodyYsxms()
        {
            xjxxField = new T_taxMLSbbYysBodyYsxmsXjxx();
        }
    }
}
