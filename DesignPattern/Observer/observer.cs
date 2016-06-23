using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    //通知者接口
    public interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }

    //事件处理程序的委托
    public delegate string EventHandler();

    public class Secretary : Subject
    {
        //声明一事件Update，类型为委托EventHandler
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }

    public class Boss : Subject
    {
        //声明一事件Update，类型为委托EventHandler
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }

    //聊的同事
    public class QQObserver
    {
        private string name;
        private Subject sub;
        public QQObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        //关闭股票行情
        public string CloseQQMarket()
        {
            string str = string.Format("{0} {1} 关闭股票行情，继续工作！", sub.SubjectState, name);
            return str;
        }
    }

    //看NBA的同事
    public class NBAObserver
    {
        private string name;
        private Subject sub;
        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        //关闭NBA直播
        public string CloseNBADirectSeeding()
        {
            string str = string.Format("{0} {1} 关闭NBA直播，继续工作！", sub.SubjectState, name);
            return str;
        }
    }
}