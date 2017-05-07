using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void RegisterUser(IUserFactory userFactory)
        {
            //ITicketHolder holder = userFactory.CreateUser();
        }

        static void Main(string[] args)
        {
        }
    }
}
