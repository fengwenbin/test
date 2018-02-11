using System;
using System.Collections.Generic;
using System.Text;

namespace tdps.Model
{
   public partial class NSRZJG
    {
       private NSRFZJG _nsrfzjg;
       public NSRFZJG NSRFZJG
       {
           set
           {
               _nsrfzjg = value;
           }
           get
           {
               return _nsrfzjg;
           }  
       }
    }
}
