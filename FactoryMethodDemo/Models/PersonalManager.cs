using FactoryMethodDemo.Interfaces;
using System;

namespace FactoryMethodDemo.Models
{
    public class PersonalManager
    {
        public PersonalManager(Func<IUser> userFactory)
        {
            this.UserFactory = userFactory;

        }

        public void Notify(string message)
        {
            this.Enqueue(this.GetPrimaryContact(), message);
        }

        private Func<IUser> UserFactory { get; }

        private IContactInfo GetPrimaryContact()
        {
            return this.UserFactory().PrimaryContact;
        }

        private void Enqueue(IContactInfo contact ,string message)
        {
            Console.WriteLine($"Sendind '{message}' to {contact}");
        }
    }
}
