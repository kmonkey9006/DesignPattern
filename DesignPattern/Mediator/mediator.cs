using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    public abstract class Mediator_Renting
    {
        public abstract string Notice(string message, House house);
    }
    public abstract class House
    {
        protected Mediator_Renting mediator;

        public House(Mediator_Renting rentingMediator)
        {
            this.mediator = rentingMediator;
        }

        public abstract string GetMessage(string message);
    }
    public class Renter : House
    {
        public Renter(Mediator_Renting mediator)
            : base(mediator)
        { }
        public string Notice(string message)
        {
            return mediator.Notice(message, this);
        }
        public override string GetMessage(string message)
        {
            return string.Format("租房者接收消息:{0}\n", message);
        }
    }
    public class Landlord : House
    {
        public Landlord(Mediator_Renting mediator)
            : base(mediator)
        { }

        public string Notice(string message)
        {
            return mediator.Notice(message, this);
        }
        public override string GetMessage(string message)
        {
            return string.Format("房东接收消息:{0}\n", message);
        }
    }
    public class Mediator_Intelligence : Mediator_Renting
    {
        private Renter _renter;
        private Landlord _landlord;

        public Renter renter
        {
            set { _renter = value; }
            get { return _renter; }
        }

        public Landlord landlord
        {
            set { _landlord = value; }
            get { return _landlord; }
        }

        public override string Notice(string message, House house)
        {
            if (house == renter)
            {
                return landlord.GetMessage(message);
            }
            else
            {
                return renter.GetMessage(message);
            }
        }
    }
}
