using Iterator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Iterator.Tests
{
    [TestClass]
    public class LeapYearTestSet
    {
        [TestMethod]
        public void test_leapyearset_implicit()
        {
            LeapYearSet leapYearSet = new LeapYearSet(2000, 2040);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in leapYearSet)
            {
                stringBuilder.Append(item);
                stringBuilder.Append(", ");
            }
            string expected = "2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, ";
            Assert.AreEqual(expected, stringBuilder.ToString());
        }

        [TestMethod]
        public void test_leapyearset_iterator()
        {
            LeapYearSet leapYearSet = new LeapYearSet(2010, 2020);
            var iterator = leapYearSet.GetEnumerator();
            StringBuilder stringBuilder = new StringBuilder();
            while (iterator.MoveNext())
            {
                stringBuilder.Append($"{iterator.Current}, ");
            }
            string expected = "2012, 2016, 2020, ";
            Assert.AreEqual(expected, stringBuilder.ToString());
        }
    }
}
