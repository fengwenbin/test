using System;
using System.Collections.Generic;
using System.Text;

namespace tdps._20201._006
{
    public partial class T_taxML
    {
        public T_taxML()
        {
            sbbYdtgjzylwskjnqksbbField = new T_taxMLSbbYdtgjzylwskjnqksbb();
        }
    }

    public partial class T_taxMLSbbYdtgjzylwskjnqksbb
    {
        public T_taxMLSbbYdtgjzylwskjnqksbb()
        {
            headField = new T_taxMLSbbYdtgjzylwskjnqksbbHead();
            bodyField = new T_taxMLSbbYdtgjzylwskjnqksbbBody();
        }
    }

    public partial class T_taxMLSbbYdtgjzylwskjnqksbbHead
    {
        public T_taxMLSbbYdtgjzylwskjnqksbbHead()
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

    public partial class T_taxMLSbbYdtgjzylwskjnqksbbBody
    {
        public T_taxMLSbbYdtgjzylwskjnqksbbBody()
        {
            ysxmsField = new T_taxMLSbbYdtgjzylwskjnqksbbBodyYsxms();
            hjxxField = new T_taxMLSbbYdtgjzylwskjnqksbbBodyHjxx();
        }
    }

    public partial class T_taxMLSbbYdtgjzylwskjnqksbbBodyYsxms
    {
        public T_taxMLSbbYdtgjzylwskjnqksbbBodyYsxms()
        {
            xjxxField = new T_taxMLSbbYdtgjzylwskjnqksbbBodyYsxmsXjxx();
            dkdjxmField = new T6_ysxm();
        }
    }

    public partial class T6_ysxm
    {
        public T6_ysxm()
        {
            ysxmmxsField = new T6_ysxmYsxmmxs();
        }
    }
}
