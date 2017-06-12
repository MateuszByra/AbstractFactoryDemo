﻿using SpecificationDemo.Interfaces;
using SpecificationDemo.Models;
using SpecificationDemo.Validation;
using SpecificationDemo.Validation.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDemo
{
    class Program
    {
        static void DoSomethingWith(Person person,Specification<Person> validator)
        {
            if (!validator.IsSatisfiedBy(person))
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
            DoSomethingWith(person,
               new Composite<Person>((results) => results.All(res => res == true),
                Spec<Person>.NotNull(p => p.Name)
                .And(Spec<Person>.NotNull(p => p.Surname))
                .And(
                    Spec<Person>.Null(p => p.PrimaryContact)
                    .Or(Spec<Person>.IsTrue(p => p.Contacts.Contains(p.PrimaryContact))))));

            Console.WriteLine("SAVING TO DATABASE:");
            DoSomethingWith(person,
                Spec<Person>.NonEmptyString(p => p.Name)
                .And(Spec<Person>.NonEmptyString(p => p.Surname))
                .And(Spec<Person>.NotNull(p => p.Contacts))
                .And(Spec<Person>.IsTrue(p => p.Contacts.Contains(p.PrimaryContact))));

            //Builder with specification
            /*IUser user =
                UserSpecification
                    .ForPerson()
                    .WithName("Mateusz")
                    .WithSurname("Planck")
                    .WithPrimaryContact(
                        ContactSpecification
                            .ForEmailAddress("mat.byra@gmail.com"))
                    .WithAlternateContact(
                        ContactSpecification
                            .ForPhoneNumber()
                            .WithCountryCode(1)
                            .WithAreaCode(23)
                            .WithNumber(456789))
                     .AndNoMoreContacts()
                     .Build();*/

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
