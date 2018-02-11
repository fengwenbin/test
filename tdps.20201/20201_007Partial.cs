using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._007
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbJzyyysField = new T_taxMLSbbJzyyys();
        }
    }

    public partial class T_taxMLSbbJzyyys
    {
        public T_taxMLSbbJzyyys()
        {
            headField = new T_taxMLSbbJzyyysHead();
            bodyField = new T_taxMLSbbJzyyysBody();
        }
    }

    public partial class T_taxMLSbbJzyyysHead
    {
        public T_taxMLSbbJzyyysHead()
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

    public partial class T_taxMLSbbJzyyysBody
    {
        public T_taxMLSbbJzyyysBody()
        {
 
        }
    }
}
