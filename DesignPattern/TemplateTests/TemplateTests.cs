using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Template.Tests
{
    [TestClass()]
    public class TemplateTests
    {
        [TestMethod()]

        public void TemplateTest()
        {
            Template c;
            c = new ConcreteClassA();
            Assert.AreEqual("具体类A1A2的实现方法", c.TemplateMethod());
            c = new ConcreteClassB();
            Assert.AreEqual("具体类B1B2的实现方法", c.TemplateMethod());
            Console.Read();
        }
    }
}
