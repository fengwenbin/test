using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._004
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbFwyyysField = new T_taxMLSbbFwyyys();
        }
    }

    public partial class T_taxMLSbbFwyyys
    {
        public T_taxMLSbbFwyyys()
        {
            headField = new T_taxMLSbbFwyyysHead();
            bodyField = new T_taxMLSbbFwyyysBody();
        }
    }

    public partial class T_taxMLSbbFwyyysHead
    {
        public T_taxMLSbbFwyyysHead()
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

    public partial class T_taxMLSbbFwyyysBody
    {
        public T_taxMLSbbFwyyysBody()
        {
            hjxxField = new T_taxMLSbbFwyyysBodyHjxx();
        }
    }
}

