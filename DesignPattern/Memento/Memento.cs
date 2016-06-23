using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    /// <summary>
    /// 原始类
    /// </summary>
    public class Original
    {

        private String value;

        public String getValue()
        {
            return value;
        }

        public void setValue(String value)
        {
            this.value = value;
        }

        public Original(String value)
        {
            this.value = value;
        }

        public Memento createMemento()
        {
            return new Memento(value);
        }

        public void restoreMemento(Memento memento)
        {
            this.value = memento.getValue();
        }
    }
    public class Memento
    {

        private String value;

        public Memento(String value)
        {
            this.value = value;
        }

        public String getValue()
        {
            return value;
        }

        public void setValue(String value)
        {
            this.value = value;
        }
    }
    public class Storage
    {

        private Memento memento;

        public Storage(Memento memento)
        {
            this.memento = memento;
        }

        public Memento getMemento()
        {
            return memento;
        }

        public void setMemento(Memento memento)
        {
            this.memento = memento;
        }
    }  
}
