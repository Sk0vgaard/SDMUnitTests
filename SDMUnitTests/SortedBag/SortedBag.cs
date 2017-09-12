using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMUnitTests.Interfaces;

namespace SDMUnitTests.SortedBag
{
    public class SortedBag : ISortedBag
    {
        public List<int> bag { get; set; }
        public void Add(int i)
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
