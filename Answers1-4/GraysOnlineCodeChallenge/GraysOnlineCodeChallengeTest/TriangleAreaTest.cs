using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraysOnlineCodeChallenge.Controllers;
namespace GraysOnlineCodeChallengeTest
{
    /// <summary>
    /// Summary description for TriangleAreaTest
    /// </summary>
    [TestClass]
    public class TriangleAreaTest
    {
        public TriangleAreaTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        [TestMethod]
        public void TriaAreaTest()
        {
          GetTriangleArea controller = new GetTriangleArea();

            Assert.AreEqual(6, controller.GetTriaArea(3, 4, 5));

        }
    }
}
