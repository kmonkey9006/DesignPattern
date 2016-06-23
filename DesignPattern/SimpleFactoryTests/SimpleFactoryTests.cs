using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SimpleFactory.Tests
{
    [TestClass()]
    public class SimpleFactoryTests
    {
        [TestMethod()]
        public void CreateFactoryTest()
        {
            var oper = SimpleFactory.CreateFactory("+");
            oper.NumberA = 1;
            oper.NumberA = 1;
            Assert.AreSame(2, oper.GetResult());
        }
    }
}
