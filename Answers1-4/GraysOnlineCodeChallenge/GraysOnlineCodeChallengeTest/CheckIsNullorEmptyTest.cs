using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraysOnlineCodeChallenge.Controllers;
namespace GraysOnlineCodeChallengeTest
{
    /// <summary>
    /// Summary description for CheckIsNullorEmptyTest
    /// </summary>
    [TestClass]
    public class CheckIsNullorEmptyTest
    {
        public CheckIsNullorEmptyTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void valIsNullorEmptyTest()
        {
            // Arrange
           CheckIsNullorEmpty controller = new CheckIsNullorEmpty();


            Assert.AreEqual(true, controller.valIsNullorEmpty(null));
            Assert.AreEqual(false, controller.valIsNullorEmpty("hello<br>"));
            Assert.AreEqual(true, controller.valIsNullorEmpty(""));
            Assert.AreEqual(false, controller.valIsNullorEmpty("null"));
        }
    }
}
