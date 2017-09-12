using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDMUnitTestsTests.SortedBag
{
    [TestClass()]
    public class SortedBagTests
    {
        private SDMUnitTests.SortedBag.SortedBag bag;
        private int i;

        [TestInitialize]
        public void Initialize()
        {
            i = 0;
            bag = new SDMUnitTests.SortedBag.SortedBag();
        }

        [TestMethod()]
        public void AddTest()
        {
            bag.Add(5);
            Assert.AreEqual(bag.Size(), 1);
        }

        [TestMethod()]
        public void CorrectNumberPopTest()
        {
            bag.Add(3);
            bag.Add(1);
            bag.Add(5);

            Assert.AreEqual(bag.Pop(), 1);
        }

        [TestMethod()]
        public void DeletePopTest()
        {
            bag.Add(3);
            bag.Pop();
            Assert.AreEqual(bag.Size(), 0);
        }

        [TestMethod()]
        public void SizeInitiliazeTest()
        {
            Assert.AreEqual(bag.Size(), 0);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.AreEqual(bag.bag.Count, 0);
        }
    }
}