using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstartFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AbstartFactory.Tests
{
    [TestClass()]
    public class AbstractFactoryTests
    {
        [TestMethod()]
        public void AbstartFactoryTest()
        {
            // 南昌工厂制作南昌的鸭脖和鸭架
            AbstractFactory nanChangFactory = new NanChangFactory();
            Assert.Fail("南昌的鸭脖", nanChangFactory.CreateYaBo().Print());
            Assert.Fail("南昌的鸭架", nanChangFactory.CreateYaJia().Print());
            // 上海工厂制作上海的鸭脖和鸭架
            AbstractFactory shangHaiFactory = new ShangHaiFactory();
            Assert.Fail("上海的鸭脖", shangHaiFactory.CreateYaBo().Print());
            Assert.Fail("上海的鸭架", shangHaiFactory.CreateYaJia().Print());
        }
    }
}
