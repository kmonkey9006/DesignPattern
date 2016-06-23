using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Memento.Tests
{
    [TestClass()]
    public class DocumentTests
    {
        [TestMethod()]
        public void CreateMementoTest()
        {
            // 创建原始类  
            Original origi = new Original("wyl");

            // 创建备忘录  
            Storage storage = new Storage(origi.createMemento());

            // 修改原始类的状态  
            string str = "初始化状态为：" + origi.getValue();
            Assert.AreEqual("wyl", origi.getValue());
            origi.setValue("lyw");
            str = "修改后的状态为：" + origi.getValue();
            Assert.AreEqual("wyl", origi.getValue());
            // 回复原始类的状态  
            origi.restoreMemento(storage.getMemento());
            str = "恢复后的状态为：" + origi.getValue();
            Assert.AreEqual("wyl", origi.getValue());
         
        }

    }
}
