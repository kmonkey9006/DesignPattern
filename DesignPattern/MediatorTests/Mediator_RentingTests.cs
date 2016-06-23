using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Mediator.Tests
{
    [TestClass()]
    public class Mediator_RentingTests
    {
        [TestMethod()]
        public void NoticeTest()
        {
            Mediator_Intelligence mediator = new Mediator_Intelligence();

            Renter Intelligence = new Renter(mediator);
            Landlord user = new Landlord(mediator);

            mediator.renter = Intelligence;
            mediator.landlord = user;

           Intelligence.Notice("带空调、独卫和阳台的25平米的房间多少钱？");
           user.Notice("800元每月，水费15元，物业费15元，电费0.8元每度.");
            Assert.AreEqual(1,1);
        }
    }
}
