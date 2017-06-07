using BuilderDemo.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDemo.Interfaces;
using BuilderDemo.Models;

namespace BuilderDemo.Factories.Person
{
    public class PersonFactory : IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            return new Models.Person() { Name = name1, Surname = name2 };
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
