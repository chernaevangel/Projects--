using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.Exceptions
{
    public class EmailFormatException : Exception
    {
        public override string Message => "Incorrect email format. Please try again";
    }
}
