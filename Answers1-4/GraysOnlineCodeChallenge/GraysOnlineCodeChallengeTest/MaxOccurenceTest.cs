using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

using GraysOnlineCodeChallenge.Controllers;

namespace GraysOnlineCodeChallengeTest
{
    /// <summary>
    /// Summary description for MaxOccurenceTest
    /// </summary>
    [TestClass]
    public class MaxOccurenceTest
    {
        public MaxOccurenceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

       

        [TestMethod]
        public void MaxOccurenceNumTest()
        {
          GetCommonNumsArray controller = new GetCommonNumsArray();

            //Test Case 1
            List<int> lst = new List<int>() { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            List<int> expectedList = new List<int> { 5, 4 };
            List<int> finallst = controller.GetCommonNumArray(lst);
            Assert.AreEqual(true, expectedList.SequenceEqual(finallst));

            //Test CASE 2
            List<int> lst2 = new List<int>() { 1, 2, 3, 4, 5, 1, 6, 7 };
            List<int> expectedList2 = new List<int> { 1 };
            List<int> finallst2 = controller.GetCommonNumArray(lst2);
            Assert.AreEqual(true, expectedList2.SequenceEqual(finallst2));

            //Test CASE 3
            List<int> lst3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> expectedList3 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> finallst3 = controller.GetCommonNumArray(lst3);
            Assert.AreEqual(true, expectedList3.SequenceEqual(finallst3));
        }
    }
}
