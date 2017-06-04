using BuilderDemo.Builders.Person;
using BuilderDemo.Interfaces;
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

            IContactInfo email = new EmailAddress("mat.byra@gmail.com");
            builder.Add(email);
            builder.Add(new EmailAddress("mat.byra2@gmail.com"));
            builder.SetPrimaryContact(email);

            Person person = builder.Build();
            Console.WriteLine(person);
        }

        static void Main(string[] args)
        {
            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
