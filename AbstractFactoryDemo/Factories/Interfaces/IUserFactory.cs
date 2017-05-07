using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Factories.Interfaces
{
    public interface IUserFactory
    {
        IUser CreateUser();
        IUserIdentity CreateIdentity()
    }
}
