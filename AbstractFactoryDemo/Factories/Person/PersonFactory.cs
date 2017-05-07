using AbstractFactoryDemo.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories.Person
{
    public class PersonFactory : IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            return new Models.Person(name1, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
