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
                MachineBuilder
                    .Machine()
                    .WithProducer(new Producer())
                    .WithModel("fast-one")
                    .OwnedBy(
                        new LegalEntity(
                            "Big Co.",
                            new EmailAddress("big@co"),
                            new PhoneNumber(123, 45, 6789)))
                            .Build;

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
