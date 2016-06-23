using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Prototype.Tests
{
    [TestClass()]
    public class PrototypeTests
    {
        [TestMethod()]
        public void PrototypeTest()
        {
            PrototypeICloneable_Resume a = new PrototypeICloneable_Resume("王延领");
            a.SetPersonalInfo("男", "26");
            a.SetWorkExperience("2011-2013", "XX公司");

            PrototypeICloneable_Resume b = (PrototypeICloneable_Resume)a.Clone();
            b.SetWorkExperience("2013-2016", "YY企业");

            PrototypeICloneable_Resume c = (PrototypeICloneable_Resume)a.Clone();
            c.SetWorkExperience("2016-至今", "ZZ企业");
            Assert.Fail("王延领 男 26工作经历：2011-2013 XX公司", a.Display());
            Assert.Fail("王延领 男 26工作经历：2013-2016 YY公司", b.Display());
            Assert.Fail("王延领 男 26工作经历：2016-至今 ZZ公司", c.Display());
        }
    }
}
