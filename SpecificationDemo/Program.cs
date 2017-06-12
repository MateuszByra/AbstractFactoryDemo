using SpecificationDemo.Interfaces;
using SpecificationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo
{
    class Program
    {
        static void DoSomethingWith(Person person,Func<Person,bool> predicate)
        {
            if (!predicate(person))
            {
                Console.WriteLine("Not applicable...");
                return;
            }

            Console.WriteLine("   Name: {0}", person.Name);
            Console.WriteLine("Surname: {0}", person.Surname);

            Console.WriteLine("Contacts:");
            foreach(IContactInfo contact in person.Contacts)
                Console.WriteLine("     {0}{1}", contact==person.PrimaryContact?"*" : " ", contact);

            Console.WriteLine(new string ('-',20));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Mateusz",
                Surname = "Byra"
            };

            Console.WriteLine("DISPLAYING IN USER INTERFACE");
            DoSomethingWith(person, (p) =>
             p.Name != null &&
             p.Surname != null &&
             p.Contacts != null &&
             (
                 p.PrimaryContact == null ||
                 p.Contacts.Contains(p.PrimaryContact)
             ));

            Console.WriteLine("SAVING TO DATABASE:");
            DoSomethingWith(person, (p) =>
            !string.IsNullOrEmpty(p.Name) &&
            !string.IsNullOrEmpty(p.Surname) &&
            p.Contacts != null &&
            p.PrimaryContact != null &&
            p.Contacts.Contains(p.PrimaryContact));

            Console.ReadLine();
        }
    }
}
