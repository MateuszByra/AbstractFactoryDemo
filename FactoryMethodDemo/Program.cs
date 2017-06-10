using FactoryMethodDemo.Builders.Person;
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
            PersonalManager mgr = new PersonalManager(
                PersonBuilder
                    .Person()
                    .WithFirstName("Mateusz")
                    .WithLastName("Byra")
                    .WithPrimaryContact(new EmailAddress("mat.byra@gmail.com"))
                    .WithSecondaryContact(new EmailAddress("mat.byra@wp.pl"))
                    .AndNoMoreContacts()
                    .Build
            );
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
