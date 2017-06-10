using FactoryMethodDemo.Interfaces;
using FactoryMethodDemo.Builders.Person;

namespace FactoryMethodDemo.Models
{
    public class HumanPersonalManager : PersonalManager
    {
        protected override IUser CreateUser()
        {
            return
                PersonBuilder
                .Person()
                .WithFirstName("Mateusz")
                .WithLastName("Byra")
                .WithPrimaryContact(new EmailAddress("mat.byra@gmail.com"))
                .WithSecondaryContact(new EmailAddress("mat.byra@wp.pl"))
                .AndNoMoreContacts()
                .Build();

        }
    }
}
