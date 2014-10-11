using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class HelloWorldTests
    {
        [Test]
        public void Test()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
