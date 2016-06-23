using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    /// <summary>
    /// 提供了一个MemberwiseClone()方法用于实现浅克隆
    /// 该方法使用起来很方便
    /// 直接调用一个已有对象的MemberwiseClone()方法即可实现克隆
    /// </summary>
   public class PrototypeMemberwise_Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;

        private WorkExperience work;

        public PrototypeMemberwise_Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        //设置个人信息
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }
        //设置工作经历
        public void SetWorkExperience(string workDate, string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        //显示
        public string Display()
        {
           string str=string.Format("{0} {1} {2}", name, sex, age);
         str =str+ string.Format("工作经历：{0} {1}", work.WorkDate, work.Company);
         return str;
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }

    }

    //工作经历
    class WorkExperience
    {
        private string workDate;
        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }
        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
    }
}
