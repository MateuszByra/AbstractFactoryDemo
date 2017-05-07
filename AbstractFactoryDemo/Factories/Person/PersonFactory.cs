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
        public IUser CreateUser()
        {
            return new Models.Person();
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
