using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    public class ConcreteBuilder1 : IBuilder
    {
        private Product product = new Product();

        public  void BuildPartA()
        {
            product.Add("部件A");
        }

        public  void BuildPartB()
        {
            product.Add("部件B");
        }

        public  Product GetResult()
        {
            return product;
        }
    }

    public class ConcreteBuilder2 : IBuilder
    {
        private Product product = new Product();
        public  void BuildPartA()
        {
            product.Add("部件X");
        }

        public  void BuildPartB()
        {
            product.Add("部件Y");
        }

        public  Product GetResult()
        {
            return product;
        }
    }

    public class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public string Show()
        {
            string str = string.Empty;
            foreach (string part in parts)
            {
                str = str + part;
            }
            return str;
        }
    }
}
