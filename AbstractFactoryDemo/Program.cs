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
        static void ConfigureUser()
        {
            IUserFactory factory = new PersonFactory();

            IUser user = factory.CreateUser("Mateusz", "Byra");

            IUserIdentity id = factory.CreateIdentity();
            user.SetIdentity(id);
        }

        static void Main(string[] args)
        {
            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
