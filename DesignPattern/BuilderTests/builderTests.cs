using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Builder.Tests
{
    [TestClass()]
    public class builderTests
    {
        [TestMethod()]
        public void ConstructTest()
        {
            Director director = new Director();
            IBuilder b1 = new ConcreteBuilder1();
            IBuilder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            Assert.AreEqual("部件A部件B", p1.Show());

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            Assert.AreEqual("部件X部件Y", p2.Show());
        }
    }
}
