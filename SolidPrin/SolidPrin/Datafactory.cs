using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrin
{
    class Datafactory
    {
        public static IDataacsess Getobject()
        {
            return new DataAcsess(); 
        }
    }
}
