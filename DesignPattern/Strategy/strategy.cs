using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //抽像算法类
    public abstract class Streategy
    {
        //算法方法
        public abstract string AlgorithmInterface();
    }
    //ConcreteStrategy ，封装了具体的算法或行为  继承于Streategy

    /// <summary>
    /// 具体算法A
    /// </summary>
    public class ConcreteStrategyA : Streategy
    {
        //算法实现
        public override string AlgorithmInterface()
        {
            return "算法实现A";
        }
    }
    /// <summary>
    ///  具体算法A
    /// </summary>
    public class ConcreteStrategyB : Streategy
    {
        public override string AlgorithmInterface()
        {
            return "算法实现B";
        }
    }
    /// <summary>
    /// 具体实现方法C
    /// </summary>
    public class ConcreteStrategyC : Streategy
    {
        public override string AlgorithmInterface()
        {
            return "算法实现C";
        }
    }
    /// <summary>
    /// Content，用一个ConcreteStrategy 类来配置，维护对Strategy对象的引用
    /// </summary>
    public class Content
    {
        private Streategy streategy;

        //在初使化时。传入具体的策略对象
        public Content(Streategy streategy)
        {
            this.streategy = streategy;
        }
        //上下文接口   ----根据具体的策略对象。调用其算法与方法
        public string ContentInterface()
        {
            return streategy.AlgorithmInterface();
        }
    }
}
