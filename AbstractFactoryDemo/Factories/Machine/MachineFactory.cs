using AbstractFactoryDemo.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Interfaces;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories.Machine
{
    public class MachineFactory : IUserFactory
    {
        public IUser CreateUser()
        {
            return new Models.Machine();
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
