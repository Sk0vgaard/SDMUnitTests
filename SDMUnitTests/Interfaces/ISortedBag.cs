using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMUnitTests.Interfaces
{
    interface ISortedBag
    {
        List<int> bag { get; set; }

        void Add(int i);

        int Pop();

        int Count();
    }
    
}
