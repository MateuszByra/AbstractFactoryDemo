using BuilderDemo.Builders.Person.Interfaces;
using BuilderDemo.Common;
using BuilderDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builders.Person
{
    public class PersonBuilder
        : IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder, IContactHolder, IPersonBuilder
    {
        private INonEmptyStringState FirstNameState { get; set; } = new UninitializedString();
        private INonEmptyStringState LastNameState { get; set; } = new UninitializedString();

        private IPrimaryContactState PrimaryContactState { get; set; }
        private IList<IContactInfo> Contacts { get; }

        public PersonBuilder()
        {
            this.Contacts = new List<IContactInfo>();
            this.PrimaryContactState = new UninitializedPrimaryContact(this.Contacts.Contains);
        }

        public ILastNameHolder SetFirstName(string firstName)
        {
            this.FirstNameState = FirstNameState.Set(firstName);
            return this;
        }

        public IPrimaryContactHolder SetLastName(string lastName)
        {
            this.LastNameState = LastNameState.Set(lastName);
            return this;
        }

        public IContactHolder Add(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            if (Contacts.Contains(contact))
                throw new ArgumentException();

            Contacts.Add(contact);
            return this;
        }

        public IContactHolder SetPrimaryContact(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            this.Add(contact);
            this.PrimaryContactState = PrimaryContactState.Set(contact);
            return this;
        }

        public IPersonBuilder NoMoreContacts()
        {
            return this;
        }

        public Models.Person Build()
        {
            var person = new Models.Person(this.FirstNameState.Get(), this.LastNameState.Get());

            foreach(var contact in Contacts)
            {
                person.Add(contact);
            }

            person.SetPrimaryContact(PrimaryContactState.Get());
            return person;
        }
    }
}
