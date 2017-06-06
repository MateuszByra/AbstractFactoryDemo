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
        private string FirstName { get; set; }
        private string LastName{ get; set; }

        private IContactInfo PrimaryContact { get; set; }
        private IList<IContactInfo> Contacts { get; } = new List<IContactInfo>();

        public static IFirstNameHolder Person()=> new PersonBuilder();

        public ILastNameHolder WithFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException();
            this.FirstName = firstName;
            return this;
        }

        public IPrimaryContactHolder WithLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException();
            this.LastName = lastName;
            return this;
        }

        public IContactHolder WithSecondaryContact(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            if (Contacts.Contains(contact))
                throw new ArgumentException();

            Contacts.Add(contact);
            return this;
        }

        public IContactHolder WithPrimaryContact(IContactInfo contact)
        {
            this.WithSecondaryContact(contact);
            this.PrimaryContact = contact;
            return this;
        }

        public IPersonBuilder AndNoMoreContacts()
        {
            return this;
        }

        public Models.Person Build()
        {
            var person = new Models.Person(this.FirstName, this.LastName);

            foreach(var contact in Contacts)
            {
                person.Add(contact);
            }

            person.SetPrimaryContact(PrimaryContactState.Get());
            return person;
        }
    }
}
