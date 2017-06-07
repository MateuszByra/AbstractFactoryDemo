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
        : IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder, ISecondaryContactHolder, IPersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }

        private IContactInfo PrimaryContact { get; set; }
        private IList<IContactInfo> Contacts { get; set; } = new List<IContactInfo>();

        public static IFirstNameHolder Person() => new PersonBuilder();

        public ILastNameHolder WithFirstName(string firstName) =>
            new PersonBuilder()
            {
                FirstName = firstName
            };

        public bool IsValidFirstName(string firstName) => !string.IsNullOrEmpty(firstName);

        public IPrimaryContactHolder WithLastName(string lastName) =>
            new PersonBuilder()
            {
                FirstName = this.FirstName,
                LastName = lastName
            };

        public bool IsValidLastName(string surname) => !string.IsNullOrEmpty(surname);

        public ISecondaryContactHolder WithSecondaryContact(IContactInfo contact) =>
       new PersonBuilder()
       {
           FirstName = this.FirstName,
           LastName = this.LastName,
           Contacts = new List<IContactInfo>(this.Contacts) { contact },
           PrimaryContact = this.PrimaryContact
       };

        public ISecondaryContactHolder WithPrimaryContact(IContactInfo contact) =>
         new PersonBuilder()
         {
             FirstName = this.FirstName,
             LastName = this.LastName,
             Contacts = new List<IContactInfo>(this.Contacts) { contact },
             PrimaryContact = contact
         };

        public IPersonBuilder AndNoMoreContacts() => this;

        public bool Contains(IContactInfo contact) => this.Contacts.Contains(contact);

        public Models.Person Build()
        {
            var person = new Models.Person();
            person.Name = this.FirstName;
            person.Surname = this.LastName;

            foreach (var contact in Contacts)
            {
                person.ContactsList.Add(contact);
            }

            person.PrimaryContact=this.PrimaryContact;
            return person;
        }

    }
}
