using FactoryMethodDemo.Interfaces;
using System;

namespace FactoryMethodDemo.Models
{
    public abstract class PersonalManager
    {
        public void Notify(string message)
        {
            this.Enqueue(this.GetPrimaryContact(), message);
        }

        protected abstract IUser CreateUser();

        private IContactInfo GetPrimaryContact()
        {
            return this.CreateUser().PrimaryContact;
        }

        private void Enqueue(IContactInfo contact ,string message)
        {
            Console.WriteLine($"Sendind '{message}' to {contact}");
        }
    }
}
