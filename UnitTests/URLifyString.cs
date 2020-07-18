using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsTests
{
    [TestClass]
    public class URLifiedStringUnitTest
    {
        [TestMethod]
        public void URLifiedString()
        {
            Assert.AreEqual("Hello%20World", Problems.URLifyString.URLify("Hello World     ", 11));
            Assert.AreEqual("%20H%20e%20l%20l%20o%20W%20o%20r%20l%20d", Problems.URLifyString.URLify(" H e l l o W o r l d     ", 20));
            Assert.AreEqual("%20H%20e%20l%20l%20o%20W%20o%20r%20l%20d%20", Problems.URLifyString.URLify(" H e l l o W o r l d     ", 21));
            Assert.AreEqual("%20Hello%20World", Problems.URLifyString.URLify(" Hello World     ", 12));
            Assert.AreEqual("%20%20%20%20Hello%20World", Problems.URLifyString.URLify("    Hello World     ", 15));

        }
    }
}