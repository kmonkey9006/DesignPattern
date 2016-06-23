using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    ///   ICloneable接口充当了抽象原型类的角色
    ///   具体原型类通常作为实现该接口的子类
    /// </summary>
    public class PrototypeICloneable_Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;

        private WorkExperience work;

        public PrototypeICloneable_Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        private PrototypeICloneable_Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
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
            string str = string.Format("{0} {1} {2}", name, sex, age);
            str = string.Format("工作经历：{0} {1}", work.WorkDate, work.Company);
            return str;
        }

        public Object Clone()
        {
            PrototypeICloneable_Resume obj = new PrototypeICloneable_Resume(this.work);

            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;


            return obj;
        }

    }

    //工作经历
    class WorkExperience : ICloneable
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

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }


}
