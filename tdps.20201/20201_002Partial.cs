using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._002
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbJtysyyysField = new T_taxMLSbbJtysyyys();
        }
    }

    public partial class T_taxMLSbbJtysyyys
    {
        public T_taxMLSbbJtysyyys()
        {
            headField = new T_taxMLSbbJtysyyysHead();
            bodyField = new T_taxMLSbbJtysyyysBody();
        }
    }

    public partial class T_taxMLSbbJtysyyysHead
    {
        public T_taxMLSbbJtysyyysHead()
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

    public partial class T_taxMLSbbJtysyyysBody
    {
        public T_taxMLSbbJtysyyysBody()
        {
            hjxxField = new T_taxMLSbbJtysyyysBodyHjxx();
        }
    }
}

