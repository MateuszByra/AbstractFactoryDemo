using AbstractFactoryDemo.Factories.Interfaces;
using AbstractFactoryDemo.Factories.Person;
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
            IUserFactory factory = new PersonFactory();

            IUser user = factory.CreateUser("Mateusz", "Byra");

            IUserIdentity id = factory.CreateIdentity(); // new MacAddress(); break the substitution principle
            user.SetIdentity(id);

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
