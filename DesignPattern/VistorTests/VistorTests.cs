using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Vistor.Tests
{
    [TestClass()]
    public class SuccessTests
    {
        [TestMethod()]
        public void VistorTest()
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());

            Success v1 = new Success();
            o.Display(v1);

            Failing v2 = new Failing();
            o.Display(v2);

            Amativeness v3 = new Amativeness();
            o.Display(v3);

            Marriage v4 = new Marriage();
            o.Display(v4);
        }

       
    }
}
