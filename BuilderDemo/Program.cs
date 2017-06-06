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
            Person person =
                new PersonBuilder()
                .SetFirstName("Mateusz")
                .SetLastName("Byra")
                .SetPrimaryContact(new EmailAddress("mat.byra@gmail.com"))
                .Add(new EmailAddress("mat.byra@wp.pl"))
                .NoMoreContacts()
                .Build();
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
