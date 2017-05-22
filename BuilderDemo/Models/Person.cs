using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    public class Person : IUser
    {
        private string name { get; set; }
        private string surname { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public void SetIdentity(IUserIdentity identity)
        {
            if(!CanAcceptIdentity(identity))
                throw new ArgumentException();

            IdentityCard idCard = identity as IdentityCard;

            Console.WriteLine("Accepted person identity card");
            // do somethind with idCard
        }

        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is IdentityCard;
    }
}
