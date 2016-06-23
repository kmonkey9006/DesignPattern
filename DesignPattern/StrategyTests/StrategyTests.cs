using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Strategy.Tests
{
    [TestClass()]
    public class ContentTests
    {
        [TestMethod()]
        public void ContentTest()
        {
            //备注 由于实例化不同的策略，所以最终在调用 
            //content.ContentInterface() 时，所获得的结果就不尽相同
            Content content;
            content = new Content(new ConcreteStrategyA());
            Assert.AreEqual("算法实现A", content.ContentInterface());

            content = new Content(new ConcreteStrategyB());
            Assert.AreEqual("算法实现B", content.ContentInterface());

            content = new Content(new ConcreteStrategyC());
            Assert.AreEqual("算法实现C", content.ContentInterface());
        }

    }
}
