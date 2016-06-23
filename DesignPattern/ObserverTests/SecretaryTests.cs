using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Observer.Tests
{
    [TestClass()]
    public class SecretaryTests
    {
        [TestMethod()]
        public void NotifyTest()
        {

            //老板胡汉三
            Boss boss = new Boss();

            //看股票的同事
            QQObserver tongshi1 = new QQObserver("王延领", boss);
            //看NBA的同事
            NBAObserver tongshi2 = new NBAObserver("胡云峰", boss);

            boss.Update += new EventHandler(tongshi1.CloseQQMarket);
            boss.Update += new EventHandler(tongshi2.CloseNBADirectSeeding);

            //老板回来
            boss.SubjectState = "我胡汉三回来了！";
            //发出通知
            boss.Notify();
        }
    }
}
