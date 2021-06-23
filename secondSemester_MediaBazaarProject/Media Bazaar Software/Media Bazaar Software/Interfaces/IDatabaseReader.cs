using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar_Software.Interfaces
{
    public interface IDatabaseReader
    {
        Object ReadAll();
        void Insert(object obj);
        void Delete(int id);
    }
}
