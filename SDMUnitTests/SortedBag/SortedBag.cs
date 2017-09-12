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
        public List<int> bag;

        public SortedBag()
        {
            bag = new List<int>();
        }

        public void Add(int i)
        {
            bag.Add(i);
        }

        public int Pop()
        {
            bag.Sort();
            var result = bag[0];
            bag.RemoveAt(0);
            return result;
        }

        public int Size()
        {
            return bag.Count;
        }

        public List<int> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}