using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._003
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbYlyyysField = new T_taxMLSbbYlyyys();
        }
    }

    public partial class T_taxMLSbbYlyyys
    {
        public T_taxMLSbbYlyyys()
        {
            headField = new T_taxMLSbbYlyyysHead();
            bodyField = new T_taxMLSbbYlyyysBody();
        }
    }

    public partial class T_taxMLSbbYlyyysHead
    {
        public T_taxMLSbbYlyyysHead()
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

    public partial class T_taxMLSbbYlyyysBody
    {
        public T_taxMLSbbYlyyysBody()
        {
            hjxxField = new T_taxMLSbbYlyyysBodyHjxx();
        }
    }
}
