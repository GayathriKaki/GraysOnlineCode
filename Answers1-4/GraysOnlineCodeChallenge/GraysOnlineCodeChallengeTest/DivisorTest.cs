using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraysOnlineCodeChallenge.Controllers;
using System.Linq;

namespace GraysOnlineCodeChallengeTest
{
    /// <summary>
    /// Summary description for DivisorTest
    /// </summary>
    [TestClass]
    public class DivisorTest
    {
       

        [TestMethod]
        public void DivisorNumTest()
        {
          GetNumDivisors controller = new GetNumDivisors();
            //Test Case 1
            IEnumerable<int> lstDivisors = new List<int> { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 };
            Assert.AreEqual(true, lstDivisors.OrderBy(x => x).SequenceEqual(controller.GetDivisors(60).ToList().OrderBy(x => x)));

            //Test Case 2
            IEnumerable<int> lstDivisors2 = new List<int> { 1, 2, 3, 6, 7, 14, 21, 42 };
            Assert.AreEqual(true, lstDivisors2.OrderBy(x => x).SequenceEqual(controller.GetDivisors(42).ToList().OrderBy(x => x)));
        }

       
    }
}
