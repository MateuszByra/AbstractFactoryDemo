using SpecificationDemo.Interfaces;
using SpecificationDemo.Models;
using SpecificationDemo.Specifications;
using SpecificationDemo.Specifications.ContactInfo;
using SpecificationDemo.Specifications.LegalEntity;
using SpecificationDemo.Specifications.Producer;
using SpecificationDemo.Specifications.User;
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
            //Person person = new Person()
            //{
            //    Name = "Mateusz",
            //    Surname = "Byra"
            //};

            //Console.WriteLine("DISPLAYING IN USER INTERFACE");
            //DoSomethingWith(person,
            //   new Composite<Person>((results) => results.All(res => res == true),
            //    Spec<Person>.NotNull(p => p.Name)
            //    .And(Spec<Person>.NotNull(p => p.Surname))
            //    .And(
            //        Spec<Person>.Null(p => p.PrimaryContact)
            //        .Or(Spec<Person>.IsTrue(p => p.Contacts.Contains(p.PrimaryContact))))));

            //Console.WriteLine("SAVING TO DATABASE:");
            //DoSomethingWith(person,
            //    Spec<Person>.NonEmptyString(p => p.Name)
            //    .And(Spec<Person>.NonEmptyString(p => p.Surname))
            //    .And(Spec<Person>.NotNull(p => p.Contacts))
            //    .And(Spec<Person>.IsTrue(p => p.Contacts.Contains(p.PrimaryContact))));

            var user = GetPersonWithMultipleTheSameAdresses();

            Console.WriteLine(user);
            Console.WriteLine();
            Console.ReadLine();
        }
        

        private static IUser GetMachine()
        {
            //Builder with specification
            IUser user =
                UserSpecification
                    .ForMachine()
                    .ProducedBy(
                        ProducerSpecification
                            .WithName("Big Co."))
                     .WithModel("Shiny one")
                     .OwnedBy(
                        LegalEntitySpecification
                            .Initialize()
                            .WithCompanyName("Properties Co.")
                            .WithEmailAddress(
                                ContactSpecification.ForEmailAddress("one@prop"))
                             .WithPhoneNumber(
                                ContactSpecification
                                    .ForPhoneNumber()
                                    .WithCountryCode(1)
                                    .WithAreaCode(23)
                                    .WithNumber(456))
                              .WithOtherContact(
                                 ContactSpecification.ForEmailAddress("two@prop"))
                               .AndNoMoreContacts())
                       .Build();

            return user;
        }

        private static IUser GetPerson()
        {
            //Builder with specification
            IUser user =
               UserSpecification
                   .ForPerson()
                   .WithName("Mateusz")
                   .WithSurname("Byra")
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
                    .Build();
            return user;
        }


        private static IUser GetPersonWithMultipleTheSameAdresses()
        {
            //Builder with specification
            IUser user =
               UserSpecification
                   .ForPerson()
                   .WithName("Mateusz")
                   .WithSurname("Byra")
                   .WithPrimaryContact(
                       ContactSpecification
                           .ForEmailAddress("mat.byra@gmail.com"))
                   .WithAlternateContact(
                       ContactSpecification
                            .ForEmailAddress("mat.byra@gmail.com"))
                    .AndNoMoreContacts()
                    .Build();
            return user;
        }
    }
}
