using BuilderDemo.Builders.Person;
using BuilderDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class Program
    {
        static void ConfigureUser()
        {
            PersonBuilder builder = new PersonBuilder();

            builder.SetFirstName("Mateusz");
            builder.SetLastName("Byra");

            Person person = builder.Build();
        }

        static void Main(string[] args)
        {
            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
