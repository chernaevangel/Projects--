using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.Exceptions
{
    class EmptyFieldException : Exception
    {
        public override string Message => "Please input all the required information and try again.";
    }
}
