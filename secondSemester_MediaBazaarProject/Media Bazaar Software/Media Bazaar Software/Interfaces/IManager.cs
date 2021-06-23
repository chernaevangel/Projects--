using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.Interfaces
{
    interface IManager
    {
        void Add(object obj);

        Object GetAllObjects();
    }
}
