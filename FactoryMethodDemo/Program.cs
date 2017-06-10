using FactoryMethodDemo.Builders.Machine;
using FactoryMethodDemo.Builders.Person;
using FactoryMethodDemo.Factories;
using FactoryMethodDemo.Interfaces;
using FactoryMethodDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    class Program
    {
        static void ConfigureUser()
        {
            PersonalManager mgr = new PersonalManager(UserFactories.MachineFactory);
            mgr.Notify("hello");
        }

        static void Main(string[] args)
        {
            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadKey();
        }
    }
}
