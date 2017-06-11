using FactoryMethodDemo.Builders.Machine;
using FactoryMethodDemo.Builders.Person;
using FactoryMethodDemo.Interfaces;
using FactoryMethodDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Factories
{
    public static class UserFactories
    {
        public static Func<IUser> MachineFactory =>
            CreateMachineFactory(CreateLegalEntity);
             

        private static Func<IUser> CreateMachineFactory(Func<LegalEntity> ownerFactory) =>
               MachineBuilder
                    .Machine()
                    .WithProducer(new Producer())
                    .WithModel("fast-one")
                    .OwnedBy(ownerFactory())
                    .Build;

        private static Func<LegalEntity> CreateLegalEntityFactory(Func<EmailAddress> emailAddressFactory) =>
           ()=> new LegalEntity(
                  "Big Co.",
                  emailAddressFactory(),
                  new PhoneNumber(123, 45, 6789));

        private static Func<LegalEntity> CreateLegalEntity =>
            CreateLegalEntityFactory(() => new Models.EmailAddress("big@co"));

        public static Func<IUser> PersonFactory =>
                PersonBuilder
                    .Person()
                    .WithFirstName("Mateusz")
                    .WithLastName("Byra")
                    .WithPrimaryContact(new EmailAddress("mat.byra@gmail.com"))
                    .WithSecondaryContact(new EmailAddress("mat.byra@wp.pl"))
                    .AndNoMoreContacts()
                    .Build;

    }
}
