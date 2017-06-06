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
                PersonBuilder
                .Person()
                .WithFirstName("Mateusz")
                .WithLastName("Byra")
                .WithPrimaryContact(new EmailAddress("mat.byra@gmail.com"))
                .WithSecondaryContact(new EmailAddress("mat.byra@wp.pl"))
                .AndNoMoreContacts()
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
