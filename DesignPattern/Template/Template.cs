using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Template
    {
        public abstract string PrimitiveOperation1();
        public abstract string PrimitiveOperation2();

        public string TemplateMethod()
        {
            string str = "具体类";
            str = PrimitiveOperation1();
            str += PrimitiveOperation2();
            str += "的实现方法";
            return str;
        }
    }

    public class ConcreteClassA : Template
    {
        public override string PrimitiveOperation1()
        {
            return "A1";
        }
        public override string PrimitiveOperation2()
        {
            return "A2";
        }
    }

    public class ConcreteClassB : Template
    {
        public override string PrimitiveOperation1()
        {
            return "B1";
        }
        public override string PrimitiveOperation2()
        {
            return "B2";
        }
    }
}
